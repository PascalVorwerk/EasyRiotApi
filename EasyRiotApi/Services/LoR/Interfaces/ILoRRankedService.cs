using EasyRiotApi.Models;
using EasyRiotApi.Models.LoR.Enums;
using EasyRiotApi.Models.LoR.Ranked;

namespace EasyRiotApi.Services.LoR.Interfaces;

public interface ILoRRankedService
{
    public Task<RiotApiResult<LeaderboardDto>> GetLeaderboardsAsync(LoRRegion region);
}