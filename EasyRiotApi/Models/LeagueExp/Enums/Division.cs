using System.Text.Json.Serialization;

namespace EasyRiotApi.Models.LeagueExp.Enums;

[JsonConverter(typeof(JsonStringEnumConverter<Division>))]
public enum Division
{
    I,
    II,
    III,
    IV
}