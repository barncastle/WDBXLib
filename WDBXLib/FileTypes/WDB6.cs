﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using WDBXLib.Attributes;
using WDBXLib.Common;
using WDBXLib.Extensions;
using WDBXLib.Helpers;
using WDBXLib.Storage;
using static WDBXLib.Common.Constants;

namespace WDBXLib.Reader.FileTypes
{
    class WDB6 : WDB5
    {
        public uint RawRecordSize { get; private set; }

        #region Read
        public override void ReadHeader(ref BinaryReader dbReader, string signature)
        {
            ReadBaseHeader(ref dbReader, signature);

            TableHash = dbReader.ReadInt32();
            LayoutHash = dbReader.ReadInt32();
            MinId = dbReader.ReadInt32();
            MaxId = dbReader.ReadInt32();
            Locale = dbReader.ReadInt32();
            CopyTableSize = dbReader.ReadInt32();
            Flags = (HeaderFlags)dbReader.ReadUInt16();
            IdIndex = dbReader.ReadUInt16();
            TotalFieldSize = dbReader.ReadUInt32();
            CommonDataTableSize = dbReader.ReadUInt32();

            if (Flags.HasFlag(HeaderFlags.IndexMap))
                IdIndex = 0; //Ignored if Index Table    

            RawRecordSize = RecordSize; //RecordSize header field is not right anymore

            //Gather field structures
            FieldStructure = new List<FieldStructureEntry>();
            for (int i = 0; i < FieldCount; i++)
            {
                var field = new FieldStructureEntry(dbReader.ReadInt16(), (ushort)(dbReader.ReadUInt16() + (HasIndexTable ? 4 : 0)));
                FieldStructure.Add(field);

                if (i > 0)
                    FieldStructure[i - 1].SetLength(field);
            }

            if (HasIndexTable)
            {
                FieldCount++;
                FieldStructure.Insert(0, new FieldStructureEntry(0, 0));

                if (FieldCount > 1)
                    FieldStructure[1].SetLength(FieldStructure[0]);
            }
        }

