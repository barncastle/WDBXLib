using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.IO;
using System.Text;
using WDBXLib.Reader.FileTypes;
using WDBXLib.Common;
using static WDBXLib.Common.Constants;
using System.Diagnostics;
using System.Runtime.Serialization.Formatters.Binary;
using WDBXLib.Storage;
using WDBXLib.Attributes;
using System.Reflection;
using WDBXLib.Helpers;
using WDBXLib.Extensions;

namespace WDBXLib.Reader
{
    public static class DBReader
    {
        private static List<Tuple<int, short>> OffsetMap = new List<Tuple<int, short>>();
        private static string FileName;

        #region Header Methods

        public static DBHeader ReadHeader(string dbFile)
        {
            using (var ms = new FileInfo(dbFile).OpenRead())
            using (var br = new BinaryReader(ms))
                return ReadHeader(br);
        }

        private static DBHeader ReadHeader(BinaryReader dbReader, DBHeader counterpart = null)
        {
            DBHeader header = null;
            string signature = dbReader.ReadString(4);

            if (string.IsNullOrWhiteSpace(signature))
                return null;

            if (signature[0] != 'W')
                signature = signature.Reverse();

            switch (signature)
            {
                case "WDBC":
                    header = new WDBC();
                    break;
                case "WDB2":
                case "WCH2":
                    header = new WDB2();
                    break;
                case "WDB5":
                    header = new WDB5();
                    break;
                case "WDB6":
                    header = new WDB6();
                    break;
                case "WCH5":
                    header = new WCH5(counterpart);
                    break;
                case "WCH7":
                    header = new WCH7(counterpart);
                    break;
                case "WCH8":
                    header = new WCH8(counterpart);
                    break;
                case "WMOB":
                case "WGOB":
                case "WQST":
                case "WIDB":
                case "WNDB":
                case "WITX":
                case "WNPC":
                case "WPTX":
                case "WRDN":
                    header = new WDB();
                    break;
            }

            header?.ReadHeader(ref dbReader, signature);
            return header;
        }
        #endregion

        #region Read Methods

        public static DBEntry<T> Read<T>(string dbFile, DBHeader counterpart = null) where T : class
        {
            return Read<T>(new FileInfo(dbFile).OpenRead(), dbFile, counterpart);
        }

