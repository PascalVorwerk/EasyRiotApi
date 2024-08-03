using System.Text.Json.Serialization;

namespace EasyRiotApi.Models.Common.League;

[JsonConverter(typeof(JsonStringEnumConverter<LolQueue>))]
public enum LolQueue
{
    RANKED_SOLO_5x5,
    RANKED_TFT,
    RANKED_FLEX_SR,
    RANKED_FLEX_TT
}