        public new Dictionary<int, byte[]> ReadOffsetData(BinaryReader dbReader, long pos, uint build)
        {
            Dictionary<int, byte[]> CopyTable = new Dictionary<int, byte[]>();
            List<Tuple<int, short>> offsetmap = new List<Tuple<int, short>>();
            Dictionary<int, OffsetDuplicate> firstindex = new Dictionary<int, OffsetDuplicate>();

            long commonDataTablePos = dbReader.BaseStream.Length - CommonDataTableSize;
            long copyTablePos = commonDataTablePos - CopyTableSize;
            long indexTablePos = copyTablePos - (HasIndexTable ? RecordCount * 4 : 0);
            int[] m_indexes = null;

            //Offset Map
            if (HasOffsetTable)
            {
                // Records table
                dbReader.Scrub(StringBlockSize);

                for (int i = 0; i < (MaxId - MinId + 1); i++)
                {
                    int offset = dbReader.ReadInt32();
                    short length = dbReader.ReadInt16();

                    if (offset == 0 || length == 0) continue;

                    //Special case, may contain duplicates in the offset map that we don't want
                    if (CopyTableSize == 0)
                    {
                        if (!firstindex.ContainsKey(offset))
                            firstindex.Add(offset, new OffsetDuplicate(offsetmap.Count, firstindex.Count));
                        else
                            OffsetDuplicates.Add(MinId + i, firstindex[offset].VisibleIndex);
                    }

                    offsetmap.Add(new Tuple<int, short>(offset, length));
                }
            }

            //Index table
            if (HasIndexTable)
            {
                //Offset map alone reads straight into this others may not
                if (!HasOffsetTable || HasSecondIndex)
                    dbReader.Scrub(indexTablePos);

                m_indexes = new int[RecordCount];
                for (int i = 0; i < RecordCount; i++)
                    m_indexes[i] = dbReader.ReadInt32();
            }

            //Extract record data
            for (int i = 0; i < Math.Max(RecordCount, offsetmap.Count); i++)
            {
                if (HasOffsetTable)
                {
                    int id = m_indexes[Math.Min(CopyTable.Count, m_indexes.Length - 1)];
                    var map = offsetmap[i];

                    if (CopyTableSize == 0 && firstindex[map.Item1].HiddenIndex != i) //Ignore duplicates
                        continue;

                    dbReader.Scrub(map.Item1);

                    IEnumerable<byte> recordbytes = BitConverter.GetBytes(id)
                                                    .Concat(dbReader.ReadBytes(map.Item2));

                    CopyTable.Add(id, recordbytes.ToArray());
                }
                else
                {
                    dbReader.Scrub(pos + i * RecordSize);
                    byte[] recordbytes = dbReader.ReadBytes((int)RecordSize).ToArray();

                    if (HasIndexTable)
                    {
                        IEnumerable<byte> newrecordbytes = BitConverter.GetBytes(m_indexes[i]).Concat(recordbytes);
                        CopyTable.Add(m_indexes[i], newrecordbytes.ToArray());
                    }
                    else
                    {
                        int bytecount = FieldStructure[IdIndex].ByteCount;
                        int offset = FieldStructure[IdIndex].Offset;

                        int id = 0;
                        for (int j = 0; j < bytecount; j++)
                            id |= (recordbytes[offset + j] << (j * 8));

                        CopyTable.Add(id, recordbytes);
                    }
                }
            }

            //CopyTable
            if (CopyTableSize != 0 && copyTablePos != dbReader.BaseStream.Length)
            {
                dbReader.Scrub(copyTablePos);
                while (dbReader.BaseStream.Position != dbReader.BaseStream.Length)
                {
                    int id = dbReader.ReadInt32();
                    int idcopy = dbReader.ReadInt32();

                    byte[] copyRow = CopyTable[idcopy];
                    byte[] newRow = new byte[copyRow.Length];
                    Array.Copy(copyRow, newRow, newRow.Length);
                    Array.Copy(BitConverter.GetBytes(id), newRow, sizeof(int));

                    CopyTable.Add(id, newRow);
                }
            }

            //CommonDataTable
            if (CommonDataTableSize > 0)
            {
                dbReader.Scrub(commonDataTablePos);
                int columncount = dbReader.ReadInt32();

                var commondatalookup = new Dictionary<int, byte[]>[columncount];

                //Initial Data extraction
                for (int i = 0; i < columncount; i++)
                {
                    int count = dbReader.ReadInt32();
                    byte type = dbReader.ReadByte();
                    short bit = CommonDataBits[type];
                    int size = (32 - bit) >> 3;

                    commondatalookup[i] = new Dictionary<int, byte[]>();

                    //New field not defined in header
                    if (i > FieldStructure.Count - 1)
                    {
                        var offset = (ushort)((FieldStructure.Count == 0 ? 0 : FieldStructure[i - 1].Offset + FieldStructure[i - 1].ByteCount));
                        FieldStructure.Add(new FieldStructureEntry(bit, offset, type));

                        if (FieldStructure.Count > 1)
                            FieldStructure[i - 1].SetLength(FieldStructure[i]);
                    }

                    for (int x = 0; x < count; x++)
                    {
                        commondatalookup[i].Add(dbReader.ReadInt32(), dbReader.ReadBytes(size));

                        if (build == 0 || build > 24015)
                            dbReader.ReadBytes(4 - size);
                    }
                }

                var ids = CopyTable.Keys.ToArray();
                foreach (var id in ids)
                {
                    for (int i = 0; i < commondatalookup.Length; i++)
                    {
                        if (!FieldStructure[i].CommonDataColumn)
                            continue;

                        var col = commondatalookup[i];
                        var defaultValue = TableStructure?[i]?.GetAttribute<DBFieldAttribute>()?.DefaultValue.ToString();
                        defaultValue = string.IsNullOrEmpty(defaultValue) ? "0" : defaultValue;

                        var field = FieldStructure[i];
                        var zeroData = new byte[field.ByteCount];
                        if (defaultValue != "0")
                        {
                            switch (field.CommonDataType)
                            {
                                case 1:
                                    zeroData = BitConverter.GetBytes(ushort.Parse(defaultValue));
                                    break;
                                case 2:
                                    zeroData = new[] { byte.Parse(defaultValue) };
                                    break;
                                case 3:
                                    zeroData = BitConverter.GetBytes(float.Parse(defaultValue));
                                    break;
                                case 4:
                                    zeroData = BitConverter.GetBytes(int.Parse(defaultValue));
                                    break;
                            }
                        }

                        byte[] currentData = CopyTable[id];
                        byte[] data = col.ContainsKey(id) ? col[id] : zeroData;
                        Array.Resize(ref currentData, currentData.Length + data.Length);
                        Array.Copy(data, 0, currentData, field.Offset, data.Length);
                        CopyTable[id] = currentData;
                    }
                }

                commondatalookup = null;
                RawRecordSize = (uint)CopyTable.Values.First().Length;
            }

            return CopyTable;
        }

