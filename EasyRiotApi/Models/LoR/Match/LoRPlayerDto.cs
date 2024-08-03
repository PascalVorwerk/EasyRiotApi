using System.Text.Json.Serialization;

namespace EasyRiotApi.Models.LoR.Match;

public class LoRPlayerDto
{
    public string Puuid { get; set; } = null!;
    [JsonPropertyName("deck_id")]
    public string DeckId { get; set; } = null!;
    [JsonPropertyName("deck_code")]
    public string DeckCode { get; set; } = null!;
    public List<string> Factions { get; set; } = null!;
    [JsonPropertyName("game_outcome")]
    public string GameOutcome { get; set; } = null!;
    [JsonPropertyName("order_of_play")]
    public int OrderOfPlay { get; set; }
}