using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace WDBXLib.Helpers
{
    class DBRowComparer<T> : IEqualityComparer<T>
    {
        public readonly PropertyInfo PrimaryKey;
        private PropertyInfo[] _fields;

        /// <summary>
        /// Creates a new instance of PropertyComparer.
        /// </summary>
        /// <param name="propertyName">The name of the property on type T 
        /// to perform the comparison on.</param>
        public DBRowComparer(PropertyInfo primarykey)
        {
            PrimaryKey = primarykey;
            _fields = typeof(T).GetProperties(BindingFlags.Instance | BindingFlags.Public);
        }

        public bool Equals(T x, T y)
        {
            foreach(var field in _fields)
            {
                if (field == PrimaryKey)
                    continue;

                object xa = field.GetValue(x);
                object ya = field.GetValue(y);

                if (xa == null)
                    return ya == null;

                if (!xa.Equals(ya))
                    return false;
            }

            return true;
        }

        public int GetHashCode(T obj)
        {
            int result = 0;
            foreach(var field in _fields)
            {
                if (field == PrimaryKey)
                    continue;

                result ^= field.GetValue(obj).GetHashCode();
            }

            return result;
        }
    }
}