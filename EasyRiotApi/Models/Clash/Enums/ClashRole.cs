using System.Text.Json.Serialization;

namespace EasyRiotApi.Models.Clash.Enums;

[JsonConverter(typeof(JsonStringEnumConverter<ClashRole>))]
public enum ClashRole
{
    Captain,
    Member
}