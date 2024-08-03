using System.Text.Json.Serialization;

namespace EasyRiotApi.Models.Common.Spectator;

public class CurrentGameInfo
{
    [JsonPropertyName("gameId")]
    public long GameId { get; set; }
    [JsonPropertyName("gameType")]
    public string GameType { get; set; } = null!;
    [JsonPropertyName("gameStartTime")]
    public long GameStartTime { get; set; }
    [JsonPropertyName("mapId")]
    public long MapId { get; set; }
    [JsonPropertyName("gameLength")]
    public long GameLength { get; set; }
    [JsonPropertyName("gameMode")]
    public string GameMode { get; set; } = null!;
    [JsonPropertyName("bannedChampions")]
    public List<BannedChampionDto> BannedChampions { get; set; } = null!;
    [JsonPropertyName("gameQueueConfigId")]
    public long GameQueueConfigId { get; set; }
    [JsonPropertyName("observers")]
    public ObserverDto Observers { get; set; } = null!;
    [JsonPropertyName("participants")]
    public List<CurrentGameParticipantDto> Participants { get; set; } = null!;
}

public class CurrentGameParticipantDto
{
    [JsonPropertyName("championId")]
    public long ChampionId { get; set; }
    [JsonPropertyName("perks")]
    public PerksDto Perks { get; set; } = null!;
    [JsonPropertyName("profileIconId")]
    public long ProfileIconId { get; set; }
    [JsonPropertyName("teamId")]
    public long TeamId { get; set; }
    [JsonPropertyName("summonerId")]
    public string SummonerId { get; set; } = null!;
    [JsonPropertyName("puuid")]
    public string Puuid { get; set; } = null!;
    [JsonPropertyName("spell1Id")]
    public long Spell1Id { get; set; }
    [JsonPropertyName("spell2Id")]
    public long Spell2Id { get; set; }
    [JsonPropertyName("gameCustomizationObjects")]
    public List<GameCustomizationObjectDto> GameCustomizationObjects { get; set; } = null!;
}

public class GameCustomizationObjectDto
{
    [JsonPropertyName("category")]
    public string Category { get; set; } = null!;
    [JsonPropertyName("content")]
    public string Content { get; set; } = null!;
}