using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WDBXLib.Attributes;
using WDBXLib.Reader;

namespace WDBXTest
{
    [TestClass]
    public class DBCacheTests
    {
        [TestMethod]
        public void LoadSimpleDB6()
        {
            var counterpart = DBReader.ReadHeader(@"TestFiles\TactKey.db2");
            var entry = DBReader.Read<TactKey>(@"TestFiles\DBCache.bin", counterpart);
            Assert.IsNotNull(entry);
        }
    }

    [DBTable(22578)]
    internal class TactKey
    {
        [DBKey]
        public int Id { get; set; }
        [DBField(ArraySize: 16)]
        public byte[] Key { get; set; }
    }
}