        public override byte[] ReadData(BinaryReader dbReader, long pos, uint build)
        {
            Dictionary<int, byte[]> CopyTable = ReadOffsetData(dbReader, pos, build);
            OffsetLengths = CopyTable.Select(x => x.Value.Length).ToArray();
            return CopyTable.Values.SelectMany(x => x).ToArray();
        }
        #endregion

        #region Write
        public override void WriteHeader<T>(BinaryWriter bw, DBEntry<T> entry)
        {
            Tuple<int, int> minmax = entry.MinMax();
            bw.BaseStream.Position = 0;

            WriteBaseHeader(bw, entry);

            bw.Write((int)TableHash);
            bw.Write(LayoutHash);
            bw.Write(minmax.Item1); //MinId
            bw.Write(minmax.Item2); //MaxId
            bw.Write(Locale);
            bw.Write(0); //CopyTableSize
            bw.Write((ushort)Flags); //Flags
            bw.Write(IdIndex); //IdColumn
            bw.Write(TotalFieldSize);
            bw.Write(0); //CommonDataTableSize

            //Write the field_structure bits
            for (int i = 0; i < FieldStructure.Count; i++)
            {
                if (HasIndexTable && i == 0) continue;
                if (FieldStructure[i].CommonDataColumn) continue;

                bw.Write(FieldStructure[i].Bits);
                bw.Write(HasIndexTable ? (ushort)(FieldStructure[i].Offset - 4) : FieldStructure[i].Offset);
            }
        }

        public virtual void WriteCommonDataTable<T>(BinaryWriter bw, DBEntry<T> entry) where T : class
        {
            if (CommonDataTableSize == 0)
                return;

            long start = bw.BaseStream.Position; //Current position
            var rows = entry.Rows;

            bw.WriteUInt32((uint)FieldStructure.Count); //Field count

            for (int i = 0; i < FieldStructure.Count; i++)
            {
                PropertyInfo field = TableStructure[i];
                TypeCode typeCode = Type.GetTypeCode(field.PropertyType);
                PropertyInfo pk = entry.PrimaryKey;

                object defaultValue = field.GetAttribute<DBFieldAttribute>()?.DefaultValue;
                object numberDefault = (typeCode == TypeCode.String ? null : Convert.ChangeType(defaultValue ?? 0, typeCode));

                Dictionary<int, byte[]> data = new Dictionary<int, byte[]>();
                int padding = 0;

                //Only get data if CommonDataTable
                if (FieldStructure[i].CommonDataColumn)
                {
                    Func<object, byte[]> GenGetBytes = (o) => (byte[])typeof(BitConverter).GetMethod("GetBytes", new Type[] { o.GetType() }).Invoke(null, new object[] { o });

                    switch (typeCode)
                    {
                        case TypeCode.String:
                            data = rows.Where(x => !field.GetValue(x).Equals(defaultValue + "")).ToDictionary(x => (int)pk.GetValue(x), y => Encoding.UTF8.GetBytes((string)field.GetValue(y)));
                            break;
                        case TypeCode.Byte:
                            data = rows.Where(x => !field.GetValue(x).Equals(numberDefault)).ToDictionary(x => (int)pk.GetValue(x), y => new byte[] { (byte)field.GetValue(y) });
                            padding = 3;
                            break;
                        case TypeCode.UInt16:
                        case TypeCode.Int16:
                            data = rows.Where(x => !field.GetValue(x).Equals(numberDefault)).ToDictionary(x => (int)pk.GetValue(x), y => GenGetBytes(field.GetValue(y)));
                            padding = 2;
                            break;
                        case TypeCode.Single:
                        case TypeCode.Int32:
                        case TypeCode.UInt32:
                            data = rows.Where(x => !field.GetValue(x).Equals(numberDefault)).ToDictionary(x => (int)pk.GetValue(x), y => GenGetBytes(field.GetValue(y)));
                            break;
                        default:
                            continue;
                    }
                }

                bw.WriteInt32(data.Count); //Count
                bw.Write(CommonDataTypes[typeCode]); //Type code
                foreach (var d in data)
                {
                    bw.WriteInt32(d.Key); //Id
                    bw.Write(d.Value); //Value

                    if ((entry.Build == 0 || entry.Build > 24015) && padding > 0)
                        bw.BaseStream.Position += padding;
                }
            }

            //Set CommonDataTableSize
            long pos = bw.BaseStream.Position;
            bw.Scrub(0x34);
            bw.WriteInt32((int)(pos - start));
            bw.Scrub(pos);
        }
        #endregion
    }
}
