using System.Text.Json.Serialization;

namespace EasyRiotApi.Models.LeagueExp.Enums;

[JsonConverter(typeof(JsonStringEnumConverter<Tier>))]
public enum Tier
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