        private static DBEntry<T> Read<T>(FileStream stream, string dbFile, DBHeader counterpart = null) where T : class
        {
            FileName = dbFile;
            stream.Position = 0;

            using (var dbReader = new BinaryReader(stream, Encoding.UTF8))
            {
                DBHeader header = ReadHeader(dbReader, counterpart);
                long pos = dbReader.BaseStream.Position;

                ValidationChecks<T>(header, out uint build);

                DBEntry<T> entry = new DBEntry<T>(header, dbFile, build);
                if (entry.TableStructure == null)
                    throw new Exception("Definition missing.");

                if (header.IsTypeOf<WDBC>() || header.IsTypeOf<WDB2>())
                {
                    long stringTableStart = dbReader.BaseStream.Position += header.RecordCount * header.RecordSize;
                    Dictionary<int, string> StringTable = new StringTable().Read(dbReader, stringTableStart); //Get stringtable
                    dbReader.Scrub(pos);

                    ReadIntoTable(ref entry, dbReader, StringTable); //Read data

                    stream.Dispose();
                    return entry;
                }
                else if (header.IsTypeOf<WDB5>() || header.IsTypeOf<WCH5>() || header.IsTypeOf<WDB6>())
                {
                    int CopyTableSize = header.CopyTableSize; //Only WDB5 has a copy table
                    uint CommonDataTableSize = header.CommonDataTableSize; //Only WDB6 has a CommonDataTable

                    //StringTable - only if applicable
                    long copyTablePos = dbReader.BaseStream.Length - CommonDataTableSize - CopyTableSize;
                    long indexTablePos = copyTablePos - (header.HasIndexTable ? header.RecordCount * 4 : 0);
                    long wch7TablePos = indexTablePos - (header.UnknownWCH7 * 4);
                    long stringTableStart = wch7TablePos - header.StringBlockSize;

                    Dictionary<int, string> StringTable = new Dictionary<int, string>();
                    if (!header.HasOffsetTable) //Stringtable is only present if there isn't an offset map
                    {
                        dbReader.Scrub(stringTableStart);
                        StringTable = new StringTable().Read(dbReader, stringTableStart, stringTableStart + header.StringBlockSize);
                        dbReader.Scrub(pos);
                    }

                    //Read the data
                    using (MemoryStream ms = new MemoryStream(header.ReadData(dbReader, pos, entry.Build)))
                    using (BinaryReader dataReader = new BinaryReader(ms, Encoding.UTF8))
                    {
                        ReadIntoTable(ref entry, dataReader, StringTable);
                    }

                    //Cleanup
                    header.OffsetLengths = null;

                    stream.Dispose();
                    return entry;
                }
                else if (header.IsTypeOf<WDB>())
                {
                    WDB wdb = (WDB)header;
                    wdb.ReadExtendedHeader(dbReader, entry.Build);

                    using (MemoryStream ms = new MemoryStream(wdb.ReadData(dbReader)))
                    using (BinaryReader dataReader = new BinaryReader(ms, Encoding.UTF8))
                    {
                        ReadIntoTable(ref entry, dataReader, new Dictionary<int, string>());
                    }

                    stream.Dispose();
                    return entry;
                }
                else
                {
                    stream.Dispose();
                    throw new Exception($"Invalid filetype.");
                }
            }
        }

        private static void ReadIntoTable<T>(ref DBEntry<T> entry, BinaryReader dbReader, Dictionary<int, string> stringtable) where T : class
        {
            if (entry.Header.RecordCount == 0)
                return;

            TypeCode[] columnTypes = entry.TableStructure.Select(x => Type.GetTypeCode(x.PropertyType)).ToArray();
            uint[] padding = entry.Padding.ToArray();

            FieldStructureEntry[] bits = entry.GetBits();
            int recordcount = Math.Max(entry.Header.OffsetLengths.Length, (int)entry.Header.RecordCount);
            uint recordsize = entry.Header.RecordSize + (uint)(entry.Header.HasIndexTable ? 4 : 0);

            if (entry.Header.CommonDataTableSize > 0)
                recordsize = ((WDB6)entry.Header).RawRecordSize;

            for (uint i = 0; i < recordcount; i++)
            {
                //Offset map has variable record lengths
                if (entry.Header.HasOffsetTable)
                    recordsize = (uint)entry.Header.OffsetLengths[i];

                //Store start position
                long offset = dbReader.BaseStream.Position;

                //Create row and add data
                T row = (T)Activator.CreateInstance(typeof(T));

                for (int j = 0; j < entry.TableStructure.Length; j++)
                {
                    PropertyInfo field = entry.TableStructure[j];

                    if (entry.TableStructure[j].GetAttribute<DBKeyAttribute>()?.AutoGenerated == true)
                    {
                        field.SetValue(row, entry.Rows.Count + 1);
                        continue;
                    }

                    if (columnTypes[j] == TypeCode.Object)
                    {
                        if (field.PropertyType.IsArray)
                        {
                            uint arraySize = field.GetAttribute<DBFieldAttribute>().ArraySize;
                            TypeCode type = Type.GetTypeCode(field.PropertyType.GetElementType());

                            Array array = Array.CreateInstance(field.PropertyType.GetElementType(), arraySize);
                            for (int x = 0; x < arraySize; x++)
                                array.SetValue(ReadValue(dbReader, entry, type, padding[j], stringtable, bits[j]), x);

                            field.SetValue(row, array);
                        }
                        else if (field.PropertyType == typeof(LocalizedString))
                        {
                            LocalizedString locale = new LocalizedString(entry.Build);
                            locale.Load(dbReader, stringtable);
                            field.SetValue(row, locale);
                        }
                        else
                        {
                            throw new Exception($"Unknown Type {field.PropertyType.Name}");
                        }
                    }
                    else
                    {
                        field.SetValue(row, ReadValue(dbReader, entry, columnTypes[j], padding[j], stringtable, bits[j]));
                    }
                }

                entry.Rows.Add(row);

                //Scrub to the end of the record
                if (dbReader.BaseStream.Position - offset < recordsize)
                {
                    dbReader.BaseStream.Position += (recordsize - (dbReader.BaseStream.Position - offset));
                }
                else if (dbReader.BaseStream.Position - offset > recordsize)
                {
                    throw new Exception("Definition exceeds record size");
                }

            }
        }

