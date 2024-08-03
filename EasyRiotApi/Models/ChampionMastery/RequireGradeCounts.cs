using System.Text.Json.Serialization;

namespace EasyRiotApi.Models.ChampionMastery;

public class RequireGradeCounts
{
    [JsonPropertyName("B-")]
    public int B { get; set; }

    [JsonPropertyName("C-")]
    public int C { get; set; }
}