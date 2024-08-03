using System.Text.Json.Serialization;

namespace EasyRiotApi.Models.LoL.ChampionMastery;

public class RequireGradeCounts
{
    [JsonPropertyName("B-")]
    public int B { get; set; }

    [JsonPropertyName("C-")]
    public int C { get; set; }
}