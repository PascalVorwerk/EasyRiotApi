using System.Text.Json.Serialization;

namespace EasyRiotApi.Models.Common.League;

[JsonConverter(typeof(JsonStringEnumConverter<LolDivision>))]
public enum LolDivision
{
    I,
    II,
    III,
    IV
}