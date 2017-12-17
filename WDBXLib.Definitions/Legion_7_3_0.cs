using System;
using WDBXLib.Attributes;
using WDBXLib.Helpers;
using static WDBXLib.Common.Constants;

namespace WDBXLib.Definitions.Legion_7_3_0
{

    [DBTable(24492)]
    public class Achievement
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public uint Flags { get; set; }
        public string Reward { get; set; }
        public ushort Field10 { get; set; }
        public ushort Field12 { get; set; }
        public ushort Field14 { get; set; }
        public ushort Field16 { get; set; }
        public ushort Field18 { get; set; }
        public ushort Field1A { get; set; }
        public ushort Field1C { get; set; }
        public byte Faction { get; set; }
        public byte Points { get; set; }
        public byte MinimumCriteria { get; set; }
        [DBKey]
        public int ID { get; set; }
    }

    [DBTable(24492)]
    public class Achievement_Category
    {
        public string Field0 { get; set; }
        public ushort Field4 { get; set; }
        public byte Field6 { get; set; }
        [DBKey]
        [DBField(ArraySize: 2)]
        public int[] ID { get; set; }
    }

    [DBTable(24492)]
    public class AdventureJournal
    {
        [DBKey]
        public int ID { get; set; }
        public string Field04 { get; set; }
        public string Field08 { get; set; }
        public string Field0C { get; set; }
        public uint Field10 { get; set; }
        public uint Field14 { get; set; }
        public string Field18 { get; set; }
        public string Field1C { get; set; }
        public ushort Field20 { get; set; }
        public ushort Field22 { get; set; }
        public ushort Field24 { get; set; }
        [DBField(ArraySize: 2)]
        public ushort[] Field26 { get; set; }
        public ushort Field2A { get; set; }
        public ushort Field2C { get; set; }
        public byte Field2E { get; set; }
        public byte Field2F { get; set; }
        public byte Field30 { get; set; }
        public byte Field31 { get; set; }
        public byte Field32 { get; set; }
        public byte Field33 { get; set; }
        [DBField(ArraySize: 2)]
        public byte[] Field34 { get; set; }
        public byte Field36 { get; set; }
        public byte Field37 { get; set; }
    }

    [DBTable(24492)]
    public class AdventureMapPOI
    {
        [DBKey]
        public int ID { get; set; }
        [DBField(ArraySize: 2)]
        public float[] Field04 { get; set; }
        public uint Field0C { get; set; }
        public string Field10 { get; set; }
        public string Field14 { get; set; }
        public byte Field18 { get; set; }
        public ushort Field19 { get; set; }
        public ushort Field1B { get; set; }
        public byte Field1D { get; set; }
        public ushort Field1E { get; set; }
        public byte Field20 { get; set; }
        public ushort Field21 { get; set; }
        public ushort Field23 { get; set; }
        public ushort Field25 { get; set; }
    }

    [DBTable(24492)]
    public class AnimationData
    {
        [DBKey]
        public int ID { get; set; }
        public string Field04 { get; set; }
        public int Field08 { get; set; }
        public ushort Field0C { get; set; }
        public ushort Field0E { get; set; }
        [DBField(ArraySize: 4)]
        public byte[] Field10 { get; set; }
    }

    [DBTable(24492)]
    public class AnimKit
    {
        [DBKey]
        public int ID { get; set; }
        public uint OneShotDuration { get; set; }
        public ushort OneShotStopAnimKitID { get; set; }
        public ushort LowDefAnimKitID { get; set; }
    }

    [DBTable(24492)]
    public class AnimKitBoneSet
    {
        [DBKey]
        public int ID { get; set; }
        public string Field04 { get; set; }
        public byte Field08 { get; set; }
        public byte Field09 { get; set; }
        public byte Field0A { get; set; }
        public byte Field0B { get; set; }
    }

    [DBTable(24492)]
    public class AnimKitBoneSetAlias
    {
        [DBKey]
        public int ID { get; set; }
        public byte Field4 { get; set; }
        public byte Field5 { get; set; }
    }

    [DBTable(24492)]
    public class AnimKitConfig
    {
        [DBKey]
        public int ID { get; set; }
        public uint Field4 { get; set; }
    }

    [DBTable(24492)]
    public class AnimKitConfigBoneSet
    {
        [DBKey]
        public int ID { get; set; }
        public ushort Field4 { get; set; }
        public ushort Field6 { get; set; }
        public byte Field8 { get; set; }
    }

    [DBTable(24492)]
    public class AnimKitPriority
    {
        [DBKey]
        public int ID { get; set; }
        public byte Field4 { get; set; }
    }

    [DBTable(24492)]
    public class AnimKitReplacement
    {
        public ushort Field00 { get; set; }
        public ushort Field02 { get; set; }
        public ushort Field04 { get; set; }
        public ushort Field06 { get; set; }
        [DBKey]
        public int ID { get; set; }
    }

    [DBTable(24492)]
    public class AnimKitSegment
    {
        [DBKey]
        public int ID { get; set; }
        public uint Field04 { get; set; }
        public uint Field08 { get; set; }
        public float Field0C { get; set; }
        public int Field10 { get; set; }
        public uint Field14 { get; set; }
        public ushort Field18 { get; set; }
        public ushort Field1A { get; set; }
        public ushort Field1C { get; set; }
        public byte Field1E { get; set; }
        public byte Field1F { get; set; }
        public byte Field20 { get; set; }
        public byte Field21 { get; set; }
        public byte Field22 { get; set; }
        public byte Field23 { get; set; }
        public byte Field24 { get; set; }
        public ushort Field25 { get; set; }
    }

    [DBTable(24492)]
    public class AnimReplacement
    {
        [DBKey]
        public int ID { get; set; }
        public ushort Field04 { get; set; }
        public ushort Field06 { get; set; }
        public ushort Field08 { get; set; }
        public ushort Field0A { get; set; }
    }

    [DBTable(24492)]
    public class AnimReplacementSet
    {
        [DBKey]
        public int ID { get; set; }
        public byte Field4 { get; set; }
    }

    [DBTable(24492)]
    public class AreaAssignment
    {
        [DBKey]
        public int ID { get; set; }
        public ushort Field4 { get; set; }
        public ushort Field6 { get; set; }
        public byte Field8 { get; set; }
        public byte Field9 { get; set; }
    }

    [DBTable(24492)]
    public class AreaFarClipOverride
    {
        public int Field00 { get; set; }
        public float Field04 { get; set; }
        public float Field08 { get; set; }
        public int Field0C { get; set; }
        [DBKey]
        public int ID { get; set; }
    }

    [DBTable(24492)]
    public class AreaGroupMember
    {
        [DBKey]
        public int ID { get; set; }
        public ushort AreaGroupID { get; set; }
        public ushort AreaID { get; set; }
    }

    [DBTable(24492)]
    public class AreaPOI
    {
        [DBKey]
        public int ID { get; set; }
        [DBField(ArraySize: 2)]
        public int[] Field04 { get; set; }
        public string Field0C { get; set; }
        public string Field10 { get; set; }
        public ushort Field14 { get; set; }
        public ushort Field16 { get; set; }
        public ushort Field18 { get; set; }
        public ushort Field1A { get; set; }
        public ushort Field1C { get; set; }
        public ushort Field1E { get; set; }
        public byte Field20 { get; set; }
        public byte Field21 { get; set; }
        public byte Field22 { get; set; }
        public ushort Field23 { get; set; }
    }

    [DBTable(24492)]
    public class AreaPOIState
    {
        [DBKey]
        public int ID { get; set; }
        public string Field04 { get; set; }
        public ushort Field08 { get; set; }
        public byte Field0A { get; set; }
        public byte Field0B { get; set; }
        public byte Field0C { get; set; }
    }

    [DBTable(24492)]
    public class AreaTable
    {
        [DBKey]
        public int ID { get; set; }
        [DBField(ArraySize: 2)]
        public uint[] Flags { get; set; }
        public string ZoneName { get; set; }
        public float AmbientMultiplier { get; set; }
        public string AreaName { get; set; }
        public ushort MapID { get; set; }
        public ushort ParentAreaID { get; set; }
        public ushort AreaBit { get; set; }
        public ushort AmbienceID { get; set; }
        public ushort ZoneMusic { get; set; }
        public ushort IntroSound { get; set; }
        [DBField(ArraySize: 4)]
        public ushort[] LiquidTypeID { get; set; }
        public ushort UWZoneMusic { get; set; }
        public ushort UWAmbience { get; set; }
        public ushort PvPCombatWorldStateID { get; set; }
        public byte SoundProviderPref { get; set; }
        public byte SoundProviderPrefUnderwater { get; set; }
        public byte ExplorationLevel { get; set; }
        public byte FactionGroupMask { get; set; }
        public byte MountFlags { get; set; }
        public byte WildBattlePetLevelMin { get; set; }
        public byte WildBattlePetLevelMax { get; set; }
        public byte WindSettingsID { get; set; }
        public uint UWIntroSound { get; set; }
    }

    [DBTable(24492)]
    public class AreaTrigger
    {
        [DBField(ArraySize: 3)]
        public float[] Pos { get; set; }
        public float Radius { get; set; }
        public float BoxLength { get; set; }
        public float BoxWidth { get; set; }
        public float BoxHeight { get; set; }
        public float BoxYaw { get; set; }
        public ushort MapID { get; set; }
        public ushort PhaseID { get; set; }
        public ushort PhaseGroupID { get; set; }
        public ushort ShapeID { get; set; }
        public ushort AreaTriggerActionSetID { get; set; }
        public byte PhaseUseFlags { get; set; }
        public byte ShapeType { get; set; }
        public byte Flag { get; set; }
        [DBKey]
        public int ID { get; set; }
    }

    [DBTable(24492)]
    public class AreaTriggerActionSet
    {
        [DBKey]
        public int ID { get; set; }
        public ushort Field4 { get; set; }
    }

    [DBTable(24492)]
    public class AreaTriggerBox
    {
        [DBKey]
        public int ID { get; set; }
        [DBField(ArraySize: 2)]
        public float[] Field4 { get; set; }
    }

    [DBTable(24492)]
    public class AreaTriggerCylinder
    {
        [DBKey]
        public int ID { get; set; }
        public float Field04 { get; set; }
        public float Field08 { get; set; }
        public float Field0C { get; set; }
    }

    [DBTable(24492)]
    public class AreaTriggerSphere
    {
        [DBKey]
        public int ID { get; set; }
        public float Field4 { get; set; }
    }

    [DBTable(24492)]
    public class ArmorLocation
    {
        [DBKey]
        public int ID { get; set; }
        [DBField(ArraySize: 5)]
        public float[] Modifier { get; set; }
    }

    [DBTable(24492)]
    public class Artifact
    {
        [DBKey]
        public int ID { get; set; }
        public string Name { get; set; }
        public uint BarConnectedColor { get; set; }
        public uint BarDisconnectedColor { get; set; }
        public uint TitleColor { get; set; }
        public ushort ClassUiTextureKitID { get; set; }
        public ushort SpecID { get; set; }
        public byte ArtifactCategoryID { get; set; }
        public byte Flags { get; set; }
        public uint UiModelSceneID { get; set; }
        public uint SpellVisualKitID { get; set; }
    }

    [DBTable(24492)]
    public class ArtifactAppearance
    {
        public string Name { get; set; }
        public uint SwatchColor { get; set; }
        public float ModelDesaturation { get; set; }
        public float ModelAlpha { get; set; }
        public uint ShapeshiftDisplayID { get; set; }
        public ushort ArtifactAppearanceSetID { get; set; }
        public ushort Unknown { get; set; }
        public ushort Field18 { get; set; }
        public byte DisplayIndex { get; set; }
        public byte AppearanceModID { get; set; }
        public byte Flags { get; set; }
        public byte ModifiesShapeshiftFormDisplay { get; set; }
        [DBKey]
        public int ID { get; set; }
        public byte Field20 { get; set; }
        [DBField(ArraySize: 3)]
        public byte[] Field21 { get; set; }
    }

    [DBTable(24492)]
    public class ArtifactAppearanceSet
    {
        public string Name { get; set; }
        public string Name2 { get; set; }
        public ushort UiCameraID { get; set; }
        public ushort AltHandUICameraID { get; set; }
        public byte ArtifactID { get; set; }
        public byte DisplayIndex { get; set; }
        public byte AttachmentPoint { get; set; }
        public byte Flags { get; set; }
        [DBKey]
        public int ID { get; set; }
    }

    [DBTable(24492)]
    public class ArtifactCategory
    {
        [DBKey]
        public int ID { get; set; }
        public ushort ArtifactKnowledgeCurrencyID { get; set; }
        public ushort ArtifactKnowledgeMultiplierCurveID { get; set; }
    }

    [DBTable(24492)]
    public class ArtifactPower
    {
        [DBField(ArraySize: 2)]
        public float[] Pos { get; set; }
        public byte ArtifactID { get; set; }
        public byte Flags { get; set; }
        public byte MaxRank { get; set; }
        [DBKey]
        public int ID { get; set; }
        [DBField(ArraySize: 3)]
        public byte[] Field0D { get; set; }
    }

    [DBTable(24492)]
    public class ArtifactPowerLink
    {
        [DBKey]
        public int ID { get; set; }
        public ushort FromArtifactPowerID { get; set; }
        public ushort ToArtifactPowerID { get; set; }
    }

    [DBTable(24492)]
    public class ArtifactPowerPicker
    {
        [DBKey]
        public int ID { get; set; }
        public int Field00 { get; set; }
    }

    [DBTable(24492)]
    public class ArtifactPowerRank
    {
        [DBKey]
        public int ID { get; set; }
        public uint SpellID { get; set; }
        public float Value { get; set; }
        public ushort ArtifactPowerID { get; set; }
        public ushort Unknown { get; set; }
        public byte Rank { get; set; }
    }

    [DBTable(24492)]
    public class ArtifactQuestXP
    {
        [DBKey]
        public int ID { get; set; }
        [DBField(ArraySize: 10)]
        public uint[] Exp { get; set; }
    }

    [DBTable(24492)]
    public class ArtifactTier
    {
        [DBKey]
        public int ID { get; set; }
        public int Field00 { get; set; }
        public int Field04 { get; set; }
        public int Field08 { get; set; }
        public int Field0C { get; set; }
        public int Field10 { get; set; }
    }

    [DBTable(24492)]
    public class ArtifactUnlock
    {
        [DBKey]
        public int ID { get; set; }
        public ushort Field4 { get; set; }
        public byte Field6 { get; set; }
        public byte Field7 { get; set; }
        public byte Field8 { get; set; }
        public ushort Field9 { get; set; }
    }

    [DBTable(24492)]
    public class AuctionHouse
    {
        [DBKey]
        public int ID { get; set; }
        public string Name { get; set; }
        public ushort FactionID { get; set; }
        public byte DepositRate { get; set; }
        public byte ConsignmentRate { get; set; }
    }

    [DBTable(24492)]
    public class BankBagSlotPrices
    {
        [DBKey]
        public int ID { get; set; }
        public uint Cost { get; set; }
    }

    [DBTable(24492)]
    public class BannedAddOns
    {
        [DBKey]
        public int ID { get; set; }
        public string Name { get; set; }
        public string Version { get; set; }
        public byte Flags { get; set; }
    }

    [DBTable(24492)]
    public class BarberShopStyle
    {
        public string DisplayName { get; set; }
        public string Description { get; set; }
        public float CostModifier { get; set; }
        public byte Type { get; set; }
        public byte Race { get; set; }
        public byte Sex { get; set; }
        public byte Data { get; set; }
        [DBKey]
        public int ID { get; set; }
    }

    [DBTable(24492)]
    public class BattlemasterList
    {
        [DBKey]
        public int ID { get; set; }
        public string Name { get; set; }
        public uint IconFileDataID { get; set; }
        public string GameType { get; set; }
        public string ShortDescription { get; set; }
        public string LongDescription { get; set; }
        [DBField(ArraySize: 16)]
        public ushort[] MapID { get; set; }
        public ushort HolidayWorldState { get; set; }
        public ushort PlayerConditionID { get; set; }
        public byte InstanceType { get; set; }
        public byte GroupsAllowed { get; set; }
        public byte MaxGroupSize { get; set; }
        public byte MinLevel { get; set; }
        public byte MaxLevel { get; set; }
        public byte RatedPlayers { get; set; }
        public byte MinPlayers { get; set; }
        public byte MaxPlayers { get; set; }
        public byte Flags { get; set; }
    }

    [DBTable(24492)]
    public class BattlePetAbility
    {
        [DBKey]
        public int ID { get; set; }
        public uint Field04 { get; set; }
        public string Field08 { get; set; }
        public string Field0C { get; set; }
        public ushort Field10 { get; set; }
        public byte Field12 { get; set; }
        public byte Field13 { get; set; }
        public byte Field14 { get; set; }
    }

    [DBTable(24492)]
    public class BattlePetAbilityEffect
    {
        public ushort Field00 { get; set; }
        public ushort Field02 { get; set; }
        public ushort Field04 { get; set; }
        public ushort Field06 { get; set; }
        [DBField(ArraySize: 6)]
        public ushort[] Field08 { get; set; }
        public byte Field14 { get; set; }
        [DBKey]
        public int ID { get; set; }
    }

    [DBTable(24492)]
    public class BattlePetAbilityState
    {
        [DBKey]
        public int ID { get; set; }
        public int Field04 { get; set; }
        public ushort Field08 { get; set; }
        public byte Field0A { get; set; }
    }

    [DBTable(24492)]
    public class BattlePetAbilityTurn
    {
        public ushort Field0 { get; set; }
        public ushort Field2 { get; set; }
        public byte Field4 { get; set; }
        public byte Field5 { get; set; }
        public byte Field6 { get; set; }
        [DBKey]
        public int ID { get; set; }
    }

    [DBTable(24492)]
    public class BattlePetBreedQuality
    {
        [DBKey]
        public int ID { get; set; }
        public float Modifier { get; set; }
        public byte Quality { get; set; }
    }

    [DBTable(24492)]
    public class BattlePetBreedState
    {
        [DBKey]
        public int ID { get; set; }
        public ushort Value { get; set; }
        public byte BreedID { get; set; }
        public byte State { get; set; }
    }

    [DBTable(24492)]
    public class BattlePetEffectProperties
    {
        [DBKey]
        public int ID { get; set; }
        [DBField(ArraySize: 6)]
        public string[] Field04 { get; set; }
        public ushort Field1C { get; set; }
        [DBField(ArraySize: 2)]
        public byte[] Field1E { get; set; }
    }

    [DBTable(24492)]
    public class BattlePetNPCTeamMember
    {
        [DBKey]
        public int ID { get; set; }
        public uint Field4 { get; set; }
    }

    [DBTable(24492)]
    public class BattlePetSpecies
    {
        public uint CreatureID { get; set; }
        public uint IconFileID { get; set; }
        public uint SummonSpellID { get; set; }
        public string SourceText { get; set; }
        public string Description { get; set; }
        public ushort Flags { get; set; }
        public byte PetType { get; set; }
        public byte Source { get; set; }
        [DBKey]
        public int ID { get; set; }
    }

    [DBTable(24492)]
    public class BattlePetSpeciesState
    {
        [DBKey]
        public int ID { get; set; }
        public int Value { get; set; }
        public ushort SpeciesID { get; set; }
        public byte State { get; set; }
    }

    [DBTable(24492)]
    public class BattlePetSpeciesXAbility
    {
        [DBKey]
        public int ID { get; set; }
        public ushort Field4 { get; set; }
        public ushort Field6 { get; set; }
        public byte Field8 { get; set; }
        public byte Field9 { get; set; }
    }

    [DBTable(24492)]
    public class BattlePetState
    {
        [DBKey]
        public int ID { get; set; }
        public string Field04 { get; set; }
        public ushort Field08 { get; set; }
        public ushort Field0A { get; set; }
    }

    [DBTable(24492)]
    public class BattlePetVisual
    {
        [DBKey]
        public int ID { get; set; }
        public string Field04 { get; set; }
        public ushort Field08 { get; set; }
        public ushort Field0A { get; set; }
        public ushort Field0C { get; set; }
        public ushort Field0E { get; set; }
        public byte Field10 { get; set; }
        public byte Field11 { get; set; }
    }

    [DBTable(24492)]
    public class BeamEffect
    {
        [DBKey]
        public int ID { get; set; }
        public int Field00 { get; set; }
        public float Field04 { get; set; }
        public float Field08 { get; set; }
        public int Field0C { get; set; }
        public ushort Field10 { get; set; }
        public ushort Field12 { get; set; }
        public ushort Field14 { get; set; }
        public ushort Field16 { get; set; }
        public ushort Field18 { get; set; }
        public ushort Field1A { get; set; }
    }

    [DBTable(24492)]
    public class BoneWindModifierModel
    {
        [DBKey]
        public int ID { get; set; }
        public uint Field4 { get; set; }
        public uint Field8 { get; set; }
    }

    [DBTable(24492)]
    public class BoneWindModifiers
    {
        [DBKey]
        public int ID { get; set; }
        [DBField(ArraySize: 3)]
        public float[] Field04 { get; set; }
        public float Field10 { get; set; }
    }

    [DBTable(24492)]
    public class Bounty
    {
        [DBKey]
        public int ID { get; set; }
        public uint Field04 { get; set; }
        public ushort Field08 { get; set; }
        public ushort Field0A { get; set; }
        public byte Field0C { get; set; }
    }

    [DBTable(24492)]
    public class BountySet
    {
        [DBKey]
        public int ID { get; set; }
        public ushort Field4 { get; set; }
        public ushort Field6 { get; set; }
    }

    [DBTable(24492)]
    public class BroadcastText
    {
        [DBKey]
        public int ID { get; set; }
        public string MaleText { get; set; }
        public string FemaleText { get; set; }
        [DBField(ArraySize: 3)]
        public ushort[] EmoteID { get; set; }
        [DBField(ArraySize: 3)]
        public ushort[] EmoteDelay { get; set; }
        public ushort UnkEmoteID { get; set; }
        public byte Language { get; set; }
        public byte Type { get; set; }
        [DBField(ArraySize: 2)]
        public uint[] SoundID { get; set; }
        public uint PlayerConditionID { get; set; }
    }

    [DBTable(24492)]
    public class CameraEffect
    {
        [DBKey]
        public int ID { get; set; }
        public byte Field4 { get; set; }
    }

    [DBTable(24492)]
    public class CameraEffectEntry
    {
        [DBKey]
        public int ID { get; set; }
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
        public byte Field28 { get; set; }
        public byte Field29 { get; set; }
        public byte Field2A { get; set; }
        public byte Field2B { get; set; }
        public byte Field2C { get; set; }
        public byte Field2D { get; set; }
    }

    [DBTable(24492)]
    public class CameraMode
    {
        [DBKey]
        public int ID { get; set; }
        [DBField(ArraySize: 3)]
        public int[] Field04 { get; set; }
        [DBField(ArraySize: 3)]
        public int[] Field10 { get; set; }
        public float Field1C { get; set; }
        public float Field20 { get; set; }
        public float Field24 { get; set; }
        public ushort Field28 { get; set; }
        public byte Field2A { get; set; }
        public byte Field2B { get; set; }
        public byte Field2C { get; set; }
        public byte Field2D { get; set; }
        public byte Field2E { get; set; }
    }

    [DBTable(24492)]
    public class CastableRaidBuffs
    {
        [DBKey]
        public int ID { get; set; }
        public ushort Field4 { get; set; }
        public ushort Field6 { get; set; }
    }

    [DBTable(24492)]
    public class CameraShakes
    {
        [DBKey]
        public int ID { get; set; }
        public float Field04 { get; set; }
        public float Field08 { get; set; }
        public float Field0C { get; set; }
        public float Field10 { get; set; }
        public byte Field14 { get; set; }
        public byte Field15 { get; set; }
        public byte Field16 { get; set; }
        public byte Field17 { get; set; }
        public ushort Field18 { get; set; }
    }

    [DBTable(24492)]
    public class CelestialBody
    {
        public int Field00 { get; set; }
        public int Field04 { get; set; }
        [DBField(ArraySize: 2)]
        public int[] Field08 { get; set; }
        public int Field10 { get; set; }
        public int Field14 { get; set; }
        [DBField(ArraySize: 2)]
        public int[] Field18 { get; set; }
        [DBField(ArraySize: 2)]
        public float[] Field20 { get; set; }
        [DBField(ArraySize: 2)]
        public float[] Field28 { get; set; }
        public float Field30 { get; set; }
        [DBField(ArraySize: 2)]
        public float[] Field34 { get; set; }
        public float Field3C { get; set; }
        [DBField(ArraySize: 3)]
        public float[] Field40 { get; set; }
        public float Field4C { get; set; }
        public ushort Field50 { get; set; }
        [DBKey]
        public int ID { get; set; }
    }

    [DBTable(24492)]
    public class Cfg_Categories
    {
        [DBKey]
        public int ID { get; set; }
        public string Field04 { get; set; }
        public ushort Field08 { get; set; }
        public byte Field0A { get; set; }
        public byte Field0B { get; set; }
        public byte Field0C { get; set; }
    }

    [DBTable(24492)]
    public class Cfg_Configs
    {
        [DBKey]
        public int ID { get; set; }
        public float Field04 { get; set; }
        public ushort Field08 { get; set; }
        public byte Field0A { get; set; }
        public byte Field0B { get; set; }
    }

    [DBTable(24492)]
    public class Cfg_Regions
    {
        [DBKey]
        public int ID { get; set; }
        public string Field04 { get; set; }
        public uint Field08 { get; set; }
        public byte Field0C { get; set; }
    }

    [DBTable(24492)]
    public class CharacterFaceBoneSet
    {
        [DBKey]
        public int ID { get; set; }
        public uint Field04 { get; set; }
        public byte Field08 { get; set; }
        public byte Field09 { get; set; }
        public byte Field0A { get; set; }
    }

    [DBTable(24492)]
    public class CharacterFacialHairStyles
    {
        [DBKey]
        public int ID { get; set; }
        [DBField(ArraySize: 5)]
        public uint[] Field04 { get; set; }
        public byte Field18 { get; set; }
        public byte Field19 { get; set; }
        public byte Field1A { get; set; }
    }

    [DBTable(24492)]
    public class CharacterLoadout
    {
        [DBKey]
        public int ID { get; set; }
        public uint Field4 { get; set; }
        public byte Field8 { get; set; }
        public byte Field9 { get; set; }
    }

    [DBTable(24492)]
    public class CharacterLoadoutItem
    {
        [DBKey]
        public int ID { get; set; }
        public uint Field4 { get; set; }
        public ushort Field8 { get; set; }
    }

    [DBTable(24492)]
    public class CharBaseInfo
    {
        [DBKey]
        public int ID { get; set; }
        public byte Field4 { get; set; }
        public byte Field5 { get; set; }
    }

    [DBTable(24492)]
    public class CharBaseSection
    {
        [DBKey]
        public int ID { get; set; }
        public byte Field4 { get; set; }
        public byte Field5 { get; set; }
        public byte Field6 { get; set; }
    }

    [DBTable(24492)]
    public class CharComponentTextureLayouts
    {
        [DBKey]
        public int ID { get; set; }
        public ushort Field4 { get; set; }
        public ushort Field6 { get; set; }
    }

    [DBTable(24492)]
    public class CharComponentTextureSections
    {
        [DBKey]
        public int ID { get; set; }
        public ushort Field04 { get; set; }
        public ushort Field06 { get; set; }
        public ushort Field08 { get; set; }
        public ushort Field0A { get; set; }
        public byte Field0C { get; set; }
        public byte Field0D { get; set; }
        public byte Field0E { get; set; }
    }

    [DBTable(24492)]
    public class CharHairGeosets
    {
        [DBKey]
        public int ID { get; set; }
        public uint Field04 { get; set; }
        public byte Field08 { get; set; }
        public byte Field09 { get; set; }
        public byte Field0A { get; set; }
        public byte Field0B { get; set; }
        public byte Field0C { get; set; }
        public byte Field0D { get; set; }
        public byte Field0E { get; set; }
        public byte Field0F { get; set; }
        public byte Field10 { get; set; }
    }

    [DBTable(24492)]
    public class CharSections
    {
        [DBKey]
        public int ID { get; set; }
        [DBField(ArraySize: 3)]
        public uint[] TextureFileDataID { get; set; }
        public ushort Flags { get; set; }
        public byte Race { get; set; }
        public byte Gender { get; set; }
        public byte GenType { get; set; }
        public byte Type { get; set; }
        public byte Color { get; set; }
    }

    [DBTable(24492)]
    public class CharShipment
    {
        [DBKey]
        public int ID { get; set; }
        public uint Field04 { get; set; }
        public uint Field08 { get; set; }
        public uint Field0C { get; set; }
        public uint Field10 { get; set; }
        public uint Field14 { get; set; }
        public ushort Field18 { get; set; }
        public byte Field1A { get; set; }
        public byte Field1B { get; set; }
    }

    [DBTable(24492)]
    public class CharShipmentContainer
    {
        [DBKey]
        public int ID { get; set; }
        public string Field04 { get; set; }
        public string Field08 { get; set; }
        public ushort Field0C { get; set; }
        public ushort Field0E { get; set; }
        public ushort Field10 { get; set; }
        public ushort Field12 { get; set; }
        public ushort Field14 { get; set; }
        public ushort Field16 { get; set; }
        public byte Field18 { get; set; }
        public byte Field19 { get; set; }
        public byte Field1A { get; set; }
        public byte Field1B { get; set; }
        public byte Field1C { get; set; }
        public byte Field1D { get; set; }
        public byte Field1E { get; set; }
        public byte Field1F { get; set; }
    }

    [DBTable(24492)]
    public class CharStartOutfit
    {
        [DBKey]
        public int ID { get; set; }
        [DBField(ArraySize: 24)]
        public int[] ItemID { get; set; }
        public uint PetDisplayID { get; set; }
        public byte RaceID { get; set; }
        public byte ClassID { get; set; }
        public byte GenderID { get; set; }
        public byte OutfitID { get; set; }
        public byte PetFamilyID { get; set; }
    }

    [DBTable(24492)]
    public class CharTitles
    {
        [DBKey]
        public int ID { get; set; }
        public string NameMale { get; set; }
        public string NameFemale { get; set; }
        public ushort MaskID { get; set; }
        public byte Flags { get; set; }
    }

    [DBTable(24492)]
    public class ChatChannels
    {
        [DBKey]
        public int ID { get; set; }
        public uint Flags { get; set; }
        public string Name { get; set; }
        public string Shortcut { get; set; }
        public byte FactionGroup { get; set; }
    }

    [DBTable(24492)]
    public class ChatProfanity
    {
        [DBKey]
        public int ID { get; set; }
        public string Field4 { get; set; }
        public byte Field8 { get; set; }
    }

    [DBTable(24492)]
    public class ChrClasses
    {
        public string PetNameToken { get; set; }
        public string Name { get; set; }
        public string NameFemale { get; set; }
        public string NameMale { get; set; }
        public string Filename { get; set; }
        public uint Field14 { get; set; }
        public uint Field18 { get; set; }
        public uint Field1C { get; set; }
        public ushort Flags { get; set; }
        public ushort CinematicSequenceID { get; set; }
        public ushort DefaultSpec { get; set; }
        public byte Field26 { get; set; }
        public byte Field27 { get; set; }
        public byte Field28 { get; set; }
        public byte Field29 { get; set; }
        public byte Field2A { get; set; }
        public byte Field2B { get; set; }
        public byte Field2C { get; set; }
        [DBKey]
        public int ID { get; set; }
    }

    [DBTable(24492)]
    public class ChrClassesXPowerTypes
    {
        [DBKey]
        public int ID { get; set; }
        public byte ClassID { get; set; }
        public byte PowerType { get; set; }
    }

    [DBTable(24492)]
    public class ChrClassRaceSex
    {
        [DBKey]
        public int ID { get; set; }
        public byte Field04 { get; set; }
        public byte Field05 { get; set; }
        public byte Field06 { get; set; }
        public byte Field07 { get; set; }
        public ushort Field08 { get; set; }
        public byte Field0A { get; set; }
    }

    [DBTable(24492)]
    public class ChrClassTitle
    {
        [DBKey]
        public int ID { get; set; }
        public string Field04 { get; set; }
        public string Field08 { get; set; }
        public byte Field0C { get; set; }
    }

    [DBTable(24492)]
    public class ChrClassUIDisplay
    {
        [DBKey]
        public int ID { get; set; }
        public byte Field4 { get; set; }
        public ushort Field5 { get; set; }
        public ushort Field7 { get; set; }
    }

    [DBTable(24492)]
    public class ChrClassVillain
    {
        [DBKey]
        public int ID { get; set; }
        public string Field4 { get; set; }
        public byte Field8 { get; set; }
        public byte Field9 { get; set; }
    }

    [DBTable(24492)]
    public class ChrRaces
    {
        [DBKey]
        public int ID { get; set; }
        public uint Field004 { get; set; }
        public string Field008 { get; set; }
        public string Field00C { get; set; }
        public string Field010 { get; set; }
        public string Field014 { get; set; }
        public string Field018 { get; set; }
        [DBField(ArraySize: 2)]
        public string[] Field01C { get; set; }
        public string Field024 { get; set; }
        public uint Field028 { get; set; }
        public uint Field02C { get; set; }
        [DBField(ArraySize: 3)]
        public float[] Field030 { get; set; }
        [DBField(ArraySize: 3)]
        public float[] Field03C { get; set; }
        public uint Field048 { get; set; }
        public ushort Field04C { get; set; }
        public ushort Field04E { get; set; }
        public ushort Field050 { get; set; }
        public ushort Field052 { get; set; }
        public ushort Field054 { get; set; }
        public ushort Field056 { get; set; }
        public ushort Field058 { get; set; }
        public ushort Field05A { get; set; }
        public ushort Field05C { get; set; }
        public byte Field05E { get; set; }
        public byte Field05F { get; set; }
        public byte Field060 { get; set; }
        public byte Field061 { get; set; }
        public byte Field062 { get; set; }
        public byte Field063 { get; set; }
        public byte Field064 { get; set; }
        public byte Field065 { get; set; }
        public byte Field066 { get; set; }
        public byte Field067 { get; set; }
        public ushort Field068 { get; set; }
        public ushort Field06A { get; set; }
        [DBField(ArraySize: 2)]
        public ushort[] Field06C { get; set; }
    }

    [DBTable(24492)]
    public class ChrSpecialization
    {
        [DBField(ArraySize: 2)]
        public uint[] Field00 { get; set; }
        public string Field08 { get; set; }
        public string Field0C { get; set; }
        public string Field10 { get; set; }
        public string Field14 { get; set; }
        public ushort Field18 { get; set; }
        public byte Field1A { get; set; }
        public byte Field1B { get; set; }
        public byte Field1C { get; set; }
        public byte Field1D { get; set; }
        public byte Field1E { get; set; }
        [DBKey]
        public int ID { get; set; }
        public ushort Field21 { get; set; }
        [DBField(ArraySize: 2)]
        public ushort[] Field23 { get; set; }
    }

    [DBTable(24492)]
    public class ChrUpgradeBucket
    {
        public ushort Field0 { get; set; }
        public byte Field2 { get; set; }
        [DBKey]
        public int ID { get; set; }
    }

    [DBTable(24492)]
    public class ChrUpgradeBucketSpell
    {
        [DBKey]
        public int ID { get; set; }
        public uint Field4 { get; set; }
        public ushort Field8 { get; set; }
    }

    [DBTable(24492)]
    public class ChrUpgradeTier
    {
        public uint Field0 { get; set; }
        public byte Field4 { get; set; }
        public byte Field5 { get; set; }
        [DBKey]
        [DBField(ArraySize: 2)]
        public int[] ID { get; set; }
    }

    [DBTable(24492)]
    public class CinematicCamera
    {
        [DBKey]
        public int ID { get; set; }
        public uint SoundID { get; set; }
        [DBField(ArraySize: 3)]
        public float[] Origin { get; set; }
        public float OriginFacing { get; set; }
        public uint ModelFileDataID { get; set; }
    }

    [DBTable(24492)]
    public class CinematicSequences
    {
        [DBKey]
        public int ID { get; set; }
        public uint SoundID { get; set; }
        [DBField(ArraySize: 8)]
        public ushort[] Camera { get; set; }
    }

    [DBTable(24492)]
    public class CloakDampening
    {
        [DBKey]
        public int ID { get; set; }
        [DBField(ArraySize: 5)]
        public int[] Field04 { get; set; }
        [DBField(ArraySize: 5)]
        public float[] Field18 { get; set; }
        [DBField(ArraySize: 2)]
        public int[] Field2C { get; set; }
        [DBField(ArraySize: 2)]
        public float[] Field34 { get; set; }
        public int Field3C { get; set; }
        public float Field40 { get; set; }
        public float Field44 { get; set; }
    }

    [DBTable(24492)]
    public class CombatCondition
    {
        [DBKey]
        public int ID { get; set; }
        public ushort Field04 { get; set; }
        public ushort Field06 { get; set; }
        public ushort Field08 { get; set; }
        [DBField(ArraySize: 2)]
        public ushort[] Field0A { get; set; }
        [DBField(ArraySize: 2)]
        public ushort[] Field0E { get; set; }
        [DBField(ArraySize: 2)]
        public byte[] Field12 { get; set; }
        [DBField(ArraySize: 2)]
        public byte[] Field14 { get; set; }
        public byte Field16 { get; set; }
        [DBField(ArraySize: 2)]
        public byte[] Field17 { get; set; }
        [DBField(ArraySize: 2)]
        public byte[] Field19 { get; set; }
        public byte Field1B { get; set; }
    }

    [DBTable(24492)]
    public class ComponentModelFileData
    {
        [DBKey]
        public int ID { get; set; }
        public byte Field4 { get; set; }
        public byte Field5 { get; set; }
        public byte Field6 { get; set; }
        public byte Field7 { get; set; }
    }

    [DBTable(24492)]
    public class ComponentTextureFileData
    {
        [DBKey]
        public int ID { get; set; }
        public byte Field4 { get; set; }
        public byte Field5 { get; set; }
        public byte Field6 { get; set; }
    }

    [DBTable(24492)]
    public class Contribution
    {
        [DBKey]
        public int ID { get; set; }
        public int Field04 { get; set; }
        public string Field08 { get; set; }
        public string Field0C { get; set; }
        [DBField(ArraySize: 4)]
        public int[] Field10 { get; set; }
        public int Field20 { get; set; }
    }

    [DBTable(24492)]
    public class ConversationLine
    {
        [DBKey]
        public int ID { get; set; }
        public uint Field04 { get; set; }
        public uint Field08 { get; set; }
        public int Field0C { get; set; }
        public ushort Field10 { get; set; }
        public ushort Field12 { get; set; }
        public byte Field14 { get; set; }
        public byte Field15 { get; set; }
        public byte Field16 { get; set; }
    }

    [DBTable(24492)]
    public class Creature
    {
        [DBKey]
        public int ID { get; set; }
        [DBField(ArraySize: 3)]
        public uint[] Field04 { get; set; }
        public uint Field10 { get; set; }
        [DBField(ArraySize: 4)]
        public uint[] Field14 { get; set; }
        [DBField(ArraySize: 4)]
        public float[] Field24 { get; set; }
        public string Field34 { get; set; }
        public string Field38 { get; set; }
        public string Field3C { get; set; }
        public string Field40 { get; set; }
        public byte Field44 { get; set; }
        public byte Field45 { get; set; }
        public byte Field46 { get; set; }
        public byte Field47 { get; set; }
    }

    [DBTable(24492)]
    public class CreatureDifficulty
    {
        [DBKey]
        public int ID { get; set; }
        public uint Field04 { get; set; }
        [DBField(ArraySize: 7)]
        public int[] Field08 { get; set; }
        public ushort Field24 { get; set; }
        public byte Field26 { get; set; }
        public byte Field27 { get; set; }
        public byte Field28 { get; set; }
    }

    [DBTable(24492)]
    public class CreatureDisplayInfo
    {
        [DBKey]
        public int ID { get; set; }
        public uint Field04 { get; set; }
        public float Field08 { get; set; }
        public float Field0C { get; set; }
        [DBField(ArraySize: 3)]
        public uint[] Field10 { get; set; }
        public string Field1C { get; set; }
        public uint Field20 { get; set; }
        public uint Field24 { get; set; }
        public uint Field28 { get; set; }
        public float Field2C { get; set; }
        public ushort Field30 { get; set; }
        public ushort Field32 { get; set; }
        public ushort Field34 { get; set; }
        public ushort Field36 { get; set; }
        public ushort Field38 { get; set; }
        public ushort Field3A { get; set; }
        public byte Field3C { get; set; }
        public byte Field3D { get; set; }
        public byte Field3E { get; set; }
        public byte Field3F { get; set; }
        public byte Field40 { get; set; }
        public byte Field41 { get; set; }
    }

    [DBTable(24492)]
    public class CreatureDisplayInfoCond
    {
        [DBKey]
        public int ID { get; set; }
        public uint Field04 { get; set; }
        [DBField(ArraySize: 2)]
        public int[] Field08 { get; set; }
        [DBField(ArraySize: 2)]
        public uint[] Field10 { get; set; }
        [DBField(ArraySize: 2)]
        public uint[] Field18 { get; set; }
        public byte Field20 { get; set; }
        public byte Field21 { get; set; }
        public ushort Field22 { get; set; }
        public byte Field24 { get; set; }
        public byte Field25 { get; set; }
        public ushort Field26 { get; set; }
        public byte Field28 { get; set; }
        public byte Field29 { get; set; }
        public byte Field2A { get; set; }
        public ushort Field2B { get; set; }
        [DBField(ArraySize: 2)]
        public int[] Field2D { get; set; }
    }

    [DBTable(24492)]
    public class CreatureDisplayInfoEvt
    {
        [DBKey]
        public int ID { get; set; }
        public int Field00 { get; set; }
        public int Field04 { get; set; }
        public int Field08 { get; set; }
    }

    [DBTable(24492)]
    public class CreatureDisplayInfoExtra
    {
        [DBKey]
        public int ID { get; set; }
        public uint FileDataID { get; set; }
        public uint HDFileDataID { get; set; }
        public byte DisplayRaceID { get; set; }
        public byte DisplaySexID { get; set; }
        public byte DisplayClassID { get; set; }
        public byte SkinID { get; set; }
        public byte FaceID { get; set; }
        public byte HairStyleID { get; set; }
        public byte HairColorID { get; set; }
        public byte FacialHairID { get; set; }
        [DBField(ArraySize: 3)]
        public byte[] CustomDisplayOption { get; set; }
        public byte Flags { get; set; }
    }

    [DBTable(24492)]
    public class CreatureDisplayInfoTrn
    {
        [DBKey]
        public int ID { get; set; }
        public uint Field04 { get; set; }
        public uint Field08 { get; set; }
        public uint Field0C { get; set; }
        public float Field10 { get; set; }
    }

    [DBTable(24492)]
    public class CreatureDispXUiCamera
    {
        [DBKey]
        public int ID { get; set; }
        public uint Field4 { get; set; }
        public ushort Field8 { get; set; }
    }

    [DBTable(24492)]
    public class CreatureFamily
    {
        [DBKey]
        public int ID { get; set; }
        public float MinScale { get; set; }
        public float MaxScale { get; set; }
        public string Name { get; set; }
        public uint IconFileDataID { get; set; }
        [DBField(ArraySize: 2)]
        public ushort[] SkillLine { get; set; }
        public ushort PetFoodMask { get; set; }
        public byte MinScaleLevel { get; set; }
        public byte MaxScaleLevel { get; set; }
        public byte PetTalentType { get; set; }
    }

    [DBTable(24492)]
    public class CreatureImmunities
    {
        [DBKey]
        public int ID { get; set; }
        [DBField(ArraySize: 2)]
        public uint[] Field04 { get; set; }
        public byte Field0C { get; set; }
        public byte Field0D { get; set; }
        public byte Field0E { get; set; }
        public byte Field0F { get; set; }
        public byte Field10 { get; set; }
        public byte Field11 { get; set; }
        [DBField(ArraySize: 8)]
        public byte[] Field12 { get; set; }
        [DBField(ArraySize: 14)]
        public byte[] Field1A { get; set; }
    }

    [DBTable(24492)]
    public class CreatureModelData
    {
        [DBKey]
        public int ID { get; set; }
        public float ModelScale { get; set; }
        public float FootprintTextureLength { get; set; }
        public float FootprintTextureWidth { get; set; }
        public float FootprintParticleScale { get; set; }
        public float CollisionWidth { get; set; }
        public float CollisionHeight { get; set; }
        public float MountHeight { get; set; }
        [DBField(ArraySize: 6)]
        public float[] GeoBox { get; set; }
        public float WorldEffectScale { get; set; }
        public float AttachedEffectScale { get; set; }
        public float MissileCollisionRadius { get; set; }
        public float MissileCollisionPush { get; set; }
        public float MissileCollisionRaise { get; set; }
        public float OverrideLootEffectScale { get; set; }
        public float OverrideNameScale { get; set; }
        public float OverrideSelectionRadius { get; set; }
        public float TamedPetBaseScale { get; set; }
        public float HoverHeight { get; set; }
        public uint Flags { get; set; }
        public uint FileDataID { get; set; }
        public uint SizeClass { get; set; }
        public uint BloodID { get; set; }
        public uint FootprintTextureID { get; set; }
        public uint FoleyMaterialID { get; set; }
        public uint FootstepEffectID { get; set; }
        public uint DeathThudEffectID { get; set; }
        public uint SoundID { get; set; }
        public uint CreatureGeosetDataID { get; set; }
    }

    [DBTable(24492)]
    public class CreatureMovementInfo
    {
        [DBKey]
        public int ID { get; set; }
        public float Field4 { get; set; }
    }

    [DBTable(24492)]
    public class CreatureSoundData
    {
        [DBKey]
        public int ID { get; set; }
        public float Field004 { get; set; }
        public float Field008 { get; set; }
        public byte Field00C { get; set; }
        public int Field00D { get; set; }
        public int Field010 { get; set; }
        public int Field013 { get; set; }
        public int Field016 { get; set; }
        public byte Field019 { get; set; }
        public int Field01A { get; set; }
        public int Field01D { get; set; }
        public int Field020 { get; set; }
        public ushort Field023 { get; set; }
        public int Field025 { get; set; }
        public int Field028 { get; set; }
        public int Field02B { get; set; }
        public int Field02E { get; set; }
        [DBField(ArraySize: 5)]
        public int[] Field031 { get; set; }
        [DBField(ArraySize: 4)]
        public int[] Field040 { get; set; }
        public byte Field04C { get; set; }
        public int Field04D { get; set; }
        public int Field050 { get; set; }
        public int Field053 { get; set; }
        public ushort Field056 { get; set; }
        public ushort Field058 { get; set; }
        public ushort Field05A { get; set; }
        public int Field05C { get; set; }
        public ushort Field05F { get; set; }
        public int Field061 { get; set; }
        public int Field064 { get; set; }
        public ushort Field067 { get; set; }
        public int Field069 { get; set; }
        public int Field06C { get; set; }
        public int Field06F { get; set; }
        public byte Field072 { get; set; }
        public int Field073 { get; set; }
        public int Field076 { get; set; }
        public int Field079 { get; set; }
    }

    [DBTable(24492)]
    public class CreatureType
    {
        [DBKey]
        public int ID { get; set; }
        public string Name { get; set; }
        public byte Flags { get; set; }
    }

    [DBTable(24492)]
    public class CreatureXContribution
    {
        [DBKey]
        public int ID { get; set; }
        public int Field04 { get; set; }
        public int Field08 { get; set; }
    }

    [DBTable(24492)]
    public class Criteria
    {
        [DBKey]
        public int ID { get; set; }
        public uint Asset { get; set; }
        public uint StartAsset { get; set; }
        public uint FailAsset { get; set; }
        public ushort StartTimer { get; set; }
        public ushort ModifierTreeId { get; set; }
        public ushort EligibilityWorldStateID { get; set; }
        public byte Type { get; set; }
        public byte StartEvent { get; set; }
        public byte FailEvent { get; set; }
        public byte Flags { get; set; }
        public byte EligibilityWorldStateValue { get; set; }
    }

    [DBTable(24492)]
    public class CriteriaTree
    {
        [DBKey]
        public int ID { get; set; }
        public uint Amount { get; set; }
        public uint Field08 { get; set; }
        public string Description { get; set; }
        public ushort Parent { get; set; }
        public ushort Flags { get; set; }
        public byte Operator { get; set; }
        public ushort Field15 { get; set; }
    }

    [DBTable(24492)]
    public class CriteriaTreeXEffect
    {
        [DBKey]
        public int ID { get; set; }
        public ushort Field4 { get; set; }
        public ushort Field6 { get; set; }
    }

    [DBTable(24492)]
    public class CurrencyCategory
    {
        [DBKey]
        public int ID { get; set; }
        public string Field4 { get; set; }
        public byte Field8 { get; set; }
        public byte Field9 { get; set; }
    }

    [DBTable(24492)]
    public class CurrencyTypes
    {
        [DBKey]
        public int ID { get; set; }
        public string Name { get; set; }
        [DBField(ArraySize: 2)]
        public string[] InventoryIcon { get; set; }
        public uint MaxQty { get; set; }
        public uint MaxEarnablePerWeek { get; set; }
        public uint Flags { get; set; }
        public string Description { get; set; }
        public byte CategoryID { get; set; }
        public byte SpellCategory { get; set; }
        public byte Quality { get; set; }
        public uint SpellWeight { get; set; }
    }

    [DBTable(24492)]
    public class Curve
    {
        [DBKey]
        public int ID { get; set; }
        public byte Type { get; set; }
        public byte Unused { get; set; }
    }

    [DBTable(24492)]
    public class CurvePoint
    {
        [DBKey]
        public int ID { get; set; }
        [DBField(ArraySize: 2)]
        public float[] Position { get; set; }
        public ushort CurveID { get; set; }
        public byte Index { get; set; }
    }

    [DBTable(24492)]
    public class DeathThudLookups
    {
        [DBKey]
        public int ID { get; set; }
        public byte Field4 { get; set; }
        public byte Field5 { get; set; }
        public ushort Field6 { get; set; }
        public ushort Field8 { get; set; }
    }

    [DBTable(24492)]
    public class DecalProperties
    {
        [DBKey]
        public int ID { get; set; }
        public uint Field04 { get; set; }
        public float Field08 { get; set; }
        public float Field0C { get; set; }
        public int Field10 { get; set; }
        public float Field14 { get; set; }
        public float Field18 { get; set; }
        public float Field1C { get; set; }
        public float Field20 { get; set; }
        public float Field24 { get; set; }
        public byte Field28 { get; set; }
        public byte Field29 { get; set; }
        public ushort Field2A { get; set; }
        public ushort Field2C { get; set; }
        public byte Field2E { get; set; }
    }

    [DBTable(24492)]
    public class DeclinedWord
    {
        public uint Field0 { get; set; }
        [DBKey]
        public int ID { get; set; }
    }

    [DBTable(24492)]
    public class DeclinedWordCases
    {
        [DBKey]
        public int ID { get; set; }
        public uint Field4 { get; set; }
        public byte Field8 { get; set; }
        public byte Field9 { get; set; }
    }

    [DBTable(24492)]
    public class DestructibleModelData
    {
        [DBKey]
        public int ID { get; set; }
        public ushort StateDamagedDisplayID { get; set; }
        public ushort StateDestroyedDisplayID { get; set; }
        public ushort StateRebuildingDisplayID { get; set; }
        public ushort StateSmokeDisplayID { get; set; }
        public ushort HealEffectSpeed { get; set; }
        public byte StateDamagedImpactEffectDoodadSet { get; set; }
        public byte StateDamagedAmbientDoodadSet { get; set; }
        public byte StateDamagedNameSet { get; set; }
        public byte StateDestroyedDestructionDoodadSet { get; set; }
        public byte StateDestroyedImpactEffectDoodadSet { get; set; }
        public byte StateDestroyedAmbientDoodadSet { get; set; }
        public byte StateDestroyedNameSet { get; set; }
        public byte StateRebuildingDestructionDoodadSet { get; set; }
        public byte StateRebuildingImpactEffectDoodadSet { get; set; }
        public byte StateRebuildingAmbientDoodadSet { get; set; }
        public byte StateRebuildingNameSet { get; set; }
        public byte StateSmokeInitDoodadSet { get; set; }
        public byte StateSmokeAmbientDoodadSet { get; set; }
        public byte StateSmokeNameSet { get; set; }
        public byte EjectDirection { get; set; }
        public byte DoNotHighlight { get; set; }
        public byte HealEffect { get; set; }
    }

    [DBTable(24492)]
    public class DeviceBlacklist
    {
        [DBKey]
        public int ID { get; set; }
        public ushort Field4 { get; set; }
        public ushort Field6 { get; set; }
    }

    [DBTable(24492)]
    public class DeviceDefaultSettings
    {
        [DBKey]
        public int ID { get; set; }
        public ushort Field4 { get; set; }
        public ushort Field6 { get; set; }
        public byte Field8 { get; set; }
    }

    [DBTable(24492)]
    public class Difficulty
    {
        [DBKey]
        public int ID { get; set; }
        public string Name { get; set; }
        public byte GroupSizeHealthCurveID { get; set; }
        public byte GroupSizeDmgCurveID { get; set; }
        public byte GroupSizeSpellPointsCurveID { get; set; }
        public byte FallbackDifficultyID { get; set; }
        public byte InstanceType { get; set; }
        public byte MinPlayers { get; set; }
        public byte MaxPlayers { get; set; }
        public byte OldEnumValue { get; set; }
        public byte Flags { get; set; }
        public byte ToggleDifficultyID { get; set; }
        public byte ItemBonusTreeModID { get; set; }
        public byte OrderIndex { get; set; }
    }

    [DBTable(24492)]
    public class DissolveEffect
    {
        [DBKey]
        public int ID { get; set; }
        public float Field04 { get; set; }
        public float Field08 { get; set; }
        public float Field0C { get; set; }
        public float Field10 { get; set; }
        public float Field14 { get; set; }
        public float Field18 { get; set; }
        public float Field1C { get; set; }
        public byte Field20 { get; set; }
        public byte Field21 { get; set; }
        public ushort Field22 { get; set; }
        public byte Field24 { get; set; }
    }

    [DBTable(24492)]
    public class DriverBlacklist
    {
        [DBKey]
        public int ID { get; set; }
        public uint Field04 { get; set; }
        public uint Field08 { get; set; }
        public ushort Field0C { get; set; }
        public byte Field0E { get; set; }
        public byte Field0F { get; set; }
        public byte Field10 { get; set; }
        public byte Field11 { get; set; }
    }

    [DBTable(24492)]
    public class DungeonEncounter
    {
        [DBKey]
        public int ID { get; set; }
        public string Field04 { get; set; }
        public uint Field08 { get; set; }
        public ushort Field0C { get; set; }
        public ushort Field0E { get; set; }
        public byte Field10 { get; set; }
        public byte Field11 { get; set; }
        public byte Field12 { get; set; }
        public ushort Field13 { get; set; }
    }

    [DBTable(24492)]
    public class DungeonMap
    {
        [DBField(ArraySize: 2)]
        public int[] Field00 { get; set; }
        [DBField(ArraySize: 2)]
        public int[] Field08 { get; set; }
        public ushort Field10 { get; set; }
        public ushort Field12 { get; set; }
        public byte Field14 { get; set; }
        public byte Field15 { get; set; }
        [DBKey]
        public int ID { get; set; }
    }

    [DBTable(24492)]
    public class DungeonMapChunk
    {
        [DBKey]
        public int ID { get; set; }
        public int Field04 { get; set; }
        public uint Field08 { get; set; }
        public ushort Field0C { get; set; }
        public ushort Field0E { get; set; }
        public ushort Field10 { get; set; }
    }

    [DBTable(24492)]
    public class DurabilityCosts
    {
        [DBKey]
        public int ID { get; set; }
        [DBField(ArraySize: 21)]
        public ushort[] WeaponSubClassCost { get; set; }
        [DBField(ArraySize: 8)]
        public ushort[] ArmorSubClassCost { get; set; }
    }

    [DBTable(24492)]
    public class DurabilityQuality
    {
        [DBKey]
        public int ID { get; set; }
        public float QualityMod { get; set; }
    }

    [DBTable(24492)]
    public class EdgeGlowEffect
    {
        [DBKey]
        public int ID { get; set; }
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
        public byte Field2C { get; set; }
    }

    [DBTable(24492)]
    public class Emotes
    {
        [DBKey]
        public int ID { get; set; }
        public string EmoteSlashCommand { get; set; }
        public uint SpellVisualKitID { get; set; }
        public uint EmoteFlags { get; set; }
        public ushort AnimID { get; set; }
        public byte EmoteSpecProc { get; set; }
        public uint EmoteSpecProcParam { get; set; }
        public uint EmoteSoundID { get; set; }
        public int ClassMask { get; set; }
        public int RaceMask { get; set; }
    }

    [DBTable(24492)]
    public class EmotesText
    {
        [DBKey]
        public int ID { get; set; }
        public string Name { get; set; }
        public ushort EmoteID { get; set; }
    }

    [DBTable(24492)]
    public class EmotesTextData
    {
        [DBKey]
        public int ID { get; set; }
        public string Field04 { get; set; }
        public ushort Field08 { get; set; }
        public byte Field0A { get; set; }
    }

    [DBTable(24492)]
    public class EmotesTextSound
    {
        [DBKey]
        public int ID { get; set; }
        public ushort EmotesTextId { get; set; }
        public byte RaceId { get; set; }
        public byte SexId { get; set; }
        public byte ClassId { get; set; }
        public uint SoundId { get; set; }
    }

    [DBTable(24492)]
    public class EnvironmentalDamage
    {
        [DBKey]
        public int ID { get; set; }
        public ushort Field4 { get; set; }
        public byte Field6 { get; set; }
    }

    [DBTable(24492)]
    public class Exhaustion
    {
        public int Field00 { get; set; }
        public float Field04 { get; set; }
        public int Field08 { get; set; }
        public float Field0C { get; set; }
        public string Field10 { get; set; }
        public float Field14 { get; set; }
        public string Field18 { get; set; }
        [DBKey]
        [DBField(ArraySize: 4)]
        public int[] ID { get; set; }
    }

    [DBTable(24492)]
    public class Faction
    {
        [DBKey]
        public int ID { get; set; }
        [DBField(ArraySize: 4)]
        public uint[] ReputationRaceMask { get; set; }
        [DBField(ArraySize: 4)]
        public int[] ReputationBase { get; set; }
        [DBField(ArraySize: 2)]
        public float[] ParentFactionMod { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        [DBField(ArraySize: 4)]
        public uint[] ReputationMax { get; set; }
        public ushort ParagonFactionID { get; set; }
        [DBField(ArraySize: 4)]
        public ushort[] ReputationClassMask { get; set; }
        [DBField(ArraySize: 4)]
        public ushort[] ReputationFlags { get; set; }
        public ushort ParentFactionID { get; set; }
        [DBField(ArraySize: 2)]
        public byte[] ParentFactionCap { get; set; }
        public byte Expansion { get; set; }
        public byte Flags { get; set; }
        public byte FriendshipRepID { get; set; }
    }

    [DBTable(24492)]
    public class FactionGroup
    {
        [DBKey]
        public int ID { get; set; }
        public string Field04 { get; set; }
        public string Field08 { get; set; }
        public byte Field0C { get; set; }
    }

    [DBTable(24492)]
    public class FactionTemplate
    {
        [DBKey]
        public int ID { get; set; }
        public ushort Faction { get; set; }
        public ushort Flags { get; set; }
        [DBField(ArraySize: 4)]
        public ushort[] Enemies { get; set; }
        [DBField(ArraySize: 4)]
        public ushort[] Friends { get; set; }
        public byte Mask { get; set; }
        public byte FriendMask { get; set; }
        public byte EnemyMask { get; set; }
    }

    [DBTable(24492)]
    public class FootprintTextures
    {
        public string Field0 { get; set; }
        [DBKey]
        public int ID { get; set; }
    }

    [DBTable(24492)]
    public class FootstepTerrainLookup
    {
        [DBKey]
        public int ID { get; set; }
        public ushort Field04 { get; set; }
        public byte Field06 { get; set; }
        public int Field07 { get; set; }
        public int Field0A { get; set; }
    }

    [DBTable(24492)]
    public class FriendshipRepReaction
    {
        [DBKey]
        public int ID { get; set; }
        public string Field04 { get; set; }
        public ushort Field08 { get; set; }
        public byte Field0A { get; set; }
    }

    [DBTable(24492)]
    public class FriendshipReputation
    {
        public uint Field00 { get; set; }
        public string Field04 { get; set; }
        public ushort Field08 { get; set; }
        [DBKey]
        [DBField(ArraySize: 2)]
        public int[] ID { get; set; }
    }

    [DBTable(24492)]
    public class FullScreenEffect
    {
        [DBKey]
        public int ID { get; set; }
        public float Field004 { get; set; }
        public float Field008 { get; set; }
        public float Field00C { get; set; }
        public float Field010 { get; set; }
        public uint Field014 { get; set; }
        public float Field018 { get; set; }
        public float Field01C { get; set; }
        public uint Field020 { get; set; }
        public float Field024 { get; set; }
        public float Field028 { get; set; }
        public uint Field02C { get; set; }
        public float Field030 { get; set; }
        public float Field034 { get; set; }
        public float Field038 { get; set; }
        public float Field03C { get; set; }
        public float Field040 { get; set; }
        public uint Field044 { get; set; }
        public float Field048 { get; set; }
        public float Field04C { get; set; }
        public uint Field050 { get; set; }
        public uint Field054 { get; set; }
        public float Field058 { get; set; }
        public float Field05C { get; set; }
        public byte Field060 { get; set; }
        public ushort Field061 { get; set; }
        public ushort Field063 { get; set; }
        public ushort Field065 { get; set; }
    }

    [DBTable(24492)]
    public class GameObjectArtKit
    {
        [DBKey]
        public int ID { get; set; }
        [DBField(ArraySize: 3)]
        public byte[] Field4 { get; set; }
        public int Field7 { get; set; }
    }

    [DBTable(24492)]
    public class GameObjectDiffAnimMap
    {
        [DBKey]
        public int ID { get; set; }
        public ushort Field4 { get; set; }
        public byte Field6 { get; set; }
        public byte Field7 { get; set; }
        public byte Field8 { get; set; }
    }

    [DBTable(24492)]
    public class GameObjectDisplayInfo
    {
        [DBKey]
        public int ID { get; set; }
        public uint FileDataID { get; set; }
        [DBField(ArraySize: 6)]
        public float[] GeoBox { get; set; }
        public float OverrideLootEffectScale { get; set; }
        public float OverrideNameScale { get; set; }
        public ushort ObjectEffectPackageID { get; set; }
    }

    [DBTable(24492)]
    public class GameObjectDisplayInfoXSoundKit
    {
        [DBKey]
        public int ID { get; set; }
        public byte Field4 { get; set; }
        public int Field5 { get; set; }
        public ushort Field8 { get; set; }
    }

    [DBTable(24492)]
    public class GameObjects
    {
        [DBField(ArraySize: 3)]
        public float[] Position { get; set; }
        [DBField(ArraySize: 4)]
        public float[] Rotation { get; set; }
        public float Size { get; set; }
        [DBField(ArraySize: 8)]
        public int[] Data { get; set; }
        public string Name { get; set; }
        public ushort MapID { get; set; }
        public ushort DisplayID { get; set; }
        public ushort PhaseID { get; set; }
        public ushort PhaseGroupID { get; set; }
        public byte PhaseUseFlags { get; set; }
        public byte Type { get; set; }
        [DBKey]
        public int ID { get; set; }
    }

    [DBTable(24492)]
    public class GameTips
    {
        [DBKey]
        public int ID { get; set; }
        public string Field04 { get; set; }
        public byte Field08 { get; set; }
        public byte Field09 { get; set; }
        public byte Field0A { get; set; }
    }

    [DBTable(24492)]
    public class GarrAbility
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public uint IconFileDataID { get; set; }
        public ushort Flags { get; set; }
        public ushort OtherFactionGarrAbilityID { get; set; }
        public byte GarrAbilityCategoryID { get; set; }
        public byte FollowerTypeID { get; set; }
        [DBKey]
        public int ID { get; set; }
    }

    [DBTable(24492)]
    public class GarrAbilityCategory
    {
        [DBKey]
        public int ID { get; set; }
        public string Field4 { get; set; }
    }

    [DBTable(24492)]
    public class GarrAbilityEffect
    {
        public int Field00 { get; set; }
        public int Field04 { get; set; }
        public int Field08 { get; set; }
        public uint Field0C { get; set; }
        public ushort Field10 { get; set; }
        public byte Field12 { get; set; }
        public byte Field13 { get; set; }
        public byte Field14 { get; set; }
        public byte Field15 { get; set; }
        public byte Field16 { get; set; }
        public byte Field17 { get; set; }
        [DBKey]
        [DBField(ArraySize: 2)]
        public int[] ID { get; set; }
    }

    [DBTable(24492)]
    public class GarrBuilding
    {
        [DBKey]
        public int ID { get; set; }
        public uint HordeGameObjectID { get; set; }
        public uint AllianceGameObjectID { get; set; }
        public string NameAlliance { get; set; }
        public string NameHorde { get; set; }
        public string Description { get; set; }
        public string Tooltip { get; set; }
        public uint IconFileDataID { get; set; }
        public ushort CostCurrencyID { get; set; }
        public ushort HordeTexPrefixKitID { get; set; }
        public ushort AllianceTexPrefixKitID { get; set; }
        public ushort AllianceActivationScenePackageID { get; set; }
        public ushort HordeActivationScenePackageID { get; set; }
        public ushort FollowerRequiredGarrAbilityID { get; set; }
        public ushort FollowerGarrAbilityEffectID { get; set; }
        public ushort CostMoney { get; set; }
        public byte Unknown { get; set; }
        public byte Type { get; set; }
        public byte Level { get; set; }
        public byte Flags { get; set; }
        public byte MaxShipments { get; set; }
        public byte GarrTypeID { get; set; }
        public int BuildDuration { get; set; }
        public int CostCurrencyAmount { get; set; }
        public int BonusAmount { get; set; }
    }

    [DBTable(24492)]
    public class GarrBuildingDoodadSet
    {
        [DBKey]
        public int ID { get; set; }
        public byte Field4 { get; set; }
        public byte Field5 { get; set; }
        public byte Field6 { get; set; }
        public byte Field7 { get; set; }
        public byte Field8 { get; set; }
    }

    [DBTable(24492)]
    public class GarrBuildingPlotInst
    {
        [DBField(ArraySize: 2)]
        public float[] LandmarkOffset { get; set; }
        public ushort UiTextureAtlasMemberID { get; set; }
        public ushort GarrSiteLevelPlotInstID { get; set; }
        public byte GarrBuildingID { get; set; }
        [DBKey]
        public int ID { get; set; }
    }

    [DBTable(24492)]
    public class GarrClassSpec
    {
        public string Field00 { get; set; }
        public string Field04 { get; set; }
        public string Field08 { get; set; }
        public ushort Field0C { get; set; }
        public byte Field0E { get; set; }
        public byte Field0F { get; set; }
        public byte Field10 { get; set; }
        [DBKey]
        [DBField(ArraySize: 3)]
        public int[] ID { get; set; }
    }

    [DBTable(24492)]
    public class GarrClassSpecPlayerCond
    {
        [DBKey]
        public int ID { get; set; }
        public uint Field04 { get; set; }
        public string Field08 { get; set; }
        public byte Field0C { get; set; }
        public byte Field0D { get; set; }
        public ushort Field0E { get; set; }
        public byte Field10 { get; set; }
    }

    [DBTable(24492)]
    public class GarrEncounter
    {
        public uint Field00 { get; set; }
        public string Field04 { get; set; }
        public float Field08 { get; set; }
        public float Field0C { get; set; }
        public uint Field10 { get; set; }
        public ushort Field14 { get; set; }
        [DBKey]
        public int ID { get; set; }
    }

    [DBTable(24492)]
    public class GarrEncounterSetXEncounter
    {
        [DBKey]
        public int ID { get; set; }
        public byte Field4 { get; set; }
        public ushort Field5 { get; set; }
    }

    [DBTable(24492)]
    public class GarrEncounterXMechanic
    {
        [DBKey]
        public int ID { get; set; }
        public ushort Field4 { get; set; }
        public byte Field6 { get; set; }
        public byte Field7 { get; set; }
    }

    [DBTable(24492)]
    public class GarrFollItemSetMember
    {
        [DBKey]
        public int ID { get; set; }
        public uint Field04 { get; set; }
        public ushort Field08 { get; set; }
        public ushort Field0A { get; set; }
        public byte Field0C { get; set; }
    }

    [DBTable(24492)]
    public class GarrFollower
    {
        public uint Field00 { get; set; }
        public uint Field04 { get; set; }
        public string Field08 { get; set; }
        public string Field0C { get; set; }
        public uint Field10 { get; set; }
        public uint Field14 { get; set; }
        public uint Field18 { get; set; }
        public uint Field1C { get; set; }
        public ushort Field20 { get; set; }
        public ushort Field22 { get; set; }
        public ushort Field24 { get; set; }
        public ushort Field26 { get; set; }
        public ushort Field28 { get; set; }
        public ushort Field2A { get; set; }
        public byte Field2C { get; set; }
        public byte Field2D { get; set; }
        public byte Field2E { get; set; }
        public byte Field2F { get; set; }
        public byte Field30 { get; set; }
        public byte Field31 { get; set; }
        public byte Field32 { get; set; }
        public byte Field33 { get; set; }
        public byte Field34 { get; set; }
        public byte Field35 { get; set; }
        public byte Field36 { get; set; }
        public byte Field37 { get; set; }
        public byte Field38 { get; set; }
        public byte Field39 { get; set; }
        public byte Field3A { get; set; }
        public byte Field3B { get; set; }
        [DBKey]
        [DBField(ArraySize: 2)]
        public int[] ID { get; set; }
    }

    [DBTable(24492)]
    public class GarrFollowerLevelXP
    {
        [DBKey]
        public int ID { get; set; }
        public ushort Field4 { get; set; }
        public ushort Field6 { get; set; }
        public byte Field8 { get; set; }
        public byte Field9 { get; set; }
    }

    [DBTable(24492)]
    public class GarrFollowerQuality
    {
        [DBKey]
        public int ID { get; set; }
        public uint Field04 { get; set; }
        public ushort Field08 { get; set; }
        public byte Field0A { get; set; }
        public byte Field0B { get; set; }
        public byte Field0C { get; set; }
        public byte Field0D { get; set; }
        public byte Field0E { get; set; }
    }

    [DBTable(24492)]
    public class GarrFollowerSetXFollower
    {
        [DBKey]
        public int ID { get; set; }
        public byte Field4 { get; set; }
        public byte Field5 { get; set; }
    }

    [DBTable(24492)]
    public class GarrFollowerType
    {
        [DBKey]
        public int ID { get; set; }
        public ushort Field04 { get; set; }
        public byte Field06 { get; set; }
        public byte Field07 { get; set; }
        public byte Field08 { get; set; }
        public byte Field09 { get; set; }
        public byte Field0A { get; set; }
        public byte Field0B { get; set; }
    }

    [DBTable(24492)]
    public class GarrFollowerUICreature
    {
        [DBKey]
        public int ID { get; set; }
        public uint Field04 { get; set; }
        public float Field08 { get; set; }
        public ushort Field0C { get; set; }
        public byte Field0E { get; set; }
        public byte Field0F { get; set; }
        public byte Field10 { get; set; }
    }

    [DBTable(24492)]
    public class GarrFollowerXAbility
    {
        [DBKey]
        public int ID { get; set; }
        public ushort GarrFollowerID { get; set; }
        public ushort GarrAbilityID { get; set; }
        public byte FactionIndex { get; set; }
    }

    [DBTable(24492)]
    public class GarrFollSupportSpell
    {
        [DBKey]
        public int ID { get; set; }
        public uint Field04 { get; set; }
        public uint Field08 { get; set; }
        public byte Field0C { get; set; }
        public ushort Field0D { get; set; }
    }

    [DBTable(24492)]
    public class GarrItemLevelUpgradeData
    {
        [DBKey]
        public int ID { get; set; }
        public int Field04 { get; set; }
        public int Field08 { get; set; }
        public int Field0C { get; set; }
        public int Field10 { get; set; }
    }

    [DBTable(24492)]
    public class GarrMechanic
    {
        [DBKey]
        public int ID { get; set; }
        public uint Field4 { get; set; }
        public byte Field8 { get; set; }
        public ushort Field9 { get; set; }
    }

    [DBTable(24492)]
    public class GarrMechanicSetXMechanic
    {
        public byte Field0 { get; set; }
        [DBKey]
        public int ID { get; set; }
        public byte Field2 { get; set; }
    }

    [DBTable(24492)]
    public class GarrMechanicType
    {
        public string Field00 { get; set; }
        public string Field04 { get; set; }
        public uint Field08 { get; set; }
        public byte Field0C { get; set; }
        [DBKey]
        public int ID { get; set; }
    }

    [DBTable(24492)]
    public class GarrMission
    {
        public uint Field00 { get; set; }
        public uint Field04 { get; set; }
        public string Field08 { get; set; }
        public string Field0C { get; set; }
        public string Field10 { get; set; }
        public uint Field14 { get; set; }
        public uint Field18 { get; set; }
        [DBField(ArraySize: 2)]
        public float[] Field1C { get; set; }
        [DBField(ArraySize: 2)]
        public int[] Field24 { get; set; }
        public ushort Field2C { get; set; }
        public ushort Field2E { get; set; }
        public ushort Field30 { get; set; }
        public ushort Field32 { get; set; }
        public ushort Field34 { get; set; }
        public ushort Field36 { get; set; }
        public byte Field38 { get; set; }
        public byte Field39 { get; set; }
        public byte Field3A { get; set; }
        public byte Field3B { get; set; }
        public byte Field3C { get; set; }
        public byte Field3D { get; set; }
        public byte Field3E { get; set; }
        public byte Field3F { get; set; }
        public byte Field40 { get; set; }
        [DBKey]
        public int ID { get; set; }
        public byte Field43 { get; set; }
        public ushort Field44 { get; set; }
        public ushort Field46 { get; set; }
        [DBField(ArraySize: 4)]
        public byte[] Field48 { get; set; }
    }

    [DBTable(24492)]
    public class GarrMissionTexture
    {
        [DBKey]
        public int ID { get; set; }
        [DBField(ArraySize: 2)]
        public float[] Field04 { get; set; }
        public ushort Field0C { get; set; }
    }

    [DBTable(24492)]
    public class GarrMissionType
    {
        [DBKey]
        public int ID { get; set; }
        public string Field04 { get; set; }
        public ushort Field08 { get; set; }
        public ushort Field0A { get; set; }
    }

    [DBTable(24492)]
    public class GarrMissionXEncounter
    {
        public byte Field0 { get; set; }
        [DBKey]
        public int ID { get; set; }
        public ushort Field3 { get; set; }
        public ushort Field5 { get; set; }
        public byte Field7 { get; set; }
    }

    [DBTable(24492)]
    public class GarrMissionXFollower
    {
        [DBKey]
        public int ID { get; set; }
        public ushort Field4 { get; set; }
        public ushort Field6 { get; set; }
        public byte Field8 { get; set; }
    }

    [DBTable(24492)]
    public class GarrMssnBonusAbility
    {
        [DBKey]
        public int ID { get; set; }
        public float Field04 { get; set; }
        public uint Field08 { get; set; }
        public ushort Field0C { get; set; }
        public byte Field0E { get; set; }
        public byte Field0F { get; set; }
    }

    [DBTable(24492)]
    public class GarrPlot
    {
        [DBKey]
        public int ID { get; set; }
        public string Name { get; set; }
        public uint AllianceConstructionGameObjectID { get; set; }
        public uint HordeConstructionGameObjectID { get; set; }
        public byte GarrPlotUICategoryID { get; set; }
        public byte PlotType { get; set; }
        public byte Flags { get; set; }
        [DBField(ArraySize: 2)]
        public uint[] MinCount { get; set; }
    }

    [DBTable(24492)]
    public class GarrPlotBuilding
    {
        [DBKey]
        public int ID { get; set; }
        public byte GarrPlotID { get; set; }
        public byte GarrBuildingID { get; set; }
    }

    [DBTable(24492)]
    public class GarrPlotInstance
    {
        [DBKey]
        public int ID { get; set; }
        public string Name { get; set; }
        public byte GarrPlotID { get; set; }
    }

    [DBTable(24492)]
    public class GarrPlotUICategory
    {
        [DBKey]
        public int ID { get; set; }
        public string Field4 { get; set; }
        public byte Field8 { get; set; }
    }

    [DBTable(24492)]
    public class GarrSiteLevel
    {
        [DBKey]
        public int ID { get; set; }
        [DBField(ArraySize: 2)]
        public float[] TownHall { get; set; }
        public ushort MapID { get; set; }
        public ushort SiteID { get; set; }
        public ushort MovieID { get; set; }
        public ushort UpgradeResourceCost { get; set; }
        public byte UpgradeMoneyCost { get; set; }
        public byte Level { get; set; }
        public byte UITextureKitID { get; set; }
        public byte Level2 { get; set; }
    }

    [DBTable(24492)]
    public class GarrSiteLevelPlotInst
    {
        [DBKey]
        public int ID { get; set; }
        [DBField(ArraySize: 2)]
        public float[] Landmark { get; set; }
        public ushort GarrSiteLevelID { get; set; }
        public byte GarrPlotInstanceID { get; set; }
        public byte Unknown { get; set; }
    }

    [DBTable(24492)]
    public class GarrSpecialization
    {
        [DBKey]
        public int ID { get; set; }
        public uint Field04 { get; set; }
        [DBField(ArraySize: 2)]
        public float[] Field08 { get; set; }
        public string Field10 { get; set; }
        public string Field14 { get; set; }
        public byte Field18 { get; set; }
        public byte Field19 { get; set; }
        public byte Field1A { get; set; }
    }

    [DBTable(24492)]
    public class GarrString
    {
        [DBKey]
        public int ID { get; set; }
        public string Field4 { get; set; }
    }

    [DBTable(24492)]
    public class GarrTalent
    {
        public uint Field00 { get; set; }
        public string Field04 { get; set; }
        public string Field08 { get; set; }
        public uint Field0C { get; set; }
        public byte Field10 { get; set; }
        public byte Field11 { get; set; }
        public byte Field12 { get; set; }
        [DBKey]
        public int ID { get; set; }
        public byte Field15 { get; set; }
        public ushort Field16 { get; set; }
        public ushort Field18 { get; set; }
        public ushort Field1A { get; set; }
        public ushort Field1C { get; set; }
        public byte Field1E { get; set; }
        public int Field1F { get; set; }
        public ushort Field22 { get; set; }
        public ushort Field24 { get; set; }
        public ushort Field26 { get; set; }
        public int Field28 { get; set; }
        public byte Field2B { get; set; }
    }

    [DBTable(24492)]
    public class GarrTalentTree
    {
        [DBKey]
        public int ID { get; set; }
        public byte Field4 { get; set; }
        public byte Field5 { get; set; }
        public byte Field6 { get; set; }
        public byte Field7 { get; set; }
    }

    [DBTable(24492)]
    public class GarrType
    {
        [DBKey]
        public int ID { get; set; }
        public byte Field04 { get; set; }
        public ushort Field05 { get; set; }
        public ushort Field07 { get; set; }
        public byte Field09 { get; set; }
        public ushort Field0A { get; set; }
    }

    [DBTable(24492)]
    public class GarrUiAnimClassInfo
    {
        [DBKey]
        public int ID { get; set; }
        public float Field04 { get; set; }
        public ushort Field08 { get; set; }
        public byte Field0A { get; set; }
        public byte Field0B { get; set; }
    }

    [DBTable(24492)]
    public class GarrUiAnimRaceInfo
    {
        [DBKey]
        public int ID { get; set; }
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
        public byte Field34 { get; set; }
    }

    [DBTable(24492)]
    public class GemProperties
    {
        [DBKey]
        public int ID { get; set; }
        public uint Type { get; set; }
        public ushort EnchantID { get; set; }
        public ushort MinItemLevel { get; set; }
    }

    [DBTable(24492)]
    public class GlobalStrings
    {
        [DBKey]
        public int ID { get; set; }
        public string Field04 { get; set; }
        public string Field08 { get; set; }
        public byte Field0C { get; set; }
    }

    [DBTable(24492)]
    public class GlyphBindableSpell
    {
        [DBKey]
        public int ID { get; set; }
        public uint SpellID { get; set; }
        public ushort GlyphPropertiesID { get; set; }
    }

    [DBTable(24492)]
    public class GlyphExclusiveCategory
    {
        [DBKey]
        public int ID { get; set; }
        public string Field4 { get; set; }
    }

    [DBTable(24492)]
    public class GlyphProperties
    {
        [DBKey]
        public int ID { get; set; }
        public uint SpellID { get; set; }
        public ushort SpellIconID { get; set; }
        public byte Type { get; set; }
        public byte GlyphExclusiveCategoryID { get; set; }
    }

    [DBTable(24492)]
    public class GlyphRequiredSpec
    {
        [DBKey]
        public int ID { get; set; }
        public ushort GlyphPropertiesID { get; set; }
        public ushort ChrSpecializationID { get; set; }
    }

    [DBTable(24492)]
    public class GMSurveyAnswers
    {
        [DBKey]
        public int ID { get; set; }
        public string Field4 { get; set; }
        public byte Field8 { get; set; }
        public byte Field9 { get; set; }
    }

    [DBTable(24492)]
    public class GMSurveyCurrentSurvey
    {
        [DBKey]
        public int ID { get; set; }
        public byte Field4 { get; set; }
    }

    [DBTable(24492)]
    public class GMSurveyQuestions
    {
        [DBKey]
        public int ID { get; set; }
        public string Field4 { get; set; }
    }

    [DBTable(24492)]
    public class GMSurveySurveys
    {
        [DBKey]
        public int ID { get; set; }
        [DBField(ArraySize: 11)]
        public byte[] Field4 { get; set; }
    }

    [DBTable(24492)]
    public class GroundEffectDoodad
    {
        [DBKey]
        public int ID { get; set; }
        public string Field04 { get; set; }
        public float Field08 { get; set; }
        public float Field0C { get; set; }
        public byte Field10 { get; set; }
    }

    [DBTable(24492)]
    public class GroundEffectTexture
    {
        [DBKey]
        public int ID { get; set; }
        [DBField(ArraySize: 4)]
        public ushort[] Field04 { get; set; }
        [DBField(ArraySize: 4)]
        public byte[] Field0C { get; set; }
        public byte Field10 { get; set; }
        public byte Field11 { get; set; }
    }

    [DBTable(24492)]
    public class GroupFinderActivity
    {
        [DBKey]
        public int ID { get; set; }
        public string Field04 { get; set; }
        public string Field08 { get; set; }
        public ushort Field0C { get; set; }
        public ushort Field0E { get; set; }
        public ushort Field10 { get; set; }
        public byte Field12 { get; set; }
        public byte Field13 { get; set; }
        public byte Field14 { get; set; }
        public byte Field15 { get; set; }
        public byte Field16 { get; set; }
        public byte Field17 { get; set; }
        public byte Field18 { get; set; }
        public byte Field19 { get; set; }
        public byte Field1A { get; set; }
    }

    [DBTable(24492)]
    public class GroupFinderActivityGrp
    {
        [DBKey]
        public int ID { get; set; }
        public string Field4 { get; set; }
        public byte Field8 { get; set; }
    }

    [DBTable(24492)]
    public class GroupFinderCategory
    {
        [DBKey]
        public int ID { get; set; }
        public string Field4 { get; set; }
        public byte Field8 { get; set; }
        public byte Field9 { get; set; }
    }

    [DBTable(24492)]
    public class GuildColorBackground
    {
        [DBKey]
        public int ID { get; set; }
        public byte Red { get; set; }
        public byte Green { get; set; }
        public byte Blue { get; set; }
    }

    [DBTable(24492)]
    public class GuildColorBorder
    {
        [DBKey]
        public int ID { get; set; }
        public byte Red { get; set; }
        public byte Green { get; set; }
        public byte Blue { get; set; }
    }

    [DBTable(24492)]
    public class GuildColorEmblem
    {
        [DBKey]
        public int ID { get; set; }
        public byte Red { get; set; }
        public byte Green { get; set; }
        public byte Blue { get; set; }
    }

    [DBTable(24492)]
    public class GuildPerkSpells
    {
        [DBKey]
        public int ID { get; set; }
        public uint SpellID { get; set; }
    }

    [DBTable(24492)]
    public class Heirloom
    {
        public int ItemID { get; set; }
        public string SourceText { get; set; }
        public int OldItem_1 { get; set; }
        public int OldItem_2 { get; set; }
        public int NextDifficultyItemID { get; set; }
        [DBField(ArraySize: 2)]
        public int[] UpgradeItemID { get; set; }
        [DBField(ArraySize: 2)]
        public ushort[] ItemBonusListID { get; set; }
        public byte Flags { get; set; }
        public byte Source { get; set; }
        [DBKey]
        public int ID { get; set; }
    }

    [DBTable(24492)]
    public class HelmetAnimScaling
    {
        [DBKey]
        public int ID { get; set; }
        public float Field04 { get; set; }
        public ushort Field08 { get; set; }
        public byte Field0A { get; set; }
    }

    [DBTable(24492)]
    public class HelmetGeosetVisData
    {
        [DBKey]
        public int ID { get; set; }
        [DBField(ArraySize: 8)]
        public int[] Field4 { get; set; }
    }

    [DBTable(24492)]
    public class HighlightColor
    {
        [DBKey]
        public int ID { get; set; }
        public int Field04 { get; set; }
        public int Field08 { get; set; }
        public int Field0C { get; set; }
        public byte Field10 { get; set; }
        public byte Field11 { get; set; }
    }

    [DBTable(24492)]
    public class HolidayDescriptions
    {
        [DBKey]
        public int ID { get; set; }
        public string Field4 { get; set; }
    }

    [DBTable(24492)]
    public class HolidayNames
    {
        [DBKey]
        public int ID { get; set; }
        public string Field4 { get; set; }
    }

    [DBTable(24492)]
    public class Holidays
    {
        [DBKey]
        public int ID { get; set; }
        [DBField(ArraySize: 16)]
        public uint[] Date { get; set; }
        [DBField(ArraySize: 10)]
        public ushort[] Duration { get; set; }
        public ushort Region { get; set; }
        public byte Looping { get; set; }
        [DBField(ArraySize: 10)]
        public byte[] CalendarFlags { get; set; }
        public byte Priority { get; set; }
        public byte CalendarFilterType { get; set; }
        public byte Flags { get; set; }
        public ushort HolidayNameID { get; set; }
        public byte Field06A { get; set; }
        [DBField(ArraySize: 3)]
        public int[] Field06B { get; set; }
    }

    [DBTable(24492)]
    public class ImportPriceArmor
    {
        [DBKey]
        public int ID { get; set; }
        public float ClothFactor { get; set; }
        public float LeatherFactor { get; set; }
        public float MailFactor { get; set; }
        public float PlateFactor { get; set; }
    }

    [DBTable(24492)]
    public class ImportPriceQuality
    {
        [DBKey]
        public int ID { get; set; }
        public float Factor { get; set; }
    }

    [DBTable(24492)]
    public class ImportPriceShield
    {
        [DBKey]
        public int ID { get; set; }
        public float Factor { get; set; }
    }

    [DBTable(24492)]
    public class ImportPriceWeapon
    {
        [DBKey]
        public int ID { get; set; }
        public float Factor { get; set; }
    }

    [DBTable(24492)]
    public class InvasionClientData
    {
        public string Field00 { get; set; }
        [DBField(ArraySize: 2)]
        public float[] Field04 { get; set; }
        [DBKey]
        public int ID { get; set; }
        public ushort Field0D { get; set; }
        public ushort Field0F { get; set; }
        public ushort Field11 { get; set; }
        public ushort Field13 { get; set; }
        public ushort Field15 { get; set; }
        public byte Field17 { get; set; }
        [DBField(ArraySize: 2)]
        public ushort[] Field18 { get; set; }
    }

    [DBTable(24492)]
    public class Item
    {
        [DBKey]
        public int ID { get; set; }
        public uint FileDataID { get; set; }
        public byte Class { get; set; }
        public byte SubClass { get; set; }
        public byte SoundOverrideSubclass { get; set; }
        public byte Material { get; set; }
        public byte InventoryType { get; set; }
        public byte Sheath { get; set; }
        public byte GroupSoundsID { get; set; }
    }

    [DBTable(24492)]
    public class ItemAppearance
    {
        [DBKey]
        public int ID { get; set; }
        public uint DisplayID { get; set; }
        public uint IconFileDataID { get; set; }
        public uint UIOrder { get; set; }
        public byte ObjectComponentSlot { get; set; }
    }

    [DBTable(24492)]
    public class ItemAppearanceXUiCamera
    {
        [DBKey]
        public int ID { get; set; }
        public ushort Field4 { get; set; }
        public ushort Field6 { get; set; }
    }

    [DBTable(24492)]
    public class ItemArmorQuality
    {
        [DBKey]
        public int ID { get; set; }
        [DBField(ArraySize: 7)]
        public float[] QualityMod { get; set; }
        public ushort ItemLevel { get; set; }
    }

    [DBTable(24492)]
    public class ItemArmorShield
    {
        [DBKey]
        public int ID { get; set; }
        [DBField(ArraySize: 7)]
        public float[] Quality { get; set; }
        public ushort ItemLevel { get; set; }
    }

    [DBTable(24492)]
    public class ItemArmorTotal
    {
        [DBKey]
        public int ID { get; set; }
        [DBField(ArraySize: 4)]
        public float[] Value { get; set; }
        public ushort ItemLevel { get; set; }
    }

    [DBTable(24492)]
    public class ItemBagFamily
    {
        [DBKey]
        public int ID { get; set; }
        public string Name { get; set; }
    }

    [DBTable(24492)]
    public class ItemBonus
    {
        [DBKey]
        public int ID { get; set; }
        [DBField(ArraySize: 2)]
        public int[] Value { get; set; }
        public ushort BonusListID { get; set; }
        public byte Type { get; set; }
        public byte Index { get; set; }
    }

    [DBTable(24492)]
    public class ItemBonusListLevelDelta
    {
        public ushort Delta { get; set; }
        [DBKey]
        public int ID { get; set; }
    }

    [DBTable(24492)]
    public class ItemBonusTreeNode
    {
        [DBKey]
        public int ID { get; set; }
        public ushort Field04 { get; set; }
        public ushort Field06 { get; set; }
        public ushort Field08 { get; set; }
        public byte Field0A { get; set; }
    }

    [DBTable(24492)]
    public class ItemChildEquipment
    {
        [DBKey]
        public int ID { get; set; }
        public uint ItemID { get; set; }
        public uint AltItemID { get; set; }
        public byte AltEquipmentSlot { get; set; }
    }

    [DBTable(24492)]
    public class ItemClass
    {
        [DBKey]
        public int ID { get; set; }
        public float PriceMod { get; set; }
        public string Name { get; set; }
        public byte Flags { get; set; }
    }

    [DBTable(24492)]
    public class ItemContextPickerEntry
    {
        [DBKey]
        public int ID { get; set; }
        public byte Field4 { get; set; }
        public byte Field5 { get; set; }
        public byte Field6 { get; set; }
        public byte Field7 { get; set; }
        public ushort Field8 { get; set; }
    }

    [DBTable(24492)]
    public class ItemCurrencyCost
    {
        [DBKey]
        public int ID { get; set; }
        public uint ItemId { get; set; }
    }

    [DBTable(24492)]
    public class ItemDamageAmmo
    {
        [DBKey]
        public int ID { get; set; }
        [DBField(ArraySize: 7)]
        public float[] DPS { get; set; }
        public ushort ItemLevel { get; set; }
    }

    [DBTable(24492)]
    public class ItemDamageOneHand
    {
        [DBKey]
        public int ID { get; set; }
        [DBField(ArraySize: 7)]
        public float[] DPS { get; set; }
        public ushort ItemLevel { get; set; }
    }

    [DBTable(24492)]
    public class ItemDamageOneHandCaster
    {
        [DBKey]
        public int ID { get; set; }
        [DBField(ArraySize: 7)]
        public float[] DPS { get; set; }
        public ushort ItemLevel { get; set; }
    }

    [DBTable(24492)]
    public class ItemDamageTwoHand
    {
        [DBKey]
        public int ID { get; set; }
        [DBField(ArraySize: 7)]
        public float[] DPS { get; set; }
        public ushort ItemLevel { get; set; }
    }

    [DBTable(24492)]
    public class ItemDamageTwoHandCaster
    {
        [DBKey]
        public int ID { get; set; }
        [DBField(ArraySize: 7)]
        public float[] DPS { get; set; }
        public ushort ItemLevel { get; set; }
    }

    [DBTable(24492)]
    public class ItemDisenchantLoot
    {
        [DBKey]
        public int ID { get; set; }
        public ushort MinItemLevel { get; set; }
        public ushort MaxItemLevel { get; set; }
        public ushort RequiredDisenchantSkill { get; set; }
        public byte ItemClass { get; set; }
        public byte ItemSubClass { get; set; }
        public byte ItemQuality { get; set; }
    }

    [DBTable(24492)]
    public class ItemDisplayInfo
    {
        [DBKey]
        public int ID { get; set; }
        [DBField(ArraySize: 2)]
        public ushort[] Field04 { get; set; }
        [DBField(ArraySize: 2)]
        public int[] Field08 { get; set; }
        [DBField(ArraySize: 3)]
        public byte[] Field0E { get; set; }
        [DBField(ArraySize: 3)]
        public byte[] Field11 { get; set; }
        public int Field14 { get; set; }
        public byte Field17 { get; set; }
        [DBField(ArraySize: 2)]
        public ushort[] Field18 { get; set; }
        public ushort Field1C { get; set; }
        public ushort Field1E { get; set; }
        public ushort Field20 { get; set; }
        public byte Field22 { get; set; }
        public byte Field23 { get; set; }
        public int Field24 { get; set; }
        public int Field27 { get; set; }
        public int Field2A { get; set; }
    }

    [DBTable(24492)]
    public class ItemDisplayInfoMaterialRes
    {
        [DBKey]
        public int ID { get; set; }
        public uint Field04 { get; set; }
        public uint Field08 { get; set; }
        public byte Field0C { get; set; }
    }

    [DBTable(24492)]
    public class ItemDisplayXUiCamera
    {
        [DBKey]
        public int ID { get; set; }
        public uint Field4 { get; set; }
        public ushort Field8 { get; set; }
    }

    [DBTable(24492)]
    public class ItemEffect
    {
        [DBKey]
        public int ID { get; set; }
        public uint ItemID { get; set; }
        public uint SpellID { get; set; }
        public int Cooldown { get; set; }
        public int CategoryCooldown { get; set; }
        public ushort Charges { get; set; }
        public ushort Category { get; set; }
        public ushort ChrSpecializationID { get; set; }
        public byte OrderIndex { get; set; }
        public byte Trigger { get; set; }
    }

    [DBTable(24492)]
    public class ItemExtendedCost
    {
        [DBKey]
        public int ID { get; set; }
        [DBField(ArraySize: 5)]
        public uint[] RequiredItem { get; set; }
        [DBField(ArraySize: 5)]
        public uint[] RequiredCurrencyCount { get; set; }
        [DBField(ArraySize: 5)]
        public ushort[] RequiredItemCount { get; set; }
        public ushort RequiredPersonalArenaRating { get; set; }
        [DBField(ArraySize: 5)]
        public ushort[] RequiredCurrency { get; set; }
        public byte RequiredArenaSlot { get; set; }
        public byte RequiredFactionId { get; set; }
        public byte RequiredFactionStanding { get; set; }
        public byte RequirementFlags { get; set; }
        public byte RequiredAchievement { get; set; }
    }

    [DBTable(24492)]
    public class ItemGroupSounds
    {
        [DBKey]
        public int ID { get; set; }
        [DBField(ArraySize: 2)]
        public ushort[] Field4 { get; set; }
    }

    [DBTable(24492)]
    public class ItemLevelSelector
    {
        [DBKey]
        public int ID { get; set; }
        public ushort Field00 { get; set; }
    }

    [DBTable(24492)]
    public class ItemLimitCategory
    {
        [DBKey]
        public int ID { get; set; }
        public string Name { get; set; }
        public byte Quantity { get; set; }
        public byte Flags { get; set; }
    }

    [DBTable(24492)]
    public class ItemLimitCategoryCondition
    {
        [DBKey]
        public int ID { get; set; }
        public byte Field4 { get; set; }
        public ushort Field5 { get; set; }
        public ushort Field7 { get; set; }
    }

    [DBTable(24492)]
    public class ItemModifiedAppearance
    {
        public uint ItemID { get; set; }
        public ushort AppearanceID { get; set; }
        public byte AppearanceModID { get; set; }
        public byte Index { get; set; }
        public byte SourceType { get; set; }
        [DBKey]
        public int ID { get; set; }
    }

    [DBTable(24492)]
    public class ItemModifiedAppearanceExtra
    {
        [DBKey]
        public int ID { get; set; }
        public uint Field04 { get; set; }
        public uint Field08 { get; set; }
        public byte Field0C { get; set; }
        public byte Field0D { get; set; }
        public byte Field0E { get; set; }
    }

    [DBTable(24492)]
    public class ItemNameDescription
    {
        [DBKey]
        public int ID { get; set; }
        public string Field4 { get; set; }
        public int Field8 { get; set; }
    }

    [DBTable(24492)]
    public class ItemPetFood
    {
        [DBKey]
        public int ID { get; set; }
        public string Field4 { get; set; }
    }

    [DBTable(24492)]
    public class ItemPriceBase
    {
        [DBKey]
        public int ID { get; set; }
        public float ArmorFactor { get; set; }
        public float WeaponFactor { get; set; }
        public ushort ItemLevel { get; set; }
    }

    [DBTable(24492)]
    public class ItemRandomProperties
    {
        [DBKey]
        public int ID { get; set; }
        public string Name { get; set; }
        [DBField(ArraySize: 5)]
        public ushort[] Enchantment { get; set; }
    }

    [DBTable(24492)]
    public class ItemRandomSuffix
    {
        [DBKey]
        public int ID { get; set; }
        public string Name { get; set; }
        [DBField(ArraySize: 5)]
        public ushort[] Enchantment { get; set; }
        [DBField(ArraySize: 5)]
        public ushort[] AllocationPct { get; set; }
    }

    [DBTable(24492)]
    public class ItemRangedDisplayInfo
    {
        [DBKey]
        public int ID { get; set; }
        public ushort Field4 { get; set; }
        public byte Field6 { get; set; }
        public ushort Field7 { get; set; }
        public ushort Field9 { get; set; }
    }

    [DBTable(24492)]
    public class ItemSearchName
    {
        [DBKey]
        public int ID { get; set; }
        public string Name { get; set; }
        [DBField(ArraySize: 3)]
        public uint[] Flags { get; set; }
        public uint AllowableRace { get; set; }
        public ushort RequiredSpell { get; set; }
        public byte Field1A { get; set; }
        public byte Field1B { get; set; }
        public byte Field1C { get; set; }
        public ushort Field1D { get; set; }
        public ushort Field1F { get; set; }
        public byte Field23 { get; set; }
        public ushort ItemLevel { get; set; }
        public ushort Quality { get; set; }
        public int Field2F { get; set; }
    }

    [DBTable(24492)]
    public class ItemSet
    {
        [DBKey]
        public int ID { get; set; }
        public string Name { get; set; }
        [DBField(ArraySize: 17)]
        public uint[] ItemID { get; set; }
        public ushort RequiredSkillRank { get; set; }
        public uint RequiredSkill { get; set; }
        public uint Flags { get; set; }
    }

    [DBTable(24492)]
    public class ItemSetSpell
    {
        [DBKey]
        public int ID { get; set; }
        public uint SpellID { get; set; }
        public ushort ItemSetID { get; set; }
        public ushort ChrSpecID { get; set; }
        public byte Threshold { get; set; }
    }

    [DBTable(24492)]
    public class Item_Sparse
    {
        [DBKey]
        public int ID { get; set; }
        [DBField(ArraySize: 3)]
        public int[] Field004 { get; set; }
        public float Field010 { get; set; }
        public uint Field014 { get; set; }
        public uint Field018 { get; set; }
        public uint Field01C { get; set; }
        public int Field020 { get; set; }
        public int Field024 { get; set; }
        public uint Field028 { get; set; }
        public uint Field02C { get; set; }
        public uint Field030 { get; set; }
        [DBField(ArraySize: 10)]
        public int[] Field034 { get; set; }
        [DBField(ArraySize: 10)]
        public float[] Field05C { get; set; }
        public float Field084 { get; set; }
        public uint Field088 { get; set; }
        public int Field08C { get; set; }
        public int Field090 { get; set; }
        public int Field094 { get; set; }
        public int Field098 { get; set; }
        public int Field09C { get; set; }
        public int Field0A0 { get; set; }
        public int Field0A4 { get; set; }
        public int Field0A8 { get; set; }
        public ushort Field0AC { get; set; }
        public ushort Field0AE { get; set; }
        public ushort Field0B0 { get; set; }
        public ushort Field0B2 { get; set; }
        [DBField(ArraySize: 10)]
        public ushort[] Field0B4 { get; set; }
        public ushort Field0C8 { get; set; }
        public ushort Field0CA { get; set; }
        public ushort Field0CC { get; set; }
        public ushort Field0CE { get; set; }
        public ushort Field0D0 { get; set; }
        public ushort Field0D2 { get; set; }
        public ushort Field0D4 { get; set; }
        public ushort Field0D6 { get; set; }
        public ushort Field0D8 { get; set; }
        public ushort Field0DA { get; set; }
        public ushort Field0DC { get; set; }
        public ushort Field0DE { get; set; }
        public ushort Field0E0 { get; set; }
        public ushort Field0E2 { get; set; }
        public ushort Field0E4 { get; set; }
        public byte Field0E6 { get; set; }
        public byte Field0E7 { get; set; }
        public byte Field0E8 { get; set; }
        public byte Field0E9 { get; set; }
        public byte Field0EA { get; set; }
        public byte Field0EB { get; set; }
        public byte Field0EC { get; set; }
        public byte Field0ED { get; set; }
        [DBField(ArraySize: 10)]
        public byte[] Field0EE { get; set; }
        public byte Field0F8 { get; set; }
        public byte Field0F9 { get; set; }
        public byte Field0FA { get; set; }
        public byte Field0FB { get; set; }
        public byte Field0FC { get; set; }
        public byte Field0FD { get; set; }
        public byte Field0FE { get; set; }
        [DBField(ArraySize: 3)]
        public byte[] Field0FF { get; set; }
        public byte Field102 { get; set; }
        public byte Field103 { get; set; }
        public byte Field104 { get; set; }
        public byte Field105 { get; set; }
    }

    [DBTable(24492)]
    public class ItemSpec
    {
        [DBKey]
        public int ID { get; set; }
        public ushort SpecID { get; set; }
        public byte MinLevel { get; set; }
        public byte MaxLevel { get; set; }
        public byte ItemType { get; set; }
        public byte PrimaryStat { get; set; }
        public byte SecondaryStat { get; set; }
    }

    [DBTable(24492)]
    public class ItemSpecOverride
    {
        [DBKey]
        public int ID { get; set; }
        public uint ItemID { get; set; }
        public ushort SpecID { get; set; }
    }

    [DBTable(24492)]
    public class ItemSubClass
    {
        [DBKey]
        public int ID { get; set; }
        public string Field04 { get; set; }
        public string Field08 { get; set; }
        public ushort Field0C { get; set; }
        public byte Field0E { get; set; }
        public byte Field0F { get; set; }
        public byte Field10 { get; set; }
        public byte Field11 { get; set; }
        public byte Field12 { get; set; }
        public byte Field13 { get; set; }
        public byte Field14 { get; set; }
    }

    [DBTable(24492)]
    public class ItemSubClassMask
    {
        [DBKey]
        public int ID { get; set; }
        public uint Field04 { get; set; }
        public string Field08 { get; set; }
        public byte Field0C { get; set; }
    }

    [DBTable(24492)]
    public class ItemUpgrade
    {
        [DBKey]
        public int ID { get; set; }
        public uint CurrencyCost { get; set; }
        public ushort PrevItemUpgradeID { get; set; }
        public ushort CurrencyID { get; set; }
        public byte ItemUpgradePathID { get; set; }
        public byte ItemLevelBonus { get; set; }
    }

    [DBTable(24492)]
    public class ItemVisualEffects
    {
        [DBKey]
        public int ID { get; set; }
        public string Field4 { get; set; }
    }

    [DBTable(24492)]
    public class ItemVisuals
    {
        [DBKey]
        public int ID { get; set; }
        [DBField(ArraySize: 3)]
        public ushort[] Field4 { get; set; }
    }

    [DBTable(24492)]
    public class ItemXBonusTree
    {
        [DBKey]
        public int ID { get; set; }
        public uint ItemID { get; set; }
        public ushort BonusTreeID { get; set; }
    }

    [DBTable(24492)]
    public class JournalEncounter
    {
        [DBKey]
        public int ID { get; set; }
        [DBField(ArraySize: 2)]
        public float[] Field04 { get; set; }
        public string Field0C { get; set; }
        public string Field10 { get; set; }
        public ushort Field14 { get; set; }
        public ushort Field16 { get; set; }
        public ushort Field18 { get; set; }
        public ushort Field1A { get; set; }
        public byte Field1C { get; set; }
        public byte Field1D { get; set; }
        public byte Field1E { get; set; }
    }

    [DBTable(24492)]
    public class JournalEncounterCreature
    {
        public uint Field00 { get; set; }
        public uint Field04 { get; set; }
        public string Field08 { get; set; }
        public string Field0C { get; set; }
        public ushort Field10 { get; set; }
        public byte Field12 { get; set; }
        [DBKey]
        [DBField(ArraySize: 2)]
        public int[] ID { get; set; }
    }

    [DBTable(24492)]
    public class JournalEncounterItem
    {
        public uint Field0 { get; set; }
        public ushort Field4 { get; set; }
        public byte Field6 { get; set; }
        public byte Field7 { get; set; }
        public byte Field8 { get; set; }
        [DBKey]
        public int ID { get; set; }
    }

    [DBTable(24492)]
    public class JournalEncounterSection
    {
        [DBKey]
        public int ID { get; set; }
        public string Field04 { get; set; }
        public string Field08 { get; set; }
        public uint Field0C { get; set; }
        public uint Field10 { get; set; }
        public uint Field14 { get; set; }
        public ushort Field18 { get; set; }
        public ushort Field1A { get; set; }
        public ushort Field1C { get; set; }
        public ushort Field1E { get; set; }
        public ushort Field20 { get; set; }
        public ushort Field22 { get; set; }
        public byte Field24 { get; set; }
        public byte Field25 { get; set; }
        public byte Field26 { get; set; }
    }

    [DBTable(24492)]
    public class JournalEncounterXDifficulty
    {
        [DBKey]
        public int ID { get; set; }
        public ushort Field4 { get; set; }
        public byte Field6 { get; set; }
    }

    [DBTable(24492)]
    public class JournalInstance
    {
        public uint Field00 { get; set; }
        public uint Field04 { get; set; }
        public uint Field08 { get; set; }
        public uint Field0C { get; set; }
        public string Field10 { get; set; }
        public string Field14 { get; set; }
        public ushort Field18 { get; set; }
        public ushort Field1A { get; set; }
        public byte Field1C { get; set; }
        public byte Field1D { get; set; }
        [DBKey]
        public int ID { get; set; }
    }

    [DBTable(24492)]
    public class JournalItemXDifficulty
    {
        [DBKey]
        public int ID { get; set; }
        public ushort Field4 { get; set; }
        public byte Field6 { get; set; }
    }

    [DBTable(24492)]
    public class JournalSectionXDifficulty
    {
        [DBKey]
        public int ID { get; set; }
        public ushort Field4 { get; set; }
        public byte Field6 { get; set; }
    }

    [DBTable(24492)]
    public class JournalTier
    {
        [DBKey]
        public int ID { get; set; }
        public string Field4 { get; set; }
    }

    [DBTable(24492)]
    public class JournalTierXInstance
    {
        [DBKey]
        public int ID { get; set; }
        public ushort Field4 { get; set; }
        public ushort Field6 { get; set; }
    }

    [DBTable(24492)]
    public class KeyChain
    {
        [DBKey]
        public int ID { get; set; }
        [DBField(ArraySize: 32)]
        public byte[] Key { get; set; }
    }

    [DBTable(24492)]
    public class KeystoneAffix
    {
        [DBKey]
        public int ID { get; set; }
        public string Field04 { get; set; }
        public string Field08 { get; set; }
        public uint Field0C { get; set; }
    }

    [DBTable(24492)]
    public class Languages
    {
        public string Field0 { get; set; }
        [DBKey]
        [DBField(ArraySize: 4)]
        public int[] ID { get; set; }
    }

    [DBTable(24492)]
    public class LanguageWords
    {
        [DBKey]
        public int ID { get; set; }
        public string Field4 { get; set; }
        public byte Field8 { get; set; }
    }

    [DBTable(24492)]
    public class LfgDungeonExpansion
    {
        [DBKey]
        public int ID { get; set; }
        public ushort Field04 { get; set; }
        public ushort Field06 { get; set; }
        public byte Field08 { get; set; }
        public byte Field09 { get; set; }
        public byte Field0A { get; set; }
        public byte Field0B { get; set; }
        public byte Field0C { get; set; }
    }

    [DBTable(24492)]
    public class LfgDungeonGroup
    {
        [DBKey]
        public int ID { get; set; }
        public string Field04 { get; set; }
        public ushort Field08 { get; set; }
        public byte Field0A { get; set; }
        public byte Field0B { get; set; }
    }

    [DBTable(24492)]
    public class LfgDungeons
    {
        public string Field00 { get; set; }
        public uint Field04 { get; set; }
        public string Field08 { get; set; }
        public string Field0C { get; set; }
        public uint Field10 { get; set; }
        public ushort Field14 { get; set; }
        public ushort Field16 { get; set; }
        public ushort Field18 { get; set; }
        public ushort Field1A { get; set; }
        public ushort Field1C { get; set; }
        public ushort Field1E { get; set; }
        public ushort Field20 { get; set; }
        public ushort Field22 { get; set; }
        public byte Field24 { get; set; }
        public byte Field25 { get; set; }
        public byte Field26 { get; set; }
        public byte Field27 { get; set; }
        public byte Field28 { get; set; }
        public byte Field29 { get; set; }
        public byte Field2A { get; set; }
        public byte Field2B { get; set; }
        public byte Field2C { get; set; }
        public byte Field2D { get; set; }
        public byte Field2E { get; set; }
        public byte Field2F { get; set; }
        public byte Field30 { get; set; }
        public byte Field31 { get; set; }
        public byte Field32 { get; set; }
        public byte Field33 { get; set; }
        public byte Field34 { get; set; }
        [DBKey]
        public int ID { get; set; }
    }

    [DBTable(24492)]
    public class LfgDungeonsGroupingMap
    {
        [DBKey]
        public int ID { get; set; }
        public ushort Field4 { get; set; }
        public ushort Field6 { get; set; }
        public byte Field8 { get; set; }
    }

    [DBTable(24492)]
    public class LfgRoleRequirement
    {
        [DBKey]
        public int ID { get; set; }
        public ushort Field4 { get; set; }
        public byte Field6 { get; set; }
        public ushort Field7 { get; set; }
    }

    [DBTable(24492)]
    public class Light
    {
        [DBKey]
        public int ID { get; set; }
        [DBField(ArraySize: 3)]
        public float[] Pos { get; set; }
        public float FalloffStart { get; set; }
        public float FalloffEnd { get; set; }
        public ushort MapID { get; set; }
        [DBField(ArraySize: 8)]
        public ushort[] LightParamsID { get; set; }
    }

    [DBTable(24492)]
    public class LightData
    {
        [DBKey]
        public int ID { get; set; }
        public int Field004 { get; set; }
        public int Field008 { get; set; }
        public int Field00C { get; set; }
        public int Field010 { get; set; }
        public int Field014 { get; set; }
        public int Field018 { get; set; }
        public int Field01C { get; set; }
        public int Field020 { get; set; }
        public int Field024 { get; set; }
        public int Field028 { get; set; }
        public int Field02C { get; set; }
        public int Field030 { get; set; }
        public int Field034 { get; set; }
        public int Field038 { get; set; }
        public int Field03C { get; set; }
        public int Field040 { get; set; }
        public int Field044 { get; set; }
        public int Field048 { get; set; }
        public uint Field04C { get; set; }
        public int Field050 { get; set; }
        public float Field054 { get; set; }
        public float Field058 { get; set; }
        public int Field05C { get; set; }
        public float Field060 { get; set; }
        public float Field064 { get; set; }
        public float Field068 { get; set; }
        public float Field06C { get; set; }
        public uint Field070 { get; set; }
        public uint Field074 { get; set; }
        public uint Field078 { get; set; }
        public uint Field07C { get; set; }
        public uint Field080 { get; set; }
        public uint Field084 { get; set; }
        public ushort Field088 { get; set; }
        public ushort Field08A { get; set; }
    }

    [DBTable(24492)]
    public class LightParams
    {
        public float Field00 { get; set; }
        public float Field04 { get; set; }
        public float Field08 { get; set; }
        public float Field0C { get; set; }
        public float Field10 { get; set; }
        [DBField(ArraySize: 3)]
        public int[] Field14 { get; set; }
        public ushort Field20 { get; set; }
        public byte Field22 { get; set; }
        public byte Field23 { get; set; }
        public byte Field24 { get; set; }
        [DBKey]
        public int ID { get; set; }
    }

    [DBTable(24492)]
    public class LightSkybox
    {
        [DBKey]
        public int ID { get; set; }
        public string Field4 { get; set; }
        public byte Field8 { get; set; }
    }

    [DBTable(24492)]
    public class LiquidMaterial
    {
        [DBKey]
        public int ID { get; set; }
        public byte Field4 { get; set; }
        public byte Field5 { get; set; }
    }

    [DBTable(24492)]
    public class LiquidObject
    {
        [DBKey]
        public int ID { get; set; }
        public float Field04 { get; set; }
        public float Field08 { get; set; }
        public ushort Field0C { get; set; }
        public byte Field0E { get; set; }
        public byte Field0F { get; set; }
    }

    [DBTable(24492)]
    public class LiquidType
    {
        [DBKey]
        public int ID { get; set; }
        public string Name { get; set; }
        public uint SpellID { get; set; }
        public float MaxDarkenDepth { get; set; }
        public float FogDarkenIntensity { get; set; }
        public float AmbDarkenIntensity { get; set; }
        public float DirDarkenIntensity { get; set; }
        public float ParticleScale { get; set; }
        [DBField(ArraySize: 6)]
        public string[] Texture { get; set; }
        [DBField(ArraySize: 2)]
        public uint[] Color { get; set; }
        [DBField(ArraySize: 18)]
        public float[] Float { get; set; }
        [DBField(ArraySize: 4)]
        public uint[] Int { get; set; }
        public ushort Flags { get; set; }
        public ushort LightID { get; set; }
        public byte Type { get; set; }
        public byte ParticleMovement { get; set; }
        public byte ParticleTexSlots { get; set; }
        public byte MaterialID { get; set; }
        [DBField(ArraySize: 6)]
        public byte[] DepthTexCount { get; set; }
        public uint SoundID { get; set; }
    }

    [DBTable(24492)]
    public class LoadingScreens
    {
        [DBKey]
        public int ID { get; set; }
        public uint Field04 { get; set; }
        public uint Field08 { get; set; }
        public uint Field0C { get; set; }
    }

    [DBTable(24492)]
    public class LoadingScreenTaxiSplines
    {
        [DBKey]
        public int ID { get; set; }
        [DBField(ArraySize: 10)]
        public float[] Field04 { get; set; }
        [DBField(ArraySize: 10)]
        public float[] Field2C { get; set; }
        public ushort Field54 { get; set; }
        public ushort Field56 { get; set; }
        public byte Field58 { get; set; }
    }

    [DBTable(24492)]
    public class Locale
    {
        [DBKey]
        public int ID { get; set; }
        public uint Field04 { get; set; }
        public byte Field08 { get; set; }
        public byte Field09 { get; set; }
        public byte Field0A { get; set; }
    }

    [DBTable(24492)]
    public class Location
    {
        [DBKey]
        public int ID { get; set; }
        [DBField(ArraySize: 3)]
        public int[] Field04 { get; set; }
        [DBField(ArraySize: 2)]
        public int[] Field10 { get; set; }
    }

    [DBTable(24492)]
    public class Lock
    {
        [DBKey]
        public int ID { get; set; }
        [DBField(ArraySize: 8)]
        public uint[] Index { get; set; }
        [DBField(ArraySize: 8)]
        public ushort[] Skill { get; set; }
        [DBField(ArraySize: 8)]
        public byte[] Type { get; set; }
        [DBField(ArraySize: 8)]
        public byte[] Action { get; set; }
    }

    [DBTable(24492)]
    public class LockType
    {
        public string Field00 { get; set; }
        public string Field04 { get; set; }
        public string Field08 { get; set; }
        public string Field0C { get; set; }
        [DBKey]
        [DBField(ArraySize: 4)]
        public int[] ID { get; set; }
    }

    [DBTable(24492)]
    public class LookAtController
    {
        [DBKey]
        public int ID { get; set; }
        public float Field04 { get; set; }
        public float Field08 { get; set; }
        public float Field0C { get; set; }
        public float Field10 { get; set; }
        public ushort Field14 { get; set; }
        public ushort Field16 { get; set; }
        public ushort Field18 { get; set; }
        public ushort Field1A { get; set; }
        public byte Field1C { get; set; }
        public byte Field1D { get; set; }
        public byte Field1E { get; set; }
        public byte Field1F { get; set; }
        public byte Field20 { get; set; }
        public byte Field21 { get; set; }
        public ushort Field22 { get; set; }
        public ushort Field24 { get; set; }
        public byte Field26 { get; set; }
        public byte Field27 { get; set; }
    }

    [DBTable(24492)]
    public class MailTemplate
    {
        [DBKey]
        public int ID { get; set; }
        public string Body { get; set; }
    }

    [DBTable(24492)]
    public class ManagedWorldState
    {
        [DBKey]
        public int ID { get; set; }
        public int Field04 { get; set; }
        public int Field08 { get; set; }
        public int Field0C { get; set; }
        public int Field10 { get; set; }
        public int Field14 { get; set; }
        public int Field18 { get; set; }
        public int Field1C { get; set; }
        public int Field20 { get; set; }
    }

    [DBTable(24492)]
    public class ManagedWorldStateBuff
    {
        [DBKey]
        public int ID { get; set; }
        public int Field04 { get; set; }
        public int Field08 { get; set; }
        public int Field0C { get; set; }
        public int Field10 { get; set; }
    }

    [DBTable(24492)]
    public class ManagedWorldStateInput
    {
        [DBKey]
        public int ID { get; set; }
        public int Field04 { get; set; }
        public int Field08 { get; set; }
    }

    [DBTable(24492)]
    public class ManifestInterfaceActionIcon
    {
        [DBKey]
        public int ID { get; set; }
    }

    [DBTable(24492)]
    public class ManifestInterfaceData
    {
        [DBKey]
        public int ID { get; set; }
        public string Field4 { get; set; }
        public string Field8 { get; set; }
    }

    [DBTable(24492)]
    public class ManifestInterfaceItemIcon
    {
        [DBKey]
        public int ID { get; set; }
    }

    [DBTable(24492)]
    public class ManifestInterfaceTOCData
    {
        [DBKey]
        public int ID { get; set; }
        public string Field4 { get; set; }
    }

    [DBTable(24492)]
    public class ManifestMP3
    {
        [DBKey]
        public int ID { get; set; }
    }

    [DBTable(24492)]
    public class Map
    {
        [DBKey]
        public int ID { get; set; }
        public string Field04 { get; set; }
        [DBField(ArraySize: 2)]
        public int[] Field08 { get; set; }
        public float Field10 { get; set; }
        [DBField(ArraySize: 2)]
        public int[] Field14 { get; set; }
        public string Field1C { get; set; }
        public string Field20 { get; set; }
        public string Field24 { get; set; }
        public ushort Field28 { get; set; }
        public ushort Field2A { get; set; }
        public ushort Field2C { get; set; }
        public ushort Field2E { get; set; }
        public ushort Field30 { get; set; }
        public ushort Field32 { get; set; }
        public ushort Field34 { get; set; }
        public byte Field36 { get; set; }
        public byte Field37 { get; set; }
        public byte Field38 { get; set; }
        public byte Field39 { get; set; }
        public byte Field3A { get; set; }
    }

    [DBTable(24492)]
    public class MapCelestialBody
    {
        [DBKey]
        public int ID { get; set; }
        public ushort Field00 { get; set; }
        public ushort Field02 { get; set; }
        public int Field04 { get; set; }
    }

    [DBTable(24492)]
    public class MapChallengeMode
    {
        [DBKey]
        public int ID { get; set; }
        public ushort Field04 { get; set; }
        [DBField(ArraySize: 3)]
        public ushort[] Field06 { get; set; }
        public byte Field0C { get; set; }
    }

    [DBTable(24492)]
    public class MapDifficulty
    {
        [DBKey]
        public int ID { get; set; }
        public string Message_lang { get; set; }
        public ushort MapID { get; set; }
        public byte DifficultyID { get; set; }
        public byte RaidDurationType { get; set; }
        public byte MaxPlayers { get; set; }
        public byte LockID { get; set; }
        public byte ItemBonusTreeModID { get; set; }
        public int Context { get; set; }
    }

    [DBTable(24492)]
    public class MapDifficultyXCondition
    {
        [DBKey]
        public int ID { get; set; }
        public string Field04 { get; set; }
        public ushort Field08 { get; set; }
        public ushort Field0A { get; set; }
        public byte Field0C { get; set; }
    }

    [DBTable(24492)]
    public class MarketingPromotionsXLocale
    {
        [DBKey]
        public int ID { get; set; }
        public uint Field04 { get; set; }
        public uint Field08 { get; set; }
        public uint Field0C { get; set; }
        public uint Field10 { get; set; }
        public string Field14 { get; set; }
        public byte Field18 { get; set; }
        public byte Field19 { get; set; }
    }

    [DBTable(24492)]
    public class Material
    {
        [DBKey]
        public int ID { get; set; }
        public byte Field4 { get; set; }
        public ushort Field5 { get; set; }
        public ushort Field7 { get; set; }
        public ushort Field9 { get; set; }
    }

    [DBTable(24492)]
    public class MinorTalent
    {
        [DBKey]
        public int ID { get; set; }
        public uint Field04 { get; set; }
        public ushort Field08 { get; set; }
        public byte Field0A { get; set; }
    }

    [DBTable(24492)]
    public class ModelAnimCloakDampening
    {
        [DBKey]
        public int ID { get; set; }
        public int Field4 { get; set; }
        public byte Field7 { get; set; }
        public byte Field8 { get; set; }
    }

    [DBTable(24492)]
    public class ModelFileData
    {
        public byte Field0 { get; set; }
        [DBKey]
        public int ID { get; set; }
        public ushort Field4 { get; set; }
    }

    [DBTable(24492)]
    public class ModelRibbonQuality
    {
        [DBKey]
        public int ID { get; set; }
        public uint Field4 { get; set; }
        public byte Field8 { get; set; }
    }

    [DBTable(24492)]
    public class ModifierTree
    {
        [DBKey]
        public int ID { get; set; }
        [DBField(ArraySize: 2)]
        public uint[] Asset { get; set; }
        public ushort Parent { get; set; }
        public byte Type { get; set; }
        public byte Unk700 { get; set; }
        public byte Operator { get; set; }
        public byte Amount { get; set; }
    }

    [DBTable(24492)]
    public class Mount
    {
        public uint Field00 { get; set; }
        public uint Field04 { get; set; }
        public string Field08 { get; set; }
        public string Field0C { get; set; }
        public string Field10 { get; set; }
        public float Field14 { get; set; }
        public ushort Field18 { get; set; }
        public ushort Field1A { get; set; }
        public ushort Field1C { get; set; }
        public byte Field1E { get; set; }
        [DBKey]
        public int ID { get; set; }
        public int Field2A { get; set; }
    }

    [DBTable(24492)]
    public class MountCapability
    {
        public uint RequiredSpell { get; set; }
        public uint SpeedModSpell { get; set; }
        public ushort RequiredRidingSkill { get; set; }
        public ushort RequiredArea { get; set; }
        public ushort RequiredMap { get; set; }
        public byte Flags { get; set; }
        [DBKey]
        public int ID { get; set; }
        public uint RequiredAura { get; set; }
    }

    [DBTable(24492)]
    public class MountTypeXCapability
    {
        [DBKey]
        public int ID { get; set; }
        public ushort MountTypeID { get; set; }
        public ushort MountCapabilityID { get; set; }
        public byte OrderIndex { get; set; }
    }

    [DBTable(24492)]
    public class MountXDisplay
    {
        [DBKey]
        public int ID { get; set; }
        public uint MountID { get; set; }
        public uint DisplayID { get; set; }
        public uint PlayerConditionID { get; set; }
    }

    [DBTable(24492)]
    public class Movie
    {
        [DBKey]
        public int ID { get; set; }
        public uint AudioFileDataID { get; set; }
        public uint SubtitleFileDataID { get; set; }
        public byte Volume { get; set; }
        public byte KeyID { get; set; }
    }

    [DBTable(24492)]
    public class MovieFileData
    {
        [DBKey]
        public int ID { get; set; }
        public ushort Field4 { get; set; }
    }

    [DBTable(24492)]
    public class MovieVariation
    {
        [DBKey]
        public int ID { get; set; }
        public uint Field04 { get; set; }
        public ushort Field08 { get; set; }
        public byte Field0A { get; set; }
    }

    [DBTable(24492)]
    public class NameGen
    {
        [DBKey]
        public int ID { get; set; }
        public string Name { get; set; }
        public byte Race { get; set; }
        public byte Sex { get; set; }
    }

    [DBTable(24492)]
    public class NamesProfanity
    {
        [DBKey]
        public int ID { get; set; }
        public string Name { get; set; }
        public byte Language { get; set; }
    }

    [DBTable(24492)]
    public class NamesReserved
    {
        [DBKey]
        public int ID { get; set; }
        public string Name { get; set; }
    }

    [DBTable(24492)]
    public class NamesReservedLocale
    {
        [DBKey]
        public int ID { get; set; }
        public string Name { get; set; }
        public byte LocaleMask { get; set; }
    }

    [DBTable(24492)]
    public class NpcModelItemSlotDisplayInfo
    {
        [DBKey]
        public int ID { get; set; }
        public uint Field04 { get; set; }
        public uint Field08 { get; set; }
        public byte Field0C { get; set; }
    }

    [DBTable(24492)]
    public class NPCSounds
    {
        [DBKey]
        public int ID { get; set; }
        [DBField(ArraySize: 2)]
        public int[] Field4 { get; set; }
    }

    [DBTable(24492)]
    public class ObjectEffect
    {
        [DBKey]
        public int ID { get; set; }
        [DBField(ArraySize: 3)]
        public int[] Field04 { get; set; }
        public ushort Field10 { get; set; }
        public byte Field12 { get; set; }
        public byte Field13 { get; set; }
        public byte Field14 { get; set; }
        public byte Field15 { get; set; }
        public int Field16 { get; set; }
        public ushort Field19 { get; set; }
    }

    [DBTable(24492)]
    public class ObjectEffectGroup
    {
        [DBKey]
        public int ID { get; set; }
        public string Field4 { get; set; }
    }

    [DBTable(24492)]
    public class ObjectEffectModifier
    {
        [DBKey]
        public int ID { get; set; }
        [DBField(ArraySize: 4)]
        public float[] Field04 { get; set; }
        public byte Field14 { get; set; }
        public byte Field15 { get; set; }
        public byte Field16 { get; set; }
    }

    [DBTable(24492)]
    public class ObjectEffectPackage
    {
        [DBKey]
        public int ID { get; set; }
        public string Field4 { get; set; }
    }

    [DBTable(24492)]
    public class ObjectEffectPackageElem
    {
        [DBKey]
        public int ID { get; set; }
        public ushort Field4 { get; set; }
        public ushort Field6 { get; set; }
        public ushort Field8 { get; set; }
    }

    [DBTable(24492)]
    public class OutlineEffect
    {
        [DBKey]
        public int ID { get; set; }
        public float Field04 { get; set; }
        public ushort Field08 { get; set; }
        public byte Field0A { get; set; }
        public byte Field0B { get; set; }
        public byte Field0C { get; set; }
        public byte Field0D { get; set; }
    }

    [DBTable(24492)]
    public class OverrideSpellData
    {
        [DBKey]
        public int ID { get; set; }
        [DBField(ArraySize: 10)]
        public uint[] SpellID { get; set; }
        public uint PlayerActionbarFileDataID { get; set; }
        public byte Flags { get; set; }
    }

    [DBTable(24492)]
    public class PageTextMaterial
    {
        [DBKey]
        public int ID { get; set; }
        public string Field4 { get; set; }
    }

    [DBTable(24492)]
    public class PaperDollItemFrame
    {
        [DBKey]
        public int ID { get; set; }
        public string Field04 { get; set; }
        public string Field08 { get; set; }
        public byte Field0C { get; set; }
    }

    [DBTable(24492)]
    public class ParagonReputation
    {
        [DBKey]
        public int ID { get; set; }
        public int Field00 { get; set; }
        public int Field04 { get; set; }
        public int Field08 { get; set; }
    }

    [DBTable(24492)]
    public class ParticleColor
    {
        [DBKey]
        public int ID { get; set; }
        [DBField(ArraySize: 3)]
        public int[] Field04 { get; set; }
        [DBField(ArraySize: 3)]
        public int[] Field10 { get; set; }
        [DBField(ArraySize: 2)]
        public int[] Field1C { get; set; }
    }

    [DBTable(24492)]
    public class Path
    {
        [DBKey]
        public int ID { get; set; }
        public byte Field04 { get; set; }
        public byte Field05 { get; set; }
        public byte Field06 { get; set; }
        public byte Field07 { get; set; }
        public byte Field08 { get; set; }
        public byte Field09 { get; set; }
        public byte Field0A { get; set; }
    }

    [DBTable(24492)]
    public class PathNode
    {
        [DBKey]
        public int ID { get; set; }
        public uint Field04 { get; set; }
        public ushort Field08 { get; set; }
        public ushort Field0A { get; set; }
    }

    [DBTable(24492)]
    public class PathNodeProperty
    {
        public ushort Field0 { get; set; }
        public ushort Field2 { get; set; }
        public byte Field4 { get; set; }
        [DBKey]
        public int ID { get; set; }
        public int Field8 { get; set; }
    }

    [DBTable(24492)]
    public class PathProperty
    {
        public uint Field0 { get; set; }
        public ushort Field4 { get; set; }
        public byte Field6 { get; set; }
        [DBKey]
        [DBField(ArraySize: 2)]
        public int[] ID { get; set; }
    }

    [DBTable(24492)]
    public class Phase
    {
        [DBKey]
        public int ID { get; set; }
        public ushort Flags { get; set; }
    }

    [DBTable(24492)]
    public class PhaseShiftZoneSounds
    {
        [DBKey]
        public int ID { get; set; }
        public ushort Field04 { get; set; }
        public ushort Field06 { get; set; }
        public ushort Field08 { get; set; }
        public ushort Field0A { get; set; }
        public ushort Field0C { get; set; }
        public byte Field0E { get; set; }
        public byte Field0F { get; set; }
        public byte Field10 { get; set; }
        public byte Field11 { get; set; }
        public ushort Field12 { get; set; }
        public ushort Field14 { get; set; }
        public byte Field16 { get; set; }
        public byte Field17 { get; set; }
    }

    [DBTable(24492)]
    public class PhaseXPhaseGroup
    {
        [DBKey]
        public int ID { get; set; }
        public ushort PhaseID { get; set; }
        public ushort PhaseGroupID { get; set; }
    }

    [DBTable(24492)]
    public class PlayerCondition
    {
        [DBKey]
        public int ID { get; set; }
        public uint RaceMask { get; set; }
        public uint SkillLogic { get; set; }
        public uint ReputationLogic { get; set; }
        public uint PrevQuestLogic { get; set; }
        public uint CurrQuestLogic { get; set; }
        public uint CurrentCompletedQuestLogic { get; set; }
        public uint SpellLogic { get; set; }
        public uint ItemLogic { get; set; }
        [DBField(ArraySize: 2)]
        public uint[] Time { get; set; }
        public uint AuraSpellLogic { get; set; }
        [DBField(ArraySize: 4)]
        public uint[] AuraSpellID { get; set; }
        public uint AchievementLogic { get; set; }
        public uint AreaLogic { get; set; }
        public uint QuestKillLogic { get; set; }
        public string FailureDescription { get; set; }
        public ushort MinLevel { get; set; }
        public ushort MaxLevel { get; set; }
        [DBField(ArraySize: 4)]
        public ushort[] SkillID { get; set; }
        [DBField(ArraySize: 4)]
        public ushort[] MinSkill { get; set; }
        [DBField(ArraySize: 4)]
        public ushort[] MaxSkill { get; set; }
        public ushort MaxFactionID { get; set; }
        [DBField(ArraySize: 4)]
        public ushort[] PrevQuestID { get; set; }
        [DBField(ArraySize: 4)]
        public ushort[] CurrQuestID { get; set; }
        [DBField(ArraySize: 4)]
        public ushort[] CurrentCompletedQuestID { get; set; }
        [DBField(ArraySize: 2)]
        public ushort[] Explored { get; set; }
        public ushort WorldStateExpressionID { get; set; }
        [DBField(ArraySize: 4)]
        public ushort[] Achievement { get; set; }
        [DBField(ArraySize: 4)]
        public ushort[] AreaID { get; set; }
        public ushort QuestKillID { get; set; }
        public ushort PhaseID { get; set; }
        public ushort MinAvgEquippedItemLevel { get; set; }
        public ushort MaxAvgEquippedItemLevel { get; set; }
        public ushort ModifierTreeID { get; set; }
        public byte Flags { get; set; }
        public byte Gender { get; set; }
        public byte NativeGender { get; set; }
        public byte MinLanguage { get; set; }
        public byte MaxLanguage { get; set; }
        [DBField(ArraySize: 3)]
        public byte[] MinReputation { get; set; }
        public byte MaxReputation { get; set; }
        public byte Field0AF { get; set; }
        public byte MinPVPRank { get; set; }
        public byte MaxPVPRank { get; set; }
        public byte PvpMedal { get; set; }
        public byte ItemFlags { get; set; }
        [DBField(ArraySize: 4)]
        public byte[] AuraCount { get; set; }
        public byte WeatherID { get; set; }
        public byte PartyStatus { get; set; }
        public byte LifetimeMaxPVPRank { get; set; }
        [DBField(ArraySize: 4)]
        public byte[] LfgStatus { get; set; }
        [DBField(ArraySize: 4)]
        public byte[] LfgCompare { get; set; }
        [DBField(ArraySize: 4)]
        public byte[] CurrencyCount { get; set; }
        public byte MinExpansionLevel { get; set; }
        public byte MaxExpansionLevel { get; set; }
        public byte MinExpansionTier { get; set; }
        public byte MaxExpansionTier { get; set; }
        public byte MinGuildLevel { get; set; }
        public byte MaxGuildLevel { get; set; }
        public byte PhaseUseFlags { get; set; }
        public byte ChrSpecializationIndex { get; set; }
        public byte ChrSpecializationRole { get; set; }
        public byte PowerType { get; set; }
        public byte PowerTypeComp { get; set; }
        public byte PowerTypeValue { get; set; }
        public int ClassMask { get; set; }
        public uint LanguageID { get; set; }
        [DBField(ArraySize: 3)]
        public ushort[] MinFactionID { get; set; }
        [DBField(ArraySize: 4)]
        public int[] SpellID { get; set; }
        [DBField(ArraySize: 4)]
        public int[] ItemID { get; set; }
        [DBField(ArraySize: 4)]
        public byte[] ItemCount { get; set; }
        public byte LfgLogic { get; set; }
        [DBField(ArraySize: 4)]
        public byte[] LfgValue { get; set; }
        public int CurrencyLogic { get; set; }
        [DBField(ArraySize: 4)]
        public ushort[] CurrencyID { get; set; }
        [DBField(ArraySize: 6)]
        public int[] QuestKillMonster { get; set; }
        public byte PhaseGroupID { get; set; }
        public ushort MinAvgItemLevel { get; set; }
        public ushort MaxAvgItemLevel { get; set; }
        public byte MainHandItemSubclassMask { get; set; }
    }

    [DBTable(24492)]
    public class Positioner
    {
        [DBKey]
        public int ID { get; set; }
        public float Field04 { get; set; }
        public ushort Field08 { get; set; }
        public byte Field0A { get; set; }
        public byte Field0B { get; set; }
    }

    [DBTable(24492)]
    public class PositionerState
    {
        [DBKey]
        public int ID { get; set; }
        public float Field04 { get; set; }
        public byte Field08 { get; set; }
        public ushort Field09 { get; set; }
        public byte Field0B { get; set; }
        public ushort Field0C { get; set; }
        public ushort Field0E { get; set; }
        public ushort Field10 { get; set; }
        public ushort Field12 { get; set; }
    }

    [DBTable(24492)]
    public class PositionerStateEntry
    {
        [DBKey]
        public int ID { get; set; }
        public float Field04 { get; set; }
        public float Field08 { get; set; }
        public byte Field0C { get; set; }
        public byte Field0D { get; set; }
        public byte Field0E { get; set; }
        public byte Field0F { get; set; }
        public byte Field10 { get; set; }
        public byte Field11 { get; set; }
        public byte Field12 { get; set; }
        public byte Field13 { get; set; }
        public ushort Field14 { get; set; }
    }

    [DBTable(24492)]
    public class PowerDisplay
    {
        [DBKey]
        public int ID { get; set; }
        public string GlobalStringBaseTag { get; set; }
        public byte PowerType { get; set; }
        public byte Red { get; set; }
        public byte Green { get; set; }
        public byte Blue { get; set; }
    }

    [DBTable(24492)]
    public class PowerType
    {
        [DBKey]
        public int ID { get; set; }
        public string PowerTypeToken { get; set; }
        public string PowerCostToken { get; set; }
        public float RegenerationPeace { get; set; }
        public float RegenerationCombat { get; set; }
        public ushort MaxPower { get; set; }
        public ushort RegenerationDelay { get; set; }
        public ushort Flags { get; set; }
        public byte PowerTypeEnum { get; set; }
        public byte RegenerationMin { get; set; }
        public byte RegenerationCenter { get; set; }
        public byte RegenerationMax { get; set; }
        public byte UIModifier { get; set; }
    }

    [DBTable(24492)]
    public class PrestigeLevelInfo
    {
        [DBKey]
        public int ID { get; set; }
        public uint Field04 { get; set; }
        public string Field08 { get; set; }
        public byte Field0C { get; set; }
        public byte Field0D { get; set; }
    }

    [DBTable(24492)]
    public class PvpBracketTypes
    {
        [DBKey]
        public int ID { get; set; }
        public byte Field4 { get; set; }
        [DBField(ArraySize: 2)]
        public ushort[] Field5 { get; set; }
    }

    [DBTable(24492)]
    public class PvpDifficulty
    {
        [DBKey]
        public int ID { get; set; }
        public ushort MapID { get; set; }
        public byte BracketID { get; set; }
        public byte MinLevel { get; set; }
        public byte MaxLevel { get; set; }
    }

    [DBTable(24492)]
    public class PvpItem
    {
        [DBKey]
        public int ID { get; set; }
        public uint Field4 { get; set; }
        public byte Field8 { get; set; }
    }

    [DBTable(24492)]
    public class PvpReward
    {
        [DBKey]
        public int ID { get; set; }
        public byte Field4 { get; set; }
        public byte Field5 { get; set; }
        public byte Field6 { get; set; }
    }

    [DBTable(24492)]
    public class PvpScalingEffect
    {
        [DBKey]
        public int ID { get; set; }
        public float Field00 { get; set; }
        public int Field04 { get; set; }
        public int Field08 { get; set; }
    }

    [DBTable(24492)]
    public class PvpScalingEffectType
    {
        [DBKey]
        public int ID { get; set; }
        public string Field00 { get; set; }
    }

    [DBTable(24492)]
    public class PvpTalent
    {
        [DBKey]
        public int ID { get; set; }
        public uint Field04 { get; set; }
        public uint Field08 { get; set; }
        public uint Field0C { get; set; }
        public byte Field10 { get; set; }
        public byte Field11 { get; set; }
        public byte Field12 { get; set; }
        public byte Field13 { get; set; }
        public ushort Field14 { get; set; }
        public byte Field16 { get; set; }
    }

    [DBTable(24492)]
    public class PvpTalentUnlock
    {
        [DBKey]
        public int ID { get; set; }
        public byte Field4 { get; set; }
        public byte Field5 { get; set; }
        public byte Field6 { get; set; }
    }

    [DBTable(24492)]
    public class QuestFactionReward
    {
        [DBKey]
        public int ID { get; set; }
        [DBField(ArraySize: 10)]
        public ushort[] QuestRewFactionValue { get; set; }
    }

    [DBTable(24492)]
    public class QuestFeedbackEffect
    {
        [DBKey]
        public int ID { get; set; }
        public uint Field04 { get; set; }
        public ushort Field08 { get; set; }
        public byte Field0A { get; set; }
        public byte Field0B { get; set; }
        public byte Field0C { get; set; }
        public byte Field0D { get; set; }
    }

    [DBTable(24492)]
    public class QuestInfo
    {
        [DBKey]
        public int ID { get; set; }
        public string Field04 { get; set; }
        public ushort Field08 { get; set; }
        public byte Field0A { get; set; }
        public byte Field0B { get; set; }
    }

    [DBTable(24492)]
    public class QuestLine
    {
        [DBKey]
        public int ID { get; set; }
        public string Field4 { get; set; }
    }

    [DBTable(24492)]
    public class QuestLineXQuest
    {
        [DBKey]
        public int ID { get; set; }
        public ushort Field4 { get; set; }
        public ushort Field6 { get; set; }
        public byte Field8 { get; set; }
    }

    [DBTable(24492)]
    public class QuestMoneyReward
    {
        [DBKey]
        public int ID { get; set; }
        [DBField(ArraySize: 10)]
        public uint[] Money { get; set; }
    }

    [DBTable(24492)]
    public class QuestObjective
    {
        [DBKey]
        public int ID { get; set; }
        public uint Field04 { get; set; }
        public uint Field08 { get; set; }
        public string Field0C { get; set; }
        public ushort Field10 { get; set; }
        public byte Field12 { get; set; }
        public byte Field13 { get; set; }
        public byte Field14 { get; set; }
        public byte Field15 { get; set; }
    }

    [DBTable(24492)]
    public class QuestPackageItem
    {
        [DBKey]
        public int ID { get; set; }
        public uint ItemID { get; set; }
        public ushort QuestPackageID { get; set; }
        public byte FilterType { get; set; }
        public uint ItemCount { get; set; }
    }

    [DBTable(24492)]
    public class QuestPOIBlob
    {
        [DBKey]
        public int ID { get; set; }
        public ushort Field04 { get; set; }
        public ushort Field06 { get; set; }
        public byte Field08 { get; set; }
        public byte Field09 { get; set; }
        public int Field0A { get; set; }
    }

    [DBTable(24492)]
    public class QuestPOIPoint
    {
        public uint Field0 { get; set; }
        public ushort Field4 { get; set; }
        public ushort Field6 { get; set; }
        [DBKey]
        public int ID { get; set; }
    }

    [DBTable(24492)]
    public class QuestPOIPointCliTask
    {
        [DBKey]
        public int ID { get; set; }
        public ushort Field04 { get; set; }
        public ushort Field06 { get; set; }
        public ushort Field08 { get; set; }
        public ushort Field0A { get; set; }
        public ushort Field0C { get; set; }
        public byte Field0E { get; set; }
        public int Field0F { get; set; }
    }

    [DBTable(24492)]
    public class QuestSort
    {
        [DBKey]
        public int ID { get; set; }
        public string SortName { get; set; }
        public byte SortOrder { get; set; }
    }

    [DBTable(24492)]
    public class QuestV2
    {
        [DBKey]
        public int ID { get; set; }
        public ushort UniqueBitFlag { get; set; }
    }

    [DBTable(24492)]
    public class QuestV2CliTask
    {
        public int Field00 { get; set; }
        public string Field04 { get; set; }
        public string Field08 { get; set; }
        public uint Field0C { get; set; }
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
        [DBKey]
        public int ID { get; set; }
        public byte Field2D { get; set; }
        public ushort Field2E { get; set; }
    }

    [DBTable(24492)]
    public class QuestXGroupActivity
    {
        [DBKey]
        public int ID { get; set; }
        public int Field00 { get; set; }
        public int Field04 { get; set; }
    }

    [DBTable(24492)]
    public class QuestXP
    {
        [DBKey]
        public int ID { get; set; }
        [DBField(ArraySize: 10)]
        public ushort[] Exp { get; set; }
    }

    [DBTable(24492)]
    public class RacialMounts
    {
        [DBKey]
        public int ID { get; set; }
        public uint Field4 { get; set; }
        public byte Field8 { get; set; }
    }

    [DBTable(24492)]
    public class RandPropPoints
    {
        [DBKey]
        public int ID { get; set; }
        [DBField(ArraySize: 5)]
        public uint[] EpicPropertiesPoints { get; set; }
        [DBField(ArraySize: 5)]
        public uint[] RarePropertiesPoints { get; set; }
        [DBField(ArraySize: 5)]
        public uint[] UncommonPropertiesPoints { get; set; }
    }

    [DBTable(24492)]
    public class ResearchBranch
    {
        [DBKey]
        public int ID { get; set; }
        public string Field04 { get; set; }
        public string Field08 { get; set; }
        public uint Field0C { get; set; }
        public ushort Field10 { get; set; }
        public byte Field12 { get; set; }
    }

    [DBTable(24492)]
    public class ResearchField
    {
        public int Field0 { get; set; }
        public byte Field4 { get; set; }
        [DBKey]
        [DBField(ArraySize: 3)]
        public int[] ID { get; set; }
    }

    [DBTable(24492)]
    public class ResearchProject
    {
        public string Field00 { get; set; }
        public string Field04 { get; set; }
        public uint Field08 { get; set; }
        public string Field0C { get; set; }
        public ushort Field10 { get; set; }
        public byte Field12 { get; set; }
        public byte Field13 { get; set; }
        [DBKey]
        public int ID { get; set; }
        [DBField(ArraySize: 2)]
        public byte[] Field16 { get; set; }
    }

    [DBTable(24492)]
    public class ResearchSite
    {
        [DBKey]
        public int ID { get; set; }
        public uint Field04 { get; set; }
        public string Field08 { get; set; }
        public ushort Field0C { get; set; }
        public byte Field0E { get; set; }
    }

    [DBTable(24492)]
    public class Resistances
    {
        [DBKey]
        public int ID { get; set; }
        public string Field4 { get; set; }
        public byte Field8 { get; set; }
        public ushort Field9 { get; set; }
    }

    [DBTable(24492)]
    public class RewardPack
    {
        [DBKey]
        public int ID { get; set; }
        public uint Field04 { get; set; }
        public float Field08 { get; set; }
        public byte Field0C { get; set; }
        public byte Field0D { get; set; }
        public ushort Field0E { get; set; }
        public ushort Field10 { get; set; }
    }

    [DBTable(24492)]
    public class RewardPackXCurrencyType
    {
        [DBKey]
        public int ID { get; set; }
        public byte Field4 { get; set; }
        public ushort Field5 { get; set; }
        public byte Field7 { get; set; }
    }

    [DBTable(24492)]
    public class RewardPackXItem
    {
        [DBKey]
        public int ID { get; set; }
        public uint Field04 { get; set; }
        public ushort Field08 { get; set; }
        public byte Field0A { get; set; }
    }

    [DBTable(24492)]
    public class RibbonQuality
    {
        [DBKey]
        public int ID { get; set; }
        public float Field04 { get; set; }
        public float Field08 { get; set; }
        public float Field0C { get; set; }
        public byte Field10 { get; set; }
    }

    [DBTable(24492)]
    public class RulesetItemUpgrade
    {
        [DBKey]
        public int ID { get; set; }
        public uint ItemID { get; set; }
        public ushort ItemUpgradeID { get; set; }
    }

    [DBTable(24492)]
    public class ScalingStatDistribution
    {
        [DBKey]
        public int ID { get; set; }
        public ushort ItemLevelCurveID { get; set; }
        public uint MinLevel { get; set; }
        public uint MaxLevel { get; set; }
    }

    [DBTable(24492)]
    public class Scenario
    {
        [DBKey]
        public int ID { get; set; }
        public string Name { get; set; }
        public ushort Data { get; set; }
        public byte Flags { get; set; }
        public byte Type { get; set; }
    }

    [DBTable(24492)]
    public class ScenarioEventEntry
    {
        [DBKey]
        public int ID { get; set; }
        public ushort Field4 { get; set; }
        public byte Field6 { get; set; }
    }

    [DBTable(24492)]
    public class ScenarioStep
    {
        [DBKey]
        public int ID { get; set; }
        public string Description { get; set; }
        public string Name { get; set; }
        public ushort CriteriaTreeID { get; set; }
        public ushort ScenarioID { get; set; }
        public ushort PreviousStepID { get; set; }
        public ushort QuestRewardID { get; set; }
        public byte Step { get; set; }
        public byte Flags { get; set; }
        public uint BonusRequiredStepID { get; set; }
    }

    [DBTable(24492)]
    public class SceneScript
    {
        [DBKey]
        public int ID { get; set; }
        public string Name { get; set; }
        public string Script { get; set; }
        public ushort PrevScriptId { get; set; }
        public ushort NextScriptId { get; set; }
    }

    [DBTable(24492)]
    public class SceneScriptPackage
    {
        [DBKey]
        public int ID { get; set; }
        public string Name { get; set; }
    }

    [DBTable(24492)]
    public class SceneScriptPackageMember
    {
        [DBKey]
        public int ID { get; set; }
        public ushort Field04 { get; set; }
        public ushort Field06 { get; set; }
        public ushort Field08 { get; set; }
        public byte Field0A { get; set; }
    }

    [DBTable(24492)]
    public class ScheduledInterval
    {
        [DBKey]
        public int ID { get; set; }
        public byte Field04 { get; set; }
        public byte Field05 { get; set; }
        public uint Field06 { get; set; }
        public int Field0A { get; set; }
        public byte Field0E { get; set; }
    }

    [DBTable(24492)]
    public class ScheduledWorldState
    {
        [DBKey]
        public int ID { get; set; }
        public ushort Field04 { get; set; }
        public ushort Field06 { get; set; }
        public byte Field08 { get; set; }
        public int Field09 { get; set; }
        public ushort Field0C { get; set; }
        public byte Field0E { get; set; }
        public byte Field0F { get; set; }
        public byte Field10 { get; set; }
    }

    [DBTable(24492)]
    public class ScheduledWorldStateGroup
    {
        [DBKey]
        public int ID { get; set; }
        public byte Field4 { get; set; }
        public byte Field5 { get; set; }
        public byte Field6 { get; set; }
        public byte Field7 { get; set; }
        public ushort Field8 { get; set; }
    }

    [DBTable(24492)]
    public class ScheduledWorldStateXUniqCat
    {
        [DBKey]
        public int ID { get; set; }
        public ushort Field2 { get; set; }
        public ushort Field4 { get; set; }
    }

    [DBTable(24492)]
    public class ScreenEffect
    {
        [DBKey]
        public int ID { get; set; }
        public string Field04 { get; set; }
        [DBField(ArraySize: 4)]
        public int[] Field08 { get; set; }
        public ushort Field18 { get; set; }
        public ushort Field1A { get; set; }
        public ushort Field1C { get; set; }
        public ushort Field1E { get; set; }
        public byte Field20 { get; set; }
        public byte Field21 { get; set; }
        public byte Field22 { get; set; }
        public byte Field23 { get; set; }
        public ushort Field24 { get; set; }
        public ushort Field26 { get; set; }
    }

    [DBTable(24492)]
    public class ScreenLocation
    {
        [DBKey]
        public int ID { get; set; }
        public string Field4 { get; set; }
    }

    [DBTable(24492)]
    public class SeamlessSite
    {
        [DBKey]
        public int ID { get; set; }
        public ushort Field4 { get; set; }
    }

    [DBTable(24492)]
    public class ServerMessages
    {
        [DBKey]
        public int ID { get; set; }
        public string Field4 { get; set; }
    }

    [DBTable(24492)]
    public class ShadowyEffect
    {
        [DBKey]
        public int ID { get; set; }
        public int Field04 { get; set; }
        public int Field08 { get; set; }
        public float Field0C { get; set; }
        public float Field10 { get; set; }
        public float Field14 { get; set; }
        public float Field18 { get; set; }
        public float Field1C { get; set; }
        public float Field20 { get; set; }
        public byte Field24 { get; set; }
        public byte Field25 { get; set; }
    }

    [DBTable(24492)]
    public class SkillLine
    {
        [DBKey]
        public int ID { get; set; }
        public string DisplayName { get; set; }
        public string Description { get; set; }
        public string AlternateVerb { get; set; }
        public ushort Flags { get; set; }
        public byte CategoryID { get; set; }
        public byte CanLink { get; set; }
        public uint IconFileDataID { get; set; }
        public uint ParentSkillLineID { get; set; }
    }

    [DBTable(24492)]
    public class SkillLineAbility
    {
        [DBKey]
        public int ID { get; set; }
        public uint SpellID { get; set; }
        public uint RaceMask { get; set; }
        public uint SupercedesSpell { get; set; }
        public ushort SkillLine { get; set; }
        public ushort MinSkillLineRank { get; set; }
        public ushort TrivialSkillLineRankHigh { get; set; }
        public ushort TrivialSkillLineRankLow { get; set; }
        public ushort UniqueBit { get; set; }
        public ushort TradeSkillCategoryID { get; set; }
        public byte AcquireMethod { get; set; }
        public byte NumSkillUps { get; set; }
        public byte Unknown703 { get; set; }
        public int ClassMask { get; set; }
    }

    [DBTable(24492)]
    public class SkillRaceClassInfo
    {
        [DBKey]
        public int ID { get; set; }
        public int RaceMask { get; set; }
        public ushort SkillID { get; set; }
        public ushort Flags { get; set; }
        public ushort SkillTierID { get; set; }
        public byte Availability { get; set; }
        public byte MinLevel { get; set; }
        public int ClassMask { get; set; }
    }

    [DBTable(24492)]
    public class SoundAmbience
    {
        [DBKey]
        public int ID { get; set; }
        public byte Field04 { get; set; }
        [DBField(ArraySize: 2)]
        public int[] Field05 { get; set; }
        public byte Field0B { get; set; }
        public byte Field0C { get; set; }
    }

    [DBTable(24492)]
    public class SoundAmbienceFlavor
    {
        [DBKey]
        public int ID { get; set; }
        public ushort Field4 { get; set; }
        public int Field6 { get; set; }
        public int Field9 { get; set; }
    }

    [DBTable(24492)]
    public class SoundBus
    {
        public float Field00 { get; set; }
        public float Field04 { get; set; }
        public ushort Field08 { get; set; }
        public byte Field0A { get; set; }
        public byte Field0B { get; set; }
        public byte Field0C { get; set; }
        public byte Field0D { get; set; }
        public byte Field0E { get; set; }
        public byte Field0F { get; set; }
        public byte Field10 { get; set; }
        public byte Field11 { get; set; }
        [DBKey]
        public int ID { get; set; }
    }

    [DBTable(24492)]
    public class SoundBusName
    {
        public string Field0 { get; set; }
        [DBKey]
        [DBField(ArraySize: 4)]
        public int[] ID { get; set; }
    }

    [DBTable(24492)]
    public class SoundBusOverride
    {
        [DBKey]
        public int ID { get; set; }
        public float Field04 { get; set; }
        public byte Field08 { get; set; }
        public byte Field09 { get; set; }
        public byte Field0A { get; set; }
        public int Field0B { get; set; }
        public int Field0F { get; set; }
    }

    [DBTable(24492)]
    public class SoundEmitterPillPoints
    {
        [DBKey]
        public int ID { get; set; }
        [DBField(ArraySize: 3)]
        public int[] Field04 { get; set; }
        public ushort Field10 { get; set; }
    }

    [DBTable(24492)]
    public class SoundEmitters
    {
        [DBField(ArraySize: 3)]
        public int[] Field00 { get; set; }
        [DBField(ArraySize: 3)]
        public int[] Field0C { get; set; }
        public string Field18 { get; set; }
        public ushort Field1C { get; set; }
        public ushort Field1E { get; set; }
        public ushort Field20 { get; set; }
        public byte Field22 { get; set; }
        public byte Field23 { get; set; }
        public byte Field24 { get; set; }
        public byte Field25 { get; set; }
        [DBKey]
        public int ID { get; set; }
        public int Field28 { get; set; }
    }

    [DBTable(24492)]
    public class SoundFilter
    {
        [DBKey]
        public int ID { get; set; }
        public string Field4 { get; set; }
    }

    [DBTable(24492)]
    public class SoundFilterElem
    {
        [DBKey]
        public int ID { get; set; }
        [DBField(ArraySize: 9)]
        public float[] Field04 { get; set; }
        public byte Field28 { get; set; }
        public byte Field29 { get; set; }
    }

    [DBTable(24492)]
    public class SoundKit
    {
        [DBKey]
        public int ID { get; set; }
        public float VolumeFloat { get; set; }
        public float MinDistance { get; set; }
        public float DistanceCutoff { get; set; }
        public ushort Field10 { get; set; }
        public ushort Field12 { get; set; }
        public byte Field14 { get; set; }
        public byte Field15 { get; set; }
        public byte Field16 { get; set; }
        public float Field1A { get; set; }
        public float Field1E { get; set; }
        public float Field22 { get; set; }
        public float Field26 { get; set; }
        public float Field2A { get; set; }
        public ushort Field2E { get; set; }
        public byte Field32 { get; set; }
    }

    [DBTable(24492)]
    public class SoundKitAdvanced
    {
        [DBKey]
        public int ID { get; set; }
        public float Field004 { get; set; }
        public uint Field008 { get; set; }
        public uint Field00C { get; set; }
        public uint Field010 { get; set; }
        public uint Field014 { get; set; }
        public uint Field018 { get; set; }
        public uint Field01C { get; set; }
        public float Field020 { get; set; }
        public float Field024 { get; set; }
        public float Field028 { get; set; }
        public float Field02C { get; set; }
        public float Field030 { get; set; }
        public uint Field034 { get; set; }
        public uint Field038 { get; set; }
        public int Field03C { get; set; }
        public int Field040 { get; set; }
        public float Field044 { get; set; }
        public float Field048 { get; set; }
        public float Field04C { get; set; }
        public float Field050 { get; set; }
        public int Field054 { get; set; }
        public ushort Field058 { get; set; }
        public byte Field05A { get; set; }
        public byte Field05B { get; set; }
        public byte Field05C { get; set; }
        public byte Field05D { get; set; }
        public int Field05E { get; set; }
        public ushort Field061 { get; set; }
        public int Field063 { get; set; }
        public int Field066 { get; set; }
        public ushort Field069 { get; set; }
        public ushort Field06B { get; set; }
    }

    [DBTable(24492)]
    public class SoundKitChild
    {
        [DBKey]
        public int ID { get; set; }
        public int Field4 { get; set; }
        public int Field7 { get; set; }
    }

    [DBTable(24492)]
    public class SoundKitEntry
    {
        [DBKey]
        public int ID { get; set; }
        public uint Field04 { get; set; }
        public float Field08 { get; set; }
        public byte Field0C { get; set; }
        public int Field0D { get; set; }
    }

    [DBTable(24492)]
    public class SoundKitFallback
    {
        [DBKey]
        public int ID { get; set; }
        public ushort Field4 { get; set; }
        public ushort Field6 { get; set; }
    }

    [DBTable(24492)]
    public class SoundKitName
    {
        [DBKey]
        public int ID { get; set; }
        public string Field4 { get; set; }
    }

    [DBTable(24492)]
    public class SoundOverride
    {
        [DBKey]
        public int ID { get; set; }
        public ushort Field04 { get; set; }
        public ushort Field06 { get; set; }
        public ushort Field08 { get; set; }
        public byte Field0A { get; set; }
    }

    [DBTable(24492)]
    public class SoundProviderPreferences
    {
        [DBKey]
        public int ID { get; set; }
        public string Field04 { get; set; }
        public float Field08 { get; set; }
        public float Field0C { get; set; }
        public float Field10 { get; set; }
        public float Field14 { get; set; }
        public float Field18 { get; set; }
        public float Field1C { get; set; }
        public float Field20 { get; set; }
        public int Field24 { get; set; }
        public float Field28 { get; set; }
        public float Field2C { get; set; }
        public float Field30 { get; set; }
        public float Field34 { get; set; }
        public float Field38 { get; set; }
        public float Field3C { get; set; }
        public float Field40 { get; set; }
        public ushort Field44 { get; set; }
        public ushort Field46 { get; set; }
        public ushort Field48 { get; set; }
        public ushort Field4A { get; set; }
        public ushort Field4C { get; set; }
        public byte Field4E { get; set; }
        public byte Field4F { get; set; }
    }

    [DBTable(24492)]
    public class SourceInfo
    {
        [DBKey]
        public int ID { get; set; }
        public uint Field04 { get; set; }
        public string Field08 { get; set; }
        public byte Field0C { get; set; }
        public byte Field0D { get; set; }
    }

    [DBTable(24492)]
    public class SpamMessages
    {
        [DBKey]
        public int ID { get; set; }
        public string Field4 { get; set; }
    }

    [DBTable(24492)]
    public class SpecializationSpells
    {
        public uint SpellID { get; set; }
        public uint OverridesSpellID { get; set; }
        public string Description { get; set; }
        public ushort SpecID { get; set; }
        public byte OrderIndex { get; set; }
        [DBKey]
        public int ID { get; set; }
    }

    [DBTable(24492)]
    public class Spell
    {
        public string Name { get; set; }
        public string NameSubtext { get; set; }
        public string Description { get; set; }
        public string AuraDescription { get; set; }
        public uint MiscID { get; set; }
        [DBKey]
        public int ID { get; set; }
        public uint DescriptionVariablesID { get; set; }
    }

    [DBTable(24492)]
    public class SpellActionBarPref
    {
        [DBKey]
        public int ID { get; set; }
        public uint Field4 { get; set; }
        public ushort Field8 { get; set; }
    }

    [DBTable(24492)]
    public class SpellActivationOverlay
    {
        [DBKey]
        public int ID { get; set; }
        public uint Field04 { get; set; }
        public uint Field08 { get; set; }
        public int Field0C { get; set; }
        public float Field10 { get; set; }
        [DBField(ArraySize: 4)]
        public uint[] Field14 { get; set; }
        public byte Field24 { get; set; }
        public byte Field25 { get; set; }
        public ushort Field26 { get; set; }
    }

    [DBTable(24492)]
    public class SpellAuraOptions
    {
        [DBKey]
        public int ID { get; set; }
        public uint SpellID { get; set; }
        public uint ProcCharges { get; set; }
        public uint ProcTypeMask { get; set; }
        public uint ProcCategoryRecovery { get; set; }
        public ushort CumulativeAura { get; set; }
        public byte DifficultyID { get; set; }
        public byte ProcChance { get; set; }
        public byte SpellProcsPerMinuteID { get; set; }
    }

    [DBTable(24492)]
    public class SpellAuraRestrictions
    {
        [DBKey]
        public int ID { get; set; }
        public uint SpellID { get; set; }
        public uint CasterAuraSpell { get; set; }
        public uint TargetAuraSpell { get; set; }
        public uint ExcludeCasterAuraSpell { get; set; }
        public uint ExcludeTargetAuraSpell { get; set; }
        public byte DifficultyID { get; set; }
        public byte CasterAuraState { get; set; }
        public byte TargetAuraState { get; set; }
        public byte ExcludeCasterAuraState { get; set; }
        public byte ExcludeTargetAuraState { get; set; }
    }

    [DBTable(24492)]
    public class SpellAuraVisibility
    {
        public uint Field0 { get; set; }
        public byte Field4 { get; set; }
        public byte Field5 { get; set; }
        [DBKey]
        public int ID { get; set; }
    }

    [DBTable(24492)]
    public class SpellAuraVisXChrSpec
    {
        [DBKey]
        public int ID { get; set; }
        public ushort Field4 { get; set; }
        public ushort Field6 { get; set; }
    }

    [DBTable(24492)]
    public class SpellCastingRequirements
    {
        [DBKey]
        public int ID { get; set; }
        public uint SpellID { get; set; }
        public ushort MinFactionID { get; set; }
        public ushort RequiredAreasID { get; set; }
        public ushort RequiresSpellFocus { get; set; }
        public byte FacingCasterFlags { get; set; }
        public byte MinReputation { get; set; }
        public byte RequiredAuraVision { get; set; }
    }

    [DBTable(24492)]
    public class SpellCastTimes
    {
        [DBKey]
        public int ID { get; set; }
        public int CastTime { get; set; }
        public int MinCastTime { get; set; }
        public ushort CastTimePerLevel { get; set; }
    }

    [DBTable(24492)]
    public class SpellCategories
    {
        [DBKey]
        public int ID { get; set; }
        public uint SpellID { get; set; }
        public ushort Category { get; set; }
        public ushort StartRecoveryCategory { get; set; }
        public ushort ChargeCategory { get; set; }
        public byte DifficultyID { get; set; }
        public byte DefenseType { get; set; }
        public byte DispelType { get; set; }
        public byte Mechanic { get; set; }
        public byte PreventionType { get; set; }
    }

    [DBTable(24492)]
    public class SpellCategory
    {
        [DBKey]
        public int ID { get; set; }
        public string Name { get; set; }
        public int ChargeRecoveryTime { get; set; }
        public byte Flags { get; set; }
        public byte UsesPerWeek { get; set; }
        public byte MaxCharges { get; set; }
        public uint ChargeCategoryType { get; set; }
    }

    [DBTable(24492)]
    public class SpellChainEffects
    {
        [DBKey]
        public int ID { get; set; }
        public float Field004 { get; set; }
        public float Field008 { get; set; }
        public float Field00C { get; set; }
        public int Field010 { get; set; }
        public uint Field014 { get; set; }
        public uint Field018 { get; set; }
        public float Field01C { get; set; }
        public float Field020 { get; set; }
        public float Field024 { get; set; }
        public int Field028 { get; set; }
        public float Field02C { get; set; }
        public float Field030 { get; set; }
        public float Field034 { get; set; }
        public int Field038 { get; set; }
        public int Field03C { get; set; }
        public int Field040 { get; set; }
        public int Field044 { get; set; }
        public int Field048 { get; set; }
        public int Field04C { get; set; }
        public int Field050 { get; set; }
        public int Field054 { get; set; }
        public int Field058 { get; set; }
        public int Field05C { get; set; }
        public int Field060 { get; set; }
        public int Field064 { get; set; }
        public uint Field068 { get; set; }
        public float Field06C { get; set; }
        public float Field070 { get; set; }
        public float Field074 { get; set; }
        public float Field078 { get; set; }
        public int Field07C { get; set; }
        public float Field080 { get; set; }
        public float Field084 { get; set; }
        public int Field088 { get; set; }
        public int Field08C { get; set; }
        public float Field090 { get; set; }
        public float Field094 { get; set; }
        [DBField(ArraySize: 3)]
        public int[] Field098 { get; set; }
        [DBField(ArraySize: 3)]
        public int[] Field0A4 { get; set; }
        [DBField(ArraySize: 3)]
        public int[] Field0B0 { get; set; }
        [DBField(ArraySize: 3)]
        public float[] Field0BC { get; set; }
        public uint Field0C8 { get; set; }
        public float Field0CC { get; set; }
        public float Field0D0 { get; set; }
        [DBField(ArraySize: 3)]
        public string[] Field0D4 { get; set; }
        public string Field0E0 { get; set; }
        public ushort Field0E4 { get; set; }
        public ushort Field0E6 { get; set; }
        [DBField(ArraySize: 11)]
        public ushort[] Field0E8 { get; set; }
        public ushort Field0FE { get; set; }
        public byte Field100 { get; set; }
        public byte Field101 { get; set; }
        public byte Field102 { get; set; }
        public byte Field103 { get; set; }
        public byte Field104 { get; set; }
        public byte Field105 { get; set; }
        public byte Field106 { get; set; }
        public byte Field107 { get; set; }
        public byte Field108 { get; set; }
        public byte Field109 { get; set; }
        public byte Field10A { get; set; }
        public int Field10B { get; set; }
    }

    [DBTable(24492)]
    public class SpellClassOptions
    {
        [DBKey]
        public int ID { get; set; }
        public uint SpellID { get; set; }
        public byte SpellClassSet { get; set; }
        public uint ModalNextSpell { get; set; }
    }

    [DBTable(24492)]
    public class SpellCooldowns
    {
        [DBKey]
        public int ID { get; set; }
        public uint SpellID { get; set; }
        public uint CategoryRecoveryTime { get; set; }
        public uint RecoveryTime { get; set; }
        public uint StartRecoveryTime { get; set; }
        public byte DifficultyID { get; set; }
    }

    [DBTable(24492)]
    public class SpellDescriptionVariables
    {
        [DBKey]
        public int ID { get; set; }
        public string Field4 { get; set; }
    }

    [DBTable(24492)]
    public class SpellDispelType
    {
        [DBKey]
        public int ID { get; set; }
        public string Field04 { get; set; }
        public string Field08 { get; set; }
        public byte Field0C { get; set; }
        public byte Field0D { get; set; }
    }

    [DBTable(24492)]
    public class SpellDuration
    {
        [DBKey]
        public int ID { get; set; }
        public int Duration { get; set; }
        public int MaxDuration { get; set; }
        public int DurationPerLevel { get; set; }
    }

    [DBTable(24492)]
    public class SpellEffect
    {
        public int Field00 { get; set; }
        public int Field04 { get; set; }
        public float Field08 { get; set; }
        public float Field0C { get; set; }
        public int Field10 { get; set; }
        [DBField(ArraySize: 4)]
        public int[] Field14 { get; set; }
        public float Field24 { get; set; }
        public float Field28 { get; set; }
        [DBKey]
        public int ID { get; set; }
        public byte Field2F { get; set; }
        public byte Field30 { get; set; }
        public ushort Field31 { get; set; }
        public uint Field33 { get; set; }
        public int Field37 { get; set; }
        public ushort Field3B { get; set; }
        public uint Field3D { get; set; }
        public int Field41 { get; set; }
        public byte Field44 { get; set; }
        [DBField(ArraySize: 2)]
        public int[] Field45 { get; set; }
        [DBField(ArraySize: 2)]
        public byte[] Field4D { get; set; }
        public int Field4F { get; set; }
        [DBField(ArraySize: 2)]
        public byte[] Field52 { get; set; }
        public int Field54 { get; set; }
        public byte Field57 { get; set; }
        public int Field58 { get; set; }
    }

    [DBTable(24492)]
    public class SpellEffectCameraShakes
    {
        [DBKey]
        public int ID { get; set; }
        [DBField(ArraySize: 3)]
        public ushort[] Field04 { get; set; }
        public ushort Field0A { get; set; }
    }

    [DBTable(24492)]
    public class SpellEffectEmission
    {
        [DBKey]
        public int ID { get; set; }
        public float Field04 { get; set; }
        public float Field08 { get; set; }
        public ushort Field0C { get; set; }
        public byte Field0E { get; set; }
    }

    [DBTable(24492)]
    public class SpellEffectGroupSize
    {
        [DBKey]
        public int ID { get; set; }
        public uint Field4 { get; set; }
        public float Field8 { get; set; }
    }

    [DBTable(24492)]
    public class SpellEffectScaling
    {
        [DBKey]
        public int ID { get; set; }
        public float Coefficient { get; set; }
        public float Variance { get; set; }
        public float ResourceCoefficient { get; set; }
        public uint SpellEffectID { get; set; }
    }

    [DBTable(24492)]
    public class SpellEquippedItems
    {
        [DBKey]
        public int ID { get; set; }
        public uint SpellID { get; set; }
        public int EquippedItemInventoryTypeMask { get; set; }
        public int EquippedItemSubClassMask { get; set; }
        public byte EquippedItemClass { get; set; }
    }

    [DBTable(24492)]
    public class SpellFlyout
    {
        [DBKey]
        public int ID { get; set; }
        public int Field04 { get; set; }
        public string Field08 { get; set; }
        public string Field0C { get; set; }
        public byte Field10 { get; set; }
        public ushort Field11 { get; set; }
        public int Field13 { get; set; }
    }

    [DBTable(24492)]
    public class SpellFlyoutItem
    {
        [DBKey]
        public int ID { get; set; }
        public uint Field4 { get; set; }
        public byte Field8 { get; set; }
        public byte Field9 { get; set; }
    }

    [DBTable(24492)]
    public class SpellFocusObject
    {
        [DBKey]
        public int ID { get; set; }
        public string Name { get; set; }
    }

    [DBTable(24492)]
    public class SpellIcon
    {
        [DBKey]
        public int ID { get; set; }
        public string Field4 { get; set; }
    }

    [DBTable(24492)]
    public class SpellInterrupts
    {
        [DBKey]
        public int ID { get; set; }
        public uint SpellID { get; set; }
        [DBField(ArraySize: 2)]
        public uint[] AuraInterruptFlags { get; set; }
        [DBField(ArraySize: 2)]
        public uint[] ChannelInterruptFlags { get; set; }
        public ushort InterruptFlags { get; set; }
        public byte DifficultyID { get; set; }
    }

    [DBTable(24492)]
    public class SpellItemEnchantment
    {
        [DBKey]
        public int ID { get; set; }
        [DBField(ArraySize: 3)]
        public uint[] EffectSpellID { get; set; }
        public string Name { get; set; }
        [DBField(ArraySize: 3)]
        public float[] EffectScalingPoints { get; set; }
        public uint TransmogCost { get; set; }
        public uint TextureFileDataID { get; set; }
        [DBField(ArraySize: 3)]
        public ushort[] EffectPointsMin { get; set; }
        public ushort ItemVisual { get; set; }
        public ushort Flags { get; set; }
        public ushort RequiredSkillID { get; set; }
        public ushort RequiredSkillRank { get; set; }
        public ushort ItemLevel { get; set; }
        public byte Charges { get; set; }
        [DBField(ArraySize: 3)]
        public byte[] Effect { get; set; }
        public byte ConditionID { get; set; }
        public byte MinLevel { get; set; }
        public byte MaxLevel { get; set; }
        public byte ScalingClass { get; set; }
        public byte ScalingClassRestricted { get; set; }
        public uint PlayerConditionID { get; set; }
    }

    [DBTable(24492)]
    public class SpellItemEnchantmentCondition
    {
        [DBKey]
        public int ID { get; set; }
        [DBField(ArraySize: 5)]
        public byte[] Field04 { get; set; }
        [DBField(ArraySize: 5)]
        public byte[] Field09 { get; set; }
        [DBField(ArraySize: 5)]
        public byte[] Field0E { get; set; }
        [DBField(ArraySize: 5)]
        public byte[] Field13 { get; set; }
        [DBField(ArraySize: 5)]
        public byte[] Field18 { get; set; }
        public byte Field1D { get; set; }
    }

    [DBTable(24492)]
    public class SpellKeyboundOverride
    {
        [DBKey]
        public int ID { get; set; }
        public uint Field04 { get; set; }
        public string Field08 { get; set; }
        public byte Field0C { get; set; }
    }

    [DBTable(24492)]
    public class SpellLabel
    {
        [DBKey]
        public int ID { get; set; }
        public uint Field4 { get; set; }
        public ushort Field8 { get; set; }
    }

    [DBTable(24492)]
    public class SpellLearnSpell
    {
        [DBKey]
        public int ID { get; set; }
        public uint LearnSpellID { get; set; }
        public uint SpellID { get; set; }
        public uint OverridesSpellID { get; set; }
    }

    [DBTable(24492)]
    public class SpellLevels
    {
        [DBKey]
        public int ID { get; set; }
        public uint SpellID { get; set; }
        public ushort BaseLevel { get; set; }
        public ushort MaxLevel { get; set; }
        public ushort SpellLevel { get; set; }
        public byte DifficultyID { get; set; }
        public byte MaxUsableLevel { get; set; }
    }

    [DBTable(24492)]
    public class SpellMechanic
    {
        [DBKey]
        public int ID { get; set; }
        public string Field4 { get; set; }
    }

    [DBTable(24492)]
    public class SpellMisc
    {
        [DBKey]
        public int ID { get; set; }
        [DBField(ArraySize: 14)]
        public int[] Attributes { get; set; }
        public float Speed { get; set; }
        public float MultistrikeSpeedMod { get; set; }
        public ushort CastingTimeIndex { get; set; }
        public ushort DurationIndex { get; set; }
        public ushort RangeIndex { get; set; }
        public byte SchoolMask { get; set; }
        public int IconFileDataID { get; set; }
        public int ActiveIconFileDataID { get; set; }
    }

    [DBTable(24492)]
    public class SpellMiscDifficulty
    {
        public uint Field0 { get; set; }
        public byte Field4 { get; set; }
        [DBKey]
        public int ID { get; set; }
    }

    [DBTable(24492)]
    public class SpellMissile
    {
        [DBKey]
        public int ID { get; set; }
        public uint Field04 { get; set; }
        public int Field08 { get; set; }
        public int Field0C { get; set; }
        public float Field10 { get; set; }
        public float Field14 { get; set; }
        public int Field18 { get; set; }
        public int Field1C { get; set; }
        public int Field20 { get; set; }
        public int Field24 { get; set; }
        public int Field28 { get; set; }
        public float Field2C { get; set; }
        public int Field30 { get; set; }
        public float Field34 { get; set; }
        public float Field38 { get; set; }
        public byte Field3C { get; set; }
    }

    [DBTable(24492)]
    public class SpellMissileMotion
    {
        [DBKey]
        public int ID { get; set; }
        public string Field04 { get; set; }
        public string Field08 { get; set; }
        public byte Field0C { get; set; }
        public byte Field0D { get; set; }
    }

    [DBTable(24492)]
    public class SpellPower
    {
        public uint SpellID { get; set; }
        public uint ManaCost { get; set; }
        public float ManaCostPercentage { get; set; }
        public float ManaCostPercentagePerSecond { get; set; }
        public uint RequiredAura { get; set; }
        public float HealthCostPercentage { get; set; }
        public byte PowerIndex { get; set; }
        public byte PowerType { get; set; }
        [DBKey]
        public int ID { get; set; }
        public int ManaCostPerLevel { get; set; }
        public int ManaCostPerSecond { get; set; }
        public uint ManaCostAdditional { get; set; }
        public uint PowerDisplayID { get; set; }
        public uint UnitPowerBarID { get; set; }
    }

    [DBTable(24492)]
    public class SpellPowerDifficulty
    {
        public byte DifficultyID { get; set; }
        public byte PowerIndex { get; set; }
        [DBKey]
        public int ID { get; set; }
    }

    [DBTable(24492)]
    public class SpellProceduralEffect
    {
        [DBField(ArraySize: 4)]
        public int[] Field00 { get; set; }
        public byte Field10 { get; set; }
        [DBKey]
        public int ID { get; set; }
    }

    [DBTable(24492)]
    public class SpellProcsPerMinute
    {
        [DBKey]
        public int ID { get; set; }
        public float BaseProcRate { get; set; }
        public byte Flags { get; set; }
    }

    [DBTable(24492)]
    public class SpellProcsPerMinuteMod
    {
        [DBKey]
        public int ID { get; set; }
        public float Coeff { get; set; }
        public ushort Param { get; set; }
        public byte Type { get; set; }
        public byte SpellProcsPerMinuteID { get; set; }
    }

    [DBTable(24492)]
    public class SpellRadius
    {
        [DBKey]
        public int ID { get; set; }
        public float Radius { get; set; }
        public float RadiusPerLevel { get; set; }
        public float RadiusMin { get; set; }
        public float RadiusMax { get; set; }
    }

    [DBTable(24492)]
    public class SpellRange
    {
        [DBKey]
        public int ID { get; set; }
        [DBField(ArraySize: 2)]
        public float[] MinRange { get; set; }
        [DBField(ArraySize: 2)]
        public float[] MaxRange { get; set; }
        public string DisplayName { get; set; }
        public string DisplayNameShort { get; set; }
        public byte Flags { get; set; }
    }

    [DBTable(24492)]
    public class SpellReagents
    {
        [DBKey]
        public int ID { get; set; }
        public uint SpellID { get; set; }
        [DBField(ArraySize: 8)]
        public int[] Reagent { get; set; }
        [DBField(ArraySize: 8)]
        public ushort[] ReagentCount { get; set; }
    }

    [DBTable(24492)]
    public class SpellReagentsCurrency
    {
        [DBKey]
        public int ID { get; set; }
        public uint Field04 { get; set; }
        public ushort Field08 { get; set; }
        public ushort Field0A { get; set; }
    }

    [DBTable(24492)]
    public class SpellScaling
    {
        [DBKey]
        public int ID { get; set; }
        public uint SpellID { get; set; }
        public ushort ScalesFromItemLevel { get; set; }
        public int ScalingClass { get; set; }
        public uint MinScalingLevel { get; set; }
        public uint MaxScalingLevel { get; set; }
    }

    [DBTable(24492)]
    public class SpellShapeshift
    {
        [DBKey]
        public int ID { get; set; }
        public uint SpellID { get; set; }
        [DBField(ArraySize: 2)]
        public uint[] ShapeshiftExclude { get; set; }
        [DBField(ArraySize: 2)]
        public uint[] ShapeshiftMask { get; set; }
        public byte StanceBarOrder { get; set; }
    }

    [DBTable(24492)]
    public class SpellShapeshiftForm
    {
        [DBKey]
        public int ID { get; set; }
        public string Name { get; set; }
        public float WeaponDamageVariance { get; set; }
        public uint Flags { get; set; }
        public ushort CombatRoundTime { get; set; }
        public ushort MountTypeID { get; set; }
        public byte CreatureType { get; set; }
        public byte BonusActionBar { get; set; }
        public uint AttackIconFileDataID { get; set; }
        [DBField(ArraySize: 4)]
        public uint[] CreatureDisplayID { get; set; }
        [DBField(ArraySize: 8)]
        public uint[] PresetSpellID { get; set; }
    }

    [DBTable(24492)]
    public class SpellSpecialUnitEffect
    {
        [DBKey]
        public int ID { get; set; }
        public ushort Field4 { get; set; }
        public byte Field6 { get; set; }
    }

    [DBTable(24492)]
    public class SpellTargetRestrictions
    {
        [DBKey]
        public int ID { get; set; }
        public uint SpellID { get; set; }
        public float ConeAngle { get; set; }
        public float Width { get; set; }
        public uint Targets { get; set; }
        public ushort TargetCreatureType { get; set; }
        public byte DifficultyID { get; set; }
        public byte MaxAffectedTargets { get; set; }
        public uint MaxTargetLevel { get; set; }
    }

    [DBTable(24492)]
    public class SpellTotems
    {
        [DBKey]
        public int ID { get; set; }
        public uint SpellID { get; set; }
        [DBField(ArraySize: 2)]
        public uint[] Totem { get; set; }
        [DBField(ArraySize: 2)]
        public ushort[] RequiredTotemCategoryID { get; set; }
    }

    [DBTable(24492)]
    public class SpellVisual
    {
        public uint Field000 { get; set; }
        public uint Field004 { get; set; }
        public uint Field008 { get; set; }
        public uint Field00C { get; set; }
        public uint Field010 { get; set; }
        public uint Field014 { get; set; }
        public uint Field018 { get; set; }
        public uint Field01C { get; set; }
        public uint Field020 { get; set; }
        public uint Field024 { get; set; }
        public uint Field028 { get; set; }
        public uint Field02C { get; set; }
        public uint Field030 { get; set; }
        public uint Field034 { get; set; }
        public uint Field038 { get; set; }
        [DBField(ArraySize: 3)]
        public int[] Field03C { get; set; }
        [DBField(ArraySize: 3)]
        public int[] Field048 { get; set; }
        public uint Field054 { get; set; }
        public uint Field058 { get; set; }
        public ushort Field05C { get; set; }
        public ushort Field05E { get; set; }
        public ushort Field060 { get; set; }
        public byte Field062 { get; set; }
        public byte Field063 { get; set; }
        [DBKey]
        public int ID { get; set; }
        public int Field066 { get; set; }
        public byte Field069 { get; set; }
        [DBField(ArraySize: 2)]
        public byte[] Field06A { get; set; }
    }

    [DBTable(24492)]
    public class SpellVisualAnim
    {
        [DBKey]
        public int ID { get; set; }
        public ushort Field4 { get; set; }
        public ushort Field6 { get; set; }
        public ushort Field8 { get; set; }
    }

    [DBTable(24492)]
    public class SpellVisualColorEffect
    {
        [DBKey]
        public int ID { get; set; }
        public float Field04 { get; set; }
        public int Field08 { get; set; }
        public float Field0C { get; set; }
        public ushort Field10 { get; set; }
        public ushort Field12 { get; set; }
        public ushort Field14 { get; set; }
        public ushort Field16 { get; set; }
        public ushort Field18 { get; set; }
        public byte Field1A { get; set; }
        public byte Field1B { get; set; }
        public ushort Field1C { get; set; }
    }

    [DBTable(24492)]
    public class SpellVisualEffectName
    {
        [DBKey]
        public int ID { get; set; }
        public float Field04 { get; set; }
        public float Field08 { get; set; }
        public float Field0C { get; set; }
        public float Field10 { get; set; }
        public float Field14 { get; set; }
        public float Field18 { get; set; }
        public uint Field1C { get; set; }
        public uint Field20 { get; set; }
        public uint Field24 { get; set; }
        public byte Field28 { get; set; }
        public int Field29 { get; set; }
        public byte Field2C { get; set; }
        public ushort Field2D { get; set; }
    }

    [DBTable(24492)]
    public class SpellVisualKit
    {
        public int Field00 { get; set; }
        public float Field04 { get; set; }
        public ushort Field08 { get; set; }
        public ushort Field0A { get; set; }
        [DBKey]
        public int ID { get; set; }
        public byte Field0F { get; set; }
    }

    [DBTable(24492)]
    public class SpellVisualKitAreaModel
    {
        [DBKey]
        public int ID { get; set; }
        public uint Field04 { get; set; }
        public float Field08 { get; set; }
        public float Field0C { get; set; }
        public float Field10 { get; set; }
        public ushort Field14 { get; set; }
        public byte Field16 { get; set; }
    }

    [DBTable(24492)]
    public class SpellVisualKitEffect
    {
        [DBKey]
        public int ID { get; set; }
        public uint Field04 { get; set; }
        public uint Field08 { get; set; }
        public uint Field0C { get; set; }
    }

    [DBTable(24492)]
    public class SpellVisualKitModelAttach
    {
        public int Field00 { get; set; }
        [DBField(ArraySize: 3)]
        public float[] Field04 { get; set; }
        [DBField(ArraySize: 3)]
        public float[] Field10 { get; set; }
        public ushort Field1C { get; set; }
        public byte Field1E { get; set; }
        public byte Field1F { get; set; }
        [DBKey]
        public int ID { get; set; }
        public ushort Field22 { get; set; }
        public float Field26 { get; set; }
        public float Field2A { get; set; }
        public float Field2E { get; set; }
        public float Field32 { get; set; }
        public float Field36 { get; set; }
        public float Field3A { get; set; }
        public float Field3E { get; set; }
        public float Field42 { get; set; }
        [DBField(DefaultValue: ushort.MaxValue)]
        public ushort Field44 { get; set; }
        [DBField(DefaultValue: ushort.MaxValue)]
        public ushort Field46 { get; set; }
        [DBField(DefaultValue: ushort.MaxValue)]
        public ushort Field48 { get; set; }
        public ushort Field4A { get; set; }
        public int Field4E { get; set; }
        public float Field52 { get; set; }
    }

    [DBTable(24492)]
    public class SpellVisualMissile
    {
        public int Field00 { get; set; }
        public uint Field04 { get; set; }
        public uint Field08 { get; set; }
        [DBField(ArraySize: 3)]
        public int[] Field0C { get; set; }
        [DBField(ArraySize: 3)]
        public int[] Field18 { get; set; }
        public ushort Field24 { get; set; }
        public ushort Field26 { get; set; }
        public ushort Field28 { get; set; }
        public ushort Field2A { get; set; }
        public ushort Field2C { get; set; }
        public ushort Field2E { get; set; }
        public byte Field30 { get; set; }
        public byte Field31 { get; set; }
        [DBKey]
        public int ID { get; set; }
        public int Field34 { get; set; }
        [DBField(ArraySize: 2)]
        public ushort[] Field37 { get; set; }
    }

    [DBTable(24492)]
    public class SpellXSpellVisual
    {
        public uint Field00 { get; set; }
        public float Field04 { get; set; }
        public ushort Field08 { get; set; }
        public ushort Field0A { get; set; }
        public ushort Field0C { get; set; }
        public byte Field0E { get; set; }
        public byte Field0F { get; set; }
        [DBKey]
        public int ID { get; set; }
    }

    [DBTable(24492)]
    public class Startup_Strings
    {
        [DBKey]
        public int ID { get; set; }
        public string Field4 { get; set; }
        public string Field8 { get; set; }
    }

    [DBTable(24492)]
    public class StartupFiles
    {
        [DBKey]
        public int ID { get; set; }
        public int Field00 { get; set; }
        public int Field04 { get; set; }
        public int Field08 { get; set; }
    }

    [DBTable(24492)]
    public class Stationery
    {
        [DBKey]
        public int ID { get; set; }
        public byte Field4 { get; set; }
        public ushort Field5 { get; set; }
        public int Field7 { get; set; }
    }

    [DBTable(24492)]
    public class StringLookups
    {
        [DBKey]
        public int ID { get; set; }
        public string Field4 { get; set; }
    }

    [DBTable(24492)]
    public class SummonProperties
    {
        [DBKey]
        public int ID { get; set; }
        public uint Flags { get; set; }
        public uint Category { get; set; }
        public uint Faction { get; set; }
        public int Type { get; set; }
        public int Slot { get; set; }
    }

    [DBTable(24492)]
    public class TactKey
    {
        [DBKey]
        public int ID { get; set; }
        [DBField(ArraySize: 16)]
        public byte[] Key { get; set; }
    }

    [DBTable(24492)]
    public class TactKeyLookup
    {
        [DBKey]
        public int ID { get; set; }
        [DBField(ArraySize: 4)]
        public byte[] Field4 { get; set; }
    }

    [DBTable(24492)]
    public class Talent
    {
        [DBKey]
        public int ID { get; set; }
        public uint SpellID { get; set; }
        public uint OverridesSpellID { get; set; }
        public string Description { get; set; }
        public ushort SpecID { get; set; }
        public byte TierID { get; set; }
        public byte ColumnIndex { get; set; }
        public byte Flags { get; set; }
        [DBField(ArraySize: 2)]
        public byte[] CategoryMask { get; set; }
        public byte ClassID { get; set; }
    }

    [DBTable(24492)]
    public class TaxiNodes
    {
        [DBField(ArraySize: 3)]
        public float[] Field00 { get; set; }
        public string Field0C { get; set; }
        [DBField(ArraySize: 2)]
        public int[] Field10 { get; set; }
        [DBField(ArraySize: 2)]
        public float[] Field18 { get; set; }
        public ushort Field20 { get; set; }
        public ushort Field22 { get; set; }
        public ushort Field24 { get; set; }
        public byte Field26 { get; set; }
        [DBKey]
        public int ID { get; set; }
    }

    [DBTable(24492)]
    public class TaxiPath
    {
        public ushort From { get; set; }
        public ushort To { get; set; }
        [DBKey]
        public int ID { get; set; }
        public uint Cost { get; set; }
    }

    [DBTable(24492)]
    public class TaxiPathNode
    {
        [DBField(ArraySize: 3)]
        public float[] Loc { get; set; }
        public uint Delay { get; set; }
        public ushort PathID { get; set; }
        public ushort MapID { get; set; }
        public ushort ArrivalEventID { get; set; }
        public ushort DepartureEventID { get; set; }
        public byte NodeIndex { get; set; }
        public byte Flags { get; set; }
        [DBKey]
        public int ID { get; set; }
    }

    [DBTable(24492)]
    public class TerrainMaterial
    {
        [DBKey]
        public int ID { get; set; }
        public string Field04 { get; set; }
        public string Field08 { get; set; }
        public byte Field0C { get; set; }
    }

    [DBTable(24492)]
    public class TerrainType
    {
        [DBKey]
        public int ID { get; set; }
        public string Field04 { get; set; }
        public ushort Field08 { get; set; }
        public ushort Field0A { get; set; }
        public byte Field0C { get; set; }
        public byte Field0D { get; set; }
    }

    [DBTable(24492)]
    public class TerrainTypeSounds
    {
        [DBKey]
        public int ID { get; set; }
        public string Field4 { get; set; }
    }

    [DBTable(24492)]
    public class TextureBlendSet
    {
        [DBKey]
        public int ID { get; set; }
        [DBField(ArraySize: 3)]
        public uint[] Field04 { get; set; }
        [DBField(ArraySize: 3)]
        public int[] Field10 { get; set; }
        [DBField(ArraySize: 3)]
        public int[] Field1C { get; set; }
        [DBField(ArraySize: 3)]
        public float[] Field28 { get; set; }
        [DBField(ArraySize: 3)]
        public float[] Field34 { get; set; }
        [DBField(ArraySize: 4)]
        public float[] Field40 { get; set; }
        public byte Field50 { get; set; }
        public byte Field51 { get; set; }
        public byte Field52 { get; set; }
        public byte Field53 { get; set; }
    }

    [DBTable(24492)]
    public class TextureFileData
    {
        public uint Field0 { get; set; }
        public byte Field4 { get; set; }
        [DBKey]
        public int ID { get; set; }
    }

    [DBTable(24492)]
    public class TotemCategory
    {
        [DBKey]
        public int ID { get; set; }
        public string Name { get; set; }
        public uint CategoryMask { get; set; }
        public byte CategoryType { get; set; }
    }

    [DBTable(24492)]
    public class Toy
    {
        public uint ItemID { get; set; }
        public string Description { get; set; }
        public byte Flags { get; set; }
        public byte CategoryFilter { get; set; }
        [DBKey]
        public int ID { get; set; }
    }

    [DBTable(24492)]
    public class TradeSkillCategory
    {
        [DBKey]
        public int ID { get; set; }
        public string Field04 { get; set; }
        public ushort Field08 { get; set; }
        public ushort Field0A { get; set; }
        public ushort Field0C { get; set; }
        public byte Field0E { get; set; }
    }

    [DBTable(24492)]
    public class TradeSkillItem
    {
        [DBKey]
        public int ID { get; set; }
        public ushort Field4 { get; set; }
        public byte Field6 { get; set; }
    }

    [DBTable(24492)]
    public class TransformMatrix
    {
        [DBKey]
        public int ID { get; set; }
        [DBField(ArraySize: 3)]
        public int[] Field04 { get; set; }
        public uint Field10 { get; set; }
        public int Field14 { get; set; }
        public float Field18 { get; set; }
        public float Field1C { get; set; }
    }

    [DBTable(24492)]
    public class TransmogHoliday
    {
        [DBKey]
        public int ID { get; set; }
        public int Field04 { get; set; }
    }

    [DBTable(24492)]
    public class TransmogSet
    {
        [DBKey]
        public int ID { get; set; }
        public byte Field1 { get; set; }
        public ushort Field2 { get; set; }
        public ushort Field4 { get; set; }
    }

    [DBTable(24492)]
    public class TransmogSetGroup
    {
        public string Field00 { get; set; }
        [DBKey]
        public int ID { get; set; }
    }

    [DBTable(24492)]
    public class TransmogSetItem
    {
        [DBKey]
        public int ID { get; set; }
        public ushort Field3 { get; set; }
        public int Field5 { get; set; }
        public byte Field8 { get; set; }
    }

    [DBTable(24492)]
    public class TransportAnimation
    {
        [DBKey]
        public int ID { get; set; }
        public uint TransportID { get; set; }
        public uint TimeIndex { get; set; }
        [DBField(ArraySize: 3)]
        public float[] Pos { get; set; }
        public byte SequenceID { get; set; }
    }

    [DBTable(24492)]
    public class TransportPhysics
    {
        [DBKey]
        public int ID { get; set; }
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
    }

    [DBTable(24492)]
    public class TransportRotation
    {
        [DBKey]
        public int ID { get; set; }
        public uint TransportID { get; set; }
        public uint TimeIndex { get; set; }
        [DBField(ArraySize: 4)]
        public float[] Position { get; set; }
    }

    [DBTable(24492)]
    public class Trophy
    {
        [DBKey]
        public int ID { get; set; }
        public string Field04 { get; set; }
        public ushort Field08 { get; set; }
        public byte Field0A { get; set; }
        public ushort Field0B { get; set; }
    }

    [DBTable(24492)]
    public class UiCamera
    {
        [DBKey]
        public int ID { get; set; }
        public string Field04 { get; set; }
        [DBField(ArraySize: 3)]
        public int[] Field08 { get; set; }
        [DBField(ArraySize: 3)]
        public int[] Field14 { get; set; }
        [DBField(ArraySize: 3)]
        public float[] Field20 { get; set; }
        public ushort Field2C { get; set; }
        public byte Field2E { get; set; }
        public byte Field2F { get; set; }
        public byte Field30 { get; set; }
        public byte Field31 { get; set; }
    }

    [DBTable(24492)]
    public class UiCameraType
    {
        [DBKey]
        public int ID { get; set; }
        public string Field04 { get; set; }
        public ushort Field08 { get; set; }
        public ushort Field0A { get; set; }
    }

    [DBTable(24492)]
    public class UiCamFbackTransmogChrRace
    {
        [DBKey]
        public int ID { get; set; }
        public ushort Field4 { get; set; }
        public byte Field6 { get; set; }
        public byte Field7 { get; set; }
        public byte Field8 { get; set; }
        public byte Field9 { get; set; }
    }

    [DBTable(24492)]
    public class UiCamFbackTransmogWeapon
    {
        [DBKey]
        public int ID { get; set; }
        public ushort Field4 { get; set; }
        public byte Field6 { get; set; }
        public byte Field7 { get; set; }
        public byte Field8 { get; set; }
    }

    [DBTable(24492)]
    public class UiMapPOI
    {
        public uint Field00 { get; set; }
        [DBField(ArraySize: 3)]
        public int[] Field04 { get; set; }
        public uint Field10 { get; set; }
        public uint Field14 { get; set; }
        public ushort Field18 { get; set; }
        public ushort Field1A { get; set; }
        [DBKey]
        [DBField(ArraySize: 4)]
        public int[] ID { get; set; }
    }

    [DBTable(24492)]
    public class UiModelScene
    {
        [DBKey]
        public int ID { get; set; }
        public byte Field00 { get; set; }
        public byte Field01 { get; set; }
    }

    [DBTable(24492)]
    public class UiModelSceneActor
    {
        public string Field00 { get; set; }
        [DBField(ArraySize: 3)]
        public float[] Field04 { get; set; }
        public float Field10 { get; set; }
        public float Field14 { get; set; }
        public float Field18 { get; set; }
        public float Field1C { get; set; }
        public byte Field20 { get; set; }
        [DBKey]
        public int ID { get; set; }
        public int Field25 { get; set; }
        public int Field29 { get; set; }
    }

    [DBTable(24492)]
    public class UiModelSceneActorDisplay
    {
        [DBKey]
        public int ID { get; set; }
        public float Field00 { get; set; }
        public float Field04 { get; set; }
        public int Field08 { get; set; }
        public int Field0C { get; set; }
    }

    [DBTable(24492)]
    public class UiModelSceneCamera
    {
        public string Field00 { get; set; }
        [DBField(ArraySize: 3)]
        public float[] Field04 { get; set; }
        [DBField(ArraySize: 3)]
        public float[] Field10 { get; set; }
        public float Field1C { get; set; }
        public float Field20 { get; set; }
        public float Field24 { get; set; }
        public float Field28 { get; set; }
        public float Field2C { get; set; }
        public float Field30 { get; set; }
        public float Field34 { get; set; }
        public float Field38 { get; set; }
        public float Field3C { get; set; }
        public byte Field40 { get; set; }
        public byte Field41 { get; set; }
        [DBKey]
        public int ID { get; set; }
        public int Field46 { get; set; }
    }

    [DBTable(24492)]
    public class UiTextureAtlas
    {
        [DBKey]
        public int ID { get; set; }
        public uint Field04 { get; set; }
        public ushort Field08 { get; set; }
        public ushort Field0A { get; set; }
    }

    [DBTable(24492)]
    public class UiTextureAtlasMember
    {
        [DBKey]
        public int ID { get; set; }
        public string Field04 { get; set; }
        public ushort Field08 { get; set; }
        public ushort Field0A { get; set; }
        public ushort Field0C { get; set; }
        public ushort Field0E { get; set; }
        public ushort Field10 { get; set; }
        public byte Field12 { get; set; }
    }

    [DBTable(24492)]
    public class UiTextureKit
    {
        [DBKey]
        public int ID { get; set; }
        public string Field4 { get; set; }
    }

    [DBTable(24492)]
    public class UnitBlood
    {
        [DBKey]
        public int ID { get; set; }
        [DBField(ArraySize: 5)]
        public string[] Field04 { get; set; }
        public ushort Field18 { get; set; }
        public ushort Field1A { get; set; }
        public ushort Field1C { get; set; }
        public int Field1E { get; set; }
        public int Field21 { get; set; }
        public int Field24 { get; set; }
    }

    [DBTable(24492)]
    public class UnitBloodLevels
    {
        [DBKey]
        public int ID { get; set; }
        public byte Field4 { get; set; }
    }

    [DBTable(24492)]
    public class UnitCondition
    {
        [DBKey]
        public int ID { get; set; }
        [DBField(ArraySize: 8)]
        public uint[] Field04 { get; set; }
        public byte Field24 { get; set; }
        [DBField(ArraySize: 8)]
        public byte[] Field25 { get; set; }
        [DBField(ArraySize: 7)]
        public byte[] Field2D { get; set; }
    }

    [DBTable(24492)]
    public class UnitPowerBar
    {
        [DBKey]
        public int ID { get; set; }
        public float RegenerationPeace { get; set; }
        public float RegenerationCombat { get; set; }
        [DBField(ArraySize: 6)]
        public uint[] FileDataID { get; set; }
        [DBField(ArraySize: 6)]
        public uint[] Color { get; set; }
        public string Name { get; set; }
        public string Cost { get; set; }
        public string OutOfError { get; set; }
        public string ToolTip { get; set; }
        public float StartInset { get; set; }
        public float EndInset { get; set; }
        public ushort StartPower { get; set; }
        public ushort Flags { get; set; }
        public byte CenterPower { get; set; }
        public byte BarType { get; set; }
        public uint MinPower { get; set; }
        public uint MaxPower { get; set; }
    }

    [DBTable(24492)]
    public class Vehicle
    {
        [DBKey]
        public int ID { get; set; }
        public uint Flags { get; set; }
        public float TurnSpeed { get; set; }
        public float PitchSpeed { get; set; }
        public float PitchMin { get; set; }
        public float PitchMax { get; set; }
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
        public float MsslTrgtImpactTexRadius { get; set; }
        [DBField(ArraySize: 8)]
        public ushort[] SeatID { get; set; }
        public ushort VehicleUIIndicatorID { get; set; }
        [DBField(ArraySize: 3)]
        public ushort[] PowerDisplayID { get; set; }
        public byte FlagsB { get; set; }
        public byte UILocomotionType { get; set; }
    }

    [DBTable(24492)]
    public class VehicleSeat
    {
        [DBKey]
        public int ID { get; set; }
        [DBField(ArraySize: 3)]
        public uint[] Flags { get; set; }
        [DBField(ArraySize: 3)]
        public float[] AttachmentOffset { get; set; }
        public float EnterPreDelay { get; set; }
        public float EnterSpeed { get; set; }
        public float EnterGravity { get; set; }
        public float EnterMinDuration { get; set; }
        public float EnterMaxDuration { get; set; }
        public float EnterMinArcHeight { get; set; }
        public float EnterMaxArcHeight { get; set; }
        public float ExitPreDelay { get; set; }
        public float ExitSpeed { get; set; }
        public float ExitGravity { get; set; }
        public float ExitMinDuration { get; set; }
        public float ExitMaxDuration { get; set; }
        public float ExitMinArcHeight { get; set; }
        public float ExitMaxArcHeight { get; set; }
        public float PassengerYaw { get; set; }
        public float PassengerPitch { get; set; }
        public float PassengerRoll { get; set; }
        public float VehicleEnterAnimDelay { get; set; }
        public float VehicleExitAnimDelay { get; set; }
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
        public uint UISkinFileDataID { get; set; }
        public ushort EnterAnimStart { get; set; }
        public ushort EnterAnimLoop { get; set; }
        public ushort RideAnimStart { get; set; }
        public ushort RideAnimLoop { get; set; }
        public ushort RideUpperAnimStart { get; set; }
        public ushort RideUpperAnimLoop { get; set; }
        public ushort ExitAnimStart { get; set; }
        public ushort ExitAnimLoop { get; set; }
        public ushort ExitAnimEnd { get; set; }
        public ushort VehicleEnterAnim { get; set; }
        public ushort VehicleExitAnim { get; set; }
        public ushort VehicleRideAnimLoop { get; set; }
        public ushort EnterAnimKitID { get; set; }
        public ushort RideAnimKitID { get; set; }
        public ushort ExitAnimKitID { get; set; }
        public ushort VehicleEnterAnimKitID { get; set; }
        public ushort VehicleRideAnimKitID { get; set; }
        public ushort VehicleExitAnimKitID { get; set; }
        public ushort CameraModeID { get; set; }
        public byte AttachmentID { get; set; }
        public byte PassengerAttachmentID { get; set; }
        public byte VehicleEnterAnimBone { get; set; }
        public byte VehicleExitAnimBone { get; set; }
        public byte VehicleRideAnimLoopBone { get; set; }
        public byte VehicleAbilityDisplay { get; set; }
        public uint EnterUISoundID { get; set; }
        public uint ExitUISoundID { get; set; }
    }

    [DBTable(24492)]
    public class VehicleUIIndicator
    {
        [DBKey]
        public int ID { get; set; }
        public string Field4 { get; set; }
    }

    [DBTable(24492)]
    public class VehicleUIIndSeat
    {
        [DBKey]
        public int ID { get; set; }
        public float Field04 { get; set; }
        public float Field08 { get; set; }
        public ushort Field0C { get; set; }
        public byte Field0E { get; set; }
    }

    [DBTable(24492)]
    public class VideoHardware
    {
        public string Field00 { get; set; }
        public int Field04 { get; set; }
        public ushort Field08 { get; set; }
        public ushort Field0A { get; set; }
        public byte Field0C { get; set; }
        public byte Field0D { get; set; }
        public byte Field0E { get; set; }
        public byte Field0F { get; set; }
        public byte Field10 { get; set; }
        public byte Field11 { get; set; }
        public byte Field12 { get; set; }
        public byte Field13 { get; set; }
        public byte Field14 { get; set; }
        public byte Field15 { get; set; }
        [DBKey]
        public int ID { get; set; }
        public byte Field18 { get; set; }
        public byte Field19 { get; set; }
        public byte Field1A { get; set; }
        public byte Field1B { get; set; }
        public byte Field1C { get; set; }
        public byte Field1D { get; set; }
        [DBField(ArraySize: 2)]
        public byte[] Field1E { get; set; }
    }

    [DBTable(24492)]
    public class Vignette
    {
        [DBKey]
        public int ID { get; set; }
        public string Field04 { get; set; }
        public int Field08 { get; set; }
        public int Field0C { get; set; }
        public byte Field10 { get; set; }
        public byte Field11 { get; set; }
        public ushort Field12 { get; set; }
        public ushort Field14 { get; set; }
    }

    [DBTable(24492)]
    public class VocalUISounds
    {
        [DBKey]
        public int ID { get; set; }
        public byte Field4 { get; set; }
        public byte Field5 { get; set; }
        public byte Field6 { get; set; }
        public ushort Field7 { get; set; }
    }

    [DBTable(24492)]
    public class WbAccessControlList
    {
        [DBKey]
        public int ID { get; set; }
        public string Field04 { get; set; }
        public ushort Field08 { get; set; }
        public byte Field0A { get; set; }
        public byte Field0B { get; set; }
        public byte Field0C { get; set; }
    }

    [DBTable(24492)]
    public class WbCertBlacklist
    {
        [DBKey]
        public int ID { get; set; }
        public uint Field4 { get; set; }
        [DBField(ArraySize: 16)]
        public byte[] Field8 { get; set; }
    }

    [DBTable(24492)]
    public class WbCertWhitelist
    {
        [DBKey]
        public int ID { get; set; }
        public string Field04 { get; set; }
        public byte Field08 { get; set; }
        public byte Field09 { get; set; }
        public byte Field0A { get; set; }
    }

    [DBTable(24492)]
    public class WbPermissions
    {
        [DBKey]
        public int ID { get; set; }
        public string Field4 { get; set; }
        public byte Field8 { get; set; }
    }

    [DBTable(24492)]
    public class WeaponImpactSounds
    {
        [DBKey]
        public int ID { get; set; }
        public byte Field04 { get; set; }
        public byte Field05 { get; set; }
        public byte Field06 { get; set; }
        [DBField(ArraySize: 11)]
        public int[] Field07 { get; set; }
        [DBField(ArraySize: 11)]
        public int[] Field28 { get; set; }
        [DBField(ArraySize: 11)]
        public ushort[] Field49 { get; set; }
        [DBField(ArraySize: 9)]
        public ushort[] Field5F { get; set; }
    }

    [DBTable(24492)]
    public class WeaponSwingSounds2
    {
        [DBKey]
        public int ID { get; set; }
        public byte Field4 { get; set; }
        public byte Field5 { get; set; }
        public ushort Field6 { get; set; }
    }

    [DBTable(24492)]
    public class WeaponTrail
    {
        [DBKey]
        public int ID { get; set; }
        public uint Field04 { get; set; }
        public float Field08 { get; set; }
        public uint Field0C { get; set; }
        public uint Field10 { get; set; }
        [DBField(ArraySize: 3)]
        public uint[] Field14 { get; set; }
        [DBField(ArraySize: 3)]
        public uint[] Field20 { get; set; }
        [DBField(ArraySize: 3)]
        public uint[] Field2C { get; set; }
        [DBField(ArraySize: 3)]
        public float[] Field38 { get; set; }
        [DBField(ArraySize: 2)]
        public float[] Field44 { get; set; }
    }

    [DBTable(24492)]
    public class WeaponTrailModelDef
    {
        [DBKey]
        public int ID { get; set; }
        public uint Field04 { get; set; }
        public ushort Field08 { get; set; }
        public ushort Field0A { get; set; }
    }

    [DBTable(24492)]
    public class WeaponTrailParam
    {
        [DBKey]
        public int ID { get; set; }
        public float Field04 { get; set; }
        public float Field08 { get; set; }
        public float Field0C { get; set; }
        public float Field10 { get; set; }
        public float Field14 { get; set; }
        public ushort Field18 { get; set; }
        public byte Field1A { get; set; }
        public byte Field1B { get; set; }
        public byte Field1C { get; set; }
        public byte Field1D { get; set; }
    }

    [DBTable(24492)]
    public class Weather
    {
        [DBKey]
        public int ID { get; set; }
        [DBField(ArraySize: 2)]
        public float[] Field04 { get; set; }
        public float Field0C { get; set; }
        [DBField(ArraySize: 3)]
        public float[] Field10 { get; set; }
        public string Field1C { get; set; }
        public float Field20 { get; set; }
        public float Field24 { get; set; }
        public float Field28 { get; set; }
        public float Field2C { get; set; }
        public float Field30 { get; set; }
        public ushort Field34 { get; set; }
        public byte Field36 { get; set; }
        public byte Field37 { get; set; }
        public byte Field38 { get; set; }
        public ushort Field39 { get; set; }
    }

    [DBTable(24492)]
    public class WindSettings
    {
        [DBKey]
        public int ID { get; set; }
        public float Field04 { get; set; }
        [DBField(ArraySize: 3)]
        public int[] Field08 { get; set; }
        public float Field14 { get; set; }
        public float Field18 { get; set; }
        [DBField(ArraySize: 3)]
        public float[] Field1C { get; set; }
        public float Field28 { get; set; }
        [DBField(ArraySize: 3)]
        public float[] Field2C { get; set; }
        public uint Field38 { get; set; }
        public uint Field3C { get; set; }
        public byte Field40 { get; set; }
    }

    [DBTable(24492)]
    public class WMOAreaTable
    {
        public int WMOGroupID { get; set; }
        public string AreaName { get; set; }
        public ushort WMOID { get; set; }
        public ushort AmbienceID { get; set; }
        public ushort ZoneMusic { get; set; }
        public ushort IntroSound { get; set; }
        public ushort AreaTableID { get; set; }
        public ushort UWIntroSound { get; set; }
        public ushort UWAmbience { get; set; }
        public byte NameSet { get; set; }
        public byte SoundProviderPref { get; set; }
        public byte SoundProviderPrefUnderwater { get; set; }
        public byte Flags { get; set; }
        [DBKey]
        public int ID { get; set; }
        public uint UWZoneMusic { get; set; }
    }

    [DBTable(24492)]
    public class WmoMinimapTexture
    {
        [DBKey]
        public int ID { get; set; }
        public uint Field04 { get; set; }
        public ushort Field08 { get; set; }
        public ushort Field0A { get; set; }
        public byte Field0C { get; set; }
        public byte Field0D { get; set; }
    }

    [DBTable(24492)]
    public class World_PVP_Area
    {
        [DBKey]
        public int ID { get; set; }
        public ushort Field04 { get; set; }
        public ushort Field06 { get; set; }
        public ushort Field08 { get; set; }
        public ushort Field0A { get; set; }
        public ushort Field0C { get; set; }
        public byte Field0E { get; set; }
        public byte Field0F { get; set; }
    }

    [DBTable(24492)]
    public class WorldBossLockout
    {
        [DBKey]
        public int ID { get; set; }
        public string Field4 { get; set; }
        public ushort Field8 { get; set; }
    }

    [DBTable(24492)]
    public class WorldChunkSounds
    {
        [DBKey]
        public int ID { get; set; }
        public ushort Field04 { get; set; }
        public byte Field06 { get; set; }
        public byte Field07 { get; set; }
        public byte Field08 { get; set; }
        public byte Field09 { get; set; }
        public byte Field0A { get; set; }
    }

    [DBTable(24492)]
    public class WorldEffect
    {
        [DBKey]
        public int ID { get; set; }
        public int Field04 { get; set; }
        public ushort Field08 { get; set; }
        public byte Field0A { get; set; }
        public byte Field0B { get; set; }
        public byte Field0C { get; set; }
        public ushort Field0D { get; set; }
    }

    [DBTable(24492)]
    public class WorldElapsedTimer
    {
        [DBKey]
        public int ID { get; set; }
        public string Field4 { get; set; }
        public byte Field8 { get; set; }
        public byte Field9 { get; set; }
    }

    [DBTable(24492)]
    public class WorldMapArea
    {
        public string AreaName { get; set; }
        public float LocLeft { get; set; }
        public float LocRight { get; set; }
        public float LocTop { get; set; }
        public float LocBottom { get; set; }
        public ushort MapID { get; set; }
        public ushort AreaID { get; set; }
        public ushort DisplayMapID { get; set; }
        public ushort DefaultDungeonFloor { get; set; }
        public ushort ParentWorldMapID { get; set; }
        public ushort Flags { get; set; }
        public byte LevelRangeMin { get; set; }
        public byte LevelRangeMax { get; set; }
        public byte BountySetID { get; set; }
        public byte BountyBoardLocation { get; set; }
        [DBKey]
        public int ID { get; set; }
        public uint PlayerConditionID { get; set; }
    }

    [DBTable(24492)]
    public class WorldMapContinent
    {
        [DBKey]
        public int ID { get; set; }
        [DBField(ArraySize: 2)]
        public int[] Field04 { get; set; }
        public float Field0C { get; set; }
        [DBField(ArraySize: 2)]
        public int[] Field10 { get; set; }
        [DBField(ArraySize: 2)]
        public float[] Field18 { get; set; }
        public ushort Field20 { get; set; }
        public ushort Field22 { get; set; }
        public byte Field24 { get; set; }
        public byte Field25 { get; set; }
        public byte Field26 { get; set; }
        public byte Field27 { get; set; }
        public byte Field28 { get; set; }
    }

    [DBTable(24492)]
    public class WorldMapOverlay
    {
        [DBKey]
        public int ID { get; set; }
        public string TextureName { get; set; }
        public ushort TextureWidth { get; set; }
        public ushort TextureHeight { get; set; }
        public uint MapAreaID { get; set; }
        [DBField(ArraySize: 4)]
        public uint[] AreaID { get; set; }
        public int OffsetX { get; set; }
        public int OffsetY { get; set; }
        public int HitRectTop { get; set; }
        public int HitRectLeft { get; set; }
        public int HitRectBottom { get; set; }
        public int HitRectRight { get; set; }
        public uint PlayerConditionID { get; set; }
        public uint Flags { get; set; }
    }

    [DBTable(24492)]
    public class WorldMapTransforms
    {
        [DBKey]
        public int ID { get; set; }
        [DBField(ArraySize: 6)]
        public float[] Region { get; set; }
        [DBField(ArraySize: 2)]
        public float[] RegionOffset { get; set; }
        public float RegionScale { get; set; }
        public ushort MapID { get; set; }
        public ushort AreaID { get; set; }
        public ushort NewMapID { get; set; }
        public ushort NewDungeonMapID { get; set; }
        public ushort NewAreaID { get; set; }
        public byte Flags { get; set; }
    }

    [DBTable(24492)]
    public class WorldSafeLocs
    {
        [DBKey]
        public int ID { get; set; }
        [DBField(ArraySize: 3)]
        public float[] Loc { get; set; }
        public float Facing { get; set; }
        public string AreaName { get; set; }
        public ushort MapID { get; set; }
    }

    [DBTable(24492)]
    public class WorldState
    {
        [DBKey]
        public int ID { get; set; }
    }

    [DBTable(24492)]
    public class WorldStateExpression
    {
        [DBKey]
        public int ID { get; set; }
        public string Field4 { get; set; }
    }

    [DBTable(24492)]
    public class WorldStateUI
    {
        public string Field00 { get; set; }
        public int Field04 { get; set; }
        public string Field08 { get; set; }
        public string Field0C { get; set; }
        public string Field10 { get; set; }
        public string Field14 { get; set; }
        public ushort Field18 { get; set; }
        public ushort Field1A { get; set; }
        public ushort Field1C { get; set; }
        public ushort Field1E { get; set; }
        [DBField(ArraySize: 3)]
        public ushort[] Field20 { get; set; }
        public byte Field26 { get; set; }
        public byte Field27 { get; set; }
        public byte Field28 { get; set; }
        public byte Field29 { get; set; }
        [DBKey]
        public int ID { get; set; }
    }

    [DBTable(24492)]
    public class WorldStateZoneSounds
    {
        [DBKey]
        public int ID { get; set; }
        public uint Field04 { get; set; }
        public ushort Field08 { get; set; }
        public ushort Field0A { get; set; }
        public ushort Field0C { get; set; }
        public ushort Field0E { get; set; }
        public ushort Field10 { get; set; }
        public ushort Field12 { get; set; }
        public byte Field14 { get; set; }
    }

    [DBTable(24492)]
    public class ZoneIntroMusicTable
    {
        [DBKey]
        public int ID { get; set; }
        public string Field04 { get; set; }
        public ushort Field08 { get; set; }
        public byte Field0A { get; set; }
        public int Field0B { get; set; }
    }

    [DBTable(24492)]
    public class ZoneLight
    {
        [DBKey]
        public int ID { get; set; }
        public string Field04 { get; set; }
        public ushort Field08 { get; set; }
        public ushort Field0A { get; set; }
    }

    [DBTable(24492)]
    public class ZoneLightPoint
    {
        [DBKey]
        public int ID { get; set; }
        [DBField(ArraySize: 2)]
        public int[] Field04 { get; set; }
        public ushort Field0C { get; set; }
        public byte Field0E { get; set; }
    }

    [DBTable(24492)]
    public class ZoneMusic
    {
        [DBKey]
        public int ID { get; set; }
        public string Field04 { get; set; }
        [DBField(ArraySize: 2)]
        public uint[] Field08 { get; set; }
        [DBField(ArraySize: 2)]
        public uint[] Field10 { get; set; }
        public int Field18 { get; set; }
    }

}
