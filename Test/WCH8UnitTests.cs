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
    public class WCH8UnitTests
    {
        [TestMethod]
        public void LoadWCH8()
        {
            var counterpart = DBReader.ReadHeader(@"TestFiles\ArtifactPowerRank.db2");
            var entry = DBReader.Read<ArtifactPowerRank>(@"TestFiles\ArtifactPowerRank.adb", counterpart);
            Assert.IsNotNull(entry);
        }

        [TestMethod]
        public void SaveWCH8()
        {
            var counterpart = DBReader.ReadHeader(@"TestFiles\ArtifactPowerRank.db2");
            var entry = DBReader.Read<ArtifactPowerRank>(@"TestFiles\ArtifactPowerRank.adb", counterpart);
            Assert.IsNotNull(entry);

            DBReader.Write(entry, @"TestFiles\ArtifactPowerRank_Test.adb");

            byte[] original = File.ReadAllBytes(@"TestFiles\ArtifactPowerRank.adb");
            byte[] saved = File.ReadAllBytes(@"TestFiles\ArtifactPowerRank_Test.adb");
            CollectionAssert.AreEqual(original, saved);
        }

        [ClassCleanup()]
        public static void ClassCleanup()
        {
            File.Delete(@"TestFiles\ArtifactPowerRank_Test.adb");
        }
    }

    [DBTable(22578)]
    internal class ArtifactPowerRank
    {
        [DBKey]
        public int Id { get; set; }

        public int Field1 { get; set; }
        public float Field2 { get; set; }
        public ushort Field3 { get; set; }
        public ushort Field4 { get; set; }
        public byte Field5 { get; set; }
    }
}
