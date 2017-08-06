using WDBXLib.Reader.FileTypes;
using WDBXLib.Storage;
using System.IO;
using System.Linq;
using System.Text;
using WDBXLib.Common;
using System.Collections.Generic;
using System;
using static WDBXLib.Common.Constants;
using System.Reflection;
using WDBXLib.Helpers;

namespace WDBXLib.Reader
{
    public class DBHeader
    {
        //Standard Fields
        public string Signature { get; protected set; }
        public uint RecordCount { get; protected set; }
        public uint UnknownWCH7 { get; protected set; } = 0;
        public uint FieldCount { get; protected set; }
        public uint RecordSize { get; protected set; }
        public uint StringBlockSize { get; protected set; }

        public uint TableHash { get; protected set; }
        public int LayoutHash { get; protected set; }
        public int MinId { get; protected set; }
        public int MaxId { get; protected set; }
        public int Locale { get; protected set; }
        public int CopyTableSize { get; protected set; } = 0;
        public HeaderFlags Flags { get; protected set; } = HeaderFlags.None;
        public List<FieldStructureEntry> FieldStructure { get; protected set; } = new List<FieldStructureEntry>();
        public PropertyInfo[] TableStructure { get; set; }

        public ushort IdIndex { get; protected set; } = 0;
        public uint TotalFieldSize { get; protected set; } = 0;
        public uint CommonDataTableSize { get; protected set; } = 0;
        
        public int[] OffsetLengths { get; set; } = new int[0];
        public int HeaderSize = 0x20;
        public int StringTableOffset = 0x10;

        public bool IsTypeOf<T>() => this is T;
        public bool IsLegionFile => this is WDB5 || this is WCH5 || this is WCH7 || this is WCH8;

        public virtual bool ExtendedStringTable => false;
        public virtual bool HasIndexTable => false;
        public virtual bool HasOffsetTable => false;
        public virtual bool HasSecondIndex => false;

        public Dictionary<int, int> OffsetDuplicates = new Dictionary<int, int>();

        public virtual void ReadHeader(ref BinaryReader dbReader, string signature)
        {
            this.Signature = signature;
            RecordCount = dbReader.ReadUInt32();

            if (IsTypeOf<WCH7>())
                UnknownWCH7 = dbReader.ReadUInt32();

            FieldCount = dbReader.ReadUInt32();
            RecordSize = dbReader.ReadUInt32();
            StringBlockSize = dbReader.ReadUInt32();
        }

        public virtual byte[] ReadData(BinaryReader dbReader, long pos, uint build) => new byte[0];

        public virtual void WriteHeader<T>(BinaryWriter bw, DBEntry<T> entry) where T : class
        {
            //Signature
            bw.Write(Encoding.UTF8.GetBytes(Signature));

            //Record count
            if (IsTypeOf<WDB5>() && !HasOffsetTable && CopyTableSize > 0)
                bw.Write(entry.GetUniqueRows().Count());
            else
                bw.Write(entry.Rows.Count);

            //WCH7 specific field
            if (IsTypeOf<WCH7>())
                bw.Write(UnknownWCH7);

            //FieldCount
            if (IsTypeOf<WDB5>() && HasIndexTable)
                FieldCount--;
            bw.Write(FieldCount);

            //Record size
            bw.Write(RecordSize);

            //StringBlockSize placeholder
            uint stringblocksize = (uint)((IsTypeOf<WDB5>() || IsTypeOf<WCH7>()) ? 2 : 1);
            bw.Write(stringblocksize);
        }

        public virtual void WriteOffsetMap<T>(BinaryWriter bw, DBEntry<T> entry, List<Tuple<int, short>> OffsetMap) where T : class { }

        public virtual void WriteIndexTable<T>(BinaryWriter bw, DBEntry<T> entry) where T : class { }

        public virtual void WriteRecordPadding<T>(BinaryWriter bw, DBEntry<T> entry, long offset) where T : class
        {
            if (bw.BaseStream.Position - offset < RecordSize)
                bw.BaseStream.Position += (RecordSize - (bw.BaseStream.Position - offset));
        }
    }
}