        private static object ReadValue<T>(BinaryReader dbReader, DBEntry<T> entry, TypeCode type, uint padding, Dictionary<int, string> StringTable, FieldStructureEntry bits) where T : class
        {
            object value;

            switch (type)
            {
                case TypeCode.Boolean:
                    value = dbReader.ReadBoolean();
                    dbReader.BaseStream.Position += sizeof(bool) * padding;
                    break;
                case TypeCode.SByte:
                    value = dbReader.ReadSByte();
                    dbReader.BaseStream.Position += sizeof(sbyte) * padding;
                    break;
                case TypeCode.Byte:
                    value = dbReader.ReadByte();
                    dbReader.BaseStream.Position += sizeof(byte) * padding;
                    break;
                case TypeCode.Int16:
                    value = dbReader.ReadInt16();
                    dbReader.BaseStream.Position += sizeof(short) * padding;
                    break;
                case TypeCode.UInt16:
                    value = dbReader.ReadUInt16();
                    dbReader.BaseStream.Position += sizeof(ushort) * padding;
                    break;
                case TypeCode.Int32:
                    value = dbReader.ReadInt32(bits);
                    dbReader.BaseStream.Position += sizeof(int) * padding;
                    break;
                case TypeCode.UInt32:
                    value = dbReader.ReadUInt32(bits);
                    dbReader.BaseStream.Position += sizeof(uint) * padding;
                    break;
                case TypeCode.Int64:
                    value = dbReader.ReadInt64(bits);
                    dbReader.BaseStream.Position += sizeof(long) * padding;
                    break;
                case TypeCode.UInt64:
                    value = dbReader.ReadUInt64(bits);
                    dbReader.BaseStream.Position += sizeof(ulong) * padding;
                    break;
                case TypeCode.Single:
                    value = dbReader.ReadSingle();
                    dbReader.BaseStream.Position += sizeof(float) * padding;
                    break;
                case TypeCode.String:
                    if (entry.Header.IsTypeOf<WDB>() || entry.Header.HasOffsetTable)
                    {
                        value = dbReader.ReadStringNull();
                    }
                    else
                    {
                        int stindex = dbReader.ReadInt32();
                        if (!StringTable.ContainsKey(stindex))
                            throw new Exception("Strings not found in string table");

                        value = StringTable[stindex];
                    }
                    break;
                default:
                    throw new Exception($"Unknown TypeCode");
            }

            return value;
        }
        #endregion

        #region Write Methods

