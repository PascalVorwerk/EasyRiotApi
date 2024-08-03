using EasyRiotApi.Models.Clash.Enums;

namespace EasyRiotApi.Models.Clash;

public class PlayerDto
{
    public string SummonerId { get; set; } = null!;
    public string TeamId { get; set; } = null!;
    public ClashPosition Position { get; set; }
    public ClashRole Role { get; set; }
}