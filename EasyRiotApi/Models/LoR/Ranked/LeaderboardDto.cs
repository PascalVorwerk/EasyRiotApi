using EasyRiotApi.Models.LoR.Match;

namespace EasyRiotApi.Models.LoR.Ranked;

public class LeaderboardDto
{
    public List<LoRPlayerDto> Players { get; set; } = null!;
}