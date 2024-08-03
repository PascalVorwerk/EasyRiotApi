using System.Text.Json.Serialization;

namespace EasyRiotApi.Models.LoL.Match;

public class TimelineDto
{
    [JsonPropertyName("info")] public InfoTimelineDto Info { get; set; } = null!;

    [JsonPropertyName("metadata")] public MetadataTimelineDto Metadata { get; set; } = null!;
}

public class ParticipantFrameDto
{
    [JsonPropertyName("championStats")] public ChampionStatsDto ChampionStats { get; set; } = null!;

    [JsonPropertyName("currentGold")] public int CurrentGold { get; set; }

    [JsonPropertyName("damageStats")] public DamageStatsDto DamageStats { get; set; } = null!;

    [JsonPropertyName("goldPerSecond")] public int GoldPerSecond { get; set; }

    [JsonPropertyName("jungleMinionsKilled")]
    public int JungleMinionsKilled { get; set; }

    [JsonPropertyName("level")] public int Level { get; set; }

    [JsonPropertyName("minionsKilled")] public int MinionsKilled { get; set; }

    [JsonPropertyName("participantId")] public int ParticipantId { get; set; }

    [JsonPropertyName("position")] public PositionDto Position { get; set; } = null!;

    [JsonPropertyName("timeEnemySpentControlled")]
    public int TimeEnemySpentControlled { get; set; }

    [JsonPropertyName("totalGold")] public int TotalGold { get; set; }

    [JsonPropertyName("xp")] public int Xp { get; set; }
}

public class ChampionStatsDto
{
    [JsonPropertyName("abilityHaste")] public int AbilityHaste { get; set; }

    [JsonPropertyName("abilityPower")] public int AbilityPower { get; set; }

    [JsonPropertyName("armor")] public int Armor { get; set; }

    [JsonPropertyName("armorPen")] public int ArmorPen { get; set; }

    [JsonPropertyName("armorPenPercent")] public int ArmorPenPercent { get; set; }

    [JsonPropertyName("attackDamage")] public int AttackDamage { get; set; }

    [JsonPropertyName("attackSpeed")] public int AttackSpeed { get; set; }

    [JsonPropertyName("bonusArmorPenPercent")]
    public int BonusArmorPenPercent { get; set; }

    [JsonPropertyName("bonusMagicPenPercent")]
    public int BonusMagicPenPercent { get; set; }

    [JsonPropertyName("ccReduction")] public int CcReduction { get; set; }

    [JsonPropertyName("cooldownReduction")]
    public int CooldownReduction { get; set; }

    [JsonPropertyName("health")] public int Health { get; set; }

    [JsonPropertyName("healthMax")] public int HealthMax { get; set; }

    [JsonPropertyName("healthRegen")] public int HealthRegen { get; set; }

    [JsonPropertyName("lifesteal")] public int Lifesteal { get; set; }

    [JsonPropertyName("magicPen")] public int MagicPen { get; set; }

    [JsonPropertyName("magicPenPercent")] public int MagicPenPercent { get; set; }

    [JsonPropertyName("magicResist")] public int MagicResist { get; set; }

    [JsonPropertyName("movementSpeed")] public int MovementSpeed { get; set; }

    [JsonPropertyName("omnivamp")] public int Omnivamp { get; set; }

    [JsonPropertyName("physicalVamp")] public int PhysicalVamp { get; set; }

    [JsonPropertyName("power")] public int Power { get; set; }

    [JsonPropertyName("powerMax")] public int PowerMax { get; set; }

    [JsonPropertyName("powerRegen")] public int PowerRegen { get; set; }

    [JsonPropertyName("spellVamp")] public int SpellVamp { get; set; }
}

public class DamageStatsDto
{
    [JsonPropertyName("magicDamageDone")] public int MagicDamageDone { get; set; }

    [JsonPropertyName("magicDamageDoneToChampions")]
    public int MagicDamageDoneToChampions { get; set; }

