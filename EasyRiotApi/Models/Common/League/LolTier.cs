using System.Text.Json.Serialization;

namespace EasyRiotApi.Models.Common.League;

[JsonConverter(typeof(JsonStringEnumConverter<LolTier>))]
public enum LolTier
{
    IRON,
    BRONZE,
    SILVER,
    GOLD,
    PLATINUM,
    EMERALD,
    DIAMOND,
    MASTER,
    GRANDMASTER,
    CHALLENGER
}