        public static void Write<T>(DBEntry<T> entry, string savepath) where T : class
        {
            if (entry.Rows.HasDuplicateKeys)
                throw new Exception("Collection contains duplicate keys");


            using (var fs = new FileStream(savepath, FileMode.Create))
            using (var ms = new MemoryStream())
            using (var bw = new BinaryWriter(ms))
            {
                StringTable stringtable = new StringTable(entry.Header.ExtendedStringTable); //Preloads null byte(s)
                entry.Header.WriteHeader(bw, entry);

                if (entry.Header.IsTypeOf<WDB5>() && !entry.Header.HasOffsetTable && entry.Header.CopyTableSize > 0)
                {
                    WriteIntoFile(entry, bw, entry.GetUniqueRows().ToArray(), ref stringtable); //Insert unique rows
                }
                else
                {
                    WriteIntoFile(entry, bw, entry.Rows.AsEnumerable(), ref stringtable); //Insert all rows
                }

                //Copy StringTable and StringTable size if it doesn't have inline strings
                if (stringtable.Size > 0 && !entry.Header.HasOffsetTable)
                {
                    long pos = bw.BaseStream.Position;
                    bw.Scrub(entry.Header.StringTableOffset);
                    bw.Write(stringtable.Size);
                    bw.Scrub(pos);
                    stringtable.CopyTo(bw.BaseStream);
                }
                stringtable.Dispose();

                //Legion+ only
                if (entry.Header.IsLegionFile)
                {
                    //WCH7 Map
                    if (entry.Header.IsTypeOf<WCH7>())
                        bw.WriteArray(((WCH7)entry.Header).WCH7Table);

                    //OffsetMap
                    if (entry.Header.HasOffsetTable)
                    {
                        //Update StringTableOffset with current position
                        long pos = bw.BaseStream.Position;
                        bw.Scrub(entry.Header.StringTableOffset);
                        bw.Write((int)pos);
                        bw.Scrub(pos);

                        entry.Header.WriteOffsetMap(bw, entry, OffsetMap);

                        OffsetMap.Clear(); //Cleanup
                    }

                    //Index Table
                    if (entry.Header.HasIndexTable)
                        entry.Header.WriteIndexTable(bw, entry);

                    //CopyTable - WDB5 only
                    if (entry.Header.IsTypeOf<WDB5>())
                        ((WDB5)entry.Header).WriteCopyTable(bw, entry);

                    //CommonDataTable
                    if (entry.Header.IsTypeOf<WDB6>())
                        ((WDB6)entry.Header).WriteCommonDataTable(bw, entry);
                }

                //Copy data to file
                ms.Position = 0;
                ms.CopyTo(fs);
            }
        }

        private static void WriteIntoFile<T>(DBEntry<T> entry, BinaryWriter bw, IEnumerable<T> rows, ref StringTable st) where T : class
        {
            TypeCode[] columnTypes = entry.TableStructure.Select(x => Type.GetTypeCode(x.PropertyType)).ToArray();
            uint[] padding = entry.Padding.ToArray();
            FieldStructureEntry[] bits = entry.GetBits();

            bool duplicates = false;
            duplicates |= (entry.Header.IsTypeOf<WDB2>() && entry.Header.MaxId != 0); //WDB2 with MaxId > 0 allows duplicates
            duplicates |= (entry.Header.IsTypeOf<WCH7>() && entry.Header.UnknownWCH7 != 0); //WCH7 with Unknown > 0 allows duplicates

            T lastrow = rows.Last();

            foreach (T row in rows)
            {
                long offset = bw.BaseStream.Position;

                for (int j = 0; j < entry.TableStructure.Length; j++)
                {
                    PropertyInfo field = entry.TableStructure[j];

                    if (field.GetAttribute<DBKeyAttribute>()?.AutoGenerated == true) //Autogenerated so skip
                        continue;

                    if (entry.Header.HasIndexTable && j == 0) //Inline Id so skip
                        continue;

                    if (entry.Header.IsTypeOf<WCH5>() && entry.Header.HasOffsetTable && j == 0) //Inline Id so skip
                        continue;

                    if (entry.Header.IsTypeOf<WDB6>() && (bits?[j].CommonDataColumn ?? false))
                        continue;

                    if (columnTypes[j] == TypeCode.Object)
                    {
                        if (field.PropertyType.IsArray)
                        {
                            Array array = (Array)field.GetValue(row);
                            for (int x = 0; x < array.Length; x++)
                                WriteValue(bw, entry, array.GetValue(x), padding[j], st, bits?[j], duplicates);
                        }
                        else if (field.PropertyType == typeof(LocalizedString))
                        {
                            ((LocalizedString)field.GetValue(row)).Write(bw, st, duplicates);
                        }
                        else
                        {
                            throw new Exception($"Unknown Type {field.PropertyType.Name}.");
                        }
                    }
                    else
                    {
                        WriteValue(bw, entry, field.GetValue(row), padding[j], st, bits?[j], duplicates);
                    }
                }

                //Calculate and write the row's padding
                entry.Header.WriteRecordPadding(bw, entry, offset);

                //Store the offset map
                if (entry.Header.HasOffsetTable)
                    OffsetMap.Add(new Tuple<int, short>((int)offset, (short)(bw.BaseStream.Position - offset)));

                //WDB5 + OffsetMap without SecondIndex for the last row pads to next mod 4
                if (entry.Header.IsTypeOf<WDB5>() && entry.Header.HasOffsetTable && !entry.Header.HasSecondIndex && row == lastrow)
                {
                    long rem = bw.BaseStream.Position % 4;
                    bw.BaseStream.Position += (rem == 0 ? 0 : (4 - rem));
                }
            }
        }

