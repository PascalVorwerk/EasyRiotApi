using System.Text.Json.Serialization;

namespace EasyRiotApi.Models.Common.League;

[JsonConverter(typeof(JsonStringEnumConverter<TftDivision>))]
public enum TftDivision
{
    I,
    II,
    III,
    IV
}