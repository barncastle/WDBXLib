using System;
using WDBXLib.Attributes;
using WDBXLib.Helpers;
using static WDBXLib.Common.Constants;

namespace WDBXLib.Definitions.Cata
{

    [DBTable(Expansion.Cata)]
    public class Achievement
    {
        [DBKey]
        public int Id { get; set; }
        public int FactionFlag { get; set; }
        public int MapId { get; set; }
        public uint ParentAchievement { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public uint CategoryId { get; set; }
        public uint RewardPoints { get; set; }
        public uint OrderInCategory { get; set; }
        public uint Flags { get; set; }
        public uint IconId { get; set; }
        public string Reward { get; set; }
        public uint ReqCriteriasCount { get; set; }
        public uint RefAchievement { get; set; }
    }

    [DBTable(Expansion.Cata)]
    public class Achievement_Category
    {
        [DBKey]
        public int Id { get; set; }
        public int Field00 { get; set; }
        public string Field01 { get; set; }
        public int Field02 { get; set; }
    }

    [DBTable(Expansion.Cata)]
    public class Achievement_Criteria
    {
        [DBKey]
        public int ID { get; set; }
        public int Achievement_id { get; set; }
        public int Type { get; set; }
        public int Asset_id { get; set; }
        public int Quantity { get; set; }
        public int Field5 { get; set; }
        public int Start_event { get; set; }
        public int Start_asset { get; set; }
        public int Fail_event { get; set; }
        public int Fail_asset { get; set; }
        public string Description { get; set; }
        public int Flags { get; set; }
        public int Timer_start_event { get; set; }
        public int Timer_asset_id { get; set; }
        public int Timer_time { get; set; }
        public int Ui_order { get; set; }
        public int Field16 { get; set; }
        public int Req_type1 { get; set; }
        public int Req_type2 { get; set; }
        public int Req_type3 { get; set; }
        public int Req_value1 { get; set; }
        public int Req_value2 { get; set; }
        public int Req_value3 { get; set; }
    }

    [DBTable(Expansion.Cata)]
    public class AnimationData
    {
        [DBKey]
        public int Id { get; set; }
        public string Field00 { get; set; }
        public int Field01 { get; set; }
        public int Field02 { get; set; }
        public int Field03 { get; set; }
        public int Field04 { get; set; }
    }

    [DBTable(Expansion.Cata)]
    public class AnimKit
    {
        [DBKey]
        public int Id { get; set; }
        public int Field00 { get; set; }
        public int Field01 { get; set; }
    }

    [DBTable(Expansion.Cata)]
    public class AnimKitBoneSet
    {
        [DBKey]
        public int Id { get; set; }
        public string Field1 { get; set; }
        public int Field2 { get; set; }
        public int Field3 { get; set; }
        public uint Field4 { get; set; }
        public int Field5 { get; set; }
    }

    [DBTable(Expansion.Cata)]
    public class AnimKitBoneSetAlias
    {
        [DBKey]
        public int Id { get; set; }
        public int Field00 { get; set; }
        public int Field01 { get; set; }
    }

    [DBTable(Expansion.Cata)]
    public class AnimKitConfig
    {
        [DBKey]
        public int Id { get; set; }
        public int Field00 { get; set; }
    }

    [DBTable(Expansion.Cata)]
    public class AnimKitConfigBoneSet
    {
        [DBKey]
        public int Id { get; set; }
        public int Field00 { get; set; }
        public int Field01 { get; set; }
        public int Field02 { get; set; }
    }

    [DBTable(Expansion.Cata)]
    public class AnimKitPriority
    {
        [DBKey]
        public int Id { get; set; }
        public int Field00 { get; set; }
    }

    [DBTable(Expansion.Cata)]
    public class AnimKitSegment
    {
        [DBKey]
        public int Id { get; set; }
        public int Field00 { get; set; }
        public int Field01 { get; set; }
        public int Field02 { get; set; }
        public int Field03 { get; set; }
        public int Field04 { get; set; }
        public int Field05 { get; set; }
        public int Field06 { get; set; }
        public int Field07 { get; set; }
        public int Field08 { get; set; }
        public int Field09 { get; set; }
        public int Field0A { get; set; }
        public int Field0B { get; set; }
        public int Field0C { get; set; }
        public int Field0D { get; set; }
        public int Field0E { get; set; }
    }

    [DBTable(Expansion.Cata)]
    public class AnimReplacement
    {
        [DBKey]
        public int Id { get; set; }
        public int Field00 { get; set; }
        public int Field01 { get; set; }
        public int Field02 { get; set; }
    }

    [DBTable(Expansion.Cata)]
    public class AnimReplacementSet
    {
        [DBKey]
        public int Id { get; set; }
        public int Field00 { get; set; }
    }

    [DBTable(Expansion.Cata)]
    public class AreaAssignment
    {
        [DBKey]
        public int Field0 { get; set; }
        public int Field1 { get; set; }
        public int Field2 { get; set; }
        public int Field3 { get; set; }
        public int Field4 { get; set; }
    }

    [DBTable(Expansion.Cata)]
    public class AreaGroup
    {
        [DBKey]
        public int Field0 { get; set; }
        public int Field1 { get; set; }
        public int Field2 { get; set; }
        public int Field3 { get; set; }
        public int Field4 { get; set; }
        public int Field5 { get; set; }
        public int Field6 { get; set; }
        public int Field7 { get; set; }
    }

    [DBTable(Expansion.Cata)]
    public class AreaPOI
    {
        [DBKey]
        public int ID { get; set; }
        public int Importance { get; set; }
        [DBField(ArraySize: 9)]
        public int[] Icon { get; set; }
        public int FactionID { get; set; }
        public float X { get; set; }
        public float Y { get; set; }
        public int ContinentID { get; set; }
        public int Flags { get; set; }
        public int AreaID { get; set; }
        public string Name_lang { get; set; }
        public string Description_lang { get; set; }
        public int WorldStateID { get; set; }
        public int WorldMapLink { get; set; }
        public int Unknown { get; set; }
    }

    [DBTable(Expansion.Cata)]
    public class AreaPOISortedWorldState
    {
        [DBKey]
        public int Id { get; set; }
        public int Field00 { get; set; }
        public int Field01 { get; set; }
    }

    [DBTable(Expansion.Cata)]
    public class AreaTable
    {
        [DBKey]
        public int ID { get; set; }
        public int ContinentID { get; set; }
        public int ParentAreaID { get; set; }
        public int AreaBit { get; set; }
        public int Flags { get; set; }
        public int SoundProviderPref { get; set; }
        public int SoundProviderPrefUnderwater { get; set; }
        public int AmbienceID { get; set; }
        public int ZoneMusic { get; set; }
        public int IntroSound { get; set; }
        public int ExplorationLevel { get; set; }
        public string AreaName_lang { get; set; }
        public int FactionGroupMask { get; set; }
        public int LiquidTypeID_1 { get; set; }
        public int LiquidTypeID_2 { get; set; }
        public int LiquidTypeID_3 { get; set; }
        public int LiquidTypeID_4 { get; set; }
        public float MinElevation { get; set; }
        public float Ambient_multiplier { get; set; }
        public int Lightid { get; set; }
        public int NewField20 { get; set; }
        public int NewField21 { get; set; }
        public int NewField22 { get; set; }
        public int NewField23 { get; set; }
        public int NewField24 { get; set; }
        public int NewField25 { get; set; }
    }

    [DBTable(Expansion.Cata)]
    public class AreaTrigger
    {
        [DBKey]
        public int Id { get; set; }
        public int MapId { get; set; }
        public float PosX { get; set; }
        public float PosY { get; set; }
        public float PosZ { get; set; }
        public int Field5 { get; set; }
        public int Field6 { get; set; }
        public int Field7 { get; set; }
        public float Field8 { get; set; }
        public float Field9 { get; set; }
        public float Field10 { get; set; }
        public float Field11 { get; set; }
        public float Field12 { get; set; }
    }

    [DBTable(Expansion.Cata)]
    public class Armorlocation
    {
        [DBKey]
        public int Field0 { get; set; }
        public float Field1 { get; set; }
        public float Field2 { get; set; }
        public float Field3 { get; set; }
        public float Field4 { get; set; }
        public float Field5 { get; set; }
    }

    [DBTable(Expansion.Cata)]
    public class AttackAnimKits
    {
        [DBKey]
        public int Id { get; set; }
        public int Field00 { get; set; }
        public int Field01 { get; set; }
        public int Field02 { get; set; }
        public int Field03 { get; set; }
    }

    [DBTable(Expansion.Cata)]
    public class AttackAnimTypes
    {
        [DBKey]
        public int Id { get; set; }
        public string Field00 { get; set; }
    }

    [DBTable(Expansion.Cata)]
    public class AuctionHouse
    {
        [DBKey]
        public int Id { get; set; }
        public int Field00 { get; set; }
        public int Field01 { get; set; }
        public int Field02 { get; set; }
        public string Field03 { get; set; }
    }

    [DBTable(Expansion.Cata)]
    public class BankBagSlotPrices
    {
        [DBKey]
        public int Id { get; set; }
        public int Field00 { get; set; }
    }

    [DBTable(Expansion.Cata)]
    public class BannedAddOns
    {
        [DBKey]
        public int Id { get; set; }
        public int Field00 { get; set; }
        public int Field01 { get; set; }
        public int Field02 { get; set; }
        public int Field03 { get; set; }
        public int Field04 { get; set; }
        public int Field05 { get; set; }
        public int Field06 { get; set; }
        public int Field07 { get; set; }
        public int Field08 { get; set; }
        public int Field09 { get; set; }
    }

    [DBTable(Expansion.Cata)]
    public class BarberShopStyle
    {
        [DBKey]
        public int Id { get; set; }
        public int Field00 { get; set; }
        public string Field01 { get; set; }
        public int Field02 { get; set; }
        public float Field03 { get; set; }
        public int Field04 { get; set; }
        public string Field05 { get; set; }
        public int Field06 { get; set; }
    }

    [DBTable(Expansion.Cata)]
    public class BattlemasterList
    {
        [DBKey]
        public int Id { get; set; }
        public int MapId_1 { get; set; }
        public int MapId_2 { get; set; }
        public int MapId_3 { get; set; }
        public int MapId_4 { get; set; }
        public int MapId_5 { get; set; }
        public int MapId_6 { get; set; }
        public int MapId_7 { get; set; }
        public int MapId_8 { get; set; }
        public int MapType { get; set; }
        public int CanJoinAsGroup { get; set; }
        public string Name { get; set; }
        public int MaxGroupSize { get; set; }
        public int HolidayWorldStateId { get; set; }
        public int MinLevel { get; set; }
        public int MaxLevel { get; set; }
        public int MaxGroupSizeRated { get; set; }
        public int MaxPlayers { get; set; }
        public int UnkRated { get; set; }
        public int NewField { get; set; }
    }

    [DBTable(Expansion.Cata)]
    public class CameraMode
    {
        [DBKey]
        public int Field0 { get; set; }
        public string Field1 { get; set; }
        public int Field2 { get; set; }
        public int Field3 { get; set; }
        public float Field4 { get; set; }
        public float Field5 { get; set; }
        public float Field6 { get; set; }
        public float Field7 { get; set; }
        public float Field8 { get; set; }
        public float Field9 { get; set; }
        public float Field10 { get; set; }
        public float Field11 { get; set; }
        public float Field12 { get; set; }
        public int Field13 { get; set; }
        public int Field14 { get; set; }
        public int Field15 { get; set; }
        public int Field16 { get; set; }
    }

    [DBTable(Expansion.Cata)]
    public class CameraShakes
    {
        [DBKey]
        public int Id { get; set; }
        public int Field00 { get; set; }
        public int Field01 { get; set; }
        public float Field02 { get; set; }
        public float Field03 { get; set; }
        public float Field04 { get; set; }
        public int Field05 { get; set; }
        public int Field06 { get; set; }
        public int Field07 { get; set; }
    }

    [DBTable(Expansion.Cata)]
    public class CastableRaidBuffs
    {
        [DBKey]
        public int Id { get; set; }
        public int Field00 { get; set; }
        public int Field01 { get; set; }
    }

    [DBTable(Expansion.Cata)]
    public class Cfg_Categories
    {
        [DBKey]
        public int Id { get; set; }
        public int Field00 { get; set; }
        public int Field01 { get; set; }
        public int Field02 { get; set; }
        public string Field03 { get; set; }
        public string Field04 { get; set; }
    }

    [DBTable(Expansion.Cata)]
    public class Cfg_Configs
    {
        [DBKey]
        public int Id { get; set; }
        public int Field00 { get; set; }
        public int Field01 { get; set; }
        public int Field02 { get; set; }
        public int Field03 { get; set; }
    }

    [DBTable(Expansion.Cata)]
    public class CharacterFacialHairStyles
    {
        [DBKey]
        public int Id { get; set; }
        public int Field00 { get; set; }
        public int Field01 { get; set; }
        public int Field02 { get; set; }
        public int Field03 { get; set; }
        public int Field04 { get; set; }
        public int Field05 { get; set; }
        public int Field06 { get; set; }
        public int Field07 { get; set; }
    }

    [DBTable(Expansion.Cata)]
    public class CharBaseInfo
    {
        [DBKey(AutoGenerated: true)]
        public int GeneratedID { get; set; }
        public byte RaceID { get; set; }
        public byte ClassID { get; set; }
    }

    [DBTable(Expansion.Cata)]
    public class CharHairGeosets
    {
        [DBKey]
        public int Id { get; set; }
        public int Field00 { get; set; }
        public int Field01 { get; set; }
        public int Field02 { get; set; }
        public int Field03 { get; set; }
        public int Field04 { get; set; }
    }

    [DBTable(Expansion.Cata)]
    public class CharSections
    {
        [DBKey]
        public int Id { get; set; }
        public int Field00 { get; set; }
        public string Field01 { get; set; }
        public int Field02 { get; set; }
        public string Field03 { get; set; }
        public string Field04 { get; set; }
        public string Field05 { get; set; }
        public int Field06 { get; set; }
        public int Field07 { get; set; }
        public int Field08 { get; set; }
    }

    [DBTable(Expansion.Cata)]
    public class CharStartOutfit
    {
        [DBKey]
        public int ID { get; set; }
        public byte RaceID { get; set; }
        public byte ClassID { get; set; }
        public byte SexID { get; set; }
        public byte OutfitID { get; set; }
        [DBField(ArraySize: 24)]
        public int[] ItemID { get; set; }
        [DBField(ArraySize: 24)]
        public int[] DisplayItemID { get; set; }
        [DBField(ArraySize: 24)]
        public int[] InventoryType { get; set; }
    }

    [DBTable(Expansion.Cata)]
    public class CharTitles
    {
        [DBKey]
        public int Id { get; set; }
        public int Field00 { get; set; }
        public string Field01 { get; set; }
        public string Field02 { get; set; }
        public int Field03 { get; set; }
        public int Field04 { get; set; }
    }

    [DBTable(Expansion.Cata)]
    public class ChatChannels
    {
        [DBKey]
        public int Id { get; set; }
        public int Field00 { get; set; }
        public int Field01 { get; set; }
        public string Field02 { get; set; }
        public string Field03 { get; set; }
    }

    [DBTable(Expansion.Cata)]
    public class ChatProfanity
    {
        [DBKey]
        public int Id { get; set; }
        public string Field00 { get; set; }
        public int Field01 { get; set; }
    }

    [DBTable(Expansion.Cata)]
    public class ChrClasses
    {
        [DBKey]
        public int Field0 { get; set; }
        public int Field1 { get; set; }
        public string Field2 { get; set; }
        public string Field3 { get; set; }
        public int Field4 { get; set; }
        public int Field5 { get; set; }
        public string Field6 { get; set; }
        public int Field7 { get; set; }
        public int Field8 { get; set; }
        public int Field9 { get; set; }
        public int Field10 { get; set; }
        public int Field11 { get; set; }
        public int Field12 { get; set; }
        public int Field13 { get; set; }
    }

    [DBTable(Expansion.Cata)]
    public class ChrClassesXPowerTypes
    {
        [DBKey]
        public int Id { get; set; }
        public int Field00 { get; set; }
        public int Field01 { get; set; }
    }

    [DBTable(Expansion.Cata)]
    public class ChrRaces
    {
        [DBKey]
        public int Field0 { get; set; }
        public int Field1 { get; set; }
        public int Field2 { get; set; }
        public int Field3 { get; set; }
        public int Field4 { get; set; }
        public int Field5 { get; set; }
        public string Field6 { get; set; }
        public int Field7 { get; set; }
        public int Field8 { get; set; }
        public int Field9 { get; set; }
        public int Field10 { get; set; }
        public string Field11 { get; set; }
        public int Field12 { get; set; }
        public int Field13 { get; set; }
        public string Field14 { get; set; }
        public int Field55 { get; set; }
        public int Field56 { get; set; }
        public string Field62 { get; set; }
        public string Field63 { get; set; }
        public string Field64 { get; set; }
        public int Field65 { get; set; }
        public int Field66 { get; set; }
        public int Field67 { get; set; }
        public int Field68 { get; set; }
    }

    [DBTable(Expansion.Cata)]
    public class CinematicCamera
    {
        [DBKey]
        public int Id { get; set; }
        public string Field00 { get; set; }
        public int Field01 { get; set; }
        public int Field02 { get; set; }
        public int Field03 { get; set; }
        public int Field04 { get; set; }
        public int Field05 { get; set; }
    }

    [DBTable(Expansion.Cata)]
    public class CinematicSequences
    {
        [DBKey]
        public int Id { get; set; }
        public int Field00 { get; set; }
        public int Field01 { get; set; }
        public int Field02 { get; set; }
        public int Field03 { get; set; }
        public int Field04 { get; set; }
        public int Field05 { get; set; }
        public int Field06 { get; set; }
        public int Field07 { get; set; }
        public int Field08 { get; set; }
    }

    [DBTable(Expansion.Cata)]
    public class Creature
    {
        [DBKey]
        public int Field0 { get; set; }
        public int Field1 { get; set; }
        public int Field2 { get; set; }
        public int Field3 { get; set; }
        public int Field4 { get; set; }
        public int Field5 { get; set; }
        public int Field6 { get; set; }
        public int Field7 { get; set; }
        public int Field8 { get; set; }
        public int Field9 { get; set; }
        public int Field10 { get; set; }
        public float Field11 { get; set; }
        public float Field12 { get; set; }
        public float Field13 { get; set; }
        public float Field14 { get; set; }
        public uint Field15 { get; set; }
        public string Field16 { get; set; }
        public int Field17 { get; set; }
    }

