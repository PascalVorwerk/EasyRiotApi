using System.Text.Json.Serialization;

namespace EasyRiotApi.Models.LoR.Ranked;

public class RankedPlayerDto
{
    public string Name { get; set; } = null!;
    public int Rank { get; set; }
    [JsonPropertyName("lp")]
    public int LeaguePoints { get; set; }
}