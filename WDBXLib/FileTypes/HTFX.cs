using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WDBXLib.Reader;
using WDBXLib.Reader.FileTypes;
using WDBXLib.Storage;

namespace WDBXLib.Reader.FileTypes
{
    class HTFX : DBHeader
    {
        public int Build { get; set; }
        public List<HotfixEntry> Entries { get; private set; } = new List<HotfixEntry>();

        public override void ReadHeader(ref BinaryReader dbReader, string signature)
        {
            this.Signature = signature;
            Locale = dbReader.ReadInt32();
            Build = dbReader.ReadInt32();

            while (dbReader.BaseStream.Position < dbReader.BaseStream.Length)
                Entries.Add(new HotfixEntry(dbReader));

            Entries.RemoveAll(x => x.IsValid != 1); //Remove old hotfix entries
        }

        public bool HasEntry(DBHeader counterpart) => Entries.Any(x => (x.Locale == counterpart.Locale || x.Locale == 0) && x.TableHash == counterpart.TableHash && x.IsValid == 1);

        public byte[] ReadData(WDB6 CounterPart)
        {
            if (CounterPart == null)
                throw new Exception("Counterpart is not WDB6");

            var entries = Entries.Where(x => (x.Locale == CounterPart.Locale || x.Locale == 0) && x.TableHash == CounterPart.TableHash);
            if (entries.Any())
            {
                OffsetLengths = entries.Select(x => (int)x.Size + 4).ToArray();
                Flags = CounterPart.Flags;
                FieldStructure = CounterPart.FieldStructure;
                RecordCount = (uint)entries.Count();

                IEnumerable<byte> Data = new byte[0];
                foreach (var e in entries)
                    Data = Data.Concat(BitConverter.GetBytes(e.RowId)).Concat(e.Data);

                return Data.ToArray();
            }

            throw new Exception("Entry not found");
        }
    }

    public class HotfixEntry
    {
        public uint Signature;
        public uint Locale;
        public uint Offset;
        public uint Size;
        public uint TableHash;
        public int RowId;
        public byte IsValid;
        public byte[] Padding;
        public byte[] Data;

        public HotfixEntry(BinaryReader br)
        {
            Signature = br.ReadUInt32();
            Locale = br.ReadUInt32();
            Offset = br.ReadUInt32();
            Size = br.ReadUInt32();
            TableHash = br.ReadUInt32();
            RowId = br.ReadInt32();
            IsValid = br.ReadByte();
            Padding = br.ReadBytes(3);
            Data = br.ReadBytes((int)Size);
        }
    }
}