    [DBTable(Expansion.Cata)]
    public class Creaturecache
    {
        [DBKey]
        public int Entry { get; set; }
        public string Name { get; set; }
        public string Name2 { get; set; }
        public string Name3 { get; set; }
        public string Name4 { get; set; }
        public string Name5 { get; set; }
        public string Name6 { get; set; }
        public string Name7 { get; set; }
        public string Name8 { get; set; }
        public string SubName { get; set; }
        public string IconName { get; set; }
        public ulong Flags { get; set; }
        public int Type { get; set; }
        public int Family { get; set; }
        public int Rank { get; set; }
        public int KillCredit1 { get; set; }
        public int KillCredit2 { get; set; }
        public int Modelid1 { get; set; }
        public int Modelid2 { get; set; }
        public int Modelid3 { get; set; }
        public int Modelid4 { get; set; }
        public float HealthModifier { get; set; }
        public float PowerModifier { get; set; }
        public byte RacialLeader { get; set; }
        public int QuestItem_1 { get; set; }
        public int QuestItem_2 { get; set; }
        public int QuestItem_3 { get; set; }
        public int QuestItem_4 { get; set; }
        public int QuestItem_5 { get; set; }
        public int QuestItem_6 { get; set; }
        public int MovementId { get; set; }
        public int Unk1 { get; set; }
    }

    [DBTable(Expansion.Cata)]
    public class CreatureDisplayInfo
    {
        [DBKey]
        public int Field0 { get; set; }
        public int Field1 { get; set; }
        public int Field2 { get; set; }
        public int Field3 { get; set; }
        public float Field4 { get; set; }
        public int Field5 { get; set; }
        public string Field6 { get; set; }
        public string Field7 { get; set; }
        public string Field8 { get; set; }
        public string Field9 { get; set; }
        public int Field10 { get; set; }
        public int Field11 { get; set; }
        public int Field12 { get; set; }
        public int Field13 { get; set; }
        public int Field14 { get; set; }
        public int Field15 { get; set; }
        public int Field16 { get; set; }
    }

    [DBTable(Expansion.Cata)]
    public class CreatureDisplayInfoExtra
    {
        [DBKey]
        public int Id { get; set; }
        public int Field00 { get; set; }
        public string Field01 { get; set; }
        public int Field02 { get; set; }
        public int Field03 { get; set; }
        public int Field04 { get; set; }
        public int Field05 { get; set; }
        public int Field06 { get; set; }
        public int Field07 { get; set; }
        public int Field08 { get; set; }
        public int Field09 { get; set; }
        public int Field0A { get; set; }
        public int Field0B { get; set; }
        public int Field0C { get; set; }
        public int Field0D { get; set; }
        public int Field0E { get; set; }
        public int Field0F { get; set; }
        public int Field10 { get; set; }
        public int Field11 { get; set; }
        public string Field12 { get; set; }
        public string Field13 { get; set; }
    }

    [DBTable(Expansion.Cata)]
    public class CreatureFamily
    {
        [DBKey]
        public int Id { get; set; }
        public int Field00 { get; set; }
        public string Field01 { get; set; }
        public int Field02 { get; set; }
        public int Field03 { get; set; }
        public int Field04 { get; set; }
        public int Field05 { get; set; }
        public int Field06 { get; set; }
        public int Field07 { get; set; }
        public int Field08 { get; set; }
        public string Field09 { get; set; }
        public string Field0A { get; set; }
    }

    [DBTable(Expansion.Cata)]
    public class CreatureImmunities
    {
        [DBKey]
        public int Id { get; set; }
        public int Field00 { get; set; }
        public int Field01 { get; set; }
        public int Field02 { get; set; }
        public int Field03 { get; set; }
        public int Field04 { get; set; }
        public int Field05 { get; set; }
        public int Field06 { get; set; }
        public int Field07 { get; set; }
        public int Field08 { get; set; }
        public int Field09 { get; set; }
        public int Field0A { get; set; }
        public int Field0B { get; set; }
        public int Field0C { get; set; }
        public int Field0D { get; set; }
        public int Field0E { get; set; }
        public int Field0F { get; set; }
        public int Field10 { get; set; }
        public int Field11 { get; set; }
        public int Field12 { get; set; }
        public int Field13 { get; set; }
        public int Field14 { get; set; }
        public int Field15 { get; set; }
        public int Field16 { get; set; }
        public int Field17 { get; set; }
        public int Field18 { get; set; }
    }

    [DBTable(Expansion.Cata)]
    public class CreatureModelData
    {
        [DBKey]
        public int Field0 { get; set; }
        public int Field1 { get; set; }
        public string Field2 { get; set; }
        public int Field3 { get; set; }
        public float Field4 { get; set; }
        public int Field5 { get; set; }
        public int Field6 { get; set; }
        public float Field7 { get; set; }
        public float Field8 { get; set; }
        public float Field9 { get; set; }
        public int Field10 { get; set; }
        public int Field11 { get; set; }
        public int Field12 { get; set; }
        public int Field13 { get; set; }
        public float Field14 { get; set; }
        public float Field15 { get; set; }
        public float Field16 { get; set; }
        public float Field17 { get; set; }
        public float Field18 { get; set; }
        public float Field19 { get; set; }
        public int Field20 { get; set; }
        public int Field21 { get; set; }
        public int Field22 { get; set; }
        public int Field23 { get; set; }
        public int Field24 { get; set; }
        public int Field25 { get; set; }
        public int Field26 { get; set; }
        public int Field27 { get; set; }
        public int Field28 { get; set; }
        public int Field29 { get; set; }
        public int Field30 { get; set; }
    }

    [DBTable(Expansion.Cata)]
    public class CreatureMovementInfo
    {
        [DBKey]
        public int Id { get; set; }
        public int Field00 { get; set; }
    }

    [DBTable(Expansion.Cata)]
    public class CreatureSoundData
    {
        [DBKey]
        public int Id { get; set; }
        public int Field00 { get; set; }
        public int Field01 { get; set; }
        public int Field02 { get; set; }
        public int Field03 { get; set; }
        public int Field04 { get; set; }
        public int Field05 { get; set; }
        public int Field06 { get; set; }
        public int Field07 { get; set; }
        public int Field08 { get; set; }
        public int Field09 { get; set; }
        public int Field0A { get; set; }
        public int Field0B { get; set; }
        public int Field0C { get; set; }
        public int Field0D { get; set; }
        public int Field0E { get; set; }
        public int Field0F { get; set; }
        public int Field10 { get; set; }
        public int Field11 { get; set; }
        public int Field12 { get; set; }
        public int Field13 { get; set; }
        public int Field14 { get; set; }
        public int Field15 { get; set; }
        public int Field16 { get; set; }
        public int Field17 { get; set; }
        public int Field18 { get; set; }
        public int Field19 { get; set; }
        public int Field1A { get; set; }
        public int Field1B { get; set; }
        public int Field1C { get; set; }
        public int Field1D { get; set; }
        public int Field1E { get; set; }
        public int Field1F { get; set; }
        public int Field20 { get; set; }
        public int Field21 { get; set; }
        public int Field22 { get; set; }
        public int Field23 { get; set; }
        public int Field24 { get; set; }
        public int Field25 { get; set; }
        public int Field26 { get; set; }
    }

    [DBTable(Expansion.Cata)]
    public class CreatureSpellData
    {
        [DBKey]
        public int Id { get; set; }
        public int Field00 { get; set; }
        public int Field01 { get; set; }
        public int Field02 { get; set; }
        public int Field03 { get; set; }
        public int Field04 { get; set; }
        public int Field05 { get; set; }
        public int Field06 { get; set; }
        public int Field07 { get; set; }
    }

    [DBTable(Expansion.Cata)]
    public class CreatureType
    {
        [DBKey]
        public int Id { get; set; }
        public string Name { get; set; }
        public int Unk1 { get; set; }
    }

    [DBTable(Expansion.Cata)]
    public class CurrencyCategory
    {
        [DBKey]
        public int Category { get; set; }
        public uint Unk1 { get; set; }
        public string Name { get; set; }
    }

    [DBTable(Expansion.Cata)]
    public class CurrencyTypes
    {
        [DBKey]
        public int Id { get; set; }
        public int Category { get; set; }
        public string Name { get; set; }
        public string IconName { get; set; }
        public int Field4 { get; set; }
        public int Field5 { get; set; }
        public int Field6 { get; set; }
        public int Field7 { get; set; }
        public int Field8 { get; set; }
        public int Field9 { get; set; }
        public string Desc { get; set; }
    }

    [DBTable(Expansion.Cata)]
    public class DanceMoves
    {
        [DBKey]
        public int Id { get; set; }
        public int Field00 { get; set; }
        public int Field01 { get; set; }
        public string Field02 { get; set; }
        public int Field03 { get; set; }
        public string Field04 { get; set; }
        public string Field05 { get; set; }
        public int Field06 { get; set; }
    }

    [DBTable(Expansion.Cata)]
    public class DeathThudLookups
    {
        [DBKey]
        public int Id { get; set; }
        public int Field00 { get; set; }
        public int Field01 { get; set; }
        public int Field02 { get; set; }
        public int Field03 { get; set; }
    }

    [DBTable(Expansion.Cata)]
    public class DeclinedWord
    {
        [DBKey]
        public int Id { get; set; }
        public string Field00 { get; set; }
    }

    [DBTable(Expansion.Cata)]
    public class DeclinedWordCases
    {
        [DBKey]
        public int Id { get; set; }
        public int Field00 { get; set; }
        public int Field01 { get; set; }
        public string Field02 { get; set; }
    }

    [DBTable(Expansion.Cata)]
    public class DestructibleModelData
    {
        [DBKey]
        public int Id { get; set; }
        public int Field00 { get; set; }
        public int Field01 { get; set; }
        public int Field02 { get; set; }
        public int Field03 { get; set; }
        public int Field04 { get; set; }
        public int Field05 { get; set; }
        public int Field06 { get; set; }
        public int Field07 { get; set; }
        public int Field08 { get; set; }
        public int Field09 { get; set; }
        public int Field0A { get; set; }
        public int Field0B { get; set; }
        public int Field0C { get; set; }
        public int Field0D { get; set; }
        public int Field0E { get; set; }
        public int Field0F { get; set; }
        public int Field10 { get; set; }
        public int Field11 { get; set; }
        public int Field12 { get; set; }
        public int Field13 { get; set; }
        public int Field14 { get; set; }
        public int Field15 { get; set; }
        public int Field16 { get; set; }
    }

    [DBTable(Expansion.Cata)]
    public class DungeonEncounter
    {
        [DBKey]
        public int Field0 { get; set; }
        public int Field1 { get; set; }
        public int Field2 { get; set; }
        public int Field3 { get; set; }
        public int Field4 { get; set; }
        public string Field5 { get; set; }
        public int Field6 { get; set; }
        public int Field7 { get; set; }
    }

    [DBTable(Expansion.Cata)]
    public class DungeonMap
    {
        [DBKey]
        public int Field0 { get; set; }
        public int Field1 { get; set; }
        public int Field2 { get; set; }
        public float Field3 { get; set; }
        public float Field4 { get; set; }
        public float Field5 { get; set; }
        public float Field6 { get; set; }
        public int Field7 { get; set; }
    }

    [DBTable(Expansion.Cata)]
    public class DungeonMapChunk
    {
        [DBKey]
        public int Id { get; set; }
        public int Field00 { get; set; }
        public int Field01 { get; set; }
        public int Field02 { get; set; }
        public int Field03 { get; set; }
    }

    [DBTable(Expansion.Cata)]
    public class DurabilityCosts
    {
        [DBKey]
        public int Id { get; set; }
        public int Field00 { get; set; }
        public int Field01 { get; set; }
        public int Field02 { get; set; }
        public int Field03 { get; set; }
        public int Field04 { get; set; }
        public int Field05 { get; set; }
        public int Field06 { get; set; }
        public int Field07 { get; set; }
        public int Field08 { get; set; }
        public int Field09 { get; set; }
        public int Field0A { get; set; }
        public int Field0B { get; set; }
        public int Field0C { get; set; }
        public int Field0D { get; set; }
        public int Field0E { get; set; }
        public int Field0F { get; set; }
        public int Field10 { get; set; }
        public int Field11 { get; set; }
        public int Field12 { get; set; }
        public int Field13 { get; set; }
        public int Field14 { get; set; }
        public int Field15 { get; set; }
        public int Field16 { get; set; }
        public int Field17 { get; set; }
        public int Field18 { get; set; }
        public int Field19 { get; set; }
        public int Field1A { get; set; }
        public int Field1B { get; set; }
        public int Field1C { get; set; }
    }

    [DBTable(Expansion.Cata)]
    public class DurabilityQuality
    {
        [DBKey]
        public int Id { get; set; }
        public int Field00 { get; set; }
    }

    [DBTable(Expansion.Cata)]
    public class Emotes
    {
        [DBKey]
        public int Id { get; set; }
        public string Field00 { get; set; }
        public int Field01 { get; set; }
        public int Field02 { get; set; }
        public int Field03 { get; set; }
        public int Field04 { get; set; }
        public int Field05 { get; set; }
        public int Field06 { get; set; }
    }

    [DBTable(Expansion.Cata)]
    public class EmotesText
    {
        [DBKey]
        public int Id { get; set; }
        public string Field00 { get; set; }
        public int Field01 { get; set; }
        public int Field02 { get; set; }
        public int Field03 { get; set; }
        public int Field04 { get; set; }
        public int Field05 { get; set; }
        public int Field06 { get; set; }
        public int Field07 { get; set; }
        public int Field08 { get; set; }
        public int Field09 { get; set; }
        public int Field0A { get; set; }
        public int Field0B { get; set; }
        public int Field0C { get; set; }
        public int Field0D { get; set; }
        public int Field0E { get; set; }
        public int Field0F { get; set; }
        public int Field10 { get; set; }
        public int Field11 { get; set; }
    }

    [DBTable(Expansion.Cata)]
    public class EmotesTextData
    {
        [DBKey]
        public int Id { get; set; }
        public string Field00 { get; set; }
    }

    [DBTable(Expansion.Cata)]
    public class EmotesTextSound
    {
        [DBKey]
        public int Id { get; set; }
        public int Field00 { get; set; }
        public int Field01 { get; set; }
        public int Field02 { get; set; }
        public int Field03 { get; set; }
    }

    [DBTable(Expansion.Cata)]
    public class EnvironmentalDamage
    {
        [DBKey]
        public int Id { get; set; }
        public int Field00 { get; set; }
        public int Field01 { get; set; }
    }

    [DBTable(Expansion.Cata)]
    public class Exhaustion
    {
        [DBKey]
        public int Id { get; set; }
        public int Field00 { get; set; }
        public float Field01 { get; set; }
        public int Field02 { get; set; }
        public int Field03 { get; set; }
        public string Field04 { get; set; }
        public int Field05 { get; set; }
    }

    [DBTable(Expansion.Cata)]
    public class Faction
    {
        [DBKey]
        public int Id { get; set; }
        public int Field00 { get; set; }
        public int Field01 { get; set; }
        public int Field02 { get; set; }
        public int Field03 { get; set; }
        public int Field04 { get; set; }
        public int Field05 { get; set; }
        public int Field06 { get; set; }
        public int Field07 { get; set; }
        public int Field08 { get; set; }
        public int Field09 { get; set; }
        public int Field0A { get; set; }
        public int Field0B { get; set; }
        public int Field0C { get; set; }
        public int Field0D { get; set; }
        public int Field0E { get; set; }
        public int Field0F { get; set; }
        public int Field10 { get; set; }
        public int Field11 { get; set; }
        public int Field12 { get; set; }
        public int Field13 { get; set; }
        public int Field14 { get; set; }
        public int Field15 { get; set; }
        public string Field16 { get; set; }
        public string Field17 { get; set; }
        public int Field18 { get; set; }
    }

    [DBTable(Expansion.Cata)]
    public class FactionGroup
    {
        [DBKey]
        public int Id { get; set; }
        public int Field00 { get; set; }
        public string Field01 { get; set; }
        public string Field02 { get; set; }
    }

    [DBTable(Expansion.Cata)]
    public class FactionTemplate
    {
        [DBKey]
        public int Id { get; set; }
        public int Field00 { get; set; }
        public int Field01 { get; set; }
        public int Field02 { get; set; }
        public int Field03 { get; set; }
        public int Field04 { get; set; }
        public int Field05 { get; set; }
        public int Field06 { get; set; }
        public int Field07 { get; set; }
        public int Field08 { get; set; }
        public int Field09 { get; set; }
        public int Field0A { get; set; }
        public int Field0B { get; set; }
        public int Field0C { get; set; }
    }

    [DBTable(Expansion.Cata)]
    public class FileData
    {
        [DBKey]
        public int Id { get; set; }
        public string Field00 { get; set; }
        public string Field01 { get; set; }
    }

    [DBTable(Expansion.Cata)]
    public class FootprintTextures
    {
        [DBKey]
        public int Id { get; set; }
        public string Field00 { get; set; }
    }

    [DBTable(Expansion.Cata)]
    public class FootstepTerrainLookup
    {
        [DBKey]
        public int Id { get; set; }
        public int Field00 { get; set; }
        public int Field01 { get; set; }
        public int Field02 { get; set; }
        public int Field03 { get; set; }
    }

    [DBTable(Expansion.Cata)]
    public class GameObjectArtKit
    {
        [DBKey]
        public int Id { get; set; }
        public int Field00 { get; set; }
        public int Field01 { get; set; }
        public int Field02 { get; set; }
        public string Field03 { get; set; }
        public string Field04 { get; set; }
        public string Field05 { get; set; }
        public string Field06 { get; set; }
    }

    [DBTable(Expansion.Cata)]
    public class Gameobjectcache
    {
        [DBKey]
        public int Entry { get; set; }
        public int Type { get; set; }
        public int Displayid { get; set; }
        public string Name { get; set; }
        public string Name2 { get; set; }
        public string Name3 { get; set; }
        public string Name4 { get; set; }
        public string IconName { get; set; }
        public string CastBarCaption { get; set; }
        public string Unk1string { get; set; }
        public int NewField1 { get; set; }
        public int NewField2 { get; set; }
        public int NewField3 { get; set; }
        public int NewField4 { get; set; }
        public int NewField5 { get; set; }
        public int NewField6 { get; set; }
        public int NewField7 { get; set; }
        public int NewField8 { get; set; }
        public int NewField9 { get; set; }
        public int NewField10 { get; set; }
        public int NewField11 { get; set; }
        public int NewField12 { get; set; }
        public int NewField13 { get; set; }
        public int NewField14 { get; set; }
        public int NewField15 { get; set; }
        public int NewField16 { get; set; }
        public int NewField17 { get; set; }
        public int NewField18 { get; set; }
        public int NewField19 { get; set; }
        public int NewField20 { get; set; }
        public int NewField21 { get; set; }
        public int NewField22 { get; set; }
        public int NewField23 { get; set; }
        public int NewField24 { get; set; }
        public int NewField25 { get; set; }
        public int NewField26 { get; set; }
        public int NewField27 { get; set; }
        public int NewField28 { get; set; }
        public int NewField29 { get; set; }
        public int NewField30 { get; set; }
        public int NewField31 { get; set; }
        public int NewField32 { get; set; }
        public float Size { get; set; }
        public int QuestItem1 { get; set; }
        public int QuestItem2 { get; set; }
        public int QuestItem3 { get; set; }
        public int QuestItem4 { get; set; }
        public int QuestItem5 { get; set; }
        public int QuestItem6 { get; set; }
        public int Unk1 { get; set; }
    }

