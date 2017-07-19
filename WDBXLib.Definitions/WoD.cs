using System;
using WDBXLib.Attributes;
using WDBXLib.Helpers;
using static WDBXLib.Common.Constants;

namespace WDBXLib.Definitions.WoD
{

    [DBTable(Expansion.WoD)]
    public class Achievement
    {
        [DBKey]
        public int ID { get; set; }
        public int Faction { get; set; }
        public int Instance_id { get; set; }
        public int Supercedes { get; set; }
        public string Title_lang { get; set; }
        public string Description_lang { get; set; }
        public int Category { get; set; }
        public int Points { get; set; }
        public int Ui_order { get; set; }
        public int Flags { get; set; }
        public int IconID { get; set; }
        public string Reward_lang { get; set; }
        public int Minimum_criteria { get; set; }
        public int Shares_criteria { get; set; }
        public int Criteria_tree { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class Achievement_Category
    {
        [DBKey]
        public int ID { get; set; }
        public int Parent { get; set; }
        public string Name_lang { get; set; }
        public int Ui_order { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class AdventureJournal
    {
        [DBKey]
        public int ID { get; set; }
        public string Field00 { get; set; }
        public string Field04 { get; set; }
        public string Field08 { get; set; }
        public int Field0C { get; set; }
        public int Field10 { get; set; }
        public string Field14 { get; set; }
        public string Field18 { get; set; }
        public ushort Field1C { get; set; }
        public ushort Field1E { get; set; }
        public ushort Field20 { get; set; }
        [DBField(ArraySize: 2)]
        public ushort[] Field22 { get; set; }
        public ushort Field26 { get; set; }
        public ushort Field28 { get; set; }
        public byte Field2A { get; set; }
        public byte Field2B { get; set; }
        public byte Field2C { get; set; }
        public byte Field2D { get; set; }
        public byte Field2E { get; set; }
        public byte Field2F { get; set; }
        [DBField(ArraySize: 2)]
        public byte[] Field30 { get; set; }
        public byte Field32 { get; set; }
        public byte Field33 { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class AdventureMapPOI
    {
        [DBKey]
        public int ID { get; set; }
        [DBField(ArraySize: 2)]
        public float[] Field00 { get; set; }
        public int Field08 { get; set; }
        public string Field0C { get; set; }
        public string Field10 { get; set; }
        public byte Field14 { get; set; }
        public int Field15 { get; set; }
        public int Field19 { get; set; }
        public int Field1D { get; set; }
        public int Field21 { get; set; }
        public int Field25 { get; set; }
        public int Field29 { get; set; }
        public int Field2D { get; set; }
        public int Field31 { get; set; }
    }

    [DBTable(Expansion.WoD)]
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

    [DBTable(Expansion.WoD)]
    public class AnimKit
    {
        [DBKey]
        public int ID { get; set; }
        public int OneShotDuration { get; set; }
        public int OneShotStopAnimKitID { get; set; }
        public int LowDefAnimKitID { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class AnimKitBoneSet
    {
        [DBKey]
        public int ID { get; set; }
        public string Name { get; set; }
        public int BoneDataID { get; set; }
        public int ParentAnimKitBoneSetID { get; set; }
        public int ExtraBoneCount { get; set; }
        public int AltAnimKitBoneSetID { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class AnimKitBoneSetAlias
    {
        [DBKey]
        public int ID { get; set; }
        public int BoneDataID { get; set; }
        public int AnimKitBoneSetID { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class AnimKitConfig
    {
        [DBKey]
        public int ID { get; set; }
        public int ConfigFlags { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class AnimKitConfigBoneSet
    {
        [DBKey]
        public int ID { get; set; }
        public int ParentAnimKitConfigID { get; set; }
        public int AnimKitBoneSetID { get; set; }
        public int AnimKitPriorityID { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class AnimKitPriority
    {
        [DBKey]
        public int ID { get; set; }
        public int Priority { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class AnimKitSegment
    {
        [DBKey]
        public int ID { get; set; }
        public int ParentAnimKitID { get; set; }
        public int OrderIndex { get; set; }
        public int AnimID { get; set; }
        public int AnimStartTime { get; set; }
        public int AnimKitConfigID { get; set; }
        public int StartCondition { get; set; }
        public int StartConditionParam { get; set; }
        public int StartConditionDelay { get; set; }
        public int EndCondition { get; set; }
        public int EndConditionParam { get; set; }
        public int EndConditionDelay { get; set; }
        public float Speed { get; set; }
        public int SegmentFlags { get; set; }
        public int ForcedVariation { get; set; }
        public int OverrideConfigFlags { get; set; }
        public int LoopToSegmentIndex { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class AnimReplacement
    {
        [DBKey]
        public int ID { get; set; }
        public int SrcAnimID { get; set; }
        public int DstAnimID { get; set; }
        public int ParentAnimReplacementSetID { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class AnimReplacementSet
    {
        [DBKey]
        public int ID { get; set; }
        public int ExecOrder { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class AreaAssignment
    {
        [DBKey]
        public int ID { get; set; }
        public int MapID { get; set; }
        public int AreaID { get; set; }
        public int ChunkX { get; set; }
        public int ChunkY { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class AreaGroup
    {
        [DBKey(AutoGenerated: true)]
        public int ID { get; set; }
        public int AreaID { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class AreaGroupMember
    {
        [DBKey]
        public int ID { get; set; }
        public ushort AreaGroupId { get; set; }
        public ushort AreaId { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class AreaPOI
    {
        [DBKey]
        public int ID { get; set; }
        public int Importance { get; set; }
        public int Icon { get; set; }
        public int FactionID { get; set; }
        [DBField(ArraySize: 2)]
        public float[] Pos { get; set; }
        public int ContinentID { get; set; }
        public int Flags { get; set; }
        public int AreaID { get; set; }
        public string Name_lang { get; set; }
        public string Description_lang { get; set; }
        public int WorldStateID { get; set; }
        public int PlayerConditionID { get; set; }
        public int WorldMapLink { get; set; }
        public int PortlocID { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class AreaPOIState
    {
        [DBKey]
        public int ID { get; set; }
        public int AreaPoiID { get; set; }
        public int State { get; set; }
        public int Icon { get; set; }
        public string Description { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class AreaTable
    {
        [DBKey]
        public int ID { get; set; }
        public int ContinentID { get; set; }
        public int ParentAreaID { get; set; }
        public int AreaBit { get; set; }
        [DBField(ArraySize: 2)]
        public int[] Flags { get; set; }
        public int SoundProviderPref { get; set; }
        public int SoundProviderPrefUnderwater { get; set; }
        public int AmbienceID { get; set; }
        public int ZoneMusic { get; set; }
        public string ZoneName { get; set; }
        public int IntroSound { get; set; }
        public int ExplorationLevel { get; set; }
        public string AreaName_lang { get; set; }
        public int FactionGroupMask { get; set; }
        [DBField(ArraySize: 4)]
        public int[] LiquidTypeID { get; set; }
        public float Ambient_multiplier { get; set; }
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

    [DBTable(Expansion.WoD)]
    public class AreaTrigger
    {
        [DBKey]
        public int ID { get; set; }
        public int ContinentID { get; set; }
        [DBField(ArraySize: 3)]
        public float[] Pos { get; set; }
        public int PhaseUseFlags { get; set; }
        public int PhaseID { get; set; }
        public int PhaseGroupID { get; set; }
        public float Radius { get; set; }
        public float Box_length { get; set; }
        public float Box_width { get; set; }
        public float Box_height { get; set; }
        public float Box_yaw { get; set; }
        public int ShapeType { get; set; }
        public int ShapeID { get; set; }
        public int AreaTriggerActionSetID { get; set; }
        public int Flags { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class AreaTriggerActionSet
    {
        [DBKey]
        public int ID { get; set; }
        public int Flags { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class AreaTriggerBox
    {
        [DBKey]
        public int ID { get; set; }
        [DBField(ArraySize: 3)]
        public float[] Extents { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class AreaTriggerCylinder
    {
        [DBKey]
        public int ID { get; set; }
        public float Radius { get; set; }
        public float Height { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class AreaTriggerSphere
    {
        [DBKey]
        public int ID { get; set; }
        public float MaxRadius { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class Armorlocation
    {
        [DBKey]
        public int ID { get; set; }
        public float Clothmodifier { get; set; }
        public float Leathermodifier { get; set; }
        public float Chainmodifier { get; set; }
        public float Platemodifier { get; set; }
        public float Modifier { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class Artifact
    {
        [DBKey]
        public int ID { get; set; }
        public string Field00 { get; set; }
        public int Field04 { get; set; }
        public int Field08 { get; set; }
        public int Field0C { get; set; }
        public ushort Field10 { get; set; }
        public ushort Field12 { get; set; }
        public byte Field14 { get; set; }
        public byte Field15 { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class ArtifactAppearance
    {
        public string Field00 { get; set; }
        public int Field04 { get; set; }
        public float Field08 { get; set; }
        public float Field0C { get; set; }
        public int Field10 { get; set; }
        public ushort Field14 { get; set; }
        public ushort Field16 { get; set; }
        public ushort Field18 { get; set; }
        public byte Field1A { get; set; }
        public byte Field1B { get; set; }
        public byte Field1C { get; set; }
        public byte Field1D { get; set; }
        [DBKey]
        public int ID { get; set; }
        public int Field22 { get; set; }
        public int Field26 { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class ArtifactAppearanceSet
    {
        public string Field00 { get; set; }
        public string Field04 { get; set; }
        public ushort Field08 { get; set; }
        public ushort Field0A { get; set; }
        public byte Field0C { get; set; }
        public byte Field0D { get; set; }
        public byte Field0E { get; set; }
        [DBKey]
        public int ID { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class ArtifactCategory
    {
        [DBKey]
        public int ID { get; set; }
        public ushort Field00 { get; set; }
        public ushort Field02 { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class ArtifactPower
    {
        [DBField(ArraySize: 2)]
        public float[] Field00 { get; set; }
        public byte Field08 { get; set; }
        public byte Field09 { get; set; }
        public byte Field0A { get; set; }
        [DBKey]
        public int ID { get; set; }
        public int Field0F { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class ArtifactPowerLink
    {
        [DBKey]
        public int ID { get; set; }
        public ushort Field00 { get; set; }
        public ushort Field02 { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class ArtifactPowerRank
    {
        [DBKey]
        public int ID { get; set; }
        public int Field00 { get; set; }
        public float Field04 { get; set; }
        public ushort Field08 { get; set; }
        public ushort Field0A { get; set; }
        public byte Field0C { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class ArtifactQuestXP
    {
        [DBKey]
        public int ID { get; set; }
        [DBField(ArraySize: 10)]
        public int[] Field00 { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class ArtifactUnlock
    {
        [DBKey]
        public int ID { get; set; }
        public ushort Field00 { get; set; }
        public ushort Field02 { get; set; }
        public byte Field04 { get; set; }
        public byte Field05 { get; set; }
        public int Field06 { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class AttackAnimKits
    {
        [DBKey]
        public int ID { get; set; }
        public int Animation { get; set; }
        public int Type { get; set; }
        public int Flags { get; set; }
        public int Unknown { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class AttackAnimTypes
    {
        [DBKey]
        public int ID { get; set; }
        public string Name { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class AuctionHouse
    {
        [DBKey]
        public int ID { get; set; }
        public int FactionID { get; set; }
        public int DepositRate { get; set; }
        public int ConsignmentRate { get; set; }
        public string Name_lang { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class BankBagSlotPrices
    {
        [DBKey]
        public int ID { get; set; }
        public int Cost { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class BannedAddOns
    {
        [DBKey]
        public int ID { get; set; }
        [DBField(ArraySize: 4)]
        public int[] NameMD5_ { get; set; }
        [DBField(ArraySize: 4)]
        public int[] VersionMD5_ { get; set; }
        public int LastModified { get; set; }
        public int Flags { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class BarberShopStyle
    {
        [DBKey]
        public int ID { get; set; }
        public int Type { get; set; }
        public string DisplayName_lang { get; set; }
        public string Description_lang { get; set; }
        public float Cost_Modifier { get; set; }
        public int Race { get; set; }
        public int Sex { get; set; }
        public int Data { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class BattlemasterList
    {
        [DBKey]
        public int ID { get; set; }
        [DBField(ArraySize: 16)]
        public int[] MapID { get; set; }
        public int InstanceType { get; set; }
        public int GroupsAllowed { get; set; }
        public string Name_lang { get; set; }
        public int MaxGroupSize { get; set; }
        public int HolidayWorldState { get; set; }
        public int Minlevel { get; set; }
        public int Maxlevel { get; set; }
        public int RatedPlayers { get; set; }
        public int MinPlayers { get; set; }
        public int MaxPlayers { get; set; }
        public int Flags { get; set; }
        public int IconFileDataID { get; set; }
        public string GameType_lang { get; set; }
        public int PlayerConditionID { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class BattlePetAbility
    {
        [DBKey]
        public int ID { get; set; }
        public int Field4 { get; set; }
        public int Field8 { get; set; }
        public int FieldC { get; set; }
        public int Field10 { get; set; }
        public int Field14 { get; set; }
        public string Field18 { get; set; }
        public string Field1C { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class BattlePetAbilityEffect
    {
        [DBKey]
        public int ID { get; set; }
        public int Field4 { get; set; }
        public int Field8 { get; set; }
        public int FieldC { get; set; }
        public int Field10 { get; set; }
        public int Field14 { get; set; }
        [DBField(ArraySize: 6)]
        public int[] Field18 { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class BattlePetAbilityState
    {
        [DBKey]
        public int ID { get; set; }
        public int Field4 { get; set; }
        public int Field8 { get; set; }
        public int FieldC { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class BattlePetAbilityTurn
    {
        [DBKey]
        public int ID { get; set; }
        public int Field4 { get; set; }
        public int Field8 { get; set; }
        public int FieldC { get; set; }
        public int Field10 { get; set; }
        public int Field14 { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class BattlePetBreedQuality
    {
        [DBKey]
        public int ID { get; set; }
        public int Field4 { get; set; }
        public float Field8 { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class BattlePetBreedState
    {
        [DBKey]
        public int ID { get; set; }
        public int Field4 { get; set; }
        public int Field8 { get; set; }
        public int FieldC { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class BattlePetEffectProperties
    {
        [DBKey]
        public int ID { get; set; }
        public int Field4 { get; set; }
        [DBField(ArraySize: 6)]
        public string[] Field8 { get; set; }
        [DBField(ArraySize: 6)]
        public int[] Field20 { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class BattlePetNPCTeamMember
    {
        [DBKey]
        public int ID { get; set; }
        public string Field4 { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class BattlePetSpecies
    {
        [DBKey]
        public int ID { get; set; }
        public int Field4 { get; set; }
        public int Field8 { get; set; }
        public int FieldC { get; set; }
        public int Field10 { get; set; }
        public int Field14 { get; set; }
        public int Field18 { get; set; }
        public string Field1C { get; set; }
        public string Field20 { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class BattlePetSpeciesState
    {
        [DBKey]
        public int ID { get; set; }
        public int Field4 { get; set; }
        public int Field8 { get; set; }
        public int FieldC { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class BattlePetSpeciesXAbility
    {
        [DBKey]
        public int ID { get; set; }
        public int Field4 { get; set; }
        public int Field8 { get; set; }
        public int FieldC { get; set; }
        public int Field10 { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class BattlePetState
    {
        [DBKey]
        public int ID { get; set; }
        public int Field4 { get; set; }
        public string Field8 { get; set; }
        public int FieldC { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class BattlePetVisual
    {
        [DBKey]
        public int ID { get; set; }
        public int Field4 { get; set; }
        public int Field8 { get; set; }
        public int FieldC { get; set; }
        public int Field10 { get; set; }
        public int Field14 { get; set; }
        public int Field18 { get; set; }
        public string Field1C { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class BoneWindModifierModel
    {
        [DBKey]
        public int ID { get; set; }
        public int Field00 { get; set; }
        public int Field04 { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class BoneWindModifiers
    {
        [DBKey]
        public int ID { get; set; }
        [DBField(ArraySize: 3)]
        public float[] Field00 { get; set; }
        public float Field0C { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class Bounty
    {
        [DBKey]
        public int ID { get; set; }
        public int Field00 { get; set; }
        public ushort Field04 { get; set; }
        public ushort Field06 { get; set; }
        public byte Field08 { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class BountySet
    {
        [DBKey]
        public int ID { get; set; }
        public ushort Field00 { get; set; }
        public ushort Field02 { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class BroadcastText
    {
        [DBKey]
        public int ID { get; set; }
        public int Field4 { get; set; }
        public string Field8 { get; set; }
        public string FieldC { get; set; }
        [DBField(ArraySize: 3)]
        public int[] Field10 { get; set; }
        [DBField(ArraySize: 3)]
        public int[] Field1C { get; set; }
        public int Field28 { get; set; }
        public int Field2C { get; set; }
        public int Field30 { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class CameraEffect
    {
        [DBKey]
        public int ID { get; set; }
        public byte Field00 { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class CameraEffectEntry
    {
        [DBKey]
        public int ID { get; set; }
        public float Field00 { get; set; }
        public float Field04 { get; set; }
        public float Field08 { get; set; }
        public float Field0C { get; set; }
        public float Field10 { get; set; }
        public float Field14 { get; set; }
        public float Field18 { get; set; }
        public float Field1C { get; set; }
        public ushort Field20 { get; set; }
        public ushort Field22 { get; set; }
        public byte Field24 { get; set; }
        public byte Field25 { get; set; }
        public byte Field26 { get; set; }
        public byte Field27 { get; set; }
        public byte Field28 { get; set; }
        public byte Field29 { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class CameraMode
    {
        [DBKey]
        public int ID { get; set; }
        public int Type { get; set; }
        public int Flags { get; set; }
        [DBField(ArraySize: 3)]
        public float[] PositionOffset { get; set; }
        [DBField(ArraySize: 3)]
        public float[] TargetOffset { get; set; }
        public float PositionSmoothing { get; set; }
        public float RotationSmoothing { get; set; }
        public float FieldOfView { get; set; }
        public int LockedPositionOffsetBase { get; set; }
        public int LockedPositionOffsetDirection { get; set; }
        public int LockedTargetOffsetBase { get; set; }
        public int LockedTargetOffsetDirection { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class CameraShakes
    {
        [DBKey]
        public int ID { get; set; }
        public int ShakeType { get; set; }
        public int Direction { get; set; }
        public float Amplitude { get; set; }
        public float Frequency { get; set; }
        public float Duration { get; set; }
        public float Phase { get; set; }
        public float Coefficient { get; set; }
        public int Flags { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class CastableRaidBuffs
    {
        [DBKey]
        public int ID { get; set; }
        public int SpellID { get; set; }
        public int CastingSpellID { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class Cfg_Categories
    {
        [DBKey]
        public int ID { get; set; }
        public int LocaleMask { get; set; }
        public int Create_charsetMask { get; set; }
        public int Existing_charsetMask { get; set; }
        public int Flags { get; set; }
        public string Name_lang { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class Cfg_Configs
    {
        [DBKey]
        public int ID { get; set; }
        public int RealmType { get; set; }
        public int PlayerKillingAllowed { get; set; }
        public int Roleplaying { get; set; }
        public int PlayerAttackSpeedBase { get; set; }
        public int MaxDamageReductionPctPhysical { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class Cfg_Regions
    {
        [DBKey]
        public int ID { get; set; }
        public string Tag { get; set; }
        public int Region_group_mask { get; set; }
        public int RulesetID { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class CharacterFaceBoneSet
    {
        [DBKey]
        public int ID { get; set; }
        public int Field00 { get; set; }
        public byte Field04 { get; set; }
        public byte Field05 { get; set; }
        public byte Field06 { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class CharacterFacialHairStyles
    {
        [DBKey]
        public int ID { get; set; }
        public int RaceID { get; set; }
        public int GenderID { get; set; }
        public int VariationID { get; set; }
        [DBField(ArraySize: 5)]
        public int[] Geoset { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class CharacterLoadout
    {
        [DBKey]
        public int ID { get; set; }
        public int ChrClassID { get; set; }
        public int Purpose { get; set; }
        public int Racemask { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class CharacterLoadoutItem
    {
        [DBKey]
        public int ID { get; set; }
        public int CharacterLoadoutID { get; set; }
        public int ItemID { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class CharBaseInfo
    {
        [DBKey]
        public int ID { get; set; }
        public byte RaceID { get; set; }
        public byte ClassID { get; set; }
        [DBField(ArraySize: 2)]
        public byte[] Padding { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class CharBaseSection
    {
        [DBKey]
        public int ID { get; set; }
        public int FallbackID { get; set; }
        public int LayoutResType { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class CharComponentTextureLayouts
    {
        [DBKey]
        public int ID { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class CharComponentTextureSections
    {
        [DBKey]
        public int ID { get; set; }
        public int CharComponentTextureLayoutID { get; set; }
        public int SectionType { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class CharHairGeosets
    {
        [DBKey]
        public int ID { get; set; }
        public int RaceID { get; set; }
        public int SexID { get; set; }
        public int VariationID { get; set; }
        public int VariationType { get; set; }
        public int GeosetID { get; set; }
        public int GeosetType { get; set; }
        public int Showscalp { get; set; }
        public int ColorIndex { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class CharSections
    {
        [DBKey]
        public int ID { get; set; }
        public int RaceID { get; set; }
        public int SexID { get; set; }
        public int BaseSection { get; set; }
        [DBField(ArraySize: 3)]
        public string[] TextureName { get; set; }
        public int Flags { get; set; }
        public int VariationIndex { get; set; }
        public int ColorIndex { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class CharShipment
    {
        [DBKey]
        public int ID { get; set; }
        public int Field4 { get; set; }
        public int Field8 { get; set; }
        public int FieldC { get; set; }
        public int Field10 { get; set; }
        public int Field14 { get; set; }
        public int Field18 { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class CharShipmentContainer
    {
        [DBKey]
        public int ID { get; set; }
        public int Field4 { get; set; }
        public int Field8 { get; set; }
        public string FieldC { get; set; }
        public int Field10 { get; set; }
        public int Field14 { get; set; }
        public int Field18 { get; set; }
        public int Field1C { get; set; }
        public int Field20 { get; set; }
        public int Field24 { get; set; }
    }

    [DBTable(Expansion.WoD)]
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
        public int PetDisplayID { get; set; }
        public int PetFamilyID { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class CharTitles
    {
        [DBKey]
        public int ID { get; set; }
        public int Condition_ID { get; set; }
        public string Name_lang { get; set; }
        public string Name1_lang { get; set; }
        public int Mask_ID { get; set; }
        public int Flags { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class ChatChannels
    {
        [DBKey]
        public int ID { get; set; }
        public int Flags { get; set; }
        public int FactionGroup { get; set; }
        public string Name_lang { get; set; }
        public string Shortcut_lang { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class ChatProfanity
    {
        [DBKey]
        public int ID { get; set; }
        public string Text { get; set; }
        public int Language { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class ChrClasses
    {
        [DBKey]
        public int ID { get; set; }
        public int DisplayPower { get; set; }
        public string PetNameToken { get; set; }
        public string Name_lang { get; set; }
        public string Name_female_lang { get; set; }
        public string Name_male_lang { get; set; }
        public string FileName { get; set; }
        public int SpellClassSet { get; set; }
        public int Flags { get; set; }
        public int CinematicSequenceID { get; set; }
        public int AttackPowerPerStrength { get; set; }
        public int AttackPowerPerAgility { get; set; }
        public int RangedAttackPowerPerAgility { get; set; }
        public int DefaultSpec { get; set; }
        public int CreateScreenFileDataID { get; set; }
        public int SelectScreenFileDataID { get; set; }
        public int LowResScreenFileDataID { get; set; }
        public int IconFileDataID { get; set; }
        public int Unknown { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class ChrClassesXPowerTypes
    {
        [DBKey]
        public int ID { get; set; }
        public int ClassID { get; set; }
        public int PowerType { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class ChrClassRaceSex
    {
        [DBKey]
        public int ID { get; set; }
        public byte Field00 { get; set; }
        public byte Field01 { get; set; }
        public byte Field02 { get; set; }
        public int Field03 { get; set; }
        public int Field07 { get; set; }
        public int Field0B { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class ChrClassTitle
    {
        [DBKey]
        public int ID { get; set; }
        public string Field00 { get; set; }
        public string Field04 { get; set; }
        public byte Field08 { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class ChrClassUIDisplay
    {
        [DBKey]
        public int ID { get; set; }
        public ushort Field00 { get; set; }
        public ushort Field02 { get; set; }
        public byte Field04 { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class ChrClassVillain
    {
        [DBKey]
        public int ID { get; set; }
        public string Field00 { get; set; }
        public byte Field04 { get; set; }
        public byte Field05 { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class ChrRaces
    {
        [DBKey]
        public int ID { get; set; }
        public int Flags { get; set; }
        public int FactionID { get; set; }
        public int ExplorationSoundID { get; set; }
        public int MaleDisplayId { get; set; }
        public int FemaleDisplayId { get; set; }
        public string ClientPrefix { get; set; }
        public int BaseLanguage { get; set; }
        public int CreatureType { get; set; }
        public int ResSicknessSpellID { get; set; }
        public int SplashSoundID { get; set; }
        public string ClientFilestring { get; set; }
        public int CinematicSequenceID { get; set; }
        public int Alliance { get; set; }
        public string Name_lang { get; set; }
        public string Name_female_lang { get; set; }
        public string Name_male_lang { get; set; }
        [DBField(ArraySize: 2)]
        public string[] FacialHairCustomization { get; set; }
        public string HairCustomization { get; set; }
        public int Race_related { get; set; }
        public int UnalteredVisualRaceID { get; set; }
        public int UaMaleCreatureSoundDataID { get; set; }
        public int UaFemaleCreatureSoundDataID { get; set; }
        public int CharComponentTextureLayoutID { get; set; }
        public int DefaultClassID { get; set; }
        public int CreateScreenFileDataID { get; set; }
        public int SelectScreenFileDataID { get; set; }
        [DBField(ArraySize: 3)]
        public float[] MaleCustomizeOffset { get; set; }
        [DBField(ArraySize: 3)]
        public float[] FemaleCustomizeOffset { get; set; }
        public int NeutralRaceID { get; set; }
        public int LowResScreenFileDataID { get; set; }
        public int HighResMaleDisplayId { get; set; }
        public int HighResFemaleDisplayId { get; set; }
        public int CharComponentTexLayoutHiResID { get; set; }
        public int Unknown { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class ChrSpecialization
    {
        [DBKey]
        public int ID { get; set; }
        public string BackgroundFile { get; set; }
        public int ClassID { get; set; }
        [DBField(ArraySize: 2)]
        public int[] MasterySpellID { get; set; }
        public int OrderIndex { get; set; }
        public int PetTalentType { get; set; }
        public int Role { get; set; }
        public int SpellIconID { get; set; }
        public int RaidBuffs { get; set; }
        public int Flags { get; set; }
        public string Name_lang { get; set; }
        public string Name2_lang { get; set; }
        public string Description_lang { get; set; }
        [DBField(ArraySize: 2)]
        public int[] PrimaryStatOrder { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class ChrUpgradeBucket
    {
        [DBKey]
        public int ID { get; set; }
        public ushort Field00 { get; set; }
        public byte Field02 { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class ChrUpgradeBucketSpell
    {
        [DBKey]
        public int ID { get; set; }
        public int Field00 { get; set; }
        public ushort Field04 { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class ChrUpgradeTier
    {
        [DBKey]
        public int ID { get; set; }
        public int Field04 { get; set; }
        public string Field05 { get; set; }
        public int Field06 { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class CinematicCamera
    {
        [DBKey]
        public int ID { get; set; }
        public string Model { get; set; }
        public int SoundID { get; set; }
        [DBField(ArraySize: 3)]
        public float[] Origin { get; set; }
        public float OriginFacing { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class CinematicSequences
    {
        [DBKey]
        public int ID { get; set; }
        public int SoundID { get; set; }
        [DBField(ArraySize: 8)]
        public int[] Camera { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class CloakDampening
    {
        [DBKey]
        public int ID { get; set; }
        [DBField(ArraySize: 5)]
        public float[] Field00 { get; set; }
        [DBField(ArraySize: 5)]
        public float[] Field14 { get; set; }
        [DBField(ArraySize: 2)]
        public float[] Field28 { get; set; }
        [DBField(ArraySize: 2)]
        public float[] Field30 { get; set; }
        public float Field38 { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class CombatCondition
    {
        [DBKey]
        public int ID { get; set; }
        public int WorldStateExpressionID { get; set; }
        public int SelfConditionID { get; set; }
        public int TargetConditionID { get; set; }
        [DBField(ArraySize: 2)]
        public int[] FriendConditionID { get; set; }
        [DBField(ArraySize: 2)]
        public int[] FriendConditionOp { get; set; }
        [DBField(ArraySize: 2)]
        public int[] FriendConditionCount { get; set; }
        public int FriendConditionLogic { get; set; }
        [DBField(ArraySize: 2)]
        public int[] EnemyConditionID { get; set; }
        [DBField(ArraySize: 2)]
        public int[] EnemyConditionOp { get; set; }
        [DBField(ArraySize: 2)]
        public int[] EnemyConditionCount { get; set; }
        public int EnemyConditionLogic { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class ComponentModelFileData
    {
        [DBKey]
        public int ID { get; set; }
        public byte Field00 { get; set; }
        public byte Field01 { get; set; }
        public byte Field02 { get; set; }
        public byte Field03 { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class ComponentTextureFileData
    {
        [DBKey]
        public int ID { get; set; }
        public byte TextureItemID { get; set; }
        public byte Field01 { get; set; }
        public byte Texture_Type { get; set; }
        public int FileDataRef { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class ConsoleScripts
    {
        [DBKey]
        public int ID { get; set; }
        public string Name { get; set; }
        public string Script { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class ConversationLine
    {
        [DBKey]
        public int ID { get; set; }
        public int Field00 { get; set; }
        public int Field04 { get; set; }
        public int Field08 { get; set; }
        public ushort Field0C { get; set; }
        public ushort Field0E { get; set; }
        public byte Field10 { get; set; }
        public byte Field11 { get; set; }
        public byte Field12 { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class Creature
    {
        [DBKey]
        public int ID { get; set; }
        public int Field4 { get; set; }
        [DBField(ArraySize: 3)]
        public int[] Field8 { get; set; }
        public int Field14 { get; set; }
        [DBField(ArraySize: 4)]
        public int[] Field18 { get; set; }
        [DBField(ArraySize: 4)]
        public int[] Field28 { get; set; }
        public string Field38 { get; set; }
        public string Field3C { get; set; }
        public string Field40 { get; set; }
        public int Field44 { get; set; }
        public int Field48 { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class CreatureDifficulty
    {
        [DBKey]
        public int ID { get; set; }
        public int Field4 { get; set; }
        public int Field8 { get; set; }
        public int FieldC { get; set; }
        public int Field10 { get; set; }
        public int Field14 { get; set; }
        [DBField(ArraySize: 5)]
        public int[] Field18 { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class CreatureDisplayInfo
    {
        [DBKey]
        public int ID { get; set; }
        public int ModelID { get; set; }
        public int SoundID { get; set; }
        public int ExtendedDisplayInfoID { get; set; }
        public float CreatureModelScale { get; set; }
        public float PlayerModelScale { get; set; }
        public int CreatureModelAlpha { get; set; }
        [DBField(ArraySize: 3)]
        public string[] TextureVariation { get; set; }
        public string PortraitTextureName { get; set; }
        public int SizeClass { get; set; }
        public int BloodID { get; set; }
        public int NPCSoundID { get; set; }
        public int ParticleColorID { get; set; }
        public int CreatureGeosetData { get; set; }
        public int ObjectEffectPackageID { get; set; }
        public int AnimReplacementSetID { get; set; }
        public int Flags { get; set; }
        public int Gender { get; set; }
        public int StateSpellVisualKitID { get; set; }
        public int Unknown { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class CreatureDisplayInfoCond
    {
        [DBKey]
        public int ID { get; set; }
        public int Field00 { get; set; }
        [DBField(ArraySize: 2)]
        public int[] Field04 { get; set; }
        [DBField(ArraySize: 2)]
        public int[] Field0C { get; set; }
        [DBField(ArraySize: 2)]
        public int[] Field14 { get; set; }
        public byte Field1C { get; set; }
        public byte Field1D { get; set; }
        public int Field1E { get; set; }
        public int Field22 { get; set; }
        public int Field26 { get; set; }
        public int Field2A { get; set; }
        public int Field2E { get; set; }
        public int Field32 { get; set; }
        public int Field36 { get; set; }
        public int Field3A { get; set; }
        [DBField(ArraySize: 3)]
        public int[] Field3E { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class CreatureDisplayInfoExtra
    {
        [DBKey]
        public int ID { get; set; }
        public int DisplayRaceID { get; set; }
        public int DisplaySexID { get; set; }
        public int SkinID { get; set; }
        public int FaceID { get; set; }
        public int HairStyleID { get; set; }
        public int HairColorID { get; set; }
        public int FacialHairID { get; set; }
        [DBField(ArraySize: 11)]
        public int[] NPCItemDisplay { get; set; }
        public int Flags { get; set; }
        public int FileDataID { get; set; }
        public int HdFileDataID { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class CreatureDisplayInfoTrn
    {
        [DBKey]
        public int ID { get; set; }
        public int Field00 { get; set; }
        public int Field04 { get; set; }
        public float Field08 { get; set; }
        public ushort Field0C { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class CreatureDispXUiCamera
    {
        [DBKey]
        public int ID { get; set; }
        public int Field00 { get; set; }
        public ushort Field04 { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class CreatureFamily
    {
        [DBKey]
        public int ID { get; set; }
        public float MinScale { get; set; }
        public int MinScaleLevel { get; set; }
        public float MaxScale { get; set; }
        public int MaxScaleLevel { get; set; }
        [DBField(ArraySize: 2)]
        public int[] SkillLine { get; set; }
        public int PetFoodMask { get; set; }
        public int PetTalentType { get; set; }
        public int CategoryEnumID { get; set; }
        public string Name_lang { get; set; }
        public string IconFile { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class CreatureImmunities
    {
        [DBKey]
        public int ID { get; set; }
        public int School { get; set; }
        public int DispelType { get; set; }
        public int MechanicsAllowed { get; set; }
        public int Mechanic { get; set; }
        public int EffectsAllowed { get; set; }
        [DBField(ArraySize: 7)]
        public int[] Effect { get; set; }
        public int StatesAllowed { get; set; }
        [DBField(ArraySize: 15)]
        public int[] State { get; set; }
        public int Flags { get; set; }
    }

    [DBTable(Expansion.WoD)]
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
        [DBField(ArraySize: 3)]
        public float[] GeoBoxMin { get; set; }
        [DBField(ArraySize: 3)]
        public float[] GeoBoxMax { get; set; }
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

    [DBTable(Expansion.WoD)]
    public class CreatureMovementInfo
    {
        [DBKey]
        public int ID { get; set; }
        public float SmoothFacingChaseRate { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class CreatureSoundData
    {
        [DBKey]
        public int ID { get; set; }
        public int SoundExertionID { get; set; }
        public int SoundExertionCriticalID { get; set; }
        public int SoundInjuryID { get; set; }
        public int SoundInjuryCriticalID { get; set; }
        public int SoundInjuryCrushingBlowID { get; set; }
        public int SoundDeathID { get; set; }
        public int SoundStunID { get; set; }
        public int SoundStandID { get; set; }
        public int SoundFootstepID { get; set; }
        public int SoundAggroID { get; set; }
        public int SoundWingFlapID { get; set; }
        public int SoundWingGlideID { get; set; }
        public int SoundAlertID { get; set; }
        [DBField(ArraySize: 5)]
        public int[] SoundFidget { get; set; }
        [DBField(ArraySize: 4)]
        public int[] CustomAttack { get; set; }
        public int NPCSoundID { get; set; }
        public int LoopSoundID { get; set; }
        public int CreatureImpactType { get; set; }
        public int SoundJumpStartID { get; set; }
        public int SoundJumpEndID { get; set; }
        public int SoundPetAttackID { get; set; }
        public int SoundPetOrderID { get; set; }
        public int SoundPetDismissID { get; set; }
        public float FidgetDelaySecondsMin { get; set; }
        public float FidgetDelaySecondsMax { get; set; }
        public int BirthSoundID { get; set; }
        public int SpellCastDirectedSoundID { get; set; }
        public int SubmergeSoundID { get; set; }
        public int SubmergedSoundID { get; set; }
        public int CreatureSoundDataIDPet { get; set; }
        public int TransformSoundID { get; set; }
        public int TransformAnimatedSoundID { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class CreatureSpellData
    {
        [DBKey]
        public int ID { get; set; }
        [DBField(ArraySize: 4)]
        public int[] Spells { get; set; }
        [DBField(ArraySize: 4)]
        public int[] Availability { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class CreatureType
    {
        [DBKey]
        public int ID { get; set; }
        public string Name_lang { get; set; }
        public int Flags { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class Criteria
    {
        [DBKey]
        public int ID { get; set; }
        public int Type { get; set; }
        public int Asset { get; set; }
        public int Start_event { get; set; }
        public int Start_asset { get; set; }
        public int Start_timer { get; set; }
        public int Fail_event { get; set; }
        public int Fail_asset { get; set; }
        public int Modifier_tree_id { get; set; }
        public int Flags { get; set; }
        public int Eligibility_world_state_ID { get; set; }
        public int Eligibility_world_state_value { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class CriteriaTree
    {
        [DBKey]
        public int ID { get; set; }
        public int CriteriaID { get; set; }
        public ulong Amount { get; set; }
        public int Operator { get; set; }
        public int Parent { get; set; }
        public int Flags { get; set; }
        public string Description_lang { get; set; }
        public int OrderIndex { get; set; }
        [DBField(ArraySize: 4)]
        public byte[] Padding { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class CriteriaTreeXEffect
    {
        [DBKey]
        public int ID { get; set; }
        public int CriteriaTreeID { get; set; }
        public int WorldEffectID { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class CurrencyCategory
    {
        [DBKey]
        public int ID { get; set; }
        public int Flags { get; set; }
        public string Name_lang { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class CurrencyTypes
    {
        [DBKey]
        public int ID { get; set; }
        public int CategoryID { get; set; }
        public string Name_lang { get; set; }
        [DBField(ArraySize: 2)]
        public string[] InventoryIcon { get; set; }
        public int SpellWeight { get; set; }
        public int SpellCategory { get; set; }
        public int MaxQty { get; set; }
        public int MaxEarnablePerWeek { get; set; }
        public int Flags { get; set; }
        public int Quality { get; set; }
        public string Description_lang { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class Curve
    {
        [DBKey]
        public int ID { get; set; }
        public int Field4 { get; set; }
        public int Field8 { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class CurvePoint
    {
        [DBKey]
        public int ID { get; set; }
        public int Field4 { get; set; }
        public int Field8 { get; set; }
        [DBField(ArraySize: 2)]
        public float[] FieldC { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class DeathThudLookups
    {
        [DBKey]
        public int ID { get; set; }
        public int SizeClass { get; set; }
        public int TerrainTypeSoundID { get; set; }
        public int SoundEntryID { get; set; }
        public int SoundEntryIDWater { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class DecalProperties
    {
        [DBKey]
        public int ID { get; set; }
        public int Field00 { get; set; }
        public float Field04 { get; set; }
        public float Field08 { get; set; }
        public float Field0C { get; set; }
        public float Field10 { get; set; }
        public float Field14 { get; set; }
        public float Field18 { get; set; }
        public float Field1C { get; set; }
        public float Field20 { get; set; }
        public byte Field24 { get; set; }
        public byte Field25 { get; set; }
        public int Field26 { get; set; }
        public int Field2A { get; set; }
        public int Field2E { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class DeclinedWord
    {
        [DBKey]
        public int ID { get; set; }
        public string Word { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class DeclinedWordCases
    {
        [DBKey]
        public int ID { get; set; }
        public int DeclinedWordID { get; set; }
        public int CaseIndex { get; set; }
        public string DeclinedWord { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class DestructibleModelData
    {
        [DBKey]
        public int ID { get; set; }
        public int State0Wmo { get; set; }
        public int State0ImpactEffectDoodadSet { get; set; }
        public int State0AmbientDoodadSet { get; set; }
        public int State0NameSet { get; set; }
        public int State1Wmo { get; set; }
        public int State1DestructionDoodadSet { get; set; }
        public int State1ImpactEffectDoodadSet { get; set; }
        public int State1AmbientDoodadSet { get; set; }
        public int State1NameSet { get; set; }
        public int State2Wmo { get; set; }
        public int State2DestructionDoodadSet { get; set; }
        public int State2ImpactEffectDoodadSet { get; set; }
        public int State2AmbientDoodadSet { get; set; }
        public int State2NameSet { get; set; }
        public int State3Wmo { get; set; }
        public int State3InitDoodadSet { get; set; }
        public int State3AmbientDoodadSet { get; set; }
        public int State3NameSet { get; set; }
        public int EjectDirection { get; set; }
        public int RepairGroundFx { get; set; }
        public int DoNotHighlight { get; set; }
        public int HealEffect { get; set; }
        public int HealEffectSpeed { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class DeviceBlacklist
    {
        [DBKey]
        public int ID { get; set; }
        public int Field4 { get; set; }
        public int Field8 { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class DeviceDefaultSettings
    {
        [DBKey]
        public int ID { get; set; }
        public int Field4 { get; set; }
        public int Field8 { get; set; }
        public int FieldC { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class Difficulty
    {
        [DBKey]
        public int ID { get; set; }
        public int FallbackDifficultyID { get; set; }
        public int InstanceType { get; set; }
        public int MinPlayers { get; set; }
        public int MaxPlayers { get; set; }
        public int OldEnumValue { get; set; }
        public int Flags { get; set; }
        public int ToggleDifficultyID { get; set; }
        public int GroupSizeHealthCurveID { get; set; }
        public int GroupSizeDmgCurveID { get; set; }
        public int GroupSizeSpellPointsCurveID { get; set; }
        public string Name_lang { get; set; }
        public int ItemBonusTreeModID { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class DissolveEffect
    {
        [DBKey]
        public int ID { get; set; }
        public float Field00 { get; set; }
        public float Field04 { get; set; }
        public float Field08 { get; set; }
        public float Field0C { get; set; }
        public float Field10 { get; set; }
        public float Field14 { get; set; }
        public float Field18 { get; set; }
        public byte Field1C { get; set; }
        public byte Field1D { get; set; }
        public int Field1E { get; set; }
        public int Field22 { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class DriverBlacklist
    {
        [DBKey]
        public int ID { get; set; }
        public int Field4 { get; set; }
        public int Field8 { get; set; }
        public int FieldC { get; set; }
        public int Field10 { get; set; }
        public int Field14 { get; set; }
        public int Field18 { get; set; }
        public int Field1C { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class DungeonEncounter
    {
        [DBKey]
        public int ID { get; set; }
        public int MapID { get; set; }
        public int DifficultyID { get; set; }
        public int OrderIndex { get; set; }
        public int Bit { get; set; }
        public string Name_lang { get; set; }
        public int CreatureDisplayID { get; set; }
        public int SpellIconID { get; set; }
        public int Flags { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class DungeonMap
    {
        [DBKey]
        public int ID { get; set; }
        public int MapID { get; set; }
        public int FloorIndex { get; set; }
        [DBField(ArraySize: 2)]
        public float[] Min { get; set; }
        [DBField(ArraySize: 2)]
        public float[] Max { get; set; }
        public int ParentWorldMapID { get; set; }
        public int Flags { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class DungeonMapChunk
    {
        [DBKey]
        public int ID { get; set; }
        public int MapID { get; set; }
        public int WmoGroupID { get; set; }
        public int DungeonMapID { get; set; }
        public float MinZ { get; set; }
        public int DoodadPlacementID { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class DurabilityCosts
    {
        [DBKey]
        public int ID { get; set; }
        [DBField(ArraySize: 21)]
        public int[] WeaponSubClassCost { get; set; }
        [DBField(ArraySize: 8)]
        public int[] ArmorSubClassCost { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class DurabilityQuality
    {
        [DBKey]
        public int ID { get; set; }
        public float Data { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class EdgeGlowEffect
    {
        [DBKey]
        public int ID { get; set; }
        public float Field00 { get; set; }
        public float Field04 { get; set; }
        public float Field08 { get; set; }
        public float Field0C { get; set; }
        public float Field10 { get; set; }
        public float Field14 { get; set; }
        public float Field18 { get; set; }
        public float Field1C { get; set; }
        public float Field20 { get; set; }
        public byte Field24 { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class Emotes
    {
        [DBKey]
        public int ID { get; set; }
        public string EmoteSlashCommand { get; set; }
        public int AnimID { get; set; }
        public int EmoteFlags { get; set; }
        public int EmoteSpecProc { get; set; }
        public int EmoteSpecProcParam { get; set; }
        public int EventSoundID { get; set; }
        public int SpellVisualKitID { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class EmotesText
    {
        [DBKey]
        public int ID { get; set; }
        public string Name { get; set; }
        public int EmoteID { get; set; }
        [DBField(ArraySize: 16)]
        public int[] EmoteText { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class EmotesTextData
    {
        [DBKey]
        public int ID { get; set; }
        public string Text_lang { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class EmotesTextSound
    {
        [DBKey]
        public int ID { get; set; }
        public int EmotesTextID { get; set; }
        public int RaceID { get; set; }
        public int SexID { get; set; }
        public int SoundID { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class EnvironmentalDamage
    {
        [DBKey]
        public int ID { get; set; }
        public int EnumID { get; set; }
        public int VisualkitID { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class Exhaustion
    {
        [DBKey]
        public int ID { get; set; }
        public int Xp { get; set; }
        public float Factor { get; set; }
        public float OutdoorHours { get; set; }
        public float InnHours { get; set; }
        public string Name_lang { get; set; }
        public float Threshold { get; set; }
        public string CombatLogText { get; set; }
    }

    [DBTable(WDBXLib.Common.Constants.Expansion.WoD)]
    public class Faction
    {
        [DBKey]
        public int ID { get; set; }
        public int ReputationIndex { get; set; }
        [DBField(ArraySize: 4)]
        public int[] ReputationRaceMask { get; set; }
        [DBField(ArraySize: 4)]
        public int[] ReputationClassMask { get; set; }
        [DBField(ArraySize: 4)]
        public int[] ReputationBase { get; set; }
        [DBField(ArraySize: 4)]
        public int[] ReputationFlags { get; set; }
        public int ParentFactionID { get; set; }
        [DBField(ArraySize: 2)]
        public float[] ParentFactionMod { get; set; }
        [DBField(ArraySize: 2)]
        public int[] ParentFactionCap { get; set; }
        public string Name_lang { get; set; }
        public string Description_lang { get; set; }
        public int Expansion { get; set; }
        public int Flags { get; set; }
        public int FriendshipRepID { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class FactionGroup
    {
        [DBKey]
        public int ID { get; set; }
        public int MaskID { get; set; }
        public string InternalName { get; set; }
        public string Name_lang { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class FactionTemplate
    {
        [DBKey]
        public int ID { get; set; }
        public int Faction { get; set; }
        public int Flags { get; set; }
        public int FactionGroup { get; set; }
        public int FriendGroup { get; set; }
        public int EnemyGroup { get; set; }
        [DBField(ArraySize: 4)]
        public int[] Enemies { get; set; }
        [DBField(ArraySize: 4)]
        public int[] Friend { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class FileData
    {
        [DBKey]
        public int ID { get; set; }
        public string FileName { get; set; }
        public string Filepath { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class FileDataComplete
    {
        [DBKey]
        public int ID { get; set; }
        public string Path { get; set; }
        public string Name { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class FootprintTextures
    {
        [DBKey]
        public int ID { get; set; }
        public string FootstepFileName { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class FootstepTerrainLookup
    {
        [DBKey]
        public int ID { get; set; }
        public int CreatureFootstepID { get; set; }
        public int TerrainSoundID { get; set; }
        public int SoundID { get; set; }
        public int SoundIDSplash { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class FriendshipRepReaction
    {
        [DBKey]
        public int ID { get; set; }
        public int FriendshipRepID { get; set; }
        public int ReactionThreshold { get; set; }
        public string Reaction_lang { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class FriendshipReputation
    {
        [DBKey]
        public int ID { get; set; }
        public int FactionID { get; set; }
        public int TextureFileID { get; set; }
        public string Description_lang { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class FullScreenEffect
    {
        [DBKey]
        public int ID { get; set; }
        public float Field00 { get; set; }
        public float Field04 { get; set; }
        public float Field08 { get; set; }
        public float Field0C { get; set; }
        public float Field10 { get; set; }
        public float Field14 { get; set; }
        public float Field18 { get; set; }
        public float Field1C { get; set; }
        public float Field20 { get; set; }
        public float Field24 { get; set; }
        public float Field28 { get; set; }
        public float Field2C { get; set; }
        public float Field30 { get; set; }
        public float Field34 { get; set; }
        public float Field38 { get; set; }
        public float Field3C { get; set; }
        public float Field40 { get; set; }
        public float Field44 { get; set; }
        public float Field48 { get; set; }
        public int Field4C { get; set; }
        public int Field50 { get; set; }
        public float Field54 { get; set; }
        public float Field58 { get; set; }
        public float Field5C { get; set; }
        public float Field60 { get; set; }
        public float Field64 { get; set; }
        public float Field68 { get; set; }
        public float Field6C { get; set; }
        public float Field70 { get; set; }
        public float Field74 { get; set; }
        public float Field78 { get; set; }
        public float Field7C { get; set; }
        public float Field80 { get; set; }
        public float Field84 { get; set; }
        public float Field88 { get; set; }
        public byte Field8C { get; set; }
        public int Field8D { get; set; }
        public int Field91 { get; set; }
        public int Field95 { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class GameObjectArtKit
    {
        [DBKey]
        public int ID { get; set; }
        [DBField(ArraySize: 3)]
        public string[] TextureVariation { get; set; }
        [DBField(ArraySize: 4)]
        public string[] AttachModel { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class GameObjectDiffAnimMap
    {
        [DBKey]
        public int ID { get; set; }
        public int GameObjectDiffAnimID { get; set; }
        public int DifficultyID { get; set; }
        public int Animation { get; set; }
        public int AttachmentDisplayID { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class GameObjectDisplayInfo
    {
        [DBKey]
        public int ID { get; set; }
        public int FileDataID { get; set; }
        [DBField(ArraySize: 10)]
        public int[] Sound { get; set; }
        [DBField(ArraySize: 3)]
        public float[] GeoBoxMin { get; set; }
        [DBField(ArraySize: 3)]
        public float[] GeoBoxMax { get; set; }
        public int ObjectEffectPackageID { get; set; }
        public float OverrideLootEffectScale { get; set; }
        public float OverrideNameScale { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class GameObjectDisplayInfoXSoundKit
    {
        [DBKey]
        public int ID { get; set; }
        public byte Field00 { get; set; }
        public int Field01 { get; set; }
        public int Field05 { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class GameObjects
    {
        [DBKey]
        public int ID { get; set; }
        public int Field4 { get; set; }
        public int Field8 { get; set; }
        [DBField(ArraySize: 3)]
        public float[] FieldC { get; set; }
        [DBField(ArraySize: 4)]
        public float[] Field18 { get; set; }
        public float Field28 { get; set; }
        public int Field2C { get; set; }
        public int Field30 { get; set; }
        public int Field34 { get; set; }
        public int Field38 { get; set; }
        [DBField(ArraySize: 8)]
        public int[] Field3C { get; set; }
        public string Field5C { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class GameTables
    {
        [DBKey]
        public int ID { get; set; }
        public string Name { get; set; }
        public int NumRows { get; set; }
        public int NumColumns { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class GameTips
    {
        [DBKey]
        public int ID { get; set; }
        public string Text_lang { get; set; }
        public int Min_level { get; set; }
        public int Max_level { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class GarrAbility
    {
        [DBKey]
        public int ID { get; set; }
        public int Field4 { get; set; }
        public string Field8 { get; set; }
        public string FieldC { get; set; }
        public int Field10 { get; set; }
        public int Field11 { get; set; }
        public int Field12 { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class GarrAbilityCategory
    {
        [DBKey]
        public int ID { get; set; }
        public string Field00 { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class GarrAbilityEffect
    {
        [DBKey]
        public int ID { get; set; }
        public int Field4 { get; set; }
        public int Field8 { get; set; }
        public int FieldC { get; set; }
        public int Field10 { get; set; }
        public int Field14 { get; set; }
        public float Field18 { get; set; }
        public float Field1C { get; set; }
        public float Field20 { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class GarrBuilding
    {
        [DBKey]
        public int ID { get; set; }
        public int HordeGameObjectID { get; set; }
        public int AllianceGameObjectID { get; set; }
        public int FieldC { get; set; }
        public int Type { get; set; }
        public int Level { get; set; }
        public string NameAlliance { get; set; }
        public string NameHorde { get; set; }
        public string Description { get; set; }
        public string Tooltip { get; set; }
        public int BuildDuration { get; set; }
        public int CostCurrencyID { get; set; }
        public int CostCurrencyAmount { get; set; }
        public int HordeTexPrefixKitID { get; set; }
        public int AllianceTexPrefixKitID { get; set; }
        public int IconFileDataID { get; set; }
        public int BonusAmount { get; set; }
        public int Flags { get; set; }
        public int AllianceActivationScenePackageID { get; set; }
        public int HordeActivationScenePackageID { get; set; }
        public int MaxShipments { get; set; }
        public int FollowerRequiredGarrAbilityID { get; set; }
        public int FollowerGarrAbilityEffectID { get; set; }
        public int CostMoney { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class GarrBuildingDoodadSet
    {
        [DBKey]
        public int ID { get; set; }
        public int Field4 { get; set; }
        public int Field8 { get; set; }
        public int FieldC { get; set; }
        public int Field10 { get; set; }
        public int Field14 { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class GarrBuildingPlotInst
    {
        [DBKey]
        public int ID { get; set; }
        [DBField(ArraySize: 2)]
        public float[] Field00 { get; set; }
        public ushort Field08 { get; set; }
        public ushort Field0A { get; set; }
        public byte Field0C { get; set; }
        public int Field0D { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class GarrClassSpec
    {
        [DBKey]
        public int ID { get; set; }
        [DBField(ArraySize: 3)]
        public string[] Field4 { get; set; }
        public int Field8 { get; set; }
        public int FieldC { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class GarrClassSpecPlayerCond
    {
        [DBKey]
        public int ID { get; set; }
        public int Field00 { get; set; }
        public string Field04 { get; set; }
        public byte Field08 { get; set; }
        public int Field09 { get; set; }
        public int Field0D { get; set; }
        public int Field11 { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class GarrEncounter
    {
        [DBKey]
        public int ID { get; set; }
        public int Field4 { get; set; }
        public string Field8 { get; set; }
        public float FieldC { get; set; }
        public float Field10 { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class GarrEncounterSetXEncounter
    {
        [DBKey]
        public int ID { get; set; }
        public int Field00 { get; set; }
        public int Field04 { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class GarrEncounterXMechanic
    {
        [DBKey]
        public int ID { get; set; }
        public int Field4 { get; set; }
        public int Field8 { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class GarrFamilyName
    {
        [DBKey]
        public int ID { get; set; }
        public string Field4 { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class GarrFollItemSet
    {
        [DBKey]
        public int ID { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class GarrFollItemSetMember
    {
        [DBKey]
        public int ID { get; set; }
        public int Field4 { get; set; }
        public int Field8 { get; set; }
        public int FieldC { get; set; }
        public int Field10 { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class GarrFollower
    {
        [DBKey]
        public int ID { get; set; }
        public int Field4 { get; set; }
        public int Field8 { get; set; }
        public int FieldC { get; set; }
        public int Field10 { get; set; }
        public int Field14 { get; set; }
        public int Field18 { get; set; }
        public int Field1C { get; set; }
        public int Field20 { get; set; }
        public int Field24 { get; set; }
        public int Field28 { get; set; }
        public int Field2C { get; set; }
        public int Field30 { get; set; }
        public int Field34 { get; set; }
        public int Field38 { get; set; }
        public int Field3C { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class GarrFollowerLevelXP
    {
        [DBKey]
        public int ID { get; set; }
        public int Field4 { get; set; }
        public int Field8 { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class GarrFollowerQuality
    {
        [DBKey]
        public int ID { get; set; }
        [DBField(Padding: 1)]
        public ushort Field04 { get; set; }
        public byte Field06 { get; set; }
        public byte Field07 { get; set; }
        public byte Field08 { get; set; }
        public byte Field09 { get; set; }
        public int Field0A { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class GarrFollowerSetXFollower
    {
        [DBKey]
        public int ID { get; set; }
        public int Field00 { get; set; }
        public int Field04 { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class GarrFollowerType
    {
        [DBKey]
        public int ID { get; set; }
        public ushort Field00 { get; set; }
        public byte Field02 { get; set; }
        public byte Field03 { get; set; }
        public byte Field04 { get; set; }
        public byte Field05 { get; set; }
        public byte Field06 { get; set; }
        public byte Field07 { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class GarrFollowerUICreature
    {
        [DBKey]
        public int ID { get; set; }
        public float Field04 { get; set; }
        public ushort Field08 { get; set; }
        public byte Field0A { get; set; }
        public byte Field0B { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class GarrFollowerXAbility
    {
        [DBKey]
        public int ID { get; set; }
        public int Field4 { get; set; }
        public int Field8 { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class GarrFollSupportSpell
    {
        [DBKey]
        public int ID { get; set; }
        public int Field00 { get; set; }
        public int Field04 { get; set; }
        public byte Field08 { get; set; }
        public int Field09 { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class GarrGivenName
    {
        [DBKey]
        public int ID { get; set; }
        public string Field4 { get; set; }
        public int Field8 { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class GarrMechanic
    {
        [DBKey]
        public int ID { get; set; }
        public int Field4 { get; set; }
        public float Field8 { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class GarrMechanicSetXMechanic
    {
        public byte Field00 { get; set; }
        [DBKey]
        public int ID { get; set; }
        public int Field05 { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class GarrMechanicType
    {
        [DBKey]
        public int ID { get; set; }
        public int Field4 { get; set; }
        public string Field8 { get; set; }
        public string FieldC { get; set; }
        public int Field10 { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class GarrMission
    {
        [DBKey]
        public int ID { get; set; }
        public int Field4 { get; set; }
        public int Field8 { get; set; }
        public int FieldC { get; set; }
        public int Field10 { get; set; }
        public int Field14 { get; set; }
        public int Field18 { get; set; }
        public int Field1C { get; set; }
        public int Field20 { get; set; }
        [DBField(ArraySize: 3)]
        public int[] Field24 { get; set; }
        public int Field30 { get; set; }
        public int Field34 { get; set; }
        [DBField(ArraySize: 3)]
        public int[] Field38 { get; set; }
        [DBField(ArraySize: 3)]
        public int[] Field44 { get; set; }
        public int Field50 { get; set; }
        public int Field54 { get; set; }
        public int Field58 { get; set; }
        public int Field5C { get; set; }
        public int Field60 { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class GarrMissionReward
    {
        [DBKey]
        public int ID { get; set; }
        public int Field04 { get; set; }
        public int Field08 { get; set; }
        public ushort Field0C { get; set; }
        public ushort Field0E { get; set; }
        public ushort Field10 { get; set; }
        public byte Field12 { get; set; }
        public byte Field13 { get; set; }
        public byte Field14 { get; set; }
        public byte Field15 { get; set; }
        public byte Field16 { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class GarrMissionTexture
    {
        [DBKey]
        public int ID { get; set; }
        [DBField(ArraySize: 2)]
        public float[] Field00 { get; set; }
        public ushort Field08 { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class GarrMissionType
    {
        [DBKey]
        public int ID { get; set; }
        public string Field00 { get; set; }
        public ushort Field04 { get; set; }
        public ushort Field06 { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class GarrMissionXEncounter
    {
        [DBKey]
        public int ID { get; set; }
        public int Field4 { get; set; }
        public int Field8 { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class GarrMissionXFollower
    {
        [DBKey]
        public int ID { get; set; }
        public int Field00 { get; set; }
        public int Field04 { get; set; }
        public int Field08 { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class GarrMssnBonusAbility
    {
        [DBKey]
        public int ID { get; set; }
        public float Field00 { get; set; }
        public int Field04 { get; set; }
        public ushort Field08 { get; set; }
        public byte Field0A { get; set; }
        public byte Field0B { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class GarrPlot
    {
        [DBKey]
        public int ID { get; set; }
        public int GarrPlotUICategoryID { get; set; }
        public int PlotType { get; set; }
        public int Flags { get; set; }
        public string Name { get; set; }
        public int MinCount { get; set; }
        public int MaxCount { get; set; }
        public int AllianceConstructionGameObjectID { get; set; }
        public int HordeConstructionGameObjectID { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class GarrPlotBuilding
    {
        [DBKey]
        public int ID { get; set; }
        public int Field4 { get; set; }
        public int Field8 { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class GarrPlotInstance
    {
        [DBKey]
        public int ID { get; set; }
        public int Field4 { get; set; }
        public string Field8 { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class GarrPlotUICategory
    {
        [DBKey]
        public int ID { get; set; }
        public string Field4 { get; set; }
        public int Field8 { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class GarrSiteLevel
    {
        [DBKey]
        public int ID { get; set; }
        public int Field4 { get; set; }
        public int Field8 { get; set; }
        public int FieldC { get; set; }
        public int Field10 { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class GarrSiteLevelPlotInst
    {
        [DBKey]
        public int ID { get; set; }
        public int Field4 { get; set; }
        public int Field8 { get; set; }
        [DBField(ArraySize: 2)]
        public float[] FieldC { get; set; }
        public int Field14 { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class GarrSpecialization
    {
        [DBKey]
        public int ID { get; set; }
        public int Field4 { get; set; }
        public int Field8 { get; set; }
        public int FieldC { get; set; }
        public int Field10 { get; set; }
        [DBField(ArraySize: 2)]
        public float[] Field14 { get; set; }
        public string Field1C { get; set; }
        public string Field20 { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class Garrstring
    {
        [DBKey]
        public int ID { get; set; }
        public string Field00 { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class GarrTalent
    {
        public int Field00 { get; set; }
        public string Field04 { get; set; }
        public string Field08 { get; set; }
        public int Field0C { get; set; }
        public byte Field10 { get; set; }
        public byte Field11 { get; set; }
        public byte Field12 { get; set; }
        [DBKey]
        public int ID { get; set; }
        public int Field17 { get; set; }
        public int Field1B { get; set; }
        public int Field1F { get; set; }
        public int Field23 { get; set; }
        public int Field27 { get; set; }
        public int Field2B { get; set; }
        public int Field2F { get; set; }
        public int Field33 { get; set; }
        public int Field37 { get; set; }
        public int Field3B { get; set; }
        public int Field3F { get; set; }
        public int Field43 { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class GarrTalentTree
    {
        [DBKey]
        public int ID { get; set; }
        public byte Field00 { get; set; }
        public byte Field01 { get; set; }
        public int Field02 { get; set; }
        public int Field06 { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class GarrType
    {
        [DBKey]
        public int ID { get; set; }
        public int Field00 { get; set; }
        public int Field04 { get; set; }
        public int Field08 { get; set; }
        public int Field0C { get; set; }
        public int Field10 { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class GarrUiAnimClassInfo
    {
        [DBKey]
        public int ID { get; set; }
        public int GarrClassSpecID { get; set; }
        public int SpellVisualID { get; set; }
        public int MovementType { get; set; }
        public float ImpactDelaySecs { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class GarrUiAnimRaceInfo
    {
        [DBKey]
        public int ID { get; set; }
        public int ChrRaceID { get; set; }
        public float Scale { get; set; }
        public float Height { get; set; }
        public float SingleModelScale { get; set; }
        public float SingleModelHeight { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class GemProperties
    {
        [DBKey]
        public int Id { get; set; }
        public int Enchant_id { get; set; }
        public int Maxcount_inv { get; set; }
        public int Maxcount_item { get; set; }
        public int Type { get; set; }
        public int Min_item_level { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class Globalstrings
    {
        [DBKey]
        public int ID { get; set; }
        public string Field00 { get; set; }
        public string Field04 { get; set; }
        public byte Field08 { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class GlueScreenEmote
    {
        [DBKey]
        public int ID { get; set; }
        public int ClassId { get; set; }
        public int RaceId { get; set; }
        public int SexId { get; set; }
        public int LeftHandItemType { get; set; }
        public int RightHandItemType { get; set; }
        public int AnimKitId { get; set; }
        public int SpellVisualKitId { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class GlyphBindableSpell
    {
        [DBKey]
        public int ID { get; set; }
        public int Field00 { get; set; }
        public ushort Field04 { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class GlyphExclusiveCategory
    {
        [DBKey]
        public int ID { get; set; }
        public string Field4 { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class GlyphProperties
    {
        [DBKey]
        public int Id { get; set; }
        public int SpellID { get; set; }
        public int GlyphType { get; set; }
        public int SpellIconID { get; set; }
        public int GlyphExclusiveCategoryID { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class GlyphRequiredSpec
    {
        [DBKey]
        public int ID { get; set; }
        public int Field4 { get; set; }
        public int Field8 { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class GlyphSlot
    {
        [DBKey]
        public int Id { get; set; }
        public int Type { get; set; }
        public int Tooltip { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class GMSurveyAnswers
    {
        [DBKey]
        public int ID { get; set; }
        public int Sort_Index { get; set; }
        public int GMSurveyQuestionID { get; set; }
        public string Answer_lang { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class GMSurveyCurrentSurvey
    {
        [DBKey]
        public int LANGID { get; set; }
        public int GMSURVEY_ID { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class GMSurveyQuestions
    {
        [DBKey]
        public int ID { get; set; }
        public string Question_lang { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class GMSurveySurveys
    {
        [DBKey]
        public int ID { get; set; }
        [DBField(ArraySize: 15)]
        public int[] Q { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class GMTicketCategory
    {
        [DBKey]
        public int ID { get; set; }
        public string Category_lang { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class GroundEffectDoodad
    {
        [DBKey]
        public int ID { get; set; }
        public string Doodadpath { get; set; }
        public int Flags { get; set; }
        public float Animscale { get; set; }
        public float Pushscale { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class GroundEffectTexture
    {
        [DBKey]
        public int ID { get; set; }
        [DBField(ArraySize: 4)]
        public int[] DoodadId { get; set; }
        [DBField(ArraySize: 4)]
        public int[] DoodadWeight { get; set; }
        public int Density { get; set; }
        public int Sound { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class GroupFinderActivity
    {
        [DBKey]
        public int ID { get; set; }
        public int Field4 { get; set; }
        public int Field8 { get; set; }
        public int FieldC { get; set; }
        public int Field10 { get; set; }
        public int Field14 { get; set; }
        public int Field18 { get; set; }
        public int Field1C { get; set; }
        public int Field20 { get; set; }
        public int Field24 { get; set; }
        public int Field28 { get; set; }
        public int Field2C { get; set; }
        public int Field30 { get; set; }
        public string Field34 { get; set; }
        public string Field38 { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class GroupFinderActivityGrp
    {
        [DBKey]
        public int ID { get; set; }
        public string Field4 { get; set; }
        public int Field8 { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class GroupFinderCategory
    {
        [DBKey]
        public int ID { get; set; }
        public string Field4 { get; set; }
        public int Field8 { get; set; }
        public int Field12 { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class GtArmorMitigationByLvl
    {
        [DBKey]
        public int ID { get; set; }
        public float Data { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class GtBarberShopCostBase
    {
        [DBKey]
        public int ID { get; set; }
        public float Data { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class GtBattlePetTypeDamageMod
    {
        [DBKey]
        public int ID { get; set; }
        public float Data { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class GtBattlePetXP
    {
        [DBKey]
        public int ID { get; set; }
        public float Data { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class GtChanceToMeleeCrit
    {
        [DBKey]
        public int ID { get; set; }
        public float Data { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class GtChanceToMeleeCritBase
    {
        [DBKey]
        public int ID { get; set; }
        public float Data { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class GtChanceToSpellCrit
    {
        [DBKey]
        public int ID { get; set; }
        public float Data { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class GtChanceToSpellCritBase
    {
        [DBKey]
        public int ID { get; set; }
        public float Data { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class GtCombatRatings
    {
        [DBKey]
        public int ID { get; set; }
        public float Data { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class GtItemSocketCostPerLevel
    {
        [DBKey]
        public int ID { get; set; }
        public float Data { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class GtNPCManaCostScaler
    {
        [DBKey]
        public int ID { get; set; }
        public float Data { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class GtNpcTotalHp
    {
        [DBKey(AutoGenerated: true)]
        public int ID { get; set; }
        public float HP { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class GtNpcTotalHpExp1
    {
        [DBKey(AutoGenerated: true)]
        public int ID { get; set; }
        public float HP { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class GtNpcTotalHpExp2
    {
        [DBKey(AutoGenerated: true)]
        public int ID { get; set; }
        public float HP { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class GtNpcTotalHpExp3
    {
        [DBKey(AutoGenerated: true)]
        public int ID { get; set; }
        public float HP { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class GtNpcTotalHpExp4
    {
        [DBKey(AutoGenerated: true)]
        public int ID { get; set; }
        public float HP { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class GtNpcTotalHpExp5
    {
        [DBKey(AutoGenerated: true)]
        public int ID { get; set; }
        public float HP { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class GtOCTBaseHPByClass
    {
        [DBKey]
        public int ID { get; set; }
        public float Data { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class GtOCTBaseMPByClass
    {
        [DBKey]
        public int ID { get; set; }
        public float Data { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class GtOCTClassCombatRatingScalar
    {
        [DBKey]
        public int ID { get; set; }
        public float Data { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class GtOCTHpPerStamina
    {
        [DBKey]
        public int ID { get; set; }
        public float Data { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class GtOCTLevelExperience
    {
        [DBKey]
        public int ID { get; set; }
        public float Data { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class GtRegenMPPerSpt
    {
        [DBKey]
        public int ID { get; set; }
        public float Data { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class GtResilienceDR
    {
        [DBKey]
        public int ID { get; set; }
        public float Data { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class GtSpellScaling
    {
        [DBKey]
        public int ID { get; set; }
        public float Data { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class GuildColorBackground
    {
        [DBKey]
        public int ColorID { get; set; }
        public byte Red { get; set; }
        public byte Green { get; set; }
        public byte Blue { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class GuildColorBorder
    {
        [DBKey]
        public int ColorID { get; set; }
        public byte Red { get; set; }
        public byte Green { get; set; }
        public byte Blue { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class GuildColorEmblem
    {
        [DBKey]
        public int ColorID { get; set; }
        public byte Red { get; set; }
        public byte Green { get; set; }
        public byte Blue { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class GuildPerkSpells
    {
        [DBKey]
        public int Id { get; set; }
        public int GuildLevel { get; set; }
        public int SpellID { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class Heirloom
    {
        [DBKey]
        public int ID { get; set; }
        public int ItemId { get; set; }
        public int Flags { get; set; }
        public string SourceText { get; set; }
        public int Source { get; set; }
        [DBField(ArraySize: 2)]
        public int[] OldItem { get; set; }
        public int NextDifficultyItemId { get; set; }
        [DBField(ArraySize: 2)]
        public ushort[] UpgradeItemId { get; set; }
        [DBField(ArraySize: 2)]
        public ushort[] ItemBonusListId { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class HelmetAnimScaling
    {
        [DBKey]
        public int ID { get; set; }
        public int HelmetGeosetVisDataID { get; set; }
        public int RaceID { get; set; }
        public float Amount { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class HelmetGeosetVisData
    {
        [DBKey]
        public int ID { get; set; }
        [DBField(ArraySize: 7)]
        public int[] HideGeoset { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class HighlightColor
    {
        [DBKey]
        public int ID { get; set; }
        public int Field00 { get; set; }
        public int Field04 { get; set; }
        public int Field08 { get; set; }
        public byte Field0C { get; set; }
        public byte Field0D { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class HolidayDescriptions
    {
        [DBKey]
        public int ID { get; set; }
        public string Description_lang { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class HolidayNames
    {
        [DBKey]
        public int ID { get; set; }
        public string Name_lang { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class Holidays
    {
        [DBKey]
        public int ID { get; set; }
        [DBField(ArraySize: 10)]
        public int[] Duration { get; set; }
        [DBField(ArraySize: 16)]
        public int[] Date { get; set; }
        public int Region { get; set; }
        public int Looping { get; set; }
        [DBField(ArraySize: 10)]
        public int[] CalendarFlags { get; set; }
        public int HolidayNameID { get; set; }
        public int HolidayDescriptionID { get; set; }
        public string TextureFileName { get; set; }
        public int Priority { get; set; }
        public int CalendarFilterType { get; set; }
        public int Flags { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class ImportPriceArmor
    {
        [DBKey]
        public int ID { get; set; }
        public float ClothModifier { get; set; }
        public float LeatherModifier { get; set; }
        public float ChainModifier { get; set; }
        public float PlateModifier { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class ImportPriceQuality
    {
        [DBKey]
        public int ID { get; set; }
        public float Data { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class ImportPriceShield
    {
        [DBKey]
        public int ID { get; set; }
        public float Data { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class ImportPriceWeapon
    {
        [DBKey]
        public int ID { get; set; }
        public float Data { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class InvasionClientData
    {
        public string Field00 { get; set; }
        [DBField(ArraySize: 2)]
        public float[] Field04 { get; set; }
        [DBKey]
        public int ID { get; set; }
        public int Field10 { get; set; }
        public int Field14 { get; set; }
        public int Field18 { get; set; }
        public int Field1C { get; set; }
        public int Field20 { get; set; }
        public int Field24 { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class Item
    {
        [DBKey]
        public int ID { get; set; }
        public int Class { get; set; }
        public int Subclass { get; set; }
        public int SoundOverrideID { get; set; }
        public int MaterialID { get; set; }
        public int InventoryType { get; set; }
        public int Sheathe { get; set; }
        public int FileDataID { get; set; }
        public int GroupSoundsId { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class ItemAppearance
    {
        [DBKey]
        public int ID { get; set; }
        public int Field4 { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class ItemAppearanceXUiCamera
    {
        [DBKey]
        public int ID { get; set; }
        public ushort Field00 { get; set; }
        public ushort Field02 { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class ItemArmorQuality
    {
        [DBKey]
        public int ID { get; set; }
        [DBField(ArraySize: 7)]
        public float[] Qualitymod { get; set; }
        public int ItemLevel { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class ItemArmorShield
    {
        [DBKey]
        public int ID { get; set; }
        public int ItemLevel { get; set; }
        [DBField(ArraySize: 7)]
        public float[] Quality { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class ItemArmorTotal
    {
        [DBKey]
        public int ID { get; set; }
        public int ItemLevel { get; set; }
        public float Cloth { get; set; }
        public float Leather { get; set; }
        public float Mail { get; set; }
        public float Plate { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class ItemBagFamily
    {
        [DBKey]
        public int ID { get; set; }
        public string Name_lang { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class ItemBonus
    {
        [DBKey]
        public int ID { get; set; }
        public int Field4 { get; set; }
        public int Field8 { get; set; }
        [DBField(ArraySize: 2)]
        public int[] FieldC { get; set; }
        public int Field14 { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class ItemBonusListLevelDelta
    {
        public ushort Field00 { get; set; }
        [DBKey]
        public int ID { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class ItemBonusTreeNode
    {
        [DBKey]
        public int ID { get; set; }
        public ushort Field00 { get; set; }
        public ushort Field02 { get; set; }
        public ushort Field04 { get; set; }
        public byte Field06 { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class ItemChildEquipment
    {
        [DBKey]
        public int ID { get; set; }
        public int Field00 { get; set; }
        public int Field04 { get; set; }
        public byte Field08 { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class ItemClass
    {
        [DBKey]
        public int ClassID { get; set; }
        public int Flags { get; set; }
        public float PriceModifier { get; set; }
        public string ClassName_lang { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class ItemContextPickerEntry
    {
        [DBKey]
        public int ID { get; set; }
        public byte Field00 { get; set; }
        public byte Field01 { get; set; }
        public int Field02 { get; set; }
        public int Field06 { get; set; }
        public int Field0A { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class ItemCurrencyCost
    {
        [DBKey]
        public int ID { get; set; }
        public int Field4 { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class ItemDamageAmmo
    {
        [DBKey]
        public int ID { get; set; }
        [DBField(ArraySize: 7)]
        public float[] Quality { get; set; }
        public int ItemLevel { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class ItemDamageOneHand
    {
        [DBKey]
        public int ID { get; set; }
        [DBField(ArraySize: 7)]
        public float[] Quality { get; set; }
        public int ItemLevel { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class ItemDamageOneHandCaster
    {
        [DBKey]
        public int ID { get; set; }
        [DBField(ArraySize: 7)]
        public float[] Quality { get; set; }
        public int ItemLevel { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class ItemDamageRanged
    {
        [DBKey]
        public int ID { get; set; }
        [DBField(ArraySize: 7)]
        public float[] Quality { get; set; }
        public int ItemLevel { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class ItemDamageThrown
    {
        [DBKey]
        public int ID { get; set; }
        [DBField(ArraySize: 7)]
        public float[] Quality { get; set; }
        public int ItemLevel { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class ItemDamageTwoHand
    {
        [DBKey]
        public int ID { get; set; }
        [DBField(ArraySize: 7)]
        public float[] Quality { get; set; }
        public int ItemLevel { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class ItemDamageTwoHandCaster
    {
        [DBKey]
        public int ID { get; set; }
        [DBField(ArraySize: 7)]
        public float[] Quality { get; set; }
        public int ItemLevel { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class ItemDamageWand
    {
        [DBKey]
        public int ID { get; set; }
        [DBField(ArraySize: 7)]
        public float[] Quality { get; set; }
        public int ItemLevel { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class ItemDisenchantLoot
    {
        [DBKey]
        public int ID { get; set; }
        public int Class { get; set; }
        public int Subclass { get; set; }
        public int Quality { get; set; }
        public int MinLevel { get; set; }
        public int MaxLevel { get; set; }
        public int SkillRequired { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class ItemDisplayInfo
    {
        [DBKey]
        public int ID { get; set; }
        [DBField(ArraySize: 2)]
        public string[] ModelName { get; set; }
        [DBField(ArraySize: 2)]
        public int[] ModelTexture { get; set; }
        [DBField(ArraySize: 3)]
        public int[] GeosetGroup { get; set; }
        public int Flags { get; set; }
        public int SpellVisualID { get; set; }
        [DBField(ArraySize: 2)]
        public int[] HelmetGeosetVis { get; set; }
        [DBField(ArraySize: 9)]
        public int[] Texture { get; set; }
        public int ItemVisual { get; set; }
        public int ParticleColorID { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class ItemDisplayInfoMaterialRes
    {
        [DBKey]
        public int ID { get; set; }
        public int Field00 { get; set; }
        public int Field04 { get; set; }
        public byte Field08 { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class ItemDisplayXUiCamera
    {
        [DBKey]
        public int ID { get; set; }
        public int Field00 { get; set; }
        public ushort Field04 { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class ItemEffect
    {
        [DBKey]
        public int ID { get; set; }
        public int Field4 { get; set; }
        public int Field8 { get; set; }
        public int FieldC { get; set; }
        public int Field10 { get; set; }
        public int Field14 { get; set; }
        public int Field18 { get; set; }
        public int Field1C { get; set; }
        public int Field20 { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class ItemExtendedCost
    {
        [DBKey]
        public int ID { get; set; }
        public int RequiredArenaSlot { get; set; }
        [DBField(ArraySize: 5)]
        public int[] RequiredItem { get; set; }
        [DBField(ArraySize: 5)]
        public int[] RequiredItemCount { get; set; }
        public int RequiredPersonalArenaRating { get; set; }
        public int ItemPurchaseGroup { get; set; }
        [DBField(ArraySize: 5)]
        public int[] RequiredCurrency { get; set; }
        [DBField(ArraySize: 5)]
        public int[] RequiredCurrencyCount { get; set; }
        public int RequiredFactionId { get; set; }
        public int RequiredFactionStanding { get; set; }
        public int RequirementFlags { get; set; }
        public int RequiredAchievement { get; set; }
        public int RequiredMoney { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class ItemGroupSounds
    {
        [DBKey]
        public int ID { get; set; }
        [DBField(ArraySize: 4)]
        public int[] Sound { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class ItemLimitCategory
    {
        [DBKey]
        public int ID { get; set; }
        public string Name_lang { get; set; }
        public int Quantity { get; set; }
        public int Flags { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class ItemLimitCategoryCondition
    {
        [DBKey]
        public int ID { get; set; }
        public byte Field00 { get; set; }
        public int Field01 { get; set; }
        public int Field05 { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class ItemModifiedAppearance
    {
        [DBKey]
        public int ID { get; set; }
        public int Field4 { get; set; }
        public int Field8 { get; set; }
        public int FieldC { get; set; }
        public int Field10 { get; set; }
        public int Field14 { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class ItemModifiedAppearanceExtra
    {
        [DBKey]
        public int ID { get; set; }
        public int Field00 { get; set; }
        public int Field04 { get; set; }
        public byte Field08 { get; set; }
        public byte Field09 { get; set; }
        public byte Field0A { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class ItemNameDescription
    {
        [DBKey]
        public int ID { get; set; }
        public string Description_lang { get; set; }
        public int Color { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class ItemPetFood
    {
        [DBKey]
        public int ID { get; set; }
        public string Name_lang { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class ItemPriceBase
    {
        [DBKey]
        public int ID { get; set; }
        public int ItemLevel { get; set; }
        public float Armor { get; set; }
        public float Weapon { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class ItemPurchaseGroup
    {
        [DBKey]
        public int ID { get; set; }
        [DBField(ArraySize: 8)]
        public int[] ItemID { get; set; }
        public string Name_lang { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class ItemRandomProperties
    {
        [DBKey]
        public int ID { get; set; }
        public string Name { get; set; }
        [DBField(ArraySize: 5)]
        public int[] Enchantment { get; set; }
        public string Name_lang { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class ItemRandomSuffix
    {
        [DBKey]
        public int ID { get; set; }
        public string Name_lang { get; set; }
        public string InternalName { get; set; }
        [DBField(ArraySize: 5)]
        public int[] Enchantment { get; set; }
        [DBField(ArraySize: 5)]
        public int[] AllocationPct { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class ItemRangedDisplayInfo
    {
        [DBKey]
        public int ID { get; set; }
        public int Field00 { get; set; }
        public int Field04 { get; set; }
        public int Field08 { get; set; }
        public int Field0C { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class ItemSearchName
    {
        [DBKey]
        public int ID { get; set; }
        public string Field00 { get; set; }
        [DBField(ArraySize: 3)]
        public int[] Field04 { get; set; }
        public int Field10 { get; set; }
        public int Field14 { get; set; }
        public ushort Field18 { get; set; }
        public ushort Field1A { get; set; }
        public ushort Field1C { get; set; }
        public ushort Field1E { get; set; }
        public byte Field20 { get; set; }
        public byte Field21 { get; set; }
        public byte Field22 { get; set; }
        public byte Field23 { get; set; }
        public int Field24 { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class ItemSet
    {
        [DBKey]
        public int ID { get; set; }
        public string Name_lang { get; set; }
        [DBField(ArraySize: 17)]
        public int[] ItemID { get; set; }
        public int RequiredSkill { get; set; }
        public int RequiredSkillRank { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class ItemSetSpell
    {
        [DBKey]
        public int ID { get; set; }
        public int ItemSetID { get; set; }
        public int SpellID { get; set; }
        public int Threshold { get; set; }
        public int ChrSpecID { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class Item_sparse
    {
        [DBKey]
        public int ID { get; set; }
        public uint Quality { get; set; }
        [DBField(ArraySize: 3)]
        public uint[] Flags { get; set; }
        public float Unk1 { get; set; }
        public float Unk2 { get; set; }
        public uint BuyCount { get; set; }
        public uint BuyPrice { get; set; }
        public uint SellPrice { get; set; }
        public uint InventoryType { get; set; }
        public int AllowableClass { get; set; }
        public int AllowableRace { get; set; }
        public uint ItemLevel { get; set; }
        public int RequiredLevel { get; set; }
        public uint RequiredSkill { get; set; }
        public uint RequiredSkillRank { get; set; }
        public uint RequiredSpell { get; set; }
        public uint RequiredHonorRank { get; set; }
        public uint RequiredCityRank { get; set; }
        public uint RequiredReputationFaction { get; set; }
        public uint RequiredReputationRank { get; set; }
        public uint MaxCount { get; set; }
        public uint Stackable { get; set; }
        public uint ContainerSlots { get; set; }
        [DBField(ArraySize: 10)]
        public int[] ItemStatType { get; set; }
        [DBField(ArraySize: 10)]
        public int[] ItemStatValue { get; set; }
        [DBField(ArraySize: 10)]
        public int[] ItemStatAllocation { get; set; }
        [DBField(ArraySize: 10)]
        public float[] ItemStatSocketCostMultiplier { get; set; }
        public uint ScalingStatDistribution { get; set; }
        public uint DamageType { get; set; }
        public uint Delay { get; set; }
        public float RangedModRange { get; set; }
        public uint Bonding { get; set; }
        public string Name { get; set; }
        public string Name2 { get; set; }
        public string Name3 { get; set; }
        public string Name4 { get; set; }
        public string Description { get; set; }
        public uint PageText { get; set; }
        public uint LanguageID { get; set; }
        public uint PageMaterial { get; set; }
        public uint StartQuest { get; set; }
        public uint LockID { get; set; }
        public int Material { get; set; }
        public uint Sheath { get; set; }
        public uint RandomProperty { get; set; }
        public uint RandomSuffix { get; set; }
        public uint ItemSet { get; set; }
        public uint Area { get; set; }
        public uint Map { get; set; }
        public uint BagFamily { get; set; }
        public uint TotemCategory { get; set; }
        [DBField(ArraySize: 3)]
        public uint[] SocketColor { get; set; }
        public uint SocketBonus { get; set; }
        public uint GemProperties { get; set; }
        public float ArmorDamageModifier { get; set; }
        public uint Duration { get; set; }
        public uint ItemLimitCategory { get; set; }
        public uint HolidayID { get; set; }
        public float StatScalingFactor { get; set; }
        public uint CurrencySubstitutionID { get; set; }
        public uint CurrencySubstitutionCount { get; set; }
        public uint ItemNameDescriptionID { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class ItemSpec
    {
        [DBKey]
        public int ID { get; set; }
        public int MinLevel { get; set; }
        public int MaxLevel { get; set; }
        public int ItemType { get; set; }
        public int PrimaryStat { get; set; }
        public int SecondaryStat { get; set; }
        public int SpecializationID { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class ItemSpecOverride
    {
        [DBKey]
        public int ID { get; set; }
        public int ItemID { get; set; }
        public int SpecID { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class ItemSubClass
    {
        [DBKey]
        public int ID { get; set; }
        public int ClassID { get; set; }
        public int SubClassID { get; set; }
        public int PrerequisiteProficiency { get; set; }
        public int PostrequisiteProficiency { get; set; }
        public int Flags { get; set; }
        public int DisplayFlags { get; set; }
        public int WeaponParrySeq { get; set; }
        public int WeaponReadySeq { get; set; }
        public int WeaponAttackSeq { get; set; }
        public int WeaponSwingSize { get; set; }
        public string DisplayName_lang { get; set; }
        public string VerboseName_lang { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class ItemSubClassMask
    {
        [DBKey]
        public int ID { get; set; }
        public int ClassID { get; set; }
        public int Mask { get; set; }
        public string Name_lang { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class ItemToBattlePet
    {
        [DBKey]
        public int ID { get; set; }
        public int Field4 { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class ItemToBattlePetSpecies
    {
        [DBKey]
        public int ID { get; set; }
        public int BattlePetSpeciesId { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class ItemToMountSpell
    {
        [DBKey]
        public int ID { get; set; }
        public int Field4 { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class ItemUpgrade
    {
        [DBKey]
        public int ID { get; set; }
        public int Field4 { get; set; }
        public int Field8 { get; set; }
        public int FieldC { get; set; }
        public int Field10 { get; set; }
        public int Field14 { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class ItemUpgradePath
    {
        [DBKey]
        public int Id { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class ItemVisualEffects
    {
        [DBKey]
        public int ID { get; set; }
        public string Model { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class ItemVisuals
    {
        [DBKey]
        public int ID { get; set; }
        [DBField(ArraySize: 5)]
        public int[] Slot { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class ItemXBonusTree
    {
        [DBKey]
        public int ID { get; set; }
        public int Field00 { get; set; }
        public ushort Field04 { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class JournalEncounter
    {
        [DBKey]
        public int ID { get; set; }
        public int DungeonMapID { get; set; }
        public int WorldMapAreaID { get; set; }
        [DBField(ArraySize: 2)]
        public float[] Map { get; set; }
        public int FirstSectionID { get; set; }
        public int JournalInstanceID { get; set; }
        public int OrderIndex { get; set; }
        public int DifficultyMask { get; set; }
        public string Name_lang { get; set; }
        public string Description_lang { get; set; }
        public int Flags { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class JournalEncounterCreature
    {
        [DBKey]
        public int ID { get; set; }
        public int JournalEncounterID { get; set; }
        public int CreatureDisplayInfoID { get; set; }
        public int OrderIndex { get; set; }
        public int FileDataID { get; set; }
        public string Name_lang { get; set; }
        public string Description_lang { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class JournalEncounterItem
    {
        [DBKey]
        public int ID { get; set; }
        public int JournalEncounterID { get; set; }
        public int ItemID { get; set; }
        public int DifficultyMask { get; set; }
        public int FactionMask { get; set; }
        public int Flags { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class JournalEncounterSection
    {
        [DBKey]
        public int ID { get; set; }
        public int JournalEncounterID { get; set; }
        public int NextSiblingSectionID { get; set; }
        public int FirstChildSectionID { get; set; }
        public int ParentSectionID { get; set; }
        public int OrderIndex { get; set; }
        public int Type { get; set; }
        public int Flags { get; set; }
        public int IconFlags { get; set; }
        public string Title_lang { get; set; }
        public string BodyText_lang { get; set; }
        public int DifficultyMask { get; set; }
        public int IconCreatureDisplayInfoID { get; set; }
        public int SpellID { get; set; }
        public int IconFileDataID { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class JournalEncounterXDifficulty
    {
        [DBKey]
        public int ID { get; set; }
        public int JournalEncounterID { get; set; }
        public int DifficultyID { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class JournalInstance
    {
        [DBKey]
        public int ID { get; set; }
        public int MapID { get; set; }
        public int AreaID { get; set; }
        public int ButtonFiledataID { get; set; }
        public int ButtonSmallFileDataID { get; set; }
        public int BackgroundFiledataID { get; set; }
        public int LoreFileDataID { get; set; }
        public int Unknown { get; set; }
        public string Name_lang { get; set; }
        public string Description_lang { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class JournalItemXDifficulty
    {
        [DBKey]
        public int ID { get; set; }
        public int JournalEncounterItemID { get; set; }
        public int DifficultyID { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class JournalSectionXDifficulty
    {
        [DBKey]
        public int ID { get; set; }
        public int JournalEncounterSectionID { get; set; }
        public int DifficultyID { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class JournalTier
    {
        [DBKey]
        public int ID { get; set; }
        public string Name_lang { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class JournalTierXInstance
    {
        [DBKey]
        public int JournalTierID { get; set; }
        public int JournalInstanceID { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class KeyChain
    {
        [DBKey]
        public int ID { get; set; }
        [DBField(ArraySize: 32)]
        public byte[] Field4 { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class KeystoneAffix
    {
        [DBKey]
        public int ID { get; set; }
        public string Field00 { get; set; }
        public string Field04 { get; set; }
        public int Field08 { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class Languages
    {
        [DBKey]
        public int ID { get; set; }
        public string Name_lang { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class LanguageWords
    {
        [DBKey]
        public int ID { get; set; }
        public int LanguageID { get; set; }
        public string Word { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class LfgDungeonExpansion
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

    [DBTable(Expansion.WoD)]
    public class LfgDungeonGroup
    {
        [DBKey]
        public int ID { get; set; }
        public string Name_lang { get; set; }
        public int Order_index { get; set; }
        public int Parent_group_id { get; set; }
        public int Typeid { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class LfgDungeons
    {
        [DBKey]
        public int ID { get; set; }
        public string Name_lang { get; set; }
        public int MinLevel { get; set; }
        public int MaxLevel { get; set; }
        public int Target_level { get; set; }
        public int Target_level_min { get; set; }
        public int Target_level_max { get; set; }
        public int MapID { get; set; }
        public int DifficultyID { get; set; }
        public int Flags { get; set; }
        public int TypeID { get; set; }
        public int Faction { get; set; }
        public string TextureFileName { get; set; }
        public int ExpansionLevel { get; set; }
        public int Order_index { get; set; }
        public int Group_id { get; set; }
        public string Description_lang { get; set; }
        public int Random_id { get; set; }
        public int Count_tank { get; set; }
        public int Count_healer { get; set; }
        public int Count_damage { get; set; }
        public int Min_count_tank { get; set; }
        public int Min_count_healer { get; set; }
        public int Min_count_damage { get; set; }
        public int ScenarioID { get; set; }
        public int SubType { get; set; }
        public int Bonus_reputation_amount { get; set; }
        public int MentorCharLevel { get; set; }
        public int MentorItemLevel { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class LfgDungeonsGroupingMap
    {
        [DBKey]
        public int ID { get; set; }
        public int LfgDungeonsID { get; set; }
        public int Random_lfgDungeonsID { get; set; }
        public int Group_id { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class LfgRoleRequirement
    {
        [DBKey]
        public int ID { get; set; }
        public int Field4 { get; set; }
        public int Field8 { get; set; }
        public int FieldC { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class Light
    {
        [DBKey]
        public int ID { get; set; }
        public int ContinentID { get; set; }
        public float X { get; set; }
        public float Y { get; set; }
        public float Z { get; set; }
        public float FalloffStart { get; set; }
        public float FalloffEnd { get; set; }
        [DBField(ArraySize: 8)]
        public int[] LightParamsID { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class LightData
    {
        [DBKey]
        public int ID { get; set; }
        public int LightParamID { get; set; }
        public int Time { get; set; }
        public int DirectColor { get; set; }
        public int AmbientColor { get; set; }
        public int SkyTopColor { get; set; }
        public int SkyMiddleColor { get; set; }
        public int SkyBand1Color { get; set; }
        public int SkyBand2Color { get; set; }
        public int SkySmogColor { get; set; }
        public int SkyFogColor { get; set; }
        public int SunColor { get; set; }
        public int CloudSunColor { get; set; }
        public int CloudEmissiveColor { get; set; }
        public int CloudLayer1AmbientColor { get; set; }
        public int CloudLayer2AmbientColor { get; set; }
        public int OceanCloseColor { get; set; }
        public int OceanFarColor { get; set; }
        public int RiverCloseColor { get; set; }
        public int RiverFarColor { get; set; }
        public int ShadowOpacity { get; set; }
        public float FogEnd { get; set; }
        public float FogScaler { get; set; }
        public float CloudDensity { get; set; }
        public float FogDensity { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class LightParams
    {
        [DBKey]
        public int ID { get; set; }
        public int HighlightSky { get; set; }
        public int LightSkyboxID { get; set; }
        public int CloudTypeID { get; set; }
        public float Glow { get; set; }
        public float WaterShallowAlpha { get; set; }
        public float WaterDeepAlpha { get; set; }
        public float OceanShallowAlpha { get; set; }
        public float OceanDeepAlpha { get; set; }
        public int Flags { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class LightSkybox
    {
        [DBKey]
        public int ID { get; set; }
        public string Name { get; set; }
        public int Flags { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class LiquidMaterial
    {
        [DBKey]
        public int ID { get; set; }
        public int LVF { get; set; }
        public int Flags { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class LiquidObject
    {
        [DBKey]
        public int ID { get; set; }
        public float FlowDirection { get; set; }
        public float FlowSpeed { get; set; }
        public int LiquidTypeID { get; set; }
        public int Fishable { get; set; }
        public int Reflection { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class LiquidType
    {
        [DBKey]
        public int ID { get; set; }
        public string Name { get; set; }
        public int Flags { get; set; }
        public int Type { get; set; }
        public int SoundID { get; set; }
        public int SpellID { get; set; }
        public float MaxDarkenDepth { get; set; }
        public float FogDarkenintensity { get; set; }
        public float AmbDarkenintensity { get; set; }
        public float DirDarkenintensity { get; set; }
        public int LightID { get; set; }
        public float ParticleScale { get; set; }
        public int ParticleMovement { get; set; }
        public int ParticleTexSlots { get; set; }
        public int MaterialID { get; set; }
        [DBField(ArraySize: 6)]
        public string[] Texture { get; set; }
        [DBField(ArraySize: 2)]
        public int[] Color { get; set; }
        [DBField(ArraySize: 18)]
        public float[] Float { get; set; }
        [DBField(ArraySize: 4)]
        public int[] Int { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class LoadingScreens
    {
        [DBKey]
        public int ID { get; set; }
        public string Name { get; set; }
        public string FileName { get; set; }
        public int HasWideScreen { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class LoadingScreenTaxiSplines
    {
        [DBKey]
        public int ID { get; set; }
        public int PathID { get; set; }
        [DBField(ArraySize: 10)]
        public float[] Locx { get; set; }
        [DBField(ArraySize: 10)]
        public float[] Locy { get; set; }
        public int LegIndex { get; set; }
        public int LoadingScreenID { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class Locale
    {
        [DBKey]
        public int ID { get; set; }
        public byte Field4 { get; set; }
        public byte Field8 { get; set; }
        public byte FieldC { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class Location
    {
        [DBKey]
        public int ID { get; set; }
        [DBField(ArraySize: 3)]
        public float[] Field4 { get; set; }
        [DBField(ArraySize: 3)]
        public float[] Field10 { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class Lock
    {
        [DBKey]
        public int ID { get; set; }
        [DBField(ArraySize: 8)]
        public int[] Type { get; set; }
        [DBField(ArraySize: 8)]
        public int[] Index { get; set; }
        [DBField(ArraySize: 8)]
        public int[] Skill { get; set; }
        [DBField(ArraySize: 8)]
        public int[] Action { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class LockType
    {
        [DBKey]
        public int ID { get; set; }
        public string Name_lang { get; set; }
        public string ResourceName_lang { get; set; }
        public string Verb_lang { get; set; }
        public string CursorName { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class LookAtController
    {
        [DBKey]
        public int ID { get; set; }
        public float Field00 { get; set; }
        public float Field04 { get; set; }
        public float Field08 { get; set; }
        public float Field0C { get; set; }
        public ushort Field10 { get; set; }
        public ushort Field12 { get; set; }
        public ushort Field14 { get; set; }
        public ushort Field16 { get; set; }
        public byte Field18 { get; set; }
        public byte Field19 { get; set; }
        public byte Field1A { get; set; }
        public byte Field1B { get; set; }
        public byte Field1C { get; set; }
        public int Field1D { get; set; }
        public int Field21 { get; set; }
        public int Field25 { get; set; }
        public int Field29 { get; set; }
        public int Field2D { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class MailTemplate
    {
        [DBKey]
        public int ID { get; set; }
        public string Body_lang { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class ManifestinterfaceActionIcon
    {
        [DBKey]
        public int ID { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class ManifestinterfaceData
    {
        [DBKey]
        public int ID { get; set; }
        public string FilePath { get; set; }
        public string FileName { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class ManifestinterfaceItemIcon
    {
        [DBKey]
        public int ID { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class ManifestinterfaceTOCData
    {
        [DBKey]
        public int ID { get; set; }
        public string FilePath { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class ManifestMP3
    {
        [DBKey]
        public int ID { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class Map
    {
        [DBKey]
        public int ID { get; set; }
        public string Directory { get; set; }
        public int InstanceType { get; set; }
        public int Flags { get; set; }
        public int MapType { get; set; }
        public int Unknown { get; set; }
        public string MapName_lang { get; set; }
        public int AreaTableID { get; set; }
        public string MapDescription0_lang { get; set; }
        public string MapDescription1_lang { get; set; }
        public int LoadingScreenID { get; set; }
        public float MinimapIconScale { get; set; }
        public int CorpseMapID { get; set; }
        [DBField(ArraySize: 2)]
        public float[] Corpse { get; set; }
        public int TimeOfDayOverride { get; set; }
        public int ExpansionID { get; set; }
        public int RaidOffset { get; set; }
        public int MaxPlayers { get; set; }
        public int ParentMapID { get; set; }
        public int CosmeticParentMapID { get; set; }
        public int TimeOffset { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class MapChallengeMode
    {
        [DBKey]
        public int ID { get; set; }
        public int Field4 { get; set; }
        public int Field8 { get; set; }
        public int FieldC { get; set; }
        [DBField(ArraySize: 5)]
        public int[] Field10 { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class MapDifficulty
    {
        [DBKey]
        public int ID { get; set; }
        public int MapID { get; set; }
        public int DifficultyID { get; set; }
        public string Message_lang { get; set; }
        public int RaidDuration { get; set; }
        public int MaxPlayers { get; set; }
        public int LockID { get; set; }
        public int ItemBonusTreeModID { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class MapDifficultyXCondition
    {
        [DBKey]
        public int ID { get; set; }
        public string Field00 { get; set; }
        public int Field04 { get; set; }
        public int Field08 { get; set; }
        public int Field0C { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class MarketingPromotionsXlocale
    {
        [DBKey]
        public int ID { get; set; }
        public int Field4 { get; set; }
        public int Field8 { get; set; }
        public int FieldC { get; set; }
        public int Field10 { get; set; }
        public int Field14 { get; set; }
        public int Field18 { get; set; }
        public string Field1C { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class Material
    {
        [DBKey]
        public int ID { get; set; }
        public int Flags { get; set; }
        public int FoleySoundID { get; set; }
        public int SheatheSoundID { get; set; }
        public int UnsheatheSoundID { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class MinorTalent
    {
        [DBKey]
        public int ID { get; set; }
        public int ChrSpecializationID { get; set; }
        public int SpellID { get; set; }
        public int OrderIndex { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class ModelAnimCloakDampening
    {
        [DBKey]
        public int ID { get; set; }
        public byte Field00 { get; set; }
        public int Field01 { get; set; }
        public int Field05 { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class ModelFileData
    {
        [DBKey]
        public int ID { get; set; }
        public int Field05 { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class ModelManifest
    {
        [DBKey]
        public int ID { get; set; }
        public int Field4 { get; set; }
        public ulong Field8 { get; set; }
        public int Field10 { get; set; }
        public byte Field14 { get; set; }
        public string Field18 { get; set; }
        public int Field1C { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class ModelNameToManifest
    {
        [DBKey]
        public int ID { get; set; }
        public string Field4 { get; set; }
        public int Field8 { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class ModelRibbonQuality
    {
        [DBKey]
        public int ID { get; set; }
        public int Field00 { get; set; }
        public byte Field04 { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class ModifierTree
    {
        [DBKey]
        public int ID { get; set; }
        public int Type { get; set; }
        public int Asset { get; set; }
        public int SecondaryAsset { get; set; }
        public int Operator { get; set; }
        public int Amount { get; set; }
        public int Parent { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class Mount
    {
        [DBKey]
        public int ID { get; set; }
        public int SpellId { get; set; }
        public int MountTypeID { get; set; }
        public int DisplayId { get; set; }
        public int Flags { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string SourceDescription { get; set; }
        public int Source { get; set; }
        public int PlayerConditionId { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class MountCapability
    {
        [DBKey]
        public int ID { get; set; }
        public int Flags { get; set; }
        public int ReqRidingSkill { get; set; }
        public int ReqAreaID { get; set; }
        public int ReqSpellAuraID { get; set; }
        public int ReqSpellKnownID { get; set; }
        public int ModSpellAuraID { get; set; }
        public int ReqMapID { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class MountType
    {
        [DBKey]
        public int ID { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class MountTypeXCapability
    {
        [DBKey]
        public int ID { get; set; }
        public ushort Field00 { get; set; }
        public ushort Field02 { get; set; }
        public byte Field04 { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class Movie
    {
        [DBKey]
        public int ID { get; set; }
        public int Volume { get; set; }
        public int KeyID { get; set; }
        public int AudioFileDataID { get; set; }
        public int SubtitleFileDataID { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class MovieFileData
    {
        [DBKey]
        public int FileDataID { get; set; }
        public int Resolution { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class MovieOverlays
    {
        [DBKey]
        public int ID { get; set; }
        public int MovieID { get; set; }
        public int LocaleMask { get; set; }
        public int OverlayRangeBegin { get; set; }
        public int OverlayRangeEnd { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class MovieVariation
    {
        [DBKey]
        public int ID { get; set; }
        public int MovieID { get; set; }
        public int FileDataID { get; set; }
        public int OverlayFileDataID { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class NameGen
    {
        [DBKey]
        public int ID { get; set; }
        public string Name { get; set; }
        public int RaceID { get; set; }
        public int Sex { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class NamesProfanity
    {
        [DBKey]
        public int ID { get; set; }
        public string Name { get; set; }
        public int Language { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class NamesReserved
    {
        [DBKey]
        public int ID { get; set; }
        public string Name { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class NamesReservedlocale
    {
        [DBKey]
        public int ID { get; set; }
        public string Name { get; set; }
        public int LocaleMask { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class NpcModelItemSlotDisplayInfo
    {
        [DBKey]
        public int ID { get; set; }
        public int Field00 { get; set; }
        public int Field04 { get; set; }
        public byte Field08 { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class NPCSounds
    {
        [DBKey]
        public int ID { get; set; }
        [DBField(ArraySize: 4)]
        public int[] SoundID { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class ObjectEffect
    {
        [DBKey]
        public int ID { get; set; }
        public string Name { get; set; }
        public int ObjectEffectGroupID { get; set; }
        public int TriggerType { get; set; }
        public int EventType { get; set; }
        public int EffectRecType { get; set; }
        public int EffectRecID { get; set; }
        public int Attachment { get; set; }
        [DBField(ArraySize: 3)]
        public float[] Offset { get; set; }
        public int ObjectEffectModifierID { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class ObjectEffectGroup
    {
        [DBKey]
        public int ID { get; set; }
        public string Name { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class ObjectEffectModifier
    {
        [DBKey]
        public int ID { get; set; }
        public int InputType { get; set; }
        public int MapType { get; set; }
        public int OutputType { get; set; }
        [DBField(ArraySize: 4)]
        public float[] Param { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class ObjectEffectPackage
    {
        [DBKey]
        public int ID { get; set; }
        public string Name { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class ObjectEffectPackageElem
    {
        [DBKey]
        public int ID { get; set; }
        public int ObjectEffectPackageID { get; set; }
        public int ObjectEffectGroupID { get; set; }
        public int StateType { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class OutlineEffect
    {
        [DBKey]
        public int ID { get; set; }
        public float Field00 { get; set; }
        public int Field04 { get; set; }
        public int Field08 { get; set; }
        public int Field0C { get; set; }
        public int Field10 { get; set; }
        public int Field14 { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class OverrideSpellData
    {
        [DBKey]
        public int ID { get; set; }
        [DBField(ArraySize: 10)]
        public int[] Spells { get; set; }
        public int Flags { get; set; }
        public int PlayerActionbarFileDataID { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class Package
    {
        [DBKey]
        public int ID { get; set; }
        public string Icon { get; set; }
        public int Cost { get; set; }
        public string Name_lang { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class PageTextCache
    {
        [DBKey]
        public int PageID { get; set; }
        public int EntryLength { get; set; }
        public string PageText { get; set; }
        public int NextPageID { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class PageTextMaterial
    {
        [DBKey]
        public int ID { get; set; }
        public string Name { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class PaperDollItemFrame
    {
        [DBKey]
        public int ID { get; set; }
        public string ItemButtonName { get; set; }
        public string SlotIcon { get; set; }
        public int SlotNumber { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class ParticleColor
    {
        [DBKey]
        public int ID { get; set; }
        [DBField(ArraySize: 3)]
        public int[] Start { get; set; }
        [DBField(ArraySize: 3)]
        public int[] Mid { get; set; }
        [DBField(ArraySize: 3)]
        public int[] End { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class Path
    {
        [DBKey]
        public int ID { get; set; }
        public int Field4 { get; set; }
        public int Field8 { get; set; }
        public int FieldC { get; set; }
        public int Field10 { get; set; }
        public int Field14 { get; set; }
        public int Field18 { get; set; }
        public int Field1C { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class PathNode
    {
        [DBKey]
        public int ID { get; set; }
        public int Field4 { get; set; }
        public int Field8 { get; set; }
        public int FieldC { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class PathNodeProperty
    {
        [DBKey]
        public int ID { get; set; }
        public int Field4 { get; set; }
        public int Field8 { get; set; }
        public int FieldC { get; set; }
        public int Field10 { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class PathProperty
    {
        [DBKey]
        public int ID { get; set; }
        public int Field4 { get; set; }
        public int Field8 { get; set; }
        public int FieldC { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class Phase
    {
        [DBKey]
        public int ID { get; set; }
        public int Flags { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class PhaseShiftZoneSounds
    {
        [DBKey]
        public int ID { get; set; }
        public int AreaID { get; set; }
        public int WMOAreaID { get; set; }
        public int PhaseID { get; set; }
        public int PhaseGroupID { get; set; }
        public int PhaseUseFlags { get; set; }
        public int ZoneintroMusicID { get; set; }
        public int ZoneMusicID { get; set; }
        public int SoundAmbienceID { get; set; }
        public int SoundProviderPreferencesID { get; set; }
        public int UWZoneintroMusicID { get; set; }
        public int UWZoneMusicID { get; set; }
        public int UWSoundAmbienceID { get; set; }
        public int UWSoundProviderPreferencesID { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class PhaseXPhaseGroup
    {
        [DBKey]
        public int ID { get; set; }
        public int PhaseID { get; set; }
        public int PhaseGroupID { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class PlayerCondition
    {
        [DBKey]
        public int ID { get; set; }
        public int Flags { get; set; }
        public int MinLevel { get; set; }
        public int MaxLevel { get; set; }
        public int RaceMask { get; set; }
        public int ClassMask { get; set; }
        public int Gender { get; set; }
        public int NativeGender { get; set; }
        [DBField(ArraySize: 4)]
        public int[] SkillID { get; set; }
        [DBField(ArraySize: 4)]
        public int[] MinSkill { get; set; }
        [DBField(ArraySize: 4)]
        public int[] MaxSkill { get; set; }
        public int SkillLogic { get; set; }
        public int LanguageID { get; set; }
        public int MinLanguage { get; set; }
        public int MaxLanguage { get; set; }
        [DBField(ArraySize: 3)]
        public int[] MinFactionID { get; set; }
        public int MaxFactionID { get; set; }
        [DBField(ArraySize: 3)]
        public int[] MinReputation { get; set; }
        public int MaxReputation { get; set; }
        public int ReputationLogic { get; set; }
        public int MinPVPRank { get; set; }
        public int MaxPVPRank { get; set; }
        public int PvpMedal { get; set; }
        public int PrevQuestLogic { get; set; }
        [DBField(ArraySize: 4)]
        public int[] PrevQuestID { get; set; }
        public int CurrQuestLogic { get; set; }
        [DBField(ArraySize: 4)]
        public int[] CurrQuestID { get; set; }
        public int CurrentCompletedQuestLogic { get; set; }
        [DBField(ArraySize: 4)]
        public int[] CurrentCompletedQuestID { get; set; }
        public int SpellLogic { get; set; }
        [DBField(ArraySize: 4)]
        public int[] SpellID { get; set; }
        public int ItemLogic { get; set; }
        [DBField(ArraySize: 4)]
        public int[] ItemID { get; set; }
        [DBField(ArraySize: 4)]
        public int[] ItemCount { get; set; }
        public int ItemFlags { get; set; }
        [DBField(ArraySize: 2)]
        public int[] Explored { get; set; }
        [DBField(ArraySize: 2)]
        public int[] Time { get; set; }
        public int AuraSpellLogic { get; set; }
        [DBField(ArraySize: 4)]
        public int[] AuraSpellID { get; set; }
        public int WorldStateExpressionID { get; set; }
        public int WeatherID { get; set; }
        public int PartyStatus { get; set; }
        public int LifetimeMaxPVPRank { get; set; }
        public int AchievementLogic { get; set; }
        [DBField(ArraySize: 4)]
        public int[] Achievement { get; set; }
        public int LfgLogic { get; set; }
        [DBField(ArraySize: 4)]
        public int[] LfgStatus { get; set; }
        [DBField(ArraySize: 4)]
        public int[] LfgCompare { get; set; }
        [DBField(ArraySize: 4)]
        public int[] LfgValue { get; set; }
        public int AreaLogic { get; set; }
        [DBField(ArraySize: 4)]
        public int[] AreaID { get; set; }
        public int CurrencyLogic { get; set; }
        [DBField(ArraySize: 4)]
        public int[] CurrencyID { get; set; }
        [DBField(ArraySize: 4)]
        public int[] CurrencyCount { get; set; }
        public int QuestKillID { get; set; }
        public int QuestKillLogic { get; set; }
        [DBField(ArraySize: 4)]
        public int[] QuestKillMonster { get; set; }
        public int MinExpansionLevel { get; set; }
        public int MaxExpansionLevel { get; set; }
        public int MinExpansionTier { get; set; }
        public int MaxExpansionTier { get; set; }
        public int MinGuildLevel { get; set; }
        public int MaxGuildLevel { get; set; }
        public int PhaseUseFlags { get; set; }
        public int PhaseID { get; set; }
        public int PhaseGroupID { get; set; }
        public int MinAvgItemLevel { get; set; }
        public int MaxAvgItemLevel { get; set; }
        public int MinAvgEquippedItemLevel { get; set; }
        public int MaxAvgEquippedItemLevel { get; set; }
        public int ChrSpecializationIndex { get; set; }
        public int ChrSpecializationRole { get; set; }
        public string Failure_description_lang { get; set; }
        public int PowerType { get; set; }
        public int PowerTypeComp { get; set; }
        public int PowerTypeValue { get; set; }
        public int ClassMask2 { get; set; }
        public int LanguageID2 { get; set; }
        [DBField(ArraySize: 3)]
        public int[] MinFactionID2 { get; set; }
        [DBField(ArraySize: 4)]
        public int[] SpellID2 { get; set; }
        [DBField(ArraySize: 4)]
        public int[] ItemID2 { get; set; }
        [DBField(ArraySize: 4)]
        public int[] ItemCount2 { get; set; }
        public int LfgLogic2 { get; set; }
        [DBField(ArraySize: 4)]
        public int[] LfgValue2 { get; set; }
        public int CurrencyLogic2 { get; set; }
        [DBField(ArraySize: 4)]
        public int[] CurrencyID2 { get; set; }
        [DBField(ArraySize: 6)]
        public int[] QuestKillMonster2 { get; set; }
        public int PhaseGroupID2 { get; set; }
        public int MinAvgItemLevel2 { get; set; }
        public int MaxAvgItemLevel2 { get; set; }
        [DBField(ArraySize: 2)]
        public int[] Unknown700 { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class Positioner
    {
        [DBKey]
        public int ID { get; set; }
        public float Field00 { get; set; }
        public ushort Field04 { get; set; }
        public byte Field06 { get; set; }
        public byte Field07 { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class PositionerState
    {
        [DBKey]
        public int ID { get; set; }
        public float Field00 { get; set; }
        public byte Field04 { get; set; }
        public int Field05 { get; set; }
        public int Field09 { get; set; }
        public int Field0D { get; set; }
        public int Field11 { get; set; }
        public int Field15 { get; set; }
        public int Field19 { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class PositionerStateEntry
    {
        [DBKey]
        public int ID { get; set; }
        public float Field00 { get; set; }
        public float Field04 { get; set; }
        public byte Field08 { get; set; }
        public byte Field09 { get; set; }
        public byte Field0A { get; set; }
        public byte Field0B { get; set; }
        public byte Field0C { get; set; }
        public byte Field0D { get; set; }
        public byte Field0E { get; set; }
        public byte Field0F { get; set; }
        public int Field10 { get; set; }
    }

    [DBTable(Expansion.WoD)]
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

    [DBTable(Expansion.WoD)]
    public class PowerType
    {
        [DBKey]
        public int ID { get; set; }
        public string Field00 { get; set; }
        public string Field04 { get; set; }
        public float Field08 { get; set; }
        public float Field0C { get; set; }
        public ushort Field10 { get; set; }
        public ushort Field12 { get; set; }
        public ushort Field14 { get; set; }
        public byte Field16 { get; set; }
        public byte Field17 { get; set; }
        public byte Field18 { get; set; }
        public byte Field19 { get; set; }
        public byte Field1A { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class PrestigeLevelInfo
    {
        [DBKey]
        public int ID { get; set; }
        public int Field00 { get; set; }
        public string Field04 { get; set; }
        public byte Field08 { get; set; }
        public byte Field09 { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class PvpBracketTypes
    {
        [DBKey]
        public int ID { get; set; }
        public byte Field00 { get; set; }
        [DBField(ArraySize: 4)]
        public int[] Field01 { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class PvpDifficulty
    {
        [DBKey]
        public int ID { get; set; }
        public int MapID { get; set; }
        public int RangeIndex { get; set; }
        public int MinLevel { get; set; }
        public int MaxLevel { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class PvpItem
    {
        [DBKey]
        public int ID { get; set; }
        public int Field4 { get; set; }
        public int Field8 { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class PvpReward
    {
        [DBKey]
        public int ID { get; set; }
        public int Field00 { get; set; }
        public int Field04 { get; set; }
        public int Field08 { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class PvpTalent
    {
        [DBKey]
        public int ID { get; set; }
        public int Field00 { get; set; }
        public int Field04 { get; set; }
        public string Field08 { get; set; }
        public int Field0C { get; set; }
        public int Field10 { get; set; }
        public int Field14 { get; set; }
        public int Field18 { get; set; }
        public int Field1C { get; set; }
        public int Field20 { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class PvpTalentUnlock
    {
        [DBKey]
        public int ID { get; set; }
        public int Field00 { get; set; }
        public int Field04 { get; set; }
        public int Field08 { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class QuestFactionReward
    {
        [DBKey]
        public int ID { get; set; }
        [DBField(ArraySize: 10)]
        public int[] Difficulty { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class QuestFeedbackEffect
    {
        [DBKey]
        public int ID { get; set; }
        public int FileDataID { get; set; }
        public int AttachPoint { get; set; }
        public int Minimapobject { get; set; }
        public int Priority { get; set; }
        public int Flags { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class QuestInfo
    {
        [DBKey]
        public int ID { get; set; }
        public string InfoName_lang { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class QuestLine
    {
        [DBKey]
        public int ID { get; set; }
        public string Field4 { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class QuestLineXQuest
    {
        [DBKey]
        public int ID { get; set; }
        public int Field4 { get; set; }
        public int Field8 { get; set; }
        public int FieldC { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class QuestMoneyReward
    {
        [DBKey]
        public int ID { get; set; }
        [DBField(ArraySize: 10)]
        public int[] Difficulty { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class QuestObjective
    {
        [DBKey]
        public int ID { get; set; }
        public int Field00 { get; set; }
        public int Field04 { get; set; }
        public string Field08 { get; set; }
        public ushort Field0C { get; set; }
        public byte Field0E { get; set; }
        public byte Field0F { get; set; }
        public byte Field10 { get; set; }
        public byte Field11 { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class QuestPackageItem
    {
        [DBKey]
        public int ID { get; set; }
        public int Field4 { get; set; }
        public int Field8 { get; set; }
        public int FieldC { get; set; }
        public int Field10 { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class QuestPOIBlob
    {
        [DBKey]
        public int ID { get; set; }
        public int NumPoints { get; set; }
        public int MapID { get; set; }
        public int WorldMapAreaID { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class QuestPOIPoint
    {
        [DBKey]
        public int ID { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public int QuestPOIBlobID { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class QuestPOIPointCliTask
    {
        [DBKey]
        public int ID { get; set; }
        public ushort Field00 { get; set; }
        public ushort Field02 { get; set; }
        public ushort Field04 { get; set; }
        public ushort Field06 { get; set; }
        public ushort Field08 { get; set; }
        public byte Field0A { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class QuestSort
    {
        [DBKey]
        public int ID { get; set; }
        public string SortName_lang { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class QuestV2
    {
        [DBKey]
        public int ID { get; set; }
        public int UniqueBitFlag { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class QuestV2CliTask
    {
        [DBKey]
        public int ID { get; set; }
        public string Field04 { get; set; }
        public string Field08 { get; set; }
        public int Field0C { get; set; }
        public ushort Field10 { get; set; }
        public ushort Field12 { get; set; }
        public ushort Field14 { get; set; }
        [DBField(ArraySize: 3)]
        public ushort[] Field16 { get; set; }
        public ushort Field1C { get; set; }
        public ushort Field1E { get; set; }
        public ushort Field20 { get; set; }
        public byte Field22 { get; set; }
        public byte Field23 { get; set; }
        public byte Field24 { get; set; }
        public byte Field25 { get; set; }
        public byte Field26 { get; set; }
        public byte Field27 { get; set; }
        public byte Field28 { get; set; }
        public byte Field29 { get; set; }
        public byte Field2A { get; set; }
        public int Field2F { get; set; }
        public int Field33 { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class QuestXP
    {
        [DBKey]
        public int ID { get; set; }
        [DBField(ArraySize: 10)]
        public int[] Difficulty { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class RacialMounts
    {
        [DBKey]
        public int ID { get; set; }
        public int Race { get; set; }
        public int Spell_id { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class RandPropPoints
    {
        [DBKey]
        public int ID { get; set; }
        [DBField(ArraySize: 5)]
        public int[] Epic { get; set; }
        [DBField(ArraySize: 5)]
        public int[] Superior { get; set; }
        [DBField(ArraySize: 5)]
        public int[] Good { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class ResearchBranch
    {
        [DBKey]
        public int ID { get; set; }
        public string Name_lang { get; set; }
        public int ResearchFieldID { get; set; }
        public int CurrencyID { get; set; }
        public string Texture { get; set; }
        public int ItemID { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class ResearchField
    {
        [DBKey]
        public int ID { get; set; }
        public string Name_lang { get; set; }
        public int Slot { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class ResearchProject
    {
        [DBKey]
        public int ID { get; set; }
        public string Name_lang { get; set; }
        public string Description_lang { get; set; }
        public int Rarity { get; set; }
        public int ResearchBranchID { get; set; }
        public int SpellID { get; set; }
        public int NumSockets { get; set; }
        public string Texture { get; set; }
        public int RequiredWeight { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class ResearchSite
    {
        [DBKey]
        public int ID { get; set; }
        public int MapID { get; set; }
        public int QuestPOIBlobID { get; set; }
        public string Name_lang { get; set; }
        public int AreaPOIIconEnum { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class Resistances
    {
        [DBKey]
        public int ID { get; set; }
        public int Flags { get; set; }
        public int FizzleSoundID { get; set; }
        public string Name_lang { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class RewardPack
    {
        [DBKey]
        public int ID { get; set; }
        public int Field00 { get; set; }
        public float Field04 { get; set; }
        public byte Field08 { get; set; }
        public byte Field09 { get; set; }
        public int Field0A { get; set; }
        public int Field0E { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class RewardPackXCurrencyType
    {
        [DBKey]
        public int ID { get; set; }
        public int Field00 { get; set; }
        public int Field04 { get; set; }
        public int Field08 { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class RewardPackXItem
    {
        [DBKey]
        public int ID { get; set; }
        public int Field00 { get; set; }
        public int Field04 { get; set; }
        public int Field08 { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class RibbonQuality
    {
        [DBKey]
        public int ID { get; set; }
        public float Field00 { get; set; }
        public float Field04 { get; set; }
        public float Field08 { get; set; }
        public byte Field0C { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class RulesetItemUpgrade
    {
        [DBKey]
        public int ID { get; set; }
        public int Field4 { get; set; }
        public int Field8 { get; set; }
        public int FieldC { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class RulesetRaidLootUpgrade
    {
        [DBKey]
        public int ID { get; set; }
        public int Field4 { get; set; }
        public int Field8 { get; set; }
        public int FieldC { get; set; }
        public int Field10 { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class RulesetRaidOverride
    {
        [DBKey]
        public int ID { get; set; }
        public int MapID { get; set; }
        public int DifficultyID { get; set; }
        public int RulesetID { get; set; }
        public int Sharedlock { get; set; }
        public int Raidduration { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class ScalingStatDistribution
    {
        [DBKey]
        public int ID { get; set; }
        public int MinLevel { get; set; }
        public int MaxLevel { get; set; }
        public int ItemLevelCurveId { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class ScalingStatValues
    {
        [DBKey]
        public int ID { get; set; }
        public int Charlevel { get; set; }
        public int EffectiveLevel { get; set; }
        public int WeaponDPS1H { get; set; }
        public int WeaponDPS2H { get; set; }
        public int SpellcasterDPS1H { get; set; }
        public int SpellcasterDPS2H { get; set; }
        public int RangedDPS { get; set; }
        public int WandDPS { get; set; }
        public int SpellPower { get; set; }
        public int BudgetPrimary { get; set; }
        public int BudgetSecondary { get; set; }
        public int BudgetTertiary { get; set; }
        public int BudgetSub { get; set; }
        public int BudgetTrivial { get; set; }
        [DBField(ArraySize: 4)]
        public int[] ArmorShoulder { get; set; }
        [DBField(ArraySize: 4)]
        public int[] ArmorChest { get; set; }
        [DBField(ArraySize: 4)]
        public int[] ArmorHead { get; set; }
        [DBField(ArraySize: 4)]
        public int[] ArmorLegs { get; set; }
        [DBField(ArraySize: 4)]
        public int[] ArmorFeet { get; set; }
        [DBField(ArraySize: 4)]
        public int[] ArmorWaist { get; set; }
        [DBField(ArraySize: 4)]
        public int[] ArmorHands { get; set; }
        [DBField(ArraySize: 4)]
        public int[] ArmorWrists { get; set; }
        public int ArmorBack { get; set; }
        public int ArmorShield { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class Scenario
    {
        [DBKey]
        public int ID { get; set; }
        public string Name_lang { get; set; }
        public int Flags { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class ScenarioEventEntry
    {
        [DBKey]
        public int ID { get; set; }
        public int TriggerType { get; set; }
        public int TriggerAsset { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class ScenarioStep
    {
        [DBKey]
        public int ID { get; set; }
        public int Criteriatreeid { get; set; }
        public int ScenarioID { get; set; }
        public int OrderIndex { get; set; }
        public string Description_lang { get; set; }
        public string Title_lang { get; set; }
        public int Flags { get; set; }
        public int RelatedStep { get; set; }
        public int Supersedes { get; set; }
        public int RewardQuestID { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class SceneScript
    {
        [DBKey]
        public int ID { get; set; }
        public string Field4 { get; set; }
        public string Field8 { get; set; }
        public int FieldC { get; set; }
        public int Field10 { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class SceneScriptPackage
    {
        [DBKey]
        public int ID { get; set; }
        public string Field4 { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class SceneScriptPackageMember
    {
        [DBKey]
        public int ID { get; set; }
        public int Field4 { get; set; }
        public int Field8 { get; set; }
        public int FieldC { get; set; }
        public int Field10 { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class Scheduledinterval
    {
        [DBKey]
        public int ID { get; set; }
        public int Field00 { get; set; }
        public int Field04 { get; set; }
        public int Field08 { get; set; }
        public int Field0C { get; set; }
        public int Field10 { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class ScheduledUniqueCategory
    {
        [DBKey]
        public int ID { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class ScheduledWorldState
    {
        [DBKey]
        public int ID { get; set; }
        public int Field00 { get; set; }
        public int Field04 { get; set; }
        public int Field08 { get; set; }
        public int Field0C { get; set; }
        public int Field10 { get; set; }
        public int Field14 { get; set; }
        public int Field18 { get; set; }
        public int Field1C { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class ScheduledWorldStateGroup
    {
        [DBKey]
        public int ID { get; set; }
        public int Field00 { get; set; }
        public int Field04 { get; set; }
        public int Field08 { get; set; }
        public int Field0C { get; set; }
        public int Field10 { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class ScheduledWorldStateXUniqCat
    {
        [DBKey]
        public int ID { get; set; }
        public int Field04 { get; set; }
        public int Field08 { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class ScreenEffect
    {
        [DBKey]
        public int Id { get; set; }
        public string Name { get; set; }
        public int Effect { get; set; }
        [DBField(ArraySize: 4)]
        public int[] Param { get; set; }
        public int LightParamsID { get; set; }
        public int LightParamsFadeIn { get; set; }
        public int LightParamsFadeOut { get; set; }
        public int LightFlags { get; set; }
        public int SoundAmbienceID { get; set; }
        public int ZoneMusicID { get; set; }
        public int TimeOfDayOverride { get; set; }
        public int EffectMask { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class Screenlocation
    {
        [DBKey]
        public int ID { get; set; }
        public string Name { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class SeamlessSite
    {
        [DBKey]
        public int ID { get; set; }
        public int Field00 { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class ServerMessages
    {
        [DBKey]
        public int ID { get; set; }
        public string Text_lang { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class ShadowyEffect
    {
        [DBKey]
        public int ID { get; set; }
        public int Field00 { get; set; }
        public int Field04 { get; set; }
        public float Field08 { get; set; }
        public float Field0C { get; set; }
        public float Field10 { get; set; }
        public float Field14 { get; set; }
        public float Field18 { get; set; }
        public float Field1C { get; set; }
        public byte Field20 { get; set; }
        public byte Field21 { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class SkillLine
    {
        [DBKey]
        public int ID { get; set; }
        public int CategoryID { get; set; }
        public string DisplayName_lang { get; set; }
        public string Description_lang { get; set; }
        public int SpellIconID { get; set; }
        public string AlternateVerb_lang { get; set; }
        public int CanLink { get; set; }
        public int ParentSkillLineID { get; set; }
        public int Flags { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class SkillLineAbility
    {
        [DBKey]
        public int ID { get; set; }
        public int SkillLine { get; set; }
        public int Spell { get; set; }
        public int RaceMask { get; set; }
        public int ClassMask { get; set; }
        public int MinSkillLineRank { get; set; }
        public int SupercedesSpell { get; set; }
        public int AcquireMethod { get; set; }
        public int TrivialSkillLineRankHigh { get; set; }
        public int TrivialSkillLineRankLow { get; set; }
        public int NumSkillUps { get; set; }
        public int UniqueBit { get; set; }
        public int TradeSkillCategoryID { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class SkillLineAbilitySortedSpell
    {
        [DBKey]
        public int ID { get; set; }
        public int Spell { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class SkillRaceClassInfo
    {
        [DBKey]
        public int ID { get; set; }
        public int SkillID { get; set; }
        public int RaceMask { get; set; }
        public int ClassMask { get; set; }
        public int Flags { get; set; }
        public int Availability { get; set; }
        public int MinLevel { get; set; }
        public int SkillTierID { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class SkillTiers
    {
        [DBKey]
        public int ID { get; set; }
        [DBField(ArraySize: 16)]
        public int[] Value { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class SoundAmbience
    {
        [DBKey]
        public int ID { get; set; }
        [DBField(ArraySize: 2)]
        public int[] AmbienceID { get; set; }
        public int Flags { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class SoundAmbienceFlavor
    {
        [DBKey]
        public int ID { get; set; }
        public int SoundAmbienceID { get; set; }
        public int SoundEntriesIDDay { get; set; }
        public int SoundEntriesIDNight { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class SoundBus
    {
        [DBKey]
        public int ID { get; set; }
        public int Parent { get; set; }
        public int DefaultPriority { get; set; }
        public int DefaultPrioriTypenalty { get; set; }
        public int RaidPriority { get; set; }
        public int RaidPrioriTypenalty { get; set; }
        public float DefaultVolume { get; set; }
        public float RaidVolume { get; set; }
        public int DefaultPlaybackLimit { get; set; }
        public int RaidPlaybackLimit { get; set; }
        public int BusEnumID { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class SoundBusName
    {
        [DBKey]
        public int EnumID { get; set; }
        public string Name { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class SoundEmitterPillPoints
    {
        [DBKey]
        public int ID { get; set; }
        public int SoundEmittersID { get; set; }
        [DBField(ArraySize: 3)]
        public float[] Position { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class SoundEmitters
    {
        [DBKey]
        public int ID { get; set; }
        [DBField(ArraySize: 3)]
        public float[] Position { get; set; }
        [DBField(ArraySize: 3)]
        public float[] Direction { get; set; }
        public int SoundEntriesID { get; set; }
        public int MapID { get; set; }
        [DBField(ArraySize: 2)]
        public int[] Unknown { get; set; }
        public string Name { get; set; }
        public int EmitterType { get; set; }
        public int PhaseID { get; set; }
        public int PhaseGroupID { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class SoundEntries
    {
        [DBKey]
        public int ID { get; set; }
        public int SoundType { get; set; }
        public string Name { get; set; }
        [DBField(ArraySize: 20)]
        public int[] FileDataID { get; set; }
        [DBField(ArraySize: 20)]
        public int[] Freq { get; set; }
        public float Volumefloat { get; set; }
        public int Flags { get; set; }
        public float MinDistance { get; set; }
        public float DistanceCutoff { get; set; }
        public int EAXDef { get; set; }
        public int SoundEntriesAdvancedID { get; set; }
        public float Volumevariationplus { get; set; }
        public float Volumevariationminus { get; set; }
        public float Pitchvariationplus { get; set; }
        public float Pitchvariationminus { get; set; }
        public float PitchAdjust { get; set; }
        public int DialogType { get; set; }
        public int BusOverwriteID { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class SoundEntriesAdvanced
    {
        [DBKey]
        public int ID { get; set; }
        public int SoundEntryID { get; set; }
        public float InnerRadius2D { get; set; }
        public int TimeA { get; set; }
        public int TimeB { get; set; }
        public int TimeC { get; set; }
        public int TimeD { get; set; }
        public int RandomOffsetRange { get; set; }
        public int Usage { get; set; }
        public int TimeintervalMin { get; set; }
        public int TimeintervalMax { get; set; }
        public int VolumeSliderCategory { get; set; }
        public float DuckToSFX { get; set; }
        public float DuckToMusic { get; set; }
        public float DuckToAmbience { get; set; }
        public float InnerRadiusOfInfluence { get; set; }
        public float OuterRadiusOfInfluence { get; set; }
        public int TimeToDuck { get; set; }
        public int TimeToUnduck { get; set; }
        public float InsideAngle { get; set; }
        public float OutsideAngle { get; set; }
        public float OutsideVolume { get; set; }
        public float OuterRadius2D { get; set; }
        public int MinRandomPosOffset { get; set; }
        public int MaxRandomPosOffset { get; set; }
        public float DuckToDialog { get; set; }
        public float DuckToSuppressors { get; set; }
        public int MsOffset { get; set; }
        [DBField(ArraySize: 20)]
        public float[] Volume { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class SoundEntriesFallbacks
    {
        [DBKey]
        public int ID { get; set; }
        public int SoundEntriesID { get; set; }
        public int FallbackSoundEntriesID { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class SoundFilter
    {
        [DBKey]
        public int ID { get; set; }
        public string Name { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class SoundFilterElem
    {
        [DBKey]
        public int ID { get; set; }
        public int SoundFilterID { get; set; }
        public int OrderIndex { get; set; }
        public int FilterType { get; set; }
        [DBField(ArraySize: 9)]
        public float[] Params { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class SoundKit
    {
        public string Field00 { get; set; }
        public float Field04 { get; set; }
        public float Field08 { get; set; }
        public float Field0C { get; set; }
        public float Field10 { get; set; }
        public float Field14 { get; set; }
        public float Field18 { get; set; }
        public float Field1C { get; set; }
        public float Field20 { get; set; }
        public ushort Field24 { get; set; }
        public ushort Field26 { get; set; }
        public ushort Field28 { get; set; }
        public byte Field2A { get; set; }
        public byte Field2B { get; set; }
        public byte Field2C { get; set; }
        public byte Field2D { get; set; }
        [DBKey]
        public int ID { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class SoundKitAdvanced
    {
        [DBKey]
        public int ID { get; set; }
        public float Field00 { get; set; }
        public int Field04 { get; set; }
        public int Field08 { get; set; }
        public int Field0C { get; set; }
        public int Field10 { get; set; }
        public int Field14 { get; set; }
        public int Field18 { get; set; }
        public float Field1C { get; set; }
        public float Field20 { get; set; }
        public float Field24 { get; set; }
        public float Field28 { get; set; }
        public float Field2C { get; set; }
        public int Field30 { get; set; }
        public int Field34 { get; set; }
        public float Field38 { get; set; }
        public float Field3C { get; set; }
        public float Field40 { get; set; }
        public float Field44 { get; set; }
        public float Field48 { get; set; }
        public float Field4C { get; set; }
        public int Field50 { get; set; }
        public ushort Field54 { get; set; }
        public byte Field56 { get; set; }
        public byte Field57 { get; set; }
        public byte Field58 { get; set; }
        public byte Field59 { get; set; }
        public int Field5A { get; set; }
        public int Field5E { get; set; }
        public int Field62 { get; set; }
        public int Field66 { get; set; }
        public int Field6A { get; set; }
        public int Field6E { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class SoundKitChild
    {
        [DBKey]
        public int ID { get; set; }
        public int Field00 { get; set; }
        public int Field04 { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class SoundKitEntry
    {
        [DBKey]
        public int ID { get; set; }
        public int Field00 { get; set; }
        public float Field04 { get; set; }
        public byte Field08 { get; set; }
        public int Field09 { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class SoundKitFallback
    {
        [DBKey]
        public int ID { get; set; }
        public int Field00 { get; set; }
        public int Field04 { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class SoundOverride
    {
        [DBKey]
        public int ID { get; set; }
        public int WowEditlock { get; set; }
        public string WowEditlockUser { get; set; }
        public int ZoneintroMusicID { get; set; }
        public int ZoneMusicID { get; set; }
        public int SoundAmbienceID { get; set; }
        public int SoundProviderPreferencesID { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class SoundProviderPreferences
    {
        [DBKey]
        public int ID { get; set; }
        public string Description { get; set; }
        public int Flags { get; set; }
        public int EAXEnvironmentSelection { get; set; }
        public float EAXDecayTime { get; set; }
        public float EAX2EnvironmentSize { get; set; }
        public float EAX2EnvironmentDiffusion { get; set; }
        public int EAX2Room { get; set; }
        public int EAX2RoomHF { get; set; }
        public float EAX2DecayHFRatio { get; set; }
        public int EAX2Reflections { get; set; }
        public float EAX2ReflectionsDelay { get; set; }
        public int EAX2Reverb { get; set; }
        public float EAX2ReverbDelay { get; set; }
        public float EAX2RoomRolloff { get; set; }
        public float EAX2AirAbsorption { get; set; }
        public int EAX3RoomLF { get; set; }
        public float EAX3DecayLFRatio { get; set; }
        public float EAX3EchoTime { get; set; }
        public float EAX3EchoDepth { get; set; }
        public float EAX3ModulationTime { get; set; }
        public float EAX3ModulationDepth { get; set; }
        public float EAX3HFReference { get; set; }
        public float EAX3LFReference { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class SourceInfo
    {
        [DBKey]
        public int ID { get; set; }
        public int Field00 { get; set; }
        public string Field04 { get; set; }
        public byte Field08 { get; set; }
        public byte Field09 { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class SpamMessages
    {
        [DBKey]
        public int ID { get; set; }
        public string Text { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class SpecializationSpells
    {
        [DBKey]
        public int ID { get; set; }
        public int SpellID { get; set; }
        public int OverridesSpellID { get; set; }
        public int SpecId { get; set; }
        public string Description { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class Spell
    {
        [DBKey]
        public int ID { get; set; }
        public string Name_lang { get; set; }
        public string NameSubtext_lang { get; set; }
        public string Description_lang { get; set; }
        public string AuraDescription_lang { get; set; }
        public int RuneCostID { get; set; }
        public int SpellMissileID { get; set; }
        public int DescriptionVariablesID { get; set; }
        public int ScalingID { get; set; }
        public int AuraOptionsID { get; set; }
        public int AuraRestrictionsID { get; set; }
        public int CastingRequirementsID { get; set; }
        public int CategoriesID { get; set; }
        public int ClassOptionsID { get; set; }
        public int CooldownsID { get; set; }
        public int EquippedItemsID { get; set; }
        public int InterruptsID { get; set; }
        public int LevelsID { get; set; }
        public int ReagentsID { get; set; }
        public int ShapeshiftID { get; set; }
        public int TargetRestrictionsID { get; set; }
        public int TotemsID { get; set; }
        public int RequiredProjectID { get; set; }
        public int MiscID { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class SpellActionBarPref
    {
        [DBKey]
        public int ID { get; set; }
        public int Field00 { get; set; }
        public ushort Field04 { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class SpellActivationOverlay
    {
        [DBKey]
        public int ID { get; set; }
        public int SpellID { get; set; }
        public int OverlayFileDataID { get; set; }
        public int ScreenlocationID { get; set; }
        public int Color { get; set; }
        public float Scale { get; set; }
        [DBField(ArraySize: 4)]
        public int[] IconHighlightSpellClassMask { get; set; }
        public int TriggerType { get; set; }
        public int SoundEntriesID { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class SpellAuraOptions
    {
        [DBKey]
        public int ID { get; set; }
        public int SpellID { get; set; }
        public int DifficultyID { get; set; }
        public int CumulativeAura { get; set; }
        public int ProcChance { get; set; }
        public int ProcCharges { get; set; }
        public int ProcTypeMask { get; set; }
        public int ProcCategoryRecovery { get; set; }
        public int SpellProcsPerMinuteID { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class SpellAuraRestrictions
    {
        [DBKey]
        public int ID { get; set; }
        public int Field4 { get; set; }
        public int Field8 { get; set; }
        public int FieldC { get; set; }
        public int Field10 { get; set; }
        public int Field14 { get; set; }
        public int Field18 { get; set; }
        public int Field1C { get; set; }
        public int Field20 { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class SpellAuraRestrictionsDifficulty
    {
        [DBKey]
        public int ID { get; set; }
        public int Field4 { get; set; }
        public int Field8 { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class SpellAuraVisibility
    {
        [DBKey]
        public int ID { get; set; }
        public int SpellID { get; set; }
        public int Type { get; set; }
        public int Flags { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class SpellAuraVisXChrSpec
    {
        [DBKey]
        public int ID { get; set; }
        public int SpellAuraVisibilityID { get; set; }
        public int ChrSpecializationID { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class SpellCastingRequirements
    {
        [DBKey]
        public int ID { get; set; }
        public int FacingCasterFlags { get; set; }
        public int MinFactionID { get; set; }
        public int MinReputation { get; set; }
        public int RequiredAreasID { get; set; }
        public int RequiredAuraVision { get; set; }
        public int RequiresSpellFocus { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class SpellCastTimes
    {
        [DBKey]
        public int ID { get; set; }
        public int Base { get; set; }
        public int PerLevel { get; set; }
        public int Minimum { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class SpellCategories
    {
        [DBKey]
        public int ID { get; set; }
        public int SpellID { get; set; }
        public int DifficultyID { get; set; }
        public int Category { get; set; }
        public int DefenseType { get; set; }
        public int DispelType { get; set; }
        public int Mechanic { get; set; }
        public int PreventionType { get; set; }
        public int StartRecoveryCategory { get; set; }
        public int ChargeCategory { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class SpellCategory
    {
        [DBKey]
        public int ID { get; set; }
        public int Flags { get; set; }
        [DBField(Padding: 3)]
        public byte UsesPerWeek { get; set; }
        public string Name_lang { get; set; }
        public int MaxCharges { get; set; }
        public int ChargeRecoveryTime { get; set; }
    }

    [DBTable(Expansion.WoD)]
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

    [DBTable(Expansion.WoD)]
    public class SpellClassOptions
    {
        [DBKey]
        public int ID { get; set; }
        public int Field4 { get; set; }
        [DBField(ArraySize: 4)]
        public int[] Field8 { get; set; }
        public int Field18 { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class SpellCooldowns
    {
        [DBKey]
        public int ID { get; set; }
        public int SpellID { get; set; }
        public int DifficultyID { get; set; }
        public int CategoryRecoveryTime { get; set; }
        public int RecoveryTime { get; set; }
        public int StartRecoveryTime { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class SpellDescriptionVariables
    {
        [DBKey]
        public int ID { get; set; }
        public string Variables { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class SpellDispelType
    {
        [DBKey]
        public int ID { get; set; }
        public string Name_lang { get; set; }
        public int Mask { get; set; }
        public int ImmunityPossible { get; set; }
        public string InternalName { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class SpellDuration
    {
        [DBKey]
        public int ID { get; set; }
        public int Duration { get; set; }
        public int DurationPerLevel { get; set; }
        public int MaxDuration { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class SpellEffect
    {
        [DBKey]
        public int ID { get; set; }
        public int DifficultyID { get; set; }
        public int Effect { get; set; }
        public float EffectAmplitude { get; set; }
        public int EffectAura { get; set; }
        public int EffectAuraPeriod { get; set; }
        public int EffectBasePoints { get; set; }
        public float EffectBonusCoefficient { get; set; }
        public float EffectChainAmplitude { get; set; }
        public int EffectChaintargets { get; set; }
        public int EffectDieSides { get; set; }
        public int EffectItemType { get; set; }
        public int EffectMechanic { get; set; }
        [DBField(ArraySize: 2)]
        public int[] EffectMiscValue { get; set; }
        public float EffectPointsPerResource { get; set; }
        [DBField(ArraySize: 2)]
        public int[] EffectRadiusIndex { get; set; }
        public float EffectRealPointsPerLevel { get; set; }
        [DBField(ArraySize: 4)]
        public int[] EffectSpellClassMask { get; set; }
        public int EffectTriggerSpell { get; set; }
        public float EffectPos_facing { get; set; }
        [DBField(ArraySize: 2)]
        public int[] ImplicitTarget { get; set; }
        public int SpellID { get; set; }
        public int EffectIndex { get; set; }
        public int EffectAttributes { get; set; }
        public float BonusCoefficientFromAP { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class SpellEffectCameraShakes
    {
        [DBKey]
        public int ID { get; set; }
        [DBField(ArraySize: 3)]
        public int[] Field4 { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class SpellEffectEmission
    {
        [DBKey]
        public int ID { get; set; }
        public float Field00 { get; set; }
        public float Field04 { get; set; }
        public ushort Field08 { get; set; }
        public byte Field0A { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class SpellEffectGroupSize
    {
        [DBKey]
        public int ID { get; set; }
        public int Field4 { get; set; }
        public float Field8 { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class SpellEffectScaling
    {
        [DBKey]
        public int ID { get; set; }
        public float Coefficient { get; set; }
        public float Variance { get; set; }
        public float ResourceCoefficient { get; set; }
        public int SpellEffectID { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class SpellEquippedItems
    {
        [DBKey]
        public int ID { get; set; }
        public int SpellID { get; set; }
        public int DifficultyID { get; set; }
        public int EquippedItemClass { get; set; }
        public int EquippedItemInvTypes { get; set; }
        public int EquippedItemSubclass { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class SpellFlyout
    {
        [DBKey]
        public int ID { get; set; }
        public int Flags { get; set; }
        public int RaceMask { get; set; }
        public int ClassMask { get; set; }
        public int SpellIconID { get; set; }
        public string Name_lang { get; set; }
        public string Description_lang { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class SpellFlyoutItem
    {
        [DBKey]
        public int ID { get; set; }
        public int SpellFlyoutID { get; set; }
        public int SpellID { get; set; }
        public int Slot { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class SpellFocusObject
    {
        [DBKey]
        public int ID { get; set; }
        public string Name_lang { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class SpellIcon
    {
        [DBKey]
        public int ID { get; set; }
        public string TextureFileName { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class Spellinterrupts
    {
        [DBKey]
        public int ID { get; set; }
        public int SpellID { get; set; }
        public int DifficultyID { get; set; }
        [DBField(ArraySize: 2)]
        public int[] AurainterruptFlags { get; set; }
        [DBField(ArraySize: 2)]
        public int[] ChannelinterruptFlags { get; set; }
        public int InterruptFlags { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class SpellItemEnchantment
    {
        [DBKey]
        public int ID { get; set; }
        public int Charges { get; set; }
        [DBField(ArraySize: 3)]
        public int[] Effect { get; set; }
        [DBField(ArraySize: 3)]
        public int[] EffectPointsMin { get; set; }
        [DBField(ArraySize: 3)]
        public int[] EffectArg { get; set; }
        public string Name_lang { get; set; }
        public int ItemVisual { get; set; }
        public int Flags { get; set; }
        public int Src_itemID { get; set; }
        public int Condition_id { get; set; }
        public int RequiredSkillID { get; set; }
        public int RequiredSkillRank { get; set; }
        public int MinLevel { get; set; }
        public int MaxLevel { get; set; }
        public int ItemLevel { get; set; }
        public int ScalingClass { get; set; }
        public int ScalingClassRestricted { get; set; }
        [DBField(ArraySize: 3)]
        public float[] EffectScalingPoints { get; set; }
    }

    [DBTable(Expansion.WoD)]
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

    [DBTable(Expansion.WoD)]
    public class SpellKeyboundOverride
    {
        [DBKey]
        public int ID { get; set; }
        public string Function { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class SpellLabel
    {
        [DBKey]
        public int ID { get; set; }
        public int Field00 { get; set; }
        public int Field04 { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class SpellLearnSpell
    {
        [DBKey]
        public int ID { get; set; }
        public int LearnSpellID { get; set; }
        public int OverridesSpellID { get; set; }
        public int SpellID { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class SpellLevels
    {
        [DBKey]
        public int ID { get; set; }
        public int SpellID { get; set; }
        public int DifficultyID { get; set; }
        public int BaseLevel { get; set; }
        public int MaxLevel { get; set; }
        public int SpellLevel { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class SpellMechanic
    {
        [DBKey]
        public int ID { get; set; }
        public string StateName_lang { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class SpellMisc
    {
        [DBKey]
        public int ID { get; set; }
        [DBField(ArraySize: 14)]
        public int[] Attributes { get; set; }
        public int CastingTimeIndex { get; set; }
        public int DurationIndex { get; set; }
        public int RangeIndex { get; set; }
        public float Speed { get; set; }
        public int SpellIconID { get; set; }
        public int ActiveIconID { get; set; }
        public int SchoolMask { get; set; }
        public float MultistrikeSpeedMod { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class SpellMiscDifficulty
    {
        [DBKey]
        public int ID { get; set; }
        public int Field00 { get; set; }
        public byte Field04 { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class SpellMissile
    {
        [DBKey]
        public int ID { get; set; }
        public int Field4 { get; set; }
        public float Field8 { get; set; }
        public float FieldC { get; set; }
        public float Field10 { get; set; }
        public float Field14 { get; set; }
        public float Field18 { get; set; }
        public float Field1C { get; set; }
        public float Field20 { get; set; }
        public float Field24 { get; set; }
        public float Field28 { get; set; }
        public float Field2C { get; set; }
        public float Field30 { get; set; }
        public float Field34 { get; set; }
        public float Field38 { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class SpellMissileMotion
    {
        [DBKey]
        public int ID { get; set; }
        public string Field4 { get; set; }
        public string Field8 { get; set; }
        public int FieldC { get; set; }
        public int Field10 { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class SpellPower
    {
        [DBKey]
        public int ID { get; set; }
        public int Field4 { get; set; }
        public int Field8 { get; set; }
        public int FieldC { get; set; }
        public int Field10 { get; set; }
        public int Field14 { get; set; }
        public int Field18 { get; set; }
        public int Field1C { get; set; }
        public int Field20 { get; set; }
        public float Field24 { get; set; }
        public float Field28 { get; set; }
        public int Field2C { get; set; }
        public float Field30 { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class SpellPowerDifficulty
    {
        [DBKey]
        public int ID { get; set; }
        public int Field4 { get; set; }
        public int Field8 { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class SpellProceduralEffect
    {
        [DBField(ArraySize: 4)]
        public float[] Field00 { get; set; }
        public byte Field10 { get; set; }
        [DBKey]
        public int ID { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class SpellProcsPerMinute
    {
        [DBKey]
        public int ID { get; set; }
        public float BaseProcRate { get; set; }
        public int Flags { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class SpellProcsPerMinuteMod
    {
        [DBKey]
        public int ID { get; set; }
        public int Type { get; set; }
        public int Param { get; set; }
        public float Coeff { get; set; }
        public int SpellProcsPerMinuteID { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class SpellRadius
    {
        [DBKey]
        public int ID { get; set; }
        public float Radius { get; set; }
        public float RadiusPerLevel { get; set; }
        public float RadiusMin { get; set; }
        public float RadiusMax { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class SpellRange
    {
        [DBKey]
        public int ID { get; set; }
        [DBField(ArraySize: 2)]
        public float[] RangeMin { get; set; }
        [DBField(ArraySize: 2)]
        public float[] RangeMax { get; set; }
        public int Flags { get; set; }
        public string DisplayName_lang { get; set; }
        public string DisplayNameShort_lang { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class SpellReagents
    {
        [DBKey]
        public int ID { get; set; }
        public int SpellID { get; set; }
        [DBField(ArraySize: 8)]
        public int[] Reagent { get; set; }
        [DBField(ArraySize: 8)]
        public ushort[] ReagentCount { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class SpellReagentsCurrency
    {
        [DBKey]
        public int ID { get; set; }
        public int Field00 { get; set; }
        public ushort Field04 { get; set; }
        public ushort Field06 { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class SpellRuneCost
    {
        [DBKey]
        public int ID { get; set; }
        public int Blood { get; set; }
        public int Unholy { get; set; }
        public int Frost { get; set; }
        public int Chromatic { get; set; }
        public int RunicPower { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class SpellScaling
    {
        [DBKey]
        public int ID { get; set; }
        public int CastTimeMin { get; set; }
        public int CastTimeMax { get; set; }
        public int CastTimeMaxLevel { get; set; }
        public int Class { get; set; }
        public float NerfFactor { get; set; }
        public int NerfMaxLevel { get; set; }
        public int MaxScalingLevel { get; set; }
        public int ScalesFromItemLevel { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class SpellShapeshift
    {
        [DBKey]
        public int ID { get; set; }
        [DBField(ArraySize: 2)]
        public int[] ShapeshiftExclude { get; set; }
        [DBField(ArraySize: 2)]
        public int[] ShapeshiftMask { get; set; }
        public int StanceBarOrder { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class SpellShapeshiftForm
    {
        [DBKey]
        public int ID { get; set; }
        public int BonusActionBar { get; set; }
        public string Name_lang { get; set; }
        public int Flags { get; set; }
        public int CreatureType { get; set; }
        public int AttackIconID { get; set; }
        public int CombatRoundTime { get; set; }
        [DBField(ArraySize: 4)]
        public int[] CreatureDisplayID { get; set; }
        [DBField(ArraySize: 8)]
        public int[] PresetSpellID { get; set; }
        public int MountTypeID { get; set; }
        public int ExitSoundEntriesID { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class SpellSpecialUnitEffect
    {
        [DBKey]
        public int EnumID { get; set; }
        public int SpellVisualEffectNameID { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class SpellTargetRestrictions
    {
        [DBKey]
        public int ID { get; set; }
        public int SpellID { get; set; }
        public int DifficultyID { get; set; }
        public float ConeAngle { get; set; }
        public float Width { get; set; }
        public int MaxTargets { get; set; }
        public int MaxTargetLevel { get; set; }
        public int TargetCreatureType { get; set; }
        public int Targets { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class SpellTotems
    {
        [DBKey]
        public int ID { get; set; }
        [DBField(ArraySize: 2)]
        public int[] RequiredTotemCategoryID { get; set; }
        [DBField(ArraySize: 2)]
        public int[] Totem { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class SpellVisual
    {
        [DBKey]
        public int ID { get; set; }
        public int Field4 { get; set; }
        public int Field8 { get; set; }
        public int FieldC { get; set; }
        public int Field10 { get; set; }
        public int Field14 { get; set; }
        public int Field18 { get; set; }
        public int Field1C { get; set; }
        public int Field20 { get; set; }
        public int Field24 { get; set; }
        public int Field28 { get; set; }
        public int Field2C { get; set; }
        public int Field30 { get; set; }
        public int Field34 { get; set; }
        public int Field38 { get; set; }
        public int Field3C { get; set; }
        public int Field40 { get; set; }
        public int Field44 { get; set; }
        public int Field48 { get; set; }
        [DBField(ArraySize: 3)]
        public float[] Field4C { get; set; }
        [DBField(ArraySize: 3)]
        public float[] Field58 { get; set; }
        public int Field64 { get; set; }
        public int Field68 { get; set; }
        public int Field6C { get; set; }
        public int Field70 { get; set; }
        public int Field74 { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class SpellVisualAnim
    {
        [DBKey]
        public int ID { get; set; }
        public ushort Field00 { get; set; }
        public ushort Field02 { get; set; }
        public ushort Field04 { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class SpellVisualColorEffect
    {
        [DBKey]
        public int ID { get; set; }
        public float Field00 { get; set; }
        public int Field04 { get; set; }
        public float Field08 { get; set; }
        public ushort Field0C { get; set; }
        public ushort Field0E { get; set; }
        public ushort Field10 { get; set; }
        public ushort Field12 { get; set; }
        public ushort Field14 { get; set; }
        public byte Field16 { get; set; }
        public byte Field17 { get; set; }
        public int Field18 { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class SpellVisualEffectName
    {
        [DBKey]
        public int ID { get; set; }
        public string Field4 { get; set; }
        public float Field8 { get; set; }
        public float FieldC { get; set; }
        public float Field10 { get; set; }
        public float Field14 { get; set; }
        public byte Field18 { get; set; }
        public float Field1C { get; set; }
        public int Field20 { get; set; }
        public int Field24 { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class SpellVisualKit
    {
        [DBKey]
        public int ID { get; set; }
        public int Field4 { get; set; }
        public int Field8 { get; set; }
        public int FieldC { get; set; }
        public int Field10 { get; set; }
        public int Field14 { get; set; }
        public int Field18 { get; set; }
        public int Field1C { get; set; }
        public int Field20 { get; set; }
        public int Field24 { get; set; }
        public int Field28 { get; set; }
        public int Field2C { get; set; }
        [DBField(ArraySize: 3)]
        public int[] Field30 { get; set; }
        public int Field3C { get; set; }
        public int Field40 { get; set; }
        public int Field44 { get; set; }
        [DBField(ArraySize: 4)]
        public int[] Field48 { get; set; }
        [DBField(ArraySize: 4)]
        public float[] Field58 { get; set; }
        [DBField(ArraySize: 4)]
        public float[] Field68 { get; set; }
        [DBField(ArraySize: 4)]
        public float[] Field78 { get; set; }
        [DBField(ArraySize: 4)]
        public float[] Field88 { get; set; }
        public int Field98 { get; set; }
        public float Field9C { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class SpellVisualKitAreaModel
    {
        [DBKey]
        public int ID { get; set; }
        public int Field4 { get; set; }
        public int Field8 { get; set; }
        public int FieldC { get; set; }
        public float Field10 { get; set; }
        public float Field14 { get; set; }
        public float Field18 { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class SpellVisualKitEffect
    {
        [DBKey]
        public int ID { get; set; }
        public int Field00 { get; set; }
        public int Field04 { get; set; }
        public int Field08 { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class SpellVisualKitModelAttach
    {
        [DBKey]
        public int ID { get; set; }
        public int Field4 { get; set; }
        public int Field8 { get; set; }
        public int FieldC { get; set; }
        [DBField(ArraySize: 3)]
        public float[] Field10 { get; set; }
        public float Field1C { get; set; }
        public float Field20 { get; set; }
        public float Field24 { get; set; }
        public int Field28 { get; set; }
        public int Field2C { get; set; }
        public int Field30 { get; set; }
        public int Field34 { get; set; }
        public int Field38 { get; set; }
        public int Field3C { get; set; }
        public int Field40 { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class SpellVisualMissile
    {
        [DBKey]
        public int ID { get; set; }
        public int Field4 { get; set; }
        public int Field8 { get; set; }
        public int FieldC { get; set; }
        public int Field10 { get; set; }
        public int Field14 { get; set; }
        public int Field18 { get; set; }
        public int Field1C { get; set; }
        public int Field20 { get; set; }
        public int Field24 { get; set; }
        public int Field28 { get; set; }
        [DBField(ArraySize: 3)]
        public float[] Field2C { get; set; }
        [DBField(ArraySize: 3)]
        public float[] Field38 { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class SpellXSpellVisual
    {
        [DBKey]
        public int ID { get; set; }
        public float Unk620 { get; set; }
        [DBField(ArraySize: 2)]
        public ushort[] SpellVisualID { get; set; }
        public ushort PlayerConditionID { get; set; }
        public byte DifficultyID { get; set; }
        public byte Flags { get; set; }
        public int SpellID { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class Startup_strings
    {
        [DBKey]
        public int ID { get; set; }
        public string Name { get; set; }
        public string Message_lang { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class Stationery
    {
        [DBKey]
        public int ID { get; set; }
        public int ItemID { get; set; }
        public string Texture { get; set; }
        public int Flags { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class StringLookups
    {
        [DBKey]
        public int ID { get; set; }
        public string String { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class SummonProperties
    {
        [DBKey]
        public int Id { get; set; }
        public int Control { get; set; }
        public int Faction { get; set; }
        public int Title { get; set; }
        public int Slot { get; set; }
        public int Flags { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class TactKey
    {
        [DBKey]
        public int ID { get; set; }
        [DBField(ArraySize: 16)]
        public byte[] Field00 { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class TactKeyLookup
    {
        [DBKey]
        public int ID { get; set; }
        [DBField(ArraySize: 8)]
        public byte[] Field00 { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class Talent
    {
        [DBKey]
        public int ID { get; set; }
        public int SpecID { get; set; }
        public int TierID { get; set; }
        public int ColumnIndex { get; set; }
        public int SpellID { get; set; }
        public int Flags { get; set; }
        [DBField(ArraySize: 2)]
        public int[] CategoryMask { get; set; }
        public int ClassID { get; set; }
        public int OverridesSpellID { get; set; }
        public string Description_lang { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class TaxiNodes
    {
        [DBKey]
        public int ID { get; set; }
        public int ContinentID { get; set; }
        [DBField(ArraySize: 3)]
        public float[] Pos { get; set; }
        public string Name_lang { get; set; }
        [DBField(ArraySize: 2)]
        public int[] MountCreatureID { get; set; }
        public int ConditionID { get; set; }
        public int LearnableIndex { get; set; }
        public int Flags { get; set; }
        [DBField(ArraySize: 2)]
        public float[] MapOffset { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class TaxiPath
    {
        [DBKey]
        public int ID { get; set; }
        public int FromTaxiNode { get; set; }
        public int ToTaxiNode { get; set; }
        public int Cost { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class TaxiPathNode
    {
        [DBKey]
        public int ID { get; set; }
        public int PathID { get; set; }
        public int NodeIndex { get; set; }
        public int ContinentID { get; set; }
        [DBField(ArraySize: 3)]
        public float[] Loc { get; set; }
        public int Flags { get; set; }
        public int Delay { get; set; }
        public int ArrivalEventID { get; set; }
        public int DepartureEventID { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class TerrainMaterial
    {
        [DBKey]
        public int ID { get; set; }
        public string Name { get; set; }
        public int Shader { get; set; }
        public string EnvMapPath { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class TerrainType
    {
        [DBKey]
        public int ID { get; set; }
        public int TerrainID { get; set; }
        public string TerrainDesc { get; set; }
        public int FootstepSprayRun { get; set; }
        public int FootstepSprayWalk { get; set; }
        public int SoundID { get; set; }
        public int Flags { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class TerrainTypeSounds
    {
        [DBKey]
        public int ID { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class TextureBlendSet
    {
        [DBKey]
        public int ID { get; set; }
        [DBField(ArraySize: 3)]
        public int[] Field00 { get; set; }
        [DBField(ArraySize: 3)]
        public float[] Field0C { get; set; }
        [DBField(ArraySize: 3)]
        public float[] Field18 { get; set; }
        [DBField(ArraySize: 3)]
        public float[] Field24 { get; set; }
        [DBField(ArraySize: 3)]
        public float[] Field30 { get; set; }
        [DBField(ArraySize: 4)]
        public float[] Field3C { get; set; }
        public byte Field4C { get; set; }
        public byte Field4D { get; set; }
        public byte Field4E { get; set; }
        public byte Field4F { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class TextureFileData
    {
        [DBKey]
        public int ID { get; set; }
        public int Field4 { get; set; }
        public int Field8 { get; set; }
        public int FieldC { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class TotemCategory
    {
        [DBKey]
        public int ID { get; set; }
        public string Name_lang { get; set; }
        public int TotemCategoryType { get; set; }
        public int TotemCategoryMask { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class Toy
    {
        [DBKey]
        public int ID { get; set; }
        public int ItemId { get; set; }
        public int Unknown { get; set; }
        public string SourceText { get; set; }
        public int SourceType { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class TradeSkillCategory
    {
        [DBKey]
        public int Id { get; set; }
        public int Skilllineid { get; set; }
        public int Parenttradeskillcategoryid { get; set; }
        public int Orderindex { get; set; }
        public string Name_lang { get; set; }
        public int Flags { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class TradeSkillItem
    {
        [DBKey]
        public int ID { get; set; }
        public ushort Field00 { get; set; }
        public byte Field02 { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class TransformMatrix
    {
        [DBKey]
        public int ID { get; set; }
        [DBField(ArraySize: 3)]
        public float[] Field00 { get; set; }
        public float Field0C { get; set; }
        public float Field10 { get; set; }
        public float Field14 { get; set; }
        public float Field18 { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class TransmogSet
    {
        [DBKey]
        public int ID { get; set; }
        public int Field04 { get; set; }
        public int Field08 { get; set; }
        public int Field0C { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class TransmogSetItem
    {
        [DBKey]
        public int ID { get; set; }
        public int Field04 { get; set; }
        public int Field08 { get; set; }
        public int Field0C { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class TransportAnimation
    {
        [DBKey]
        public int ID { get; set; }
        public int TransportID { get; set; }
        public int TimeIndex { get; set; }
        [DBField(ArraySize: 3)]
        public float[] Pos { get; set; }
        public int SequenceID { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class TransportPhysics
    {
        [DBKey]
        public int ID { get; set; }
        public float WaveAmp { get; set; }
        public float WaveTimeScale { get; set; }
        public float RollAmp { get; set; }
        public float RollTimeScale { get; set; }
        public float PitchAmp { get; set; }
        public float PitchTimeScale { get; set; }
        public float MaxBank { get; set; }
        public float MaxBankTurnSpeed { get; set; }
        public float SpeedDampThresh { get; set; }
        public float SpeedDamp { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class TransportRotation
    {
        [DBKey]
        public int ID { get; set; }
        public int GameObjectsID { get; set; }
        public int TimeIndex { get; set; }
        [DBField(ArraySize: 4)]
        public float[] Rot { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class Trophy
    {
        [DBKey]
        public int ID { get; set; }
        public int Field4 { get; set; }
        public int Field8 { get; set; }
        public int FieldC { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class TrophyInstance
    {
        [DBKey]
        public int ID { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class TrophyType
    {
        [DBKey]
        public int ID { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class UiCamera
    {
        [DBKey]
        public int ID { get; set; }
        public string Field00 { get; set; }
        [DBField(ArraySize: 3)]
        public float[] Field04 { get; set; }
        [DBField(ArraySize: 3)]
        public float[] Field10 { get; set; }
        [DBField(ArraySize: 3)]
        public float[] Field1C { get; set; }
        public ushort Field28 { get; set; }
        public byte Field2A { get; set; }
        public byte Field2B { get; set; }
        public byte Field2C { get; set; }
        public int Field2D { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class UiCameraType
    {
        [DBKey]
        public int ID { get; set; }
        public string Field00 { get; set; }
        public int Field04 { get; set; }
        public int Field08 { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class UiCamFbackTransmogChrRace
    {
        [DBKey]
        public int ID { get; set; }
        public ushort Field00 { get; set; }
        public byte Field02 { get; set; }
        public byte Field03 { get; set; }
        public byte Field04 { get; set; }
        public byte Field05 { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class UiCamFbackTransmogWeapon
    {
        [DBKey]
        public int ID { get; set; }
        public ushort Field00 { get; set; }
        public byte Field02 { get; set; }
        public byte Field03 { get; set; }
        public byte Field04 { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class UiMapPOI
    {
        public int Field00 { get; set; }
        [DBField(ArraySize: 3)]
        public float[] Field04 { get; set; }
        public int Field10 { get; set; }
        public int Field14 { get; set; }
        public int Field18 { get; set; }
        public int Field1C { get; set; }
        [DBKey]
        public int ID { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class UiTextureAtlas
    {
        [DBKey]
        public int ID { get; set; }
        public int Field4 { get; set; }
        public int Field8 { get; set; }
        public int FieldC { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class UiTextureAtlasMember
    {
        [DBKey]
        public int ID { get; set; }
        public string Field4 { get; set; }
        public int Field8 { get; set; }
        public int FieldC { get; set; }
        public int Field10 { get; set; }
        public int Field14 { get; set; }
        public int Field18 { get; set; }
        public int Field1C { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class UiTextureKit
    {
        [DBKey]
        public int ID { get; set; }
        public string Field4 { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class UnitBlood
    {
        [DBKey]
        public int ID { get; set; }
        [DBField(ArraySize: 2)]
        public int[] CombatBloodSpurtFront { get; set; }
        [DBField(ArraySize: 2)]
        public int[] CombatBloodSpurtBack { get; set; }
        [DBField(ArraySize: 5)]
        public string[] GroundBlood { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class UnitBloodLevels
    {
        [DBKey]
        public int ID { get; set; }
        [DBField(ArraySize: 3)]
        public int[] Violencelevel { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class UnitCondition
    {
        [DBKey]
        public int ID { get; set; }
        public int Flags { get; set; }
        [DBField(ArraySize: 8)]
        public int[] Variable { get; set; }
        [DBField(ArraySize: 8)]
        public int[] Op { get; set; }
        [DBField(ArraySize: 8)]
        public int[] Value { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class UnitPowerBar
    {
        [DBKey]
        public int ID { get; set; }
        public int MinPower { get; set; }
        public int MaxPower { get; set; }
        public int StartPower { get; set; }
        public int CenterPower { get; set; }
        public float RegenerationPeace { get; set; }
        public float RegenerationCombat { get; set; }
        public int BarType { get; set; }
        [DBField(ArraySize: 6)]
        public int[] FileDataID { get; set; }
        [DBField(ArraySize: 6)]
        public int[] Color { get; set; }
        public int Flags { get; set; }
        public string Name_lang { get; set; }
        public string Cost_lang { get; set; }
        public string OutOfError_lang { get; set; }
        public string ToolTip_lang { get; set; }
        public float StartInset { get; set; }
        public float EndInset { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class Vehicle
    {
        [DBKey]
        public int ID { get; set; }
        public int Flags { get; set; }
        public int FlagsB { get; set; }
        public float TurnSpeed { get; set; }
        public float PitchSpeed { get; set; }
        public float PitchMin { get; set; }
        public float PitchMax { get; set; }
        [DBField(ArraySize: 8)]
        public int[] SeatID { get; set; }
        public float MouseLookOffsetPitch { get; set; }
        public float CameraFadeDistScalarMin { get; set; }
        public float CameraFadeDistScalarMax { get; set; }
        public float CameraPitchOffset { get; set; }
        public float FacingLimitRight { get; set; }
        public float FacingLimitLeft { get; set; }
        public float MsslTrgtTurnLingering { get; set; }
        public float MsslTrgtPitchLingering { get; set; }
        public float MsslTrgtMouseLingering { get; set; }
        public float MsslTrgtEndOpacity { get; set; }
        public float MsslTrgtArcSpeed { get; set; }
        public float MsslTrgtArcRepeat { get; set; }
        public float MsslTrgtArcWidth { get; set; }
        [DBField(ArraySize: 2)]
        public float[] MsslTrgtImpactRadius { get; set; }
        public string MsslTrgtArcTexture { get; set; }
        public string MsslTrgtImpactTexture { get; set; }
        [DBField(ArraySize: 2)]
        public string[] MsslTrgtImpactModel { get; set; }
        public float CameraYawOffset { get; set; }
        public int UilocomotionType { get; set; }
        public float MsslTrgtImpactTexRadius { get; set; }
        public int VehicleUIIndicatorID { get; set; }
        [DBField(ArraySize: 3)]
        public int[] PowerDisplayID { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class VehicleSeat
    {
        [DBKey]
        public int ID { get; set; }
        public int Flags { get; set; }
        public int AttachmentID { get; set; }
        [DBField(ArraySize: 3)]
        public float[] AttachmentOffset { get; set; }
        public float EnterPreDelay { get; set; }
        public float EnterSpeed { get; set; }
        public float EnterGravity { get; set; }
        public float EnterMinDuration { get; set; }
        public float EnterMaxDuration { get; set; }
        public float EnterMinArcHeight { get; set; }
        public float EnterMaxArcHeight { get; set; }
        public int EnterAnimStart { get; set; }
        public int EnterAnimLoop { get; set; }
        public int RideAnimStart { get; set; }
        public int RideAnimLoop { get; set; }
        public int RideUpperAnimStart { get; set; }
        public int RideUpperAnimLoop { get; set; }
        public float ExitPreDelay { get; set; }
        public float ExitSpeed { get; set; }
        public float ExitGravity { get; set; }
        public float ExitMinDuration { get; set; }
        public float ExitMaxDuration { get; set; }
        public float ExitMinArcHeight { get; set; }
        public float ExitMaxArcHeight { get; set; }
        public int ExitAnimStart { get; set; }
        public int ExitAnimLoop { get; set; }
        public int ExitAnimEnd { get; set; }
        public float PassengerYaw { get; set; }
        public float PassengerPitch { get; set; }
        public float PassengerRoll { get; set; }
        public int PassengerAttachmentID { get; set; }
        public int VehicleEnterAnim { get; set; }
        public int VehicleExitAnim { get; set; }
        public int VehicleRideAnimLoop { get; set; }
        public int VehicleEnterAnimBone { get; set; }
        public int VehicleExitAnimBone { get; set; }
        public int VehicleRideAnimLoopBone { get; set; }
        public float VehicleEnterAnimDelay { get; set; }
        public float VehicleExitAnimDelay { get; set; }
        public int VehicleAbilityDisplay { get; set; }
        public int EnterUISoundID { get; set; }
        public int ExitUISoundID { get; set; }
        public int FlagsB { get; set; }
        public float CameraEnteringDelay { get; set; }
        public float CameraEnteringDuration { get; set; }
        public float CameraExitingDelay { get; set; }
        public float CameraExitingDuration { get; set; }
        [DBField(ArraySize: 3)]
        public float[] CameraOffset { get; set; }
        public float CameraPosChaseRate { get; set; }
        public float CameraFacingChaseRate { get; set; }
        public float CameraEnteringZoom { get; set; }
        public float CameraSeatZoomMin { get; set; }
        public float CameraSeatZoomMax { get; set; }
        public int EnterAnimKitID { get; set; }
        public int RideAnimKitID { get; set; }
        public int ExitAnimKitID { get; set; }
        public int VehicleEnterAnimKitID { get; set; }
        public int VehicleRideAnimKitID { get; set; }
        public int VehicleExitAnimKitID { get; set; }
        public int CameraModeID { get; set; }
        public int FlagsC { get; set; }
        public int UiSkinFileDataID { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class VehicleUIIndicator
    {
        [DBKey]
        public int ID { get; set; }
        public string BackgroundTexture { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class VehicleUIIndSeat
    {
        [DBKey]
        public int ID { get; set; }
        public int VehicleUIIndicatorID { get; set; }
        public int VirtualSeatIndex { get; set; }
        public float XPos { get; set; }
        public float YPos { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class VideoHardware
    {
        [DBKey]
        public int ID { get; set; }
        public int VendorID { get; set; }
        public int DeviceID { get; set; }
        public int FarclipIdx { get; set; }
        public int TerrainLODDistIdx { get; set; }
        public int TerrainShadowLOD { get; set; }
        public int DetailDoodadDensityIdx { get; set; }
        public int DetailDoodadAlpha { get; set; }
        public int AnimatingDoodadIdx { get; set; }
        public int Trilinear { get; set; }
        public int NumLights { get; set; }
        public int Specularity { get; set; }
        public int WaterLODIdx { get; set; }
        public int ParticleDensityIdx { get; set; }
        public int UnitDrawDistIdx { get; set; }
        public int SmallCullDistIdx { get; set; }
        public int ResolutionIdx { get; set; }
        public int BaseMipLevel { get; set; }
        public string OglOverrides { get; set; }
        public string D3dOverrides { get; set; }
        public int FixLag { get; set; }
        public int Multisample { get; set; }
        public int Atlasdisable { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class Vignette
    {
        [DBKey]
        public int ID { get; set; }
        public string Field4 { get; set; }
        public int Field8 { get; set; }
        public int FieldC { get; set; }
        public float Field10 { get; set; }
        public float Field14 { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class VocalUISounds
    {
        [DBKey]
        public int ID { get; set; }
        public int VocalUIEnum { get; set; }
        public int RaceID { get; set; }
        [DBField(ArraySize: 2)]
        public int[] NormalSoundID { get; set; }
        [DBField(ArraySize: 2)]
        public int[] PissedSoundID { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class WbAccessControlList
    {
        [DBKey]
        public int ID { get; set; }
        public string Field4 { get; set; }
        public int Field8 { get; set; }
        public int FieldC { get; set; }
        public int Field10 { get; set; }
        public int Field14 { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class WbCertBlacklist
    {
        [DBKey]
        public int ID { get; set; }
        public string Field4 { get; set; }
        [DBField(ArraySize: 20)]
        public byte[] Field8 { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class WbCertWhitelist
    {
        [DBKey]
        public int ID { get; set; }
        public string Field4 { get; set; }
        public byte Field8 { get; set; }
        [DBField(Padding: 2)]
        public byte Field9 { get; set; }
        public int FieldC { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class WbPermissions
    {
        [DBKey]
        public int ID { get; set; }
        public string Field4 { get; set; }
        public int Field8 { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class WeaponImpactSounds
    {
        [DBKey]
        public int ID { get; set; }
        public int WeaponSubClassID { get; set; }
        public int ParrySoundType { get; set; }
        [DBField(ArraySize: 10)]
        public int[] ImpactSoundID { get; set; }
        [DBField(ArraySize: 10)]
        public int[] CritImpactSoundID { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class WeaponSwingSounds2
    {
        [DBKey]
        public int ID { get; set; }
        public int SwingType { get; set; }
        public int Crit { get; set; }
        public int SoundID { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class WeaponTrail
    {
        [DBKey]
        public int ID { get; set; }
        public int Field4 { get; set; }
        public float Field8 { get; set; }
        public float FieldC { get; set; }
        public float Field10 { get; set; }
        public float Field14 { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class WeaponTrailModelDef
    {
        [DBKey]
        public int ID { get; set; }
        public int Field00 { get; set; }
        public ushort Field04 { get; set; }
        public ushort Field06 { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class WeaponTrailParam
    {
        [DBKey]
        public int ID { get; set; }
        public float Field00 { get; set; }
        public float Field04 { get; set; }
        public float Field08 { get; set; }
        public float Field0C { get; set; }
        public float Field10 { get; set; }
        public ushort Field14 { get; set; }
        public byte Field16 { get; set; }
        public byte Field17 { get; set; }
        public byte Field18 { get; set; }
        public byte Field19 { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class Weather
    {
        [DBKey]
        public int ID { get; set; }
        public int AmbienceID { get; set; }
        public int Type { get; set; }
        public int EffectType { get; set; }
        [DBField(ArraySize: 2)]
        public float[] Intensity { get; set; }
        public float TransitionSkyBox { get; set; }
        [DBField(ArraySize: 3)]
        public float[] EffectColor { get; set; }
        public string EffectTexture { get; set; }
        public int SoundAmbienceID { get; set; }
        public int WindSettingsID { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class WindSettings
    {
        [DBKey]
        public int ID { get; set; }
        public float Field4 { get; set; }
        [DBField(ArraySize: 3)]
        public float[] Field8 { get; set; }
        public float Field14 { get; set; }
        public float Field18 { get; set; }
        [DBField(ArraySize: 3)]
        public float[] Field1C { get; set; }
        public float Field28 { get; set; }
        [DBField(ArraySize: 3)]
        public float[] Field2C { get; set; }
        public int Field38 { get; set; }
        public int Field3C { get; set; }
        public int Field40 { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class WMOAreaTable
    {
        [DBKey]
        public int ID { get; set; }
        public int WMOID { get; set; }
        public int NameSetID { get; set; }
        public int WMOGroupID { get; set; }
        public int SoundProviderPref { get; set; }
        public int SoundProviderPrefUnderwater { get; set; }
        public int AmbienceID { get; set; }
        public int ZoneMusic { get; set; }
        public int IntroSound { get; set; }
        public int Flags { get; set; }
        public int AreaTableID { get; set; }
        public string AreaName_lang { get; set; }
        public int UwintroSound { get; set; }
        public int UwZoneMusic { get; set; }
        public int UwAmbience { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class WmoMinimapTexture
    {
        [DBKey]
        public int ID { get; set; }
        public int Field00 { get; set; }
        public ushort Field04 { get; set; }
        public ushort Field06 { get; set; }
        public byte Field08 { get; set; }
        public byte Field09 { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class World_PVP_Area
    {
        [DBKey]
        public int ID { get; set; }
        public int Area_ID { get; set; }
        public int Next_time_worldstate { get; set; }
        public int Game_time_worldstate { get; set; }
        public int Battle_populate_time { get; set; }
        public int Min_level { get; set; }
        public int Max_level { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class WorldBosslockout
    {
        [DBKey]
        public int ID { get; set; }
        public string Field4 { get; set; }
        public int Field8 { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class WorldChunkSounds
    {
        [DBKey]
        public int ID { get; set; }
        public int MapID { get; set; }
        public int ChunkX { get; set; }
        public int ChunkY { get; set; }
        public int SubchunkX { get; set; }
        public int SubchunkY { get; set; }
        public int SoundOverrideID { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class WorldEffect
    {
        [DBKey]
        public int ID { get; set; }
        public int TargetType { get; set; }
        public int TargetAsset { get; set; }
        public int QuestFeedbackEffectID { get; set; }
        public int PlayerConditionID { get; set; }
        public int CombatConditionID { get; set; }
        public int WhenToDisplay { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class WorldElapsedTimer
    {
        [DBKey]
        public int ID { get; set; }
        public string Name_lang { get; set; }
        public int Flags { get; set; }
        public int Type { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class WorldMapArea
    {
        [DBKey]
        public int ID { get; set; }
        public int MapID { get; set; }
        public int AreaID { get; set; }
        public string AreaName { get; set; }
        public float LocLeft { get; set; }
        public float LocRight { get; set; }
        public float LocTop { get; set; }
        public float LocBottom { get; set; }
        public int DisplayMapID { get; set; }
        public int DefaultDungeonFloor { get; set; }
        public int ParentWorldMapID { get; set; }
        public int Flags { get; set; }
        public int LevelRangeMin { get; set; }
        public int LevelRangeMax { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class WorldMapContinent
    {
        [DBKey]
        public int ID { get; set; }
        public int MapID { get; set; }
        public int LeftBoundary { get; set; }
        public int RightBoundary { get; set; }
        public int TopBoundary { get; set; }
        public int BottomBoundary { get; set; }
        [DBField(ArraySize: 2)]
        public float[] ContinentOffset { get; set; }
        public float Scale { get; set; }
        [DBField(ArraySize: 2)]
        public float[] TaxiMin { get; set; }
        [DBField(ArraySize: 2)]
        public float[] TaxiMax { get; set; }
        public int WorldMapID { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class WorldMapOverlay
    {
        [DBKey]
        public int ID { get; set; }
        public int MapAreaID { get; set; }
        [DBField(ArraySize: 4)]
        public int[] AreaID { get; set; }
        public string TextureName { get; set; }
        public int TextureWidth { get; set; }
        public int TextureHeight { get; set; }
        public int OffsetX { get; set; }
        public int OffsetY { get; set; }
        public int HitRectTop { get; set; }
        public int HitRectLeft { get; set; }
        public int HitRectBottom { get; set; }
        public int HitRectRight { get; set; }
        public int PlayerConditionID { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class WorldMapTransforms
    {
        [DBKey]
        public int ID { get; set; }
        public int MapID { get; set; }
        [DBField(ArraySize: 3)]
        public float[] RegionMin { get; set; }
        [DBField(ArraySize: 3)]
        public float[] RegionMax { get; set; }
        public int NewMapID { get; set; }
        [DBField(ArraySize: 2)]
        public float[] RegionOffset { get; set; }
        public int NewDungeonMapID { get; set; }
        public int Flags { get; set; }
        public int NewAreaID { get; set; }
        public float RegionScale { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class WorldSafelocs
    {
        [DBKey]
        public int ID { get; set; }
        public int Continent { get; set; }
        [DBField(ArraySize: 3)]
        public float[] Loc { get; set; }
        public float Facing { get; set; }
        public string AreaName_lang { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class WorldState
    {
        [DBKey]
        public int ID { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class WorldStateExpression
    {
        [DBKey]
        public int ID { get; set; }
        public string Expression { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class WorldStateUI
    {
        [DBKey]
        public int ID { get; set; }
        public int MapID { get; set; }
        public int AreaID { get; set; }
        public int PhaseUseFlags { get; set; }
        public int PhaseID { get; set; }
        public int PhaseGroupID { get; set; }
        public string Icon { get; set; }
        public string String_lang { get; set; }
        public string Tooltip_lang { get; set; }
        public int StateVariable { get; set; }
        public int Type { get; set; }
        public string DynamicIcon { get; set; }
        public string DynamicTooltip_lang { get; set; }
        public string ExtendedUI { get; set; }
        [DBField(ArraySize: 3)]
        public int[] ExtendedUIStateVariable { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class WorldStateZoneSounds
    {
        [DBKey]
        public int ID { get; set; }
        public int WorldStateID { get; set; }
        public int WorldStateValue { get; set; }
        public int AreaID { get; set; }
        public int WMOAreaID { get; set; }
        public int ZoneintroMusicID { get; set; }
        public int ZoneMusicID { get; set; }
        public int SoundAmbienceID { get; set; }
        public int SoundProviderPreferencesID { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class WOWCache
    {
        [DBKey(AutoGenerated: true)]
        public int Id { get; set; }
        public string HashID { get; set; }
        public int EntryLength { get; set; }
        public int DataLength { get; set; }
        public string ModuleData { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class WowError_Strings
    {
        [DBKey]
        public int ID { get; set; }
        public string ErrorName { get; set; }
        public LocalizedString ErrorString { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class ZoneintroMusicTable
    {
        [DBKey]
        public int ID { get; set; }
        public string Name { get; set; }
        public int SoundID { get; set; }
        public int Priority { get; set; }
        public int MinDelayMinutes { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class ZoneLight
    {
        [DBKey]
        public int ID { get; set; }
        public string Name { get; set; }
        public int MapID { get; set; }
        public int LightID { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class ZoneLightPoint
    {
        [DBKey]
        public int ID { get; set; }
        public int ZoneLightID { get; set; }
        [DBField(ArraySize: 2)]
        public float[] Pos { get; set; }
        public int PointOrder { get; set; }
    }

    [DBTable(Expansion.WoD)]
    public class ZoneMusic
    {
        [DBKey]
        public int ID { get; set; }
        public string SetName { get; set; }
        [DBField(ArraySize: 2)]
        public int[] SilenceintervalMin { get; set; }
        [DBField(ArraySize: 2)]
        public int[] SilenceintervalMax { get; set; }
        [DBField(ArraySize: 2)]
        public int[] Sounds { get; set; }
    }

}
