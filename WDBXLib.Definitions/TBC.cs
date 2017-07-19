using System;
using WDBXLib.Attributes;
using WDBXLib.Helpers;
using static WDBXLib.Common.Constants;

namespace WDBXLib.Definitions.TBC
{

    [DBTable(Expansion.TBC)]
    public class AnimationData
    {
        [DBKey]
        public int ID { get; set; }
        public string Name { get; set; }
        public int WeaponFlags { get; set; }
        public int BodyFlags { get; set; }
        public int Flags { get; set; }
        public int Fallback { get; set; }
        public int BehaviourID { get; set; }
    }

    [DBTable(Expansion.TBC)]
    public class AreaPOI
    {
        [DBKey]
        public int ID { get; set; }
        public int Importance { get; set; }
        public int Icon { get; set; }
        public int FactionID { get; set; }
        public float X { get; set; }
        public float Y { get; set; }
        public float Z { get; set; }
        public int ContinentID { get; set; }
        public int Flags { get; set; }
        public int AreaID { get; set; }
        public LocalizedString Name { get; set; }
        public LocalizedString Description { get; set; }
        public int WorldStateID { get; set; }
    }

    [DBTable(Expansion.TBC)]
    public class AreaTable
    {
        [DBKey]
        public int ID { get; set; }
        public int ContinentID { get; set; }
        public int ParentAreaID { get; set; }
        public int AreaBit { get; set; }
        public int Flags { get; set; }
        public int SoundProviderPref { get; set; }
        public int SoundProviderPrefUnderWater { get; set; }
        public int AmbienceID { get; set; }
        public int ZoneMusic { get; set; }
        public int IntroSound { get; set; }
        public int ExplorationLevel { get; set; }
        public LocalizedString AreaName { get; set; }
        public int FactionGroupMask { get; set; }
        [DBField(ArraySize: 4)]
        public int[] LiquidTypeID { get; set; }
        public int MinElevation { get; set; }
        public float AmbientMultiplier { get; set; }
    }

    [DBTable(Expansion.TBC)]
    public class AreaTrigger
    {
        [DBKey]
        public int ID { get; set; }
        public int ContinentID { get; set; }
        public float X { get; set; }
        public float Y { get; set; }
        public float Z { get; set; }
        public float Radius { get; set; }
        public int BoxLength { get; set; }
        public int BoxWidth { get; set; }
        public int BoxHeight { get; set; }
        public int BoxYaw { get; set; }
    }

    [DBTable(Expansion.TBC)]
    public class AttackAnimKits
    {
        [DBKey]
        public int ID { get; set; }
        public int AnimationID { get; set; }
        public int AttackTypeID { get; set; }
        public int Flags { get; set; }
        public int Field5 { get; set; }
    }

    [DBTable(Expansion.TBC)]
    public class AttackAnimTypes
    {
        [DBKey]
        public int ID { get; set; }
        public string Name { get; set; }
    }

    [DBTable(Expansion.TBC)]
    public class AuctionHouse
    {
        [DBKey]
        public int ID { get; set; }
        public int FactionID { get; set; }
        public int DepositRate { get; set; }
        public int ConsignmentRate { get; set; }
        public LocalizedString Name { get; set; }
    }

    [DBTable(Expansion.TBC)]
    public class BankBagSlotPrices
    {
        [DBKey]
        public int ID { get; set; }
        public int Cost { get; set; }
    }

    [DBTable(Expansion.TBC)]
    public class BattlemasterList
    {
        [DBKey]
        public int ID { get; set; }
        [DBField(ArraySize: 8)]
        public int[] Instance { get; set; }
        public int Type { get; set; }
        public int MinLevel { get; set; }
        public int MaxLevel { get; set; }
        public int MaxPlayersPerTeam { get; set; }
        public int Bands { get; set; }
        public int JoinAsGroup { get; set; }
        public LocalizedString Name { get; set; }
        public int Unknown { get; set; }
    }

    [DBTable(Expansion.TBC)]
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

    [DBTable(Expansion.TBC)]
    public class Cfg_Categories
    {
        [DBKey]
        public int Tab { get; set; }
        public int LocaleMask { get; set; }
        public int CharsetMask { get; set; }
        public int Flags { get; set; }
        public LocalizedString Name { get; set; }
    }

    [DBTable(Expansion.TBC)]
    public class Cfg_Configs
    {
        [DBKey]
        public int ID { get; set; }
        public int RealmType { get; set; }
        public int PlayerKillingAllowed { get; set; }
        public int Roleplaying { get; set; }
    }

    [DBTable(Expansion.TBC)]
    public class CharacterFacialHairStyles
    {
        [DBKey(AutoGenerated: true)]
        public int GeneratedID { get; set; }
        [DBKey]
        public int RaceID { get; set; }
        public int GenderID { get; set; }
        public int VariationID { get; set; }
        [DBField(ArraySize: 6)]
        public int[] Geoset { get; set; }
    }

    [DBTable(Expansion.TBC)]
    public class CharBaseInfo
    {
        [DBKey(AutoGenerated: true)]
        public int GeneratedID { get; set; }
        public byte RaceID { get; set; }
        public byte ClassID { get; set; }
    }

    [DBTable(Expansion.TBC)]
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

    [DBTable(Expansion.TBC)]
    public class CharHairTextures
    {
        [DBKey]
        public int ID { get; set; }
        public int RaceID { get; set; }
        public int SexID { get; set; }
        public int Field4 { get; set; }
        public int Field5 { get; set; }
        public int Field6 { get; set; }
        public int Field7 { get; set; }
        public int Field8 { get; set; }
    }

    [DBTable(Expansion.TBC)]
    public class CharSections
    {
        [DBKey]
        public int ID { get; set; }
        public int RaceID { get; set; }
        public int SexID { get; set; }
        public int SectionType { get; set; }
        public int VariationIndex { get; set; }
        public int ColorIndex { get; set; }
        public string TextureName1 { get; set; }
        public string TextureName2 { get; set; }
        public string TextureName3 { get; set; }
        public int Flags { get; set; }
    }

    [DBTable(Expansion.TBC)]
    public class CharStartOutfit
    {
        [DBKey]
        public int ID { get; set; }
        public byte RaceID { get; set; }
        public byte ClassID { get; set; }
        public byte Gender { get; set; }
        public byte OutiftID { get; set; }
        [DBField(ArraySize: 12)]
        public int[] Items { get; set; }
        [DBField(ArraySize: 12)]
        public int[] DisplayInfo { get; set; }
        [DBField(ArraySize: 12)]
        public int[] InventoryType { get; set; }
    }

    [DBTable(Expansion.TBC)]
    public class CharTitles
    {
        [DBKey]
        public int ID { get; set; }
        public int ConditionID { get; set; }
        public LocalizedString TitleMale { get; set; }
        public LocalizedString TitleFemale { get; set; }
        public int TitleMaskID { get; set; }
    }

