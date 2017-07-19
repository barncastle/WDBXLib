using System;
using WDBXLib.Attributes;
using WDBXLib.Helpers;
using static WDBXLib.Common.Constants;

namespace WDBXLib.Definitions.MoP
{

    [DBTable(Expansion.MoP)]
    public class Achievement
    {
        [DBKey]
        public int ID { get; set; }
        public int Faction { get; set; }
        public int Instance_id { get; set; }
        public uint Supercedes { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public uint Category { get; set; }
        public uint Points { get; set; }
        public uint Ui_order { get; set; }
        public uint Flags { get; set; }
        public uint IconID { get; set; }
        public string Reward { get; set; }
        public uint Minimum_criteria { get; set; }
        public uint Shares_criteria { get; set; }
        public int Criteria_tree { get; set; }
    }

    [DBTable(Expansion.MoP)]
    public class Achievement_Category
    {
        [DBKey]
        public int Id { get; set; }
        public int Field00 { get; set; }
        public string Field01 { get; set; }
        public int Field02 { get; set; }
    }

    [DBTable(Expansion.MoP)]
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

    [DBTable(Expansion.MoP)]
    public class AnimationData
    {
        [DBKey]
        public int ID { get; set; }
        public string Name { get; set; }
        public int Flags { get; set; }
        public int Fallback { get; set; }
        public int BehaviorID { get; set; }
        public int BehaviorTier { get; set; }
    }

    [DBTable(Expansion.MoP)]
    public class AnimKit
    {
        [DBKey]
        public int Id { get; set; }
        public int Field00 { get; set; }
        public int Field01 { get; set; }
    }

    [DBTable(Expansion.MoP)]
    public class AnimKitBoneSet
    {
        [DBKey]
        public int Id { get; set; }
        public string Field00 { get; set; }
        public int Field01 { get; set; }
        public int Field02 { get; set; }
        public int Field03 { get; set; }
        public int Field04 { get; set; }
    }

    [DBTable(Expansion.MoP)]
    public class AnimKitBoneSetAlias
    {
        [DBKey]
        public int Id { get; set; }
        public int Field00 { get; set; }
        public int Field01 { get; set; }
    }

    [DBTable(Expansion.MoP)]
    public class AnimKitConfig
    {
        [DBKey]
        public int Id { get; set; }
        public int Field00 { get; set; }
    }

    [DBTable(Expansion.MoP)]
    public class AnimKitConfigBoneSet
    {
        [DBKey]
        public int Id { get; set; }
        public int Field00 { get; set; }
        public int Field01 { get; set; }
        public int Field02 { get; set; }
    }

    [DBTable(Expansion.MoP)]
    public class AnimKitPriority
    {
        [DBKey]
        public int Id { get; set; }
        public int Field00 { get; set; }
    }

    [DBTable(Expansion.MoP)]
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

    [DBTable(Expansion.MoP)]
    public class AnimReplacement
    {
        [DBKey]
        public int Id { get; set; }
        public int Field00 { get; set; }
        public int Field01 { get; set; }
        public int Field02 { get; set; }
    }

    [DBTable(Expansion.MoP)]
    public class AnimReplacementSet
    {
        [DBKey]
        public int Id { get; set; }
        public int Field00 { get; set; }
    }

    [DBTable(Expansion.MoP)]
    public class AreaAssignment
    {
        [DBKey]
        public int Id { get; set; }
        public int Field00 { get; set; }
        public int Field01 { get; set; }
        public int Field02 { get; set; }
        public int Field03 { get; set; }
    }

    [DBTable(Expansion.MoP)]
    public class AreaGroup
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

    [DBTable(Expansion.MoP)]
    public class AreaPOI
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
        public float Field12 { get; set; }
        public float Field13 { get; set; }
        public int Field14 { get; set; }
        public int Field15 { get; set; }
        public int Field16 { get; set; }
        public string Field17 { get; set; }
        public string Field18 { get; set; }
        public int Field19 { get; set; }
        public int Field20 { get; set; }
        public int Field21 { get; set; }
        public int Field22 { get; set; }
    }

    [DBTable(Expansion.MoP)]
    public class AreaTable
    {
        [DBKey]
        public int ID { get; set; }
        public int ContinentID { get; set; }
        public int ParentAreaID { get; set; }
        public int AreaBit { get; set; }
        public int Flags_1 { get; set; }
        public int Flags_2 { get; set; }
        public int SoundProviderPref { get; set; }
        public int SoundProviderPrefUnderwater { get; set; }
        public int AmbienceID { get; set; }
        public string ZoneName { get; set; }
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
        public int MountFlags { get; set; }
        public int UwintroSound { get; set; }
        public int UwZoneMusic { get; set; }
        public int UwAmbience { get; set; }
        public int World_pvp_id { get; set; }
        public int PvpCombatWorldStateID { get; set; }
        public int WildBattlePetLevelMin { get; set; }
        public int WildBattlePetLevelMax { get; set; }
        public int WindSettingsID { get; set; }
    }