    [DBTable(Expansion.Cata)]
    public class GameObjectDisplayInfo
    {
        [DBKey]
        public int Id { get; set; }
        public string Field00 { get; set; }
        public int Field01 { get; set; }
        public int Field02 { get; set; }
        public int Field03 { get; set; }
        public int Field04 { get; set; }
        public int Field05 { get; set; }
        public int Field06 { get; set; }
        public int Field07 { get; set; }
        public int Field08 { get; set; }
        public int Field09 { get; set; }
        public int Field0A { get; set; }
        public int Field0B { get; set; }
        public int Field0C { get; set; }
        public int Field0D { get; set; }
        public int Field0E { get; set; }
        public int Field0F { get; set; }
        public int Field10 { get; set; }
        public int Field11 { get; set; }
        public int Field12 { get; set; }
        public int Field13 { get; set; }
    }

    [DBTable(Expansion.Cata)]
    public class GameObjectsClient
    {
        [DBKey]
        public int Field0 { get; set; }
        public int Field1 { get; set; }
        public int Field2 { get; set; }
        public float Field3 { get; set; }
        public float Field4 { get; set; }
        public float Field5 { get; set; }
        public float Field6 { get; set; }
        public float Field7 { get; set; }
        public float Field8 { get; set; }
        public float Field9 { get; set; }
        public float Field10 { get; set; }
        public int Field11 { get; set; }
        public int Field12 { get; set; }
        public int Field13 { get; set; }
        public int Field14 { get; set; }
        public int Field15 { get; set; }
        public string Field16 { get; set; }
    }

    [DBTable(Expansion.Cata)]
    public class GameTables
    {
        [DBKey]
        public int Field0 { get; set; }
        public int Field1 { get; set; }
        public int Field2 { get; set; }
    }

    [DBTable(Expansion.Cata)]
    public class GameTips
    {
        [DBKey]
        public int Id { get; set; }
        public string Field00 { get; set; }
        public int Field01 { get; set; }
        public int Field02 { get; set; }
    }

    [DBTable(Expansion.Cata)]
    public class GemProperties
    {
        [DBKey]
        public int Id { get; set; }
        public int Field00 { get; set; }
        public int Field01 { get; set; }
        public int Field02 { get; set; }
        public int Field03 { get; set; }
        public int Field04 { get; set; }
    }

    [DBTable(Expansion.Cata)]
    public class GlueScreenEmote
    {
        [DBKey]
        public int Id { get; set; }
        public int Field00 { get; set; }
        public int Field01 { get; set; }
        public int Field02 { get; set; }
        public int Field03 { get; set; }
        public int Field04 { get; set; }
        public int Field05 { get; set; }
        public int Field06 { get; set; }
    }

    [DBTable(Expansion.Cata)]
    public class GlyphProperties
    {
        [DBKey]
        public int Id { get; set; }
        public int Field00 { get; set; }
        public int Field01 { get; set; }
        public int Field02 { get; set; }
    }

    [DBTable(Expansion.Cata)]
    public class GlyphSlot
    {
        [DBKey]
        public int Id { get; set; }
        public int Field00 { get; set; }
        public int Field01 { get; set; }
    }

    [DBTable(Expansion.Cata)]
    public class GMSurveyAnswers
    {
        [DBKey]
        public int Id { get; set; }
        public int Field00 { get; set; }
        public int Field01 { get; set; }
        public string Field02 { get; set; }
    }

    [DBTable(Expansion.Cata)]
    public class GMSurveyCurrentSurvey
    {
        [DBKey]
        public int Id { get; set; }
        public int Field00 { get; set; }
    }

    [DBTable(Expansion.Cata)]
    public class GMSurveyQuestions
    {
        [DBKey]
        public int Id { get; set; }
        public string Field00 { get; set; }
    }

    [DBTable(Expansion.Cata)]
    public class GMSurveySurveys
    {
        [DBKey]
        public int Id { get; set; }
        public int Field00 { get; set; }
        public int Field01 { get; set; }
        public int Field02 { get; set; }
        public int Field03 { get; set; }
        public int Field04 { get; set; }
        public int Field05 { get; set; }
        public int Field06 { get; set; }
        public int Field07 { get; set; }
        public int Field08 { get; set; }
        public int Field09 { get; set; }
        public int Field0A { get; set; }
        public int Field0B { get; set; }
        public int Field0C { get; set; }
        public int Field0D { get; set; }
        public int Field0E { get; set; }
    }

    [DBTable(Expansion.Cata)]
    public class GMTicketCategory
    {
        [DBKey]
        public int Id { get; set; }
        public string Field00 { get; set; }
    }

    [DBTable(Expansion.Cata)]
    public class GroundEffectDoodad
    {
        [DBKey]
        public int Id { get; set; }
        public string Field00 { get; set; }
        public int Field01 { get; set; }
    }

    [DBTable(Expansion.Cata)]
    public class GroundEffectTexture
    {
        [DBKey]
        public int Id { get; set; }
        public int Field00 { get; set; }
        public int Field01 { get; set; }
        public int Field02 { get; set; }
        public int Field03 { get; set; }
        public int Field04 { get; set; }
        public int Field05 { get; set; }
        public int Field06 { get; set; }
        public int Field07 { get; set; }
        public int Field08 { get; set; }
        public int Field09 { get; set; }
    }

    [DBTable(Expansion.Cata)]
    public class GtBarberShopCostBase
    {
        [DBKey]
        public int Level { get; set; }
        public float Cost { get; set; }
    }

    [DBTable(Expansion.Cata)]
    public class GtChanceToMeleeCrit
    {
        [DBKey]
        public int Id { get; set; }
        public int Field00 { get; set; }
    }

    [DBTable(Expansion.Cata)]
    public class GtChanceToMeleeCritBase
    {
        [DBKey]
        public int Id { get; set; }
        public int Field00 { get; set; }
    }

    [DBTable(Expansion.Cata)]
    public class GtChanceToSpellCrit
    {
        [DBKey]
        public int Id { get; set; }
        public int Field00 { get; set; }
    }

    [DBTable(Expansion.Cata)]
    public class GtChanceToSpellCritBase
    {
        [DBKey]
        public int Id { get; set; }
        public int Field00 { get; set; }
    }

    [DBTable(Expansion.Cata)]
    public class GtCombatRatings
    {
        [DBKey]
        public int Id { get; set; }
        public int Field00 { get; set; }
    }

    [DBTable(Expansion.Cata)]
    public class GtNPCManaCostScaler
    {
        [DBKey]
        public int Id { get; set; }
        public float Field00 { get; set; }
    }

    [DBTable(Expansion.Cata)]
    public class GtOCTBaseHPByClass
    {
        [DBKey]
        public int Id { get; set; }
        public int Field00 { get; set; }
    }

    [DBTable(Expansion.Cata)]
    public class GtOCTBaseMPByClass
    {
        [DBKey]
        public int Id { get; set; }
        public int Field00 { get; set; }
    }

    [DBTable(Expansion.Cata)]
    public class GtOCTClassCombatRatingScalar
    {
        [DBKey]
        public int Field0 { get; set; }
        public float Field1 { get; set; }
    }

    [DBTable(Expansion.Cata)]
    public class GtOCTHpPerStamina
    {
        [DBKey]
        public int Id { get; set; }
        public float Field00 { get; set; }
    }

    [DBTable(Expansion.Cata)]
    public class GtOCTRegenMP
    {
        [DBKey]
        public int Id { get; set; }
        public int Field00 { get; set; }
    }

    [DBTable(Expansion.Cata)]
    public class GtRegenMPPerSpt
    {
        [DBKey]
        public int Id { get; set; }
        public int Field00 { get; set; }
    }

    [DBTable(Expansion.Cata)]
    public class GtSpellScaling
    {
        [DBKey]
        public int Id { get; set; }
        public int Field00 { get; set; }
    }

    [DBTable(Expansion.Cata)]
    public class GuildColorBackground
    {
        [DBKey]
        public int ColorID { get; set; }
        public byte Red { get; set; }
        public byte Green { get; set; }
        public byte Blue { get; set; }
    }

    [DBTable(Expansion.Cata)]
    public class GuildColorBorder
    {
        [DBKey]
        public int ColorID { get; set; }
        public byte Red { get; set; }
        public byte Green { get; set; }
        public byte Blue { get; set; }
    }

    [DBTable(Expansion.Cata)]
    public class GuildColorEmblem
    {
        [DBKey]
        public int ColorID { get; set; }
        public byte Red { get; set; }
        public byte Green { get; set; }
        public byte Blue { get; set; }
    }

    [DBTable(Expansion.Cata)]
    public class GuildPerkSpells
    {
        [DBKey]
        public int Id { get; set; }
        public int Field00 { get; set; }
        public int Field01 { get; set; }
    }

    [DBTable(Expansion.Cata)]
    public class HelmetGeosetVisData
    {
        [DBKey]
        public int Id { get; set; }
        public int Field00 { get; set; }
        public int Field01 { get; set; }
        public int Field02 { get; set; }
        public int Field03 { get; set; }
        public int Field04 { get; set; }
        public int Field05 { get; set; }
        public int Field06 { get; set; }
    }

    [DBTable(Expansion.Cata)]
    public class HolidayDescriptions
    {
        [DBKey]
        public int Id { get; set; }
        public string Field00 { get; set; }
    }

    [DBTable(Expansion.Cata)]
    public class HolidayNames
    {
        [DBKey]
        public int Id { get; set; }
        public string Field00 { get; set; }
    }

    [DBTable(Expansion.Cata)]
    public class Holidays
    {
        [DBKey]
        public int Id { get; set; }
        public int Field00 { get; set; }
        public int Field01 { get; set; }
        public int Field02 { get; set; }
        public int Field03 { get; set; }
        public int Field04 { get; set; }
        public int Field05 { get; set; }
        public int Field06 { get; set; }
        public int Field07 { get; set; }
        public int Field08 { get; set; }
        public int Field09 { get; set; }
        public int Field0A { get; set; }
        public int Field0B { get; set; }
        public int Field0C { get; set; }
        public int Field0D { get; set; }
        public int Field0E { get; set; }
        public int Field0F { get; set; }
        public int Field10 { get; set; }
        public int Field11 { get; set; }
        public int Field12 { get; set; }
        public int Field13 { get; set; }
        public int Field14 { get; set; }
        public int Field15 { get; set; }
        public int Field16 { get; set; }
        public int Field17 { get; set; }
        public int Field18 { get; set; }
        public int Field19 { get; set; }
        public int Field1A { get; set; }
        public int Field1B { get; set; }
        public int Field1C { get; set; }
        public int Field1D { get; set; }
        public int Field1E { get; set; }
        public int Field1F { get; set; }
        public int Field20 { get; set; }
        public int Field21 { get; set; }
        public int Field22 { get; set; }
        public int Field23 { get; set; }
        public int Field24 { get; set; }
        public string Field25 { get; set; }
        public int Field26 { get; set; }
        public int Field27 { get; set; }
        public int Field28 { get; set; }
        public int Field29 { get; set; }
        public int Field2A { get; set; }
        public int Field2B { get; set; }
        public int Field2C { get; set; }
        public int Field2D { get; set; }
        public int Field2E { get; set; }
        public int Field2F { get; set; }
        public int Field30 { get; set; }
        public int Field31 { get; set; }
        public string Field32 { get; set; }
        public int Field33 { get; set; }
        public int Field34 { get; set; }
        public string Field35 { get; set; }
    }

    [DBTable(Expansion.Cata)]
    public class ImportPriceArmor
    {
        [DBKey]
        public int Id { get; set; }
        public int Field00 { get; set; }
        public int Field01 { get; set; }
        public int Field02 { get; set; }
        public int Field03 { get; set; }
    }

    [DBTable(Expansion.Cata)]
    public class ImportPriceQuality
    {
        [DBKey]
        public int Id { get; set; }
        public int Field00 { get; set; }
    }

    [DBTable(Expansion.Cata)]
    public class ImportPriceShield
    {
        [DBKey]
        public int Id { get; set; }
        public float Field00 { get; set; }
    }

    [DBTable(Expansion.Cata)]
    public class ImportPriceWeapon
    {
        [DBKey]
        public int Id { get; set; }
        public float Field00 { get; set; }
    }

    [DBTable(Expansion.Cata)]
    public class Item
    {
        [DBKey]
        public int Id { get; set; }
        public int Class { get; set; }
        public int SubClass { get; set; }
        public int SoundOverrideSubclass { get; set; }
        public int Material { get; set; }
        public int DisplayId { get; set; }
        public int InventoryType { get; set; }
        public int Sheathe { get; set; }
    }

    [DBTable(Expansion.Cata)]
    public class ItemArmorQuality
    {
        [DBKey]
        public int Field0 { get; set; }
        public float Field1 { get; set; }
        public float Field2 { get; set; }
        public float Field3 { get; set; }
        public float Field4 { get; set; }
        public float Field5 { get; set; }
        public float Field6 { get; set; }
        public float Field7 { get; set; }
        public int Field8 { get; set; }
    }

    [DBTable(Expansion.Cata)]
    public class ItemArmorShield
    {
        [DBKey]
        public int Id { get; set; }
        public int Field00 { get; set; }
        public float Field01 { get; set; }
        public float Field02 { get; set; }
        public float Field03 { get; set; }
        public float Field04 { get; set; }
        public float Field05 { get; set; }
        public float Field06 { get; set; }
        public float Field07 { get; set; }
    }

    [DBTable(Expansion.Cata)]
    public class ItemArmorTotal
    {
        [DBKey]
        public int Field0 { get; set; }
        public int Field1 { get; set; }
        public float Field2 { get; set; }
        public float Field3 { get; set; }
        public float Field4 { get; set; }
        public float Field5 { get; set; }
    }

    [DBTable(Expansion.Cata)]
    public class ItemBagFamily
    {
        [DBKey]
        public int Id { get; set; }
        public string Field00 { get; set; }
    }

    [DBTable(Expansion.Cata)]
    public class ItemClass
    {
        [DBKey]
        public int Field0 { get; set; }
        public int Field1 { get; set; }
        public float Field2 { get; set; }
        public string Field3 { get; set; }
    }

    [DBTable(Expansion.Cata)]
    public class ItemCondExtCosts
    {
        [DBKey]
        public int Field0 { get; set; }
        public int Field1 { get; set; }
        public int Field2 { get; set; }
        public int Field3 { get; set; }
    }

    [DBTable(Expansion.Cata)]
    public class ItemCurrencyCost
    {
        [DBKey]
        public int Id { get; set; }
        public int ItemId { get; set; }
    }

    [DBTable(Expansion.Cata)]
    public class ItemDamageAmmo
    {
        [DBKey]
        public int Id { get; set; }
        public float Field00 { get; set; }
        public float Field01 { get; set; }
        public float Field02 { get; set; }
        public float Field03 { get; set; }
        public int Field04 { get; set; }
        public int Field05 { get; set; }
        public int Field06 { get; set; }
        public int Field07 { get; set; }
    }

    [DBTable(Expansion.Cata)]
    public class ItemDamageOneHand
    {
        [DBKey]
        public int Id { get; set; }
        public int Field00 { get; set; }
        public int Field01 { get; set; }
        public int Field02 { get; set; }
        public int Field03 { get; set; }
        public int Field04 { get; set; }
        public int Field05 { get; set; }
        public int Field06 { get; set; }
        public int Field07 { get; set; }
    }

    [DBTable(Expansion.Cata)]
    public class ItemDamageOneHandCaster
    {
        [DBKey]
        public int Id { get; set; }
        public float Field00 { get; set; }
        public float Field01 { get; set; }
        public float Field02 { get; set; }
        public float Field03 { get; set; }
        public float Field04 { get; set; }
        public float Field05 { get; set; }
        public float Field06 { get; set; }
        public int Field07 { get; set; }
    }

    [DBTable(Expansion.Cata)]
    public class ItemDamageRanged
    {
        [DBKey]
        public int Id { get; set; }
        public int Field00 { get; set; }
        public int Field01 { get; set; }
        public int Field02 { get; set; }
        public int Field03 { get; set; }
        public int Field04 { get; set; }
        public int Field05 { get; set; }
        public int Field06 { get; set; }
        public int Field07 { get; set; }
    }

    [DBTable(Expansion.Cata)]
    public class ItemDamageThrown
    {
        [DBKey]
        public int Id { get; set; }
        public int Field00 { get; set; }
        public int Field01 { get; set; }
        public int Field02 { get; set; }
        public int Field03 { get; set; }
        public int Field04 { get; set; }
        public int Field05 { get; set; }
        public int Field06 { get; set; }
        public int Field07 { get; set; }
    }

    [DBTable(Expansion.Cata)]
    public class ItemDamageTwoHand
    {
        [DBKey]
        public int Id { get; set; }
        public float Value1 { get; set; }
        public float Value2 { get; set; }
        public float Value3 { get; set; }
        public float Value4 { get; set; }
        public float Value5 { get; set; }
        public float Value6 { get; set; }
        public float Value7 { get; set; }
        public int ItemLevel { get; set; }
    }

    [DBTable(Expansion.Cata)]
    public class ItemDamageTwoHandCaster
    {
        [DBKey]
        public int Id { get; set; }
        public float Field00 { get; set; }
        public float Field01 { get; set; }
        public float Field02 { get; set; }
        public float Field03 { get; set; }
        public float Field04 { get; set; }
        public float Field05 { get; set; }
        public float Field06 { get; set; }
        public int Field07 { get; set; }
    }

    [DBTable(Expansion.Cata)]
    public class ItemDamageWand
    {
        [DBKey]
        public int Id { get; set; }
        public int Field00 { get; set; }
        public int Field01 { get; set; }
        public int Field02 { get; set; }
        public int Field03 { get; set; }
        public int Field04 { get; set; }
        public int Field05 { get; set; }
        public int Field06 { get; set; }
        public int Field07 { get; set; }
    }

    [DBTable(Expansion.Cata)]
    public class ItemDisenchantLoot
    {
        [DBKey]
        public int Field0 { get; set; }
        public int Field1 { get; set; }
        public int Field2 { get; set; }
        public int Field3 { get; set; }
        public int Field4 { get; set; }
        public int Field5 { get; set; }
        public int Field6 { get; set; }
    }

    [DBTable(Expansion.Cata)]
    public class ItemDisplayInfo
    {
        [DBKey]
        public int Field0 { get; set; }
        public int Field1 { get; set; }
        public int Field2 { get; set; }
        public int Field3 { get; set; }
        public int Field4 { get; set; }
        public int Field5 { get; set; }
        public int Field6 { get; set; }
        public int Field7 { get; set; }
        public int Field8 { get; set; }
        public int Field9 { get; set; }
        public int Field10 { get; set; }
        public int Field11 { get; set; }
        public int Field12 { get; set; }
        public int Field13 { get; set; }
        public int Field14 { get; set; }
        public int Field15 { get; set; }
        public int Field16 { get; set; }
        public int Field17 { get; set; }
        public int Field18 { get; set; }
        public int Field19 { get; set; }
        public int Field20 { get; set; }
        public int Field21 { get; set; }
        public int Field22 { get; set; }
        public int Field23 { get; set; }
        public int Field24 { get; set; }
    }

