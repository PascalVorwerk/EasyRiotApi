using System.Text.Json.Serialization;

namespace EasyRiotApi.Models.TFT.Match;

public class MetadataDto
{
    [JsonPropertyName("data_version")] public string DataVersion { get; set; } = null!;
    [JsonPropertyName("match_id")] public string MatchId { get; set; } = null!;
    [JsonPropertyName("participants")] public List<string> Participants { get; set; } = null!;
}