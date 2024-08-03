using System.Text.Json.Serialization;

namespace EasyRiotApi.Models.LoL.Clash.Enums;

[JsonConverter(typeof(JsonStringEnumConverter<ClashRole>))]
public enum ClashRole
{
    Captain,
    Member
}