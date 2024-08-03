using System.Text.Json.Serialization;

namespace EasyRiotApi.Models.LoR.Match;

public class LoRMetadataDto
{
    [JsonPropertyName("data_version")]
    public string DataVersion { get; set; } = null!;
    [JsonPropertyName("match_id")]
    public string MatchId { get; set; } = null!;
    public List<string> Participants { get; set; } = null!;
}