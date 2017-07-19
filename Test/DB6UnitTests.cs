using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using WDBXLib.Attributes;
using WDBXLib.Reader;

namespace WDBXTest
{
    [TestClass]
    public class DB6UnitTests
    {
        [TestMethod]
        public void LoadSimpleDB6()
        {
            var entry = DBReader.Read<Achievement_Category>(@"TestFiles\Achievement_Category.db2");
            Assert.IsNotNull(entry);
        }

        [TestMethod]
        public void SaveSimpleDB6()
        {
            var entry = DBReader.Read<Achievement_Category>(@"TestFiles\Achievement_Category.db2");
            Assert.IsNotNull(entry);

            DBReader.Write(entry, @"TestFiles\Achievement_Category_Test.db2");

            byte[] original = File.ReadAllBytes(@"TestFiles\Achievement_Category.db2");
            byte[] saved = File.ReadAllBytes(@"TestFiles\Achievement_Category_Test.db2");
            CollectionAssert.AreEqual(original, saved);
        }


        [TestMethod]
        public void LoadIndexMapDB6()
        {
            var entry = DBReader.Read<AnimKit>(@"TestFiles\AnimKit.db2");
            Assert.IsNotNull(entry);
        }

        [TestMethod]
        public void SaveIndexMapDB6()
        {
            var entry = DBReader.Read<AnimKit>(@"TestFiles\AnimKit.db2");
            Assert.IsNotNull(entry);

            DBReader.Write(entry, @"TestFiles\AnimKit_Test.db2");

            byte[] original = File.ReadAllBytes(@"TestFiles\AnimKit.db2");
            byte[] saved = File.ReadAllBytes(@"TestFiles\AnimKit_Test.db2");
            CollectionAssert.AreEqual(original, saved);
        }


        [TestMethod]
        public void LoadIndexOffsetMapDB6()
        {
            var entry = DBReader.Read<ConversationLine>(@"TestFiles\ConversationLine.db2");
            Assert.IsNotNull(entry);
        }

        [TestMethod]
        public void SaveIndexOffsetMapDB6()
        {
            var entry = DBReader.Read<ConversationLine>(@"TestFiles\ConversationLine.db2");
            Assert.IsNotNull(entry);

            DBReader.Write(entry, @"TestFiles\ConversationLine_Test.db2");

            byte[] original = File.ReadAllBytes(@"TestFiles\ConversationLine.db2");
            byte[] saved = File.ReadAllBytes(@"TestFiles\ConversationLine_Test.db2");

            CollectionAssert.AreEqual(original, saved);
        }


        [TestMethod]
        public void LoadAllFlagsDB6()
        {
            var entry = DBReader.Read<WmoMiniMapTexture>(@"TestFiles\WmoMiniMapTexture.db2");
            Assert.IsNotNull(entry);
        }

        [TestMethod]
        public void SaveAllFlagsDB6()
        {
            var entry = DBReader.Read<WmoMiniMapTexture>(@"TestFiles\WmoMiniMapTexture.db2");
            Assert.IsNotNull(entry);

            DBReader.Write(entry, @"TestFiles\WmoMiniMapTexture_Test.db2");

            byte[] original = File.ReadAllBytes(@"TestFiles\WmoMiniMapTexture.db2");
            byte[] saved = File.ReadAllBytes(@"TestFiles\WmoMiniMapTexture_Test.db2");

            CollectionAssert.AreEqual(original, saved);
        }


        [TestMethod]
        public void LoadDefaultValueDB6()
        {
            var entry = DBReader.Read<SpellXSpellVisual>(@"TestFiles\SpellXSpellVisual.db2");
            Assert.IsNotNull(entry);
            Assert.AreEqual(entry.Rows[0].Chance, 1f);            
        }

        [TestMethod]
        public void SaveDefaultValueDB6()
        {
            var entry = DBReader.Read<SpellXSpellVisual>(@"TestFiles\SpellXSpellVisual.db2");
            Assert.IsNotNull(entry);

            DBReader.Write(entry, @"TestFiles\SpellXSpellVisual_Test.db2");

            byte[] original = File.ReadAllBytes(@"TestFiles\SpellXSpellVisual.db2");
            byte[] saved = File.ReadAllBytes(@"TestFiles\SpellXSpellVisual_Test.db2");

            CollectionAssert.AreEqual(original, saved);
        }


        [ClassCleanup()]
        public static void ClassCleanup()
        {
            File.Delete(@"TestFiles\Achievement_Category_Test.db2");
            File.Delete(@"TestFiles\AnimKit_Test.db2");
            File.Delete(@"TestFiles\ConversationLine_Test.db2");
            File.Delete(@"TestFiles\WmoMiniMapTexture_Test.db2");
            File.Delete(@"TestFiles\SpellXSpellVisual_Test.db2");
        }
    }

    [DBTable(22578)]
    internal class Achievement_Category
    {
        public string Field0 { get; set; }
        public ushort Field4 { get; set; }
        public byte Field6 { get; set; }

        [DBKey]
        public int Id { get; set; }
    }

    [DBTable(24461)]
    internal class AnimKit
    {
        [DBKey]
        public int Id { get; set; }
        public uint OneShotDuration { get; set; }
        public ushort OneShotStopAnimKitID { get; set; }
        public ushort LowDefAnimKitID { get; set; }
    }

    [DBTable(23835)]
    internal class ConversationLine
    {
        [DBKey]
        public int Id { get; set; }
        public uint Field2 { get; set; }
        public uint Field3 { get; set; }
        public int Field4 { get; set; }
        public ushort Field5 { get; set; }
        public ushort Field6 { get; set; }
        public byte Field7 { get; set; }
        public byte Field8 { get; set; }
        public byte Field9 { get; set; }
    }

    [DBTable(23835)]
    internal class WmoMiniMapTexture
    {
        [DBKey]
        public int Id { get; set; }
        public uint Field1 { get; set; }
        public ushort Field2 { get; set; }
        public ushort Field3 { get; set; }
        public byte Field4 { get; set; }
        public byte Field5 { get; set; }
    }

    [DBTable(23835)]
    internal class SpellXSpellVisual
    {
        public uint SpellID { get; set; }
        public uint SpellVisualID { get; set; }

        [DBKey]
        public int Id { get; set; }

        [DBField(DefaultValue: 1.0f)]
        public float Chance { get; set; }
        public ushort CasterPlayerConditionID { get; set; }
        public ushort CasterUnitConditionID { get; set; }
        public ushort PlayerConditionID { get; set; }
        public ushort UnitConditionID { get; set; }
        public uint IconFileDataID { get; set; }
        public uint ActiveIconFileDataID { get; set; }
        public byte Flags { get; set; }
        public byte DifficultyID { get; set; }
        public byte Priority { get; set; }
    }
}
