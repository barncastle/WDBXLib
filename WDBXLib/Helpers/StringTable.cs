using WDBXLib.Common;
using WDBXLib.Reader;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System;
using WDBXLib.Extensions;

namespace WDBXLib.Helpers
{
    public class StringTable : IDisposable
    {
        public int Size => (int)_stringstream.Length;

        private MemoryStream _stringstream = new MemoryStream();
        private Dictionary<string, int> _stringlookup = new Dictionary<string, int>();

        public StringTable() { }

        public StringTable(bool extended)
        {
            _stringstream.WriteByte(0);
            if (extended)
                _stringstream.WriteByte(0);
        }

        /// <summary>
        /// Writes the string into the stringtable and return's it's position.
        /// <para>If unqiue then it will check if the string is existent and return the previous position.</para>
        /// </summary>
        /// <param name="str"></param>
        /// <param name="unique"></param>
        /// <returns></returns>
        public int Write(string str, bool duplicates = false)
        {
            int offset = 0;
            if (string.IsNullOrEmpty(str)) //Empty string always 0
                return offset;

            //WDB2 with MaxId allows duplicates else distinct strings
            if (duplicates || !_stringlookup.TryGetValue(str, out offset))
            {
                byte[] strBytes = Encoding.UTF8.GetBytes(str);
                offset = (int)_stringstream.Position;

                if (!duplicates)
                    _stringlookup.Add(str, offset);

                _stringstream.Write(strBytes, 0, strBytes.Length);
                _stringstream.WriteByte(0);
            }

            return offset;
        }

        public void CopyTo(Stream s)
        {
            _stringstream.Position = 0;
            _stringstream.CopyTo(s);
        }
        
        /// <summary>
        /// Reads the binary data from start to end returning a list of strings and their positions.
        /// </summary>
        /// <param name="dbReader"></param>
        /// <param name="stringTableStart"></param>
        /// <param name="stringTableEnd"></param>
        /// <returns></returns>
        public Dictionary<int, string> Read(BinaryReader dbReader, long stringTableStart, long stringTableEnd)
        {
            Dictionary<int, string> table = new Dictionary<int, string>();

            if (dbReader.BaseStream.Position > stringTableEnd)
                return table;

            while (dbReader.BaseStream.Position < stringTableEnd)
            {
                int index = (int)(dbReader.BaseStream.Position - stringTableStart);
                table[index] = dbReader.ReadStringNull(); //Extract all the strings to the string table
            }

            return table;
        }

        public Dictionary<int, string> Read(BinaryReader dbReader, long stringTableStart)
        {
            return Read(dbReader, stringTableStart, dbReader.BaseStream.Length);
        }

        public void Dispose()
        {
            ((IDisposable)_stringstream).Dispose();
        }
    }
}
