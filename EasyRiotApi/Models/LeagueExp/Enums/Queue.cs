using System.Text.Json.Serialization;

namespace EasyRiotApi.Models.LeagueExp.Enums;

[JsonConverter(typeof(JsonStringEnumConverter<Queue>))]
public enum Queue
{
    RANKED_SOLO_5x5,
    RANKED_TFT,
    RANKED_FLEX_SR,
    RANKED_FLEX_TT
}