    [DBTable(Expansion.MoP)]
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
        public int NewField13 { get; set; }
        public int NewField14 { get; set; }
        public int NewField15 { get; set; }
        public int NewField16 { get; set; }
    }

    [DBTable(Expansion.MoP)]
    public class AreaTriggerActionSet
    {
        [DBKey]
        public int Id { get; set; }
        public int Field00 { get; set; }
    }

    [DBTable(Expansion.MoP)]
    public class AreaTriggerBox
    {
        [DBKey]
        public int Id { get; set; }
        public float Field00 { get; set; }
        public float Field01 { get; set; }
        public float Field02 { get; set; }
    }

    [DBTable(Expansion.MoP)]
    public class AreaTriggerSphere
    {
        [DBKey]
        public int Id { get; set; }
        public float Field00 { get; set; }
    }

    [DBTable(Expansion.MoP)]
    public class ArmorLocation
    {
        [DBKey]
        public int Id { get; set; }
        public int Field00 { get; set; }
        public int Field01 { get; set; }
        public int Field02 { get; set; }
        public int Field03 { get; set; }
        public int Field04 { get; set; }
    }

    [DBTable(Expansion.MoP)]
    public class AttackAnimKits
    {
        [DBKey]
        public int Id { get; set; }
        public int Field00 { get; set; }
        public int Field01 { get; set; }
        public int Field02 { get; set; }
        public int Field03 { get; set; }
    }

    [DBTable(Expansion.MoP)]
    public class AttackAnimTypes
    {
        [DBKey]
        public int Id { get; set; }
        public string Field00 { get; set; }
    }

    [DBTable(Expansion.MoP)]
    public class AuctionHouse
    {
        [DBKey]
        public int Id { get; set; }
        public int Field00 { get; set; }
        public int Field01 { get; set; }
        public int Field02 { get; set; }
        public string Field03 { get; set; }
    }

    [DBTable(Expansion.MoP)]
    public class BankBagSlotPrices
    {
        [DBKey]
        public int Id { get; set; }
        public int Field00 { get; set; }
    }

    [DBTable(Expansion.MoP)]
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

    [DBTable(Expansion.MoP)]
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

    [DBTable(Expansion.MoP)]
    public class BattleMasterList
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
        public string Field19 { get; set; }
        public int Field20 { get; set; }
        public int Field21 { get; set; }
        public int Field22 { get; set; }
        public int Field23 { get; set; }
        public int Field24 { get; set; }
        public int Field25 { get; set; }
        public int Field26 { get; set; }
        public int Field27 { get; set; }
        public int Field28 { get; set; }
        public string Field29 { get; set; }
    }

    [DBTable(Expansion.MoP)]
    public class BattlePetAbility
    {
        [DBKey]
        public int Field0 { get; set; }
        public int Field1 { get; set; }
        public int Field2 { get; set; }
        public int Field3 { get; set; }
        public int Field4 { get; set; }
        public int Field5 { get; set; }
        public string Field6 { get; set; }
        public string Field7 { get; set; }
    }

    [DBTable(Expansion.MoP)]
    public class CameraMode
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
    }

    [DBTable(Expansion.MoP)]
    public class CameraShakes
    {
        [DBKey]
        public int Id { get; set; }
        public int Field00 { get; set; }
        public int Field01 { get; set; }
        public int Field02 { get; set; }
        public float Field03 { get; set; }
        public int Field04 { get; set; }
        public int Field05 { get; set; }
        public int Field06 { get; set; }
        public int Field07 { get; set; }
    }

    [DBTable(Expansion.MoP)]
    public class CastableRaidBuffs
    {
        [DBKey]
        public int Id { get; set; }
        public int Field00 { get; set; }
        public int Field01 { get; set; }
    }

    [DBTable(Expansion.MoP)]
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

    [DBTable(Expansion.MoP)]
    public class Cfg_Configs
    {
        [DBKey]
        public int Id { get; set; }
        public int Field00 { get; set; }
        public int Field01 { get; set; }
        public int Field02 { get; set; }
        public int Field03 { get; set; }
        public int Field04 { get; set; }
    }

    [DBTable(Expansion.MoP)]
    public class Cfg_Regions
    {
        [DBKey]
        public int Id { get; set; }
        public string Field00 { get; set; }
        public int Field01 { get; set; }
        public int Field02 { get; set; }
    }

    [DBTable(Expansion.MoP)]
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

    [DBTable(Expansion.MoP)]
    public class CharacterLoadout
    {
        [DBKey]
        public int Id { get; set; }
        public int Field00 { get; set; }
        public int Field01 { get; set; }
        public int Field02 { get; set; }
    }

    [DBTable(Expansion.MoP)]
    public class CharacterLoadoutItem
    {
        [DBKey]
        public int Field0 { get; set; }
        public int Field1 { get; set; }
        public int Field2 { get; set; }
        public int Field3 { get; set; }
        public int Field4 { get; set; }
    }

    [DBTable(Expansion.MoP)]
    public class CharBaseInfo
    {
        [DBKey(AutoGenerated: true)]
        public int GeneratedID { get; set; }
        public byte RaceID { get; set; }
        public byte ClassID { get; set; }
    }

    [DBTable(Expansion.MoP)]
    public class CharComponentTextureLayouts
    {
        [DBKey]
        public int Field0 { get; set; }
        public int Field1 { get; set; }
        public int Field2 { get; set; }
    }

    [DBTable(Expansion.MoP)]
    public class CharComponentTextureSections
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

    [DBTable(Expansion.MoP)]
    public class CharHairGeosets
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

    [DBTable(Expansion.MoP)]
    public class CharSections
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
    }

    [DBTable(Expansion.MoP)]
    public class CharTitles
    {
        [DBKey]
        public int Field0 { get; set; }
        public int Field1 { get; set; }
        public string Field2 { get; set; }
        public string Field3 { get; set; }
        public int Field4 { get; set; }
        public int Field5 { get; set; }
    }

    [DBTable(Expansion.MoP)]
    public class ChatChannels
    {
        [DBKey]
        public int Id { get; set; }
        public int Field00 { get; set; }
        public int Field01 { get; set; }
        public string Field02 { get; set; }
        public string Field03 { get; set; }
    }

    [DBTable(Expansion.MoP)]
    public class ChatProfanity
    {
        [DBKey]
        public int Id { get; set; }
        public string Field00 { get; set; }
        public int Field01 { get; set; }
    }

    [DBTable(Expansion.MoP)]
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
        public int Field14 { get; set; }
        public int Field15 { get; set; }
        public int Field16 { get; set; }
        public int Field17 { get; set; }
    }

    [DBTable(Expansion.MoP)]
    public class ChrClassesXPowerTypes
    {
        [DBKey]
        public int Id { get; set; }
        public int Field00 { get; set; }
        public int Field01 { get; set; }
    }

    [DBTable(Expansion.MoP)]
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
        public int Field24 { get; set; }
        public int Field25 { get; set; }
        public int Field26 { get; set; }
        public int Field27 { get; set; }
        public int Field28 { get; set; }
        public int Field29 { get; set; }
        public int Field30 { get; set; }
        public int Field31 { get; set; }
        public int Field32 { get; set; }
        public int Field33 { get; set; }
        public int Field34 { get; set; }
        public int Field35 { get; set; }
    }

    [DBTable(Expansion.MoP)]
    public class ChrSpecialization
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
        public string Field0A { get; set; }
        public string Field0B { get; set; }
        public string Field0C { get; set; }
    }

    [DBTable(Expansion.MoP)]
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

    [DBTable(Expansion.MoP)]
    public class CinematicSequences
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
    }

    [DBTable(Expansion.MoP)]
    public class CombatCondition
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
    }

    [DBTable(Expansion.MoP)]
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
        public float Field9 { get; set; }
        public float Field10 { get; set; }
        public float Field11 { get; set; }
        public float Field12 { get; set; }
        public string Field13 { get; set; }
        public string Field14 { get; set; }
        public int Field15 { get; set; }
        public int Field16 { get; set; }
        public int NewField { get; set; }
    }

    [DBTable(Expansion.MoP)]
    public class Creaturecache
    {
        [DBKey]
        public int Entry { get; set; }
        public int Unk1 { get; set; }
        public int Unk2 { get; set; }
        public int Unk3 { get; set; }
        public byte Unk5 { get; set; }
        public byte Unk6 { get; set; }
        public byte Unk7 { get; set; }
        public string Name { get; set; }
        public int Unk8 { get; set; }
        public int Unk9 { get; set; }
        public int Unk10 { get; set; }
        public int Unk11 { get; set; }
        public int Unk12 { get; set; }
        public int Unk13 { get; set; }
        public int Unk14 { get; set; }
        public int Unk15 { get; set; }
        public int Unk16 { get; set; }
        public int Unk17 { get; set; }
        public int Unk18 { get; set; }
        public float Unk19 { get; set; }
        public float Unk20 { get; set; }
        public int Unk21 { get; set; }
        public int Unk22 { get; set; }
        public byte Unk23 { get; set; }
        public string Icon { get; set; }
    }

    [DBTable(Expansion.MoP)]
    public class CreatureDifficulty
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
    }

    [DBTable(Expansion.MoP)]
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
        public int NewField17 { get; set; }
        public int NewField18 { get; set; }
        public int NewField19 { get; set; }
        public int NewField20 { get; set; }
    }

    [DBTable(Expansion.MoP)]
    public class CreatureDisplayInfoExtra
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
    }

    [DBTable(Expansion.MoP)]
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

    [DBTable(Expansion.MoP)]
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
        public int Field19 { get; set; }
        public int Field1A { get; set; }
        public int Field1B { get; set; }
        public int Field1C { get; set; }
    }

    [DBTable(Expansion.MoP)]
    public class CreatureModelData
    {
        [DBKey]
        public int ID { get; set; }
        public int Flags { get; set; }
        public int FileDataID { get; set; }
        public int SizeClass { get; set; }
        public float ModelScale { get; set; }
        public int BloodID { get; set; }
        public int FootprintTextureID { get; set; }
        public float FootprintTextureLength { get; set; }
        public float FootprintTextureWidth { get; set; }
        public float FootprintParticleScale { get; set; }
        public int FoleyMaterialID { get; set; }
        public int FootstepShakeSize { get; set; }
        public int DeathThudShakeSize { get; set; }
        public int SoundID { get; set; }
        public float CollisionWidth { get; set; }
        public float CollisionHeight { get; set; }
        public float MountHeight { get; set; }
        public float GeoBoxMin1 { get; set; }
        public float GeoBoxMin2 { get; set; }
        public float GeoBoxMin3 { get; set; }
        public float GeoBoxMax1 { get; set; }
        public float GeoBoxMax2 { get; set; }
        public float GeoBoxMax3 { get; set; }
        public float WorldEffectScale { get; set; }
        public float AttachedEffectScale { get; set; }
        public float MissileCollisionRadius { get; set; }
        public float MissileCollisionPush { get; set; }
        public float MissileCollisionRaise { get; set; }
        public float OverrideLootEffectScale { get; set; }
        public float OverrideNameScale { get; set; }
        public float OverrideSelectionRadius { get; set; }
        public float TamedPetBaseScale { get; set; }
        public int CreatureGeosetDataID { get; set; }
        public float HoverHeight { get; set; }
    }

    [DBTable(Expansion.MoP)]
    public class CreatureMovementInfo
    {
        [DBKey]
        public int Id { get; set; }
        public int Field00 { get; set; }
    }

    [DBTable(Expansion.MoP)]
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

    [DBTable(Expansion.MoP)]
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

    [DBTable(Expansion.MoP)]
    public class CreatureType
    {
        [DBKey]
        public int Id { get; set; }
        public string Field00 { get; set; }
        public string Field01 { get; set; }
    }

    [DBTable(Expansion.MoP)]
    public class Criteria
    {
        [DBKey]
        public int Id { get; set; }
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
    }

    [DBTable(Expansion.MoP)]
    public class CriteriaTree
    {
        [DBKey]
        public int Id { get; set; }
        public int Criteria { get; set; }
        public int Min_criteria { get; set; }
        public int Field3 { get; set; }
        public int Flags { get; set; }
        public int Parent { get; set; }
        public int Flags2 { get; set; }
        public string Description { get; set; }
    }

    [DBTable(Expansion.MoP)]
    public class CriteriaTreeXEffect
    {
        [DBKey]
        public int Field0 { get; set; }
        public int Field1 { get; set; }
        public int Field2 { get; set; }
    }

    [DBTable(Expansion.MoP)]
    public class CurrencyCategory
    {
        [DBKey]
        public int Id { get; set; }
        public int Field00 { get; set; }
        public string Field01 { get; set; }
    }

    [DBTable(Expansion.MoP)]
    public class CurrencyTypes
    {
        [DBKey]
        public int Id { get; set; }
        public int Field00 { get; set; }
        public string Field01 { get; set; }
        public string Field02 { get; set; }
        public string Field03 { get; set; }
        public int Field04 { get; set; }
        public int Field05 { get; set; }
        public int Field06 { get; set; }
        public int Field07 { get; set; }
        public int Field08 { get; set; }
        public int Field09 { get; set; }
        public string Field0A { get; set; }
    }

    [DBTable(Expansion.MoP)]
    public class DeathThudLookups
    {
        [DBKey]
        public int Id { get; set; }
        public int Field00 { get; set; }
        public int Field01 { get; set; }
        public int Field02 { get; set; }
        public int Field03 { get; set; }
    }

    [DBTable(Expansion.MoP)]
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

    [DBTable(Expansion.MoP)]
    public class Difficulty
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
        public int NewField2 { get; set; }
        public int NewField3 { get; set; }
        public int NewField4 { get; set; }
        public string NewField1 { get; set; }
    }

    [DBTable(Expansion.MoP)]
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
        public int NewField { get; set; }
    }

    [DBTable(Expansion.MoP)]
    public class DungeonMap
    {
        [DBKey]
        public int ID { get; set; }
        public int MapID { get; set; }
        public int FloorIndex { get; set; }
        public float MinX { get; set; }
        public float MinY { get; set; }
        public float MaxX { get; set; }
        public float MaxY { get; set; }
        public int ParentWorldMapID { get; set; }
        public int Flags { get; set; }
    }

    [DBTable(Expansion.MoP)]
    public class DungeonMapChunk
    {
        [DBKey]
        public int Field0 { get; set; }
        public int Field1 { get; set; }
        public int Field2 { get; set; }
        public int Field3 { get; set; }
        public float Field4 { get; set; }
        public int Field5 { get; set; }
    }

    [DBTable(Expansion.MoP)]
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

    [DBTable(Expansion.MoP)]
    public class DurabilityQuality
    {
        [DBKey]
        public int Id { get; set; }
        public int Field00 { get; set; }
    }

    [DBTable(Expansion.MoP)]
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

    [DBTable(Expansion.MoP)]
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

    [DBTable(Expansion.MoP)]
    public class EmotesTextData
    {
        [DBKey]
        public int Id { get; set; }
        public string Field00 { get; set; }
    }

    [DBTable(Expansion.MoP)]
    public class EmotesTextSound
    {
        [DBKey]
        public int Id { get; set; }
        public int Field00 { get; set; }
        public int Field01 { get; set; }
        public int Field02 { get; set; }
        public int Field03 { get; set; }
    }

    [DBTable(Expansion.MoP)]
    public class EnvironmentalDamage
    {
        [DBKey]
        public int Id { get; set; }
        public int Field00 { get; set; }
        public int Field01 { get; set; }
    }

    [DBTable(Expansion.MoP)]
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
        public string Field06 { get; set; }
    }

    [DBTable(WDBXLib.Common.Constants.Expansion.MoP)]
    public class Faction
    {
        [DBKey]
        public int ID { get; set; }
        public int ReputationIndex { get; set; }
        public uint ReputationRaceMask_1 { get; set; }
        public uint ReputationRaceMask_2 { get; set; }
        public uint ReputationRaceMask_3 { get; set; }
        public uint ReputationRaceMask_4 { get; set; }
        public uint ReputationClassMask_1 { get; set; }
        public uint ReputationClassMask_2 { get; set; }
        public uint ReputationClassMask_3 { get; set; }
        public uint ReputationClassMask_4 { get; set; }
        public int ReputationBase_1 { get; set; }
        public int ReputationBase_2 { get; set; }
        public int ReputationBase_3 { get; set; }
        public int ReputationBase_4 { get; set; }
        public uint ReputationFlags_1 { get; set; }
        public uint ReputationFlags_2 { get; set; }
        public uint ReputationFlags_3 { get; set; }
        public uint ReputationFlags_4 { get; set; }
        public uint ParentFactionID { get; set; }
        public float SpilloverRate1 { get; set; }
        public float SpilloverRate2 { get; set; }
        public uint SpilloverMaxRank { get; set; }
        public uint SpilloverRank_unk { get; set; }
        public string Name_lang_1 { get; set; }
        public string Description_lang_1 { get; set; }
        public int Expansion { get; set; }
    }

    [DBTable(Expansion.MoP)]
    public class FactionGroup
    {
        [DBKey]
        public int Field0 { get; set; }
        public int Field1 { get; set; }
        public string Field2 { get; set; }
        public string Field3 { get; set; }
    }

    [DBTable(Expansion.MoP)]
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

    [DBTable(Expansion.MoP)]
    public class FileData
    {
        [DBKey]
        public int Field0 { get; set; }
        public string Field1 { get; set; }
        public string Field2 { get; set; }
    }

    [DBTable(Expansion.MoP)]
    public class FootprintTextures
    {
        [DBKey]
        public int Id { get; set; }
        public string Field00 { get; set; }
    }

    [DBTable(Expansion.MoP)]
    public class FootstepTerrainLookup
    {
        [DBKey]
        public int Id { get; set; }
        public int Field00 { get; set; }
        public int Field01 { get; set; }
        public int Field02 { get; set; }
        public int Field03 { get; set; }
    }

    [DBTable(Expansion.MoP)]
    public class FriendshipRepReaction
    {
        [DBKey]
        public int Id { get; set; }
        public int Field00 { get; set; }
        public int Field01 { get; set; }
        public string Field02 { get; set; }
    }

    [DBTable(Expansion.MoP)]
    public class FriendshipReputation
    {
        [DBKey]
        public int Id { get; set; }
        public int Field00 { get; set; }
        public int Field01 { get; set; }
        public string Field02 { get; set; }
    }

    [DBTable(Expansion.MoP)]
    public class GameObjectArtKit
    {
        [DBKey]
        public int Field0 { get; set; }
        public int Field1 { get; set; }
        public int Field2 { get; set; }
        public int Field3 { get; set; }
        public string Field4 { get; set; }
        public string Field5 { get; set; }
        public string Field6 { get; set; }
        public string Field7 { get; set; }
    }

    [DBTable(Expansion.MoP)]
    public class GameObjectDiffAnimMap
    {
        [DBKey]
        public int Id { get; set; }
        public int Field00 { get; set; }
        public int Field01 { get; set; }
        public int Field02 { get; set; }
        public int Field03 { get; set; }
    }

    [DBTable(Expansion.MoP)]
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

    [DBTable(Expansion.MoP)]
    public class GameObjects
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
        public int Field16 { get; set; }
        public int NewField17 { get; set; }
        public int NewField18 { get; set; }
        public int NewField19 { get; set; }
        public int NewField20 { get; set; }
        public int NewField21 { get; set; }
        public int NewField22 { get; set; }
        public string NewField23 { get; set; }
    }

    [DBTable(Expansion.MoP)]
    public class GameTables
    {
        [DBKey]
        public int Id { get; set; }
        public string Field00 { get; set; }
        public int Field01 { get; set; }
        public int Field02 { get; set; }
    }

    [DBTable(Expansion.MoP)]
    public class GameTips
    {
        [DBKey]
        public int Id { get; set; }
        public string Field00 { get; set; }
        public int Field01 { get; set; }
        public int Field02 { get; set; }
    }

    [DBTable(Expansion.MoP)]
    public class GarrSpecialization
    {
        [DBKey]
        public int Field0 { get; set; }
        public int Field1 { get; set; }
        public int Field2 { get; set; }
        public int Field3 { get; set; }
        public int Field4 { get; set; }
        public float Field5 { get; set; }
        public int Field6 { get; set; }
        public string Field7 { get; set; }
        public string Field8 { get; set; }
    }

    [DBTable(Expansion.MoP)]
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

    [DBTable(Expansion.MoP)]
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

    [DBTable(Expansion.MoP)]
    public class GlyphProperties
    {
        [DBKey]
        public int Id { get; set; }
        public int Field00 { get; set; }
        public int Field01 { get; set; }
        public int Field02 { get; set; }
    }

    [DBTable(Expansion.MoP)]
    public class GlyphSlot
    {
        [DBKey]
        public int Id { get; set; }
        public int Field00 { get; set; }
        public int Field01 { get; set; }
    }

    [DBTable(Expansion.MoP)]
    public class GMSurveyAnswers
    {
        [DBKey]
        public int Id { get; set; }
        public int Field00 { get; set; }
        public int Field01 { get; set; }
        public string Field02 { get; set; }
    }

    [DBTable(Expansion.MoP)]
    public class GMSurveyCurrentSurvey
    {
        [DBKey]
        public int Id { get; set; }
        public int Field00 { get; set; }
    }

    [DBTable(Expansion.MoP)]
    public class GMSurveyQuestions
    {
        [DBKey]
        public int Id { get; set; }
        public string Field00 { get; set; }
    }

    [DBTable(Expansion.MoP)]
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

    [DBTable(Expansion.MoP)]
    public class GMTicketCategory
    {
        [DBKey]
        public int Id { get; set; }
        public string Field00 { get; set; }
    }

    [DBTable(Expansion.MoP)]
    public class GroundEffectDoodad
    {
        [DBKey]
        public int Id { get; set; }
        public string Field00 { get; set; }
        public int Field01 { get; set; }
        public int Field02 { get; set; }
    }

    [DBTable(Expansion.MoP)]
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

    [DBTable(Expansion.MoP)]
    public class GroupFinderActivity
    {
        [DBKey]
        public int Field0 { get; set; }
        public int Field1 { get; set; }
        public int Field2 { get; set; }
        public int Field3 { get; set; }
        public int Field4 { get; set; }
        public int Field5 { get; set; }
        public int Field6 { get; set; }
        public string Field7 { get; set; }
        public string Field8 { get; set; }
    }

    [DBTable(Expansion.MoP)]
    public class GroupFinderActivityGrp
    {
        [DBKey]
        public int Field0 { get; set; }
        public string Field1 { get; set; }
    }

    [DBTable(Expansion.MoP)]
    public class GroupFinderCategory
    {
        [DBKey]
        public int Field0 { get; set; }
        public string Field1 { get; set; }
    }

    [DBTable(Expansion.MoP)]
    public class GtBarberShopCostBase
    {
        [DBKey]
        public int Id { get; set; }
        public int Field00 { get; set; }
    }

    [DBTable(Expansion.MoP)]
    public class GtBattlePetTypeDamageMod
    {
        [DBKey]
        public int Id { get; set; }
        public float Field00 { get; set; }
    }

    [DBTable(Expansion.MoP)]
    public class GtBattlePetXP
    {
        [DBKey]
        public int Id { get; set; }
        public float Field00 { get; set; }
    }

    [DBTable(Expansion.MoP)]
    public class GtChanceToMeleeCrit
    {
        [DBKey]
        public int Id { get; set; }
        public float Field00 { get; set; }
    }

    [DBTable(Expansion.MoP)]
    public class GtChanceToMeleeCritBase
    {
        [DBKey]
        public int Id { get; set; }
        public int Field00 { get; set; }
    }

    [DBTable(Expansion.MoP)]
    public class GtChanceToSpellCrit
    {
        [DBKey]
        public int Id { get; set; }
        public float Field00 { get; set; }
    }

    [DBTable(Expansion.MoP)]
    public class GtChanceToSpellCritBase
    {
        [DBKey]
        public int Id { get; set; }
        public int Field00 { get; set; }
    }

    [DBTable(Expansion.MoP)]
    public class GtCombatRatings
    {
        [DBKey]
        public int Id { get; set; }
        public int Field00 { get; set; }
    }

    [DBTable(Expansion.MoP)]
    public class GtItemSocketCostPerLevel
    {
        [DBKey]
        public int Id { get; set; }
        public int Field00 { get; set; }
    }

    [DBTable(Expansion.MoP)]
    public class GtNPCManaCostScaler
    {
        [DBKey]
        public int Id { get; set; }
        public int Field00 { get; set; }
    }

    [DBTable(Expansion.MoP)]
    public class GtOCTBaseHPByClass
    {
        [DBKey]
        public int Id { get; set; }
        public int Field00 { get; set; }
    }

    [DBTable(Expansion.MoP)]
    public class GtOCTBaseMPByClass
    {
        [DBKey]
        public int Id { get; set; }
        public int Field00 { get; set; }
    }

    [DBTable(Expansion.MoP)]
    public class GtOCTClassCombatRatingScalar
    {
        [DBKey]
        public int Id { get; set; }
        public int Field00 { get; set; }
    }

    [DBTable(Expansion.MoP)]
    public class GtOCTHpPerStamina
    {
        [DBKey]
        public int Id { get; set; }
        public float Field00 { get; set; }
    }

    [DBTable(Expansion.MoP)]
    public class GtRegenMPPerSpt
    {
        [DBKey]
        public int Id { get; set; }
        public int Field00 { get; set; }
    }

    [DBTable(Expansion.MoP)]
    public class GtResilienceDR
    {
        [DBKey]
        public int Id { get; set; }
        public float Field00 { get; set; }
    }

    [DBTable(Expansion.MoP)]
    public class GtSpellScaling
    {
        [DBKey]
        public int Id { get; set; }
        public int Field00 { get; set; }
    }

    [DBTable(Expansion.MoP)]
    public class GuildPerkSpells
    {
        [DBKey]
        public int Id { get; set; }
        public int Field00 { get; set; }
        public int Field01 { get; set; }
    }

    [DBTable(Expansion.MoP)]
    public class HelmetAnimScaling
    {
        [DBKey]
        public int Id { get; set; }
        public int Field00 { get; set; }
        public int Field01 { get; set; }
        public int Field02 { get; set; }
    }

    [DBTable(Expansion.MoP)]
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

    [DBTable(Expansion.MoP)]
    public class HolidayDescriptions
    {
        [DBKey]
        public int Id { get; set; }
        public string Field00 { get; set; }
    }

    [DBTable(Expansion.MoP)]
    public class HolidayNames
    {
        [DBKey]
        public int Id { get; set; }
        public string Field00 { get; set; }
    }

    [DBTable(Expansion.MoP)]
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

    [DBTable(Expansion.MoP)]
    public class ImportPriceArmor
    {
        [DBKey]
        public int Id { get; set; }
        public int Field00 { get; set; }
        public int Field01 { get; set; }
        public int Field02 { get; set; }
        public int Field03 { get; set; }
    }

    [DBTable(Expansion.MoP)]
    public class ImportPriceQuality
    {
        [DBKey]
        public int Id { get; set; }
        public int Field00 { get; set; }
    }

    [DBTable(Expansion.MoP)]
    public class ImportPriceShield
    {
        [DBKey]
        public int Id { get; set; }
        public float Field00 { get; set; }
    }

    [DBTable(Expansion.MoP)]
    public class ImportPriceWeapon
    {
        [DBKey]
        public int Id { get; set; }
        public float Field00 { get; set; }
    }

    [DBTable(Expansion.MoP)]
    public class Item
    {
        [DBKey]
        public int Id { get; set; }
        public uint Class { get; set; }
        public uint Subclass { get; set; }
        public int Sound_override_subclassid { get; set; }
        public int Material { get; set; }
        public uint Displayid { get; set; }
        public uint Inventorytype { get; set; }
        public uint SheatheType { get; set; }
        public int NewField8 { get; set; }
        public int Field9 { get; set; }
    }

    [DBTable(Expansion.MoP)]
    public class ItemArmorQuality
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

    [DBTable(Expansion.MoP)]
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

    [DBTable(Expansion.MoP)]
    public class ItemArmorTotal
    {
        [DBKey]
        public int Id { get; set; }
        public int Field00 { get; set; }
        public float Field01 { get; set; }
        public float Field02 { get; set; }
        public float Field03 { get; set; }
        public float Field04 { get; set; }
    }

    [DBTable(Expansion.MoP)]
    public class ItemBagFamily
    {
        [DBKey]
        public int Id { get; set; }
        public string Field00 { get; set; }
    }

    [DBTable(Expansion.MoP)]
    public class ItemBonus
    {
        [DBKey]
        public int Field0 { get; set; }
        public int Field1 { get; set; }
        public int Field2 { get; set; }
        public int Field3 { get; set; }
        public int Field4 { get; set; }
        public int Field5 { get; set; }
    }

    [DBTable(Expansion.MoP)]
    public class ItemClass
    {
        [DBKey]
        public int Field0 { get; set; }
        public int Field1 { get; set; }
        public float Field2 { get; set; }
        public string Field3 { get; set; }
    }

    [DBTable(Expansion.MoP)]
    public class ItemCurrencyCost
    {
        [DBKey]
        public int Id { get; set; }
        public int ItemId { get; set; }
    }

    [DBTable(Expansion.MoP)]
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

    [DBTable(Expansion.MoP)]
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

    [DBTable(Expansion.MoP)]
    public class ItemDamageOneHandCaster
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

    [DBTable(Expansion.MoP)]
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

    [DBTable(Expansion.MoP)]
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

    [DBTable(Expansion.MoP)]
    public class ItemDamageTwoHand
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

    [DBTable(Expansion.MoP)]
    public class ItemDamageTwoHandCaster
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

    [DBTable(Expansion.MoP)]
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

    [DBTable(Expansion.MoP)]
    public class ItemDisenchantLoot
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

    [DBTable(Expansion.MoP)]
    public class ItemDisplayInfo
    {
        [DBKey]
        public int Field0 { get; set; }
        public string Field1 { get; set; }
        public string Field2 { get; set; }
        public string Field3 { get; set; }
        public string Field4 { get; set; }
        public int Field5 { get; set; }
        public int Field6 { get; set; }
        public int Field7 { get; set; }
        public int Field8 { get; set; }
        public int Field9 { get; set; }
        public int Field10 { get; set; }
        public int Field11 { get; set; }
        public string Field12 { get; set; }
        public string Field13 { get; set; }
        public string Field14 { get; set; }
        public string Field15 { get; set; }
        public string Field16 { get; set; }
        public string Field17 { get; set; }
        public string Field18 { get; set; }
        public string Field19 { get; set; }
        public string Field20 { get; set; }
        public int Field21 { get; set; }
        public int Field22 { get; set; }
    }

    [DBTable(Expansion.MoP)]
    public class ItemEffect
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
    }

    [DBTable(Expansion.MoP)]
    public class ItemGroupSounds
    {
        [DBKey]
        public int Id { get; set; }
        public int Field00 { get; set; }
        public int Field01 { get; set; }
        public int Field02 { get; set; }
        public int Field03 { get; set; }
    }

    [DBTable(Expansion.MoP)]
    public class ItemLimitCategory
    {
        [DBKey]
        public int Id { get; set; }
        public string Field00 { get; set; }
        public int Field01 { get; set; }
        public string Field02 { get; set; }
    }

    [DBTable(Expansion.MoP)]
    public class ItemNameDescription
    {
        [DBKey]
        public int Id { get; set; }
        public string Field00 { get; set; }
        public int Field01 { get; set; }
    }

    [DBTable(Expansion.MoP)]
    public class ItemPetFood
    {
        [DBKey]
        public int Id { get; set; }
        public string Field00 { get; set; }
    }

    [DBTable(Expansion.MoP)]
    public class ItemPriceBase
    {
        [DBKey]
        public int Id { get; set; }
        public int Field00 { get; set; }
        public int Field01 { get; set; }
        public int Field02 { get; set; }
    }

    [DBTable(Expansion.MoP)]
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

    [DBTable(Expansion.MoP)]
    public class ItemRandomProperties
    {
        [DBKey]
        public int ID { get; set; }
        public string Name { get; set; }
        public int Enchantment1 { get; set; }
        public int Enchantment2 { get; set; }
        public int Enchantment3 { get; set; }
        public int Enchantment4 { get; set; }
        public int Enchantment5 { get; set; }
        public string Name_lang1 { get; set; }
    }

    [DBTable(Expansion.MoP)]
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

    [DBTable(Expansion.MoP)]
    public class ItemReforge
    {
        [DBKey]
        public int Id { get; set; }
        public int Field00 { get; set; }
        public float Field01 { get; set; }
        public int Field02 { get; set; }
        public float Field03 { get; set; }
    }

    [DBTable(Expansion.MoP)]
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

    [DBTable(Expansion.MoP)]
    public class ItemSpec
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

    [DBTable(Expansion.MoP)]
    public class ItemSpecOverride
    {
        [DBKey]
        public int Id { get; set; }
        public int Field00 { get; set; }
        public int Field01 { get; set; }
    }

    [DBTable(Expansion.MoP)]
    public class ItemSubClass
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
        public string Field0A { get; set; }
        public string Field0B { get; set; }
    }

    [DBTable(Expansion.MoP)]
    public class ItemSubClassMask
    {
        [DBKey]
        public int Id { get; set; }
        public int Field00 { get; set; }
        public int Field01 { get; set; }
        public string Field02 { get; set; }
    }

    [DBTable(Expansion.MoP)]
    public class ItemUpgradePath
    {
        [DBKey]
        public int Field0 { get; set; }
    }

    [DBTable(Expansion.MoP)]
    public class ItemVisualEffects
    {
        [DBKey]
        public int Field0 { get; set; }
        public string Field1 { get; set; }
    }

    [DBTable(Expansion.MoP)]
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
        public int NewField { get; set; }
    }

    [DBTable(Expansion.MoP)]
    public class JournalEncounterXDifficulty
    {
        [DBKey]
        public int Field0 { get; set; }
        public int Field1 { get; set; }
        public int Field2 { get; set; }
    }

    [DBTable(Expansion.MoP)]
    public class JournalInstance
    {
        [DBKey]
        public int Id { get; set; }
        public int MapId { get; set; }
        public int AreaId { get; set; }
        public int Unk1 { get; set; }
        public int Unk2 { get; set; }
        public int NewField { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }

    [DBTable(Expansion.MoP)]
    public class JournalTier
    {
        [DBKey]
        public int Field0 { get; set; }
        public int Field1 { get; set; }
        public string Field2 { get; set; }
    }

    [DBTable(Expansion.MoP)]
    public class JournalTierXInstance
    {
        [DBKey]
        public int Field0 { get; set; }
        public int Tier { get; set; }
        public int Instance { get; set; }
    }

    [DBTable(Expansion.MoP)]
    public class KeyChain
    {
        [DBKey]
        public int Id { get; set; }
        public byte Byte01 { get; set; }
        public byte Byte02 { get; set; }
        public byte Byte03 { get; set; }
        public byte Byte04 { get; set; }
        public byte Byte05 { get; set; }
        public byte Byte06 { get; set; }
        public byte Byte07 { get; set; }
        public byte Byte08 { get; set; }
        public byte Byte09 { get; set; }
        public byte Byte10 { get; set; }
        public byte Byte11 { get; set; }
        public byte Byte12 { get; set; }
        public byte Byte13 { get; set; }
        public byte Byte14 { get; set; }
        public byte Byte15 { get; set; }
        public byte Byte16 { get; set; }
        public byte Byte17 { get; set; }
        public byte Byte18 { get; set; }
        public byte Byte19 { get; set; }
        public byte Byte20 { get; set; }
        public byte Byte21 { get; set; }
        public byte Byte22 { get; set; }
        public byte Byte23 { get; set; }
        public byte Byte24 { get; set; }
        public byte Byte25 { get; set; }
        public byte Byte26 { get; set; }
        public byte Byte27 { get; set; }
        public byte Byte28 { get; set; }
        public byte Byte29 { get; set; }
        public byte Byte30 { get; set; }
        public byte Byte31 { get; set; }
        public byte Byte32 { get; set; }
    }

    [DBTable(Expansion.MoP)]
    public class LfgDungeonGroup
    {
        [DBKey]
        public int Id { get; set; }
        public string Name { get; set; }
        public int Order_index { get; set; }
        public int Parent_group_id { get; set; }
        public int Typeid { get; set; }
    }

    [DBTable(Expansion.MoP)]
    public class LfgDungeons
    {
        [DBKey]
        public int Id { get; set; }
        public string Name_lang { get; set; }
        public int MinLevel { get; set; }
        public int MaxLevel { get; set; }
        public int Target_level { get; set; }
        public int Target_level_min { get; set; }
        public int Target_level_max { get; set; }
        public int MapID { get; set; }
        public int Difficulty { get; set; }
        public int Flags { get; set; }
        public int TypeID { get; set; }
        public int Faction { get; set; }
        public string TextureFilename { get; set; }
        public int ExpansionLevel { get; set; }
        public int Order_index { get; set; }
        public int Group_id { get; set; }
        public string Description_lang { get; set; }
        public int Field17 { get; set; }
        public int Field18 { get; set; }
        public int Field19 { get; set; }
        public int Field20 { get; set; }
        public int Field21 { get; set; }
        public int Field22 { get; set; }
        public int NewField1 { get; set; }
        public int NewField2 { get; set; }
        public int NewField3 { get; set; }
        public int NewField4 { get; set; }
        public int NewField5 { get; set; }
        public int NewField6 { get; set; }
    }

    [DBTable(Expansion.MoP)]
    public class LFGDungeonsGroupingmap
    {
        [DBKey]
        public int Field0 { get; set; }
        public int Field1 { get; set; }
        public int Field2 { get; set; }
        public int Field3 { get; set; }
    }

    [DBTable(Expansion.MoP)]
    public class LightSkybox
    {
        [DBKey]
        public int Field0 { get; set; }
        public string Field1 { get; set; }
        public int Field2 { get; set; }
    }

    [DBTable(Expansion.MoP)]
    public class LiquidType
    {
        [DBKey]
        public int Field0 { get; set; }
        public string Field1 { get; set; }
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
        public int Field25 { get; set; }
        public int Field26 { get; set; }
        public int Field27 { get; set; }
        public int Field28 { get; set; }
        public int Field29 { get; set; }
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
        public int Field40 { get; set; }
        public int Field41 { get; set; }
        public int Field42 { get; set; }
        public int Field43 { get; set; }
        public int Field44 { get; set; }
    }

    [DBTable(Expansion.MoP)]
    public class LoadingScreens
    {
        [DBKey]
        public int Field0 { get; set; }
        public string Field1 { get; set; }
        public string Field2 { get; set; }
        public int Field3 { get; set; }
    }

    [DBTable(Expansion.MoP)]
    public class ManifestinterfaceActionIcon
    {
        [DBKey]
        public int Field0 { get; set; }
    }

    [DBTable(Expansion.MoP)]
    public class ManifestinterfaceData
    {
        [DBKey]
        public int Field0 { get; set; }
        public string Field1 { get; set; }
        public string Field2 { get; set; }
    }

    [DBTable(Expansion.MoP)]
    public class ManifestinterfaceItemIcon
    {
        [DBKey]
        public int Field0 { get; set; }
    }

    [DBTable(Expansion.MoP)]
    public class ManifestinterfaceTOCData
    {
        [DBKey]
        public int Field0 { get; set; }
        public string Field1 { get; set; }
    }

    [DBTable(Expansion.MoP)]
    public class Map
    {
        [DBKey]
        public int ID { get; set; }
        public string Directory { get; set; }
        public int InstanceType { get; set; }
        public int Flags { get; set; }
        public int MapType { get; set; }
        public string MapName_lang { get; set; }
        public int AreaTableID { get; set; }
        public string MapDescription0_lang { get; set; }
        public string MapDescription1_lang { get; set; }
        public int LoadingScreenID { get; set; }
        public float MinimapIconScale { get; set; }
        public int CorpseMapID { get; set; }
        public float CorpseX { get; set; }
        public float CorpseY { get; set; }
        public int TimeOfDayOverride { get; set; }
        public int ExpansionID { get; set; }
        public int RaidOffset { get; set; }
        public int MaxPlayers { get; set; }
        public int ParentMapID { get; set; }
        public int CosmeticParentMapID { get; set; }
        public int TimeOffset { get; set; }
    }

    [DBTable(Expansion.MoP)]
    public class MapChallengeMode
    {
        [DBKey]
        public int Id { get; set; }
        public int MapId { get; set; }
        public int Field2 { get; set; }
        public int Field3 { get; set; }
        public int Field4 { get; set; }
        public int BronzeTime { get; set; }
        public int SilverTime { get; set; }
        public int GoldTime { get; set; }
        public int Field8 { get; set; }
        public int Field9 { get; set; }
    }

    [DBTable(Expansion.MoP)]
    public class MapDifficulty
    {
        [DBKey]
        public int Id { get; set; }
        public int MapId { get; set; }
        public int Difficulty { get; set; }
        public string Requirement { get; set; }
        public int ResetTime { get; set; }
        public int MaxPlayers { get; set; }
        public int NewField { get; set; }
    }

    [DBTable(Expansion.MoP)]
    public class ModelNameToManifest
    {
        [DBKey]
        public int Field0 { get; set; }
        public int Field1 { get; set; }
        public int Field2 { get; set; }
    }

    [DBTable(Expansion.MoP)]
    public class Mount
    {
        [DBKey]
        public int Field0 { get; set; }
        public int Field1 { get; set; }
        public int Field2 { get; set; }
        public int Field3 { get; set; }
        public string Field4 { get; set; }
        public string Field5 { get; set; }
        public string Field6 { get; set; }
        public int Field7 { get; set; }
        public int Field8 { get; set; }
    }

    [DBTable(Expansion.MoP)]
    public class Movie
    {
        [DBKey]
        public int Id { get; set; }
        public int Field1 { get; set; }
        public int KeyChainId { get; set; }
        public int Field3 { get; set; }
        public int Field4 { get; set; }
    }

    [DBTable(Expansion.MoP)]
    public class MovieFileData
    {
        [DBKey]
        public int Field0 { get; set; }
        public int Field1 { get; set; }
    }

    [DBTable(Expansion.MoP)]
    public class MovieOverlays
    {
        [DBKey]
        public int Field0 { get; set; }
        public int Field1 { get; set; }
        public int Field2 { get; set; }
        public int Field3 { get; set; }
        public int Field4 { get; set; }
    }

    [DBTable(Expansion.MoP)]
    public class ObjectEffect
    {
        [DBKey]
        public int Field0 { get; set; }
        public string Field1 { get; set; }
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
    }

    [DBTable(Expansion.MoP)]
    public class PaperDollItemFrame
    {
        [DBKey]
        public int Field0 { get; set; }
        public string Field1 { get; set; }
        public string Field2 { get; set; }
        public int Field3 { get; set; }
    }

    [DBTable(Expansion.MoP)]
    public class Questcache
    {
        [DBKey]
        public int Entry { get; set; }
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
        public float NewField17 { get; set; }
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
    }

    [DBTable(Expansion.MoP)]
    public class QuestLine
    {
        [DBKey]
        public int Field0 { get; set; }
        public string Field1 { get; set; }
    }

    [DBTable(Expansion.MoP)]
    public class QuestPOIBlob
    {
        [DBKey]
        public int Field0 { get; set; }
        public int Field1 { get; set; }
        public int Field2 { get; set; }
        public int Field3 { get; set; }
    }

    [DBTable(Expansion.MoP)]
    public class QuestPOIPoint
    {
        [DBKey]
        public int Id { get; set; }
        public int Pos_x { get; set; }
        public int Pos_y { get; set; }
        public int Poi_id { get; set; }
    }

    [DBTable(Expansion.MoP)]
    public class ResearchBranch
    {
        [DBKey]
        public int Field0 { get; set; }
        public string Field1 { get; set; }
        public int Field2 { get; set; }
        public int Field3 { get; set; }
        public string Field4 { get; set; }
        public int Field5 { get; set; }
    }

    [DBTable(Expansion.MoP)]
    public class ResearchField
    {
        [DBKey]
        public int Field0 { get; set; }
        public string Field1 { get; set; }
        public int Field2 { get; set; }
    }

    [DBTable(Expansion.MoP)]
    public class ResearchProject
    {
        [DBKey]
        public int Field0 { get; set; }
        public string Field1 { get; set; }
        public string Field2 { get; set; }
        public int Field3 { get; set; }
        public int Field4 { get; set; }
        public int Field5 { get; set; }
        public int Field6 { get; set; }
        public string Field7 { get; set; }
        public int Field8 { get; set; }
    }

    [DBTable(Expansion.MoP)]
    public class ResearchSite
    {
        [DBKey]
        public int Id { get; set; }
        public int MapId { get; set; }
        public int Poi_id { get; set; }
        public string Name { get; set; }
        public int TextureIndex { get; set; }
    }

    [DBTable(Expansion.MoP)]
    public class ScalingStatDistribution
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
    }

    [DBTable(Expansion.MoP)]
    public class ScalingStatValues
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
        public int Field25 { get; set; }
        public int Field26 { get; set; }
        public int Field27 { get; set; }
        public int Field28 { get; set; }
        public int Field29 { get; set; }
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
        public int Field40 { get; set; }
        public int Field41 { get; set; }
        public int Field42 { get; set; }
        public int Field43 { get; set; }
        public int Field44 { get; set; }
        public int Field45 { get; set; }
        public int Field46 { get; set; }
        public int Field47 { get; set; }
        public int Field48 { get; set; }
    }

    [DBTable(Expansion.MoP)]
    public class Scenario
    {
        [DBKey]
        public int Id { get; set; }
        public string Name_lang { get; set; }
        public int Flags { get; set; }
    }

    [DBTable(Expansion.MoP)]
    public class ScenarioEventEntry
    {
        [DBKey]
        public int Field0 { get; set; }
        public int Field1 { get; set; }
        public int Field2 { get; set; }
    }

    [DBTable(Expansion.MoP)]
    public class ScenarioStep
    {
        [DBKey]
        public int Id { get; set; }
        public int Criteria { get; set; }
        public int ScenarioId { get; set; }
        public int Step { get; set; }
        public string Step_description { get; set; }
        public string Step_name { get; set; }
        public int Bonus_step { get; set; }
    }

    [DBTable(Expansion.MoP)]
    public class Spell
    {
        [DBKey]
        public int ID { get; set; }
        public string Name { get; set; }
        public string NameSubtext { get; set; }
        public string Description { get; set; }
        public string AuraDescription { get; set; }
        public int RuneCostID { get; set; }
        public int SpellMissileID { get; set; }
        public int SpellDescriptionVariableID { get; set; }
        public float Unk_f1 { get; set; }
        public int SpellScalingID { get; set; }
        public int SpellAuraOptionsId { get; set; }
        public int SpellAuraRestrictionsId { get; set; }
        public int SpellCastingRequirementsId { get; set; }
        public int SpellCategoriesId { get; set; }
        public int SpellClassOptionsId { get; set; }
        public int SpellCooldownsId { get; set; }
        public int SpellEquippedItemsId { get; set; }
        public int SpellinterruptsId { get; set; }
        public int SpellLevelsId { get; set; }
        public int SpellReagentsId { get; set; }
        public int SpellShapeshiftId { get; set; }
        public int SpellTargetRestrictionsId { get; set; }
        public int SpellTotemsId { get; set; }
        public int ResearchProjectId { get; set; }
        public int SpellMiscId { get; set; }
    }

    [DBTable(Expansion.MoP)]
    public class SpellAuraOptions
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

    [DBTable(Expansion.MoP)]
    public class SpellAuraRestrictions
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
    }

    [DBTable(Expansion.MoP)]
    public class SpellCategories
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
    }

    [DBTable(Expansion.MoP)]
    public class SpellClassOptions
    {
        [DBKey]
        public int ID { get; set; }
        public uint ModalNextSpell { get; set; }
        public uint SpellClassMask_1 { get; set; }
        public uint SpellClassMask_2 { get; set; }
        public uint SpellClassMask_3 { get; set; }
        public uint SpellClassSet { get; set; }
        public int Unk { get; set; }
    }

    [DBTable(Expansion.MoP)]
    public class SpellCooldowns
    {
        [DBKey]
        public int Id { get; set; }
        public int CategoryRecoveryTime { get; set; }
        public int RecoveryTime { get; set; }
        public int StartRecoveryTime { get; set; }
        public int NewField1 { get; set; }
        public int NewField2 { get; set; }
    }

    [DBTable(Expansion.MoP)]
    public class SpellDescriptionVariables
    {
        [DBKey]
        public int Field0 { get; set; }
        public string Field1 { get; set; }
    }

    [DBTable(Expansion.MoP)]
    public class SpellEquippedItems
    {
        [DBKey]
        public int Field0 { get; set; }
        public int Field1 { get; set; }
        public int Field2 { get; set; }
        public int Field3 { get; set; }
        public int Field4 { get; set; }
        public int Field5 { get; set; }
    }

    [DBTable(Expansion.MoP)]
    public class Spellinterrupts
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

    [DBTable(Expansion.MoP)]
    public class SpellLearnSpell_internal
    {
        [DBKey]
        public int Field0 { get; set; }
        public int Field1 { get; set; }
        public int Field2 { get; set; }
        public int Field3 { get; set; }
    }

    [DBTable(Expansion.MoP)]
    public class SpellLevels
    {
        [DBKey]
        public int Field0 { get; set; }
        public int Field1 { get; set; }
        public int Field2 { get; set; }
        public int Field3 { get; set; }
        public int Field4 { get; set; }
        public int Field5 { get; set; }
    }

    [DBTable(Expansion.MoP)]
    public class SpellLevels_internal
    {
        [DBKey]
        public int Field0 { get; set; }
        public int Field1 { get; set; }
        public int Field2 { get; set; }
        public int Field3 { get; set; }
        public int Field4 { get; set; }
        public int Field5 { get; set; }
    }

    [DBTable(Expansion.MoP)]
    public class SpellMisc
    {
        [DBKey]
        public int Id { get; set; }
        public int SpellId { get; set; }
        public int Field2 { get; set; }
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
        public uint AttributesExK { get; set; }
        public uint AttributesExL { get; set; }
        public int Field16 { get; set; }
        public int Field17 { get; set; }
        public float Field18 { get; set; }
        public int Field19 { get; set; }
        public int Field20 { get; set; }
        public int Field21 { get; set; }
        public int Field22 { get; set; }
        public int Field23 { get; set; }
        public int Field24 { get; set; }
    }

    [DBTable(Expansion.MoP)]
    public class SpellMissile
    {
        [DBKey]
        public int Field0 { get; set; }
        public int Field1 { get; set; }
        public float Field2 { get; set; }
        public float Field3 { get; set; }
        public float Field4 { get; set; }
        public float Field5 { get; set; }
        public float Field6 { get; set; }
        public float Field7 { get; set; }
        public float Field8 { get; set; }
        public float Field9 { get; set; }
        public float Field10 { get; set; }
        public float Field11 { get; set; }
        public float Field12 { get; set; }
        public float Field13 { get; set; }
        public float Field14 { get; set; }
    }

    [DBTable(Expansion.MoP)]
    public class SpellPower
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
        public float Field9 { get; set; }
        public float Field10 { get; set; }
        public int Field11 { get; set; }
        public float Field12 { get; set; }
    }

    [DBTable(Expansion.MoP)]
    public class SpellReagents
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
    }

    [DBTable(Expansion.MoP)]
    public class SpellRuneCost
    {
        [DBKey]
        public int Field0 { get; set; }
        public int Field1 { get; set; }
        public int Field2 { get; set; }
        public int Field3 { get; set; }
        public int Field4 { get; set; }
        public int Field5 { get; set; }
    }

    [DBTable(Expansion.MoP)]
    public class SpellScaling
    {
        [DBKey]
        public int Field0 { get; set; }
        public int Field1 { get; set; }
        public int Field2 { get; set; }
        public int Field3 { get; set; }
        public int Field4 { get; set; }
        public float Field5 { get; set; }
        public int Field6 { get; set; }
        public int Field7 { get; set; }
        public int Field8 { get; set; }
    }

    [DBTable(Expansion.MoP)]
    public class SpellShapeshift
    {
        [DBKey]
        public int Field0 { get; set; }
        public int Field1 { get; set; }
        public int Field2 { get; set; }
        public int Field3 { get; set; }
        public int Field4 { get; set; }
        public int Field5 { get; set; }
    }

    [DBTable(Expansion.MoP)]
    public class SpellShapeshiftForm
    {
        [DBKey]
        public int Id { get; set; }
        public int NewField1 { get; set; }
        public string NewField2 { get; set; }
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
    }

    [DBTable(Expansion.MoP)]
    public class SpellTargetRestrictions
    {
        [DBKey]
        public int Field0 { get; set; }
        public int Field1 { get; set; }
        public int Field2 { get; set; }
        public float Field3 { get; set; }
        public float Field4 { get; set; }
        public int Field5 { get; set; }
        public int Field6 { get; set; }
        public int Field7 { get; set; }
        public int Field8 { get; set; }
    }

    [DBTable(Expansion.MoP)]
    public class SpellTotems
    {
        [DBKey]
        public int Field0 { get; set; }
        public int Field1 { get; set; }
        public int Field2 { get; set; }
        public int Field3 { get; set; }
        public int Field4 { get; set; }
    }

    [DBTable(Expansion.MoP)]
    public class SpellVisual
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
        public int Field25 { get; set; }
        public int Field26 { get; set; }
        public int Field27 { get; set; }
        public int Field28 { get; set; }
        public int Field29 { get; set; }
    }

    [DBTable(Expansion.MoP)]
    public class SpellVisualEffectName
    {
        [DBKey]
        public int Field0 { get; set; }
        public string Field1 { get; set; }
        public float Field2 { get; set; }
        public float Field3 { get; set; }
        public float Field4 { get; set; }
        public float Field5 { get; set; }
        public int Field6 { get; set; }
        public float NewField7 { get; set; }
        public int NewField8 { get; set; }
        public int NewField9 { get; set; }
    }

    [DBTable(Expansion.MoP)]
    public class UiTextureAtlasMember
    {
        [DBKey]
        public int Field0 { get; set; }
        public string Field1 { get; set; }
        public int Field2 { get; set; }
        public int Field3 { get; set; }
        public int Field4 { get; set; }
        public int Field5 { get; set; }
        public int Field6 { get; set; }
        public int Field7 { get; set; }
    }

    [DBTable(Expansion.MoP)]
    public class UiTextureKit
    {
        [DBKey]
        public int Field0 { get; set; }
        public string Field1 { get; set; }
    }

    [DBTable(Expansion.MoP)]
    public class Vehicle
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
        public int Field25 { get; set; }
        public int Field26 { get; set; }
        public int Field27 { get; set; }
        public int Field28 { get; set; }
        public int Field29 { get; set; }
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
        public int Field40 { get; set; }
    }

    [DBTable(Expansion.MoP)]
    public class WorldBosslockout
    {
        [DBKey]
        public int Field0 { get; set; }
        public string Field1 { get; set; }
        public int Field2 { get; set; }
    }

    [DBTable(Expansion.MoP)]
    public class WorldEffect
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

    [DBTable(Expansion.MoP)]
    public class WorldMapArea
    {
        [DBKey]
        public int Id { get; set; }
        public int MapId { get; set; }
        public int AreaId { get; set; }
        public string Int_name { get; set; }
        public float LocLeft { get; set; }
        public float LocRight { get; set; }
        public float LocTop { get; set; }
        public float LocBottom { get; set; }
        public int DisplayMapID { get; set; }
        public int Field9 { get; set; }
        public int Field10 { get; set; }
        public int Flags { get; set; }
        public int MinLevel { get; set; }
        public int MaxLevel { get; set; }
    }

    [DBTable(Expansion.MoP)]
    public class WorldMapOverlay
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
        public int Field11 { get; set; }
        public int Field12 { get; set; }
        public int Field13 { get; set; }
        public int Field14 { get; set; }
        public int Field15 { get; set; }
    }

    [DBTable(Expansion.MoP)]
    public class WorldMapTransforms
    {
        [DBKey]
        public int Field0 { get; set; }
        public int Field1 { get; set; }
        public float Field2 { get; set; }
        public float Field3 { get; set; }
        public float Field4 { get; set; }
        public float Field5 { get; set; }
        public int Field6 { get; set; }
        public float Field7 { get; set; }
        public float Field8 { get; set; }
        public int Field9 { get; set; }
        public int Field10 { get; set; }
        public int Field11 { get; set; }
        public float NewField { get; set; }
        public int NewField13 { get; set; }
        public int NewField14 { get; set; }
    }

    [DBTable(Expansion.MoP)]
    public class WorldSafelocs
    {
        [DBKey]
        public int Id { get; set; }
        public uint Map { get; set; }
        public float Pos_x { get; set; }
        public float Pos_y { get; set; }
        public float Pos_z { get; set; }
        public float Unk { get; set; }
        public string Name_lang { get; set; }
    }

    [DBTable(Expansion.MoP)]
    public class WorldState
    {
        [DBKey]
        public int Field0 { get; set; }
    }

    [DBTable(Expansion.MoP)]
    public class WorldStateExpression
    {
        [DBKey]
        public int Field0 { get; set; }
        public string Field1 { get; set; }
    }

    [DBTable(Expansion.MoP)]
    public class WorldStateUI
    {
        [DBKey]
        public int Field0 { get; set; }
        public int Field1 { get; set; }
        public int Field2 { get; set; }
        public int Field3 { get; set; }
        public int Field4 { get; set; }
        public int Field5 { get; set; }
        public string Field6 { get; set; }
        public string Field7 { get; set; }
        public string Field8 { get; set; }
        public int Field9 { get; set; }
        public int Field10 { get; set; }
        public string Field11 { get; set; }
        public string Field12 { get; set; }
        public string Field13 { get; set; }
        public int Field14 { get; set; }
        public int Field15 { get; set; }
        public int Field16 { get; set; }
    }

    [DBTable(Expansion.MoP)]
    public class ZoneintroMusicTable
    {
        [DBKey]
        public int Field0 { get; set; }
        public string Field1 { get; set; }
        public int Field2 { get; set; }
        public int Field3 { get; set; }
        public int Field4 { get; set; }
    }

    [DBTable(Expansion.MoP)]
    public class ZoneMusic
    {
        [DBKey]
        public int Field0 { get; set; }
        public string Field1 { get; set; }
        public int Field2 { get; set; }
        public int Field3 { get; set; }
        public int Field4 { get; set; }
        public int Field5 { get; set; }
        public int Field6 { get; set; }
        public int Field7 { get; set; }
    }

}
