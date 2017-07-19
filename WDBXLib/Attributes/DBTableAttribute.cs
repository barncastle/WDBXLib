using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static WDBXLib.Common.Constants;

namespace WDBXLib.Attributes
{
    public class DBTableAttribute : Attribute
    {
        public readonly uint Build;

        public DBTableAttribute(uint Build)
        {
            this.Build = Build;
        }

        public DBTableAttribute(Expansion Expansion)
        {
            this.Build = (uint)Expansion;
        }
    }
}
