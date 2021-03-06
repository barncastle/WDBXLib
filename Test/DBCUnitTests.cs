﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WDBXLib.Reader;
using WDBXLib.Attributes;
using System.IO;
using static WDBXLib.Common.Constants;
using WDBXLib.Helpers;
using System.Collections.Generic;

namespace Test
{
    [TestClass]
    public class DBCUnitTests
    {
        [TestMethod]
        public void LoadSimpleDBC()
        {
            var entry = DBReader.Read<AttackAnimKits>(@"TestFiles\AttackAnimKits.dbc");
            Assert.IsNotNull(entry);
        }

        [TestMethod]
        public void SaveSimpleDBC()
        {
            var entry = DBReader.Read<AttackAnimKits>(@"TestFiles\AttackAnimKits.dbc");
            Assert.IsNotNull(entry);

            DBReader.Write(entry, @"TestFiles\AttackAnimKits_Test.dbc");

            byte[] original = File.ReadAllBytes(@"TestFiles\AttackAnimKits.dbc");
            byte[] saved = File.ReadAllBytes(@"TestFiles\AttackAnimKits_Test.dbc");

            CollectionAssert.AreEqual(original, saved);
        }

        [TestMethod]
        public void LoadArrayDBC()
        {
            var entry = DBReader.Read<CharacterFacialHairStyles>(@"TestFiles\CharacterFacialHairStyles.dbc");
            Assert.IsNotNull(entry);
        }

        [TestMethod]
        public void SaveArrayDBC()
        {
            var entry = DBReader.Read<CharacterFacialHairStyles>(@"TestFiles\CharacterFacialHairStyles.dbc");
            Assert.IsNotNull(entry);

            DBReader.Write(entry, @"TestFiles\CharacterFacialHairStyles_Test.dbc");

            byte[] original = File.ReadAllBytes(@"TestFiles\CharacterFacialHairStyles.dbc");
            byte[] saved = File.ReadAllBytes(@"TestFiles\CharacterFacialHairStyles_Test.dbc");

            CollectionAssert.AreEqual(original, saved);
        }

        [TestMethod]
        public void LoadLocalizedDBC()
        {
            var entry = DBReader.Read<WowError_Strings>(@"TestFiles\WowError_Strings.dbc");


            Assert.IsNotNull(entry);
        }

        [TestMethod]
        public void SaveLocalizedDBC()
        {
            var entry = DBReader.Read<WowError_Strings>(@"TestFiles\WowError_Strings.dbc");
            Assert.IsNotNull(entry);

            DBReader.Write(entry, @"TestFiles\WowError_Strings_Test.dbc");

            byte[] original = File.ReadAllBytes(@"TestFiles\WowError_Strings.dbc");
            byte[] saved = File.ReadAllBytes(@"TestFiles\WowError_Strings_Test.dbc");

            CollectionAssert.AreEqual(original, saved);
        }

        [TestMethod]
        public void FailAddDuplicates()
        {
            var entry = DBReader.Read<AttackAnimKits>(@"TestFiles\AttackAnimKits.dbc");
            var row = entry.Rows[0];

            Assert.ThrowsException<ArgumentException>(() => entry.Rows.Add(row));
        }

        [ClassCleanup()]
        public static void ClassCleanup()
        {
            File.Delete(@"TestFiles\AttackAnimKits_Test.dbc");
            File.Delete(@"TestFiles\CharacterFacialHairStyles_Test.dbc");
            File.Delete(@"TestFiles\WowError_Strings_Test.dbc");
        }

    }

    [DBTable(Expansion.WotLK)]
    internal class AttackAnimKits
    {
        [DBKey]
        public int Id { get; set; }
        public int Animation { get; set; }
        public int Type { get; set; }
        public int Flags { get; set; }
        public int Unknown { get; set; }
    }

    [DBTable(Expansion.WotLK)]
    internal class CharacterFacialHairStyles
    {
        [DBKey(AutoGenerated: true)]
        public int Id { get; set; }
        public int RaceId { get; set; }
        public int GenderId { get; set; }
        public int VariationId { get; set; }

        [DBField(ArraySize: 5)]
        public int[] GeoSetId { get; set; }
    }

    [DBTable(Expansion.WotLK)]
    internal class WowError_Strings
    {
        [DBKey]
        public int Id { get; set; }
        public string ErrorName { get; set; }
        public LocalizedString ErrorString { get; set; }
    }
}
