using System.Text.Json.Serialization;

namespace EasyRiotApi.Models.Common.League;

public class TopRatedLadderEntryDto
{
    [JsonPropertyName("summonerId")]
    public string SummonerId { get; set; } = null!;
    [JsonPropertyName("ratedTier")]
    public string RatedTier { get; set; } = null!;
    [JsonPropertyName("ratedRating")]
    public int RatedRating { get; set; }
    [JsonPropertyName("wins")]
    public int Wins { get; set; }
    [JsonPropertyName("previousUpdateLadderPosition")]
    public int PreviousUpdateLadderPosition { get; set; }
}