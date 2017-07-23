using System;
using WDBXLib.Attributes;
using WDBXLib.Helpers;
using static WDBXLib.Common.Constants;

namespace WDBXLib.Definitions.WotLK
{

    [DBTable(Expansion.WotLK)]
    public class Achievement
    {
        [DBKey]
        public int ID { get; set; }
        public int Faction { get; set; }
        public int Instance_id { get; set; }
        public int Supercedes { get; set; }
        public LocalizedString Title_lang { get; set; }
        public LocalizedString Description_lang { get; set; }
        public int Category { get; set; }
        public int Points { get; set; }
        public int Ui_order { get; set; }
        public int Flags { get; set; }
        public int IconID { get; set; }
        public LocalizedString Reward_lang { get; set; }
        public int Minimum_criteria { get; set; }
        public int Shares_criteria { get; set; }
    }

    [DBTable(Expansion.WotLK)]
    public class Achievement_Category
    {
        [DBKey]
        public int ID { get; set; }
        public int Parent { get; set; }
        public LocalizedString Name_lang { get; set; }
        public int Ui_order { get; set; }
    }

    [DBTable(Expansion.WotLK)]
    public class Achievement_Criteria
    {
        [DBKey]
        public int ID { get; set; }
        public int Achievement_id { get; set; }
        public int Type { get; set; }
        public int Asset_id { get; set; }
        public int Quantity { get; set; }
        public int Start_event { get; set; }
        public int Start_asset { get; set; }
        public int Fail_event { get; set; }
        public int Fail_asset { get; set; }
        public LocalizedString Description_lang { get; set; }
        public int Flags { get; set; }
        public int Timer_start_event { get; set; }
        public int Timer_asset_id { get; set; }
        public int Timer_time { get; set; }
        public int Ui_order { get; set; }
    }

    [DBTable(Expansion.WotLK)]
    public class AnimationData
    {
        [DBKey]
        public int ID { get; set; }
        public string Name { get; set; }
        public int Weaponflags { get; set; }
        public int Bodyflags { get; set; }
        public int Flags { get; set; }
        public int Fallback { get; set; }
        public int BehaviorID { get; set; }
        public int BehaviorTier { get; set; }
    }

    [DBTable(Expansion.WotLK)]
    public class AnimKit
    {
        [DBKey]
        public int ID { get; set; }
        public int OneShotDuration { get; set; }
        public int OneShotStopAnimKitID { get; set; }
    }

    [DBTable(Expansion.WotLK)]
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

    [DBTable(Expansion.WotLK)]
    public class AnimKitBoneSetAlias
    {
        [DBKey]
        public int ID { get; set; }
        public int BoneDataID { get; set; }
        public int AnimKitBoneSetID { get; set; }
    }

    [DBTable(Expansion.WotLK)]
    public class AnimKitConfig
    {
        [DBKey]
        public int ID { get; set; }
        public int ConfigFlags { get; set; }
    }

    [DBTable(Expansion.WotLK)]
    public class AnimKitConfigBoneSet
    {
        [DBKey]
        public int ID { get; set; }
        public int ParentAnimKitConfigID { get; set; }
        public int AnimKitBoneSetID { get; set; }
        public int AnimKitPriorityID { get; set; }
    }

    [DBTable(Expansion.WotLK)]
    public class AnimKitPriority
    {
        [DBKey]
        public int ID { get; set; }
        public int Priority { get; set; }
    }

    [DBTable(Expansion.WotLK)]
    public class AnimKitSegment
    {
        [DBKey]
        public int ID { get; set; }
        public int ParentAnimKitID { get; set; }
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

    [DBTable(Expansion.WotLK)]
    public class AnimReplacement
    {
        [DBKey]
        public int ID { get; set; }
        public int SrcAnimID { get; set; }
        public int DstAnimID { get; set; }
        public int ParentAnimReplacementSetID { get; set; }
    }

    [DBTable(Expansion.WotLK)]
    public class AnimReplacementSet
    {
        [DBKey]
        public int ID { get; set; }
        public int ExecOrder { get; set; }
    }

    [DBTable(Expansion.WotLK)]
    public class AreaAssignment
    {
        [DBKey(AutoGenerated: true)]
        public int GeneratedID { get; set; }
        public int MapID { get; set; }
        public int AreaID { get; set; }
        public int ChunkX { get; set; }
        public int ChunkY { get; set; }
    }

    [DBTable(Expansion.WotLK)]
    public class AreaGroup
    {
        [DBKey]
        public int ID { get; set; }
        [DBField(ArraySize: 6)]
        public int[] AreaID { get; set; }
        public int NextAreaID { get; set; }
    }

    [DBTable(Expansion.WotLK)]
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
        public float Z { get; set; }
        public int ContinentID { get; set; }
        public int Flags { get; set; }
        public int AreaID { get; set; }
        public LocalizedString Name_lang { get; set; }
        public LocalizedString Description_lang { get; set; }
        public int WorldStateID { get; set; }
        public int WorldMapLink { get; set; }
    }

