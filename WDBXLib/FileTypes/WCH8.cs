using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WDBXLib.Storage;

namespace WDBXLib.Reader.FileTypes
{
    class WCH8 : WCH7
    {
        public WCH8()
        {
            StringTableOffset = 0x14;
            HeaderSize = 0x34;
        }

        public WCH8(DBHeader counterpart)
        {
            StringTableOffset = 0x14;
            HeaderSize = 0x34;
            this.CounterPart = counterpart;
        }

        public override void WriteRecordPadding<T>(BinaryWriter bw, DBEntry<T> entry, long offset)
        {
            if (!HasOffsetTable && bw.BaseStream.Position - offset < RecordSize)
                bw.BaseStream.Position += (RecordSize - (bw.BaseStream.Position - offset));
        }
    }
}
