using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using WDBXLib.Extensions;
using WDBXLib.Storage;
using static WDBXLib.Common.Constants;

namespace WDBXLib.Reader.FileTypes
{
    class WCH5 : DBHeader
    {
        public uint Build { get; set; }
        public uint TimeStamp { get; set; }
        public override bool ExtendedStringTable => true;
        
        public override bool HasOffsetTable => Flags.HasFlag(HeaderFlags.OffsetMap);
        public override bool HasIndexTable => Flags.HasFlag(HeaderFlags.IndexMap);
        public override bool HasSecondIndex => Flags.HasFlag(HeaderFlags.SecondIndex);

        public DBHeader CounterPart { get; set; }

        protected int OffsetMapOffset = 0x30;
        
        public WCH5()
        {
            HeaderSize = 0x30;
        }

        public WCH5(DBHeader counterpart)
        {
            HeaderSize = 0x30;
            this.CounterPart = counterpart;
        }

        #region Read
        public override void ReadHeader(ref BinaryReader dbReader, string signature)
        {
            if (CounterPart == null)
                throw new Exception("You must have the DB2 counterpart open first to be able to read this file.");

            Flags = CounterPart.Flags;
            IdIndex = CounterPart.IdIndex;
            FieldStructure = CounterPart.FieldStructure;

            if (HasOffsetTable)
                Flags = HeaderFlags.OffsetMap;

            base.ReadHeader(ref dbReader, signature);
            TableHash = dbReader.ReadUInt32();
            LayoutHash = dbReader.ReadInt32();
            Build = dbReader.ReadUInt32();
            TimeStamp = dbReader.ReadUInt32();
            MinId = dbReader.ReadInt32();
            MaxId = dbReader.ReadInt32();
            Locale = dbReader.ReadInt32();
        }

        public Dictionary<int, byte[]> ReadOffsetData(BinaryReader dbReader, long pos, uint build)
        {
            Dictionary<int, byte[]> CopyTable = new Dictionary<int, byte[]>();
            List<OffsetEntry> offsetmap = new List<OffsetEntry>();

            long indexTablePos = dbReader.BaseStream.Length - (HasIndexTable ? RecordCount * 4 : 0);
            int[] m_indexes = null;

            //Offset Map - Contains the index, offset and length so the index table is not used
            if (HasOffsetTable)
            {
                // Records table
                if (StringBlockSize > 0)
                    dbReader.Scrub(StringBlockSize);

                for (int i = 0; i < RecordCount; i++)
                {
                    int id = dbReader.ReadInt32();
                    int offset = dbReader.ReadInt32();
                    short length = dbReader.ReadInt16();

                    if (offset == 0 || length == 0) continue;

                    offsetmap.Add(new OffsetEntry(id, offset, length));
                }
            }

            //Index table
            if (HasIndexTable)
            {
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
                    var map = offsetmap[i];
                    dbReader.Scrub(map.Offset);

                    IEnumerable<byte> recordbytes = BitConverter.GetBytes(map.Id).Concat(dbReader.ReadBytes(map.Length));
                    CopyTable.Add(map.Id, recordbytes.ToArray());
                }
                else
                {
                    dbReader.Scrub(pos + i * RecordSize);
                    byte[] recordbytes = dbReader.ReadBytes((int)RecordSize);

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

            return CopyTable;
        }

        public override byte[] ReadData(BinaryReader dbReader, long pos, uint build)
        {
            Dictionary<int, byte[]> CopyTable = ReadOffsetData(dbReader, pos, build);
            OffsetLengths = CopyTable.Select(x => x.Value.Length).ToArray();
            return CopyTable.Values.SelectMany(x => x).ToArray();
        }

        internal struct OffsetEntry
        {
            public int Id { get; set; }
            public int Offset { get; set; }
            public short Length { get; set; }

            public OffsetEntry(int id, int offset, short length)
            {
                this.Id = id;
                this.Offset = offset;
                this.Length = length;
            }
        }
        #endregion

        #region Write
        public override void WriteHeader<T>(BinaryWriter bw, DBEntry<T> entry)
        {
            Tuple<int, int> minmax = entry.MinMax();
            bw.BaseStream.Position = 0;

            base.WriteHeader(bw, entry);

            bw.Write(TableHash);
            bw.Write(LayoutHash);
            bw.Write(Build);
            bw.Write(TimeStamp);
            bw.Write(minmax.Item1); //MinId
            bw.Write(minmax.Item2); //MaxId
            bw.Write(Locale);

            //WCH5 has the offsetmap BEFORE the data, create placeholder data
            if (HasOffsetTable)
            {
                OffsetMapOffset = (int)bw.BaseStream.Position;
                bw.BaseStream.Position += entry.GetPrimaryKeys().Count() * (sizeof(int) + sizeof(int) + sizeof(short));
            }
                
        }

        public override void WriteOffsetMap<T>(BinaryWriter bw, DBEntry<T> entry, List<Tuple<int, short>> OffsetMap)
        {
            bw.Scrub(OffsetMapOffset); //Scrub to after header

            //Write the offset map
            var ids = entry.GetPrimaryKeys().ToList();
            for (int x = 0; x < ids.Count(); x++)
            {
                var kvp = OffsetMap[x];
                bw.Write(ids[x]);
                bw.Write(kvp.Item1);
                bw.Write(kvp.Item2);
            }
            ids.Clear();

            //Clear string table size
            long pos = bw.BaseStream.Position;
            bw.Scrub(entry.Header.StringTableOffset);
            bw.Write(0);
            bw.Scrub(pos);
        }

        public override void WriteIndexTable<T>(BinaryWriter bw, DBEntry<T> entry)
        {
            int m = 0;
            int[] ids = entry.GetPrimaryKeys().ToArray();

            if (entry.Header.HasSecondIndex)
            {
                PropertyInfo secondId = entry.TableStructure[2];
                ushort[] secondids = entry.Rows.Select(x => (ushort)secondId.GetValue(x)).ToArray();

                //Write all of the secondary ids
                foreach (ushort id in secondids)
                {
                    //Populate missing secondary ids with 0
                    if (m > 0 && (ids[m] - ids[m - 1]) > 1)
                        bw.BaseStream.Position += sizeof(int) * (ids[m] - ids[m - 1] - 1);

                    bw.Write((int)id);
                    m++;
                }
            }

            //Write all the primary IDs
            bw.WriteArray(ids);
        }

        public override void WriteRecordPadding<T>(BinaryWriter bw, DBEntry<T> entry, long offset) { }
        #endregion
    }
}