    [DBTable(Expansion.WotLK)]
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
        public LocalizedString AreaName_lang { get; set; }
        public int FactionGroupMask { get; set; }
        [DBField(ArraySize: 4)]
        public int[] LiquidTypeID { get; set; }
        public float MinElevation { get; set; }
        public float Ambient_multiplier { get; set; }
        public int Lightid { get; set; }
    }

    [DBTable(Expansion.WotLK)]
    public class AreaTrigger
    {
        [DBKey]
        public int ID { get; set; }
        public int ContinentID { get; set; }
        public float X { get; set; }
        public float Y { get; set; }
        public float Z { get; set; }
        public float Radius { get; set; }
        public float Box_length { get; set; }
        public float Box_width { get; set; }
        public float Box_height { get; set; }
        public float Box_yaw { get; set; }
    }

    [DBTable(Expansion.WotLK)]
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

    [DBTable(Expansion.WotLK)]
    public class AttackAnimKits
    {
        [DBKey]
        public int ID { get; set; }
        public int Animation { get; set; }
        public int Type { get; set; }
        public int Flags { get; set; }
        public int Unknown { get; set; }
    }

    [DBTable(Expansion.WotLK)]
    public class AttackAnimTypes
    {
        [DBKey]
        public int ID { get; set; }
        public string Name { get; set; }
    }

    [DBTable(Expansion.WotLK)]
    public class AuctionHouse
    {
        [DBKey]
        public int ID { get; set; }
        public int FactionID { get; set; }
        public int DepositRate { get; set; }
        public int ConsignmentRate { get; set; }
        public LocalizedString Name_lang { get; set; }
    }

    [DBTable(Expansion.WotLK)]
    public class BankBagSlotPrices
    {
        [DBKey]
        public int ID { get; set; }
        public int Cost { get; set; }
    }

    [DBTable(Expansion.WotLK)]
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

    [DBTable(Expansion.WotLK)]
    public class BarberShopStyle
    {
        [DBKey]
        public int ID { get; set; }
        public int Type { get; set; }
        public LocalizedString DisplayName_lang { get; set; }
        public LocalizedString Description_lang { get; set; }
        public float Cost_Modifier { get; set; }
        public int Race { get; set; }
        public int Sex { get; set; }
        public int Data { get; set; }
    }

    [DBTable(Expansion.WotLK)]
    public class BattlemasterList
    {
        [DBKey]
        public int ID { get; set; }
        [DBField(ArraySize: 8)]
        public int[] MapID { get; set; }
        public int InstanceType { get; set; }
        public int GroupsAllowed { get; set; }
        public LocalizedString Name_lang { get; set; }
        public int MaxGroupSize { get; set; }
        public int HolidayWorldState { get; set; }
        public int Minlevel { get; set; }
        public int Maxlevel { get; set; }
    }

    [DBTable(Expansion.WotLK)]
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
    }

    [DBTable(Expansion.WotLK)]
    public class Cfg_Categories
    {
        [DBKey]
        public int ID { get; set; }
        public int LocaleMask { get; set; }
        public int CharsetMask { get; set; }
        public int Flags { get; set; }
        public LocalizedString Name_lang { get; set; }
    }

    [DBTable(Expansion.WotLK)]
    public class Cfg_Configs
    {
        [DBKey(AutoGenerated: true)]
        public int GeneratedID { get; set; }
        public int ID { get; set; }
        public int RealmType { get; set; }
        public int PlayerKillingAllowed { get; set; }
        public int Roleplaying { get; set; }
    }

    [DBTable(Expansion.WotLK)]
    public class CharacterFacialHairStyles
    {
        [DBKey(AutoGenerated: true)]
        public int GeneratedID { get; set; }
        public int RaceID { get; set; }
        public int GenderID { get; set; }
        public int VariationID { get; set; }
        [DBField(ArraySize: 5)]
        public int[] Geoset { get; set; }
    }

    [DBTable(Expansion.WotLK)]
    public class CharBaseInfo
    {
        [DBKey(AutoGenerated: true)]
        public int GeneratedID { get; set; }
        public byte RaceID { get; set; }
        public byte ClassID { get; set; }
    }

    [DBTable(Expansion.WotLK)]
    public class CharHairGeosets
    {
        [DBKey]
        public int ID { get; set; }
        public int RaceID { get; set; }
        public int SexID { get; set; }
        public int VariationID { get; set; }
        public int GeosetID { get; set; }
        public int Showscalp { get; set; }
    }

    [DBTable(Expansion.WotLK)]
    public class CharHairTextures
    {
        [DBKey]
        public int ID { get; set; }
        public int Race { get; set; }
        public bool Gender { get; set; }
        public bool Unknown { get; set; }
        [DBField(ArraySize: 4)]
        public int[] UnknownInt { get; set; }
    }

    [DBTable(Expansion.WotLK)]
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

    [DBTable(Expansion.WotLK)]
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

    [DBTable(Expansion.WotLK)]
    public class CharTitles
    {
        [DBKey]
        public int ID { get; set; }
        public int Condition_ID { get; set; }
        public LocalizedString Name_lang { get; set; }
        public LocalizedString Name1_lang { get; set; }
        public int Mask_ID { get; set; }
    }

    [DBTable(Expansion.WotLK)]
    public class ChatChannels
    {
        [DBKey]
        public int ID { get; set; }
        public int Flags { get; set; }
        public int FactionGroup { get; set; }
        public LocalizedString Name_lang { get; set; }
        public LocalizedString Shortcut_lang { get; set; }
    }

    [DBTable(Expansion.WotLK)]
    public class ChatProfanity
    {
        [DBKey]
        public int ID { get; set; }
        public string Text { get; set; }
        public int Language { get; set; }
    }

    [DBTable(Expansion.WotLK)]
    public class ChrClasses
    {
        [DBKey]
        public int ID { get; set; }
        public int Unknown { get; set; }
        public int DisplayPower { get; set; }
        public int PetNameToken { get; set; }
        public LocalizedString Name_lang { get; set; }
        public LocalizedString Name_female_lang { get; set; }
        public LocalizedString Name_male_lang { get; set; }
        public string Filename { get; set; }
        public int SpellClassSet { get; set; }
        public int Flags { get; set; }
        public int CinematicSequenceID { get; set; }
        public int Required_expansion { get; set; }
    }

    [DBTable(Expansion.WotLK)]
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
        public LocalizedString Name_lang { get; set; }
        public LocalizedString Name_female_lang { get; set; }
        public LocalizedString Name_male_lang { get; set; }
        [DBField(ArraySize: 2)]
        public string[] FacialHairCustomization { get; set; }
        public string HairCustomization { get; set; }
        public int Required_expansion { get; set; }
    }

    [DBTable(Expansion.WotLK)]
    public class CinematicCamera
    {
        [DBKey]
        public int ID { get; set; }
        public string Model { get; set; }
        public int SoundID { get; set; }
        public float OriginX { get; set; }
        public float OriginY { get; set; }
        public float OriginZ { get; set; }
        public float OriginFacing { get; set; }
    }

    [DBTable(Expansion.WotLK)]
    public class CinematicSequences
    {
        [DBKey]
        public int ID { get; set; }
        public int SoundID { get; set; }
        [DBField(ArraySize: 8)]
        public int[] Camera { get; set; }
    }

    [DBTable(Expansion.WotLK)]
    public class CreatureDisplayInfo
    {
        [DBKey]
        public int ID { get; set; }
        public int ModelID { get; set; }
        public int SoundID { get; set; }
        public int ExtendedDisplayInfoID { get; set; }
        public float CreatureModelScale { get; set; }
        public int CreatureModelAlpha { get; set; }
        [DBField(ArraySize: 3)]
        public string[] TextureVariation { get; set; }
        public string PortraitTextureName { get; set; }
        public int BloodLevel { get; set; }
        public int BloodID { get; set; }
        public int NPCSoundID { get; set; }
        public int ParticleColorID { get; set; }
        public int CreatureGeosetData { get; set; }
        public int ObjectEffectPackageID { get; set; }
    }

    [DBTable(Expansion.WotLK)]
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
        public string BakeName { get; set; }
    }

    [DBTable(Expansion.WotLK)]
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
        public LocalizedString Name_lang { get; set; }
        public string IconFile { get; set; }
    }

    [DBTable(Expansion.WotLK)]
    public class CreatureModelData
    {
        [DBKey]
        public int ID { get; set; }
        public int Flags { get; set; }
        public string ModelName { get; set; }
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
        public float GeoBoxMinX { get; set; }
        public float GeoBoxMinY { get; set; }
        public float GeoBoxMinZ { get; set; }
        public float GeoBoxMaxX { get; set; }
        public float GeoBoxMaxY { get; set; }
        public float GeoBoxMaxZ { get; set; }
        public float WorldEffectScale { get; set; }
        public float AttachedEffectScale { get; set; }
        public float MissileCollisionRadius { get; set; }
        public float MissileCollisionPush { get; set; }
        public float MissileCollisionRaise { get; set; }
    }

    [DBTable(Expansion.WotLK)]
    public class CreatureMovementInfo
    {
        [DBKey]
        public int ID { get; set; }
        public float SmoothFacingChaseRate { get; set; }
    }

    [DBTable(Expansion.WotLK)]
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
    }

    [DBTable(Expansion.WotLK)]
    public class CreatureSpellData
    {
        [DBKey]
        public int ID { get; set; }
        [DBField(ArraySize: 4)]
        public int[] Spells { get; set; }
        [DBField(ArraySize: 4)]
        public int[] Availability { get; set; }
    }

    [DBTable(Expansion.WotLK)]
    public class CreatureType
    {
        [DBKey]
        public int ID { get; set; }
        public LocalizedString Name_lang { get; set; }
        public int Flags { get; set; }
    }

    [DBTable(Expansion.WotLK)]
    public class CurrencyCategory
    {
        [DBKey]
        public int ID { get; set; }
        public int Flags { get; set; }
        public LocalizedString Name_lang { get; set; }
    }

    [DBTable(Expansion.WotLK)]
    public class CurrencyTypes
    {
        [DBKey]
        public int ID { get; set; }
        public int ItemID { get; set; }
        public int CategoryID { get; set; }
        public int BitIndex { get; set; }
    }

    [DBTable(Expansion.WotLK)]
    public class DanceMoves
    {
        [DBKey]
        public int ID { get; set; }
        public int Type { get; set; }
        public int Param { get; set; }
        public int Fallback { get; set; }
        public int Racemask { get; set; }
        public string Internal_name { get; set; }
        public LocalizedString Name_lang { get; set; }
        public int LockID { get; set; }
    }

    [DBTable(Expansion.WotLK)]
    public class DeathThudLookups
    {
        [DBKey]
        public int ID { get; set; }
        public int SizeClass { get; set; }
        public int TerraintypeSoundID { get; set; }
        public int SoundEntryID { get; set; }
        public int SoundEntryIDWater { get; set; }
    }

    [DBTable(Expansion.WotLK)]
    public class DeclinedWord
    {
        [DBKey]
        public int ID { get; set; }
        public string Word { get; set; }
    }

    [DBTable(Expansion.WotLK)]
    public class DeclinedWordCases
    {
        [DBKey]
        public int ID { get; set; }
        public int DeclinedWordID { get; set; }
        public int CaseIndex { get; set; }
        public string DeclinedWord { get; set; }
    }

    [DBTable(Expansion.WotLK)]
    public class DestructibleModelData
    {
        [DBKey]
        public int ID { get; set; }
        public int State0Wmo { get; set; }
        public int State0DestructionDoodadSet { get; set; }
        public int State0ImpactEffectDoodadSet { get; set; }
        public int State0AmbientDoodadSet { get; set; }
        public int State1Wmo { get; set; }
        public int State1DestructionDoodadSet { get; set; }
        public int State1ImpactEffectDoodadSet { get; set; }
        public int State1AmbientDoodadSet { get; set; }
        public int State2Wmo { get; set; }
        public int State2DestructionDoodadSet { get; set; }
        public int State2ImpactEffectDoodadSet { get; set; }
        public int State2AmbientDoodadSet { get; set; }
        public int State3Wmo { get; set; }
        public int State3DestructionDoodadSet { get; set; }
        public int State3ImpactEffectDoodadSet { get; set; }
        public int State3AmbientDoodadSet { get; set; }
        public int Unknown { get; set; }
        public int Unknown1 { get; set; }
    }

    [DBTable(Expansion.WotLK)]
    public class DungeonEncounter
    {
        [DBKey]
        public int ID { get; set; }
        public int MapID { get; set; }
        public int Difficulty { get; set; }
        public int OrderIndex { get; set; }
        public int Bit { get; set; }
        public LocalizedString Name_lang { get; set; }
        public int SpellIconID { get; set; }
    }

    [DBTable(Expansion.WotLK)]
    public class DungeonMap
    {
        [DBKey]
        public int ID { get; set; }
        public int MapID { get; set; }
        public int FloorIndex { get; set; }
        public float MinX { get; set; }
        public float MaxX { get; set; }
        public float MinY { get; set; }
        public float MaxY { get; set; }
        public int ParentWorldMapID { get; set; }
    }

    [DBTable(Expansion.WotLK)]
    public class DungeonMapChunk
    {
        [DBKey]
        public int ID { get; set; }
        public int MapID { get; set; }
        public int WmoGroupID { get; set; }
        public int DungeonMapID { get; set; }
        public float MinZ { get; set; }
    }

    [DBTable(Expansion.WotLK)]
    public class DurabilityCosts
    {
        [DBKey]
        public int ID { get; set; }
        [DBField(ArraySize: 21)]
        public int[] WeaponSubClassCost { get; set; }
        [DBField(ArraySize: 8)]
        public int[] ArmorSubClassCost { get; set; }
    }

    [DBTable(Expansion.WotLK)]
    public class DurabilityQuality
    {
        [DBKey]
        public int ID { get; set; }
        public float Data { get; set; }
    }

    [DBTable(Expansion.WotLK)]
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
    }

    [DBTable(Expansion.WotLK)]
    public class EmotesText
    {
        [DBKey]
        public int ID { get; set; }
        public string Name { get; set; }
        public int EmoteID { get; set; }
        [DBField(ArraySize: 16)]
        public int[] EmoteText { get; set; }
    }

    [DBTable(Expansion.WotLK)]
    public class EmotesTextData
    {
        [DBKey]
        public int ID { get; set; }
        public LocalizedString Text_lang { get; set; }
    }

    [DBTable(Expansion.WotLK)]
    public class EmotesTextSound
    {
        [DBKey]
        public int ID { get; set; }
        public int EmotesTextID { get; set; }
        public int RaceID { get; set; }
        public int SexID { get; set; }
        public int SoundID { get; set; }
    }

    [DBTable(Expansion.WotLK)]
    public class EnvironmentalDamage
    {
        [DBKey]
        public int ID { get; set; }
        public int EnumID { get; set; }
        public int VisualkitID { get; set; }
    }

    [DBTable(Expansion.WotLK)]
    public class Exhaustion
    {
        [DBKey]
        public int ID { get; set; }
        public int Xp { get; set; }
        public float Factor { get; set; }
        public float OutdoorHours { get; set; }
        public float InnHours { get; set; }
        public LocalizedString Name_lang { get; set; }
        public float Threshold { get; set; }
    }

    [DBTable(Expansion.WotLK)]
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
        public LocalizedString Name_lang { get; set; }
        public LocalizedString Description_lang { get; set; }
    }

    [DBTable(Expansion.WotLK)]
    public class FactionGroup
    {
        [DBKey]
        public int ID { get; set; }
        public int MaskID { get; set; }
        public string InternalName { get; set; }
        public LocalizedString Name_lang { get; set; }
    }

    [DBTable(Expansion.WotLK)]
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

    [DBTable(Expansion.WotLK)]
    public class FileData
    {
        [DBKey]
        public int ID { get; set; }
        public string Filename { get; set; }
        public string Filepath { get; set; }
    }

    [DBTable(Expansion.WotLK)]
    public class FootprintTextures
    {
        [DBKey]
        public int ID { get; set; }
        public string FootstepFilename { get; set; }
    }

    [DBTable(Expansion.WotLK)]
    public class FootstepTerrainLookup
    {
        [DBKey]
        public int ID { get; set; }
        public int CreatureFootstepID { get; set; }
        public int TerrainSoundID { get; set; }
        public int SoundID { get; set; }
        public int SoundIDSplash { get; set; }
    }

    [DBTable(Expansion.WotLK)]
    public class GameObjectArtKit
    {
        [DBKey]
        public int ID { get; set; }
        [DBField(ArraySize: 3)]
        public string[] TextureVariation { get; set; }
        [DBField(ArraySize: 4)]
        public string[] AttachModel { get; set; }
    }

    [DBTable(Expansion.WotLK)]
    public class GameObjectDisplayInfo
    {
        [DBKey]
        public int ID { get; set; }
        public string ModelName { get; set; }
        [DBField(ArraySize: 10)]
        public int[] Sound { get; set; }
        public float GeoBoxMinX { get; set; }
        public float GeoBoxMinY { get; set; }
        public float GeoBoxMinZ { get; set; }
        public float GeoBoxMaxX { get; set; }
        public float GeoBoxMaxY { get; set; }
        public float GeoBoxMaxZ { get; set; }
        public int ObjectEffectPackageID { get; set; }
    }

    [DBTable(Expansion.WotLK)]
    public class GameTables
    {
        [DBKey(AutoGenerated: true)]
        public int GeneratedID { get; set; }
        public string Name { get; set; }
        public int NumRows { get; set; }
        public int NumColumns { get; set; }
    }

    [DBTable(Expansion.WotLK)]
    public class GameTips
    {
        [DBKey]
        public int ID { get; set; }
        public LocalizedString Text_lang { get; set; }
    }

    [DBTable(Expansion.WotLK)]
    public class GemProperties
    {
        [DBKey]
        public int Id { get; set; }
        public int Enchant_id { get; set; }
        public int Maxcount_inv { get; set; }
        public int Maxcount_item { get; set; }
        public int Type { get; set; }
    }

    [DBTable(Expansion.WotLK)]
    public class GlyphProperties
    {
        [DBKey]
        public int Id { get; set; }
        public int SpellID { get; set; }
        public int GlyphSlotFlags { get; set; }
        public int SpellIconID { get; set; }
    }

    [DBTable(Expansion.WotLK)]
    public class GlyphSlot
    {
        [DBKey]
        public int Id { get; set; }
        public int Type { get; set; }
        public int Tooltip { get; set; }
    }

    [DBTable(Expansion.WotLK)]
    public class GMSurveyAnswers
    {
        [DBKey]
        public int ID { get; set; }
        public int Sort_Index { get; set; }
        public int GMSurveyQuestionID { get; set; }
        public LocalizedString Answer_lang { get; set; }
    }

    [DBTable(Expansion.WotLK)]
    public class GMSurveyCurrentSurvey
    {
        [DBKey]
        public int LANGID { get; set; }
        public int GMSURVEY_ID { get; set; }
    }

    [DBTable(Expansion.WotLK)]
    public class GMSurveyQuestions
    {
        [DBKey]
        public int ID { get; set; }
        public LocalizedString Question_lang { get; set; }
    }

    [DBTable(Expansion.WotLK)]
    public class GMSurveySurveys
    {
        [DBKey]
        public int ID { get; set; }
        [DBField(ArraySize: 10)]
        public int[] Q { get; set; }
    }

    [DBTable(Expansion.WotLK)]
    public class GMTicketCategory
    {
        [DBKey]
        public int ID { get; set; }
        public LocalizedString Category_lang { get; set; }
    }

    [DBTable(Expansion.WotLK)]
    public class GroundEffectDoodad
    {
        [DBKey]
        public int ID { get; set; }
        public string Doodadpath { get; set; }
        public int Flags { get; set; }
    }

    [DBTable(Expansion.WotLK)]
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

    [DBTable(Expansion.WotLK)]
    public class GtBarberShopCostBase
    {
        [DBKey(AutoGenerated: true)]
        public int GeneratedID { get; set; }
        public float Data { get; set; }
    }

    [DBTable(Expansion.WotLK)]
    public class GtChanceToMeleeCrit
    {
        [DBKey(AutoGenerated: true)]
        public int GeneratedID { get; set; }
        public float Data { get; set; }
    }

    [DBTable(Expansion.WotLK)]
    public class GtChanceToMeleeCritBase
    {
        [DBKey(AutoGenerated: true)]
        public int GeneratedID { get; set; }
        public float Data { get; set; }
    }

    [DBTable(Expansion.WotLK)]
    public class GtChanceToSpellCrit
    {
        [DBKey(AutoGenerated: true)]
        public int GeneratedID { get; set; }
        public float Data { get; set; }
    }

    [DBTable(Expansion.WotLK)]
    public class GtChanceToSpellCritBase
    {
        [DBKey(AutoGenerated: true)]
        public int GeneratedID { get; set; }
        public float Data { get; set; }
    }

    [DBTable(Expansion.WotLK)]
    public class GtCombatRatings
    {
        [DBKey(AutoGenerated: true)]
        public int GeneratedID { get; set; }
        public float Data { get; set; }
    }

    [DBTable(Expansion.WotLK)]
    public class GtNPCManaCostScaler
    {
        [DBKey(AutoGenerated: true)]
        public int GeneratedID { get; set; }
        public float Data { get; set; }
    }

    [DBTable(Expansion.WotLK)]
    public class GtOCTClassCombatRatingScalar
    {
        [DBKey]
        public int ID { get; set; }
        public float Data { get; set; }
    }

    [DBTable(Expansion.WotLK)]
    public class GtOCTRegenHP
    {
        [DBKey(AutoGenerated: true)]
        public int GeneratedID { get; set; }
        public float Data { get; set; }
    }

    [DBTable(Expansion.WotLK)]
    public class GtOCTRegenMP
    {
        [DBKey(AutoGenerated: true)]
        public int GeneratedID { get; set; }
        public float Data { get; set; }
    }

    [DBTable(Expansion.WotLK)]
    public class GtRegenHPPerSpt
    {
        [DBKey(AutoGenerated: true)]
        public int GeneratedID { get; set; }
        public float Data { get; set; }
    }

    [DBTable(Expansion.WotLK)]
    public class GtRegenMPPerSpt
    {
        [DBKey(AutoGenerated: true)]
        public int GeneratedID { get; set; }
        public float Data { get; set; }
    }

    [DBTable(Expansion.WotLK)]
    public class GtSpellScaling
    {
        [DBKey(AutoGenerated: true)]
        public int GeneratedID { get; set; }
        public float Data { get; set; }
    }

    [DBTable(Expansion.WotLK)]
    public class HelmetGeosetVisData
    {
        [DBKey]
        public int ID { get; set; }
        [DBField(ArraySize: 7)]
        public int[] HideGeoset { get; set; }
    }

    [DBTable(Expansion.WotLK)]
    public class HolidayDescriptions
    {
        [DBKey]
        public int ID { get; set; }
        public LocalizedString Description_lang { get; set; }
    }

    [DBTable(Expansion.WotLK)]
    public class HolidayNames
    {
        [DBKey]
        public int ID { get; set; }
        public LocalizedString Name_lang { get; set; }
    }

    [DBTable(Expansion.WotLK)]
    public class Holidays
    {
        [DBKey]
        public int ID { get; set; }
        [DBField(ArraySize: 10)]
        public int[] Duration { get; set; }
        [DBField(ArraySize: 26)]
        public int[] Date { get; set; }
        public int Region { get; set; }
        public int Looping { get; set; }
        [DBField(ArraySize: 10)]
        public int[] CalendarFlags { get; set; }
        public int HolidayNameID { get; set; }
        public int HolidayDescriptionID { get; set; }
        public string TextureFilename { get; set; }
        public int Priority { get; set; }
        public int CalendarFilterType { get; set; }
        public int Flags { get; set; }
    }

    [DBTable(Expansion.WotLK)]
    public class Item
    {
        [DBKey]
        public int ID { get; set; }
        public int ClassID { get; set; }
        public int SubclassID { get; set; }
        public int Sound_override_subclassid { get; set; }
        public int Material { get; set; }
        public int DisplayInfoID { get; set; }
        public int InventoryType { get; set; }
        public int SheatheType { get; set; }
    }

    [DBTable(Expansion.WotLK)]
    public class ItemArmorQuality
    {
        [DBKey]
        public int ID { get; set; }
        [DBField(ArraySize: 7)]
        public float[] Qualitymod { get; set; }
        public int ItemLevel { get; set; }
    }

    [DBTable(Expansion.WotLK)]
    public class ItemArmorShield
    {
        [DBKey]
        public int ID { get; set; }
        public int ItemLevel { get; set; }
        [DBField(ArraySize: 7)]
        public float[] Quality { get; set; }
    }

    [DBTable(Expansion.WotLK)]
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

    [DBTable(Expansion.WotLK)]
    public class ItemBagFamily
    {
        [DBKey]
        public int ID { get; set; }
        public LocalizedString Name_lang { get; set; }
    }

    [DBTable(Expansion.WotLK)]
    public class ItemClass
    {
        [DBKey(AutoGenerated: true)]
        public int GeneratedID { get; set; }
        public int ClassID { get; set; }
        public int SubclassMapID { get; set; }
        public int Flags { get; set; }
        public LocalizedString ClassName_lang { get; set; }
    }

    [DBTable(Expansion.WotLK)]
    public class ItemCondExtCosts
    {
        [DBKey]
        public int ID { get; set; }
        public int Unknown { get; set; }
        public int ItemExtendedCost { get; set; }
        public int Unknown1 { get; set; }
    }

    [DBTable(Expansion.WotLK)]
    public class ItemDamageAmmo
    {
        [DBKey]
        public int ID { get; set; }
        [DBField(ArraySize: 7)]
        public float[] Quality { get; set; }
        public int ItemLevel { get; set; }
    }

    [DBTable(Expansion.WotLK)]
    public class ItemDamageOneHand
    {
        [DBKey]
        public int ID { get; set; }
        [DBField(ArraySize: 7)]
        public float[] Quality { get; set; }
        public int ItemLevel { get; set; }
    }

    [DBTable(Expansion.WotLK)]
    public class ItemDamageOneHandCaster
    {
        [DBKey]
        public int ID { get; set; }
        [DBField(ArraySize: 7)]
        public float[] Quality { get; set; }
        public int ItemLevel { get; set; }
    }

    [DBTable(Expansion.WotLK)]
    public class ItemDamageRanged
    {
        [DBKey]
        public int ID { get; set; }
        [DBField(ArraySize: 7)]
        public float[] Quality { get; set; }
        public int ItemLevel { get; set; }
    }

    [DBTable(Expansion.WotLK)]
    public class ItemDamageThrown
    {
        [DBKey]
        public int ID { get; set; }
        [DBField(ArraySize: 7)]
        public float[] Quality { get; set; }
        public int ItemLevel { get; set; }
    }

    [DBTable(Expansion.WotLK)]
    public class ItemDamageTwoHand
    {
        [DBKey]
        public int ID { get; set; }
        [DBField(ArraySize: 7)]
        public float[] Quality { get; set; }
        public int ItemLevel { get; set; }
    }

    [DBTable(Expansion.WotLK)]
    public class ItemDamageTwoHandCaster
    {
        [DBKey]
        public int ID { get; set; }
        [DBField(ArraySize: 7)]
        public float[] Quality { get; set; }
        public int ItemLevel { get; set; }
    }

    [DBTable(Expansion.WotLK)]
    public class ItemDamageWand
    {
        [DBKey]
        public int ID { get; set; }
        [DBField(ArraySize: 7)]
        public float[] Quality { get; set; }
        public int ItemLevel { get; set; }
    }

    [DBTable(Expansion.WotLK)]
    public class ItemDisplayInfo
    {
        [DBKey]
        public int ID { get; set; }
        [DBField(ArraySize: 2)]
        public string[] ModelName { get; set; }
        [DBField(ArraySize: 2)]
        public string[] ModelTexture { get; set; }
        [DBField(ArraySize: 2)]
        public string[] InventoryIcon { get; set; }
        [DBField(ArraySize: 3)]
        public int[] GeosetGroup { get; set; }
        public int Flags { get; set; }
        public int SpellVisualID { get; set; }
        public int GroupSoundIndex { get; set; }
        [DBField(ArraySize: 2)]
        public int[] HelmetGeosetVis { get; set; }
        [DBField(ArraySize: 8)]
        public string[] Texture { get; set; }
        public int ItemVisual { get; set; }
        public int ParticleColorID { get; set; }
    }

    [DBTable(Expansion.WotLK)]
    public class ItemExtendedCost
    {
        [DBKey]
        public int ID { get; set; }
        public int HonorPoints { get; set; }
        public int ArenaPoints { get; set; }
        public int ArenaBracket { get; set; }
        [DBField(ArraySize: 5)]
        public int[] ItemID { get; set; }
        [DBField(ArraySize: 5)]
        public int[] ItemCount { get; set; }
        public int RequiredArenaRating { get; set; }
        public int ItemPurchaseGroup { get; set; }
    }

    [DBTable(Expansion.WotLK)]
    public class ItemGroupSounds
    {
        [DBKey]
        public int ID { get; set; }
        [DBField(ArraySize: 4)]
        public int[] Sound { get; set; }
    }

    [DBTable(Expansion.WotLK)]
    public class ItemLimitCategory
    {
        [DBKey]
        public int ID { get; set; }
        public LocalizedString Name_lang { get; set; }
        public int Quantity { get; set; }
        public int Flags { get; set; }
    }

    [DBTable(Expansion.WotLK)]
    public class ItemPetFood
    {
        [DBKey]
        public int ID { get; set; }
        public LocalizedString Name_lang { get; set; }
    }

    [DBTable(Expansion.WotLK)]
    public class ItemPurchaseGroup
    {
        [DBKey]
        public int ID { get; set; }
        [DBField(ArraySize: 8)]
        public int[] ItemID { get; set; }
        public LocalizedString Name_lang { get; set; }
    }

    [DBTable(Expansion.WotLK)]
    public class ItemRandomProperties
    {
        [DBKey]
        public int ID { get; set; }
        public string Name { get; set; }
        [DBField(ArraySize: 5)]
        public int[] Enchantment { get; set; }
        public LocalizedString Name_lang { get; set; }
    }

    [DBTable(Expansion.WotLK)]
    public class ItemRandomSuffix
    {
        [DBKey]
        public int ID { get; set; }
        public LocalizedString Name_lang { get; set; }
        public string InternalName { get; set; }
        [DBField(ArraySize: 5)]
        public int[] Enchantment { get; set; }
        [DBField(ArraySize: 5)]
        public int[] AllocationPct { get; set; }
    }

    [DBTable(Expansion.WotLK)]
    public class ItemSet
    {
        [DBKey]
        public int ID { get; set; }
        public LocalizedString Name_lang { get; set; }
        [DBField(ArraySize: 17)]
        public int[] ItemID { get; set; }
        [DBField(ArraySize: 8)]
        public int[] SetSpellID { get; set; }
        [DBField(ArraySize: 8)]
        public int[] SetThreshold { get; set; }
        public int RequiredSkill { get; set; }
        public int RequiredSkillRank { get; set; }
    }

    [DBTable(Expansion.WotLK)]
    public class ItemSubClass
    {
        [DBKey(AutoGenerated: true)]
        public int GeneratedID { get; set; }
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
        public LocalizedString DisplayName_lang { get; set; }
        public LocalizedString VerboseName_lang { get; set; }
    }

    [DBTable(Expansion.WotLK)]
    public class ItemSubClassMask
    {
        [DBKey(AutoGenerated: true)]
        public int GeneratedID { get; set; }
        public int ClassID { get; set; }
        public int Mask { get; set; }
        public LocalizedString Name_lang { get; set; }
    }

    [DBTable(Expansion.WotLK)]
    public class ItemVisualEffects
    {
        [DBKey]
        public int ID { get; set; }
        public string Model { get; set; }
    }

    [DBTable(Expansion.WotLK)]
    public class ItemVisuals
    {
        [DBKey]
        public int ID { get; set; }
        [DBField(ArraySize: 5)]
        public int[] Slot { get; set; }
    }

    [DBTable(Expansion.WotLK)]
    public class Languages
    {
        [DBKey]
        public int ID { get; set; }
        public LocalizedString Name_lang { get; set; }
    }

    [DBTable(Expansion.WotLK)]
    public class LanguageWords
    {
        [DBKey]
        public int ID { get; set; }
        public int LanguageID { get; set; }
        public string Word { get; set; }
    }

    [DBTable(Expansion.WotLK)]
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

    [DBTable(Expansion.WotLK)]
    public class LfgDungeonGroup
    {
        [DBKey]
        public int ID { get; set; }
        public LocalizedString Name_lang { get; set; }
        public int Order_index { get; set; }
        public int Parent_group_id { get; set; }
        public int Typeid { get; set; }
    }

    [DBTable(Expansion.WotLK)]
    public class LfgDungeons
    {
        [DBKey]
        public int ID { get; set; }
        public LocalizedString Name_lang { get; set; }
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
        public LocalizedString Description_lang { get; set; }
    }

    [DBTable(Expansion.WotLK)]
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

    [DBTable(Expansion.WotLK)]
    public class LightfloatBand
    {
        [DBKey]
        public int ID { get; set; }
        public int Num { get; set; }
        [DBField(ArraySize: 16)]
        public int[] Time { get; set; }
        [DBField(ArraySize: 16)]
        public float[] Data { get; set; }
    }

    [DBTable(Expansion.WotLK)]
    public class LightintBand
    {
        [DBKey]
        public int ID { get; set; }
        public int Num { get; set; }
        [DBField(ArraySize: 16)]
        public int[] Time { get; set; }
        [DBField(ArraySize: 16)]
        public int[] Data { get; set; }
    }

    [DBTable(Expansion.WotLK)]
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
    }

    [DBTable(Expansion.WotLK)]
    public class LightSkybox
    {
        [DBKey]
        public int ID { get; set; }
        public string Name { get; set; }
        public int Flags { get; set; }
    }

    [DBTable(Expansion.WotLK)]
    public class LiquidMaterial
    {
        [DBKey]
        public int ID { get; set; }
        public int LVF { get; set; }
        public int Flags { get; set; }
    }

    [DBTable(Expansion.WotLK)]
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

    [DBTable(Expansion.WotLK)]
    public class LoadingScreens
    {
        [DBKey]
        public int ID { get; set; }
        public string Name { get; set; }
        public string FileName { get; set; }
        public int HasWideScreen { get; set; }
    }

    [DBTable(Expansion.WotLK)]
    public class LoadingScreenTaxiSplines
    {
        [DBKey]
        public int ID { get; set; }
        public int PathID { get; set; }
        [DBField(ArraySize: 8)]
        public float[] Locx { get; set; }
        [DBField(ArraySize: 8)]
        public float[] Locy { get; set; }
        public int LegIndex { get; set; }
    }

    [DBTable(Expansion.WotLK)]
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

    [DBTable(Expansion.WotLK)]
    public class LockType
    {
        [DBKey]
        public int ID { get; set; }
        public LocalizedString Name_lang { get; set; }
        public LocalizedString ResourceName_lang { get; set; }
        public LocalizedString Verb_lang { get; set; }
        public string CursorName { get; set; }
    }

    [DBTable(Expansion.WotLK)]
    public class MailTemplate
    {
        [DBKey]
        public int ID { get; set; }
        public LocalizedString Subject_lang { get; set; }
        public LocalizedString Body_lang { get; set; }
    }

    [DBTable(Expansion.WotLK)]
    public class Map
    {
        [DBKey]
        public int ID { get; set; }
        public string Directory { get; set; }
        public int InstanceType { get; set; }
        public int Flags { get; set; }
        public int PVP { get; set; }
        public LocalizedString MapName_lang { get; set; }
        public int AreaTableID { get; set; }
        public LocalizedString MapDescription0_lang { get; set; }
        public LocalizedString MapDescription1_lang { get; set; }
        public int LoadingScreenID { get; set; }
        public float MinimapIconScale { get; set; }
        public int CorpseMapID { get; set; }
        public float CorpseX { get; set; }
        public float CorpseY { get; set; }
        public int TimeOfDayOverride { get; set; }
        public int ExpansionID { get; set; }
        public int RaidOffset { get; set; }
        public int MaxPlayers { get; set; }
    }

    [DBTable(Expansion.WotLK)]
    public class MapDifficulty
    {
        [DBKey]
        public int ID { get; set; }
        public int MapID { get; set; }
        public int Difficulty { get; set; }
        public LocalizedString Message_lang { get; set; }
        public int RaidDuration { get; set; }
        public int MaxPlayers { get; set; }
        public string Difficultystring { get; set; }
    }

    [DBTable(Expansion.WotLK)]
    public class Material
    {
        [DBKey]
        public int ID { get; set; }
        public int Flags { get; set; }
        public int FoleySoundID { get; set; }
        public int SheatheSoundID { get; set; }
        public int UnsheatheSoundID { get; set; }
    }

    [DBTable(Expansion.WotLK)]
    public class Movie
    {
        [DBKey]
        public int ID { get; set; }
        public string Filename { get; set; }
        public int Volume { get; set; }
    }

    [DBTable(Expansion.WotLK)]
    public class MovieFileData
    {
        [DBKey]
        public int FileDataID { get; set; }
        public int Resolution { get; set; }
    }

    [DBTable(Expansion.WotLK)]
    public class MovieVariation
    {
        [DBKey]
        public int ID { get; set; }
        public int MovieID { get; set; }
        public int FileDataID { get; set; }
    }

    [DBTable(Expansion.WotLK)]
    public class NameGen
    {
        [DBKey]
        public int ID { get; set; }
        public string Name { get; set; }
        public int RaceID { get; set; }
        public int Sex { get; set; }
    }

    [DBTable(Expansion.WotLK)]
    public class NamesProfanity
    {
        [DBKey]
        public int ID { get; set; }
        public string Name { get; set; }
        public int Language { get; set; }
    }

    [DBTable(Expansion.WotLK)]
    public class NamesReserved
    {
        [DBKey]
        public int ID { get; set; }
        public string Name { get; set; }
        public int Language { get; set; }
    }

    [DBTable(Expansion.WotLK)]
    public class NPCSounds
    {
        [DBKey]
        public int ID { get; set; }
        [DBField(ArraySize: 4)]
        public int[] SoundID { get; set; }
    }

    [DBTable(Expansion.WotLK)]
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
        public float OffsetX { get; set; }
        public float OffsetY { get; set; }
        public float OffsetZ { get; set; }
        public int ObjectEffectModifierID { get; set; }
    }

    [DBTable(Expansion.WotLK)]
    public class ObjectEffectGroup
    {
        [DBKey]
        public int ID { get; set; }
        public string Name { get; set; }
    }

    [DBTable(Expansion.WotLK)]
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

    [DBTable(Expansion.WotLK)]
    public class ObjectEffectPackage
    {
        [DBKey]
        public int ID { get; set; }
        public string Name { get; set; }
    }

    [DBTable(Expansion.WotLK)]
    public class ObjectEffectPackageElem
    {
        [DBKey]
        public int ID { get; set; }
        public int ObjectEffectPackageID { get; set; }
        public int ObjectEffectGroupID { get; set; }
        public int StateType { get; set; }
    }

    [DBTable(Expansion.WotLK)]
    public class OverrideSpellData
    {
        [DBKey]
        public int ID { get; set; }
        [DBField(ArraySize: 10)]
        public int[] Spells { get; set; }
        public int Flags { get; set; }
    }

    [DBTable(Expansion.WotLK)]
    public class Package
    {
        [DBKey]
        public int ID { get; set; }
        public string Icon { get; set; }
        public int Cost { get; set; }
        public LocalizedString Name_lang { get; set; }
    }

    [DBTable(Expansion.WotLK)]
    public class PageTextMaterial
    {
        [DBKey]
        public int ID { get; set; }
        public string Name { get; set; }
    }

    [DBTable(Expansion.WotLK)]
    public class PaperDollItemFrame
    {
        [DBKey(AutoGenerated: true)]
        public int GeneratedID { get; set; }
        public string ItemButtonName { get; set; }
        public string SlotIcon { get; set; }
        public int SlotNumber { get; set; }
    }

    [DBTable(Expansion.WotLK)]
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

    [DBTable(Expansion.WotLK)]
    public class PetitionType
    {
        [DBKey]
        public int ID { get; set; }
        public int RefName { get; set; }
        public int Unknown { get; set; }
    }

    [DBTable(Expansion.WotLK)]
    public class PetPersonality
    {
        [DBKey]
        public int ID { get; set; }
        public LocalizedString Name_lang { get; set; }
        [DBField(ArraySize: 3)]
        public int[] HappinessThreshold { get; set; }
        [DBField(ArraySize: 3)]
        public float[] HappinessDamage { get; set; }
    }

    [DBTable(Expansion.WotLK)]
    public class Phase
    {
        [DBKey]
        public int ID { get; set; }
        public int MapID { get; set; }
        public int PhaseShift { get; set; }
        [DBField(ArraySize: 5)]
        public int[] ChildMap { get; set; }
    }

    [DBTable(Expansion.WotLK)]
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

    [DBTable(Expansion.WotLK)]
    public class PvpDifficulty
    {
        [DBKey]
        public int ID { get; set; }
        public int MapID { get; set; }
        public int RangeIndex { get; set; }
        public int MinLevel { get; set; }
        public int MaxLevel { get; set; }
        public int Difficulty { get; set; }
    }

    [DBTable(Expansion.WotLK)]
    public class QuestFactionReward
    {
        [DBKey]
        public int ID { get; set; }
        [DBField(ArraySize: 10)]
        public int[] Difficulty { get; set; }
    }

    [DBTable(Expansion.WotLK)]
    public class QuestInfo
    {
        [DBKey]
        public int ID { get; set; }
        public LocalizedString InfoName_lang { get; set; }
    }

    [DBTable(Expansion.WotLK)]
    public class QuestSort
    {
        [DBKey]
        public int ID { get; set; }
        public LocalizedString SortName_lang { get; set; }
    }

    [DBTable(Expansion.WotLK)]
    public class QuestXP
    {
        [DBKey]
        public int ID { get; set; }
        [DBField(ArraySize: 10)]
        public int[] Difficulty { get; set; }
    }

    [DBTable(Expansion.WotLK)]
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

    [DBTable(Expansion.WotLK)]
    public class Resistances
    {
        [DBKey]
        public int ID { get; set; }
        public int Flags { get; set; }
        public int FizzleSoundID { get; set; }
        public LocalizedString Name_lang { get; set; }
    }

    [DBTable(Expansion.WotLK)]
    public class ScalingStatDistribution
    {
        [DBKey]
        public int ID { get; set; }
        [DBField(ArraySize: 10)]
        public int[] StatID { get; set; }
        [DBField(ArraySize: 10)]
        public int[] Bonus { get; set; }
        public int Maxlevel { get; set; }
    }

    [DBTable(Expansion.WotLK)]
    public class ScalingStatValues
    {
        [DBKey]
        public int ID { get; set; }
        public int Charlevel { get; set; }
        public int ShoulderBudget { get; set; }
        public int TrinketBudget { get; set; }
        public int WeaponBudget1H { get; set; }
        public int RangedBudget { get; set; }
        public int ClothShoulderArmor { get; set; }
        public int LeatherShoulderArmor { get; set; }
        public int MailShoulderArmor { get; set; }
        public int PlateShoulderArmor { get; set; }
        public int WeaponDPS1H { get; set; }
        public int WeaponDPS2H { get; set; }
        public int SpellcasterDPS1H { get; set; }
        public int SpellcasterDPS2H { get; set; }
        public int RangedDPS { get; set; }
        public int WandDPS { get; set; }
        public int SpellPower { get; set; }
        public int PrimaryBudget { get; set; }
        public int TertiaryBudget { get; set; }
        public int ClothCloakArmor { get; set; }
        public int ClothChestArmor { get; set; }
        public int LeatherChestArmor { get; set; }
        public int MailChestArmor { get; set; }
        public int PlateChestArmor { get; set; }
    }

    [DBTable(Expansion.WotLK)]
    public class ScreenEffect
    {
        [DBKey]
        public int Id { get; set; }
        public string Name { get; set; }
        public int Effect { get; set; }
        [DBField(ArraySize: 4)]
        public int[] Param { get; set; }
        public int LightParamsID { get; set; }
        public int SoundAmbienceID { get; set; }
        public int ZoneMusicID { get; set; }
    }

    [DBTable(Expansion.WotLK)]
    public class ServerMessages
    {
        [DBKey]
        public int ID { get; set; }
        public LocalizedString Text_lang { get; set; }
    }

    [DBTable(Expansion.WotLK)]
    public class SheatheSoundLookups
    {
        [DBKey]
        public int ID { get; set; }
        public int ItemClass { get; set; }
        public int ItemSubclass { get; set; }
        public int ItemEnvTypes { get; set; }
        public int IsShield { get; set; }
        public int SheathSoundID { get; set; }
        public int UnsheathSoundID { get; set; }
    }

    [DBTable(Expansion.WotLK)]
    public class SkillCostsData
    {
        [DBKey]
        public int ID { get; set; }
        public int SkillCostsID { get; set; }
        [DBField(ArraySize: 3)]
        public int[] Cost { get; set; }
    }

    [DBTable(Expansion.WotLK)]
    public class SkillLine
    {
        [DBKey]
        public int ID { get; set; }
        public int CategoryID { get; set; }
        public int SkillCostsID { get; set; }
        public LocalizedString DisplayName_lang { get; set; }
        public LocalizedString Description_lang { get; set; }
        public int SpellIconID { get; set; }
        public LocalizedString AlternateVerb_lang { get; set; }
        public int CanLink { get; set; }
    }

    [DBTable(Expansion.WotLK)]
    public class SkillLineAbility
    {
        [DBKey]
        public int ID { get; set; }
        public int SkillLine { get; set; }
        public int Spell { get; set; }
        public int RaceMask { get; set; }
        public int ClassMask { get; set; }
        public int MinSkillLineRank { get; set; }
        public int SupercededBySpell { get; set; }
        public int AcquireMethod { get; set; }
        public int TrivialSkillLineRankHigh { get; set; }
        public int TrivialSkillLineRankLow { get; set; }
        [DBField(ArraySize: 2)]
        public int[] CharacterPoints { get; set; }
        public int TradeSkillCategoryID { get; set; }
    }

    [DBTable(Expansion.WotLK)]
    public class SkillLineCategory
    {
        [DBKey]
        public int ID { get; set; }
        public LocalizedString Name_lang { get; set; }
        public int SortIndex { get; set; }
    }

    [DBTable(Expansion.WotLK)]
    public class SkillRaceClassInfo
    {
        [DBKey]
        public int ID { get; set; }
        public int SkillID { get; set; }
        public int RaceMask { get; set; }
        public int ClassMask { get; set; }
        public int Flags { get; set; }
        public int MinLevel { get; set; }
        public int SkillTierID { get; set; }
        public int SkillCostIndex { get; set; }
    }

    [DBTable(Expansion.WotLK)]
    public class SkillTiers
    {
        [DBKey]
        public int ID { get; set; }
        [DBField(ArraySize: 16)]
        public int[] Cost { get; set; }
        [DBField(ArraySize: 16)]
        public int[] Value { get; set; }
    }

    [DBTable(Expansion.WotLK)]
    public class SoundAmbience
    {
        [DBKey]
        public int ID { get; set; }
        [DBField(ArraySize: 2)]
        public int[] AmbienceID { get; set; }
    }

    [DBTable(Expansion.WotLK)]
    public class SoundEmitters
    {
        [DBKey]
        public int ID { get; set; }
        public float PositionX { get; set; }
        public float PositionY { get; set; }
        public float PositionZ { get; set; }
        public float DirectionX { get; set; }
        public float DirectionY { get; set; }
        public float DirectionZ { get; set; }
        public int SoundEntriesID { get; set; }
        public int MapID { get; set; }
        public string Name { get; set; }
    }

    [DBTable(Expansion.WotLK)]
    public class SoundEntries
    {
        [DBKey]
        public int ID { get; set; }
        public int SoundType { get; set; }
        public string Name { get; set; }
        [DBField(ArraySize: 10)]
        public string[] File { get; set; }
        [DBField(ArraySize: 10)]
        public int[] Freq { get; set; }
        public string DirectoryBase { get; set; }
        public float Volumefloat { get; set; }
        public int Flags { get; set; }
        public float MinDistance { get; set; }
        public float DistanceCutoff { get; set; }
        public int EAXDef { get; set; }
        public int SoundEntriesAdvancedID { get; set; }
    }

    [DBTable(Expansion.WotLK)]
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
        public string Name { get; set; }
    }

    [DBTable(Expansion.WotLK)]
    public class SoundFilter
    {
        [DBKey]
        public int ID { get; set; }
        public string Name { get; set; }
    }

    [DBTable(Expansion.WotLK)]
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

    [DBTable(Expansion.WotLK)]
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

    [DBTable(Expansion.WotLK)]
    public class SoundSamplePreferences
    {
        [DBKey]
        public int ID { get; set; }
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
        public int Field12 { get; set; }
        public int Field13 { get; set; }
        public float Field14 { get; set; }
        public int Field15 { get; set; }
        public float Field16 { get; set; }
        public int Field17 { get; set; }
    }

    [DBTable(Expansion.WotLK)]
    public class SoundWaterType
    {
        [DBKey]
        public int ID { get; set; }
        public int LiquidTypeID { get; set; }
        public int FluidSpeed { get; set; }
        public int SoundID { get; set; }
    }

    [DBTable(Expansion.WotLK)]
    public class SpamMessages
    {
        [DBKey]
        public int ID { get; set; }
        public string Text { get; set; }
    }

    [DBTable(Expansion.WotLK)]
    public class Spell
    {
        [DBKey]
        public uint ID { get; set; }
        public uint Category { get; set; }
        public uint DispelType { get; set; }
        public uint Mechanic { get; set; }
        public uint Attributes { get; set; }
        public uint AttributesEx { get; set; }
        public uint AttributesExB { get; set; }
        public uint AttributesExC { get; set; }
        public uint AttributesExD { get; set; }
        public uint AttributesExE { get; set; }
        public uint AttributesExF { get; set; }
        public uint AttributesExG { get; set; }
        public ulong ShapeshiftMask { get; set; }
        public ulong ShapeshiftExclude { get; set; }
        public uint Targets { get; set; }
        public uint TargetCreatureType { get; set; }
        public uint RequiresSpellFocus { get; set; }
        public uint FacingCasterFlags { get; set; }
        public uint CasterAuraState { get; set; }
        public uint TargetAuraState { get; set; }
        public uint ExcludeCasterAuraState { get; set; }
        public uint ExcludeTargetAuraState { get; set; }
        public uint CasterAuraSpell { get; set; }
        public uint TargetAuraSpell { get; set; }
        public uint ExcludeCasterAuraSpell { get; set; }
        public uint ExcludeTargetAuraSpell { get; set; }
        public uint CastingTimeIndex { get; set; }
        public uint RecoveryTime { get; set; }
        public uint CategoryRecoveryTime { get; set; }
        public uint InterruptFlags { get; set; }
        public uint AuraInterruptFlags { get; set; }
        public uint ChannelInterruptFlags { get; set; }
        public uint ProcTypeMask { get; set; }
        public uint ProcChance { get; set; }
        public uint ProcCharges { get; set; }
        public uint MaxLevel { get; set; }
        public uint BaseLevel { get; set; }
        public uint SpellLevel { get; set; }
        public uint DurationIndex { get; set; }
        public int PowerType { get; set; }
        public uint ManaCost { get; set; }
        public uint ManaCostPerLevel { get; set; }
        public uint ManaPerSecond { get; set; }
        public uint ManaPerSecondPerLevel { get; set; }
        public uint RangeIndex { get; set; }
        public float Speed { get; set; }
        public uint ModalNextSpell { get; set; }
        public uint CumulativeAura { get; set; }
        public uint Totem_1 { get; set; }
        public uint Totem_2 { get; set; }
        public int Reagent_1 { get; set; }
        public int Reagent_2 { get; set; }
        public int Reagent_3 { get; set; }
        public int Reagent_4 { get; set; }
        public int Reagent_5 { get; set; }
        public int Reagent_6 { get; set; }
        public int Reagent_7 { get; set; }
        public int Reagent_8 { get; set; }
        public int ReagentCount_1 { get; set; }
        public int ReagentCount_2 { get; set; }
        public int ReagentCount_3 { get; set; }
        public int ReagentCount_4 { get; set; }
        public int ReagentCount_5 { get; set; }
        public int ReagentCount_6 { get; set; }
        public int ReagentCount_7 { get; set; }
        public int ReagentCount_8 { get; set; }
        public int EquippedItemClass { get; set; }
        public int EquippedItemSubclass { get; set; }
        public int EquippedItemInvTypes { get; set; }
        public uint Effect_1 { get; set; }
        public uint Effect_2 { get; set; }
        public uint Effect_3 { get; set; }
        public int EffectDieSides_1 { get; set; }
        public int EffectDieSides_2 { get; set; }
        public int EffectDieSides_3 { get; set; }
        public float EffectRealPointsPerLevel_1 { get; set; }
        public float EffectRealPointsPerLevel_2 { get; set; }
        public float EffectRealPointsPerLevel_3 { get; set; }
        public int EffectBasePoints_1 { get; set; }
        public int EffectBasePoints_2 { get; set; }
        public int EffectBasePoints_3 { get; set; }
        public uint EffectMechanic_1 { get; set; }
        public uint EffectMechanic_2 { get; set; }
        public uint EffectMechanic_3 { get; set; }
        public uint ImplicitTargetA_1 { get; set; }
        public uint ImplicitTargetA_2 { get; set; }
        public uint ImplicitTargetA_3 { get; set; }
        public uint ImplicitTargetB_1 { get; set; }
        public uint ImplicitTargetB_2 { get; set; }
        public uint ImplicitTargetB_3 { get; set; }
        public uint EffectRadiusIndex_1 { get; set; }
        public uint EffectRadiusIndex_2 { get; set; }
        public uint EffectRadiusIndex_3 { get; set; }
        public uint EffectAura_1 { get; set; }
        public uint EffectAura_2 { get; set; }
        public uint EffectAura_3 { get; set; }
        public uint EffectAuraPeriod_1 { get; set; }
        public uint EffectAuraPeriod_2 { get; set; }
        public uint EffectAuraPeriod_3 { get; set; }
        public float EffectAmplitude_1 { get; set; }
        public float EffectAmplitude_2 { get; set; }
        public float EffectAmplitude_3 { get; set; }
        public uint EffectChainTargets_1 { get; set; }
        public uint EffectChainTargets_2 { get; set; }
        public uint EffectChainTargets_3 { get; set; }
        public uint EffectItemType_1 { get; set; }
        public uint EffectItemType_2 { get; set; }
        public uint EffectItemType_3 { get; set; }
        public int EffectMiscValue_1 { get; set; }
        public int EffectMiscValue_2 { get; set; }
        public int EffectMiscValue_3 { get; set; }
        public int EffectMiscValueB_1 { get; set; }
        public int EffectMiscValueB_2 { get; set; }
        public int EffectMiscValueB_3 { get; set; }
        public uint EffectTriggerSpell_1 { get; set; }
        public uint EffectTriggerSpell_2 { get; set; }
        public uint EffectTriggerSpell_3 { get; set; }
        public float EffectPointsPerCombo_1 { get; set; }
        public float EffectPointsPerCombo_2 { get; set; }
        public float EffectPointsPerCombo_3 { get; set; }
        public uint EffectSpellClassMaskA_1 { get; set; }
        public uint EffectSpellClassMaskA_2 { get; set; }
        public uint EffectSpellClassMaskA_3 { get; set; }
        public uint EffectSpellClassMaskB_1 { get; set; }
        public uint EffectSpellClassMaskB_2 { get; set; }
        public uint EffectSpellClassMaskB_3 { get; set; }
        public uint EffectSpellClassMaskC_1 { get; set; }
        public uint EffectSpellClassMaskC_2 { get; set; }
        public uint EffectSpellClassMaskC_3 { get; set; }
        public uint SpellVisualID_1 { get; set; }
        public uint SpellVisualID_2 { get; set; }
        public uint SpellIconID { get; set; }
        public uint ActiveIconID { get; set; }
        public uint SpellPriority { get; set; }
        public string Name_lang_1 { get; set; }
        public string Name_lang_2 { get; set; }
        public string Name_lang_3 { get; set; }
        public string Name_lang_4 { get; set; }
        public string Name_lang_5 { get; set; }
        public string Name_lang_6 { get; set; }
        public string Name_lang_7 { get; set; }
        public string Name_lang_8 { get; set; }
        public string Name_lang_9 { get; set; }
        public string Name_lang_10 { get; set; }
        public string Name_lang_11 { get; set; }
        public string Name_lang_12 { get; set; }
        public string Name_lang_13 { get; set; }
        public string Name_lang_14 { get; set; }
        public string Name_lang_15 { get; set; }
        public string Name_lang_16 { get; set; }
        public uint Name_flag { get; set; }
        public string NameSubtext_lang_1 { get; set; }
        public string NameSubtext_lang_2 { get; set; }
        public string NameSubtext_lang_3 { get; set; }
        public string NameSubtext_lang_4 { get; set; }
        public string NameSubtext_lang_5 { get; set; }
        public string NameSubtext_lang_6 { get; set; }
        public string NameSubtext_lang_7 { get; set; }
        public string NameSubtext_lang_8 { get; set; }
        public string NameSubtext_lang_9 { get; set; }
        public string NameSubtext_lang_10 { get; set; }
        public string NameSubtext_lang_11 { get; set; }
        public string NameSubtext_lang_12 { get; set; }
        public string NameSubtext_lang_13 { get; set; }
        public string NameSubtext_lang_14 { get; set; }
        public string NameSubtext_lang_15 { get; set; }
        public string NameSubtext_lang_16 { get; set; }
        public uint NameSubtext_flag { get; set; }
        public string Description_lang_1 { get; set; }
        public string Description_lang_2 { get; set; }
        public string Description_lang_3 { get; set; }
        public string Description_lang_4 { get; set; }
        public string Description_lang_5 { get; set; }
        public string Description_lang_6 { get; set; }
        public string Description_lang_7 { get; set; }
        public string Description_lang_8 { get; set; }
        public string Description_lang_9 { get; set; }
        public string Description_lang_10 { get; set; }
        public string Description_lang_11 { get; set; }
        public string Description_lang_12 { get; set; }
        public string Description_lang_13 { get; set; }
        public string Description_lang_14 { get; set; }
        public string Description_lang_15 { get; set; }
        public string Description_lang_16 { get; set; }
        public uint Description_flag { get; set; }
        public string AuraDescription_lang_1 { get; set; }
        public string AuraDescription_lang_2 { get; set; }
        public string AuraDescription_lang_3 { get; set; }
        public string AuraDescription_lang_4 { get; set; }
        public string AuraDescription_lang_5 { get; set; }
        public string AuraDescription_lang_6 { get; set; }
        public string AuraDescription_lang_7 { get; set; }
        public string AuraDescription_lang_8 { get; set; }
        public string AuraDescription_lang_9 { get; set; }
        public string AuraDescription_lang_10 { get; set; }
        public string AuraDescription_lang_11 { get; set; }
        public string AuraDescription_lang_12 { get; set; }
        public string AuraDescription_lang_13 { get; set; }
        public string AuraDescription_lang_14 { get; set; }
        public string AuraDescription_lang_15 { get; set; }
        public string AuraDescription_lang_16 { get; set; }
        public uint AuraDescription_flag { get; set; }
        public uint ManaCostPct { get; set; }
        public uint StartRecoveryCategory { get; set; }
        public uint StartRecoveryTime { get; set; }
        public uint MaxTargetLevel { get; set; }
        public uint SpellClassSet { get; set; }
        public uint SpellClassMask_1 { get; set; }
        public uint SpellClassMask_2 { get; set; }
        public uint SpellClassMask_3 { get; set; }
        public uint MaxTargets { get; set; }
        public uint DefenseType { get; set; }
        public uint PreventionType { get; set; }
        public uint StanceBarOrder { get; set; }
        public float EffectChainAmplitude_1 { get; set; }
        public float EffectChainAmplitude_2 { get; set; }
        public float EffectChainAmplitude_3 { get; set; }
        public uint MinFactionID { get; set; }
        public uint MinReputation { get; set; }
        public uint RequiredAuraVision { get; set; }
        public uint RequiredTotemCategoryID_1 { get; set; }
        public uint RequiredTotemCategoryID_2 { get; set; }
        public int RequiredAreasID { get; set; }
        public uint SchoolMask { get; set; }
        public uint RuneCostID { get; set; }
        public uint SpellMissileID { get; set; }
        public int PowerDisplayID { get; set; }
        public float Unk1_1 { get; set; }
        public float Unk1_2 { get; set; }
        public float Unk1_3 { get; set; }
        public uint SpellDescriptionVariableID { get; set; }
        public uint SpellDifficultyID { get; set; }
    }

    [DBTable(Expansion.WotLK)]
    public class SpellCastTimes
    {
        [DBKey]
        public int ID { get; set; }
        public int Base { get; set; }
        public int PerLevel { get; set; }
        public int Minimum { get; set; }
    }

    [DBTable(Expansion.WotLK)]
    public class SpellCategory
    {
        [DBKey]
        public int ID { get; set; }
        public int Flags { get; set; }
    }

    [DBTable(Expansion.WotLK)]
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
        public string Texture { get; set; }
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
        public string Combo { get; set; }
        public int RenderLayer { get; set; }
        public float TextureLength { get; set; }
        public float WavePhase { get; set; }
    }

    [DBTable(Expansion.WotLK)]
    public class SpellDescriptionVariables
    {
        [DBKey]
        public int ID { get; set; }
        public string Variables { get; set; }
    }

    [DBTable(Expansion.WotLK)]
    public class SpellDifficulty
    {
        [DBKey]
        public int ID { get; set; }
        [DBField(ArraySize: 4)]
        public int[] DifficultySpellID { get; set; }
    }

    [DBTable(Expansion.WotLK)]
    public class SpellDispelType
    {
        [DBKey]
        public int ID { get; set; }
        public LocalizedString Name_lang { get; set; }
        public int Mask { get; set; }
        public int ImmunityPossible { get; set; }
        public string InternalName { get; set; }
    }

    [DBTable(Expansion.WotLK)]
    public class SpellDuration
    {
        [DBKey]
        public int ID { get; set; }
        public int Duration { get; set; }
        public int DurationPerLevel { get; set; }
        public int MaxDuration { get; set; }
    }

    [DBTable(Expansion.WotLK)]
    public class SpellEffectCameraShakes
    {
        [DBKey]
        public int ID { get; set; }
        [DBField(ArraySize: 3)]
        public int[] CameraShake { get; set; }
    }

    [DBTable(Expansion.WotLK)]
    public class SpellFocusObject
    {
        [DBKey]
        public int ID { get; set; }
        public LocalizedString Name_lang { get; set; }
    }

    [DBTable(Expansion.WotLK)]
    public class SpellIcon
    {
        [DBKey]
        public int ID { get; set; }
        public string TextureFilename { get; set; }
    }

    [DBTable(Expansion.WotLK)]
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
        public int[] EffectPointsMax { get; set; }
        [DBField(ArraySize: 3)]
        public int[] EffectArg { get; set; }
        public LocalizedString Name_lang { get; set; }
        public int ItemVisual { get; set; }
        public int Flags { get; set; }
        public int Src_itemID { get; set; }
        public int Condition_id { get; set; }
        public int RequiredSkillID { get; set; }
        public int RequiredSkillRank { get; set; }
        public int MinLevel { get; set; }
    }

    [DBTable(Expansion.WotLK)]
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

    [DBTable(Expansion.WotLK)]
    public class SpellMechanic
    {
        [DBKey]
        public int ID { get; set; }
        public LocalizedString StateName_lang { get; set; }
    }

    [DBTable(Expansion.WotLK)]
    public class SpellMissile
    {
        [DBKey]
        public int ID { get; set; }
        public int Flags { get; set; }
        public float DefaultPitchMin { get; set; }
        public float DefaultPitchMax { get; set; }
        public float DefaultSpeedMin { get; set; }
        public float DefaultSpeedMax { get; set; }
        public float RandomizeFacingMin { get; set; }
        public float RandomizeFacingMax { get; set; }
        public float RandomizePitchMin { get; set; }
        public float RandomizePitchMax { get; set; }
        public float RandomizeSpeedMin { get; set; }
        public float RandomizeSpeedMax { get; set; }
        public float Gravity { get; set; }
        public float MaxDuration { get; set; }
        public float CollisionRadius { get; set; }
    }

    [DBTable(Expansion.WotLK)]
    public class SpellMissileMotion
    {
        [DBKey]
        public int ID { get; set; }
        public string Name { get; set; }
        public string ScriptBody { get; set; }
        public int Flags { get; set; }
        public int MissileCount { get; set; }
    }

    [DBTable(Expansion.WotLK)]
    public class SpellRadius
    {
        [DBKey]
        public int ID { get; set; }
        public float Radius { get; set; }
        public float RadiusPerLevel { get; set; }
        public float RadiusMax { get; set; }
    }

    [DBTable(Expansion.WotLK)]
    public class SpellRange
    {
        [DBKey]
        public int ID { get; set; }
        [DBField(ArraySize: 2)]
        public float[] RangeMin { get; set; }
        [DBField(ArraySize: 2)]
        public float[] RangeMax { get; set; }
        public int Flags { get; set; }
        public LocalizedString DisplayName_lang { get; set; }
        public LocalizedString DisplayNameShort_lang { get; set; }
    }

    [DBTable(Expansion.WotLK)]
    public class SpellRuneCost
    {
        [DBKey]
        public int ID { get; set; }
        public int Blood { get; set; }
        public int Unholy { get; set; }
        public int Frost { get; set; }
        public int RunicPower { get; set; }
    }

    [DBTable(Expansion.WotLK)]
    public class SpellScaling
    {
        [DBKey]
        public int ID { get; set; }
        public int CastTimeMin { get; set; }
        public int CastTimeMax { get; set; }
        public int CastTimeMaxLevel { get; set; }
        public int Class { get; set; }
        [DBField(ArraySize: 3)]
        public float[] Coefficient { get; set; }
        [DBField(ArraySize: 3)]
        public float[] Variance { get; set; }
        [DBField(ArraySize: 3)]
        public float[] ComboPointsCoefficient { get; set; }
    }

    [DBTable(Expansion.WotLK)]
    public class SpellShapeshiftForm
    {
        [DBKey]
        public int ID { get; set; }
        public int BonusActionBar { get; set; }
        public LocalizedString Name_lang { get; set; }
        public int Flags { get; set; }
        public int CreatureType { get; set; }
        public int AttackIconID { get; set; }
        public int CombatRoundTime { get; set; }
        [DBField(ArraySize: 4)]
        public int[] CreatureDisplayID { get; set; }
        [DBField(ArraySize: 8)]
        public int[] PresetSpellID { get; set; }
    }

    [DBTable(Expansion.WotLK)]
    public class SpellVisual
    {
        [DBKey]
        public int ID { get; set; }
        public int PrecastKit { get; set; }
        public int CastKit { get; set; }
        public int ImpactKit { get; set; }
        public int StateKit { get; set; }
        public int StateDoneKit { get; set; }
        public int ChannelKit { get; set; }
        public int HasMissile { get; set; }
        public int MissileModel { get; set; }
        public int MissilePathType { get; set; }
        public int MissileDestinationAttachment { get; set; }
        public int MissileSound { get; set; }
        public int AnimEventSoundID { get; set; }
        public int Flags { get; set; }
        public int CasterImpactKit { get; set; }
        public int TargetImpactKit { get; set; }
        public int MissileAttachment { get; set; }
        public int MissileFollowGroundHeight { get; set; }
        public int MissileFollowGroundDropSpeed { get; set; }
        public int MissileFollowGroundApproach { get; set; }
        public int MissileFollowGroundFlags { get; set; }
        public int MissileMotion { get; set; }
        public int MissileTargetingKit { get; set; }
        public int InstantAreaKit { get; set; }
        public int ImpactAreaKit { get; set; }
        public int PersistentAreaKit { get; set; }
        public float MissileCastOffsetX { get; set; }
        public float MissileCastOffsetY { get; set; }
        public float MissileCastOffsetZ { get; set; }
        public float MissileImpactOffsetX { get; set; }
        public float MissileImpactOffsetY { get; set; }
        public float MissileImpactOffsetZ { get; set; }
    }

    [DBTable(Expansion.WotLK)]
    public class SpellVisualEffectName
    {
        [DBKey]
        public int ID { get; set; }
        public string Name { get; set; }
        public string FileName { get; set; }
        public float AreaEffectSize { get; set; }
        public float Scale { get; set; }
        public float MinAllowedScale { get; set; }
        public float MaxAllowedScale { get; set; }
    }

    [DBTable(Expansion.WotLK)]
    public class SpellVisualKit
    {
        [DBKey]
        public int ID { get; set; }
        public int StartAnimID { get; set; }
        public int AnimID { get; set; }
        public int AnimKitID { get; set; }
        public int HeadEffect { get; set; }
        public int ChestEffect { get; set; }
        public int BaseEffect { get; set; }
        public int LeftHandEffect { get; set; }
        public int RightHandEffect { get; set; }
        public int BreathEffect { get; set; }
        public int LeftWeaponEffect { get; set; }
        public int RightWeaponEffect { get; set; }
        [DBField(ArraySize: 3)]
        public int[] SpecialEffect { get; set; }
        public int WorldEffect { get; set; }
        public int SoundID { get; set; }
        public int ShakeID { get; set; }
        [DBField(ArraySize: 4)]
        public int[] CharProc { get; set; }
        [DBField(ArraySize: 4)]
        public float[] CharParamZero { get; set; }
        [DBField(ArraySize: 4)]
        public float[] CharParamOne { get; set; }
        [DBField(ArraySize: 4)]
        public float[] CharParamTwo { get; set; }
        [DBField(ArraySize: 4)]
        public float[] CharParamThree { get; set; }
    }

    [DBTable(Expansion.WotLK)]
    public class SpellVisualKitAreaModel
    {
        [DBKey]
        public int ID { get; set; }
        public string Name { get; set; }
        public int EnumID { get; set; }
    }

    [DBTable(Expansion.WotLK)]
    public class SpellVisualKitModelAttach
    {
        [DBKey]
        public int ID { get; set; }
        public int ParentSpellVisualKitID { get; set; }
        public int SpellVisualEffectNameID { get; set; }
        public int AttachmentID { get; set; }
        public float OffsetX { get; set; }
        public float OffsetY { get; set; }
        public float OffsetZ { get; set; }
        public float Yaw { get; set; }
        public float Pitch { get; set; }
        public float Roll { get; set; }
    }

    [DBTable(Expansion.WotLK)]
    public class SpellVisualPrecastTransitions
    {
        [DBKey]
        public int ID { get; set; }
        public string LoadAnimation { get; set; }
        public string HoldAnimation { get; set; }
    }

    [DBTable(Expansion.WotLK)]
    public class StableSlotPrices
    {
        [DBKey]
        public int ID { get; set; }
        public int Cost { get; set; }
    }

    [DBTable(Expansion.WotLK)]
    public class Startup_strings
    {
        [DBKey]
        public int ID { get; set; }
        public string Name { get; set; }
        public LocalizedString Message_lang { get; set; }
    }

    [DBTable(Expansion.WotLK)]
    public class Stationery
    {
        [DBKey]
        public int ID { get; set; }
        public int ItemID { get; set; }
        public string Texture { get; set; }
        public int Flags { get; set; }
    }

    [DBTable(Expansion.WotLK)]
    public class StringLookups
    {
        [DBKey]
        public int ID { get; set; }
        public string String { get; set; }
    }

    [DBTable(Expansion.WotLK)]
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

    [DBTable(Expansion.WotLK)]
    public class Talent
    {
        [DBKey]
        public int ID { get; set; }
        public int TabID { get; set; }
        public int TierID { get; set; }
        public int ColumnIndex { get; set; }
        [DBField(ArraySize: 9)]
        public int[] SpellRank { get; set; }
        [DBField(ArraySize: 3)]
        public int[] PrereqTalent { get; set; }
        [DBField(ArraySize: 3)]
        public int[] PrereqRank { get; set; }
        public int Flags { get; set; }
        public int RequiredSpellID { get; set; }
        [DBField(ArraySize: 2)]
        public int[] CategoryMask { get; set; }
    }

    [DBTable(Expansion.WotLK)]
    public class TalentTab
    {
        [DBKey]
        public int ID { get; set; }
        public LocalizedString Name_lang { get; set; }
        public int SpellIconID { get; set; }
        public int RaceMask { get; set; }
        public int ClassMask { get; set; }
        public int PetTalentMask { get; set; }
        public int OrderIndex { get; set; }
        public string BackgroundFile { get; set; }
    }

    [DBTable(Expansion.WotLK)]
    public class TaxiNodes
    {
        [DBKey]
        public int ID { get; set; }
        public int ContinentID { get; set; }
        public float X { get; set; }
        public float Y { get; set; }
        public float Z { get; set; }
        public LocalizedString Name_lang { get; set; }
        [DBField(ArraySize: 2)]
        public int[] MountCreatureID { get; set; }
    }

    [DBTable(Expansion.WotLK)]
    public class TaxiPath
    {
        [DBKey]
        public int ID { get; set; }
        public int FromTaxiNode { get; set; }
        public int ToTaxiNode { get; set; }
        public int Cost { get; set; }
    }

    [DBTable(Expansion.WotLK)]
    public class TaxiPathNode
    {
        [DBKey]
        public int ID { get; set; }
        public int PathID { get; set; }
        public int NodeIndex { get; set; }
        public int ContinentID { get; set; }
        public float LocX { get; set; }
        public float LocY { get; set; }
        public float LocZ { get; set; }
        public int Flags { get; set; }
        public int Delay { get; set; }
        public int ArrivalEventID { get; set; }
        public int DepartureEventID { get; set; }
    }

    [DBTable(Expansion.WotLK)]
    public class TeamContributionPoints
    {
        [DBKey]
        public int ID { get; set; }
        public float Data { get; set; }
    }

    [DBTable(Expansion.WotLK)]
    public class Terraintype
    {
        [DBKey(AutoGenerated: true)]
        public int GeneratedID { get; set; }
        public int TerrainID { get; set; }
        public string TerrainDesc { get; set; }
        public int FootstepSprayRun { get; set; }
        public int FootstepSprayWalk { get; set; }
        public int SoundID { get; set; }
        public int Flags { get; set; }
    }

    [DBTable(Expansion.WotLK)]
    public class TerraintypeSounds
    {
        [DBKey]
        public int ID { get; set; }
    }

    [DBTable(Expansion.WotLK)]
    public class TotemCategory
    {
        [DBKey]
        public int ID { get; set; }
        public LocalizedString Name_lang { get; set; }
        public int TotemCategoryType { get; set; }
        public int TotemCategoryMask { get; set; }
    }

    [DBTable(Expansion.WotLK)]
    public class TransportAnimation
    {
        [DBKey]
        public int ID { get; set; }
        public int TransportID { get; set; }
        public int TimeIndex { get; set; }
        public float PosX { get; set; }
        public float PosY { get; set; }
        public float PosZ { get; set; }
        public int SequenceID { get; set; }
    }

    [DBTable(Expansion.WotLK)]
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

    [DBTable(Expansion.WotLK)]
    public class TransportRotation
    {
        [DBKey]
        public int ID { get; set; }
        public int GameObjectsID { get; set; }
        public int TimeIndex { get; set; }
        public float RotX { get; set; }
        public float RotY { get; set; }
        public float RotZ { get; set; }
        public float RotW { get; set; }
    }

    [DBTable(Expansion.WotLK)]
    public class UISoundLookups
    {
        [DBKey]
        public int ID { get; set; }
        public int SoundID { get; set; }
        public string Name { get; set; }
    }

    [DBTable(Expansion.WotLK)]
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

    [DBTable(Expansion.WotLK)]
    public class UnitBloodLevels
    {
        [DBKey]
        public int ID { get; set; }
        [DBField(ArraySize: 3)]
        public int[] Violencelevel { get; set; }
    }

    [DBTable(Expansion.WotLK)]
    public class Vehicle
    {
        [DBKey]
        public int ID { get; set; }
        public int Flags { get; set; }
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

    [DBTable(Expansion.WotLK)]
    public class VehicleSeat
    {
        [DBKey]
        public int ID { get; set; }
        public int Flags { get; set; }
        public int AttachmentID { get; set; }
        public float AttachmentOffsetX { get; set; }
        public float AttachmentOffsetY { get; set; }
        public float AttachmentOffsetZ { get; set; }
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
        public int UiSkin { get; set; }
        public int FlagsB { get; set; }
        public float CameraEnteringDelay { get; set; }
        public float CameraEnteringDuration { get; set; }
        public float CameraExitingDelay { get; set; }
        public float CameraExitingDuration { get; set; }
        public float CameraOffsetX { get; set; }
        public float CameraOffsetY { get; set; }
        public float CameraOffsetZ { get; set; }
        public float CameraPosChaseRate { get; set; }
        public float CameraFacingChaseRate { get; set; }
        public float CameraEnteringZoom { get; set; }
        public float CameraSeatZoomMin { get; set; }
        public float CameraSeatZoomMax { get; set; }
    }

    [DBTable(Expansion.WotLK)]
    public class VehicleUIIndicator
    {
        [DBKey]
        public int ID { get; set; }
        public string BackgroundTexture { get; set; }
    }

    [DBTable(Expansion.WotLK)]
    public class VehicleUIIndSeat
    {
        [DBKey]
        public int ID { get; set; }
        public int VehicleUIIndicatorID { get; set; }
        public int VirtualSeatIndex { get; set; }
        public float XPos { get; set; }
        public float YPos { get; set; }
    }

    [DBTable(Expansion.WotLK)]
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

    [DBTable(Expansion.WotLK)]
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

    [DBTable(Expansion.WotLK)]
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

    [DBTable(Expansion.WotLK)]
    public class WeaponSwingSounds2
    {
        [DBKey]
        public int ID { get; set; }
        public int SwingType { get; set; }
        public int Crit { get; set; }
        public int SoundID { get; set; }
    }

    [DBTable(Expansion.WotLK)]
    public class Weather
    {
        [DBKey]
        public int ID { get; set; }
        public int AmbienceID { get; set; }
        public int EffectType { get; set; }
        public float TransitionSkyBox { get; set; }
        [DBField(ArraySize: 3)]
        public float[] EffectColor { get; set; }
        public string EffectTexture { get; set; }
    }

    [DBTable(Expansion.WotLK)]
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
        public LocalizedString AreaName_lang { get; set; }
    }

    [DBTable(Expansion.WotLK)]
    public class WorldChunkSounds
    {
        [DBKey(AutoGenerated: true)]
        public int GeneratedID { get; set; }
        public int WorldMapContinentID { get; set; }
        public int ChunkX { get; set; }
        public int ChunkY { get; set; }
        public int SubchunkX { get; set; }
        public int SubchunkY { get; set; }
        public int ZoneintroMusicID { get; set; }
        public int ZoneMusicID { get; set; }
        public int SoundAmbienceID { get; set; }
        public int SoundProviderPreferencesID { get; set; }
    }

    [DBTable(Expansion.WotLK)]
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
    }

    [DBTable(Expansion.WotLK)]
    public class WorldMapContinent
    {
        [DBKey]
        public int ID { get; set; }
        public int MapID { get; set; }
        public int LeftBoundary { get; set; }
        public int RightBoundary { get; set; }
        public int TopBoundary { get; set; }
        public int BottomBoundary { get; set; }
        public float ContinentOffsetX { get; set; }
        public float ContinentOffsetY { get; set; }
        public float Scale { get; set; }
        public float TaxiMinX { get; set; }
        public float TaxiMinY { get; set; }
        public float TaxiMaxX { get; set; }
        public float TaxiMaxY { get; set; }
        public int WorldMapID { get; set; }
    }

    [DBTable(Expansion.WotLK)]
    public class WorldMapOverlay
    {
        [DBKey]
        public int ID { get; set; }
        public int MapAreaID { get; set; }
        [DBField(ArraySize: 4)]
        public int[] AreaID { get; set; }
        public int MapPointX { get; set; }
        public int MapPointY { get; set; }
        public string TextureName { get; set; }
        public int TextureWidth { get; set; }
        public int TextureHeight { get; set; }
        public int OffsetX { get; set; }
        public int OffsetY { get; set; }
        public int HitRectTop { get; set; }
        public int HitRectLeft { get; set; }
        public int HitRectBottom { get; set; }
        public int HitRectRight { get; set; }
    }

    [DBTable(Expansion.WotLK)]
    public class WorldMapTransforms
    {
        [DBKey]
        public int ID { get; set; }
        public int MapID { get; set; }
        public float RegionMinX { get; set; }
        public float RegionMinY { get; set; }
        public float RegionMaxX { get; set; }
        public float RegionMaxY { get; set; }
        public int NewMapID { get; set; }
        public float RegionOffsetX { get; set; }
        public float RegionOffsetY { get; set; }
        public int NewDungeonMapID { get; set; }
    }

    [DBTable(Expansion.WotLK)]
    public class WorldSafelocs
    {
        [DBKey]
        public int ID { get; set; }
        public int Continent { get; set; }
        public float LocX { get; set; }
        public float LocY { get; set; }
        public float LocZ { get; set; }
        public LocalizedString AreaName_lang { get; set; }
    }

    [DBTable(Expansion.WotLK)]
    public class WorldStateUI
    {
        [DBKey]
        public int ID { get; set; }
        public int MapID { get; set; }
        public int AreaID { get; set; }
        public int PhaseShift { get; set; }
        public string Icon { get; set; }
        public LocalizedString String_lang { get; set; }
        public LocalizedString Tooltip_lang { get; set; }
        public int StateVariable { get; set; }
        public int Type { get; set; }
        public string DynamicIcon { get; set; }
        public LocalizedString DynamicTooltip_lang { get; set; }
        public string ExtendedUI { get; set; }
        [DBField(ArraySize: 3)]
        public int[] ExtendedUIStateVariable { get; set; }
    }

    [DBTable(Expansion.WotLK)]
    public class WorldStateZoneSounds
    {
        [DBKey(AutoGenerated: true)]
        public int GeneratedID { get; set; }
        public int WorldStateID { get; set; }
        public int WorldStateValue { get; set; }
        public int AreaID { get; set; }
        public int WMOAreaID { get; set; }
        public int ZoneintroMusicID { get; set; }
        public int ZoneMusicID { get; set; }
        public int SoundAmbienceID { get; set; }
        public int SoundProviderPreferencesID { get; set; }
    }

    [DBTable(Expansion.WotLK)]
    public class WowError_Strings
    {
        [DBKey]
        public int ID { get; set; }
        public string ErrorName { get; set; }
        public LocalizedString ErrorString { get; set; }
    }

    [DBTable(Expansion.WotLK)]
    public class ZoneintroMusicTable
    {
        [DBKey]
        public int ID { get; set; }
        public string Name { get; set; }
        public int SoundID { get; set; }
        public int Priority { get; set; }
        public int MinDelayMinutes { get; set; }
    }

    [DBTable(Expansion.WotLK)]
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
