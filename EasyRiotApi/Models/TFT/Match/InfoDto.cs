using System.Text.Json.Serialization;

namespace EasyRiotApi.Models.TFT.Match;

public class InfoDto
{
    [JsonPropertyName("game_datetime")] public long GameDatetime { get; set; }
    [JsonPropertyName("game_length")] public float GameLength { get; set; }
    [JsonPropertyName("game_variation")] public string GameVariation { get; set; } = null!;
    [JsonPropertyName("game_version")] public string GameVersion { get; set; } = null!;
    [JsonPropertyName("participants")] public List<ParticipantDto> Participants { get; set; } = null!;
    [JsonPropertyName("queue_id")] public int QueueId { get; set; }
    [JsonPropertyName("tft_set_number")] public int TftSetNumber { get; set; }
}