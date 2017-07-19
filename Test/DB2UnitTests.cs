using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using WDBXLib.Attributes;
using WDBXLib.Reader;
using static WDBXLib.Common.Constants;

namespace WDBXTest
{
    [TestClass]
    public class DB2UnitTests
    {
        [TestMethod]
        public void LoadSimpleDB2()
        {
            var entry = DBReader.Read<BattlePetAbility>(@"TestFiles\BattlePetAbility.db2");
            Assert.IsNotNull(entry);
        }

        [TestMethod]
        public void SaveSimpleDB2()
        {
            var entry = DBReader.Read<BattlePetAbility>(@"TestFiles\BattlePetAbility.db2");
            Assert.IsNotNull(entry);

            DBReader.Write(entry, @"TestFiles\BattlePetAbility_Test.db2");

            byte[] original = File.ReadAllBytes(@"TestFiles\BattlePetAbility.db2");
            byte[] saved = File.ReadAllBytes(@"TestFiles\BattlePetAbility_Test.db2");
            CollectionAssert.AreEqual(original, saved);
        }

        [TestMethod]
        public void LoadComplexDB2()
        {
            var entry = DBReader.Read<BroadcastText>(@"TestFiles\BroadcastText.db2");
            Assert.IsNotNull(entry);
        }

        [TestMethod]
        public void SaveComplexDB2()
        {
            var entry = DBReader.Read<BroadcastText>(@"TestFiles\BroadcastText.db2");
            Assert.IsNotNull(entry);

            DBReader.Write(entry, @"TestFiles\BroadcastText_Test.db2");

            byte[] original = File.ReadAllBytes(@"TestFiles\BroadcastText.db2");
            byte[] saved = File.ReadAllBytes(@"TestFiles\BroadcastText_Test.db2");
            CollectionAssert.AreEqual(original, saved);
        }


        [ClassCleanup()]
        public static void ClassCleanup()
        {
            File.Delete(@"TestFiles\BattlePetAbility_Test.db2");
            File.Delete(@"TestFiles\BroadcastText_Test.db2");
        }
    }

    [DBTable(Expansion.MoP)]
    internal class BattlePetAbility
    {
        [DBKey]
        public int Id { get; set; }
        public int Field1 { get; set; }
        public int Field2 { get; set; }
        public int Field3 { get; set; }
        public int Field4 { get; set; }
        public int Field5 { get; set; }
        public string Field6 { get; set; }
        public string Field7 { get; set; }
    }

    [DBTable(Expansion.WoD)]
    internal class BroadcastText
    {
        [DBKey]
        public int Id { get; set; }
        public int Field1 { get; set; }
        public string Field2 { get; set; }
        public string Field3 { get; set; }

        [DBField(ArraySize: 3)]
        public int[] Field4 { get; set; }

        [DBField(ArraySize: 3)]
        public int[] Field5 { get; set; }

        public int Field6 { get; set; }
        public int Field7 { get; set; }
        public int Field8 { get; set; }
    }
}
