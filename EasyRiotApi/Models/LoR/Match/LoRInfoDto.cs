using System.Text.Json.Serialization;

namespace EasyRiotApi.Models.LoR.Match;

public class LoRInfoDto
{
    [JsonPropertyName("game_mode")]
    public string GameMode { get; set; } = null!;
    [JsonPropertyName("game_type")]
    public string GameType { get; set; } = null!;
    [JsonPropertyName("game_start_time_utc")]
    public string GameStartTimeUtc { get; set; } = null!;
    [JsonPropertyName("game_version")]
    public string GameVersion { get; set; } = null!;
    [JsonPropertyName("game_format")]
    public string GameFormat { get; set; } = null!;
    public List<LoRPlayerDto> Players { get; set; } = null!;
    public int TotalTurnCount { get; set; }
}