    [DBTable(Expansion.Cata)]
    public class ItemExtendedCost
    {
        [DBKey]
        public int Id { get; set; }
        public int Field00 { get; set; }
        public int Field01 { get; set; }
        public int Field02 { get; set; }
        public int Field03 { get; set; }
        public int Field04 { get; set; }
        public int Field05 { get; set; }
        public int Field06 { get; set; }
        public int Field07 { get; set; }
        public int Field08 { get; set; }
        public int Field09 { get; set; }
        public int Field0A { get; set; }
        public int Field0B { get; set; }
        public int Field0C { get; set; }
        public int Field0D { get; set; }
        public int Field0E { get; set; }
        public int Field0F { get; set; }
        public int Field10 { get; set; }
        public int Field11 { get; set; }
        public int Field12 { get; set; }
        public int Field13 { get; set; }
        public int Field14 { get; set; }
        public int Field15 { get; set; }
        public int Field16 { get; set; }
        public int Field17 { get; set; }
        public int Field18 { get; set; }
        public int Field19 { get; set; }
        public int Field1A { get; set; }
        public int Field1B { get; set; }
        public int Field1C { get; set; }
        public int Field1D { get; set; }
    }

    [DBTable(Expansion.Cata)]
    public class ItemGroupSounds
    {
        [DBKey]
        public int Id { get; set; }
        public int Field00 { get; set; }
        public int Field01 { get; set; }
        public int Field02 { get; set; }
        public int Field03 { get; set; }
    }

    [DBTable(Expansion.Cata)]
    public class ItemLimitCategory
    {
        [DBKey]
        public int Id { get; set; }
        public string Field00 { get; set; }
        public int Field01 { get; set; }
        public string Field02 { get; set; }
    }

    [DBTable(Expansion.Cata)]
    public class ItemNameDescription
    {
        [DBKey]
        public int Field0 { get; set; }
        public string Field1 { get; set; }
        public uint Field2 { get; set; }
    }

    [DBTable(Expansion.Cata)]
    public class ItemPetFood
    {
        [DBKey]
        public int Id { get; set; }
        public string Field00 { get; set; }
    }

    [DBTable(Expansion.Cata)]
    public class ItemPriceBase
    {
        [DBKey]
        public int Id { get; set; }
        public int Field00 { get; set; }
        public int Field01 { get; set; }
        public int Field02 { get; set; }
    }

    [DBTable(Expansion.Cata)]
    public class ItemPurchaseGroup
    {
        [DBKey]
        public int Id { get; set; }
        public int Field00 { get; set; }
        public int Field01 { get; set; }
        public int Field02 { get; set; }
        public int Field03 { get; set; }
        public int Field04 { get; set; }
        public int Field05 { get; set; }
        public int Field06 { get; set; }
        public int Field07 { get; set; }
        public string Field08 { get; set; }
    }

    [DBTable(Expansion.Cata)]
    public class ItemRandomProperties
    {
        [DBKey]
        public int Id { get; set; }
        public string Field00 { get; set; }
        public int Field01 { get; set; }
        public int Field02 { get; set; }
        public int Field03 { get; set; }
        public int Field04 { get; set; }
        public int Field05 { get; set; }
        public string Field06 { get; set; }
    }

    [DBTable(Expansion.Cata)]
    public class ItemRandomSuffix
    {
        [DBKey]
        public int Id { get; set; }
        public string Field00 { get; set; }
        public string Field01 { get; set; }
        public int Field02 { get; set; }
        public int Field03 { get; set; }
        public int Field04 { get; set; }
        public int Field05 { get; set; }
        public int Field06 { get; set; }
        public int Field07 { get; set; }
        public int Field08 { get; set; }
        public int Field09 { get; set; }
        public int Field0A { get; set; }
        public int Field0B { get; set; }
    }

    [DBTable(Expansion.Cata)]
    public class ItemReforge
    {
        [DBKey]
        public int Id { get; set; }
        public int Field00 { get; set; }
        public float Field01 { get; set; }
        public int Field02 { get; set; }
        public float Field03 { get; set; }
    }

    [DBTable(Expansion.Cata)]
    public class ItemSet
    {
        [DBKey]
        public int Id { get; set; }
        public string Field00 { get; set; }
        public int Field01 { get; set; }
        public int Field02 { get; set; }
        public int Field03 { get; set; }
        public int Field04 { get; set; }
        public int Field05 { get; set; }
        public int Field06 { get; set; }
        public int Field07 { get; set; }
        public int Field08 { get; set; }
        public int Field09 { get; set; }
        public int Field0A { get; set; }
        public int Field0B { get; set; }
        public int Field0C { get; set; }
        public int Field0D { get; set; }
        public int Field0E { get; set; }
        public int Field0F { get; set; }
        public int Field10 { get; set; }
        public int Field11 { get; set; }
        public int Field12 { get; set; }
        public int Field13 { get; set; }
        public int Field14 { get; set; }
        public int Field15 { get; set; }
        public int Field16 { get; set; }
        public int Field17 { get; set; }
        public int Field18 { get; set; }
        public int Field19 { get; set; }
        public int Field1A { get; set; }
        public int Field1B { get; set; }
        public int Field1C { get; set; }
        public int Field1D { get; set; }
        public int Field1E { get; set; }
        public int Field1F { get; set; }
        public int Field20 { get; set; }
        public int Field21 { get; set; }
        public int Field22 { get; set; }
        public int Field23 { get; set; }
    }

    [DBTable(Expansion.Cata)]
    public class Item_sparse
    {
        [DBKey]
        public int Id { get; set; }
        public int Quality { get; set; }
        public uint Flags { get; set; }
        public uint Flags2 { get; set; }
        public float NewField1 { get; set; }
        public float NewField2 { get; set; }
        public int NewField3 { get; set; }
        public int Buyprice { get; set; }
        public int Sellprice { get; set; }
        public int Inventorytype { get; set; }
        public int Allowableclass { get; set; }
        public int Allowablerace { get; set; }
        public int Itemlevel { get; set; }
        public int Requiredlevel { get; set; }
        public int Requiredskill { get; set; }
        public int Requiredskillrank { get; set; }
        public int Requiredspell { get; set; }
        public int Requiredhonorrank { get; set; }
        public int Requiredcityrank { get; set; }
        public int Requiredreputationfaction { get; set; }
        public int Requiredreputationrank { get; set; }
        public int Maxcount { get; set; }
        public int Stackable { get; set; }
        public int Containerslots { get; set; }
        public int Stat_type1 { get; set; }
        public int Stat_type2 { get; set; }
        public int Stat_type3 { get; set; }
        public int Stat_type4 { get; set; }
        public int Stat_type5 { get; set; }
        public int Stat_type6 { get; set; }
        public int Stat_type7 { get; set; }
        public int Stat_type8 { get; set; }
        public int Stat_type9 { get; set; }
        public int Stat_type10 { get; set; }
        public int Stat_value1 { get; set; }
        public int Stat_value2 { get; set; }
        public int Stat_value3 { get; set; }
        public int Stat_value4 { get; set; }
        public int Stat_value5 { get; set; }
        public int Stat_value6 { get; set; }
        public int Stat_value7 { get; set; }
        public int Stat_value8 { get; set; }
        public int Stat_value9 { get; set; }
        public int Stat_value10 { get; set; }
        public int Stat_unk1_1 { get; set; }
        public int Stat_unk1_2 { get; set; }
        public int Stat_unk1_3 { get; set; }
        public int Stat_unk1_4 { get; set; }
        public int Stat_unk1_5 { get; set; }
        public int Stat_unk1_6 { get; set; }
        public int Stat_unk1_7 { get; set; }
        public int Stat_unk1_8 { get; set; }
        public int Stat_unk1_9 { get; set; }
        public int Stat_unk1_10 { get; set; }
        public int Stat_unk2_1 { get; set; }
        public int Stat_unk2_2 { get; set; }
        public int Stat_unk2_3 { get; set; }
        public int Stat_unk2_4 { get; set; }
        public int Stat_unk2_5 { get; set; }
        public int Stat_unk2_6 { get; set; }
        public int Stat_unk2_7 { get; set; }
        public int Stat_unk2_8 { get; set; }
        public int Stat_unk2_9 { get; set; }
        public int Stat_unk2_10 { get; set; }
        public int Scalingstatdistribution { get; set; }
        public int Damagetype { get; set; }
        public int Delay { get; set; }
        public float Rangedmodrange { get; set; }
        public int Spellid_1 { get; set; }
        public int Spellid_2 { get; set; }
        public int Spellid_3 { get; set; }
        public int Spellid_4 { get; set; }
        public int Spellid_5 { get; set; }
        public int Spelltrigger_1 { get; set; }
        public int Spelltrigger_2 { get; set; }
        public int Spelltrigger_3 { get; set; }
        public int Spelltrigger_4 { get; set; }
        public int Spelltrigger_5 { get; set; }
        public int Spellcharges_1 { get; set; }
        public int Spellcharges_2 { get; set; }
        public int Spellcharges_3 { get; set; }
        public int Spellcharges_4 { get; set; }
        public int Spellcharges_5 { get; set; }
        public int Spellcooldown_1 { get; set; }
        public int Spellcooldown_2 { get; set; }
        public int Spellcooldown_3 { get; set; }
        public int Spellcooldown_4 { get; set; }
        public int Spellcooldown_5 { get; set; }
        public int Spellcategory_1 { get; set; }
        public int Spellcategory_2 { get; set; }
        public int Spellcategory_3 { get; set; }
        public int Spellcategory_4 { get; set; }
        public int Spellcategory_5 { get; set; }
        public int Spellcategorycooldown_1 { get; set; }
        public int Spellcategorycooldown_2 { get; set; }
        public int Spellcategorycooldown_3 { get; set; }
        public int Spellcategorycooldown_4 { get; set; }
        public int Spellcategorycooldown_5 { get; set; }
        public int Bonding { get; set; }
        public string Name { get; set; }
        public string Name2 { get; set; }
        public string Name3 { get; set; }
        public string Name4 { get; set; }
        public string Description { get; set; }
        public int Pagetext { get; set; }
        public int Languageid { get; set; }
        public int Pagematerial { get; set; }
        public int Startquest { get; set; }
        public int Lockid { get; set; }
        public int Material { get; set; }
        public int Sheath { get; set; }
        public int Randomproperty { get; set; }
        public int Randomsuffix { get; set; }
        public int Itemset { get; set; }
        public int Area { get; set; }
        public int Map { get; set; }
        public int Bagfamily { get; set; }
        public int Totemcategory { get; set; }
        public int Socketcolor_1 { get; set; }
        public int Socketcolor_2 { get; set; }
        public int Socketcolor_3 { get; set; }
        public int Socketcontent_1 { get; set; }
        public int Socketcontent_2 { get; set; }
        public int Socketcontent_3 { get; set; }
        public int Socketbonus { get; set; }
        public int Gemproperties { get; set; }
        public float Armordamagemodifier { get; set; }
        public int Duration { get; set; }
        public int Itemlimitcategory { get; set; }
        public int Holidayid { get; set; }
        public float Statscalingfactor { get; set; }
        public int NewField4 { get; set; }
        public int NewField5 { get; set; }
    }

    [DBTable(Expansion.Cata)]
    public class ItemSubClass
    {
        [DBKey]
        public int GeneratedId { get; set; }
        public int Class { get; set; }
        public int Subclass { get; set; }
        public int Field3 { get; set; }
        public int Field4 { get; set; }
        public int Field5 { get; set; }
        public int Field6 { get; set; }
        public int Field7 { get; set; }
        public int Field8 { get; set; }
        public int Field9 { get; set; }
        public int Field10 { get; set; }
        public string Name { get; set; }
        public string Subname { get; set; }
    }

    [DBTable(Expansion.Cata)]
    public class ItemSubClassMask
    {
        [DBKey]
        public int Id { get; set; }
        public int Field00 { get; set; }
        public int Field01 { get; set; }
        public string Field02 { get; set; }
    }

    [DBTable(Expansion.Cata)]
    public class ItemVisualEffects
    {
        [DBKey]
        public int Id { get; set; }
        public string Field00 { get; set; }
    }

    [DBTable(Expansion.Cata)]
    public class ItemVisuals
    {
        [DBKey]
        public int Id { get; set; }
        public int Field00 { get; set; }
        public int Field01 { get; set; }
        public int Field02 { get; set; }
        public int Field03 { get; set; }
        public int Field04 { get; set; }
    }

    [DBTable(Expansion.Cata)]
    public class JournalEncounter
    {
        [DBKey]
        public int Id { get; set; }
        public int DungeonMapId { get; set; }
        public int NewField1 { get; set; }
        public float Unkfloat1 { get; set; }
        public float Unkfloat2 { get; set; }
        public int SectionId { get; set; }
        public int InstanceId { get; set; }
        public int Index { get; set; }
        public int NewField2 { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }

    [DBTable(Expansion.Cata)]
    public class JournalEncounterCreature
    {
        [DBKey]
        public int Id { get; set; }
        public int EncounterId { get; set; }
        public int ModelId { get; set; }
        public int Index { get; set; }
        public int Field4 { get; set; }
        public string Name { get; set; }
        public int Field6 { get; set; }
    }

    [DBTable(Expansion.Cata)]
    public class JournalEncounterItem
    {
        [DBKey]
        public int Id { get; set; }
        public int EncounterId { get; set; }
        public int ItemId { get; set; }
        public int Difficulty { get; set; }
        public int NewField1 { get; set; }
    }

    [DBTable(Expansion.Cata)]
    public class JournalEncounterSection
    {
        [DBKey]
        public int Id { get; set; }
        public int EncounterId { get; set; }
        public int NextSection { get; set; }
        public int SubSection { get; set; }
        public int ParentSection { get; set; }
        public int Index { get; set; }
        public int Type { get; set; }
        public int NewField1 { get; set; }
        public int Flags { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Field10 { get; set; }
        public int ModelId { get; set; }
        public int Field12 { get; set; }
    }

    [DBTable(Expansion.Cata)]
    public class JournalInstance
    {
        [DBKey]
        public int Id { get; set; }
        public int MapId { get; set; }
        public int AreaId { get; set; }
        public int ButtonFiledataID { get; set; }
        public int ButtonSmallFileDataID { get; set; }
        public int BackgroundFiledataID { get; set; }
        public int LoreFileDataID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }

    [DBTable(Expansion.Cata)]
    public class KeyChain
    {
        [DBKey]
        public int Id { get; set; }
        [DBField(ArraySize: 32)]
        public byte[] Key { get; set; }
    }

    [DBTable(Expansion.Cata)]
    public class Languages
    {
        [DBKey]
        public int Id { get; set; }
        public string Field00 { get; set; }
    }

    [DBTable(Expansion.Cata)]
    public class LanguageWords
    {
        [DBKey]
        public int Id { get; set; }
        public int Field00 { get; set; }
        public string Field01 { get; set; }
    }

    [DBTable(Expansion.Cata)]
    public class LFGDungeonExpansion
    {
        [DBKey]
        public int ID { get; set; }
        public int Lfg_id { get; set; }
        public int Expansion_level { get; set; }
        public int Random_id { get; set; }
        public int Hard_level_min { get; set; }
        public int Hard_level_max { get; set; }
        public int Target_level_min { get; set; }
        public int Target_level_max { get; set; }
    }

    [DBTable(Expansion.Cata)]
    public class LFGDungeonGroup
    {
        [DBKey]
        public int Field0 { get; set; }
        public string Field1 { get; set; }
        public int Field2 { get; set; }
        public int Field3 { get; set; }
        public int Field4 { get; set; }
    }

    [DBTable(Expansion.Cata)]
    public class LFGDungeons
    {
        [DBKey]
        public int Id { get; set; }
        public string Field1 { get; set; }
        public int Field2 { get; set; }
        public int Field3 { get; set; }
        public int Field4 { get; set; }
        public int Field5 { get; set; }
        public int Field6 { get; set; }
        public int MapId { get; set; }
        public int Field8 { get; set; }
        public int Field9 { get; set; }
        public int Field10 { get; set; }
        public int Field11 { get; set; }
        public string Field12 { get; set; }
        public int Field13 { get; set; }
        public int Field14 { get; set; }
        public int Field15 { get; set; }
        public int Field16 { get; set; }
        public int Field17 { get; set; }
    }

    [DBTable(Expansion.Cata)]
    public class LFGDungeonsGroupingmap
    {
        [DBKey]
        public int Id { get; set; }
        public int Field00 { get; set; }
        public int Field01 { get; set; }
        public int Field02 { get; set; }
    }

    [DBTable(Expansion.Cata)]
    public class Light
    {
        [DBKey]
        public int Id { get; set; }
        public int Field00 { get; set; }
        public int Field01 { get; set; }
        public int Field02 { get; set; }
        public int Field03 { get; set; }
        public int Field04 { get; set; }
        public int Field05 { get; set; }
        public int Field06 { get; set; }
        public int Field07 { get; set; }
        public int Field08 { get; set; }
        public int Field09 { get; set; }
        public int Field0A { get; set; }
        public int Field0B { get; set; }
        public int Field0C { get; set; }
        public int Field0D { get; set; }
    }

    [DBTable(Expansion.Cata)]
    public class LightFloatBand
    {
        [DBKey]
        public int Id { get; set; }
        public int Field00 { get; set; }
        public int Field01 { get; set; }
        public int Field02 { get; set; }
        public int Field03 { get; set; }
        public int Field04 { get; set; }
        public int Field05 { get; set; }
        public int Field06 { get; set; }
        public int Field07 { get; set; }
        public int Field08 { get; set; }
        public int Field09 { get; set; }
        public int Field0A { get; set; }
        public int Field0B { get; set; }
        public int Field0C { get; set; }
        public int Field0D { get; set; }
        public int Field0E { get; set; }
        public int Field0F { get; set; }
        public int Field10 { get; set; }
        public int Field11 { get; set; }
        public int Field12 { get; set; }
        public int Field13 { get; set; }
        public int Field14 { get; set; }
        public int Field15 { get; set; }
        public int Field16 { get; set; }
        public int Field17 { get; set; }
        public int Field18 { get; set; }
        public int Field19 { get; set; }
        public int Field1A { get; set; }
        public int Field1B { get; set; }
        public int Field1C { get; set; }
        public int Field1D { get; set; }
        public int Field1E { get; set; }
        public int Field1F { get; set; }
        public int Field20 { get; set; }
    }

    [DBTable(Expansion.Cata)]
    public class LightIntBand
    {
        [DBKey]
        public int Id { get; set; }
        public int Field00 { get; set; }
        public int Field01 { get; set; }
        public int Field02 { get; set; }
        public int Field03 { get; set; }
        public int Field04 { get; set; }
        public int Field05 { get; set; }
        public int Field06 { get; set; }
        public int Field07 { get; set; }
        public int Field08 { get; set; }
        public int Field09 { get; set; }
        public int Field0A { get; set; }
        public int Field0B { get; set; }
        public int Field0C { get; set; }
        public int Field0D { get; set; }
        public int Field0E { get; set; }
        public int Field0F { get; set; }
        public int Field10 { get; set; }
        public int Field11 { get; set; }
        public int Field12 { get; set; }
        public int Field13 { get; set; }
        public int Field14 { get; set; }
        public int Field15 { get; set; }
        public int Field16 { get; set; }
        public int Field17 { get; set; }
        public int Field18 { get; set; }
        public int Field19 { get; set; }
        public int Field1A { get; set; }
        public int Field1B { get; set; }
        public int Field1C { get; set; }
        public int Field1D { get; set; }
        public int Field1E { get; set; }
        public int Field1F { get; set; }
        public int Field20 { get; set; }
    }

