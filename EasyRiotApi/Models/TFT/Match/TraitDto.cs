using System.Text.Json.Serialization;

namespace EasyRiotApi.Models.TFT.Match;

public class TraitDto
{
    [JsonPropertyName("name")] public string Name { get; set; } = null!;
    [JsonPropertyName("num_units")] public int NumUnits { get; set; }
    [JsonPropertyName("style")] public int Style { get; set; }
    [JsonPropertyName("tier_current")] public int TierCurrent { get; set; }
    [JsonPropertyName("tier_total")] public int TierTotal { get; set; }
}