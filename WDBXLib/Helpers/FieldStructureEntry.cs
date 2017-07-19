﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WDBXLib.Helpers
{
    public class FieldStructureEntry
    {
        public short Bits;
        public ushort Offset;
        public int Length = 1;

        public bool CommonDataColumn => CommonDataType != 0xFF;
        public byte CommonDataType;

        public int ByteCount
        {
            get
            {
                int value = (32 - Bits) >> 3;
                return (value < 0 ? Math.Abs(value) + 4 : value);
            }
        }

        public FieldStructureEntry(short bits, ushort offset, byte commondatatype = 0xFF)
        {
            this.Bits = bits;
            this.Offset = offset;
            this.CommonDataType = commondatatype;
        }

        public void SetLength(FieldStructureEntry nextField)
        {
            this.Length = Math.Max(1, (int)Math.Floor((nextField.Offset - this.Offset) / (double)this.ByteCount));
        }
    }
}
