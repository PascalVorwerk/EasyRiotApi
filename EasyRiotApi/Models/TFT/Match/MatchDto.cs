using System.Text.Json.Serialization;

namespace EasyRiotApi.Models.TFT.Match;

public class MatchDto
{
    [JsonPropertyName("metadata")] public MetadataDto Metadata { get; set; } = null!;
    [JsonPropertyName("info")] public InfoDto Info { get; set; } = null!;
}