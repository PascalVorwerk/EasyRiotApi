using System.Text.Json.Serialization;

namespace EasyRiotApi.Models.Common.League;

[JsonConverter(typeof(JsonStringEnumConverter<TftTier>))]
public enum TftTier
{
    IRON,
    BRONZE,
    SILVER,
    GOLD,
    PLATINUM,
    DIAMOND
}