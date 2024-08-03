using System.Text.Json.Serialization;

namespace EasyRiotApi.Models.Common.Spectator;

public class FeaturedGamesDto
{
    public List<GameListDto> GameList { get; set; } = null!;
    public long ClientRefreshInterval { get; set; }
}

public class GameListDto
{
    [JsonPropertyName("gameId")]
    public long GameId { get; set; }

    [JsonPropertyName("mapId")]
    public int MapId { get; set; }

    [JsonPropertyName("gameMode")]
    public string GameMode { get; set; } = null!;

    [JsonPropertyName("gameType")]
    public string GameType { get; set; } = null!;

    [JsonPropertyName("gameQueueConfigId")]
    public int GameQueueConfigId { get; set; }

    [JsonPropertyName("participants")]
    public List<ParticipantDto> Participants { get; set; } = null!;

    [JsonPropertyName("observers")]
    public ObserverDto Observers { get; set; } = null!;

    [JsonPropertyName("platformId")]
    public string PlatformId { get; set; } = null!;

    [JsonPropertyName("bannedChampions")]
    public List<BannedChampionDto> BannedChampions { get; set; } = null!;

    [JsonPropertyName("gameLength")]
    public int GameLength { get; set; }
}

public class ParticipantDto
{
    [JsonPropertyName("puuid")]
    public string Puuid { get; set; } = null!;

    [JsonPropertyName("summonerId")]
    public string SummonerId { get; set; } = null!;

    [JsonPropertyName("teamId")]
    public int TeamId { get; set; }

    [JsonPropertyName("spell1Id")]
    public int Spell1Id { get; set; }

    [JsonPropertyName("spell2Id")]
    public int Spell2Id { get; set; }

    [JsonPropertyName("championId")]
    public int ChampionId { get; set; }

    [JsonPropertyName("profileIconId")]
    public int ProfileIconId { get; set; }

    [JsonPropertyName("riotId")]
    public string RiotId { get; set; } = null!;
}
