using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WDBXLib.Reader;
using static WDBXLib.Common.Constants;

namespace WDBXLib.Helpers
{
    public class LocalizedString
    {
        private readonly int _count;

        public string[] Values;
        public uint Mask;

        public string Locale => Values.FirstOrDefault(x => !string.IsNullOrWhiteSpace(x)) ?? Values[0];

        public string this[TextWowEnum locale]
        {
            get => (int)locale < _count - 1 ? Values[(int)locale] : "";
            set
            {
                if ((int)locale < _count - 1)
                    Values[(int)locale] = value;
            }
        }


        public LocalizedString(uint build)
        {
            _count = build <= 6005 ? 9 : 17;
        }


        public void Load(BinaryReader reader, Dictionary<int, string> stringtable)
        {
            Values = new string[16];

            for (int i = 0; i < _count; i++)
            {
                if (i == _count - 1)
                {
                    Mask = reader.ReadUInt32();
                }
                else
                {
                    int stindex = reader.ReadInt32();
                    if (!stringtable.ContainsKey(stindex))
                        throw new Exception("Strings not found in string table");

                    Values[i] = stringtable[stindex];
                }
            }
        }

        public void Write(BinaryWriter writer, StringTable stringtable, bool duplicates)
        {
            for (int i = 0; i < _count - 1; i++)
                writer.Write(stringtable.Write(Values[i], duplicates));

            writer.Write(Mask);
        }


        public override int GetHashCode()
        {
            Func<int, int, int> CombineHashCodes = (int h1, int h2) => ((h1 << 5) + h1) ^ h2;

            int hash = 0;
            foreach (var val in Values)
                hash = CombineHashCodes(hash, val.GetHashCode());

            return CombineHashCodes(hash, Mask.GetHashCode());
        }
    }
}