    [JsonPropertyName("magicDamageTaken")] public int MagicDamageTaken { get; set; }

    [JsonPropertyName("physicalDamageDone")]
    public int PhysicalDamageDone { get; set; }

    [JsonPropertyName("physicalDamageDoneToChampions")]
    public int PhysicalDamageDoneToChampions { get; set; }

    [JsonPropertyName("physicalDamageTaken")]
    public int PhysicalDamageTaken { get; set; }

    [JsonPropertyName("totalDamageDone")] public int TotalDamageDone { get; set; }

    [JsonPropertyName("totalDamageDoneToChampions")]
    public int TotalDamageDoneToChampions { get; set; }

    [JsonPropertyName("totalDamageTaken")] public int TotalDamageTaken { get; set; }

    [JsonPropertyName("trueDamageDone")] public int TrueDamageDone { get; set; }

    [JsonPropertyName("trueDamageDoneToChampions")]
    public int TrueDamageDoneToChampions { get; set; }

    [JsonPropertyName("trueDamageTaken")] public int TrueDamageTaken { get; set; }
}

public class EventDto
{
    [JsonPropertyName("realTimestamp")] public long RealTimestamp { get; set; }

    [JsonPropertyName("timestamp")] public int Timestamp { get; set; }

    [JsonPropertyName("type")] public string Type { get; set; } = null!;

    [JsonPropertyName("itemId")] public int? ItemId { get; set; }

    [JsonPropertyName("participantId")] public int? ParticipantId { get; set; }

    [JsonPropertyName("levelUpType")] public string LevelUpType { get; set; } = null!;

    [JsonPropertyName("skillSlot")] public int? SkillSlot { get; set; }

    [JsonPropertyName("creatorId")] public int? CreatorId { get; set; }

    [JsonPropertyName("wardType")] public string WardType { get; set; } = null!;

    [JsonPropertyName("level")] public int? Level { get; set; }

    [JsonPropertyName("assistingParticipantIds")]
    public List<int> AssistingParticipantIds { get; set; } = null!;

    [JsonPropertyName("bounty")] public int? Bounty { get; set; }

    [JsonPropertyName("killStreakLength")] public int? KillStreakLength { get; set; }

    [JsonPropertyName("killerId")] public int? KillerId { get; set; }

    [JsonPropertyName("position")] public PositionDto Position { get; set; } = null!;

    [JsonPropertyName("shutdownBounty")] public int? ShutdownBounty { get; set; }

    [JsonPropertyName("victimDamageDealt")]
    public List<VictimDamageDealtDto> VictimDamageDealt { get; set; } = null!;

    [JsonPropertyName("victimDamageReceived")]
    public List<VictimDamageReceivedDto> VictimDamageReceived { get; set; } = null!;

    [JsonPropertyName("victimId")] public int? VictimId { get; set; }

    [JsonPropertyName("killType")] public string KillType { get; set; } = null!;

    [JsonPropertyName("killerTeamId")] public int? KillerTeamId { get; set; }

    [JsonPropertyName("monsterSubType")] public string MonsterSubType { get; set; } = null!;

    [JsonPropertyName("monsterType")] public string MonsterType { get; set; } = null!;

    [JsonPropertyName("laneType")] public string LaneType { get; set; } = null!;

    [JsonPropertyName("teamId")] public int? TeamId { get; set; }

    [JsonPropertyName("afterId")] public int? AfterId { get; set; }

    [JsonPropertyName("beforeId")] public int? BeforeId { get; set; }

    [JsonPropertyName("goldGain")] public int? GoldGain { get; set; }

    [JsonPropertyName("buildingType")] public string BuildingType { get; set; } = null!;

    [JsonPropertyName("towerType")] public string TowerType { get; set; } = null!;

    [JsonPropertyName("multiKillLength")] public int? MultiKillLength { get; set; }
}

public class FramesTimelineDto
{
    [JsonPropertyName("events")] public List<EventDto> Events { get; set; } = null!;