    [DBTable(Expansion.Cata)]
    public class LightParams
    {
        [DBKey]
        public int Id { get; set; }
        public int Field00 { get; set; }
        public int Field01 { get; set; }
        public int Field02 { get; set; }
        public int Field03 { get; set; }
        public int Field04 { get; set; }
        public int Field05 { get; set; }
        public int Field06 { get; set; }
        public int Field07 { get; set; }
        public int Field08 { get; set; }
    }

    [DBTable(Expansion.Cata)]
    public class LightSkybox
    {
        [DBKey]
        public int Id { get; set; }
        public string Field00 { get; set; }
        public int Field01 { get; set; }
    }

    [DBTable(Expansion.Cata)]
    public class LiquidMaterial
    {
        [DBKey]
        public int Id { get; set; }
        public int Field00 { get; set; }
        public int Field01 { get; set; }
    }

    [DBTable(Expansion.Cata)]
    public class LiquidObject
    {
        [DBKey]
        public int Id { get; set; }
        public int Field00 { get; set; }
        public int Field01 { get; set; }
        public int Field02 { get; set; }
        public int Field03 { get; set; }
        public int Field04 { get; set; }
    }

    [DBTable(Expansion.Cata)]
    public class LiquidType
    {
        [DBKey]
        public int Id { get; set; }
        public string Field00 { get; set; }
        public int Field01 { get; set; }
        public int Field02 { get; set; }
        public int Field03 { get; set; }
        public int Field04 { get; set; }
        public int Field05 { get; set; }
        public int Field06 { get; set; }
        public int Field07 { get; set; }
        public int Field08 { get; set; }
        public int Field09 { get; set; }
        public int Field0A { get; set; }
        public string Field0B { get; set; }
        public string Field0C { get; set; }
        public int Field0D { get; set; }
        public string Field0E { get; set; }
        public string Field0F { get; set; }
        public string Field10 { get; set; }
        public string Field11 { get; set; }
        public int Field12 { get; set; }
        public int Field13 { get; set; }
        public int Field14 { get; set; }
        public int Field15 { get; set; }
        public int Field16 { get; set; }
        public int Field17 { get; set; }
        public int Field18 { get; set; }
        public int Field19 { get; set; }
        public int Field1A { get; set; }
        public int Field1B { get; set; }
        public int Field1C { get; set; }
        public int Field1D { get; set; }
        public int Field1E { get; set; }
        public int Field1F { get; set; }
        public int Field20 { get; set; }
        public int Field21 { get; set; }
        public int Field22 { get; set; }
        public int Field23 { get; set; }
        public int Field24 { get; set; }
        public int Field25 { get; set; }
        public int Field26 { get; set; }
        public int Field27 { get; set; }
        public string Field28 { get; set; }
        public int Field29 { get; set; }
        public int Field2A { get; set; }
        public int Field2B { get; set; }
    }

    [DBTable(Expansion.Cata)]
    public class LoadingScreens
    {
        [DBKey]
        public int Id { get; set; }
        public string Field00 { get; set; }
        public string Field01 { get; set; }
        public string Field02 { get; set; }
    }

    [DBTable(Expansion.Cata)]
    public class LoadingScreenTaxiSplines
    {
        [DBKey]
        public int Id { get; set; }
        public int Field00 { get; set; }
        public float Field01 { get; set; }
        public int Field02 { get; set; }
        public int Field03 { get; set; }
        public int Field04 { get; set; }
        public int Field05 { get; set; }
        public int Field06 { get; set; }
        public int Field07 { get; set; }
        public int Field08 { get; set; }
        public float Field09 { get; set; }
        public int Field0A { get; set; }
        public int Field0B { get; set; }
        public int Field0C { get; set; }
        public int Field0D { get; set; }
        public int Field0E { get; set; }
        public int Field0F { get; set; }
        public int Field10 { get; set; }
        public int Field11 { get; set; }
    }

    [DBTable(Expansion.Cata)]
    public class Lock
    {
        [DBKey]
        public int ID { get; set; }
        public int Type1 { get; set; }
        public int Type2 { get; set; }
        public int Type3 { get; set; }
        public int Type4 { get; set; }
        public int Type5 { get; set; }
        public int Type6 { get; set; }
        public int Type7 { get; set; }
        public int Type8 { get; set; }
        public int Index1 { get; set; }
        public int Index2 { get; set; }
        public int Index3 { get; set; }
        public int Index4 { get; set; }
        public int Index5 { get; set; }
        public int Index6 { get; set; }
        public int Index7 { get; set; }
        public int Index8 { get; set; }
        public int Skill1 { get; set; }
        public int Skill2 { get; set; }
        public int Skill3 { get; set; }
        public int Skill4 { get; set; }
        public int Skill5 { get; set; }
        public int Skill6 { get; set; }
        public int Skill7 { get; set; }
        public int Skill8 { get; set; }
        public int Action1 { get; set; }
        public int Action2 { get; set; }
        public int Action3 { get; set; }
        public int Action4 { get; set; }
        public int Action5 { get; set; }
        public int Action6 { get; set; }
        public int Action7 { get; set; }
        public int Action8 { get; set; }
    }

    [DBTable(Expansion.Cata)]
    public class LockType
    {
        [DBKey]
        public int Field0 { get; set; }
        public string Field1 { get; set; }
        public string Field2 { get; set; }
        public string Field3 { get; set; }
        public string Field4 { get; set; }
    }

    [DBTable(Expansion.Cata)]
    public class MailTemplate
    {
        [DBKey]
        public int Id { get; set; }
        public string Field00 { get; set; }
        public string Field01 { get; set; }
    }

    [DBTable(Expansion.Cata)]
    public class Map
    {
        [DBKey]
        public int Id { get; set; }
        public string Iname { get; set; }
        public int Type { get; set; }
        public int Flags { get; set; }
        public int Unk4 { get; set; }
        public int IsPvp { get; set; }
        public string Name { get; set; }
        public int LinkedZone { get; set; }
        public string Hordeintro { get; set; }
        public string Allianceintro { get; set; }
        public int Multimap_id { get; set; }
        public float BattlefieldMapIconScale { get; set; }
        public int Ghost_entrance_map { get; set; }
        public float Ghost_entrance_x { get; set; }
        public float Ghost_entrance_y { get; set; }
        public int TimeOfDayOverride { get; set; }
        public int Addon { get; set; }
        public int UnkTime { get; set; }
        public int MaxPlayers { get; set; }
        public int Unk400 { get; set; }
    }

    [DBTable(Expansion.Cata)]
    public class MapDifficulty
    {
        [DBKey]
        public int Id { get; set; }
        public int MapId { get; set; }
        public int Difficulty { get; set; }
        public string Requirement { get; set; }
        public int ResetTime { get; set; }
        public int MaxPlayers { get; set; }
        public string Difficultystring { get; set; }
    }

    [DBTable(Expansion.Cata)]
    public class Material
    {
        [DBKey]
        public int Id { get; set; }
        public int Field00 { get; set; }
        public int Field01 { get; set; }
        public int Field02 { get; set; }
        public int Field03 { get; set; }
    }

    [DBTable(Expansion.Cata)]
    public class MountCapability
    {
        [DBKey]
        public int Field0 { get; set; }
        public int Field1 { get; set; }
        public int Field2 { get; set; }
        public int Field3 { get; set; }
        public int Field4 { get; set; }
        public int Field5 { get; set; }
        public int Field6 { get; set; }
        public int Field7 { get; set; }
    }

    [DBTable(Expansion.Cata)]
    public class MountType
    {
        [DBKey]
        public int Field0 { get; set; }
        public int Field1 { get; set; }
        public int Field2 { get; set; }
        public int Field3 { get; set; }
        public int Field4 { get; set; }
        public int Field5 { get; set; }
        public int Field6 { get; set; }
        public int Field7 { get; set; }
        public int Field8 { get; set; }
        public int Field9 { get; set; }
        public int Field10 { get; set; }
        public int Field11 { get; set; }
        public int Field12 { get; set; }
        public int Field13 { get; set; }
        public int Field14 { get; set; }
        public int Field15 { get; set; }
        public int Field16 { get; set; }
        public int Field17 { get; set; }
        public int Field18 { get; set; }
        public int Field19 { get; set; }
        public int Field20 { get; set; }
        public int Field21 { get; set; }
        public int Field22 { get; set; }
        public int Field23 { get; set; }
        public int Field24 { get; set; }
    }

    [DBTable(Expansion.Cata)]
    public class Movie
    {
        [DBKey]
        public int Id { get; set; }
        public string Field00 { get; set; }
        public int Field01 { get; set; }
        public int Field02 { get; set; }
    }

    [DBTable(Expansion.Cata)]
    public class MovieFileData
    {
        [DBKey]
        public int Id { get; set; }
        public int Field00 { get; set; }
    }

    [DBTable(Expansion.Cata)]
    public class MovieVariation
    {
        [DBKey]
        public int Id { get; set; }
        public int Field00 { get; set; }
        public int Field01 { get; set; }
    }

    [DBTable(Expansion.Cata)]
    public class NameGen
    {
        [DBKey]
        public int Id { get; set; }
        public string Field00 { get; set; }
        public int Field01 { get; set; }
        public string Field02 { get; set; }
    }

    [DBTable(Expansion.Cata)]
    public class NamesProfanity
    {
        [DBKey]
        public int Id { get; set; }
        public string Field00 { get; set; }
        public int Field01 { get; set; }
    }

    [DBTable(Expansion.Cata)]
    public class NamesReserved
    {
        [DBKey]
        public int Id { get; set; }
        public string Field00 { get; set; }
        public int Field01 { get; set; }
    }

    [DBTable(Expansion.Cata)]
    public class NPCSounds
    {
        [DBKey]
        public int Id { get; set; }
        public int Field00 { get; set; }
        public int Field01 { get; set; }
        public int Field02 { get; set; }
        public int Field03 { get; set; }
    }

    [DBTable(Expansion.Cata)]
    public class NumTalentsAtLevel
    {
        [DBKey]
        public int Id { get; set; }
        public int Field00 { get; set; }
    }

    [DBTable(Expansion.Cata)]
    public class ObjectEffect
    {
        [DBKey]
        public int Id { get; set; }
        public string Field00 { get; set; }
        public int Field01 { get; set; }
        public int Field02 { get; set; }
        public string Field03 { get; set; }
        public string Field04 { get; set; }
        public int Field05 { get; set; }
        public int Field06 { get; set; }
        public int Field07 { get; set; }
        public int Field08 { get; set; }
        public int Field09 { get; set; }
        public int Field0A { get; set; }
    }

    [DBTable(Expansion.Cata)]
    public class ObjectEffectGroup
    {
        [DBKey]
        public int Id { get; set; }
        public string Field00 { get; set; }
    }

    [DBTable(Expansion.Cata)]
    public class ObjectEffectModifier
    {
        [DBKey]
        public int Id { get; set; }
        public int Field00 { get; set; }
        public int Field01 { get; set; }
        public int Field02 { get; set; }
        public float Field03 { get; set; }
        public float Field04 { get; set; }
        public float Field05 { get; set; }
        public float Field06 { get; set; }
    }

    [DBTable(Expansion.Cata)]
    public class ObjectEffectPackage
    {
        [DBKey]
        public int Id { get; set; }
        public string Field00 { get; set; }
    }

    [DBTable(Expansion.Cata)]
    public class ObjectEffectPackageElem
    {
        [DBKey]
        public int Id { get; set; }
        public int Field00 { get; set; }
        public int Field01 { get; set; }
        public int Field02 { get; set; }
    }

    [DBTable(Expansion.Cata)]
    public class OverrideSpellData
    {
        [DBKey]
        public int Id { get; set; }
        public int Field00 { get; set; }
        public int Field01 { get; set; }
        public int Field02 { get; set; }
        public int Field03 { get; set; }
        public int Field04 { get; set; }
        public int Field05 { get; set; }
        public int Field06 { get; set; }
        public int Field07 { get; set; }
        public int Field08 { get; set; }
        public int Field09 { get; set; }
        public int Field0A { get; set; }
        public string Field0B { get; set; }
    }

    [DBTable(Expansion.Cata)]
    public class Package
    {
        [DBKey]
        public int Id { get; set; }
        public string Field00 { get; set; }
        public int Field01 { get; set; }
        public string Field02 { get; set; }
    }

    [DBTable(Expansion.Cata)]
    public class PageTextMaterial
    {
        [DBKey]
        public int Id { get; set; }
        public string Field00 { get; set; }
    }

    [DBTable(Expansion.Cata)]
    public class PaperDollItemFrame
    {
        [DBKey]
        public int Id { get; set; }
        public string Field00 { get; set; }
        public string Field01 { get; set; }
        public int Field02 { get; set; }
    }

    [DBTable(Expansion.Cata)]
    public class ParticleColor
    {
        [DBKey]
        public int Id { get; set; }
        public int Field00 { get; set; }
        public int Field01 { get; set; }
        public int Field02 { get; set; }
        public int Field03 { get; set; }
        public int Field04 { get; set; }
        public int Field05 { get; set; }
        public int Field06 { get; set; }
        public int Field07 { get; set; }
        public int Field08 { get; set; }
    }

    [DBTable(Expansion.Cata)]
    public class PetitionType
    {
        [DBKey]
        public int Id { get; set; }
        public string Field00 { get; set; }
        public int Field01 { get; set; }
    }

    [DBTable(Expansion.Cata)]
    public class PetPersonality
    {
        [DBKey]
        public int Id { get; set; }
        public string Field00 { get; set; }
        public int Field01 { get; set; }
        public int Field02 { get; set; }
        public int Field03 { get; set; }
        public int Field04 { get; set; }
        public float Field05 { get; set; }
        public float Field06 { get; set; }
    }

    [DBTable(Expansion.Cata)]
    public class Phase
    {
        [DBKey]
        public int Id { get; set; }
        public string Field00 { get; set; }
        public int Field01 { get; set; }
    }

    [DBTable(Expansion.Cata)]
    public class PhaseShiftZoneSounds
    {
        [DBKey]
        public int Id { get; set; }
        public int Field00 { get; set; }
        public int Field01 { get; set; }
        public int Field02 { get; set; }
        public int Field03 { get; set; }
        public int Field04 { get; set; }
        public int Field05 { get; set; }
        public int Field06 { get; set; }
        public int Field07 { get; set; }
        public int Field08 { get; set; }
        public int Field09 { get; set; }
        public int Field0A { get; set; }
        public int Field0B { get; set; }
        public int Field0C { get; set; }
    }

    [DBTable(Expansion.Cata)]
    public class PhaseXPhaseGroup
    {
        [DBKey]
        public int Id { get; set; }
        public int Field00 { get; set; }
        public int Field01 { get; set; }
    }

    [DBTable(Expansion.Cata)]
    public class PlayerCondition
    {
        [DBKey]
        public int Id { get; set; }
        public string Field00 { get; set; }
    }

    [DBTable(Expansion.Cata)]
    public class PowerDisplay
    {
        [DBKey]
        public int ID { get; set; }
        public int ActualType { get; set; }
        public string GlobalstringBaseTag { get; set; }
        public byte Red { get; set; }
        public byte Green { get; set; }
        public byte Blue { get; set; }
    }

    [DBTable(Expansion.Cata)]
    public class PvpDifficulty
    {
        [DBKey]
        public int Id { get; set; }
        public int Field00 { get; set; }
        public int Field01 { get; set; }
        public int Field02 { get; set; }
        public int Field03 { get; set; }
        public int Field04 { get; set; }
    }

    [DBTable(Expansion.Cata)]
    public class QuestFactionReward
    {
        [DBKey]
        public int Id { get; set; }
        public int Field00 { get; set; }
        public int Field01 { get; set; }
        public int Field02 { get; set; }
        public int Field03 { get; set; }
        public int Field04 { get; set; }
        public int Field05 { get; set; }
        public int Field06 { get; set; }
        public int Field07 { get; set; }
        public int Field08 { get; set; }
        public int Field09 { get; set; }
    }

    [DBTable(Expansion.Cata)]
    public class QuestInfo
    {
        [DBKey]
        public int Id { get; set; }
        public string Field00 { get; set; }
    }

    [DBTable(Expansion.Cata)]
    public class QuestPOIBlob
    {
        [DBKey]
        public int Id { get; set; }
        public int Field00 { get; set; }
        public int Field01 { get; set; }
        public int Field02 { get; set; }
    }

    [DBTable(Expansion.Cata)]
    public class QuestPOIPoint
    {
        [DBKey]
        public int Id { get; set; }
        public int Field00 { get; set; }
        public int Field01 { get; set; }
        public int Field02 { get; set; }
    }

    [DBTable(Expansion.Cata)]
    public class QuestSort
    {
        [DBKey]
        public int Id { get; set; }
        public string Field00 { get; set; }
    }

    [DBTable(Expansion.Cata)]
    public class QuestXP
    {
        [DBKey]
        public int Id { get; set; }
        public int Field00 { get; set; }
        public int Field01 { get; set; }
        public int Field02 { get; set; }
        public int Field03 { get; set; }
        public int Field04 { get; set; }
        public int Field05 { get; set; }
        public int Field06 { get; set; }
        public int Field07 { get; set; }
        public int Field08 { get; set; }
        public int Field09 { get; set; }
    }

    [DBTable(Expansion.Cata)]
    public class RandPropPoints
    {
        [DBKey]
        public int Id { get; set; }
        public int Field00 { get; set; }
        public int Field01 { get; set; }
        public int Field02 { get; set; }
        public int Field03 { get; set; }
        public int Field04 { get; set; }
        public int Field05 { get; set; }
        public int Field06 { get; set; }
        public int Field07 { get; set; }
        public int Field08 { get; set; }
        public int Field09 { get; set; }
        public int Field0A { get; set; }
        public int Field0B { get; set; }
        public int Field0C { get; set; }
        public int Field0D { get; set; }
        public int Field0E { get; set; }
    }

    [DBTable(Expansion.Cata)]
    public class ResearchBranch
    {
        [DBKey]
        public int Id { get; set; }
        public string Field00 { get; set; }
        public string Field01 { get; set; }
        public int Field02 { get; set; }
        public string Field03 { get; set; }
        public int Field04 { get; set; }
    }

    [DBTable(Expansion.Cata)]
    public class ResearchField
    {
        [DBKey]
        public int Id { get; set; }
        public string Field00 { get; set; }
        public int Field01 { get; set; }
    }

    [DBTable(Expansion.Cata)]
    public class ResearchProject
    {
        [DBKey]
        public int Id { get; set; }
        public string Field00 { get; set; }
        public string Field01 { get; set; }
        public string Field02 { get; set; }
        public int Field03 { get; set; }
        public int Field04 { get; set; }
        public int Field05 { get; set; }
        public string Field06 { get; set; }
        public int Field07 { get; set; }
    }