        private static void WriteValue<T>(BinaryWriter bw, DBEntry<T> entry, object value, uint padding, StringTable st, FieldStructureEntry bits, bool duplicates) where T : class
        {
            switch (Type.GetTypeCode(value.GetType()))
            {
                case TypeCode.SByte:
                    bw.Write((sbyte)value);
                    bw.BaseStream.Position += sizeof(sbyte) * padding;
                    break;
                case TypeCode.Byte:
                    bw.Write((byte)value);
                    bw.BaseStream.Position += sizeof(byte) * padding;
                    break;
                case TypeCode.Int16:
                    bw.Write((short)value);
                    bw.BaseStream.Position += sizeof(short) * padding;
                    break;
                case TypeCode.UInt16:
                    bw.Write((ushort)value);
                    bw.BaseStream.Position += sizeof(ushort) * padding;
                    break;
                case TypeCode.Int32:
                    bw.WriteInt32((int)value, bits);
                    bw.BaseStream.Position += sizeof(int) * padding;
                    break;
                case TypeCode.UInt32:
                    bw.WriteUInt32((uint)value, bits);
                    bw.BaseStream.Position += sizeof(uint) * padding;
                    break;
                case TypeCode.Int64:
                    bw.WriteInt64((long)value, bits);
                    bw.BaseStream.Position += sizeof(long) * padding;
                    break;
                case TypeCode.UInt64:
                    bw.WriteUInt64((ulong)value, bits);
                    bw.BaseStream.Position += sizeof(ulong) * padding;
                    break;
                case TypeCode.Single:
                    bw.Write((float)value);
                    bw.BaseStream.Position += sizeof(float) * padding;
                    break;
                case TypeCode.String:
                    if (entry.Header.HasOffsetTable)
                    {
                        bw.Write(Encoding.UTF8.GetBytes(value.ToString()));
                        bw.Write((byte)0);
                    }
                    else
                        bw.Write(st.Write(value.ToString(), duplicates));
                    break;
                default:
                    throw new Exception($"Unknown TypeCode {value.GetType().Name}");
            }
        }
        #endregion

        #region Helpers

        private static void ValidationChecks<T>(DBHeader header, out uint Build)
        {
            var attr = typeof(T).GetCustomAttribute(typeof(DBTableAttribute), false) as DBTableAttribute;
            if (attr == null)
                throw new NotSupportedException("Missing DBTableAttribute.");

            if (attr.Build < (int)Expansion.Alpha)
                throw new ArgumentException("Invalid Build Number.");

            //No header - must be invalid
            if (!header.IsTypeOf<DBHeader>())
                throw new Exception("Unknown file type.");

            if (header.RecordCount == 0 || header.RecordSize == 0)
                throw new Exception("File contains no records.");

            Build = attr.Build;
        }
        #endregion

    }
}
