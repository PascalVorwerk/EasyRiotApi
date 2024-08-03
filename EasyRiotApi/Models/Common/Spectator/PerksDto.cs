using System.Text.Json.Serialization;

namespace EasyRiotApi.Models.Common.Spectator;

public class PerksDto
{
    [JsonPropertyName("perkIds")]
    public List<long> PerkIds { get; set; } = null!;
    [JsonPropertyName("perkStyle")]
    public long PerkStyle { get; set; }
    [JsonPropertyName("perkSubStyle")]
    public long PerkSubStyle { get; set; }
}