using System.Text.Json.Serialization;

namespace EasyRiotApi.Models.TFT.Match;

public class UnitDto
{
    [JsonPropertyName("items")] public List<int> Items { get; set; } = null!;
    [JsonPropertyName("character_id")] public string CharacterId { get; set; } = null!;
    [JsonPropertyName("name")] public string Name { get; set; } = null!;
    [JsonPropertyName("rarity")] public int Rarity { get; set; }
    [JsonPropertyName("tier")] public int Tier { get; set; }
    [JsonPropertyName("chosen")] public string? Chosen { get; set; }
}