    [DBTable(Expansion.Cata)]
    public class ResearchSite
    {
        [DBKey]
        public int Id { get; set; }
        public int Field00 { get; set; }
        public int Field01 { get; set; }
        public string Field02 { get; set; }
        public int Field03 { get; set; }
    }

    [DBTable(Expansion.Cata)]
    public class Resistances
    {
        [DBKey]
        public int Id { get; set; }
        public string Field00 { get; set; }
        public int Field01 { get; set; }
        public string Field02 { get; set; }
    }

    [DBTable(Expansion.Cata)]
    public class ScalingStatDistribution
    {
        [DBKey]
        public int Id { get; set; }
        public int Field00 { get; set; }
        public int Field01 { get; set; }
        public int Field02 { get; set; }
        public int Field03 { get; set; }
        public int Field04 { get; set; }
        public int Field05 { get; set; }
        public int Field06 { get; set; }
        public int Field07 { get; set; }
        public int Field08 { get; set; }
        public int Field09 { get; set; }
        public int Field0A { get; set; }
        public int Field0B { get; set; }
        public int Field0C { get; set; }
        public int Field0D { get; set; }
        public int Field0E { get; set; }
        public int Field0F { get; set; }
        public int Field10 { get; set; }
        public int Field11 { get; set; }
        public int Field12 { get; set; }
        public int Field13 { get; set; }
        public int Field14 { get; set; }
        public int Field15 { get; set; }
    }

    [DBTable(Expansion.Cata)]
    public class ScalingStatValues
    {
        [DBKey]
        public int Id { get; set; }
        public int Field00 { get; set; }
        public int Field01 { get; set; }
        public int Field02 { get; set; }
        public int Field03 { get; set; }
        public int Field04 { get; set; }
        public int Field05 { get; set; }
        public int Field06 { get; set; }
        public int Field07 { get; set; }
        public int Field08 { get; set; }
        public int Field09 { get; set; }
        public int Field0A { get; set; }
        public int Field0B { get; set; }
        public int Field0C { get; set; }
        public int Field0D { get; set; }
        public int Field0E { get; set; }
        public int Field0F { get; set; }
        public int Field10 { get; set; }
        public int Field11 { get; set; }
        public int Field12 { get; set; }
        public int Field13 { get; set; }
        public int Field14 { get; set; }
        public int Field15 { get; set; }
        public int Field16 { get; set; }
        public int Field17 { get; set; }
        public int Field18 { get; set; }
        public int Field19 { get; set; }
        public int Field1A { get; set; }
        public int Field1B { get; set; }
        public int Field1C { get; set; }
        public int Field1D { get; set; }
        public int Field1E { get; set; }
        public int Field1F { get; set; }
        public int Field20 { get; set; }
        public int Field21 { get; set; }
        public int Field22 { get; set; }
        public int Field23 { get; set; }
        public int Field24 { get; set; }
        public int Field25 { get; set; }
        public int Field26 { get; set; }
        public int Field27 { get; set; }
        public int Field28 { get; set; }
        public int Field29 { get; set; }
        public int Field2A { get; set; }
        public int Field2B { get; set; }
        public int Field2C { get; set; }
        public int Field2D { get; set; }
    }

    [DBTable(Expansion.Cata)]
    public class SceneScript
    {
        [DBKey]
        public int Field0 { get; set; }
        public string Field1 { get; set; }
        public string Field2 { get; set; }
        public int NewField1 { get; set; }
        public int NewField2 { get; set; }
    }

    [DBTable(Expansion.Cata)]
    public class SceneScriptPackage
    {
        [DBKey]
        public int Field0 { get; set; }
        public string Field1 { get; set; }
    }

    [DBTable(Expansion.Cata)]
    public class SceneScriptPackageMember
    {
        [DBKey]
        public int Field0 { get; set; }
        public int Field1 { get; set; }
        public int Field2 { get; set; }
        public int Field3 { get; set; }
        public int Field4 { get; set; }
    }

    [DBTable(Expansion.Cata)]
    public class ScreenEffect
    {
        [DBKey]
        public int Id { get; set; }
        public string Field00 { get; set; }
        public int Field01 { get; set; }
        public int Field02 { get; set; }
        public int Field03 { get; set; }
        public int Field04 { get; set; }
        public int Field05 { get; set; }
        public int Field06 { get; set; }
        public int Field07 { get; set; }
        public int Field08 { get; set; }
        public int Field09 { get; set; }
    }

    [DBTable(Expansion.Cata)]
    public class ScreenLocation
    {
        [DBKey]
        public int Id { get; set; }
        public string Field00 { get; set; }
    }

    [DBTable(Expansion.Cata)]
    public class ServerMessages
    {
        [DBKey]
        public int Id { get; set; }
        public string Message { get; set; }
    }

    [DBTable(Expansion.Cata)]
    public class SkillLine
    {
        [DBKey]
        public int Id { get; set; }
        public int Field00 { get; set; }
        public string Field01 { get; set; }
        public string Field02 { get; set; }
        public int Field03 { get; set; }
        public string Field04 { get; set; }
        public string Field05 { get; set; }
    }

    [DBTable(Expansion.Cata)]
    public class SkillLineAbility
    {
        [DBKey]
        public int Id { get; set; }
        public int Field00 { get; set; }
        public int Field01 { get; set; }
        public int Field02 { get; set; }
        public int Field03 { get; set; }
        public int Field04 { get; set; }
        public int Field05 { get; set; }
        public int Field06 { get; set; }
        public int Field07 { get; set; }
        public int Field08 { get; set; }
        public int Field09 { get; set; }
        public int Field0A { get; set; }
        public int Field0B { get; set; }
        public int Field0C { get; set; }
    }

    [DBTable(Expansion.Cata)]
    public class SkillLineAbilitySortedSpell
    {
        [DBKey]
        public int Id { get; set; }
        public int Field00 { get; set; }
    }

    [DBTable(Expansion.Cata)]
    public class SkillLineCategory
    {
        [DBKey]
        public int Id { get; set; }
        public string Field00 { get; set; }
        public int Field01 { get; set; }
    }

    [DBTable(Expansion.Cata)]
    public class SkillRaceClassInfo
    {
        [DBKey]
        public int Id { get; set; }
        public int Field00 { get; set; }
        public int Field01 { get; set; }
        public int Field02 { get; set; }
        public int Field03 { get; set; }
        public int Field04 { get; set; }
        public int Field05 { get; set; }
        public int Field06 { get; set; }
        public int Field07 { get; set; }
    }

    [DBTable(Expansion.Cata)]
    public class SkillTiers
    {
        [DBKey]
        public int Id { get; set; }
        public int Field00 { get; set; }
        public int Field01 { get; set; }
        public int Field02 { get; set; }
        public int Field03 { get; set; }
        public int Field04 { get; set; }
        public int Field05 { get; set; }
        public int Field06 { get; set; }
        public int Field07 { get; set; }
        public int Field08 { get; set; }
        public int Field09 { get; set; }
        public int Field0A { get; set; }
        public int Field0B { get; set; }
        public int Field0C { get; set; }
        public int Field0D { get; set; }
        public int Field0E { get; set; }
        public int Field0F { get; set; }
        public int Field10 { get; set; }
        public int Field11 { get; set; }
        public int Field12 { get; set; }
        public int Field13 { get; set; }
        public int Field14 { get; set; }
        public int Field15 { get; set; }
        public int Field16 { get; set; }
        public int Field17 { get; set; }
        public int Field18 { get; set; }
        public int Field19 { get; set; }
        public int Field1A { get; set; }
        public int Field1B { get; set; }
        public int Field1C { get; set; }
        public int Field1D { get; set; }
        public int Field1E { get; set; }
        public int Field1F { get; set; }
    }

    [DBTable(Expansion.Cata)]
    public class SoundAmbience
    {
        [DBKey]
        public int Id { get; set; }
        public int Field00 { get; set; }
        public int Field01 { get; set; }
    }

    [DBTable(Expansion.Cata)]
    public class SoundAmbienceFlavor
    {
        [DBKey]
        public int Id { get; set; }
        public int Field00 { get; set; }
        public int Field01 { get; set; }
        public int Field02 { get; set; }
    }

    [DBTable(Expansion.Cata)]
    public class SoundEmitterPillPoints
    {
        [DBKey]
        public int Id { get; set; }
        public int Field00 { get; set; }
        public float Field01 { get; set; }
        public float Field02 { get; set; }
        public float Field03 { get; set; }
    }

    [DBTable(Expansion.Cata)]
    public class SoundEmitters
    {
        [DBKey]
        public int Id { get; set; }
        public int Field00 { get; set; }
        public int Field01 { get; set; }
        public int Field02 { get; set; }
        public int Field03 { get; set; }
        public int Field04 { get; set; }
        public int Field05 { get; set; }
        public int Field06 { get; set; }
        public int Field07 { get; set; }
        public string Field08 { get; set; }
        public int Field09 { get; set; }
    }

    [DBTable(Expansion.Cata)]
    public class SoundEntries
    {
        [DBKey]
        public int Id { get; set; }
        public int Field00 { get; set; }
        public string Field01 { get; set; }
        public string Field02 { get; set; }
        public string Field03 { get; set; }
        public string Field04 { get; set; }
        public string Field05 { get; set; }
        public string Field06 { get; set; }
        public string Field07 { get; set; }
        public string Field08 { get; set; }
        public string Field09 { get; set; }
        public string Field0A { get; set; }
        public string Field0B { get; set; }
        public int Field0C { get; set; }
        public int Field0D { get; set; }
        public int Field0E { get; set; }
        public int Field0F { get; set; }
        public int Field10 { get; set; }
        public int Field11 { get; set; }
        public int Field12 { get; set; }
        public int Field13 { get; set; }
        public int Field14 { get; set; }
        public int Field15 { get; set; }
        public string Field16 { get; set; }
        public float Field17 { get; set; }
        public int Field18 { get; set; }
        public float Field19 { get; set; }
        public float Field1A { get; set; }
        public int Field1B { get; set; }
        public int Field1C { get; set; }
        public int Field1D { get; set; }
        public int Field1E { get; set; }
        public int Field1F { get; set; }
        public int Field20 { get; set; }
        public int Field21 { get; set; }
    }

    [DBTable(Expansion.Cata)]
    public class SoundEntriesAdvanced
    {
        [DBKey]
        public int Id { get; set; }
        public int Field00 { get; set; }
        public int Field01 { get; set; }
        public int Field02 { get; set; }
        public int Field03 { get; set; }
        public int Field04 { get; set; }
        public int Field05 { get; set; }
        public int Field06 { get; set; }
        public int Field07 { get; set; }
        public int Field08 { get; set; }
        public int Field09 { get; set; }
        public int Field0A { get; set; }
        public int Field0B { get; set; }
        public int Field0C { get; set; }
        public int Field0D { get; set; }
        public int Field0E { get; set; }
        public int Field0F { get; set; }
        public int Field10 { get; set; }
        public int Field11 { get; set; }
        public float Field12 { get; set; }
        public float Field13 { get; set; }
        public int Field14 { get; set; }
        public int Field15 { get; set; }
        public int Field16 { get; set; }
        public int Field17 { get; set; }
        public float Field18 { get; set; }
    }

    [DBTable(Expansion.Cata)]
    public class SoundEntriesFallbacks
    {
        [DBKey]
        public int Id { get; set; }
        public int Field00 { get; set; }
        public int Field01 { get; set; }
    }

    [DBTable(Expansion.Cata)]
    public class SoundFilter
    {
        [DBKey]
        public int Id { get; set; }
        public string Field00 { get; set; }
    }

    [DBTable(Expansion.Cata)]
    public class SoundFilterElem
    {
        [DBKey]
        public int Id { get; set; }
        public int Field00 { get; set; }
        public int Field01 { get; set; }
        public int Field02 { get; set; }
        public float Field03 { get; set; }
        public float Field04 { get; set; }
        public int Field05 { get; set; }
        public int Field06 { get; set; }
        public int Field07 { get; set; }
        public int Field08 { get; set; }
        public int Field09 { get; set; }
        public int Field0A { get; set; }
        public int Field0B { get; set; }
    }

    [DBTable(Expansion.Cata)]
    public class SoundProviderPreferences
    {
        [DBKey]
        public int Id { get; set; }
        public string Field00 { get; set; }
        public int Field01 { get; set; }
        public int Field02 { get; set; }
        public float Field03 { get; set; }
        public float Field04 { get; set; }
        public float Field05 { get; set; }
        public int Field06 { get; set; }
        public int Field07 { get; set; }
        public float Field08 { get; set; }
        public int Field09 { get; set; }
        public int Field0A { get; set; }
        public int Field0B { get; set; }
        public int Field0C { get; set; }
        public int Field0D { get; set; }
        public int Field0E { get; set; }
        public int Field0F { get; set; }
        public float Field10 { get; set; }
        public float Field11 { get; set; }
        public int Field12 { get; set; }
        public float Field13 { get; set; }
        public int Field14 { get; set; }
        public float Field15 { get; set; }
        public float Field16 { get; set; }
    }

    [DBTable(Expansion.Cata)]
    public class SpamMessages
    {
        [DBKey]
        public int Id { get; set; }
        public string Field00 { get; set; }
    }

    [DBTable(Expansion.Cata)]
    public class Spell
    {
        [DBKey]
        public int ID { get; set; }
        public uint Attributes { get; set; }
        public uint AttributesEx { get; set; }
        public uint AttributesExB { get; set; }
        public uint AttributesExC { get; set; }
        public uint AttributesExD { get; set; }
        public uint AttributesExE { get; set; }
        public uint AttributesExF { get; set; }
        public uint AttributesExG { get; set; }
        public uint AttributesExH { get; set; }
        public uint AttributesExI { get; set; }
        public uint AttributesExJ { get; set; }
        public int CastingTimeIndex { get; set; }
        public int DurationIndex { get; set; }
        public int PowerType { get; set; }
        public int RangeIndex { get; set; }
        public float Speed { get; set; }
        public uint SpellVisualID_1 { get; set; }
        public uint SpellVisualID_2 { get; set; }
        public int SpellIconID { get; set; }
        public int ActiveIconID { get; set; }
        public string Name { get; set; }
        public string NameSubtext { get; set; }
        public string Description { get; set; }
        public string AuraDescription { get; set; }
        public int SchoolMask { get; set; }
        public int RuneCostID { get; set; }
        public int SpellMissileID { get; set; }
        public int SpellDescriptionVariableID { get; set; }
        public int SpellDifficultyID { get; set; }
        public int Unk1 { get; set; }
        public int SpellScalingID { get; set; }
        public int SpellAuraOptionsId { get; set; }
        public int SpellAuraRestrictionsId { get; set; }
        public int SpellCastingRequirementsId { get; set; }
        public int SpellCategoriesId { get; set; }
        public int SpellClassOptionsId { get; set; }
        public int SpellCooldownsId { get; set; }
        public int Unk2 { get; set; }
        public int SpellEquippedItemsId { get; set; }
        public int SpellinterruptsId { get; set; }
        public int SpellLevelsId { get; set; }
        public int SpellPowerId { get; set; }
        public int SpellReagentsId { get; set; }
        public int SpellShapeshiftId { get; set; }
        public int SpellTargetRestrictionsId { get; set; }
        public int SpellTotemsId { get; set; }
        public int ResearchProjectId { get; set; }
    }

    [DBTable(Expansion.Cata)]
    public class SpellActivationOverlay
    {
        [DBKey]
        public int Id { get; set; }
        public int Field00 { get; set; }
        public int Field01 { get; set; }
        public int Field02 { get; set; }
        public int Field03 { get; set; }
        public float Field04 { get; set; }
        public int Field05 { get; set; }
        public int Field06 { get; set; }
        public int Field07 { get; set; }
        public int Field08 { get; set; }
        public int Field09 { get; set; }
    }

    [DBTable(Expansion.Cata)]
    public class SpellAuraOptions
    {
        [DBKey]
        public int Id { get; set; }
        public int Field00 { get; set; }
        public int Field01 { get; set; }
        public int Field02 { get; set; }
        public int Field03 { get; set; }
    }

    [DBTable(Expansion.Cata)]
    public class SpellAuraRestrictions
    {
        [DBKey]
        public int Id { get; set; }
        public int Field00 { get; set; }
        public int Field01 { get; set; }
        public int Field02 { get; set; }
        public int Field03 { get; set; }
        public int Field04 { get; set; }
        public int Field05 { get; set; }
        public int Field06 { get; set; }
        public int Field07 { get; set; }
    }

    [DBTable(Expansion.Cata)]
    public class SpellAuraVisibility
    {
        [DBKey]
        public int Id { get; set; }
        public int Field00 { get; set; }
        public int Field01 { get; set; }
        public int Field02 { get; set; }
    }

    [DBTable(Expansion.Cata)]
    public class SpellAuraVisXTalentTab
    {
        [DBKey]
        public int Id { get; set; }
        public int Field00 { get; set; }
        public int Field01 { get; set; }
    }

    [DBTable(Expansion.Cata)]
    public class SpellCastingRequirements
    {
        [DBKey]
        public int Field0 { get; set; }
        public int Field1 { get; set; }
        public int Field2 { get; set; }
        public int Field3 { get; set; }
        public int Field4 { get; set; }
        public int Field5 { get; set; }
        public int Field6 { get; set; }
    }

    [DBTable(Expansion.Cata)]
    public class SpellCastTimes
    {
        [DBKey]
        public int Id { get; set; }
        public int Field00 { get; set; }
        public int Field01 { get; set; }
        public int Field02 { get; set; }
    }

    [DBTable(Expansion.Cata)]
    public class SpellCategories
    {
        [DBKey]
        public int Id { get; set; }
        public int Field00 { get; set; }
        public int Field01 { get; set; }
        public int Field02 { get; set; }
        public int Field03 { get; set; }
        public int Field04 { get; set; }
        public int Field05 { get; set; }
    }

    [DBTable(Expansion.Cata)]
    public class SpellCategory
    {
        [DBKey]
        public int Id { get; set; }
        public int Field00 { get; set; }
        public int Field01 { get; set; }
        public string Field02 { get; set; }
    }

