using System.Text.Json.Serialization;

namespace EasyRiotApi.Models.Common.Spectator;

public class BannedChampionDto
{
    [JsonPropertyName("championId")]
    public int ChampionId { get; set; }

    [JsonPropertyName("teamId")]
    public int TeamId { get; set; }

    [JsonPropertyName("pickTurn")]
    public int PickTurn { get; set; }
}