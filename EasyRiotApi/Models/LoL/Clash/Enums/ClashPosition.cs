using System.Text.Json.Serialization;

namespace EasyRiotApi.Models.LoL.Clash.Enums;

[JsonConverter(typeof(JsonStringEnumConverter<ClashPosition>))]
public enum ClashPosition
{
    Unselected,
    Top,
    Jungle,
    Middle,
    Bottom,
    Utility
}