    [DBTable(Expansion.Cata)]
    public class SpellChainEffects
    {
        [DBKey]
        public int ID { get; set; }
        public float AvgSegLen { get; set; }
        public float Width { get; set; }
        public float NoiseScale { get; set; }
        public float TexCoordScale { get; set; }
        public int SegDuration { get; set; }
        public int SegDelay { get; set; }
        public int Flags { get; set; }
        public int JointCount { get; set; }
        public float JointOffsetRadius { get; set; }
        public int JointsPerMinorJoint { get; set; }
        public int MinorJointsPerMajorJoint { get; set; }
        public float MinorJointScale { get; set; }
        public float MajorJointScale { get; set; }
        public float JointMoveSpeed { get; set; }
        public float JointSmoothness { get; set; }
        public float MinDurationBetweenJointJumps { get; set; }
        public float MaxDurationBetweenJointJumps { get; set; }
        public float WaveHeight { get; set; }
        public float WaveFreq { get; set; }
        public float WaveSpeed { get; set; }
        public float MinWaveAngle { get; set; }
        public float MaxWaveAngle { get; set; }
        public float MinWaveSpin { get; set; }
        public float MaxWaveSpin { get; set; }
        public float ArcHeight { get; set; }
        public float MinArcAngle { get; set; }
        public float MaxArcAngle { get; set; }
        public float MinArcSpin { get; set; }
        public float MaxArcSpin { get; set; }
        public float DelayBetweenEffects { get; set; }
        public float MinFlickerOnDuration { get; set; }
        public float MaxFlickerOnDuration { get; set; }
        public float MinFlickerOffDuration { get; set; }
        public float MaxFlickerOffDuration { get; set; }
        public float PulseSpeed { get; set; }
        public float PulseOnLength { get; set; }
        public float PulseFadeLength { get; set; }
        public byte Alpha { get; set; }
        public byte Red { get; set; }
        public byte Green { get; set; }
        public byte Blue { get; set; }
        public byte BlendMode { get; set; }
        public int RenderLayer { get; set; }
        public float TextureLength { get; set; }
        public float WavePhase { get; set; }
    }

    [DBTable(Expansion.Cata)]
    public class SpellClassOptions
    {
        [DBKey]
        public int ID { get; set; }
        public uint ModalNextSpell { get; set; }
        public uint SpellClassMask_1 { get; set; }
        public uint SpellClassMask_2 { get; set; }
        public uint SpellClassMask_3 { get; set; }
        public uint SpellClassSet { get; set; }
        public string Description { get; set; }
    }

    [DBTable(Expansion.Cata)]
    public class SpellCooldowns
    {
        [DBKey]
        public int Id { get; set; }
        public int CategoryRecoveryTime { get; set; }
        public int RecoveryTime { get; set; }
        public int StartRecoveryTime { get; set; }
    }

    [DBTable(Expansion.Cata)]
    public class SpellDescriptionVariables
    {
        [DBKey]
        public int Id { get; set; }
        public string Field00 { get; set; }
    }

    [DBTable(Expansion.Cata)]
    public class SpellDifficulty
    {
        [DBKey]
        public int Id { get; set; }
        public int Field00 { get; set; }
        public int Field01 { get; set; }
        public int Field02 { get; set; }
        public int Field03 { get; set; }
    }

    [DBTable(Expansion.Cata)]
    public class SpellDispelType
    {
        [DBKey]
        public int Id { get; set; }
        public string Field00 { get; set; }
        public string Field01 { get; set; }
        public string Field02 { get; set; }
        public string Field03 { get; set; }
    }

    [DBTable(Expansion.Cata)]
    public class SpellDuration
    {
        [DBKey]
        public int Id { get; set; }
        public int Field00 { get; set; }
        public int Field01 { get; set; }
        public int Field02 { get; set; }
    }

    [DBTable(Expansion.Cata)]
    public class SpellEffect
    {
        [DBKey]
        public int ID { get; set; }
        public uint Effect { get; set; }
        public float EffectAmplitude { get; set; }
        public uint EffectAura { get; set; }
        public uint EffectAuraPeriod { get; set; }
        public int EffectBasePoints { get; set; }
        public float EffectUnk_320 { get; set; }
        public float EffectChainAmplitude { get; set; }
        public uint EffectChaintargets { get; set; }
        public uint EffectDieSides { get; set; }
        public uint EffectItemType { get; set; }
        public uint EffectMechanic { get; set; }
        public int EffectMiscValue { get; set; }
        public int EffectMiscValueB { get; set; }
        public float EffectPointsPerCombo { get; set; }
        public uint EffectRadiusIndex { get; set; }
        public uint EffectRadiusMaxIndex { get; set; }
        public float EffectRealPointsPerLevel { get; set; }
        public uint EffectSpellClassMask_1 { get; set; }
        public uint EffectSpellClassMask_2 { get; set; }
        public uint EffectSpellClassMask_3 { get; set; }
        public int EffectTriggerSpell { get; set; }
        public uint ImplicitTargetA { get; set; }
        public uint ImplicitTargetB { get; set; }
        public uint EffectSpellId { get; set; }
        public uint EffectIndex { get; set; }
        public int NewField1 { get; set; }
    }

    [DBTable(Expansion.Cata)]
    public class SpellEffectCameraShakes
    {
        [DBKey]
        public int Id { get; set; }
        public int Field00 { get; set; }
        public int Field01 { get; set; }
        public int Field02 { get; set; }
    }

    [DBTable(Expansion.Cata)]
    public class SpellEquippedItems
    {
        [DBKey]
        public int Id { get; set; }
        public int Field00 { get; set; }
        public int Field01 { get; set; }
        public int Field02 { get; set; }
    }

    [DBTable(Expansion.Cata)]
    public class SpellFlyout
    {
        [DBKey]
        public int NewField0 { get; set; }
        public int ZerosField1 { get; set; }
        public int IntField2 { get; set; }
        public uint FlagsField3 { get; set; }
        public uint SpellIconId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }

    [DBTable(Expansion.Cata)]
    public class SpellFlyoutItem
    {
        [DBKey]
        public int Id { get; set; }
        public int Field00 { get; set; }
        public int Field01 { get; set; }
        public int Field02 { get; set; }
    }

    [DBTable(Expansion.Cata)]
    public class SpellFocusObject
    {
        [DBKey]
        public int ID { get; set; }
        public string Name_lang { get; set; }
    }

    [DBTable(Expansion.Cata)]
    public class SpellIcon
    {
        [DBKey]
        public int Id { get; set; }
        public string Field00 { get; set; }
    }

    [DBTable(Expansion.Cata)]
    public class SpellInterrupts
    {
        [DBKey]
        public int Id { get; set; }
        public int Field00 { get; set; }
        public int Field01 { get; set; }
        public int Field02 { get; set; }
        public int Field03 { get; set; }
        public int Field04 { get; set; }
    }

    [DBTable(Expansion.Cata)]
    public class SpellItemEnchantment
    {
        [DBKey]
        public int Id { get; set; }
        public int Field00 { get; set; }
        public int Field01 { get; set; }
        public int Field02 { get; set; }
        public int Field03 { get; set; }
        public int Field04 { get; set; }
        public int Field05 { get; set; }
        public int Field06 { get; set; }
        public int Field07 { get; set; }
        public int Field08 { get; set; }
        public int Field09 { get; set; }
        public int Field0A { get; set; }
        public int Field0B { get; set; }
        public int Field0C { get; set; }
        public string Field0D { get; set; }
        public int Field0E { get; set; }
        public int Field0F { get; set; }
        public int Field10 { get; set; }
        public int Field11 { get; set; }
        public int Field12 { get; set; }
        public int Field13 { get; set; }
        public int Field14 { get; set; }
        public int Field15 { get; set; }
    }

    [DBTable(Expansion.Cata)]
    public class SpellItemEnchantmentCondition
    {
        [DBKey]
        public int ID { get; set; }
        [DBField(ArraySize: 5)]
        public byte[] Lt_operandType { get; set; }
        [DBField(ArraySize: 5)]
        public int[] Lt_operand { get; set; }
        [DBField(ArraySize: 5)]
        public byte[] Operator { get; set; }
        [DBField(ArraySize: 5)]
        public byte[] Rt_operandType { get; set; }
        [DBField(ArraySize: 5)]
        public int[] Rt_operand { get; set; }
        [DBField(ArraySize: 5)]
        public byte[] Logic { get; set; }
    }

    [DBTable(Expansion.Cata)]
    public class SpellLevels
    {
        [DBKey]
        public int Id { get; set; }
        public int Field00 { get; set; }
        public int Field01 { get; set; }
        public int Field02 { get; set; }
    }

    [DBTable(Expansion.Cata)]
    public class SpellMechanic
    {
        [DBKey]
        public int Id { get; set; }
        public string Field00 { get; set; }
    }

    [DBTable(Expansion.Cata)]
    public class SpellMissile
    {
        [DBKey]
        public int Id { get; set; }
        public int Field00 { get; set; }
        public int Field01 { get; set; }
        public int Field02 { get; set; }
        public int Field03 { get; set; }
        public float Field04 { get; set; }
        public int Field05 { get; set; }
        public int Field06 { get; set; }
        public int Field07 { get; set; }
        public int Field08 { get; set; }
        public int Field09 { get; set; }
        public int Field0A { get; set; }
        public int Field0B { get; set; }
        public int Field0C { get; set; }
        public int Field0D { get; set; }
    }

    [DBTable(Expansion.Cata)]
    public class SpellMissileMotion
    {
        [DBKey]
        public int Id { get; set; }
        public string Field00 { get; set; }
        public string Field01 { get; set; }
        public int Field02 { get; set; }
        public int Field03 { get; set; }
    }

    [DBTable(Expansion.Cata)]
    public class SpellPower
    {
        [DBKey]
        public int Id { get; set; }
        public int Field00 { get; set; }
        public int Field01 { get; set; }
        public int Field02 { get; set; }
        public int Field03 { get; set; }
        public int Field04 { get; set; }
        public int Field05 { get; set; }
        public int Field06 { get; set; }
    }

    [DBTable(Expansion.Cata)]
    public class SpellRadius
    {
        [DBKey]
        public int Id { get; set; }
        public int Field00 { get; set; }
        public int Field01 { get; set; }
        public int Field02 { get; set; }
    }

    [DBTable(Expansion.Cata)]
    public class SpellRange
    {
        [DBKey]
        public int Id { get; set; }
        public int Field00 { get; set; }
        public int Field01 { get; set; }
        public int Field02 { get; set; }
        public int Field03 { get; set; }
        public int Field04 { get; set; }
        public string Field05 { get; set; }
        public string Field06 { get; set; }
    }

    [DBTable(Expansion.Cata)]
    public class SpellReagents
    {
        [DBKey]
        public int Id { get; set; }
        public int Field00 { get; set; }
        public int Field01 { get; set; }
        public int Field02 { get; set; }
        public int Field03 { get; set; }
        public int Field04 { get; set; }
        public int Field05 { get; set; }
        public int Field06 { get; set; }
        public int Field07 { get; set; }
        public int Field08 { get; set; }
        public int Field09 { get; set; }
        public int Field0A { get; set; }
        public int Field0B { get; set; }
        public int Field0C { get; set; }
        public int Field0D { get; set; }
        public int Field0E { get; set; }
        public int Field0F { get; set; }
    }

    [DBTable(Expansion.Cata)]
    public class SpellRuneCost
    {
        [DBKey]
        public int Id { get; set; }
        public int Field00 { get; set; }
        public int Field01 { get; set; }
        public int Field02 { get; set; }
        public int Field03 { get; set; }
    }

    [DBTable(Expansion.Cata)]
    public class SpellScaling
    {
        [DBKey]
        public int Id { get; set; }
        public int Field00 { get; set; }
        public int Field01 { get; set; }
        public int Field02 { get; set; }
        public int Field03 { get; set; }
        public int Field04 { get; set; }
        public int Field05 { get; set; }
        public int Field06 { get; set; }
        public int Field07 { get; set; }
        public int Field08 { get; set; }
        public int Field09 { get; set; }
        public int Field0A { get; set; }
        public int Field0B { get; set; }
        public int Field0C { get; set; }
        public int Field0D { get; set; }
        public int Field0E { get; set; }
    }

    [DBTable(Expansion.Cata)]
    public class SpellShapeshift
    {
        [DBKey]
        public int Id { get; set; }
        public int Field00 { get; set; }
        public int Field01 { get; set; }
        public int Field02 { get; set; }
        public int Field03 { get; set; }
        public int Field04 { get; set; }
    }

    [DBTable(Expansion.Cata)]
    public class SpellShapeshiftForm
    {
        [DBKey]
        public int Id { get; set; }
        public int Field00 { get; set; }
        public string Field01 { get; set; }
        public int Field02 { get; set; }
        public int Field03 { get; set; }
        public int Field04 { get; set; }
        public int Field05 { get; set; }
        public int Field06 { get; set; }
        public int Field07 { get; set; }
        public int Field08 { get; set; }
        public int Field09 { get; set; }
        public int Field0A { get; set; }
        public int Field0B { get; set; }
        public int Field0C { get; set; }
        public int Field0D { get; set; }
        public int Field0E { get; set; }
        public int Field0F { get; set; }
        public int Field10 { get; set; }
        public int Field11 { get; set; }
        public int Field12 { get; set; }
        public int Field13 { get; set; }
    }

    [DBTable(Expansion.Cata)]
    public class SpellSpecialUnitEffect
    {
        [DBKey]
        public int Id { get; set; }
        public int Field00 { get; set; }
    }

    [DBTable(Expansion.Cata)]
    public class SpellTargetRestrictions
    {
        [DBKey]
        public int Id { get; set; }
        public int Field00 { get; set; }
        public int Field01 { get; set; }
        public int Field02 { get; set; }
        public int Field03 { get; set; }
        public int Field04 { get; set; }
    }

    [DBTable(Expansion.Cata)]
    public class SpellTotems
    {
        [DBKey]
        public int Id { get; set; }
        public int Field00 { get; set; }
        public int Field01 { get; set; }
        public int Field02 { get; set; }
        public int Field03 { get; set; }
    }

    [DBTable(Expansion.Cata)]
    public class SpellVisual
    {
        [DBKey]
        public int Id { get; set; }
        public int Field00 { get; set; }
        public int Field01 { get; set; }
        public int Field02 { get; set; }
        public int Field03 { get; set; }
        public int Field04 { get; set; }
        public int Field05 { get; set; }
        public int Field06 { get; set; }
        public int Field07 { get; set; }
        public int Field08 { get; set; }
        public int Field09 { get; set; }
        public int Field0A { get; set; }
        public int Field0B { get; set; }
        public int Field0C { get; set; }
        public int Field0D { get; set; }
        public int Field0E { get; set; }
        public int Field0F { get; set; }
        public int Field10 { get; set; }
        public int Field11 { get; set; }
        public int Field12 { get; set; }
        public int Field13 { get; set; }
        public int Field14 { get; set; }
        public int Field15 { get; set; }
        public int Field16 { get; set; }
        public int Field17 { get; set; }
        public int Field18 { get; set; }
        public int Field19 { get; set; }
        public int Field1A { get; set; }
        public int Field1B { get; set; }
        public int Field1C { get; set; }
        public int Field1D { get; set; }
        public int Field1E { get; set; }
        public int Field1F { get; set; }
    }

    [DBTable(Expansion.Cata)]
    public class SpellVisualEffectName
    {
        [DBKey]
        public int Id { get; set; }
        public string Field00 { get; set; }
        public string Field01 { get; set; }
        public int Field02 { get; set; }
        public int Field03 { get; set; }
        public int Field04 { get; set; }
        public int Field05 { get; set; }
        public int Field06 { get; set; }
        public int Field07 { get; set; }
    }

    [DBTable(Expansion.Cata)]
    public class SpellVisualKit
    {
        [DBKey]
        public int Id { get; set; }
        public int Field00 { get; set; }
        public int Field01 { get; set; }
        public int Field02 { get; set; }
        public int Field03 { get; set; }
        public int Field04 { get; set; }
        public int Field05 { get; set; }
        public int Field06 { get; set; }
        public int Field07 { get; set; }
        public int Field08 { get; set; }
        public int Field09 { get; set; }
        public int Field0A { get; set; }
        public int Field0B { get; set; }
        public int Field0C { get; set; }
        public int Field0D { get; set; }
        public int Field0E { get; set; }
        public int Field0F { get; set; }
        public int Field10 { get; set; }
        public int Field11 { get; set; }
        public int Field12 { get; set; }
        public int Field13 { get; set; }
        public int Field14 { get; set; }
        public int Field15 { get; set; }
        public int Field16 { get; set; }
        public int Field17 { get; set; }
        public int Field18 { get; set; }
        public int Field19 { get; set; }
        public int Field1A { get; set; }
        public int Field1B { get; set; }
        public int Field1C { get; set; }
        public int Field1D { get; set; }
        public int Field1E { get; set; }
        public int Field1F { get; set; }
        public int Field20 { get; set; }
        public int Field21 { get; set; }
        public int Field22 { get; set; }
        public int Field23 { get; set; }
        public int Field24 { get; set; }
        public int Field25 { get; set; }
    }

    [DBTable(Expansion.Cata)]
    public class SpellVisualKitAreaModel
    {
        [DBKey]
        public int Id { get; set; }
        public string Field00 { get; set; }
        public int Field01 { get; set; }
        public int Field02 { get; set; }
        public int Field03 { get; set; }
        public int Field04 { get; set; }
        public float Field05 { get; set; }
    }

    [DBTable(Expansion.Cata)]
    public class SpellVisualKitModelAttach
    {
        [DBKey]
        public int Id { get; set; }
        public int Field00 { get; set; }
        public int Field01 { get; set; }
        public int Field02 { get; set; }
        public int Field03 { get; set; }
        public int Field04 { get; set; }
        public int Field05 { get; set; }
        public int Field06 { get; set; }
        public int Field07 { get; set; }
        public int Field08 { get; set; }
        public int Field09 { get; set; }
        public int Field0A { get; set; }
        public int Field0B { get; set; }
        public int Field0C { get; set; }
    }

    [DBTable(Expansion.Cata)]
    public class SpellVisualPrecastTransitions
    {
        [DBKey]
        public int Id { get; set; }
        public string Field00 { get; set; }
        public string Field01 { get; set; }
    }

    [DBTable(Expansion.Cata)]
    public class Startup_strings
    {
        [DBKey]
        public int Field0 { get; set; }
        public string Field1 { get; set; }
        public string Field2 { get; set; }
    }

    [DBTable(Expansion.Cata)]
    public class Stationery
    {
        [DBKey]
        public int Id { get; set; }
        public int Field00 { get; set; }
        public string Field01 { get; set; }
        public int Field02 { get; set; }
    }

    [DBTable(Expansion.Cata)]
    public class StringLookups
    {
        [DBKey]
        public int Field0 { get; set; }
        public string Field1 { get; set; }
    }

    [DBTable(Expansion.Cata)]
    public class SummonProperties
    {
        [DBKey]
        public int Id { get; set; }
        public uint Group { get; set; }
        public uint Faction { get; set; }
        public int SummonTitle { get; set; }
        public int SummonType { get; set; }
        public uint Flags { get; set; }
    }

    [DBTable(Expansion.Cata)]
    public class Talent
    {
        [DBKey]
        public int Id { get; set; }
        public int Field00 { get; set; }
        public int Field01 { get; set; }
        public int Field02 { get; set; }
        public int Field03 { get; set; }
        public int Field04 { get; set; }
        public int Field05 { get; set; }
        public int Field06 { get; set; }
        public int Field07 { get; set; }
        public int Field08 { get; set; }
        public int Field09 { get; set; }
        public int Field0A { get; set; }
        public int Field0B { get; set; }
        public int Field0C { get; set; }
        public int Field0D { get; set; }
        public int Field0E { get; set; }
        public int Field0F { get; set; }
        public int Field10 { get; set; }
        public int Field11 { get; set; }
    }

