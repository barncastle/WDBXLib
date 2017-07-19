using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WDBXLib.Attributes
{
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false, Inherited = false)]
    public class DBFieldAttribute : Attribute
    {
        public readonly uint ArraySize = 1;
        public readonly uint Padding = 0;
        public readonly object DefaultValue;

        public DBFieldAttribute(uint ArraySize = 1, uint Padding = 0, object DefaultValue = null)
        {
            this.ArraySize = ArraySize;
            this.Padding = Padding;
            this.DefaultValue = DefaultValue;
        }
    }
}
