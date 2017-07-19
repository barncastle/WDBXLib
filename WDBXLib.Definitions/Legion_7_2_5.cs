using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WDBXLib.Attributes;

namespace WDBXLib.Definitions
{

    [DBTable(24461)]
    public class Achievement
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public uint Flags { get; set; }
        public string Reward { get; set; }
        public ushort MapID { get; set; }
        public ushort Supercedes { get; set; }
        public ushort Category { get; set; }
        public ushort UIOrder { get; set; }
        public ushort SharesCriteria { get; set; }
        public ushort CriteriaTree { get; set; }
        public byte Faction { get; set; }
        public byte Points { get; set; }
        public byte MinimumCriteria { get; set; }
        [DBKey]
        public int ID { get; set; }
        public uint IconFileDataID { get; set; }
    }

    [DBTable(24461)]
    public class Achievement_Category
    {
        public string Field0 { get; set; }
        public ushort Field4 { get; set; }
        public byte Field6 { get; set; }
        [DBKey]
        [DBField(ArraySize: 2)]
        public int[] ID { get; set; }
    }

    [DBTable(24461)]
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
        [DBField(ArraySize: 2)]
        public byte[] Field33 { get; set; }
        public byte Field35 { get; set; }
        public ushort Field36 { get; set; }
        public byte Field38 { get; set; }
    }

    [DBTable(24461)]
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

    [DBTable(24461)]
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

    [DBTable(24461)]
    public class AnimKit
    {
        [DBKey]
        public int ID { get; set; }
        public uint OneShotDuration { get; set; }
        public ushort OneShotStopAnimKitID { get; set; }
        public ushort LowDefAnimKitID { get; set; }
    }

    [DBTable(24461)]
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

    [DBTable(24461)]
    public class AnimKitBoneSetAlias
    {
        [DBKey]
        public int ID { get; set; }
        public byte Field4 { get; set; }
        public byte Field5 { get; set; }
    }

    [DBTable(24461)]
    public class AnimKitConfig
    {
        [DBKey]
        public int ID { get; set; }
        public uint Field4 { get; set; }
    }

    [DBTable(24461)]
    public class AnimKitConfigBoneSet
    {
        [DBKey]
        public int ID { get; set; }
        public ushort Field4 { get; set; }
        public ushort Field6 { get; set; }
        public byte Field8 { get; set; }
    }

    [DBTable(24461)]
    public class AnimKitPriority
    {
        [DBKey]
        public int ID { get; set; }
        public byte Field4 { get; set; }
    }

    [DBTable(24461)]
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

    [DBTable(24461)]
    public class AnimReplacement
    {
        public ushort Field0 { get; set; }
        public ushort Field2 { get; set; }
        public ushort Field4 { get; set; }
        public ushort Field6 { get; set; }
        [DBKey]
        public int ID { get; set; }
    }

    [DBTable(24461)]
    public class AnimReplacementSet
    {
        [DBKey]
        public int ID { get; set; }
        public byte Field4 { get; set; }
    }

    [DBTable(24461)]
    public class AreaAssignment
    {
        [DBKey]
        public int ID { get; set; }
        public ushort Field4 { get; set; }
        public ushort Field6 { get; set; }
        public byte Field8 { get; set; }
        public byte Field9 { get; set; }
    }

    [DBTable(24461)]
    public class AreaFarClipOverride
    {
        public int Field00 { get; set; }
        public float Field04 { get; set; }
        public float Field08 { get; set; }
        public int Field0C { get; set; }
        [DBKey]
        public int ID { get; set; }
    }

    [DBTable(24461)]
    public class AreaGroupMember
    {
        [DBKey]
        public int ID { get; set; }
        public ushort AreaGroupID { get; set; }
        public ushort AreaID { get; set; }
    }

    [DBTable(24461)]
    public class AreaPOI
    {
        [DBKey]
        public int ID { get; set; }
        public uint Field04 { get; set; }
        [DBField(ArraySize: 2)]
        public float[] Field08 { get; set; }
        public string Field10 { get; set; }
        public string Field14 { get; set; }
        public string Field18 { get; set; }
        public uint Field1C { get; set; }
        public ushort Field20 { get; set; }
        public ushort Field22 { get; set; }
        public ushort Field24 { get; set; }
        public ushort Field26 { get; set; }
        public byte Field28 { get; set; }
        public byte Field29 { get; set; }
        public ushort Field2A { get; set; }
        public ushort Field2C { get; set; }
    }

    [DBTable(24461)]
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

    [DBTable(24461)]
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

    [DBTable(24461)]
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

    [DBTable(24461)]
    public class AreaTriggerActionSet
    {
        [DBKey]
        public int ID { get; set; }
        public ushort Field4 { get; set; }
    }

    [DBTable(24461)]
    public class AreaTriggerBox
    {
        [DBKey]
        public int ID { get; set; }
        [DBField(ArraySize: 2)]
        public float[] Field4 { get; set; }
    }

    [DBTable(24461)]
    public class AreaTriggerCylinder
    {
        [DBKey]
        public int ID { get; set; }
        public float Field04 { get; set; }
        public float Field08 { get; set; }
        public float Field0C { get; set; }
    }

    [DBTable(24461)]
    public class AreaTriggerSphere
    {
        [DBKey]
        public int ID { get; set; }
        public float Field4 { get; set; }
    }

    [DBTable(24461)]
    public class ArmorLocation
    {
        [DBKey]
        public int ID { get; set; }
        [DBField(ArraySize: 5)]
        public float[] Modifier { get; set; }
    }

    [DBTable(24461)]
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

    [DBTable(24461)]
    public class ArtifactAppearance
    {
        public string Name { get; set; }
        public uint SwatchColor { get; set; }
        public float ModelDesaturation { get; set; }
        public float ModelAlpha { get; set; }
        public uint ShapeshiftDisplayID { get; set; }
        public ushort ArtifactAppearanceSetID { get; set; }
        public ushort Unknown { get; set; }
        public byte DisplayIndex { get; set; }
        public byte AppearanceModID { get; set; }
        public byte Flags { get; set; }
        public byte ModifiesShapeshiftFormDisplay { get; set; }
        [DBKey]
        public int ID { get; set; }
        public uint PlayerConditionID { get; set; }
        public uint ItemAppearanceID { get; set; }
        public uint AltItemAppearanceID { get; set; }
    }

    [DBTable(24461)]
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

    [DBTable(24461)]
    public class ArtifactCategory
    {
        [DBKey]
        public int ID { get; set; }
        public ushort ArtifactKnowledgeCurrencyID { get; set; }
        public ushort ArtifactKnowledgeMultiplierCurveID { get; set; }
    }

    [DBTable(24461)]
    public class ArtifactPower
    {
        [DBField(ArraySize: 2)]
        public float[] Pos { get; set; }
        public byte ArtifactID { get; set; }
        public byte Flags { get; set; }
        public byte MaxRank { get; set; }
        public byte ArtifactTier { get; set; }
        [DBKey]
        public int ID { get; set; }
        public int RelicType { get; set; }
    }

    [DBTable(24461)]
    public class ArtifactPowerLink
    {
        [DBKey]
        public int ID { get; set; }
        public ushort FromArtifactPowerID { get; set; }
        public ushort ToArtifactPowerID { get; set; }
    }

    [DBTable(24461)]
    public class ArtifactPowerPicker
    {
        [DBKey]
        public int ID { get; set; }
        public int Field00 { get; set; }
    }

    [DBTable(24461)]
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

    [DBTable(24461)]
    public class ArtifactQuestXP
    {
        [DBKey]
        public int ID { get; set; }
        [DBField(ArraySize: 10)]
        public uint[] Exp { get; set; }
    }

    [DBTable(24461)]
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

    [DBTable(24461)]
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

    [DBTable(24461)]
    public class AuctionHouse
    {
        [DBKey]
        public int ID { get; set; }
        public string Name { get; set; }
        public ushort FactionID { get; set; }
        public byte DepositRate { get; set; }
        public byte ConsignmentRate { get; set; }
    }

    [DBTable(24461)]
    public class BankBagSlotPrices
    {
        [DBKey]
        public int ID { get; set; }
        public uint Cost { get; set; }
    }

    [DBTable(24461)]
    public class BannedAddOns
    {
        [DBKey]
        public int ID { get; set; }
        public string Name { get; set; }
        public string Version { get; set; }
        public byte Flags { get; set; }
    }

    [DBTable(24461)]
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

    [DBTable(24461)]
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

    [DBTable(24461)]
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

    [DBTable(24461)]
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

    [DBTable(24461)]
    public class BattlePetAbilityState
    {
        [DBKey]
        public int ID { get; set; }
        public int Field04 { get; set; }
        public ushort Field08 { get; set; }
        public byte Field0A { get; set; }
    }

    [DBTable(24461)]
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

    [DBTable(24461)]
    public class BattlePetBreedQuality
    {
        [DBKey]
        public int ID { get; set; }
        public float Modifier { get; set; }
        public byte Quality { get; set; }
    }

    [DBTable(24461)]
    public class BattlePetBreedState
    {
        [DBKey]
        public int ID { get; set; }
        public ushort Value { get; set; }
        public byte BreedID { get; set; }
        public byte State { get; set; }
    }

    [DBTable(24461)]
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

    [DBTable(24461)]
    public class BattlePetNPCTeamMember
    {
        [DBKey]
        public int ID { get; set; }
        public uint Field4 { get; set; }
    }

    [DBTable(24461)]
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
        public uint CardModelSceneID { get; set; }
        public uint LoadoutModelSceneID { get; set; }
    }

    [DBTable(24461)]
    public class BattlePetSpeciesState
    {
        [DBKey]
        public int ID { get; set; }
        public int Value { get; set; }
        public ushort SpeciesID { get; set; }
        public byte State { get; set; }
    }

    [DBTable(24461)]
    public class BattlePetSpeciesXAbility
    {
        [DBKey]
        public int ID { get; set; }
        public ushort Field4 { get; set; }
        public ushort Field6 { get; set; }
        public byte Field8 { get; set; }
        public byte Field9 { get; set; }
    }

    [DBTable(24461)]
    public class BattlePetState
    {
        [DBKey]
        public int ID { get; set; }
        public string Field04 { get; set; }
        public ushort Field08 { get; set; }
        public ushort Field0A { get; set; }
    }

    [DBTable(24461)]
    public class BattlePetVisual
    {
        [DBKey]
        public int ID { get; set; }
        public uint Field04 { get; set; }
        public string Field08 { get; set; }
        public ushort Field0C { get; set; }
        public ushort Field0E { get; set; }
        public ushort Field10 { get; set; }
        public byte Field12 { get; set; }
        public byte Field13 { get; set; }
    }

    [DBTable(24461)]
    public class BoneWindModifierModel
    {
        [DBKey]
        public int ID { get; set; }
        public uint Field4 { get; set; }
        public uint Field8 { get; set; }
    }

    [DBTable(24461)]
    public class BoneWindModifiers
    {
        [DBKey]
        public int ID { get; set; }
        [DBField(ArraySize: 3)]
        public float[] Field04 { get; set; }
        public float Field10 { get; set; }
    }

    [DBTable(24461)]
    public class Bounty
    {
        [DBKey]
        public int ID { get; set; }
        public uint Field04 { get; set; }
        public ushort Field08 { get; set; }
        public ushort Field0A { get; set; }
        public byte Field0C { get; set; }
    }

    [DBTable(24461)]
    public class BountySet
    {
        [DBKey]
        public int ID { get; set; }
        public ushort Field4 { get; set; }
        public ushort Field6 { get; set; }
    }

    [DBTable(24461)]
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

    [DBTable(24461)]
    public class CameraEffect
    {
        [DBKey]
        public int ID { get; set; }
        public byte Field4 { get; set; }
    }

    [DBTable(24461)]
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

    [DBTable(24461)]
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

    [DBTable(24461)]
    public class CastableRaidBuffs
    {
        [DBKey]
        public int ID { get; set; }
        public ushort Field4 { get; set; }
        public ushort Field6 { get; set; }
    }

    [DBTable(24461)]
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

    [DBTable(24461)]
    public class Cfg_Configs
    {
        [DBKey]
        public int ID { get; set; }
        public float Field04 { get; set; }
        public ushort Field08 { get; set; }
        public byte Field0A { get; set; }
        public byte Field0B { get; set; }
    }

    [DBTable(24461)]
    public class Cfg_Regions
    {
        [DBKey]
        public int ID { get; set; }
        public string Field04 { get; set; }
        public uint Field08 { get; set; }
        public float Field0C { get; set; }
        public byte Field10 { get; set; }
        public byte Field11 { get; set; }
    }

    [DBTable(24461)]
    public class CharacterFaceBoneSet
    {
        [DBKey]
        public int ID { get; set; }
        public uint Field04 { get; set; }
        public byte Field08 { get; set; }
        public byte Field09 { get; set; }
        public byte Field0A { get; set; }
    }

    [DBTable(24461)]
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

    [DBTable(24461)]
    public class CharacterLoadout
    {
        [DBKey]
        public int ID { get; set; }
        public uint Field4 { get; set; }
        public byte Field8 { get; set; }
        public byte Field9 { get; set; }
    }

    [DBTable(24461)]
    public class CharacterLoadoutItem
    {
        [DBKey]
        public int ID { get; set; }
        public uint Field4 { get; set; }
        public ushort Field8 { get; set; }
    }

    [DBTable(24461)]
    public class CharBaseInfo
    {
        [DBKey]
        public int ID { get; set; }
        public byte Field4 { get; set; }
        public byte Field5 { get; set; }
    }

    [DBTable(24461)]
    public class CharBaseSection
    {
        [DBKey]
        public int ID { get; set; }
        public byte Field4 { get; set; }
        public byte Field5 { get; set; }
        public byte Field6 { get; set; }
    }

    [DBTable(24461)]
    public class CharComponentTextureLayouts
    {
        [DBKey]
        public int ID { get; set; }
        public ushort Field4 { get; set; }
        public ushort Field6 { get; set; }
    }

    [DBTable(24461)]
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

    [DBTable(24461)]
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

    [DBTable(24461)]
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

    [DBTable(24461)]
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
        public ushort Field1A { get; set; }
        public byte Field1C { get; set; }
        public byte Field1D { get; set; }
    }

    [DBTable(24461)]
    public class CharShipmentContainer
    {
        [DBKey]
        public int ID { get; set; }
        public string Field04 { get; set; }
        public string Field08 { get; set; }
        public uint Field0C { get; set; }
        public ushort Field10 { get; set; }
        public ushort Field12 { get; set; }
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
        public byte Field22 { get; set; }
    }

    [DBTable(24461)]
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

    [DBTable(24461)]
    public class CharTitles
    {
        [DBKey]
        public int ID { get; set; }
        public string NameMale { get; set; }
        public string NameFemale { get; set; }
        public ushort MaskID { get; set; }
        public byte Flags { get; set; }
    }

    [DBTable(24461)]
    public class ChatChannels
    {
        [DBKey]
        public int ID { get; set; }
        public uint Flags { get; set; }
        public string Name { get; set; }
        public string Shortcut { get; set; }
        public byte FactionGroup { get; set; }
    }

    [DBTable(24461)]
    public class ChatProfanity
    {
        [DBKey]
        public int ID { get; set; }
        public string Field4 { get; set; }
        public byte Field8 { get; set; }
    }

    [DBTable(24461)]
    public class ChrClasses
    {
        public string PetNameToken { get; set; }
        public string Name { get; set; }
        public string NameFemale { get; set; }
        public string NameMale { get; set; }
        public string Filename { get; set; }
        public uint CreateScreenFileDataID { get; set; }
        public uint SelectScreenFileDataID { get; set; }
        public uint IconFileDataID { get; set; }
        public uint LowResScreenFileDataID { get; set; }
        public ushort Flags { get; set; }
        public ushort CinematicSequenceID { get; set; }
        public ushort DefaultSpec { get; set; }
        public byte PowerType { get; set; }
        public byte SpellClassSet { get; set; }
        public byte AttackPowerPerStrength { get; set; }
        public byte AttackPowerPerAgility { get; set; }
        public byte RangedAttackPowerPerAgility { get; set; }
        public byte Unk1 { get; set; }
        [DBKey]
        public int ID { get; set; }
    }

    [DBTable(24461)]
    public class ChrClassesXPowerTypes
    {
        [DBKey]
        public int ID { get; set; }
        public byte ClassID { get; set; }
        public byte PowerType { get; set; }
    }

    [DBTable(24461)]
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

    [DBTable(24461)]
    public class ChrClassTitle
    {
        [DBKey]
        public int ID { get; set; }
        public string Field04 { get; set; }
        public string Field08 { get; set; }
        public byte Field0C { get; set; }
    }

    [DBTable(24461)]
    public class ChrClassUIDisplay
    {
        [DBKey]
        public int ID { get; set; }
        public byte Field4 { get; set; }
        public ushort Field5 { get; set; }
        public ushort Field7 { get; set; }
    }

    [DBTable(24461)]
    public class ChrClassVillain
    {
        [DBKey]
        public int ID { get; set; }
        public string Field4 { get; set; }
        public byte Field8 { get; set; }
        public byte Field9 { get; set; }
    }

    [DBTable(24461)]
    public class ChrRaces
    {
        [DBKey]
        public int ID { get; set; }
        public uint Flags { get; set; }
        public string ClientPrefix { get; set; }
        public string ClientFileString { get; set; }
        public string Name { get; set; }
        public string NameFemale { get; set; }
        public string NameMale { get; set; }
        [DBField(ArraySize: 2)]
        public string[] FacialHairCustomization { get; set; }
        public string HairCustomization { get; set; }
        public uint CreateScreenFileDataID { get; set; }
        public uint SelectScreenFileDataID { get; set; }
        [DBField(ArraySize: 3)]
        public float[] MaleCustomizeOffset { get; set; }
        [DBField(ArraySize: 3)]
        public float[] FemaleCustomizeOffset { get; set; }
        public uint LowResScreenFileDataID { get; set; }
        public ushort FactionID { get; set; }
        public ushort MaleDisplayID { get; set; }
        public ushort FemaleDisplayID { get; set; }
        public ushort ResSicknessSpellID { get; set; }
        public ushort SplashSoundID { get; set; }
        public ushort CinematicSequenceID { get; set; }
        public byte BaseLanguage { get; set; }
        public byte CreatureType { get; set; }
        public byte TeamID { get; set; }
        public byte RaceRelated { get; set; }
        public byte UnalteredVisualRaceID { get; set; }
        public byte CharComponentTextureLayoutID { get; set; }
        public byte DefaultClassID { get; set; }
        public byte NeutralRaceID { get; set; }
        public byte ItemAppearanceFrameRaceID { get; set; }
        public byte CharComponentTexLayoutHiResID { get; set; }
        public uint HighResMaleDisplayID { get; set; }
        public uint HighResFemaleDisplayID { get; set; }
        [DBField(ArraySize: 3)]
        public uint[] Unk { get; set; }
    }

    [DBTable(24461)]
    public class ChrSpecialization
    {
        [DBField(ArraySize: 2)]
        public uint[] MasterySpellID { get; set; }
        public string Name { get; set; }
        public string Name2 { get; set; }
        public string Description { get; set; }
        public byte ClassID { get; set; }
        public byte OrderIndex { get; set; }
        public byte PetTalentType { get; set; }
        public byte Role { get; set; }
        public byte PrimaryStatOrder { get; set; }
        [DBKey]
        public int ID { get; set; }
        public uint IconFileDataID { get; set; }
        public uint Flags { get; set; }
        public uint AnimReplacementSetID { get; set; }
    }

    [DBTable(24461)]
    public class ChrUpgradeBucket
    {
        public ushort Field0 { get; set; }
        public byte Field2 { get; set; }
        [DBKey]
        public int ID { get; set; }
    }

    [DBTable(24461)]
    public class ChrUpgradeBucketSpell
    {
        [DBKey]
        public int ID { get; set; }
        public uint Field4 { get; set; }
        public ushort Field8 { get; set; }
    }

    [DBTable(24461)]
    public class ChrUpgradeTier
    {
        public uint Field0 { get; set; }
        public byte Field4 { get; set; }
        public byte Field5 { get; set; }
        [DBKey]
        [DBField(ArraySize: 2)]
        public int[] ID { get; set; }
    }

    [DBTable(24461)]
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

    [DBTable(24461)]
    public class CinematicSequences
    {
        [DBKey]
        public int ID { get; set; }
        public uint SoundID { get; set; }
        [DBField(ArraySize: 8)]
        public ushort[] Camera { get; set; }
    }

    [DBTable(24461)]
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

    [DBTable(24461)]
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

    [DBTable(24461)]
    public class ComponentModelFileData
    {
        [DBKey]
        public int ID { get; set; }
        public byte Field4 { get; set; }
        public byte Field5 { get; set; }
        public byte Field6 { get; set; }
        public byte Field7 { get; set; }
    }

    [DBTable(24461)]
    public class ComponentTextureFileData
    {
        [DBKey]
        public int ID { get; set; }
        public byte Field4 { get; set; }
        public byte Field5 { get; set; }
        public byte Field6 { get; set; }
    }

    [DBTable(24461)]
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

    [DBTable(24461)]
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

    [DBTable(24461)]
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

    [DBTable(24461)]
    public class CreatureDisplayInfo
    {
        [DBKey]
        public int ID { get; set; }
        public float CreatureModelScale { get; set; }
        public ushort ModelID { get; set; }
        public ushort NPCSoundID { get; set; }
        public byte SizeClass { get; set; }
        public byte Flags { get; set; }
        public byte Gender { get; set; }
        public uint ExtendedDisplayInfoID { get; set; }
        [DBField(ArraySize: 3)]
        public uint[] TextureVariation { get; set; }
        public uint PortraitTextureFileDataID { get; set; }
        [DBField(DefaultValue: byte.MaxValue)]
        public byte CreatureModelAlpha { get; set; }
        public ushort SoundID { get; set; }
        public float PlayerModelScale { get; set; }
        public uint PortraitCreatureDisplayInfoID { get; set; }
        public byte BloodID { get; set; }
        public ushort ParticleColorID { get; set; }
        public uint CreatureGeosetData { get; set; }
        public ushort ObjectEffectPackageID { get; set; }
        public ushort AnimReplacementSetID { get; set; }
        [DBField(DefaultValue: byte.MaxValue)]
        public byte UnarmedWeaponSubclass { get; set; }
        public uint StateSpellVisualKitID { get; set; }
        public float InstanceOtherPlayerPetScale { get; set; }
        public uint MountSpellVisualKitID { get; set; }
    }

    [DBTable(24461)]
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

    [DBTable(24461)]
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

    [DBTable(24461)]
    public class CreatureDisplayInfoTrn
    {
        [DBKey]
        public int ID { get; set; }
        public uint Field04 { get; set; }
        public uint Field08 { get; set; }
        public uint Field0C { get; set; }
        public float Field10 { get; set; }
    }

    [DBTable(24461)]
    public class CreatureDispXUiCamera
    {
        [DBKey]
        public int ID { get; set; }
        public uint Field4 { get; set; }
        public ushort Field8 { get; set; }
    }

    [DBTable(24461)]
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

    [DBTable(24461)]
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
        [DBField(ArraySize: 15)]
        public ushort[] Field1A { get; set; }
    }

    [DBTable(24461)]
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

    [DBTable(24461)]
    public class CreatureMovementInfo
    {
        [DBKey]
        public int ID { get; set; }
        public float Field4 { get; set; }
    }

    [DBTable(24461)]
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

    [DBTable(24461)]
    public class CreatureType
    {
        [DBKey]
        public int ID { get; set; }
        public string Name { get; set; }
        public byte Flags { get; set; }
    }

    [DBTable(24461)]
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

    [DBTable(24461)]
    public class CriteriaTree
    {
        [DBKey]
        public int ID { get; set; }
        public uint Amount { get; set; }
        public string Description { get; set; }
        public ushort Parent { get; set; }
        public ushort Flags { get; set; }
        public byte Operator { get; set; }
        public uint CriteriaID { get; set; }
        public int OrderIndex { get; set; }
    }

    [DBTable(24461)]
    public class CriteriaTreeXEffect
    {
        [DBKey]
        public int ID { get; set; }
        public ushort Field4 { get; set; }
        public ushort Field6 { get; set; }
    }

    [DBTable(24461)]
    public class CurrencyCategory
    {
        [DBKey]
        public int ID { get; set; }
        public string Field4 { get; set; }
        public byte Field8 { get; set; }
        public byte Field9 { get; set; }
    }

    [DBTable(24461)]
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

    [DBTable(24461)]
    public class Curve
    {
        [DBKey]
        public int ID { get; set; }
        public byte Type { get; set; }
        public byte Unused { get; set; }
    }

    [DBTable(24461)]
    public class CurvePoint
    {
        [DBKey]
        public int ID { get; set; }
        [DBField(ArraySize: 2)]
        public float[] Position { get; set; }
        public ushort CurveID { get; set; }
        public byte Index { get; set; }
    }

    [DBTable(24461)]
    public class DeathThudLookups
    {
        [DBKey]
        public int ID { get; set; }
        public byte Field4 { get; set; }
        public byte Field5 { get; set; }
        public ushort Field6 { get; set; }
        public ushort Field8 { get; set; }
    }

    [DBTable(24461)]
    public class DecalProperties
    {
        [DBKey]
        public int ID { get; set; }
        public uint Field04 { get; set; }
        public int Field08 { get; set; }
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
        public byte Field2F { get; set; }
        [DBField(ArraySize: 4)]
        public byte[] Field30 { get; set; }
    }

    [DBTable(24461)]
    public class DeclinedWord
    {
        public uint Field0 { get; set; }
        [DBKey]
        [DBField(ArraySize: 4)]
        public int[] ID { get; set; }
    }

    [DBTable(24461)]
    public class DeclinedWordCases
    {
        [DBKey]
        public int ID { get; set; }
        public uint Field4 { get; set; }
        public byte Field8 { get; set; }
        public byte Field9 { get; set; }
    }

    [DBTable(24461)]
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

    [DBTable(24461)]
    public class DeviceBlacklist
    {
        [DBKey]
        public int ID { get; set; }
        public ushort Field4 { get; set; }
        public ushort Field6 { get; set; }
    }

    [DBTable(24461)]
    public class DeviceDefaultSettings
    {
        [DBKey]
        public int ID { get; set; }
        public ushort Field4 { get; set; }
        public ushort Field6 { get; set; }
        public byte Field8 { get; set; }
    }

    [DBTable(24461)]
    public class Difficulty
    {
        [DBKey]
        public int ID { get; set; }
        public string Name { get; set; }
        public ushort GroupSizeHealthCurveID { get; set; }
        public ushort GroupSizeDmgCurveID { get; set; }
        public ushort GroupSizeSpellPointsCurveID { get; set; }
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

    [DBTable(24461)]
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

    [DBTable(24461)]
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

    [DBTable(24461)]
    public class DungeonEncounter
    {
        public string Name { get; set; }
        public uint CreatureDisplayID { get; set; }
        public ushort MapID { get; set; }
        public byte DifficultyID { get; set; }
        public byte Bit { get; set; }
        public byte Flags { get; set; }
        [DBKey]
        public int ID { get; set; }
        public int OrderIndex { get; set; }
        public uint TextureFileDataID { get; set; }
    }

    [DBTable(24461)]
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
        public byte Field16 { get; set; }
        [DBKey]
        [DBField(ArraySize: 2)]
        public int[] ID { get; set; }
    }

    [DBTable(24461)]
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

    [DBTable(24461)]
    public class DurabilityCosts
    {
        [DBKey]
        public int ID { get; set; }
        [DBField(ArraySize: 21)]
        public ushort[] WeaponSubClassCost { get; set; }
        [DBField(ArraySize: 8)]
        public ushort[] ArmorSubClassCost { get; set; }
    }

    [DBTable(24461)]
    public class DurabilityQuality
    {
        [DBKey]
        public int ID { get; set; }
        public float QualityMod { get; set; }
    }

    [DBTable(24461)]
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

    [DBTable(24461)]
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

    [DBTable(24461)]
    public class EmotesText
    {
        [DBKey]
        public int ID { get; set; }
        public string Name { get; set; }
        public ushort EmoteID { get; set; }
    }

    [DBTable(24461)]
    public class EmotesTextData
    {
        [DBKey]
        public int ID { get; set; }
        public string Field04 { get; set; }
        public ushort Field08 { get; set; }
        public byte Field0A { get; set; }
    }

    [DBTable(24461)]
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

    [DBTable(24461)]
    public class EnvironmentalDamage
    {
        [DBKey]
        public int ID { get; set; }
        public ushort Field4 { get; set; }
        public byte Field6 { get; set; }
    }

    [DBTable(24461)]
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

    [DBTable(24461)]
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
        public int ReputationIndex { get; set; }
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

    [DBTable(24461)]
    public class FactionGroup
    {
        [DBKey]
        public int ID { get; set; }
        public string Field04 { get; set; }
        public string Field08 { get; set; }
        public byte Field0C { get; set; }
    }

    [DBTable(24461)]
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

    [DBTable(24461)]
    public class FootprintTextures
    {
        [DBKey]
        public int ID { get; set; }
        public ushort Field4 { get; set; }
        public byte Field6 { get; set; }
        public int Field7 { get; set; }
    }

    [DBTable(24461)]
    public class FootstepTerrainLookup
    {
        [DBKey]
        public int ID { get; set; }
        public ushort Field04 { get; set; }
        public byte Field06 { get; set; }
        public int Field07 { get; set; }
        public int Field0A { get; set; }
    }

    [DBTable(24461)]
    public class FriendshipRepReaction
    {
        [DBKey]
        public int ID { get; set; }
        public string Field04 { get; set; }
        public ushort Field08 { get; set; }
        public byte Field0A { get; set; }
    }

    [DBTable(24461)]
    public class FriendshipReputation
    {
        public uint Field00 { get; set; }
        public string Field04 { get; set; }
        public ushort Field08 { get; set; }
        [DBKey]
        [DBField(ArraySize: 2)]
        public int[] ID { get; set; }
    }

    [DBTable(24461)]
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
        public int Field058 { get; set; }
        public float Field05C { get; set; }
        public float Field060 { get; set; }
        public float Field064 { get; set; }
        public int Field068 { get; set; }
        public float Field06C { get; set; }
        public float Field070 { get; set; }
        public float Field074 { get; set; }
        public float Field078 { get; set; }
        public float Field07C { get; set; }
        public uint Field080 { get; set; }
        public uint Field084 { get; set; }
        public float Field088 { get; set; }
        public float Field08C { get; set; }
        public byte Field090 { get; set; }
        public byte Field091 { get; set; }
        public ushort Field092 { get; set; }
        public ushort Field094 { get; set; }
    }

    [DBTable(24461)]
    public class GameObjectArtKit
    {
        [DBKey]
        public int ID { get; set; }
        [DBField(ArraySize: 3)]
        public string[] Field04 { get; set; }
        [DBField(ArraySize: 3)]
        public string[] Field10 { get; set; }
    }

    [DBTable(24461)]
    public class GameObjectDiffAnimMap
    {
        [DBKey]
        public int ID { get; set; }
        public ushort Field4 { get; set; }
        public byte Field6 { get; set; }
        public byte Field7 { get; set; }
        public byte Field8 { get; set; }
    }

    [DBTable(24461)]
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

    [DBTable(24461)]
    public class GameObjectDisplayInfoXSoundKit
    {
        [DBKey]
        public int ID { get; set; }
        public byte Field4 { get; set; }
        public int Field5 { get; set; }
        public ushort Field8 { get; set; }
    }

    [DBTable(24461)]
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

    [DBTable(24461)]
    public class GameTips
    {
        [DBKey]
        public int ID { get; set; }
        public string Field04 { get; set; }
        public ushort Field08 { get; set; }
        public ushort Field0A { get; set; }
        public byte Field0C { get; set; }
    }

    [DBTable(24461)]
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

    [DBTable(24461)]
    public class GarrAbilityCategory
    {
        [DBKey]
        public int ID { get; set; }
        public string Field4 { get; set; }
    }

    [DBTable(24461)]
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

    [DBTable(24461)]
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

    [DBTable(24461)]
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

    [DBTable(24461)]
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

    [DBTable(24461)]
    public class GarrClassSpec
    {
        public string NameMale { get; set; }
        public string NameFemale { get; set; }
        public string NameGenderless { get; set; }
        public ushort ClassAtlasID { get; set; }
        public ushort GarrFollItemSetID { get; set; }
        public byte Limit { get; set; }
        public byte Flags { get; set; }
        [DBKey]
        public int ID { get; set; }
    }

    [DBTable(24461)]
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

    [DBTable(24461)]
    public class GarrEncounter
    {
        public uint Field00 { get; set; }
        public string Field04 { get; set; }
        public float Field08 { get; set; }
        public float Field0C { get; set; }
        public uint Field10 { get; set; }
        [DBKey]
        public int ID { get; set; }
        [DBField(ArraySize: 2)]
        public byte[] Field16 { get; set; }
    }

    [DBTable(24461)]
    public class GarrEncounterSetXEncounter
    {
        [DBKey]
        public int ID { get; set; }
        public byte Field4 { get; set; }
        public ushort Field5 { get; set; }
    }

    [DBTable(24461)]
    public class GarrEncounterXMechanic
    {
        [DBKey]
        public int ID { get; set; }
        public ushort Field4 { get; set; }
        public byte Field6 { get; set; }
        public byte Field7 { get; set; }
    }

    [DBTable(24461)]
    public class GarrFollItemSetMember
    {
        [DBKey]
        public int ID { get; set; }
        public uint Field04 { get; set; }
        public ushort Field08 { get; set; }
        public ushort Field0A { get; set; }
        public byte Field0C { get; set; }
    }

    [DBTable(24461)]
    public class GarrFollower
    {
        public uint HordeCreatureID { get; set; }
        public uint AllianceCreatureID { get; set; }
        public string HordeSourceText { get; set; }
        public string AllianceSourceText { get; set; }
        public uint HordePortraitIconID { get; set; }
        public uint AlliancePortraitIconID { get; set; }
        public uint HordeAddedBroadcastTextID { get; set; }
        public uint AllianceAddedBroadcastTextID { get; set; }
        public string Name { get; set; }
        public ushort HordeGarrFollItemSetID { get; set; }
        public ushort AllianceGarrFollItemSetID { get; set; }
        public ushort ItemLevelWeapon { get; set; }
        public ushort ItemLevelArmor { get; set; }
        public ushort HordeListPortraitTextureKitID { get; set; }
        public ushort AllianceListPortraitTextureKitID { get; set; }
        public byte FollowerTypeID { get; set; }
        public byte HordeUiAnimRaceInfoID { get; set; }
        public byte AllianceUiAnimRaceInfoID { get; set; }
        public byte Quality { get; set; }
        public byte HordeGarrClassSpecID { get; set; }
        public byte AllianceGarrClassSpecID { get; set; }
        public byte Level { get; set; }
        public byte Unknown1 { get; set; }
        public byte Flags { get; set; }
        public byte Unknown2 { get; set; }
        public byte Unknown3 { get; set; }
        public byte GarrTypeID { get; set; }
        public byte MaxDurability { get; set; }
        public byte Class { get; set; }
        public byte HordeFlavorTextGarrStringID { get; set; }
        public byte AllianceFlavorTextGarrStringID { get; set; }
        [DBKey]
        public int ID { get; set; }
    }

    [DBTable(24461)]
    public class GarrFollowerLevelXP
    {
        [DBKey]
        public int ID { get; set; }
        public ushort Field4 { get; set; }
        public ushort Field6 { get; set; }
        public byte Field8 { get; set; }
        public byte Field9 { get; set; }
    }

    [DBTable(24461)]
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

    [DBTable(24461)]
    public class GarrFollowerSetXFollower
    {
        [DBKey]
        public int ID { get; set; }
        public byte Field4 { get; set; }
        public byte Field5 { get; set; }
    }

    [DBTable(24461)]
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

    [DBTable(24461)]
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

    [DBTable(24461)]
    public class GarrFollowerXAbility
    {
        [DBKey]
        public int ID { get; set; }
        public ushort GarrFollowerID { get; set; }
        public ushort GarrAbilityID { get; set; }
        public byte FactionIndex { get; set; }
    }

    [DBTable(24461)]
    public class GarrFollSupportSpell
    {
        [DBKey]
        public int ID { get; set; }
        public uint Field04 { get; set; }
        public uint Field08 { get; set; }
        public byte Field0C { get; set; }
        public ushort Field0D { get; set; }
    }

    [DBTable(24461)]
    public class GarrMechanic
    {
        [DBKey]
        public int ID { get; set; }
        public uint Field4 { get; set; }
        public byte Field8 { get; set; }
        public ushort Field9 { get; set; }
    }

    [DBTable(24461)]
    public class GarrMechanicSetXMechanic
    {
        public byte Field0 { get; set; }
        [DBKey]
        public int ID { get; set; }
        public byte Field2 { get; set; }
    }

    [DBTable(24461)]
    public class GarrMechanicType
    {
        public string Field00 { get; set; }
        public string Field04 { get; set; }
        public uint Field08 { get; set; }
        public byte Field0C { get; set; }
        [DBKey]
        public int ID { get; set; }
    }

    [DBTable(24461)]
    public class GarrMission
    {
        public uint Field00 { get; set; }
        public uint Field04 { get; set; }
        public string Field08 { get; set; }
        public string Field0C { get; set; }
        public string Field10 { get; set; }
        [DBField(ArraySize: 2)]
        public float[] Field14 { get; set; }
        [DBField(ArraySize: 2)]
        public int[] Field1C { get; set; }
        public ushort Field24 { get; set; }
        public ushort Field26 { get; set; }
        public ushort Field28 { get; set; }
        public byte Field2A { get; set; }
        public byte Field2B { get; set; }
        public byte Field2C { get; set; }
        public byte Field2D { get; set; }
        public byte Field2E { get; set; }
        public byte Field2F { get; set; }
        public byte Field30 { get; set; }
        public byte Field31 { get; set; }
        public byte Field32 { get; set; }
        [DBKey]
        public int ID { get; set; }
        public byte Field35 { get; set; }
        public ushort Field36 { get; set; }
        public byte Field38 { get; set; }
        public ushort Field39 { get; set; }
        public ushort Field3B { get; set; }
        public ushort Field3D { get; set; }
        public ushort Field3F { get; set; }
        public ushort Field41 { get; set; }
        public byte Field43 { get; set; }
    }

    [DBTable(24461)]
    public class GarrMissionTexture
    {
        [DBKey]
        public int ID { get; set; }
        [DBField(ArraySize: 2)]
        public float[] Field04 { get; set; }
        public ushort Field0C { get; set; }
    }

    [DBTable(24461)]
    public class GarrMissionType
    {
        [DBKey]
        public int ID { get; set; }
        public string Field04 { get; set; }
        public ushort Field08 { get; set; }
        public ushort Field0A { get; set; }
    }

    [DBTable(24461)]
    public class GarrMissionXEncounter
    {
        public byte Field0 { get; set; }
        [DBKey]
        public int ID { get; set; }
        public ushort Field3 { get; set; }
        public ushort Field5 { get; set; }
        public byte Field7 { get; set; }
    }

    [DBTable(24461)]
    public class GarrMissionXFollower
    {
        [DBKey]
        public int ID { get; set; }
        public ushort Field4 { get; set; }
        public ushort Field6 { get; set; }
        public byte Field8 { get; set; }
    }

    [DBTable(24461)]
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

    [DBTable(24461)]
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

    [DBTable(24461)]
    public class GarrPlotBuilding
    {
        [DBKey]
        public int ID { get; set; }
        public byte GarrPlotID { get; set; }
        public byte GarrBuildingID { get; set; }
    }

    [DBTable(24461)]
    public class GarrPlotInstance
    {
        [DBKey]
        public int ID { get; set; }
        public string Name { get; set; }
        public byte GarrPlotID { get; set; }
    }

    [DBTable(24461)]
    public class GarrPlotUICategory
    {
        [DBKey]
        public int ID { get; set; }
        public string Field4 { get; set; }
        public byte Field8 { get; set; }
    }

    [DBTable(24461)]
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
        public ushort UpgradeMoneyCost { get; set; }
        public byte Level { get; set; }
        public byte UITextureKitID { get; set; }
        public byte Level2 { get; set; }
    }

    [DBTable(24461)]
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

    [DBTable(24461)]
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

    [DBTable(24461)]
    public class GarrString
    {
        [DBKey]
        public int ID { get; set; }
        public string Field4 { get; set; }
    }

    [DBTable(24461)]
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

    [DBTable(24461)]
    public class GarrTalentTree
    {
        [DBKey]
        public int ID { get; set; }
        public byte Field4 { get; set; }
        public byte Field5 { get; set; }
        public byte Field6 { get; set; }
        public byte Field7 { get; set; }
    }

    [DBTable(24461)]
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

    [DBTable(24461)]
    public class GarrUiAnimClassInfo
    {
        [DBKey]
        public int ID { get; set; }
        public uint Field04 { get; set; }
        public float Field08 { get; set; }
        public byte Field0C { get; set; }
        public byte Field0D { get; set; }
    }

    [DBTable(24461)]
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

    [DBTable(24461)]
    public class GemProperties
    {
        [DBKey]
        public int ID { get; set; }
        public uint Type { get; set; }
        public ushort EnchantID { get; set; }
        public ushort MinItemLevel { get; set; }
    }

    [DBTable(24461)]
    public class GlobalStrings
    {
        [DBKey]
        public int ID { get; set; }
        public string Field04 { get; set; }
        public string Field08 { get; set; }
        public byte Field0C { get; set; }
    }

    [DBTable(24461)]
    public class GlyphBindableSpell
    {
        [DBKey]
        public int ID { get; set; }
        public uint SpellID { get; set; }
        public ushort GlyphPropertiesID { get; set; }
    }

    [DBTable(24461)]
    public class GlyphExclusiveCategory
    {
        [DBKey]
        public int ID { get; set; }
        public string Field4 { get; set; }
    }

    [DBTable(24461)]
    public class GlyphProperties
    {
        [DBKey]
        public int ID { get; set; }
        public uint SpellID { get; set; }
        public ushort SpellIconID { get; set; }
        public byte Type { get; set; }
        public byte GlyphExclusiveCategoryID { get; set; }
    }

    [DBTable(24461)]
    public class GlyphRequiredSpec
    {
        [DBKey]
        public int ID { get; set; }
        public ushort GlyphPropertiesID { get; set; }
        public ushort ChrSpecializationID { get; set; }
    }

    [DBTable(24461)]
    public class GMSurveyAnswers
    {
        [DBKey]
        public int ID { get; set; }
        public string Field4 { get; set; }
        public byte Field8 { get; set; }
        public byte Field9 { get; set; }
    }

    [DBTable(24461)]
    public class GMSurveyCurrentSurvey
    {
        [DBKey]
        public int ID { get; set; }
        public byte Field4 { get; set; }
    }

    [DBTable(24461)]
    public class GMSurveyQuestions
    {
        [DBKey]
        public int ID { get; set; }
        public string Field4 { get; set; }
    }

    [DBTable(24461)]
    public class GMSurveySurveys
    {
        [DBKey]
        public int ID { get; set; }
        [DBField(ArraySize: 11)]
        public byte[] Field4 { get; set; }
    }

    [DBTable(24461)]
    public class GroundEffectDoodad
    {
        [DBKey]
        public int ID { get; set; }
        public string Field04 { get; set; }
        public float Field08 { get; set; }
        public float Field0C { get; set; }
        public byte Field10 { get; set; }
    }

    [DBTable(24461)]
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

    [DBTable(24461)]
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

    [DBTable(24461)]
    public class GroupFinderActivityGrp
    {
        [DBKey]
        public int ID { get; set; }
        public string Field4 { get; set; }
        public byte Field8 { get; set; }
    }

    [DBTable(24461)]
    public class GroupFinderCategory
    {
        [DBKey]
        public int ID { get; set; }
        public string Field4 { get; set; }
        public byte Field8 { get; set; }
        public byte Field9 { get; set; }
    }

    [DBTable(24461)]
    public class GuildColorBackground
    {
        [DBKey]
        public int ID { get; set; }
        public byte Red { get; set; }
        public byte Green { get; set; }
        public byte Blue { get; set; }
    }

    [DBTable(24461)]
    public class GuildColorBorder
    {
        [DBKey]
        public int ID { get; set; }
        public byte Red { get; set; }
        public byte Green { get; set; }
        public byte Blue { get; set; }
    }

    [DBTable(24461)]
    public class GuildColorEmblem
    {
        [DBKey]
        public int ID { get; set; }
        public byte Red { get; set; }
        public byte Green { get; set; }
        public byte Blue { get; set; }
    }

    [DBTable(24461)]
    public class GuildPerkSpells
    {
        [DBKey]
        public int ID { get; set; }
        public uint SpellID { get; set; }
    }

    [DBTable(24461)]
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

    [DBTable(24461)]
    public class HelmetAnimScaling
    {
        [DBKey]
        public int ID { get; set; }
        public float Field04 { get; set; }
        public ushort Field08 { get; set; }
        public byte Field0A { get; set; }
    }

    [DBTable(24461)]
    public class HelmetGeosetVisData
    {
        [DBKey]
        public int ID { get; set; }
        [DBField(ArraySize: 8)]
        public int[] Field4 { get; set; }
    }

    [DBTable(24461)]
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

    [DBTable(24461)]
    public class HolidayDescriptions
    {
        [DBKey]
        public int ID { get; set; }
        public string Field4 { get; set; }
    }

    [DBTable(24461)]
    public class HolidayNames
    {
        [DBKey]
        public int ID { get; set; }
        public string Field4 { get; set; }
    }

    [DBTable(24461)]
    public class Holidays
    {
        [DBKey]
        public int ID { get; set; }
        [DBField(ArraySize: 16)]
        public uint[] Date { get; set; }
        public string TextureFilename { get; set; }
        [DBField(ArraySize: 10)]
        public ushort[] Duration { get; set; }
        public ushort Region { get; set; }
        public byte Looping { get; set; }
        [DBField(ArraySize: 10)]
        public byte[] CalendarFlags { get; set; }
        public byte Priority { get; set; }
        public byte CalendarFilterType { get; set; }
        public byte Flags { get; set; }
        public uint HolidayNameID { get; set; }
        public uint HolidayDescriptionID { get; set; }
    }

    [DBTable(24461)]
    public class ImportPriceArmor
    {
        [DBKey]
        public int ID { get; set; }
        public float ClothFactor { get; set; }
        public float LeatherFactor { get; set; }
        public float MailFactor { get; set; }
        public float PlateFactor { get; set; }
    }

    [DBTable(24461)]
    public class ImportPriceQuality
    {
        [DBKey]
        public int ID { get; set; }
        public float Factor { get; set; }
    }

    [DBTable(24461)]
    public class ImportPriceShield
    {
        [DBKey]
        public int ID { get; set; }
        public float Factor { get; set; }
    }

    [DBTable(24461)]
    public class ImportPriceWeapon
    {
        [DBKey]
        public int ID { get; set; }
        public float Factor { get; set; }
    }

    [DBTable(24461)]
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

    [DBTable(24461)]
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

    [DBTable(24461)]
    public class ItemAppearance
    {
        [DBKey]
        public int ID { get; set; }
        public uint DisplayID { get; set; }
        public uint IconFileDataID { get; set; }
        public uint UIOrder { get; set; }
        public byte ObjectComponentSlot { get; set; }
    }

    [DBTable(24461)]
    public class ItemAppearanceXUiCamera
    {
        [DBKey]
        public int ID { get; set; }
        public ushort Field4 { get; set; }
        public ushort Field6 { get; set; }
    }

    [DBTable(24461)]
    public class ItemArmorQuality
    {
        [DBKey]
        public int ID { get; set; }
        [DBField(ArraySize: 7)]
        public float[] QualityMod { get; set; }
        public ushort ItemLevel { get; set; }
    }

    [DBTable(24461)]
    public class ItemArmorShield
    {
        [DBKey]
        public int ID { get; set; }
        [DBField(ArraySize: 7)]
        public float[] Quality { get; set; }
        public ushort ItemLevel { get; set; }
    }

    [DBTable(24461)]
    public class ItemArmorTotal
    {
        [DBKey]
        public int ID { get; set; }
        [DBField(ArraySize: 4)]
        public float[] Value { get; set; }
        public ushort ItemLevel { get; set; }
    }

    [DBTable(24461)]
    public class ItemBagFamily
    {
        [DBKey]
        public int ID { get; set; }
        public string Name { get; set; }
    }

    [DBTable(24461)]
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

    [DBTable(24461)]
    public class ItemBonusListLevelDelta
    {
        public ushort Delta { get; set; }
        [DBKey]
        public int ID { get; set; }
    }

    [DBTable(24461)]
    public class ItemBonusTreeNode
    {
        [DBKey]
        public int ID { get; set; }
        public ushort BonusTreeID { get; set; }
        public ushort SubTreeID { get; set; }
        public ushort BonusListID { get; set; }
        public ushort ItemLevelSelectorID { get; set; }
        public byte BonusTreeModID { get; set; }
    }

    [DBTable(24461)]
    public class ItemChildEquipment
    {
        [DBKey]
        public int ID { get; set; }
        public uint ItemID { get; set; }
        public uint AltItemID { get; set; }
        public byte AltEquipmentSlot { get; set; }
    }

    [DBTable(24461)]
    public class ItemClass
    {
        [DBKey]
        public int ID { get; set; }
        public float PriceMod { get; set; }
        public string Name { get; set; }
        public byte OldEnumValue { get; set; }
        public byte Flags { get; set; }
    }

    [DBTable(24461)]
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

    [DBTable(24461)]
    public class ItemCurrencyCost
    {
        [DBKey]
        public int ID { get; set; }
        public uint ItemId { get; set; }
    }

    [DBTable(24461)]
    public class ItemDamageAmmo
    {
        [DBKey]
        public int ID { get; set; }
        [DBField(ArraySize: 7)]
        public float[] DPS { get; set; }
        public ushort ItemLevel { get; set; }
    }

    [DBTable(24461)]
    public class ItemDamageOneHand
    {
        [DBKey]
        public int ID { get; set; }
        [DBField(ArraySize: 7)]
        public float[] DPS { get; set; }
        public ushort ItemLevel { get; set; }
    }

    [DBTable(24461)]
    public class ItemDamageOneHandCaster
    {
        [DBKey]
        public int ID { get; set; }
        [DBField(ArraySize: 7)]
        public float[] DPS { get; set; }
        public ushort ItemLevel { get; set; }
    }

    [DBTable(24461)]
    public class ItemDamageTwoHand
    {
        [DBKey]
        public int ID { get; set; }
        [DBField(ArraySize: 7)]
        public float[] DPS { get; set; }
        public ushort ItemLevel { get; set; }
    }

    [DBTable(24461)]
    public class ItemDamageTwoHandCaster
    {
        [DBKey]
        public int ID { get; set; }
        [DBField(ArraySize: 7)]
        public float[] DPS { get; set; }
        public ushort ItemLevel { get; set; }
    }

    [DBTable(24461)]
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

    [DBTable(24461)]
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

    [DBTable(24461)]
    public class ItemDisplayInfoMaterialRes
    {
        [DBKey]
        public int ID { get; set; }
        public uint Field04 { get; set; }
        public uint Field08 { get; set; }
        public byte Field0C { get; set; }
    }

    [DBTable(24461)]
    public class ItemDisplayXUiCamera
    {
        [DBKey]
        public int ID { get; set; }
        public uint Field4 { get; set; }
        public ushort Field8 { get; set; }
    }

    [DBTable(24461)]
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

    [DBTable(24461)]
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

    [DBTable(24461)]
    public class ItemGroupSounds
    {
        [DBKey]
        public int ID { get; set; }
        [DBField(ArraySize: 2)]
        public ushort[] Field4 { get; set; }
    }

    [DBTable(24461)]
    public class ItemLimitCategory
    {
        [DBKey]
        public int ID { get; set; }
        public string Name { get; set; }
        public byte Quantity { get; set; }
        public byte Flags { get; set; }
    }

    [DBTable(24461)]
    public class ItemLimitCategoryCondition
    {
        [DBKey]
        public int ID { get; set; }
        public byte Field4 { get; set; }
        public ushort Field5 { get; set; }
        public ushort Field7 { get; set; }
    }

    [DBTable(24461)]
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

    [DBTable(24461)]
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

    [DBTable(24461)]
    public class ItemNameDescription
    {
        [DBKey]
        public int ID { get; set; }
        public string Field4 { get; set; }
        public int Field8 { get; set; }
    }

    [DBTable(24461)]
    public class ItemPetFood
    {
        [DBKey]
        public int ID { get; set; }
        public string Field4 { get; set; }
    }

    [DBTable(24461)]
    public class ItemPriceBase
    {
        [DBKey]
        public int ID { get; set; }
        public float ArmorFactor { get; set; }
        public float WeaponFactor { get; set; }
        public ushort ItemLevel { get; set; }
    }

    [DBTable(24461)]
    public class ItemRandomProperties
    {
        [DBKey]
        public int ID { get; set; }
        public string Name { get; set; }
        [DBField(ArraySize: 5)]
        public ushort[] Enchantment { get; set; }
    }

    [DBTable(24461)]
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

    [DBTable(24461)]
    public class ItemRangedDisplayInfo
    {
        [DBKey]
        public int ID { get; set; }
        public ushort Field4 { get; set; }
        public byte Field6 { get; set; }
        public ushort Field7 { get; set; }
        public ushort Field9 { get; set; }
    }

    [DBTable(24461)]
    public class ItemSearchName
    {
        [DBKey]
        public int ID { get; set; }
        public string Name { get; set; }
        [DBField(ArraySize: 3)]
        public uint[] Flags { get; set; }
        public uint AllowableRace { get; set; }
        public uint RequiredSpell { get; set; }
        public ushort RequiredReputationFaction { get; set; }
        public ushort RequiredSkill { get; set; }
        public ushort RequiredSkillRank { get; set; }
        public ushort ItemLevel { get; set; }
        public byte Quality { get; set; }
        public byte RequiredExpansion { get; set; }
        public byte RequiredReputationRank { get; set; }
        public byte RequiredLevel { get; set; }
        public int AllowableClass { get; set; }
    }

    [DBTable(24461)]
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

    [DBTable(24461)]
    public class ItemSetSpell
    {
        [DBKey]
        public int ID { get; set; }
        public uint SpellID { get; set; }
        public ushort ItemSetID { get; set; }
        public ushort ChrSpecID { get; set; }
        public byte Threshold { get; set; }
    }

    [DBTable(24461)]
    public class ItemSparse
    {
        [DBKey]
        public int ID { get; set; }
        [DBField(ArraySize: 3)]
        public uint[] Flags { get; set; }
        public float Unk1 { get; set; }
        public float Unk2 { get; set; }
        public uint BuyCount { get; set; }
        public uint BuyPrice { get; set; }
        public uint SellPrice { get; set; }
        public int AllowableRace { get; set; }
        public uint RequiredSpell { get; set; }
        public uint MaxCount { get; set; }
        public uint Stackable { get; set; }
        [DBField(ArraySize: 10)]
        public int[] ItemStatAllocation { get; set; }
        [DBField(ArraySize: 10)]
        public float[] ItemStatSocketCostMultiplier { get; set; }
        public float RangedModRange { get; set; }
        public string Name { get; set; }
        public string Name2 { get; set; }
        public string Name3 { get; set; }
        public string Name4 { get; set; }
        public string Description { get; set; }
        public uint BagFamily { get; set; }
        public float ArmorDamageModifier { get; set; }
        public uint Duration { get; set; }
        public float StatScalingFactor { get; set; }
        public ushort AllowableClass { get; set; }
        public ushort ItemLevel { get; set; }
        public ushort RequiredSkill { get; set; }
        public ushort RequiredSkillRank { get; set; }
        public ushort RequiredReputationFaction { get; set; }
        [DBField(ArraySize: 10)]
        public ushort[] ItemStatValue { get; set; }
        public ushort ScalingStatDistribution { get; set; }
        public ushort Delay { get; set; }
        public ushort PageText { get; set; }
        public ushort StartQuest { get; set; }
        public ushort LockID { get; set; }
        public ushort RandomProperty { get; set; }
        public ushort RandomSuffix { get; set; }
        public ushort ItemSet { get; set; }
        public ushort Area { get; set; }
        public ushort Map { get; set; }
        public ushort TotemCategory { get; set; }
        public ushort SocketBonus { get; set; }
        public ushort GemProperties { get; set; }
        public ushort ItemLimitCategory { get; set; }
        public ushort HolidayID { get; set; }
        public ushort RequiredTransmogHolidayID { get; set; }
        public ushort ItemNameDescriptionID { get; set; }
        public byte Quality { get; set; }
        public byte InventoryType { get; set; }
        public byte RequiredLevel { get; set; }
        public byte RequiredHonorRank { get; set; }
        public byte RequiredCityRank { get; set; }
        public byte RequiredReputationRank { get; set; }
        public byte ContainerSlots { get; set; }
        [DBField(ArraySize: 10)]
        public byte[] ItemStatType { get; set; }
        public byte DamageType { get; set; }
        public byte Bonding { get; set; }
        public byte LanguageID { get; set; }
        public byte PageMaterial { get; set; }
        public byte Material { get; set; }
        public byte Sheath { get; set; }
        [DBField(ArraySize: 3)]
        public byte[] SocketColor { get; set; }
        public byte CurrencySubstitutionID { get; set; }
        public byte CurrencySubstitutionCount { get; set; }
        public byte ArtifactID { get; set; }
        public byte RequiredExpansion { get; set; }
    }

    [DBTable(24461)]
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

    [DBTable(24461)]
    public class ItemSpecOverride
    {
        [DBKey]
        public int ID { get; set; }
        public uint ItemID { get; set; }
        public ushort SpecID { get; set; }
    }

    [DBTable(24461)]
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

    [DBTable(24461)]
    public class ItemSubClassMask
    {
        [DBKey]
        public int ID { get; set; }
        public uint Field04 { get; set; }
        public string Field08 { get; set; }
        public byte Field0C { get; set; }
    }

    [DBTable(24461)]
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

    [DBTable(24461)]
    public class ItemVisualEffects
    {
        [DBKey]
        public int ID { get; set; }
        public string Field4 { get; set; }
    }

    [DBTable(24461)]
    public class ItemVisuals
    {
        [DBKey]
        public int ID { get; set; }
        [DBField(ArraySize: 3)]
        public ushort[] Field4 { get; set; }
    }

    [DBTable(24461)]
    public class ItemXBonusTree
    {
        [DBKey]
        public int ID { get; set; }
        public uint ItemID { get; set; }
        public ushort BonusTreeID { get; set; }
    }

    [DBTable(24461)]
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
        public byte Field1F { get; set; }
    }

    [DBTable(24461)]
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

    [DBTable(24461)]
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

    [DBTable(24461)]
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

    [DBTable(24461)]
    public class JournalEncounterXDifficulty
    {
        [DBKey]
        public int ID { get; set; }
        public ushort Field4 { get; set; }
        public byte Field6 { get; set; }
    }

    [DBTable(24461)]
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

    [DBTable(24461)]
    public class JournalItemXDifficulty
    {
        [DBKey]
        public int ID { get; set; }
        public ushort Field4 { get; set; }
        public byte Field6 { get; set; }
    }

    [DBTable(24461)]
    public class JournalSectionXDifficulty
    {
        [DBKey]
        public int ID { get; set; }
        public ushort Field4 { get; set; }
        public byte Field6 { get; set; }
    }

    [DBTable(24461)]
    public class JournalTier
    {
        [DBKey]
        public int ID { get; set; }
        public string Field4 { get; set; }
    }

    [DBTable(24461)]
    public class JournalTierXInstance
    {
        [DBKey]
        public int ID { get; set; }
        public ushort Field4 { get; set; }
        public ushort Field6 { get; set; }
    }

    [DBTable(24461)]
    public class KeyChain
    {
        [DBKey]
        public int ID { get; set; }
        [DBField(ArraySize: 32)]
        public byte[] Key { get; set; }
    }

    [DBTable(24461)]
    public class KeystoneAffix
    {
        [DBKey]
        public int ID { get; set; }
        public string Field04 { get; set; }
        public string Field08 { get; set; }
        public uint Field0C { get; set; }
    }

    [DBTable(24461)]
    public class Languages
    {
        public string Field0 { get; set; }
        [DBKey]
        [DBField(ArraySize: 4)]
        public int[] ID { get; set; }
    }

    [DBTable(24461)]
    public class LanguageWords
    {
        [DBKey]
        public int ID { get; set; }
        public string Field4 { get; set; }
        public byte Field8 { get; set; }
    }

    [DBTable(24461)]
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

    [DBTable(24461)]
    public class LfgDungeonGroup
    {
        [DBKey]
        public int ID { get; set; }
        public string Field04 { get; set; }
        public ushort Field08 { get; set; }
        public byte Field0A { get; set; }
        public byte Field0B { get; set; }
    }

    [DBTable(24461)]
    public class LfgDungeons
    {
        public string Name { get; set; }
        public int Flags { get; set; }
        public string TextureFilename { get; set; }
        public string Description { get; set; }
        public float MinItemLevel { get; set; }
        public ushort MaxLevel { get; set; }
        public ushort TargetLevelMax { get; set; }
        public ushort MapID { get; set; }
        public ushort RandomID { get; set; }
        public ushort ScenarioID { get; set; }
        public ushort LastBossJournalEncounterID { get; set; }
        public ushort BonusReputationAmount { get; set; }
        public ushort MentorItemLevel { get; set; }
        public ushort PlayerConditionID { get; set; }
        public byte MinLevel { get; set; }
        public byte TargetLevel { get; set; }
        public byte TargetLevelMin { get; set; }
        public byte DifficultyID { get; set; }
        public byte Type { get; set; }
        public byte Faction { get; set; }
        public byte Expansion { get; set; }
        public byte OrderIndex { get; set; }
        public byte GroupID { get; set; }
        public byte CountTank { get; set; }
        public byte CountHealer { get; set; }
        public byte CountDamage { get; set; }
        public byte MinCountTank { get; set; }
        public byte MinCountHealer { get; set; }
        public byte MinCountDamage { get; set; }
        public byte SubType { get; set; }
        public byte MentorCharLevel { get; set; }
        [DBKey]
        public int ID { get; set; }
    }

    [DBTable(24461)]
    public class LfgDungeonsGroupingMap
    {
        [DBKey]
        public int ID { get; set; }
        public ushort Field4 { get; set; }
        public ushort Field6 { get; set; }
        public byte Field8 { get; set; }
    }

    [DBTable(24461)]
    public class LfgRoleRequirement
    {
        [DBKey]
        public int ID { get; set; }
        public ushort Field4 { get; set; }
        public byte Field6 { get; set; }
        public ushort Field7 { get; set; }
    }

    [DBTable(24461)]
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

    [DBTable(24461)]
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

    [DBTable(24461)]
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

    [DBTable(24461)]
    public class LightSkybox
    {
        [DBKey]
        public int ID { get; set; }
        public string Field04 { get; set; }
        public uint Field08 { get; set; }
        public byte Field0C { get; set; }
    }

    [DBTable(24461)]
    public class LiquidMaterial
    {
        [DBKey]
        public int ID { get; set; }
        public byte Field4 { get; set; }
        public byte Field5 { get; set; }
    }

    [DBTable(24461)]
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

    [DBTable(24461)]
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

    [DBTable(24461)]
    public class LoadingScreens
    {
        [DBKey]
        public int ID { get; set; }
        public uint Field04 { get; set; }
        public uint Field08 { get; set; }
        public uint Field0C { get; set; }
    }

    [DBTable(24461)]
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

    [DBTable(24461)]
    public class Locale
    {
        [DBKey]
        public int ID { get; set; }
        public uint Field04 { get; set; }
        public byte Field08 { get; set; }
        public byte Field09 { get; set; }
        public byte Field0A { get; set; }
    }

    [DBTable(24461)]
    public class Location
    {
        [DBKey]
        public int ID { get; set; }
        [DBField(ArraySize: 3)]
        public int[] Field04 { get; set; }
        [DBField(ArraySize: 2)]
        public int[] Field10 { get; set; }
    }

    [DBTable(24461)]
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

    [DBTable(24461)]
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

    [DBTable(24461)]
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

    [DBTable(24461)]
    public class MailTemplate
    {
        [DBKey]
        public int ID { get; set; }
        public string Body { get; set; }
    }

    [DBTable(24461)]
    public class ManifestInterfaceActionIcon
    {
        [DBKey]
        public int ID { get; set; }
    }

    [DBTable(24461)]
    public class ManifestInterfaceData
    {
        [DBKey]
        public int ID { get; set; }
        public string Field4 { get; set; }
        public string Field8 { get; set; }
    }

    [DBTable(24461)]
    public class ManifestInterfaceItemIcon
    {
        [DBKey]
        public int ID { get; set; }
    }

    [DBTable(24461)]
    public class ManifestInterfaceTOCData
    {
        [DBKey]
        public int ID { get; set; }
        public string Field4 { get; set; }
    }

    [DBTable(24461)]
    public class ManifestMP3
    {
        [DBKey]
        public int ID { get; set; }
    }

    [DBTable(24461)]
    public class Map
    {
        [DBKey]
        public int ID { get; set; }
        public string Directory { get; set; }
        [DBField(ArraySize: 2)]
        public uint[] Flags { get; set; }
        public float MinimapIconScale { get; set; }
        [DBField(ArraySize: 2)]
        public float[] CorpsePos { get; set; }
        public string MapName { get; set; }
        public string MapDescription0 { get; set; }
        public string MapDescription1 { get; set; }
        public string ShortDescription { get; set; }
        public string LongDescription { get; set; }
        public ushort AreaTableID { get; set; }
        public ushort LoadingScreenID { get; set; }
        public ushort CorpseMapID { get; set; }
        public ushort TimeOfDayOverride { get; set; }
        public ushort ParentMapID { get; set; }
        public ushort CosmeticParentMapID { get; set; }
        public ushort WindSettingsID { get; set; }
        public byte InstanceType { get; set; }
        public byte Unk5 { get; set; }
        public byte ExpansionID { get; set; }
        public byte MaxPlayers { get; set; }
        public byte TimeOffset { get; set; }
    }

    [DBTable(24461)]
    public class MapCelestialBody
    {
        [DBKey]
        public int ID { get; set; }
        public ushort Field00 { get; set; }
        public ushort Field02 { get; set; }
        public int Field04 { get; set; }
    }

    [DBTable(24461)]
    public class MapChallengeMode
    {
        [DBKey]
        public int ID { get; set; }
        public string Field04 { get; set; }
        public ushort Field08 { get; set; }
        [DBField(ArraySize: 3)]
        public ushort[] Field0A { get; set; }
        [DBField(ArraySize: 4)]
        public byte[] Field10 { get; set; }
    }

    [DBTable(24461)]
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

    [DBTable(24461)]
    public class MapDifficultyXCondition
    {
        [DBKey]
        public int ID { get; set; }
        public string Field04 { get; set; }
        public ushort Field08 { get; set; }
        public ushort Field0A { get; set; }
        public byte Field0C { get; set; }
    }

    [DBTable(24461)]
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

    [DBTable(24461)]
    public class Material
    {
        [DBKey]
        public int ID { get; set; }
        public byte Field4 { get; set; }
        public ushort Field5 { get; set; }
        public ushort Field7 { get; set; }
        public ushort Field9 { get; set; }
    }

    [DBTable(24461)]
    public class MinorTalent
    {
        [DBKey]
        public int ID { get; set; }
        public uint Field04 { get; set; }
        public ushort Field08 { get; set; }
        public byte Field0A { get; set; }
    }

    [DBTable(24461)]
    public class ModelAnimCloakDampening
    {
        [DBKey]
        public int ID { get; set; }
        public int Field4 { get; set; }
        public byte Field7 { get; set; }
        public byte Field8 { get; set; }
    }

    [DBTable(24461)]
    public class ModelFileData
    {
        public byte Field0 { get; set; }
        [DBKey]
        public int ID { get; set; }
        public ushort Field4 { get; set; }
    }

    [DBTable(24461)]
    public class ModelRibbonQuality
    {
        [DBKey]
        public int ID { get; set; }
        public uint Field4 { get; set; }
        public byte Field8 { get; set; }
    }

    [DBTable(24461)]
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

    [DBTable(24461)]
    public class Mount
    {
        public uint SpellId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string SourceDescription { get; set; }
        public float CameraPivotMultiplier { get; set; }
        public ushort MountTypeId { get; set; }
        public ushort Flags { get; set; }
        public byte Source { get; set; }
        [DBKey]
        public int ID { get; set; }
        public uint PlayerConditionId { get; set; }
        public int UiModelSceneID { get; set; }
    }

    [DBTable(24461)]
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

    [DBTable(24461)]
    public class MountTypeXCapability
    {
        [DBKey]
        public int ID { get; set; }
        public ushort MountTypeID { get; set; }
        public ushort MountCapabilityID { get; set; }
        public byte OrderIndex { get; set; }
    }

    [DBTable(24461)]
    public class MountXDisplay
    {
        [DBKey]
        public int ID { get; set; }
        public uint MountID { get; set; }
        public uint DisplayID { get; set; }
        public uint PlayerConditionID { get; set; }
    }

    [DBTable(24461)]
    public class Movie
    {
        [DBKey]
        public int ID { get; set; }
        public uint AudioFileDataID { get; set; }
        public uint SubtitleFileDataID { get; set; }
        public byte Volume { get; set; }
        public byte KeyID { get; set; }
    }

    [DBTable(24461)]
    public class MovieFileData
    {
        [DBKey]
        public int ID { get; set; }
        public ushort Field4 { get; set; }
    }

    [DBTable(24461)]
    public class MovieVariation
    {
        [DBKey]
        public int ID { get; set; }
        public uint Field04 { get; set; }
        public ushort Field08 { get; set; }
        public byte Field0A { get; set; }
    }

    [DBTable(24461)]
    public class NameGen
    {
        [DBKey]
        public int ID { get; set; }
        public string Name { get; set; }
        public byte Race { get; set; }
        public byte Sex { get; set; }
    }

    [DBTable(24461)]
    public class NamesProfanity
    {
        [DBKey]
        public int ID { get; set; }
        public string Name { get; set; }
        public byte Language { get; set; }
    }

    [DBTable(24461)]
    public class NamesReserved
    {
        [DBKey]
        public int ID { get; set; }
        public string Name { get; set; }
    }

    [DBTable(24461)]
    public class NamesReservedLocale
    {
        [DBKey]
        public int ID { get; set; }
        public string Name { get; set; }
        public byte LocaleMask { get; set; }
    }

    [DBTable(24461)]
    public class NpcModelItemSlotDisplayInfo
    {
        [DBKey]
        public int ID { get; set; }
        public uint Field04 { get; set; }
        public uint Field08 { get; set; }
        public byte Field0C { get; set; }
    }

    [DBTable(24461)]
    public class NPCSounds
    {
        [DBKey]
        public int ID { get; set; }
        [DBField(ArraySize: 2)]
        public int[] Field4 { get; set; }
    }

    [DBTable(24461)]
    public class ObjectEffect
    {
        [DBKey]
        public int ID { get; set; }
        public string Field04 { get; set; }
        [DBField(ArraySize: 3)]
        public int[] Field08 { get; set; }
        public ushort Field14 { get; set; }
        public byte Field16 { get; set; }
        public byte Field17 { get; set; }
        public byte Field18 { get; set; }
        public byte Field19 { get; set; }
        public int Field1A { get; set; }
        public ushort Field1D { get; set; }
    }

    [DBTable(24461)]
    public class ObjectEffectGroup
    {
        [DBKey]
        public int ID { get; set; }
        public string Field4 { get; set; }
    }

    [DBTable(24461)]
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

    [DBTable(24461)]
    public class ObjectEffectPackage
    {
        [DBKey]
        public int ID { get; set; }
        public string Field4 { get; set; }
    }

    [DBTable(24461)]
    public class ObjectEffectPackageElem
    {
        [DBKey]
        public int ID { get; set; }
        public ushort Field4 { get; set; }
        public ushort Field6 { get; set; }
        public ushort Field8 { get; set; }
    }

    [DBTable(24461)]
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

    [DBTable(24461)]
    public class OverrideSpellData
    {
        [DBKey]
        public int ID { get; set; }
        [DBField(ArraySize: 10)]
        public uint[] SpellID { get; set; }
        public uint PlayerActionbarFileDataID { get; set; }
        public byte Flags { get; set; }
    }

    [DBTable(24461)]
    public class PageTextMaterial
    {
        [DBKey]
        public int ID { get; set; }
        public string Field4 { get; set; }
    }

    [DBTable(24461)]
    public class PaperDollItemFrame
    {
        [DBKey]
        public int ID { get; set; }
        public string Field04 { get; set; }
        public string Field08 { get; set; }
        public byte Field0C { get; set; }
    }

    [DBTable(24461)]
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

    [DBTable(24461)]
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

    [DBTable(24461)]
    public class PathNode
    {
        [DBKey]
        public int ID { get; set; }
        public uint Field04 { get; set; }
        public ushort Field08 { get; set; }
        public ushort Field0A { get; set; }
    }

    [DBTable(24461)]
    public class PathNodeProperty
    {
        public ushort Field0 { get; set; }
        public ushort Field2 { get; set; }
        public byte Field4 { get; set; }
        [DBKey]
        public int ID { get; set; }
        public int Field8 { get; set; }
    }

    [DBTable(24461)]
    public class PathProperty
    {
        public uint Field0 { get; set; }
        public ushort Field4 { get; set; }
        public byte Field6 { get; set; }
        [DBKey]
        [DBField(ArraySize: 2)]
        public int[] ID { get; set; }
    }

    [DBTable(24461)]
    public class Phase
    {
        [DBKey]
        public int ID { get; set; }
        public ushort Flags { get; set; }
    }

    [DBTable(24461)]
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

    [DBTable(24461)]
    public class PhaseXPhaseGroup
    {
        [DBKey]
        public int ID { get; set; }
        public ushort PhaseID { get; set; }
        public ushort PhaseGroupID { get; set; }
    }

    [DBTable(24461)]
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
        public byte Unknown1 { get; set; }
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
        public uint[] MinFactionID { get; set; }
        [DBField(ArraySize: 4)]
        public uint[] SpellID { get; set; }
        [DBField(ArraySize: 4)]
        public uint[] ItemID { get; set; }
        [DBField(ArraySize: 4)]
        public uint[] ItemCount { get; set; }
        public uint LfgLogic { get; set; }
        [DBField(ArraySize: 4)]
        public uint[] LfgValue { get; set; }
        public uint CurrencyLogic { get; set; }
        [DBField(ArraySize: 4)]
        public uint[] CurrencyID { get; set; }
        [DBField(ArraySize: 6)]
        public uint[] QuestKillMonster { get; set; }
        public uint PhaseGroupID { get; set; }
        public uint MinAvgItemLevel { get; set; }
        public uint MaxAvgItemLevel { get; set; }
        [DBField(ArraySize: 2)]
        public int[] MovementFlags { get; set; }
        public uint MainHandItemSubclassMask { get; set; }
    }

    [DBTable(24461)]
    public class Positioner
    {
        [DBKey]
        public int ID { get; set; }
        public float Field04 { get; set; }
        public ushort Field08 { get; set; }
        public byte Field0A { get; set; }
        public byte Field0B { get; set; }
    }

    [DBTable(24461)]
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

    [DBTable(24461)]
    public class PositionerStateEntry
    {
        [DBKey]
        public int ID { get; set; }
        public float Field04 { get; set; }
        public int Field08 { get; set; }
        public ushort Field0C { get; set; }
        public ushort Field0E { get; set; }
        public ushort Field10 { get; set; }
        public ushort Field12 { get; set; }
        public byte Field14 { get; set; }
        public byte Field15 { get; set; }
        public byte Field16 { get; set; }
        public byte Field17 { get; set; }
        public ushort Field18 { get; set; }
    }

    [DBTable(24461)]
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

    [DBTable(24461)]
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

    [DBTable(24461)]
    public class PrestigeLevelInfo
    {
        [DBKey]
        public int ID { get; set; }
        public uint Field04 { get; set; }
        public string Field08 { get; set; }
        public byte Field0C { get; set; }
        public byte Field0D { get; set; }
    }

    [DBTable(24461)]
    public class PvpBracketTypes
    {
        [DBKey]
        public int ID { get; set; }
        public byte Field4 { get; set; }
        [DBField(ArraySize: 2)]
        public ushort[] Field5 { get; set; }
    }

    [DBTable(24461)]
    public class PvpDifficulty
    {
        [DBKey]
        public int ID { get; set; }
        public ushort MapID { get; set; }
        public byte BracketID { get; set; }
        public byte MinLevel { get; set; }
        public byte MaxLevel { get; set; }
    }

    [DBTable(24461)]
    public class PvpItem
    {
        [DBKey]
        public int ID { get; set; }
        public uint Field4 { get; set; }
        public byte Field8 { get; set; }
    }

    [DBTable(24461)]
    public class PvpReward
    {
        [DBKey]
        public int ID { get; set; }
        public byte Field4 { get; set; }
        public byte Field5 { get; set; }
        public ushort Field6 { get; set; }
    }

    [DBTable(24461)]
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

    [DBTable(24461)]
    public class PvpTalentUnlock
    {
        [DBKey]
        public int ID { get; set; }
        public byte Field4 { get; set; }
        public byte Field5 { get; set; }
        public byte Field6 { get; set; }
    }

    [DBTable(24461)]
    public class QuestFactionReward
    {
        [DBKey]
        public int ID { get; set; }
        [DBField(ArraySize: 10)]
        public ushort[] QuestRewFactionValue { get; set; }
    }

    [DBTable(24461)]
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

    [DBTable(24461)]
    public class QuestInfo
    {
        [DBKey]
        public int ID { get; set; }
        public string Field04 { get; set; }
        public ushort Field08 { get; set; }
        public byte Field0A { get; set; }
        public byte Field0B { get; set; }
    }

    [DBTable(24461)]
    public class QuestLine
    {
        [DBKey]
        public int ID { get; set; }
        public string Field4 { get; set; }
    }

    [DBTable(24461)]
    public class QuestLineXQuest
    {
        [DBKey]
        public int ID { get; set; }
        public ushort Field4 { get; set; }
        public ushort Field6 { get; set; }
        public byte Field8 { get; set; }
    }

    [DBTable(24461)]
    public class QuestMoneyReward
    {
        [DBKey]
        public int ID { get; set; }
        [DBField(ArraySize: 10)]
        public uint[] Money { get; set; }
    }

    [DBTable(24461)]
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

    [DBTable(24461)]
    public class QuestPackageItem
    {
        [DBKey]
        public int ID { get; set; }
        public uint ItemID { get; set; }
        public ushort QuestPackageID { get; set; }
        public byte FilterType { get; set; }
        public uint ItemCount { get; set; }
    }

    [DBTable(24461)]
    public class QuestPOIBlob
    {
        [DBKey]
        public int ID { get; set; }
        public ushort Field04 { get; set; }
        public ushort Field06 { get; set; }
        public byte Field08 { get; set; }
        public byte Field09 { get; set; }
        public ushort Field0A { get; set; }
        public ushort Field0C { get; set; }
        [DBField(ArraySize: 2)]
        public byte[] Field0E { get; set; }
    }

    [DBTable(24461)]
    public class QuestPOIPoint
    {
        public uint Field0 { get; set; }
        public ushort Field4 { get; set; }
        public ushort Field6 { get; set; }
        [DBKey]
        public int ID { get; set; }
    }

    [DBTable(24461)]
    public class QuestSort
    {
        [DBKey]
        public int ID { get; set; }
        public string SortName { get; set; }
        public byte SortOrder { get; set; }
    }

    [DBTable(24461)]
    public class QuestV2
    {
        [DBKey]
        public int ID { get; set; }
        public ushort UniqueBitFlag { get; set; }
    }

    [DBTable(24461)]
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
        public byte Field20 { get; set; }
        public byte Field21 { get; set; }
        public byte Field22 { get; set; }
        public byte Field23 { get; set; }
        public byte Field24 { get; set; }
        public byte Field25 { get; set; }
        public byte Field26 { get; set; }
        public byte Field27 { get; set; }
        public byte Field28 { get; set; }
        public byte Field29 { get; set; }
        [DBKey]
        public int ID { get; set; }
        public byte Field2C { get; set; }
        [DBField(ArraySize: 3)]
        public byte[] Field2D { get; set; }
    }

    [DBTable(24461)]
    public class QuestXP
    {
        [DBKey]
        public int ID { get; set; }
        [DBField(ArraySize: 10)]
        public ushort[] Exp { get; set; }
    }

    [DBTable(24461)]
    public class RacialMounts
    {
        [DBKey]
        public int ID { get; set; }
        public uint Field4 { get; set; }
        public byte Field8 { get; set; }
    }

    [DBTable(24461)]
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

    [DBTable(24461)]
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

    [DBTable(24461)]
    public class ResearchField
    {
        public int Field0 { get; set; }
        public byte Field4 { get; set; }
        [DBKey]
        [DBField(ArraySize: 3)]
        public int[] ID { get; set; }
    }

    [DBTable(24461)]
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

    [DBTable(24461)]
    public class ResearchSite
    {
        [DBKey]
        public int ID { get; set; }
        public uint Field04 { get; set; }
        public string Field08 { get; set; }
        public ushort Field0C { get; set; }
        public byte Field0E { get; set; }
    }

    [DBTable(24461)]
    public class Resistances
    {
        [DBKey]
        public int ID { get; set; }
        public string Field4 { get; set; }
        public byte Field8 { get; set; }
        public ushort Field9 { get; set; }
    }

    [DBTable(24461)]
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

    [DBTable(24461)]
    public class RewardPackXCurrencyType
    {
        [DBKey]
        public int ID { get; set; }
        public byte Field4 { get; set; }
        public ushort Field5 { get; set; }
        public ushort Field7 { get; set; }
    }

    [DBTable(24461)]
    public class RewardPackXItem
    {
        [DBKey]
        public int ID { get; set; }
        public uint Field04 { get; set; }
        public ushort Field08 { get; set; }
        public byte Field0A { get; set; }
    }

    [DBTable(24461)]
    public class RibbonQuality
    {
        [DBKey]
        public int ID { get; set; }
        public float Field04 { get; set; }
        public float Field08 { get; set; }
        public float Field0C { get; set; }
        public byte Field10 { get; set; }
        public byte Field11 { get; set; }
    }

    [DBTable(24461)]
    public class RulesetItemUpgrade
    {
        [DBKey]
        public int ID { get; set; }
        public uint ItemID { get; set; }
        public ushort ItemUpgradeID { get; set; }
    }

    [DBTable(24461)]
    public class ScalingStatDistribution
    {
        [DBKey]
        public int ID { get; set; }
        public ushort ItemLevelCurveID { get; set; }
        public uint MinLevel { get; set; }
        public uint MaxLevel { get; set; }
    }

    [DBTable(24461)]
    public class Scenario
    {
        [DBKey]
        public int ID { get; set; }
        public string Name { get; set; }
        public ushort Data { get; set; }
        public byte Flags { get; set; }
        public byte Type { get; set; }
    }

    [DBTable(24461)]
    public class ScenarioEventEntry
    {
        [DBKey]
        public int ID { get; set; }
        public ushort Field4 { get; set; }
        public byte Field6 { get; set; }
    }

    [DBTable(24461)]
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

    [DBTable(24461)]
    public class SceneScript
    {
        [DBKey]
        public int ID { get; set; }
        public string Name { get; set; }
        public string Script { get; set; }
        public ushort PrevScriptId { get; set; }
        public ushort NextScriptId { get; set; }
    }

    [DBTable(24461)]
    public class SceneScriptPackage
    {
        [DBKey]
        public int ID { get; set; }
        public string Name { get; set; }
    }

    [DBTable(24461)]
    public class SceneScriptPackageMember
    {
        [DBKey]
        public int ID { get; set; }
        public ushort Field04 { get; set; }
        public ushort Field06 { get; set; }
        public ushort Field08 { get; set; }
        public byte Field0A { get; set; }
    }

    [DBTable(24461)]
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

    [DBTable(24461)]
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

    [DBTable(24461)]
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

    [DBTable(24461)]
    public class ScheduledWorldStateXUniqCat
    {
        [DBKey]
        public int ID { get; set; }
        public ushort Field2 { get; set; }
        public ushort Field4 { get; set; }
    }

    [DBTable(24461)]
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

    [DBTable(24461)]
    public class ScreenLocation
    {
        [DBKey]
        public int ID { get; set; }
        public string Field4 { get; set; }
    }

    [DBTable(24461)]
    public class SeamlessSite
    {
        [DBKey]
        public int ID { get; set; }
        public ushort Field4 { get; set; }
    }

    [DBTable(24461)]
    public class ServerMessages
    {
        [DBKey]
        public int ID { get; set; }
        public string Field4 { get; set; }
    }

    [DBTable(24461)]
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
        public uint Field24 { get; set; }
        public byte Field28 { get; set; }
        public byte Field29 { get; set; }
    }

    [DBTable(24461)]
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

    [DBTable(24461)]
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

    [DBTable(24461)]
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

    [DBTable(24461)]
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

    [DBTable(24461)]
    public class SoundAmbienceFlavor
    {
        [DBKey]
        public int ID { get; set; }
        public ushort Field4 { get; set; }
        public int Field6 { get; set; }
        public int Field9 { get; set; }
    }

    [DBTable(24461)]
    public class SoundBus
    {
        public float Field00 { get; set; }
        public ushort Field04 { get; set; }
        public byte Field06 { get; set; }
        public byte Field07 { get; set; }
        public byte Field08 { get; set; }
        public byte Field09 { get; set; }
        public byte Field0A { get; set; }
        [DBKey]
        [DBField(ArraySize: 2)]
        public int[] ID { get; set; }
    }

    [DBTable(24461)]
    public class SoundBusName
    {
        public string Field0 { get; set; }
        [DBKey]
        [DBField(ArraySize: 4)]
        public int[] ID { get; set; }
    }

    [DBTable(24461)]
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

    [DBTable(24461)]
    public class SoundEmitterPillPoints
    {
        [DBKey]
        public int ID { get; set; }
        [DBField(ArraySize: 3)]
        public int[] Field04 { get; set; }
        public ushort Field10 { get; set; }
    }

    [DBTable(24461)]
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
        [DBKey]
        public int ID { get; set; }
        public int Field27 { get; set; }
        [DBField(ArraySize: 2)]
        public byte[] Field2A { get; set; }
    }

    [DBTable(24461)]
    public class SoundFilter
    {
        [DBKey]
        public int ID { get; set; }
        public string Field4 { get; set; }
    }

    [DBTable(24461)]
    public class SoundFilterElem
    {
        [DBKey]
        public int ID { get; set; }
        [DBField(ArraySize: 9)]
        public float[] Field04 { get; set; }
        public byte Field28 { get; set; }
        public byte Field29 { get; set; }
    }

    [DBTable(24461)]
    public class SoundKit
    {
        public string Name { get; set; }
        public float VolumeFloat { get; set; }
        public float MinDistance { get; set; }
        public float DistanceCutoff { get; set; }
        public float VolumeVariationPlus { get; set; }
        public float VolumeVariationMinus { get; set; }
        public float PitchVariationPlus { get; set; }
        public float PitchVariationMinus { get; set; }
        public float PitchAdjust { get; set; }
        public ushort Flags { get; set; }
        public ushort SoundEntriesAdvancedID { get; set; }
        public ushort BusOverwriteID { get; set; }
        public byte SoundType { get; set; }
        public byte EAXDef { get; set; }
        public byte DialogType { get; set; }
        public byte Unk700 { get; set; }
        [DBKey]
        public int ID { get; set; }
    }

    [DBTable(24461)]
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
        public int Field069 { get; set; }
        public int Field06C { get; set; }
    }

    [DBTable(24461)]
    public class SoundKitChild
    {
        [DBKey]
        public int ID { get; set; }
        public int Field4 { get; set; }
        public int Field7 { get; set; }
    }

    [DBTable(24461)]
    public class SoundKitEntry
    {
        [DBKey]
        public int ID { get; set; }
        public uint Field04 { get; set; }
        public float Field08 { get; set; }
        public byte Field0C { get; set; }
        public int Field0D { get; set; }
    }

    [DBTable(24461)]
    public class SoundKitFallback
    {
        [DBKey]
        public int ID { get; set; }
        public ushort Field4 { get; set; }
        public ushort Field6 { get; set; }
    }

    [DBTable(24461)]
    public class SoundOverride
    {
        [DBKey]
        public int ID { get; set; }
        public ushort Field04 { get; set; }
        public ushort Field06 { get; set; }
        public ushort Field08 { get; set; }
        public byte Field0A { get; set; }
    }

    [DBTable(24461)]
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

    [DBTable(24461)]
    public class SourceInfo
    {
        [DBKey]
        public int ID { get; set; }
        public uint Field04 { get; set; }
        public string Field08 { get; set; }
        public byte Field0C { get; set; }
        public byte Field0D { get; set; }
    }

    [DBTable(24461)]
    public class SpamMessages
    {
        [DBKey]
        public int ID { get; set; }
        public string Field4 { get; set; }
    }

    [DBTable(24461)]
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

    [DBTable(24461)]
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

    [DBTable(24461)]
    public class SpellActionBarPref
    {
        [DBKey]
        public int ID { get; set; }
        public uint Field4 { get; set; }
        public ushort Field8 { get; set; }
    }

    [DBTable(24461)]
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

    [DBTable(24461)]
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

    [DBTable(24461)]
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

    [DBTable(24461)]
    public class SpellAuraVisibility
    {
        public uint Field0 { get; set; }
        public byte Field4 { get; set; }
        public byte Field5 { get; set; }
        [DBKey]
        public int ID { get; set; }
    }

    [DBTable(24461)]
    public class SpellAuraVisXChrSpec
    {
        [DBKey]
        public int ID { get; set; }
        public ushort Field4 { get; set; }
        public ushort Field6 { get; set; }
    }

    [DBTable(24461)]
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

    [DBTable(24461)]
    public class SpellCastTimes
    {
        [DBKey]
        public int ID { get; set; }
        public int CastTime { get; set; }
        public int MinCastTime { get; set; }
        public ushort CastTimePerLevel { get; set; }
    }

    [DBTable(24461)]
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

    [DBTable(24461)]
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

    [DBTable(24461)]
    public class SpellChainEffects
    {
        [DBKey]
        public int ID { get; set; }
        public float Field004 { get; set; }
        public float Field008 { get; set; }
        public int Field00C { get; set; }
        public uint Field010 { get; set; }
        public uint Field014 { get; set; }
        public float Field018 { get; set; }
        public float Field01C { get; set; }
        public float Field020 { get; set; }
        public int Field024 { get; set; }
        public float Field028 { get; set; }
        public float Field02C { get; set; }
        public float Field030 { get; set; }
        public int Field034 { get; set; }
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
        public uint Field064 { get; set; }
        public float Field068 { get; set; }
        public float Field06C { get; set; }
        public float Field070 { get; set; }
        public float Field074 { get; set; }
        public int Field078 { get; set; }
        public float Field07C { get; set; }
        public float Field080 { get; set; }
        public int Field084 { get; set; }
        public float Field088 { get; set; }
        public float Field08C { get; set; }
        [DBField(ArraySize: 3)]
        public int[] Field090 { get; set; }
        [DBField(ArraySize: 3)]
        public int[] Field09C { get; set; }
        [DBField(ArraySize: 3)]
        public int[] Field0A8 { get; set; }
        [DBField(ArraySize: 3)]
        public float[] Field0B4 { get; set; }
        public uint Field0C0 { get; set; }
        public float Field0C4 { get; set; }
        public float Field0C8 { get; set; }
        [DBField(ArraySize: 3)]
        public string[] Field0CC { get; set; }
        public string Field0D8 { get; set; }
        public ushort Field0DC { get; set; }
        public ushort Field0DE { get; set; }
        [DBField(ArraySize: 11)]
        public ushort[] Field0E0 { get; set; }
        public ushort Field0F6 { get; set; }
        public byte Field0F8 { get; set; }
        public byte Field0F9 { get; set; }
        public byte Field0FA { get; set; }
        public byte Field0FB { get; set; }
        public byte Field0FC { get; set; }
        public byte Field0FD { get; set; }
        public byte Field0FE { get; set; }
        public byte Field0FF { get; set; }
        public byte Field100 { get; set; }
        public byte Field101 { get; set; }
        public int Field102 { get; set; }
    }

    [DBTable(24461)]
    public class SpellClassOptions
    {
        [DBKey]
        public int ID { get; set; }
        public uint SpellID { get; set; }
        public byte SpellClassSet { get; set; }
        public uint ModalNextSpell { get; set; }
    }

    [DBTable(24461)]
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

    [DBTable(24461)]
    public class SpellDescriptionVariables
    {
        [DBKey]
        public int ID { get; set; }
        public string Field4 { get; set; }
    }

    [DBTable(24461)]
    public class SpellDispelType
    {
        [DBKey]
        public int ID { get; set; }
        public string Field04 { get; set; }
        public string Field08 { get; set; }
        public byte Field0C { get; set; }
        public byte Field0D { get; set; }
    }

    [DBTable(24461)]
    public class SpellDuration
    {
        [DBKey]
        public int ID { get; set; }
        public int Duration { get; set; }
        public int MaxDuration { get; set; }
        public int DurationPerLevel { get; set; }
    }

    [DBTable(24461)]
    public class SpellEffect
    {
        [DBField(ArraySize: 4)]
        public int[] EffectSpellClassMask { get; set; }
        [DBKey]
        public int ID { get; set; }
        public uint SpellID { get; set; }
        public uint Effect { get; set; }
        public uint EffectAura { get; set; }
        public int EffectBasePoints { get; set; }
        public uint EffectIndex { get; set; }
        [DBField(ArraySize: 2)]
        public int[] EffectMiscValue { get; set; }
        [DBField(ArraySize: 2)]
        public uint[] EffectRadiusIndex { get; set; }
        [DBField(ArraySize: 2)]
        public uint[] ImplicitTarget { get; set; }
        public int DifficultyID { get; set; }
        public float EffectAmplitude { get; set; }
        public int EffectAuraPeriod { get; set; }
        public float EffectBonusCoefficient { get; set; }
        [DBField(DefaultValue: 1f)]
        public float EffectChainAmplitude { get; set; }
        public uint EffectChainTargets { get; set; }
        public int EffectDieSides { get; set; }
        public uint EffectItemType { get; set; }
        public uint EffectMechanic { get; set; }
        public float EffectPointsPerResource { get; set; }
        public float EffectRealPointsPerLevel { get; set; }
        public uint EffectTriggerSpell { get; set; }
        public float EffectPosFacing { get; set; }
        public uint EffectAttributes { get; set; }
        public float BonusCoefficientFromAP { get; set; }
        [DBField(DefaultValue: 1f)]
        public float PvPMultiplier { get; set; }
    }

    [DBTable(24461)]
    public class SpellEffectEmission
    {
        [DBKey]
        public int ID { get; set; }
        public float Field04 { get; set; }
        public float Field08 { get; set; }
        public ushort Field0C { get; set; }
        public byte Field0E { get; set; }
    }

    [DBTable(24461)]
    public class SpellEffectGroupSize
    {
        [DBKey]
        public int ID { get; set; }
        public uint Field4 { get; set; }
        public float Field8 { get; set; }
    }

    [DBTable(24461)]
    public class SpellEffectScaling
    {
        [DBKey]
        public int ID { get; set; }
        public float Coefficient { get; set; }
        public float Variance { get; set; }
        public float ResourceCoefficient { get; set; }
        public uint SpellEffectID { get; set; }
    }

    [DBTable(24461)]
    public class SpellEquippedItems
    {
        [DBKey]
        public int ID { get; set; }
        public uint SpellID { get; set; }
        public int EquippedItemInventoryTypeMask { get; set; }
        public int EquippedItemSubClassMask { get; set; }
        public byte EquippedItemClass { get; set; }
    }

    [DBTable(24461)]
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

    [DBTable(24461)]
    public class SpellFlyoutItem
    {
        [DBKey]
        public int ID { get; set; }
        public uint Field4 { get; set; }
        public byte Field8 { get; set; }
        public byte Field9 { get; set; }
    }

    [DBTable(24461)]
    public class SpellFocusObject
    {
        [DBKey]
        public int ID { get; set; }
        public string Name { get; set; }
    }

    [DBTable(24461)]
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

    [DBTable(24461)]
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

    [DBTable(24461)]
    public class SpellItemEnchantmentCondition
    {
        [DBKey]
        public int ID { get; set; }
        [DBField(ArraySize: 5)]
        public byte[] LTOperandType { get; set; }
        [DBField(ArraySize: 5)]
        public byte[] Operator { get; set; }
        [DBField(ArraySize: 5)]
        public byte[] RTOperandType { get; set; }
        [DBField(ArraySize: 5)]
        public byte[] RTOperand { get; set; }
        [DBField(ArraySize: 5)]
        public byte[] Logic { get; set; }
        [DBField(ArraySize: 5)]
        public uint[] LTOperand { get; set; }
    }

    [DBTable(24461)]
    public class SpellKeyboundOverride
    {
        [DBKey]
        public int ID { get; set; }
        public uint Field04 { get; set; }
        public string Field08 { get; set; }
        public byte Field0C { get; set; }
    }

    [DBTable(24461)]
    public class SpellLabel
    {
        [DBKey]
        public int ID { get; set; }
        public uint Field4 { get; set; }
        public ushort Field8 { get; set; }
    }

    [DBTable(24461)]
    public class SpellLearnSpell
    {
        [DBKey]
        public int ID { get; set; }
        public uint LearnSpellID { get; set; }
        public uint SpellID { get; set; }
        public uint OverridesSpellID { get; set; }
    }

    [DBTable(24461)]
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

    [DBTable(24461)]
    public class SpellMechanic
    {
        [DBKey]
        public int ID { get; set; }
        public string Field4 { get; set; }
    }

    [DBTable(24461)]
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

    [DBTable(24461)]
    public class SpellMiscDifficulty
    {
        public uint Field0 { get; set; }
        public byte Field4 { get; set; }
        [DBKey]
        public int ID { get; set; }
    }

    [DBTable(24461)]
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

    [DBTable(24461)]
    public class SpellMissileMotion
    {
        [DBKey]
        public int ID { get; set; }
        public string Field04 { get; set; }
        public string Field08 { get; set; }
        public byte Field0C { get; set; }
        public byte Field0D { get; set; }
    }

    [DBTable(24461)]
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

    [DBTable(24461)]
    public class SpellPowerDifficulty
    {
        public byte DifficultyID { get; set; }
        public byte PowerIndex { get; set; }
        [DBKey]
        public int ID { get; set; }
    }

    [DBTable(24461)]
    public class SpellProceduralEffect
    {
        [DBField(ArraySize: 4)]
        public int[] Field00 { get; set; }
        public byte Field10 { get; set; }
        [DBKey]
        public int ID { get; set; }
    }

    [DBTable(24461)]
    public class SpellProcsPerMinute
    {
        [DBKey]
        public int ID { get; set; }
        public float BaseProcRate { get; set; }
        public byte Flags { get; set; }
    }

    [DBTable(24461)]
    public class SpellProcsPerMinuteMod
    {
        [DBKey]
        public int ID { get; set; }
        public float Coeff { get; set; }
        public ushort Param { get; set; }
        public byte Type { get; set; }
        public byte SpellProcsPerMinuteID { get; set; }
    }

    [DBTable(24461)]
    public class SpellRadius
    {
        [DBKey]
        public int ID { get; set; }
        public float Radius { get; set; }
        public float RadiusPerLevel { get; set; }
        public float RadiusMin { get; set; }
        public float RadiusMax { get; set; }
    }

    [DBTable(24461)]
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

    [DBTable(24461)]
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

    [DBTable(24461)]
    public class SpellReagentsCurrency
    {
        [DBKey]
        public int ID { get; set; }
        public uint Field04 { get; set; }
        public ushort Field08 { get; set; }
        public ushort Field0A { get; set; }
    }

    [DBTable(24461)]
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

    [DBTable(24461)]
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

    [DBTable(24461)]
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

    [DBTable(24461)]
    public class SpellSpecialUnitEffect
    {
        [DBKey]
        public int ID { get; set; }
        public ushort Field4 { get; set; }
        public byte Field6 { get; set; }
    }

    [DBTable(24461)]
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

    [DBTable(24461)]
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

    [DBTable(24461)]
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
        public uint Field05C { get; set; }
        public uint Field060 { get; set; }
        public uint Field064 { get; set; }
        public ushort Field068 { get; set; }
        public ushort Field06A { get; set; }
        public byte Field06C { get; set; }
        public byte Field06D { get; set; }
        [DBKey]
        public int ID { get; set; }
        public int Field071 { get; set; }
        public byte Field074 { get; set; }
        [DBField(ArraySize: 3)]
        public byte[] Field075 { get; set; }
    }

    [DBTable(24461)]
    public class SpellVisualAnim
    {
        [DBKey]
        public int ID { get; set; }
        public ushort Field4 { get; set; }
        public ushort Field6 { get; set; }
        public ushort Field8 { get; set; }
    }

    [DBTable(24461)]
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

    [DBTable(24461)]
    public class SpellVisualEffectName
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
        public uint Field20 { get; set; }
        public uint Field24 { get; set; }
        public uint Field28 { get; set; }
        public byte Field2C { get; set; }
        public byte Field2D { get; set; }
        public ushort Field2E { get; set; }
    }

    [DBTable(24461)]
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

    [DBTable(24461)]
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

    [DBTable(24461)]
    public class SpellVisualKitEffect
    {
        [DBKey]
        public int ID { get; set; }
        public uint Field04 { get; set; }
        public uint Field08 { get; set; }
        public uint Field0C { get; set; }
    }

    [DBTable(24461)]
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

    [DBTable(24461)]
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

    [DBTable(24461)]
    public class SpellXSpellVisual
    {
        public uint SpellID { get; set; }
        public uint SpellVisualID { get; set; }
        [DBKey]
        public int ID { get; set; }
        [DBField(DefaultValue: 1f)]
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

    [DBTable(24461)]
    public class StartupFiles
    {
        [DBKey]
        public int ID { get; set; }
        public int Field00 { get; set; }
        public int Field04 { get; set; }
        public int Field08 { get; set; }
    }

    [DBTable(24461)]
    public class Startup_Strings
    {
        [DBKey]
        public int ID { get; set; }
        public string Field4 { get; set; }
        public string Field8 { get; set; }
    }

    [DBTable(24461)]
    public class Stationery
    {
        [DBKey]
        public int ID { get; set; }
        public string Field4 { get; set; }
        public byte Field8 { get; set; }
        public ushort Field9 { get; set; }
    }

    [DBTable(24461)]
    public class StringLookups
    {
        [DBKey]
        public int ID { get; set; }
        public string Field4 { get; set; }
    }

    [DBTable(24461)]
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

    [DBTable(24461)]
    public class TactKey
    {
        [DBKey]
        public int ID { get; set; }
        [DBField(ArraySize: 16)]
        public byte[] Key { get; set; }
    }

    [DBTable(24461)]
    public class TactKeyLookup
    {
        [DBKey]
        public int ID { get; set; }
        [DBField(ArraySize: 4)]
        public byte[] Field4 { get; set; }
    }

    [DBTable(24461)]
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

    [DBTable(24461)]
    public class TaxiNodes
    {
        [DBField(ArraySize: 3)]
        public float[] Pos { get; set; }
        public string Name { get; set; }
        [DBField(ArraySize: 2)]
        public uint[] MountCreatureID { get; set; }
        [DBField(ArraySize: 2)]
        public float[] MapOffset { get; set; }
        public ushort MapID { get; set; }
        public ushort ConditionID { get; set; }
        public ushort LearnableIndex { get; set; }
        public byte Flags { get; set; }
        [DBKey]
        public int ID { get; set; }
    }

    [DBTable(24461)]
    public class TaxiPath
    {
        public ushort From { get; set; }
        public ushort To { get; set; }
        [DBKey]
        public int ID { get; set; }
        public uint Cost { get; set; }
    }

    [DBTable(24461)]
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

    [DBTable(24461)]
    public class TerrainMaterial
    {
        [DBKey]
        public int ID { get; set; }
        public string Field04 { get; set; }
        public string Field08 { get; set; }
        public byte Field0C { get; set; }
    }

    [DBTable(24461)]
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

    [DBTable(24461)]
    public class TerrainTypeSounds
    {
        [DBKey]
        public int ID { get; set; }
        public string Field4 { get; set; }
    }

    [DBTable(24461)]
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

    [DBTable(24461)]
    public class TextureFileData
    {
        public uint Field0 { get; set; }
        public byte Field4 { get; set; }
        [DBKey]
        public int ID { get; set; }
    }

    [DBTable(24461)]
    public class TotemCategory
    {
        [DBKey]
        public int ID { get; set; }
        public string Name { get; set; }
        public uint CategoryMask { get; set; }
        public byte CategoryType { get; set; }
    }

    [DBTable(24461)]
    public class Toy
    {
        public uint ItemID { get; set; }
        public string Description { get; set; }
        public byte Flags { get; set; }
        public byte CategoryFilter { get; set; }
        [DBKey]
        public int ID { get; set; }
    }

    [DBTable(24461)]
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

    [DBTable(24461)]
    public class TradeSkillItem
    {
        [DBKey]
        public int ID { get; set; }
        public ushort Field4 { get; set; }
        public byte Field6 { get; set; }
    }

    [DBTable(24461)]
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

    [DBTable(24461)]
    public class TransmogSet
    {
        public string Field00 { get; set; }
        public ushort Field04 { get; set; }
        public ushort Field06 { get; set; }
        public byte Field08 { get; set; }
        [DBKey]
        public int ID { get; set; }
        public byte Field0B { get; set; }
        public ushort Field0C { get; set; }
        public ushort Field0E { get; set; }
        public ushort Field10 { get; set; }
        [DBField(ArraySize: 2)]
        public byte[] Field12 { get; set; }
    }

    [DBTable(24461)]
    public class TransmogSetItem
    {
        [DBKey]
        public int ID { get; set; }
        public ushort Field3 { get; set; }
        public int Field5 { get; set; }
        public byte Field8 { get; set; }
    }

    [DBTable(24461)]
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

    [DBTable(24461)]
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

    [DBTable(24461)]
    public class TransportRotation
    {
        [DBKey]
        public int ID { get; set; }
        public uint TransportID { get; set; }
        public uint TimeIndex { get; set; }
        [DBField(ArraySize: 4)]
        public float[] Position { get; set; }
    }

    [DBTable(24461)]
    public class Trophy
    {
        [DBKey]
        public int ID { get; set; }
        public string Field04 { get; set; }
        public ushort Field08 { get; set; }
        public byte Field0A { get; set; }
        public ushort Field0B { get; set; }
    }

    [DBTable(24461)]
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

    [DBTable(24461)]
    public class UiCameraType
    {
        [DBKey]
        public int ID { get; set; }
        public string Field04 { get; set; }
        public ushort Field08 { get; set; }
        public ushort Field0A { get; set; }
    }

    [DBTable(24461)]
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

    [DBTable(24461)]
    public class UiCamFbackTransmogWeapon
    {
        [DBKey]
        public int ID { get; set; }
        public ushort Field4 { get; set; }
        public byte Field6 { get; set; }
        public byte Field7 { get; set; }
        public byte Field8 { get; set; }
    }

    [DBTable(24461)]
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

    [DBTable(24461)]
    public class UiTextureAtlas
    {
        [DBKey]
        public int ID { get; set; }
        public uint Field04 { get; set; }
        public ushort Field08 { get; set; }
        public ushort Field0A { get; set; }
    }

    [DBTable(24461)]
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

    [DBTable(24461)]
    public class UiTextureKit
    {
        [DBKey]
        public int ID { get; set; }
        public string Field4 { get; set; }
    }

    [DBTable(24461)]
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

    [DBTable(24461)]
    public class UnitBloodLevels
    {
        [DBKey]
        public int ID { get; set; }
        public byte Field4 { get; set; }
    }

    [DBTable(24461)]
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

    [DBTable(24461)]
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

    [DBTable(24461)]
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

    [DBTable(24461)]
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

    [DBTable(24461)]
    public class VehicleUIIndicator
    {
        [DBKey]
        public int ID { get; set; }
        public string Field4 { get; set; }
    }

    [DBTable(24461)]
    public class VehicleUIIndSeat
    {
        [DBKey]
        public int ID { get; set; }
        public float Field04 { get; set; }
        public float Field08 { get; set; }
        public ushort Field0C { get; set; }
        public byte Field0E { get; set; }
    }

    [DBTable(24461)]
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

    [DBTable(24461)]
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

    [DBTable(24461)]
    public class VocalUISounds
    {
        [DBKey]
        public int ID { get; set; }
        public byte Field4 { get; set; }
        public byte Field5 { get; set; }
        public byte Field6 { get; set; }
        public ushort Field7 { get; set; }
    }

    [DBTable(24461)]
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

    [DBTable(24461)]
    public class WbCertWhitelist
    {
        [DBKey]
        public int ID { get; set; }
        public string Field04 { get; set; }
        public byte Field08 { get; set; }
        public byte Field09 { get; set; }
        public byte Field0A { get; set; }
    }

    [DBTable(24461)]
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

    [DBTable(24461)]
    public class WeaponSwingSounds2
    {
        [DBKey]
        public int ID { get; set; }
        public byte Field4 { get; set; }
        public byte Field5 { get; set; }
        public ushort Field6 { get; set; }
    }

    [DBTable(24461)]
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

    [DBTable(24461)]
    public class WeaponTrailModelDef
    {
        [DBKey]
        public int ID { get; set; }
        public uint Field04 { get; set; }
        public ushort Field08 { get; set; }
        public ushort Field0A { get; set; }
    }

    [DBTable(24461)]
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

    [DBTable(24461)]
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

    [DBTable(24461)]
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

    [DBTable(24461)]
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

    [DBTable(24461)]
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

    [DBTable(24461)]
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

    [DBTable(24461)]
    public class WorldBossLockout
    {
        [DBKey]
        public int ID { get; set; }
        public string Field4 { get; set; }
        public ushort Field8 { get; set; }
    }

    [DBTable(24461)]
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

    [DBTable(24461)]
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

    [DBTable(24461)]
    public class WorldElapsedTimer
    {
        [DBKey]
        public int ID { get; set; }
        public string Field4 { get; set; }
        public byte Field8 { get; set; }
        public byte Field9 { get; set; }
    }

    [DBTable(24461)]
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

    [DBTable(24461)]
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

    [DBTable(24461)]
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

    [DBTable(24461)]
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

    [DBTable(24461)]
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

    [DBTable(24461)]
    public class WorldState
    {
        [DBKey]
        public int ID { get; set; }
    }

    [DBTable(24461)]
    public class WorldStateExpression
    {
        [DBKey]
        public int ID { get; set; }
        public string Field4 { get; set; }
    }

    [DBTable(24461)]
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
        public ushort Field20 { get; set; }
        [DBField(ArraySize: 3)]
        public ushort[] Field22 { get; set; }
        public byte Field28 { get; set; }
        public byte Field29 { get; set; }
        public byte Field2A { get; set; }
        [DBKey]
        [DBField(ArraySize: 2)]
        public int[] ID { get; set; }
    }

    [DBTable(24461)]
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

    [DBTable(24461)]
    public class ZoneIntroMusicTable
    {
        [DBKey]
        public int ID { get; set; }
        public string Field04 { get; set; }
        public ushort Field08 { get; set; }
        public byte Field0A { get; set; }
        public int Field0B { get; set; }
    }

    [DBTable(24461)]
    public class ZoneLight
    {
        [DBKey]
        public int ID { get; set; }
        public string Field04 { get; set; }
        public ushort Field08 { get; set; }
        public ushort Field0A { get; set; }
    }

    [DBTable(24461)]
    public class ZoneLightPoint
    {
        [DBKey]
        public int ID { get; set; }
        [DBField(ArraySize: 2)]
        public int[] Field04 { get; set; }
        public ushort Field0C { get; set; }
        public byte Field0E { get; set; }
    }

    [DBTable(24461)]
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

    [DBTable(24461)]
    public class GarrItemLevelUpgradeData
    {
        [DBKey]
        public int ID { get; set; }
        public int Field04 { get; set; }
        public int Field08 { get; set; }
        public int Field0C { get; set; }
        public int Field10 { get; set; }
    }

    [DBTable(24461)]
    public class QuestXGroupActivity
    {
        [DBKey]
        public int ID { get; set; }
        public int Field00 { get; set; }
        public int Field04 { get; set; }
    }

    [DBTable(24461)]
    public class PvpScalingEffectType
    {
        [DBKey]
        public int ID { get; set; }
        public string Field00 { get; set; }
    }

    [DBTable(24461)]
    public class PvpScalingEffect
    {
        [DBKey]
        public int ID { get; set; }
        public float Field00 { get; set; }
        public int Field04 { get; set; }
        public int Field08 { get; set; }
    }

    [DBTable(24461)]
    public class ParagonReputation
    {
        [DBKey]
        public int ID { get; set; }
        public int Field00 { get; set; }
        public int Field04 { get; set; }
        public int Field08 { get; set; }
    }

    [DBTable(24461)]
    public class TransmogSetGroup
    {
        public string Field00 { get; set; }
        [DBKey]
        public int ID { get; set; }
    }

    [DBTable(24461)]
    public class TransmogHoliday
    {
        [DBKey]
        public int ID { get; set; }
        public int Field04 { get; set; }
    }

    [DBTable(24461)]
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

    [DBTable(24461)]
    public class UiModelSceneActorDisplay
    {
        [DBKey]
        public int ID { get; set; }
        public float Field00 { get; set; }
        public float Field04 { get; set; }
        public int Field08 { get; set; }
        public int Field0C { get; set; }
    }

    [DBTable(24461)]
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

    [DBTable(24461)]
    public class UiModelScene
    {
        [DBKey]
        public int ID { get; set; }
        public byte Field00 { get; set; }
        public byte Field01 { get; set; }
    }

    [DBTable(24461)]
    public class ManagedWorldStateInput
    {
        [DBKey]
        public int ID { get; set; }
        public int Field04 { get; set; }
        public int Field08 { get; set; }
    }

    [DBTable(24461)]
    public class ManagedWorldStateBuff
    {
        [DBKey]
        public int ID { get; set; }
        public int Field04 { get; set; }
        public int Field08 { get; set; }
        public int Field0C { get; set; }
        public int Field10 { get; set; }
    }

    [DBTable(24461)]
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

    [DBTable(24461)]
    public class ItemLevelSelector
    {
        [DBKey]
        public int ID { get; set; }
        public ushort Field00 { get; set; }
    }

    [DBTable(24461)]
    public class CreatureXContribution
    {
        [DBKey]
        public int ID { get; set; }
        public int Field04 { get; set; }
        public int Field08 { get; set; }
    }

    [DBTable(24461)]
    public class CreatureDisplayInfoEvt
    {
        [DBKey]
        public int ID { get; set; }
        public int Field00 { get; set; }
        public int Field04 { get; set; }
        public int Field08 { get; set; }
    }

    [DBTable(24461)]
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

    [DBTable(24461)]
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

    [DBTable(24461)]
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

    [DBTable(24461)]
    public class AnimKitReplacement
    {
        public ushort Field00 { get; set; }
        public ushort Field02 { get; set; }
        public ushort Field04 { get; set; }
        public ushort Field06 { get; set; }
        [DBKey]
        public int ID { get; set; }
    }
}