    [JsonPropertyName("participantFrames")]
    public ParticipantFramesDto ParticipantFrames { get; set; } = null!;

    [JsonPropertyName("timestamp")] public int Timestamp { get; set; }
}

public class InfoTimelineDto
{
    [JsonPropertyName("endOfGameResult")] public string EndOfGameResult { get; set; } = null!;

    [JsonPropertyName("frameInterval")] public int FrameInterval { get; set; }

    [JsonPropertyName("frames")] public List<FramesTimelineDto> Frames { get; set; } = null!;

    [JsonPropertyName("gameId")] public long GameId { get; set; }

    [JsonPropertyName("participants")] public List<ParticipantTimelineDto> Participants { get; set; } = null!;
}

public class MetadataTimelineDto
{
    [JsonPropertyName("dataVersion")] public string DataVersion { get; set; } = null!;

    [JsonPropertyName("matchId")] public string MatchId { get; set; } = null!;

    [JsonPropertyName("participants")] public List<string> Participants { get; set; } = null!;
}

public class ParticipantTimelineDto
{
    [JsonPropertyName("participantId")] public int ParticipantId { get; set; }

    [JsonPropertyName("puuid")] public string Puuid { get; set; } = null!;
}

public class ParticipantFramesDto
{
    [JsonPropertyName("1")] public ParticipantFrameDto _1 { get; set; } = null!;

    [JsonPropertyName("2")] public ParticipantFrameDto _2 { get; set; } = null!;

    [JsonPropertyName("3")] public ParticipantFrameDto _3 { get; set; } = null!;

    [JsonPropertyName("4")] public ParticipantFrameDto _4 { get; set; } = null!;

    [JsonPropertyName("5")] public ParticipantFrameDto _5 { get; set; } = null!;

    [JsonPropertyName("6")] public ParticipantFrameDto _6 { get; set; } = null!;

    [JsonPropertyName("7")] public ParticipantFrameDto _7 { get; set; } = null!;

    [JsonPropertyName("8")] public ParticipantFrameDto _8 { get; set; } = null!;

    [JsonPropertyName("9")] public ParticipantFrameDto _9 { get; set; } = null!;

    [JsonPropertyName("10")] public ParticipantFrameDto _10 { get; set; } = null!;
}

public class PositionDto
{
    [JsonPropertyName("x")] public int X { get; set; }

    [JsonPropertyName("y")] public int Y { get; set; }
}

public class VictimDamageDealtDto
{
    [JsonPropertyName("basic")] public bool Basic { get; set; }

    [JsonPropertyName("magicDamage")] public int MagicDamage { get; set; }

    [JsonPropertyName("name")] public string Name { get; set; } = null!;

    [JsonPropertyName("participantId")] public int ParticipantId { get; set; }

    [JsonPropertyName("physicalDamage")] public int PhysicalDamage { get; set; }

    [JsonPropertyName("spellName")] public string SpellName { get; set; } = null!;

    [JsonPropertyName("spellSlot")] public int SpellSlot { get; set; }

    [JsonPropertyName("trueDamage")] public int TrueDamage { get; set; }

    [JsonPropertyName("type")] public string Type { get; set; } = null!;
}

public class VictimDamageReceivedDto
{
    [JsonPropertyName("basic")] public bool Basic { get; set; }

    [JsonPropertyName("magicDamage")] public int MagicDamage { get; set; }

    [JsonPropertyName("name")] public string Name { get; set; } = null!;

    [JsonPropertyName("participantId")] public int ParticipantId { get; set; }

    [JsonPropertyName("physicalDamage")] public int PhysicalDamage { get; set; }

    [JsonPropertyName("spellName")] public string SpellName { get; set; } = null!;

    [JsonPropertyName("spellSlot")] public int SpellSlot { get; set; }

    [JsonPropertyName("trueDamage")] public int TrueDamage { get; set; }

    [JsonPropertyName("type")] public string Type { get; set; } = null!;
}