    [DBTable(Expansion.Cata)]
    public class TalentTab
    {
        [DBKey]
        public int Id { get; set; }
        public string Field00 { get; set; }
        public int Field01 { get; set; }
        public int Field02 { get; set; }
        public int Field03 { get; set; }
        public int Field04 { get; set; }
        public string Field05 { get; set; }
        public string Field06 { get; set; }
        public int Field07 { get; set; }
        public int Field08 { get; set; }
        public int Field09 { get; set; }
    }

    [DBTable(Expansion.Cata)]
    public class TalentTreePrimarySpells
    {
        [DBKey]
        public int Id { get; set; }
        public int Field00 { get; set; }
        public int Field01 { get; set; }
        public int Field02 { get; set; }
    }

    [DBTable(Expansion.Cata)]
    public class TaxiNodes
    {
        [DBKey]
        public int Field0 { get; set; }
        public int Field1 { get; set; }
        public float Field2 { get; set; }
        public float Field3 { get; set; }
        public float Field4 { get; set; }
        public int Field5 { get; set; }
        public int Field6 { get; set; }
        public int Field7 { get; set; }
        public int Field8 { get; set; }
        public float Field9 { get; set; }
        public float Field10 { get; set; }
    }

    [DBTable(Expansion.Cata)]
    public class TaxiPath
    {
        [DBKey]
        public int Id { get; set; }
        public int Field00 { get; set; }
        public int Field01 { get; set; }
        public int Field02 { get; set; }
    }

    [DBTable(Expansion.Cata)]
    public class TaxiPathNode
    {
        [DBKey]
        public int Id { get; set; }
        public int Field00 { get; set; }
        public int Field01 { get; set; }
        public int Field02 { get; set; }
        public int Field03 { get; set; }
        public int Field04 { get; set; }
        public int Field05 { get; set; }
        public int Field06 { get; set; }
        public int Field07 { get; set; }
        public int Field08 { get; set; }
        public int Field09 { get; set; }
    }

    [DBTable(Expansion.Cata)]
    public class TerrainMaterial
    {
        [DBKey]
        public int Id { get; set; }
        public string Field00 { get; set; }
        public int Field01 { get; set; }
        public string Field02 { get; set; }
    }

    [DBTable(Expansion.Cata)]
    public class TerrainType
    {
        [DBKey]
        public int Id { get; set; }
        public int Field00 { get; set; }
        public string Field01 { get; set; }
        public int Field02 { get; set; }
        public int Field03 { get; set; }
        public int Field04 { get; set; }
        public int Field05 { get; set; }
    }

    [DBTable(Expansion.Cata)]
    public class TerraintypeSounds
    {
        [DBKey]
        public int ID { get; set; }
    }

    [DBTable(Expansion.Cata)]
    public class TotemCategory
    {
        [DBKey]
        public int Id { get; set; }
        public string Field00 { get; set; }
        public int Field01 { get; set; }
        public int Field02 { get; set; }
    }

    [DBTable(Expansion.Cata)]
    public class TransportAnimation
    {
        [DBKey]
        public int Id { get; set; }
        public int Field00 { get; set; }
        public int Field01 { get; set; }
        public int Field02 { get; set; }
        public int Field03 { get; set; }
        public int Field04 { get; set; }
        public int Field05 { get; set; }
    }

    [DBTable(Expansion.Cata)]
    public class TransportPhysics
    {
        [DBKey]
        public int Id { get; set; }
        public int Field00 { get; set; }
        public int Field01 { get; set; }
        public float Field02 { get; set; }
        public float Field03 { get; set; }
        public int Field04 { get; set; }
        public int Field05 { get; set; }
        public float Field06 { get; set; }
        public float Field07 { get; set; }
        public float Field08 { get; set; }
        public float Field09 { get; set; }
    }

    [DBTable(Expansion.Cata)]
    public class TransportRotation
    {
        [DBKey]
        public int Id { get; set; }
        public int Field00 { get; set; }
        public int Field01 { get; set; }
        public int Field02 { get; set; }
        public int Field03 { get; set; }
        public int Field04 { get; set; }
        public int Field05 { get; set; }
    }

    [DBTable(Expansion.Cata)]
    public class UnitBlood
    {
        [DBKey]
        public int Id { get; set; }
        public int Field00 { get; set; }
        public int Field01 { get; set; }
        public int Field02 { get; set; }
        public int Field03 { get; set; }
        public string Field04 { get; set; }
        public string Field05 { get; set; }
        public string Field06 { get; set; }
        public string Field07 { get; set; }
        public int Field08 { get; set; }
    }

    [DBTable(Expansion.Cata)]
    public class UnitBloodLevels
    {
        [DBKey]
        public int Id { get; set; }
        public int Field00 { get; set; }
        public int Field01 { get; set; }
        public int Field02 { get; set; }
    }

    [DBTable(Expansion.Cata)]
    public class UnitPowerBar
    {
        [DBKey]
        public int Id { get; set; }
        public int Field00 { get; set; }
        public int Field01 { get; set; }
        public int Field02 { get; set; }
        public int Field03 { get; set; }
        public int Field04 { get; set; }
        public int Field05 { get; set; }
        public int Field06 { get; set; }
        public int Field07 { get; set; }
        public int Field08 { get; set; }
        public int Field09 { get; set; }
        public int Field0A { get; set; }
        public int Field0B { get; set; }
        public int Field0C { get; set; }
        public int Field0D { get; set; }
        public int Field0E { get; set; }
        public int Field0F { get; set; }
        public int Field10 { get; set; }
        public int Field11 { get; set; }
        public int Field12 { get; set; }
        public int Field13 { get; set; }
        public string Field14 { get; set; }
        public string Field15 { get; set; }
        public string Field16 { get; set; }
        public string Field17 { get; set; }
        public int Field18 { get; set; }
        public int Field19 { get; set; }
    }

    [DBTable(Expansion.Cata)]
    public class Vehicle
    {
        [DBKey]
        public int Id { get; set; }
        public int Field00 { get; set; }
        public float Field01 { get; set; }
        public int Field02 { get; set; }
        public int Field03 { get; set; }
        public int Field04 { get; set; }
        public int Field05 { get; set; }
        public int Field06 { get; set; }
        public int Field07 { get; set; }
        public int Field08 { get; set; }
        public int Field09 { get; set; }
        public int Field0A { get; set; }
        public int Field0B { get; set; }
        public int Field0C { get; set; }
        public int Field0D { get; set; }
        public int Field0E { get; set; }
        public int Field0F { get; set; }
        public int Field10 { get; set; }
        public int Field11 { get; set; }
        public int Field12 { get; set; }
        public int Field13 { get; set; }
        public int Field14 { get; set; }
        public int Field15 { get; set; }
        public int Field16 { get; set; }
        public int Field17 { get; set; }
        public int Field18 { get; set; }
        public int Field19 { get; set; }
        public int Field1A { get; set; }
        public int Field1B { get; set; }
        public string Field1C { get; set; }
        public string Field1D { get; set; }
        public string Field1E { get; set; }
        public string Field1F { get; set; }
        public int Field20 { get; set; }
        public int Field21 { get; set; }
        public int Field22 { get; set; }
        public int Field23 { get; set; }
        public int Field24 { get; set; }
        public int Field25 { get; set; }
        public int Field26 { get; set; }
    }

    [DBTable(Expansion.Cata)]
    public class VehicleSeat
    {
        [DBKey]
        public int Id { get; set; }
        public int Field00 { get; set; }
        public int Field01 { get; set; }
        public int Field02 { get; set; }
        public int Field03 { get; set; }
        public int Field04 { get; set; }
        public int Field05 { get; set; }
        public float Field06 { get; set; }
        public int Field07 { get; set; }
        public int Field08 { get; set; }
        public int Field09 { get; set; }
        public int Field0A { get; set; }
        public int Field0B { get; set; }
        public int Field0C { get; set; }
        public int Field0D { get; set; }
        public int Field0E { get; set; }
        public int Field0F { get; set; }
        public int Field10 { get; set; }
        public int Field11 { get; set; }
        public int Field12 { get; set; }
        public int Field13 { get; set; }
        public int Field14 { get; set; }
        public int Field15 { get; set; }
        public int Field16 { get; set; }
        public int Field17 { get; set; }
        public int Field18 { get; set; }
        public int Field19 { get; set; }
        public int Field1A { get; set; }
        public int Field1B { get; set; }
        public int Field1C { get; set; }
        public int Field1D { get; set; }
        public int Field1E { get; set; }
        public int Field1F { get; set; }
        public int Field20 { get; set; }
        public int Field21 { get; set; }
        public int Field22 { get; set; }
        public int Field23 { get; set; }
        public int Field24 { get; set; }
        public int Field25 { get; set; }
        public int Field26 { get; set; }
        public int Field27 { get; set; }
        public int Field28 { get; set; }
        public int Field29 { get; set; }
        public int Field2A { get; set; }
        public int Field2B { get; set; }
        public int Field2C { get; set; }
        public int Field2D { get; set; }
        public int Field2E { get; set; }
        public int Field2F { get; set; }
        public int Field30 { get; set; }
        public int Field31 { get; set; }
        public int Field32 { get; set; }
        public int Field33 { get; set; }
        public int Field34 { get; set; }
        public int Field35 { get; set; }
        public int Field36 { get; set; }
        public int Field37 { get; set; }
        public int Field38 { get; set; }
        public int Field39 { get; set; }
        public int Field3A { get; set; }
        public int Field3B { get; set; }
        public int Field3C { get; set; }
        public int Field3D { get; set; }
        public int Field3E { get; set; }
        public int Field3F { get; set; }
        public int Field40 { get; set; }
    }

    [DBTable(Expansion.Cata)]
    public class VehicleUIIndicator
    {
        [DBKey]
        public int Id { get; set; }
        public string Field00 { get; set; }
    }

    [DBTable(Expansion.Cata)]
    public class VehicleUIIndSeat
    {
        [DBKey]
        public int Id { get; set; }
        public int Field00 { get; set; }
        public int Field01 { get; set; }
        public float Field02 { get; set; }
        public float Field03 { get; set; }
    }

    [DBTable(Expansion.Cata)]
    public class VideoHardware
    {
        [DBKey]
        public int Id { get; set; }
        public int Field00 { get; set; }
        public int Field01 { get; set; }
        public int Field02 { get; set; }
        public int Field03 { get; set; }
        public string Field04 { get; set; }
        public int Field05 { get; set; }
        public string Field06 { get; set; }
        public string Field07 { get; set; }
        public string Field08 { get; set; }
        public int Field09 { get; set; }
        public string Field0A { get; set; }
        public string Field0B { get; set; }
        public int Field0C { get; set; }
        public int Field0D { get; set; }
        public int Field0E { get; set; }
        public int Field0F { get; set; }
        public string Field10 { get; set; }
        public string Field11 { get; set; }
        public string Field12 { get; set; }
        public string Field13 { get; set; }
        public int Field14 { get; set; }
        public string Field15 { get; set; }
    }

    [DBTable(Expansion.Cata)]
    public class VocalUISounds
    {
        [DBKey]
        public int Id { get; set; }
        public int Field00 { get; set; }
        public int Field01 { get; set; }
        public int Field02 { get; set; }
        public int Field03 { get; set; }
        public int Field04 { get; set; }
        public int Field05 { get; set; }
    }

    [DBTable(Expansion.Cata)]
    public class WeaponImpactSounds
    {
        [DBKey]
        public int Id { get; set; }
        public int Field00 { get; set; }
        public int Field01 { get; set; }
        public int Field02 { get; set; }
        public int Field03 { get; set; }
        public int Field04 { get; set; }
        public int Field05 { get; set; }
        public int Field06 { get; set; }
        public int Field07 { get; set; }
        public int Field08 { get; set; }
        public int Field09 { get; set; }
        public int Field0A { get; set; }
        public int Field0B { get; set; }
        public int Field0C { get; set; }
        public int Field0D { get; set; }
        public int Field0E { get; set; }
        public int Field0F { get; set; }
        public int Field10 { get; set; }
        public int Field11 { get; set; }
        public int Field12 { get; set; }
        public int Field13 { get; set; }
        public int Field14 { get; set; }
        public int Field15 { get; set; }
    }

    [DBTable(Expansion.Cata)]
    public class WeaponSwingSounds2
    {
        [DBKey]
        public int Id { get; set; }
        public int Field00 { get; set; }
        public int Field01 { get; set; }
        public int Field02 { get; set; }
    }

    [DBTable(Expansion.Cata)]
    public class Weather
    {
        [DBKey]
        public int Id { get; set; }
        public int Field00 { get; set; }
        public int Field01 { get; set; }
        public int Field02 { get; set; }
        public int Field03 { get; set; }
        public int Field04 { get; set; }
        public int Field05 { get; set; }
        public string Field06 { get; set; }
    }

    [DBTable(Expansion.Cata)]
    public class WMOAreaTable
    {
        [DBKey]
        public int Field0 { get; set; }
        public int Field1 { get; set; }
        public int Field2 { get; set; }
        public int Field3 { get; set; }
        public int Field4 { get; set; }
        public int Field5 { get; set; }
        public int Field6 { get; set; }
        public int Field7 { get; set; }
        public int Field8 { get; set; }
        public int Field9 { get; set; }
        public int Field10 { get; set; }
        public string Field11 { get; set; }
        public int Field12 { get; set; }
        public int Field13 { get; set; }
        public int Field14 { get; set; }
    }

    [DBTable(Expansion.Cata)]
    public class World_PVP_Area
    {
        [DBKey]
        public int Field0 { get; set; }
        public int Field1 { get; set; }
        public int Field2 { get; set; }
        public int Field3 { get; set; }
        public int Field4 { get; set; }
        public int Field5 { get; set; }
        public int Field6 { get; set; }
    }

    [DBTable(Expansion.Cata)]
    public class WorldChunkSounds
    {
        [DBKey]
        public int Id { get; set; }
        public float Field00 { get; set; }
        public float Field01 { get; set; }
        public float Field02 { get; set; }
        public float Field03 { get; set; }
        public float Field04 { get; set; }
        public float Field05 { get; set; }
        public float Field06 { get; set; }
        public float Field07 { get; set; }
        public float Field08 { get; set; }
    }

    [DBTable(Expansion.Cata)]
    public class WorldMapArea
    {
        [DBKey]
        public int Id { get; set; }
        public int Field00 { get; set; }
        public int Field01 { get; set; }
        public string Field02 { get; set; }
        public int Field03 { get; set; }
        public int Field04 { get; set; }
        public int Field05 { get; set; }
        public int Field06 { get; set; }
        public int Field07 { get; set; }
        public int Field08 { get; set; }
        public int Field09 { get; set; }
        public int Field0A { get; set; }
        public int Field0B { get; set; }
        public int Field0C { get; set; }
    }

    [DBTable(Expansion.Cata)]
    public class WorldMapContinent
    {
        [DBKey]
        public int Id { get; set; }
        public int Field00 { get; set; }
        public int Field01 { get; set; }
        public int Field02 { get; set; }
        public int Field03 { get; set; }
        public int Field04 { get; set; }
        public int Field05 { get; set; }
        public int Field06 { get; set; }
        public float Field07 { get; set; }
        public int Field08 { get; set; }
        public int Field09 { get; set; }
        public int Field0A { get; set; }
        public int Field0B { get; set; }
        public int Field0C { get; set; }
    }

    [DBTable(Expansion.Cata)]
    public class WorldMapOverlay
    {
        [DBKey]
        public int Id { get; set; }
        public int Field00 { get; set; }
        public int Field01 { get; set; }
        public int Field02 { get; set; }
        public int Field03 { get; set; }
        public int Field04 { get; set; }
        public string Field05 { get; set; }
        public int Field06 { get; set; }
        public int Field07 { get; set; }
        public int Field08 { get; set; }
        public int Field09 { get; set; }
        public int Field0A { get; set; }
        public int Field0B { get; set; }
        public int Field0C { get; set; }
        public int Field0D { get; set; }
    }

    [DBTable(Expansion.Cata)]
    public class WorldMapTransforms
    {
        [DBKey]
        public int Id { get; set; }
        public int Field00 { get; set; }
        public int Field01 { get; set; }
        public int Field02 { get; set; }
        public int Field03 { get; set; }
        public int Field04 { get; set; }
        public int Field05 { get; set; }
        public int Field06 { get; set; }
        public int Field07 { get; set; }
        public int Field08 { get; set; }
        public int Field09 { get; set; }
        public int Field0A { get; set; }
    }

    [DBTable(Expansion.Cata)]
    public class WorldSafelocs
    {
        [DBKey]
        public int Id { get; set; }
        public uint Map { get; set; }
        public float Pos_x { get; set; }
        public float Pos_y { get; set; }
        public float Pos_z { get; set; }
        public string Name_lang { get; set; }
    }

    [DBTable(Expansion.Cata)]
    public class WorldStateUI
    {
        [DBKey]
        public int Id { get; set; }
        public int Field00 { get; set; }
        public int Field01 { get; set; }
        public int Field02 { get; set; }
        public int Field03 { get; set; }
        public int Field04 { get; set; }
        public string Field05 { get; set; }
        public string Field06 { get; set; }
        public string Field07 { get; set; }
        public int Field08 { get; set; }
        public int Field09 { get; set; }
        public string Field0A { get; set; }
        public string Field0B { get; set; }
        public string Field0C { get; set; }
        public int Field0D { get; set; }
        public int Field0E { get; set; }
        public int Field0F { get; set; }
    }

    [DBTable(Expansion.Cata)]
    public class WorldStateZoneSounds
    {
        [DBKey]
        public int Id { get; set; }
        public int Field00 { get; set; }
        public int Field01 { get; set; }
        public int Field02 { get; set; }
        public int Field03 { get; set; }
        public int Field04 { get; set; }
        public int Field05 { get; set; }
        public int Field06 { get; set; }
        public int Field07 { get; set; }
    }

    [DBTable(Expansion.Cata)]
    public class WowError_strings
    {
        [DBKey]
        public int Field0 { get; set; }
        public string Field1 { get; set; }
        public string Field2 { get; set; }
    }

    [DBTable(Expansion.Cata)]
    public class ZoneIntroMusicTable
    {
        [DBKey]
        public int Id { get; set; }
        public string Field00 { get; set; }
        public int Field01 { get; set; }
        public string Field02 { get; set; }
        public int Field03 { get; set; }
    }

    [DBTable(Expansion.Cata)]
    public class ZoneLight
    {
        [DBKey]
        public int Id { get; set; }
        public string Field00 { get; set; }
        public int Field01 { get; set; }
        public int Field02 { get; set; }
    }

    [DBTable(Expansion.Cata)]
    public class ZoneLightPoint
    {
        [DBKey]
        public int Id { get; set; }
        public int Field00 { get; set; }
        public int Field01 { get; set; }
        public int Field02 { get; set; }
        public int Field03 { get; set; }
    }

    [DBTable(Expansion.Cata)]
    public class ZoneMusic
    {
        [DBKey]
        public int Id { get; set; }
        public string Field00 { get; set; }
        public int Field01 { get; set; }
        public int Field02 { get; set; }
        public int Field03 { get; set; }
        public int Field04 { get; set; }
        public int Field05 { get; set; }
        public int Field06 { get; set; }
    }

}