    [DBTable(Expansion.TBC)]
    public class CharVariations
    {
        [DBKey]
        public int RaceID { get; set; }
        public int SexID { get; set; }
        public int Unk1 { get; set; }
        public int Mask1 { get; set; }
        public int Mask2 { get; set; }
        public int Unk4 { get; set; }
    }

    [DBTable(Expansion.TBC)]
    public class ChatChannels
    {
        [DBKey]
        public int ID { get; set; }
        public int Flags { get; set; }
        public int FactionGroup { get; set; }
        public LocalizedString Name { get; set; }
        public LocalizedString Shortcut { get; set; }
    }

    [DBTable(Expansion.TBC)]
    public class ChatProfanity
    {
        [DBKey]
        public int ID { get; set; }
        public string Word { get; set; }
        public int LanguageID { get; set; }
    }

    [DBTable(Expansion.TBC)]
    public class ChrClasses
    {
        [DBKey]
        public int ID { get; set; }
        public int Flag { get; set; }
        public int PowerType { get; set; }
        public int PetNameToken { get; set; }
        public LocalizedString Name { get; set; }
        public LocalizedString NameFemale { get; set; }
        public LocalizedString NameMale { get; set; }
        public string FileName { get; set; }
        public int SpellClassSet { get; set; }
        public int Flags { get; set; }
    }

    [DBTable(WDBXLib.Common.Constants.Expansion.TBC)]
    public class ChrRaces
    {
        [DBKey]
        public int ID { get; set; }
        public int Flags { get; set; }
        public int FactionID { get; set; }
        public int ExplorationSoundID { get; set; }
        public int MaleDisplayID { get; set; }
        public int FemaleDisplayID { get; set; }
        public string ClientPrefix { get; set; }
        public float Speed { get; set; }
        public int BaseLanguage { get; set; }
        public int CreatureType { get; set; }
        public int ResSicknessSpellID { get; set; }
        public int SplashSoundID { get; set; }
        public string ClientFileString { get; set; }
        public int CinematicSequenceID { get; set; }
        public LocalizedString Name { get; set; }
        public LocalizedString NameFemale { get; set; }
        public LocalizedString NameMale { get; set; }
        public string FacialHairCustomization1 { get; set; }
        public string FacialHairCustomization2 { get; set; }
        public string HairCustomization { get; set; }
        public int Expansion { get; set; }
    }

    [DBTable(Expansion.TBC)]
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

    [DBTable(Expansion.TBC)]
    public class CinematicSequences
    {
        [DBKey]
        public int ID { get; set; }
        public int SoundID { get; set; }
        [DBField(ArraySize: 8)]
        public int[] Camera { get; set; }
    }

    [DBTable(Expansion.TBC)]
    public class CreatureDisplayInfo
    {
        [DBKey]
        public int ID { get; set; }
        public int ModelID { get; set; }
        public int SoundID { get; set; }
        public int ExtendedDisplayInfoID { get; set; }
        public float CreatureModelScale { get; set; }
        public int CreatureModelAlpha { get; set; }
        public string TextureVariation1 { get; set; }
        public string TextureVariation2 { get; set; }
        public string TextureVariation3 { get; set; }
        public string Protrait { get; set; }
        public int SizeClass { get; set; }
        public int BloodID { get; set; }
        public int NPCSoundID { get; set; }
        public int ParticleColorID { get; set; }
    }

    [DBTable(Expansion.TBC)]
    public class CreatureDisplayInfoExtra
    {
        [DBKey]
        public int ID { get; set; }
        public int DisplayRaceID { get; set; }
        public int CreatureTypeID { get; set; }
        public int DisplaySexID { get; set; }
        public int SkinID { get; set; }
        public int FaceID { get; set; }
        public int HairStyleID { get; set; }
        public int HairColorID { get; set; }
        public int FacialHairID { get; set; }
        [DBField(ArraySize: 10)]
        public int[] Equipment { get; set; }
        public int Flags { get; set; }
        public string BakeName { get; set; }
    }

    [DBTable(Expansion.TBC)]
    public class CreatureFamily
    {
        [DBKey]
        public int ID { get; set; }
        public float MinScale { get; set; }
        public int MinScaleLevel { get; set; }
        public float MaxScale { get; set; }
        public int MaxScaleLevel { get; set; }
        public int PetFoodMask { get; set; }
        public int PetTalentType { get; set; }
        public int CategoryEnumID { get; set; }
        public LocalizedString Name { get; set; }
        public string IconFile { get; set; }
    }

    [DBTable(Expansion.TBC)]
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
        public float GeoBoxMin_x { get; set; }
        public float GeoBoxMin_y { get; set; }
        public float GeoBoxMin_z { get; set; }
        public float GeoBoxMax_x { get; set; }
        public float GeoBoxMax_y { get; set; }
        public float GeoBoxMax_z { get; set; }
        public float WorldEffectScale { get; set; }
    }

    [DBTable(Expansion.TBC)]
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
        public int SoundFiget { get; set; }
        public int CustomAttack { get; set; }
        public int NPCSoundID { get; set; }
        public int LoopSoundID { get; set; }
        public int CreatureImpactType { get; set; }
        public int SoundJumpStartID { get; set; }
        public int SoundJumpEndID { get; set; }
        public int SoundPetAttackID { get; set; }
        public int SoundPetOrderID { get; set; }
        public int SoundPetDismissID { get; set; }
        public int FidgetDelaySecondsMin { get; set; }
        public int FidgetDelaySecondsMax { get; set; }
        public int BirthSoundID { get; set; }
        public int SpellCastDirectedSoundID { get; set; }
        public int SubmergeSoundID { get; set; }
        public int SubmergedSoundID { get; set; }
    }

    [DBTable(Expansion.TBC)]
    public class CreatureSpellData
    {
        [DBKey]
        public int ID { get; set; }
        [DBField(ArraySize: 4)]
        public int[] Spells { get; set; }
        [DBField(ArraySize: 4)]
        public int[] Availability { get; set; }
    }

    [DBTable(Expansion.TBC)]
    public class CreatureType
    {
        [DBKey]
        public int ID { get; set; }
        public LocalizedString Name { get; set; }
        public int Flags { get; set; }
    }

    [DBTable(Expansion.TBC)]
    public class DeathThudLookups
    {
        [DBKey]
        public int ID { get; set; }
        public int SizeClass { get; set; }
        public int TerrainTypeSoundID { get; set; }
        public int SoundEntryID { get; set; }
        public int SoundEntryIDWater { get; set; }
    }

    [DBTable(Expansion.TBC)]
    public class DeclinedWord
    {
        [DBKey]
        public int ID { get; set; }
        public string Word { get; set; }
    }

    [DBTable(Expansion.TBC)]
    public class DeclinedWordCases
    {
        [DBKey]
        public int ID { get; set; }
        public int DeclinedWordID { get; set; }
        public int CaseIndex { get; set; }
        public string DeclinedWord { get; set; }
    }

    [DBTable(Expansion.TBC)]
    public class DurabilityCosts
    {
        [DBKey]
        public int ID { get; set; }
        [DBField(ArraySize: 21)]
        public int[] WeaponSubClassCost { get; set; }
        [DBField(ArraySize: 8)]
        public int[] ArmorSubClassCost { get; set; }
    }

    [DBTable(Expansion.TBC)]
    public class DurabilityQuality
    {
        [DBKey]
        public int ID { get; set; }
        public float Data { get; set; }
    }

    [DBTable(Expansion.TBC)]
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

    [DBTable(Expansion.TBC)]
    public class EmotesText
    {
        [DBKey]
        public int ID { get; set; }
        public string Name { get; set; }
        public int EmoteID { get; set; }
        [DBField(ArraySize: 16)]
        public int[] EmoteText { get; set; }
    }

    [DBTable(Expansion.TBC)]
    public class EmotesTextData
    {
        [DBKey]
        public int ID { get; set; }
        public LocalizedString Text { get; set; }
    }

    [DBTable(Expansion.TBC)]
    public class EmotesTextSound
    {
        [DBKey]
        public int ID { get; set; }
        public int EmotesTextID { get; set; }
        public int RaceID { get; set; }
        public int SexID { get; set; }
        public int SoundID { get; set; }
    }

    [DBTable(Expansion.TBC)]
    public class EnvironmentalDamage
    {
        [DBKey]
        public int ID { get; set; }
        public int EnumID { get; set; }
        public int VisualkitID { get; set; }
    }

    [DBTable(Expansion.TBC)]
    public class Exhaustion
    {
        [DBKey]
        public int ID { get; set; }
        public int Xp { get; set; }
        public float Factor { get; set; }
        public float OutdoorHours { get; set; }
        public float InnHours { get; set; }
        public LocalizedString Name { get; set; }
        public int Threshold { get; set; }
    }

    [DBTable(Expansion.TBC)]
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
        public int[] ReputtationFlags { get; set; }
        public int ParentFactionID { get; set; }
        public LocalizedString Name { get; set; }
        public LocalizedString Description { get; set; }
    }

    [DBTable(Expansion.TBC)]
    public class FactionGroup
    {
        [DBKey]
        public int ID { get; set; }
        public int MaskID { get; set; }
        public string InternalName { get; set; }
        public LocalizedString Name { get; set; }
    }

    [DBTable(Expansion.TBC)]
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

    [DBTable(Expansion.TBC)]
    public class FootprintTextures
    {
        [DBKey]
        public int ID { get; set; }
        public string FootstepFilename { get; set; }
    }

    [DBTable(Expansion.TBC)]
    public class FootstepTerrainLookup
    {
        [DBKey]
        public int ID { get; set; }
        public int CreatureFootstepID { get; set; }
        public int TerrainSoundID { get; set; }
        public int SoundID { get; set; }
        public int SoundIDSplash { get; set; }
    }

    [DBTable(Expansion.TBC)]
    public class GameObjectArtKit
    {
        [DBKey]
        public int ID { get; set; }
        public string TextureVariation1 { get; set; }
        public string TextureVariation2 { get; set; }
        public string TextureVariation3 { get; set; }
        public string AttachModel1 { get; set; }
        public string AttachModel2 { get; set; }
        public string AttachModel3 { get; set; }
        public string AttachModel4 { get; set; }
    }

    [DBTable(Expansion.TBC)]
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
    }

    [DBTable(Expansion.TBC)]
    public class GameTables
    {
        [DBKey(AutoGenerated: true)]
        public int GeneratedID { get; set; }
        public string Name { get; set; }
        public int NumRows { get; set; }
        public int NumColumns { get; set; }
    }

    [DBTable(Expansion.TBC)]
    public class GameTips
    {
        [DBKey]
        public int ID { get; set; }
        public LocalizedString Text { get; set; }
    }

    [DBTable(Expansion.TBC)]
    public class GemProperties
    {
        [DBKey]
        public int Id { get; set; }
        public int Enchant_id { get; set; }
        public int Maxcount_inv { get; set; }
        public int Maxcount_item { get; set; }
        public int Type { get; set; }
    }

    [DBTable(Expansion.TBC)]
    public class GMSurveyCurrentSurvey
    {
        [DBKey]
        public int LANGID { get; set; }
        public int GMSURVEYID { get; set; }
    }

    [DBTable(Expansion.TBC)]
    public class GMSurveyQuestions
    {
        [DBKey]
        public int ID { get; set; }
        public LocalizedString Question { get; set; }
    }

    [DBTable(Expansion.TBC)]
    public class GMSurveySurveys
    {
        [DBKey]
        public int ID { get; set; }
        [DBField(ArraySize: 10)]
        public int[] Q { get; set; }
    }

    [DBTable(Expansion.TBC)]
    public class GMTicketCategory
    {
        [DBKey]
        public int ID { get; set; }
        public LocalizedString Category { get; set; }
    }

    [DBTable(Expansion.TBC)]
    public class GroundEffectDoodad
    {
        [DBKey]
        public int ID { get; set; }
        public int Flags { get; set; }
        public string DoodadPath { get; set; }
    }

    [DBTable(Expansion.TBC)]
    public class GroundEffectTexture
    {
        [DBKey]
        public int ID { get; set; }
        [DBField(ArraySize: 4)]
        public int[] DoodadID { get; set; }
        public int Density { get; set; }
        public int Sound { get; set; }
    }

    [DBTable(Expansion.TBC)]
    public class GtChanceToMeleeCrit
    {
        [DBKey(AutoGenerated: true)]
        public int GeneratedID { get; set; }
        public float Data { get; set; }
    }

    [DBTable(Expansion.TBC)]
    public class GtChanceToMeleeCritBase
    {
        [DBKey(AutoGenerated: true)]
        public int GeneratedID { get; set; }
        public float Data { get; set; }
    }

    [DBTable(Expansion.TBC)]
    public class GtChanceToSpellCrit
    {
        [DBKey(AutoGenerated: true)]
        public int GeneratedID { get; set; }
        public float Data { get; set; }
    }

    [DBTable(Expansion.TBC)]
    public class GtChanceToSpellCritBase
    {
        [DBKey(AutoGenerated: true)]
        public int GeneratedID { get; set; }
        public float Data { get; set; }
    }

    [DBTable(Expansion.TBC)]
    public class GtCombatRatings
    {
        [DBKey(AutoGenerated: true)]
        public int GeneratedID { get; set; }
        public float Data { get; set; }
    }

    [DBTable(Expansion.TBC)]
    public class GtNPCManaCostScaler
    {
        [DBKey(AutoGenerated: true)]
        public int ID { get; set; }
        public float Data { get; set; }
    }

    [DBTable(Expansion.TBC)]
    public class GtOCTRegenHP
    {
        [DBKey(AutoGenerated: true)]
        public int GeneratedID { get; set; }
        public float Data { get; set; }
    }

    [DBTable(Expansion.TBC)]
    public class GtOCTRegenMP
    {
        [DBKey(AutoGenerated: true)]
        public int GeneratedID { get; set; }
        public float Data { get; set; }
    }

    [DBTable(Expansion.TBC)]
    public class GtRegenHPPerSpt
    {
        [DBKey(AutoGenerated: true)]
        public int GeneratedID { get; set; }
        public float Data { get; set; }
    }

    [DBTable(Expansion.TBC)]
    public class GtRegenMPPerSpt
    {
        [DBKey(AutoGenerated: true)]
        public int GeneratedID { get; set; }
        public float Data { get; set; }
    }

    [DBTable(Expansion.TBC)]
    public class HelmetGeosetVisData
    {
        [DBKey]
        public int ID { get; set; }
        [DBField(ArraySize: 5)]
        public int[] HideGeoset { get; set; }
    }

    [DBTable(Expansion.TBC)]
    public class Item
    {
        [DBKey]
        public int ID { get; set; }
        public int ClassID { get; set; }
        public int InventoryType { get; set; }
        public int SheatheType { get; set; }
    }

    [DBTable(Expansion.TBC)]
    public class ItemBagFamily
    {
        [DBKey]
        public int ID { get; set; }
        public LocalizedString Name { get; set; }
    }

    [DBTable(Expansion.TBC)]
    public class ItemClass
    {
        [DBKey]
        public int ClassID { get; set; }
        public int SubclassMapID { get; set; }
        public int Flags { get; set; }
        public LocalizedString Classname { get; set; }
    }

    [DBTable(Expansion.TBC)]
    public class ItemCondExtCosts
    {
        [DBKey]
        public int ID { get; set; }
        public int CondExtendedCost { get; set; }
        public int Itemextendedcostentry { get; set; }
        public int Arenaseason { get; set; }
    }

    [DBTable(Expansion.TBC)]
    public class ItemDisplayInfo
    {
        [DBKey]
        public int ID { get; set; }
        public string ModelName1 { get; set; }
        public string ModelName2 { get; set; }
        public string ModelTexture1 { get; set; }
        public string ModelTexture2 { get; set; }
        public string InventoryIcon1 { get; set; }
        public string InventoryIcon2 { get; set; }
        [DBField(ArraySize: 3)]
        public int[] GeosetGroup { get; set; }
        public int Flags { get; set; }
        public int SpellVisualID { get; set; }
        public int GroupSoundIndex { get; set; }
        [DBField(ArraySize: 2)]
        public int[] HelmetGeosetVis { get; set; }
        public string Texture1 { get; set; }
        public string Texture2 { get; set; }
        public string Texture3 { get; set; }
        public string Texture4 { get; set; }
        public string Texture5 { get; set; }
        public string Texture6 { get; set; }
        public string Texture7 { get; set; }
        public string Texture8 { get; set; }
        public int ItemVisual { get; set; }
        public int ParticleColorID { get; set; }
    }

    [DBTable(Expansion.TBC)]
    public class ItemExtendedCost
    {
        [DBKey]
        public int ID { get; set; }
        public int HonorPoints { get; set; }
        public int ArenaPoints { get; set; }
        [DBField(ArraySize: 5)]
        public int[] ItemID { get; set; }
        [DBField(ArraySize: 5)]
        public int[] ItemCount { get; set; }
    }

    [DBTable(Expansion.TBC)]
    public class ItemGroupSounds
    {
        [DBKey]
        public int ID { get; set; }
        [DBField(ArraySize: 4)]
        public int[] SoundID { get; set; }
    }

    [DBTable(Expansion.TBC)]
    public class ItemPetFood
    {
        [DBKey]
        public int ID { get; set; }
        public LocalizedString Name { get; set; }
    }

    [DBTable(Expansion.TBC)]
    public class ItemRandomProperties
    {
        [DBKey]
        public int ID { get; set; }
        public string Name { get; set; }
        [DBField(ArraySize: 5)]
        public int[] Enchantment { get; set; }
        public LocalizedString Suffix { get; set; }
    }

    [DBTable(Expansion.TBC)]
    public class ItemRandomSuffix
    {
        [DBKey]
        public int ID { get; set; }
        public LocalizedString Name_lang { get; set; }
        public string InternalName { get; set; }
        [DBField(ArraySize: 3)]
        public int[] Enchantment { get; set; }
        [DBField(ArraySize: 3)]
        public int[] AllocationPct { get; set; }
    }

    [DBTable(Expansion.TBC)]
    public class ItemSet
    {
        [DBKey]
        public int ID { get; set; }
        public LocalizedString Name { get; set; }
        [DBField(ArraySize: 10)]
        public int[] ItemID { get; set; }
        [DBField(ArraySize: 7)]
        public int[] BankItemID { get; set; }
        [DBField(ArraySize: 8)]
        public int[] SetSpellID { get; set; }
        [DBField(ArraySize: 8)]
        public int[] SetThreshold { get; set; }
        public int RequiredSkill { get; set; }
        public int RequiredSkillRank { get; set; }
    }

    [DBTable(Expansion.TBC)]
    public class ItemSubClass
    {
        [DBKey]
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
        public LocalizedString DisplayName { get; set; }
        public LocalizedString VerboseName { get; set; }
    }

    [DBTable(Expansion.TBC)]
    public class ItemSubClassMask
    {
        [DBKey]
        public int ClassID { get; set; }
        public int Mask { get; set; }
        public LocalizedString Name { get; set; }
    }

    [DBTable(Expansion.TBC)]
    public class ItemVisualEffects
    {
        [DBKey]
        public int ID { get; set; }
        public string Model { get; set; }
    }

    [DBTable(Expansion.TBC)]
    public class ItemVisuals
    {
        [DBKey]
        public int ID { get; set; }
        [DBField(ArraySize: 5)]
        public int[] Slot { get; set; }
    }

    [DBTable(Expansion.TBC)]
    public class Languages
    {
        [DBKey]
        public int ID { get; set; }
        public LocalizedString Name { get; set; }
    }

    [DBTable(Expansion.TBC)]
    public class LanguageWords
    {
        [DBKey]
        public int ID { get; set; }
        public int LanguageID { get; set; }
        public string Word { get; set; }
    }

    [DBTable(WDBXLib.Common.Constants.Expansion.TBC)]
    public class LfgDungeons
    {
        [DBKey]
        public int ID { get; set; }
        public LocalizedString Name_lang { get; set; }
        public int MinLevel { get; set; }
        public int MaxLevel { get; set; }
        public int TypeID { get; set; }
        public int Faction { get; set; }
        public string Description { get; set; }
        public int Expansion { get; set; }
    }

    [DBTable(Expansion.TBC)]
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
        [DBField(ArraySize: 5)]
        public int[] LightParamsID { get; set; }
    }

    [DBTable(Expansion.TBC)]
    public class LightFloatBand
    {
        [DBKey]
        public int ID { get; set; }
        public int Num { get; set; }
        [DBField(ArraySize: 16)]
        public int[] Time { get; set; }
        [DBField(ArraySize: 16)]
        public float[] Data { get; set; }
    }

    [DBTable(Expansion.TBC)]
    public class LightIntBand
    {
        [DBKey]
        public int ID { get; set; }
        public int Num { get; set; }
        [DBField(ArraySize: 16)]
        public int[] Time { get; set; }
        [DBField(ArraySize: 16)]
        public int[] Data { get; set; }
    }

    [DBTable(Expansion.TBC)]
    public class LightParams
    {
        [DBKey]
        public int ID { get; set; }
        public int HighlightSky { get; set; }
        public int LightSkyboxID { get; set; }
        public float Glow { get; set; }
        public float WaterShallowAlpha { get; set; }
        public float WaterDeepAlpha { get; set; }
        public float OceanShallowAlpha { get; set; }
        public float OceanDeepAlpha { get; set; }
        public int Flags { get; set; }
    }

    [DBTable(Expansion.TBC)]
    public class LightSkybox
    {
        [DBKey]
        public int ID { get; set; }
        public string Name { get; set; }
        public int Flags { get; set; }
    }

    [DBTable(Expansion.TBC)]
    public class LiquidType
    {
        [DBKey]
        public int ID { get; set; }
        public string Name { get; set; }
        public int Type { get; set; }
        public int SpellID { get; set; }
    }

    [DBTable(Expansion.TBC)]
    public class LoadingScreens
    {
        [DBKey]
        public int ID { get; set; }
        public string Name { get; set; }
        public string FileName { get; set; }
    }

    [DBTable(Expansion.TBC)]
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

    [DBTable(Expansion.TBC)]
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

    [DBTable(Expansion.TBC)]
    public class LockType
    {
        [DBKey]
        public int ID { get; set; }
        public LocalizedString Name { get; set; }
        public LocalizedString ResourceName { get; set; }
        public LocalizedString Verb { get; set; }
        public string CursorName { get; set; }
    }

    [DBTable(Expansion.TBC)]
    public class MailTemplate
    {
        [DBKey]
        public int ID { get; set; }
        public LocalizedString Subject_lang { get; set; }
        public LocalizedString Body_lang { get; set; }
    }

    [DBTable(Expansion.TBC)]
    public class Map
    {
        [DBKey]
        public int ID { get; set; }
        public string Directory { get; set; }
        public int InstanceType { get; set; }
        public int PVP { get; set; }
        public LocalizedString MapName_lang { get; set; }
        [DBField(ArraySize: 6)]
        public int[] Unknown { get; set; }
        public int AreaTableID { get; set; }
        public LocalizedString MapDescription0_lang { get; set; }
        public LocalizedString MapDescription1_lang { get; set; }
        public int LoadingScreenID { get; set; }
        public int Unknown2 { get; set; }
        public int Unknown3 { get; set; }
        public float MinimapIconScale { get; set; }
        public LocalizedString RequirementText_lang { get; set; }
        public LocalizedString HeroicText_lang { get; set; }
        public LocalizedString EmptyText2_lang { get; set; }
        public int CorpseMapID { get; set; }
        public float CorpseX { get; set; }
        public float CorpseY { get; set; }
        public int ResetTimeRaid { get; set; }
        public int ResetTimeHeroic { get; set; }
        public int Unknown4 { get; set; }
        public int TimeOfDayOverride { get; set; }
        public int ExpansionID { get; set; }
    }

    [DBTable(Expansion.TBC)]
    public class Material
    {
        [DBKey]
        public int ID { get; set; }
        public int Flags { get; set; }
        public int FoleySoundID { get; set; }
    }

    [DBTable(Expansion.TBC)]
    public class NameGen
    {
        [DBKey]
        public int ID { get; set; }
        public string Name { get; set; }
        public int RaceID { get; set; }
        public int Sex { get; set; }
    }

    [DBTable(Expansion.TBC)]
    public class NamesProfanity
    {
        [DBKey]
        public int ID { get; set; }
        public string Name { get; set; }
        public int Language { get; set; }
    }

    [DBTable(Expansion.TBC)]
    public class NamesReserved
    {
        [DBKey]
        public int ID { get; set; }
        public string Name { get; set; }
        public int Language { get; set; }
    }

    [DBTable(Expansion.TBC)]
    public class NPCSounds
    {
        [DBKey]
        public int ID { get; set; }
        [DBField(ArraySize: 4)]
        public int[] SoundID { get; set; }
    }

    [DBTable(Expansion.TBC)]
    public class Package
    {
        [DBKey]
        public int ID { get; set; }
        public string Icon { get; set; }
        public int Cost { get; set; }
        public LocalizedString Name { get; set; }
    }

    [DBTable(Expansion.TBC)]
    public class PageTextMaterial
    {
        [DBKey]
        public int ID { get; set; }
        public string Name { get; set; }
    }

    [DBTable(Expansion.TBC)]
    public class PaperDollItemFrame
    {
        [DBKey]
        public int ItemButtonName { get; set; }
        public string SlotIcon { get; set; }
        public int SlotNumber { get; set; }
    }

    [DBTable(Expansion.TBC)]
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

    [DBTable(Expansion.TBC)]
    public class PetitionType
    {
        [DBKey]
        public int ID { get; set; }
        public int RefName { get; set; }
        public int Unknown { get; set; }
    }

    [DBTable(Expansion.TBC)]
    public class PetLoyalty
    {
        [DBKey]
        public int ID { get; set; }
        public LocalizedString Name { get; set; }
    }

    [DBTable(Expansion.TBC)]
    public class PetPersonality
    {
        [DBKey]
        public int ID { get; set; }
        public LocalizedString Name { get; set; }
        [DBField(ArraySize: 3)]
        public int[] HappinessThreshold { get; set; }
        [DBField(ArraySize: 3)]
        public float[] HappinessDamage { get; set; }
        [DBField(ArraySize: 3)]
        public float[] DamageModifier { get; set; }
    }

    [DBTable(Expansion.TBC)]
    public class QuestInfo
    {
        [DBKey]
        public int ID { get; set; }
        public LocalizedString InfoName { get; set; }
    }

    [DBTable(Expansion.TBC)]
    public class QuestSort
    {
        [DBKey]
        public int ID { get; set; }
        public LocalizedString SortName { get; set; }
    }

    [DBTable(Expansion.TBC)]
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

    [DBTable(Expansion.TBC)]
    public class Resistances
    {
        [DBKey]
        public int ID { get; set; }
        public int Flags { get; set; }
        public int FizzleSoundID { get; set; }
        public LocalizedString Name { get; set; }
    }

    [DBTable(Expansion.TBC)]
    public class ServerMessages
    {
        [DBKey]
        public int ID { get; set; }
        public LocalizedString Text { get; set; }
    }

    [DBTable(Expansion.TBC)]
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

    [DBTable(Expansion.TBC)]
    public class SkillCostsData
    {
        [DBKey]
        public int ID { get; set; }
        public int SkillCostsID { get; set; }
        [DBField(ArraySize: 3)]
        public int[] Cost { get; set; }
    }

    [DBTable(Expansion.TBC)]
    public class SkillLine
    {
        [DBKey]
        public int ID { get; set; }
        public int CategoryID { get; set; }
        public int SkillCostsID { get; set; }
        public LocalizedString DisplayName { get; set; }
        public LocalizedString Description { get; set; }
        public int SpellIconID { get; set; }
    }

    [DBTable(Expansion.TBC)]
    public class SkillLineAbility
    {
        [DBKey]
        public int ID { get; set; }
        public int SkillLine { get; set; }
        public int Spell { get; set; }
        public int RaceMask { get; set; }
        public int ClassMask { get; set; }
        public int ExcludeRace { get; set; }
        public int ExcludeClass { get; set; }
        public int MinSkillLineRank { get; set; }
        public int SupercededBySpell { get; set; }
        public int AquireMethod { get; set; }
        public int TrivialSkillLineRankHigh { get; set; }
        public int TrivialSkillLineRankLow { get; set; }
        [DBField(ArraySize: 2)]
        public int[] CharacterPoints { get; set; }
        public int NumSkillUps { get; set; }
    }

    [DBTable(Expansion.TBC)]
    public class SkillLineCategory
    {
        [DBKey]
        public int ID { get; set; }
        public LocalizedString Name { get; set; }
        public int SortIndex { get; set; }
    }

    [DBTable(Expansion.TBC)]
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

    [DBTable(Expansion.TBC)]
    public class SkillTiers
    {
        [DBKey]
        public int ID { get; set; }
        [DBField(ArraySize: 16)]
        public int[] Cost { get; set; }
        [DBField(ArraySize: 16)]
        public int[] Value { get; set; }
    }

    [DBTable(Expansion.TBC)]
    public class SoundAmbience
    {
        [DBKey]
        public int ID { get; set; }
        [DBField(ArraySize: 2)]
        public int[] AmbienceID { get; set; }
    }

    [DBTable(Expansion.TBC)]
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
    }

    [DBTable(Expansion.TBC)]
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

    [DBTable(Expansion.TBC)]
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

    [DBTable(Expansion.TBC)]
    public class SoundWaterType
    {
        [DBKey]
        public int ID { get; set; }
        public int LiquidTypeID { get; set; }
        public int FluidSpeed { get; set; }
        public int SoundID { get; set; }
    }

    [DBTable(Expansion.TBC)]
    public class SpamMessages
    {
        [DBKey]
        public int ID { get; set; }
        public string Text { get; set; }
    }

    [DBTable(Expansion.TBC)]
    public class Spell
    {
        [DBKey]
        public int ID { get; set; }
        public int Category { get; set; }
        public int CastUI { get; set; }
        public int DispelType { get; set; }
        public int Mechanic { get; set; }
        public int Attributes { get; set; }
        public int AttributesEx { get; set; }
        public int AttributesExB { get; set; }
        public int AttributesExC { get; set; }
        public int AttributesExD { get; set; }
        public int AttributesExE { get; set; }
        public int AttributesExF { get; set; }
        public int ShapeshiftMask { get; set; }
        public int ShapeshiftExclude { get; set; }
        public int Targets { get; set; }
        public int TargetCreatureType { get; set; }
        public int RequireSpellFocus { get; set; }
        public int FacingCasterFlags { get; set; }
        public int CasterAuraState { get; set; }
        public int TargetAuraState { get; set; }
        public int ExcludeCasterAuraState { get; set; }
        public int ExcludeTargetAuraState { get; set; }
        public int CastingTimeIndex { get; set; }
        public int RecoveryTime { get; set; }
        public int CategoryRecoveryTime { get; set; }
        public int InterruptFlags { get; set; }
        public int AurainterruptFlags { get; set; }
        public int ChannelinterruptFlags { get; set; }
        public int ProcTypeMask { get; set; }
        public int ProcChance { get; set; }
        public int ProcCharges { get; set; }
        public int MaxLevel { get; set; }
        public int BaseLevel { get; set; }
        public int SpellLevel { get; set; }
        public int DurationIndex { get; set; }
        public int PowerType { get; set; }
        public int ManaCost { get; set; }
        public int ManaCostPerLevel { get; set; }
        public int ManaPerSecond { get; set; }
        public int ManaPerSecondPerLevel { get; set; }
        public int RangeIndex { get; set; }
        public float Speed { get; set; }
        public int SmodalNextSpell { get; set; }
        public int StackAmount { get; set; }
        [DBField(ArraySize: 2)]
        public int[] Totem { get; set; }
        [DBField(ArraySize: 8)]
        public int[] Reagent { get; set; }
        [DBField(ArraySize: 8)]
        public int[] ReagentCount { get; set; }
        public int EquippedItemClass { get; set; }
        public int EquippedItemSubclass { get; set; }
        public int EquippedItemInvTypes { get; set; }
        [DBField(ArraySize: 3)]
        public int[] Effect { get; set; }
        [DBField(ArraySize: 3)]
        public int[] EffectDieSides { get; set; }
        [DBField(ArraySize: 3)]
        public int[] EffectBaseDice { get; set; }
        [DBField(ArraySize: 3)]
        public float[] EffectDicePerLevel { get; set; }
        [DBField(ArraySize: 3)]
        public float[] EffectRealPointsPerLevel { get; set; }
        [DBField(ArraySize: 3)]
        public int[] EffectBasePoints { get; set; }
        [DBField(ArraySize: 3)]
        public int[] EffectMechanic { get; set; }
        [DBField(ArraySize: 3)]
        public int[] ImplicitTargetA { get; set; }
        [DBField(ArraySize: 3)]
        public int[] ImplicitTargetB { get; set; }
        [DBField(ArraySize: 3)]
        public int[] EffectRadiusIndex { get; set; }
        [DBField(ArraySize: 3)]
        public int[] EffectAura { get; set; }
        [DBField(ArraySize: 3)]
        public int[] EffectAmplitude { get; set; }
        [DBField(ArraySize: 3)]
        public float[] EffectMultipleValue { get; set; }
        [DBField(ArraySize: 3)]
        public int[] EffectChaintargets { get; set; }
        [DBField(ArraySize: 3)]
        public int[] EffectItemType { get; set; }
        [DBField(ArraySize: 3)]
        public int[] EffectMiscValue { get; set; }
        [DBField(ArraySize: 3)]
        public int[] EffectMiscValueB { get; set; }
        [DBField(ArraySize: 3)]
        public int[] EffectTriggerSpell { get; set; }
        [DBField(ArraySize: 3)]
        public float[] EffectPointsPerCombo { get; set; }
        [DBField(ArraySize: 2)]
        public int[] SpellVisualID { get; set; }
        public int SpellIconID { get; set; }
        public int ActiveIconID { get; set; }
        public int SpellPriority { get; set; }
        public LocalizedString Name_lang { get; set; }
        public LocalizedString Rank_lang { get; set; }
        public LocalizedString Description_lang { get; set; }
        public LocalizedString Tooltip_lang { get; set; }
        public int ManaCostPct { get; set; }
        public int StartRecoveryCategory { get; set; }
        public int StartRecoveryTime { get; set; }
        public int AffectedTargetLevel { get; set; }
        public int SpellFamilyName { get; set; }
        [DBField(ArraySize: 2)]
        public int[] SpellFamilyFlags { get; set; }
        public int MaxTargets { get; set; }
        public int DmgClass { get; set; }
        public int PreventionType { get; set; }
        public int StanceBarOrder { get; set; }
        [DBField(ArraySize: 3)]
        public float[] DmgMultiplier { get; set; }
        public int MinFactionId { get; set; }
        public int MinReputation { get; set; }
        public int RequiredAuraVision { get; set; }
        [DBField(ArraySize: 2)]
        public int[] RequiredTotemCategoryID { get; set; }
        public int RequiredAreasID { get; set; }
        public int SchoolMask { get; set; }
    }

    [DBTable(Expansion.TBC)]
    public class SpellCastTimes
    {
        [DBKey]
        public int ID { get; set; }
        public int Base { get; set; }
        public int PerLevel { get; set; }
        public int Minimum { get; set; }
    }

    [DBTable(Expansion.TBC)]
    public class SpellCategory
    {
        [DBKey]
        public int ID { get; set; }
        public int Flags { get; set; }
    }

    [DBTable(Expansion.TBC)]
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
        public int Combo { get; set; }
        public int RenderLayer { get; set; }
        public float TextureLength { get; set; }
    }

    [DBTable(Expansion.TBC)]
    public class SpellDispelType
    {
        [DBKey]
        public int ID { get; set; }
        public LocalizedString Name { get; set; }
        public int Mask { get; set; }
        public int ImmunityPossible { get; set; }
        public string InternalName { get; set; }
    }

    [DBTable(Expansion.TBC)]
    public class SpellDuration
    {
        [DBKey]
        public int ID { get; set; }
        public int Duration { get; set; }
        public int DurationPerLevel { get; set; }
        public int MaxDuration { get; set; }
    }

    [DBTable(Expansion.TBC)]
    public class SpellEffectCameraShakes
    {
        [DBKey]
        public int ID { get; set; }
        [DBField(ArraySize: 3)]
        public int[] CameraShake { get; set; }
    }

    [DBTable(Expansion.TBC)]
    public class SpellFocusObject
    {
        [DBKey]
        public int ID { get; set; }
        public LocalizedString Name { get; set; }
    }

    [DBTable(Expansion.TBC)]
    public class SpellIcon
    {
        [DBKey]
        public int Id { get; set; }
        public string TextureFilename { get; set; }
    }

    [DBTable(Expansion.TBC)]
    public class SpellItemEnchantment
    {
        [DBKey]
        public int ID { get; set; }
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
    }

    [DBTable(Expansion.TBC)]
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

    [DBTable(Expansion.TBC)]
    public class SpellMechanic
    {
        [DBKey]
        public int ID { get; set; }
        public LocalizedString StateName { get; set; }
    }

    [DBTable(Expansion.TBC)]
    public class SpellMissileMotion
    {
        [DBKey]
        public int ID { get; set; }
        public string Name { get; set; }
        public string ScriptBody { get; set; }
        public int Flags { get; set; }
        public int MissileCount { get; set; }
    }

    [DBTable(Expansion.TBC)]
    public class SpellRadius
    {
        [DBKey]
        public int ID { get; set; }
        public float Radius { get; set; }
        public float RadiusPerLevel { get; set; }
        public float RadiusMax { get; set; }
    }

    [DBTable(Expansion.TBC)]
    public class SpellRange
    {
        [DBKey]
        public int ID { get; set; }
        public float RangeMin { get; set; }
        public float RangeMax { get; set; }
        public int Flags { get; set; }
        public LocalizedString DisplayName { get; set; }
        public LocalizedString DisplayNameShort { get; set; }
    }

    [DBTable(Expansion.TBC)]
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

    [DBTable(Expansion.TBC)]
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
    }

    [DBTable(Expansion.TBC)]
    public class SpellVisualEffectName
    {
        [DBKey]
        public int ID { get; set; }
        public string Name { get; set; }
        public string FileName { get; set; }
        public float AreaEffectSize { get; set; }
        public float Scale { get; set; }
    }

    [DBTable(Expansion.TBC)]
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
        public int Flags { get; set; }
    }

    [DBTable(Expansion.TBC)]
    public class SpellVisualPrecastTransitions
    {
        [DBKey]
        public int ID { get; set; }
        public string LoadAnimation { get; set; }
        public string HoldAnimation { get; set; }
    }

    [DBTable(Expansion.TBC)]
    public class StableSlotPrices
    {
        [DBKey]
        public int ID { get; set; }
        public int Cost { get; set; }
    }

    [DBTable(Expansion.TBC)]
    public class Startup_Strings
    {
        [DBKey]
        public int ID { get; set; }
        public string Name { get; set; }
        public LocalizedString String { get; set; }
    }

    [DBTable(Expansion.TBC)]
    public class Stationery
    {
        [DBKey]
        public int ID { get; set; }
        public int ItemID { get; set; }
        public string Texture { get; set; }
        public int Flags { get; set; }
    }

    [DBTable(Expansion.TBC)]
    public class StringLookups
    {
        [DBKey]
        public int ID { get; set; }
        public string String { get; set; }
    }

    [DBTable(Expansion.TBC)]
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

    [DBTable(Expansion.TBC)]
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
    }

    [DBTable(Expansion.TBC)]
    public class TalentTab
    {
        [DBKey]
        public int ID { get; set; }
        public LocalizedString Name { get; set; }
        public int SpellIconID { get; set; }
        public int RaceMask { get; set; }
        public int ClassMask { get; set; }
        public uint OrderIndex { get; set; }
        public string BackgroundFile { get; set; }
    }

    [DBTable(Expansion.TBC)]
    public class TaxiNodes
    {
        [DBKey]
        public int ID { get; set; }
        public int ContinentID { get; set; }
        public float X { get; set; }
        public float Y { get; set; }
        public float Z { get; set; }
        public LocalizedString Name { get; set; }
        [DBField(ArraySize: 2)]
        public int[] MountCreatureID { get; set; }
    }

    [DBTable(Expansion.TBC)]
    public class TaxiPath
    {
        [DBKey]
        public int ID { get; set; }
        public int FromTaxiNode { get; set; }
        public int ToTaxiNode { get; set; }
        public int Cost { get; set; }
    }

    [DBTable(Expansion.TBC)]
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
    }

    [DBTable(Expansion.TBC)]
    public class TerrainType
    {
        [DBKey]
        public int ID { get; set; }
        public string TerrainDesc { get; set; }
        public int FootstepSprayRun { get; set; }
        public int FootstepSprayWalk { get; set; }
        public int SoundID { get; set; }
        public int Flags { get; set; }
    }

    [DBTable(Expansion.TBC)]
    public class TerrainTypeSounds
    {
        [DBKey]
        public int ID { get; set; }
    }

    [DBTable(Expansion.TBC)]
    public class TotemCategory
    {
        [DBKey]
        public int ID { get; set; }
        public LocalizedString Name_lang { get; set; }
        public int TotemCategoryType { get; set; }
        public int TotemCategoryMask { get; set; }
    }

    [DBTable(Expansion.TBC)]
    public class TransportAnimation
    {
        [DBKey]
        public int ID { get; set; }
        public int TransportID { get; set; }
        public int TimeIndex { get; set; }
        public int PosX { get; set; }
        public int PosY { get; set; }
        public float PosZ { get; set; }
        public int SequenceID { get; set; }
    }

    [DBTable(Expansion.TBC)]
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

    [DBTable(Expansion.TBC)]
    public class UISoundLookups
    {
        [DBKey]
        public int ID { get; set; }
        public int SoundID { get; set; }
        public string Name { get; set; }
    }

    [DBTable(Expansion.TBC)]
    public class UnitBlood
    {
        [DBKey]
        public int ID { get; set; }
        [DBField(ArraySize: 2)]
        public int[] CombatBloodSpurtFront { get; set; }
        [DBField(ArraySize: 2)]
        public int[] CombatBloodSpurtBack { get; set; }
        public string GroundBlood1 { get; set; }
        public string GroundBlood2 { get; set; }
        public string GroundBlood3 { get; set; }
        public string GroundBlood4 { get; set; }
        public string GroundBlood5 { get; set; }
    }

    [DBTable(Expansion.TBC)]
    public class UnitBloodLevels
    {
        [DBKey]
        public int ID { get; set; }
        [DBField(ArraySize: 3)]
        public int[] Violencelevel { get; set; }
    }

    [DBTable(Expansion.TBC)]
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
        public int OglOverrides { get; set; }
        public int D3dOverrides { get; set; }
        public int FixLag { get; set; }
        public int Multisample { get; set; }
        public int Atlasdisable { get; set; }
    }

    [DBTable(Expansion.TBC)]
    public class VocalUISounds
    {
        [DBKey]
        public int ID { get; set; }
        public int VocalUIEnum { get; set; }
        public int RaceID { get; set; }
        [DBField(ArraySize: 2)]
        public int[] NormalSoundID { get; set; }
        [DBField(ArraySize: 2)]
        public int[] PissedSound { get; set; }
    }

    [DBTable(Expansion.TBC)]
    public class WeaponImpactSounds
    {
        [DBKey]
        public int ID { get; set; }
        public int WeaponSubclassID { get; set; }
        public int ParrySoundType { get; set; }
        [DBField(ArraySize: 10)]
        public int[] ImpactSoundID { get; set; }
        [DBField(ArraySize: 10)]
        public int[] CritImpactSoundID { get; set; }
    }

    [DBTable(Expansion.TBC)]
    public class WeaponSwingSounds2
    {
        [DBKey]
        public int ID { get; set; }
        public int SwingType { get; set; }
        public int Crit { get; set; }
        public int SoundID { get; set; }
    }

    [DBTable(Expansion.TBC)]
    public class Weather
    {
        [DBKey]
        public int ID { get; set; }
        public int AmbienceID { get; set; }
        public int EffectType { get; set; }
        public float TransitionSkyBox { get; set; }
        [DBField(ArraySize: 3)]
        public float[] EffectColor { get; set; }
    }

    [DBTable(Expansion.TBC)]
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
        public uint Flags { get; set; }
        public int AreaTableID { get; set; }
        public LocalizedString AreaName { get; set; }
    }

    [DBTable(Expansion.TBC)]
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
    }

    [DBTable(Expansion.TBC)]
    public class WorldMapContinent
    {
        [DBKey]
        public int ID { get; set; }
        public int MapID { get; set; }
        public uint LeftBoundary { get; set; }
        public uint RightBoundary { get; set; }
        public uint TopBoundary { get; set; }
        public uint BottomBoundary { get; set; }
        public float ContinentOffsetX { get; set; }
        public float ContinentOffsetY { get; set; }
        public float Scale { get; set; }
        public float TaxiMinX { get; set; }
        public float TaxiMinY { get; set; }
        public float TaxiMaxX { get; set; }
        public float TaxiMaxY { get; set; }
    }

    [DBTable(Expansion.TBC)]
    public class WorldMapOverlay
    {
        [DBKey]
        public int ID { get; set; }
        public int MapArea { get; set; }
        [DBField(ArraySize: 4)]
        public int[] AreaID { get; set; }
        public uint MapPointX { get; set; }
        public uint MapPointY { get; set; }
        public string TextureName { get; set; }
        public uint TextureWidth { get; set; }
        public uint TextureHeight { get; set; }
        public uint OffsetX { get; set; }
        public uint OffsetY { get; set; }
        public uint HitRectTop { get; set; }
        public uint HitRectLeft { get; set; }
        public uint HitRectBottom { get; set; }
        public uint HitRectRight { get; set; }
    }

    [DBTable(Expansion.TBC)]
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
    }

    [DBTable(Expansion.TBC)]
    public class WorldSafeLocs
    {
        [DBKey]
        public int ID { get; set; }
        public int Continent { get; set; }
        public float LocationX { get; set; }
        public float LocationY { get; set; }
        public float LocationZ { get; set; }
        public LocalizedString AreaName { get; set; }
    }

    [DBTable(Expansion.TBC)]
    public class WorldStateUI
    {
        [DBKey]
        public int ID { get; set; }
        public uint Field2 { get; set; }
        public uint Field3 { get; set; }
        public string Field4 { get; set; }
        public LocalizedString Field5 { get; set; }
        public LocalizedString Field14 { get; set; }
        public int Field23 { get; set; }
        public uint Field24 { get; set; }
        public uint Field25 { get; set; }
        public string Field26 { get; set; }
        public LocalizedString Field27 { get; set; }
        public string Field36 { get; set; }
        public uint Field37 { get; set; }
        public uint Field38 { get; set; }
        public uint Field39 { get; set; }
    }

    [DBTable(Expansion.TBC)]
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
    }

    [DBTable(Expansion.TBC)]
    public class WowError_Strings
    {
        [DBKey]
        public int ID { get; set; }
        public string ErrorName { get; set; }
        public LocalizedString ErrorString { get; set; }
    }

    [DBTable(Expansion.TBC)]
    public class ZoneIntroMusicTable
    {
        [DBKey]
        public int ID { get; set; }
        public string Name { get; set; }
        public int SoundID { get; set; }
        public uint Priority { get; set; }
        public uint MinDelayMinutes { get; set; }
    }

    [DBTable(Expansion.TBC)]
    public class ZoneMusic
    {
        [DBKey]
        public int ID { get; set; }
        public string SetName { get; set; }
        public uint SilenceIntervalMinDay { get; set; }
        public uint SilenceIntervalMinNight { get; set; }
        public uint SilenceIntervalMaxDay { get; set; }
        public uint SilenceIntervalMaxNight { get; set; }
        public int SoundsDay { get; set; }
        public int SoundsNight { get; set; }
    }

}
