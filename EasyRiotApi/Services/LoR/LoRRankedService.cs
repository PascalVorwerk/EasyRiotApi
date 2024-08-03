using EasyRiotApi.Models;
using EasyRiotApi.Models.LoR.Enums;
using EasyRiotApi.Models.LoR.Ranked;
using EasyRiotApi.Services.LoR.Interfaces;
using Microsoft.Extensions.Logging;

namespace EasyRiotApi.Services.LoR;

internal class LoRRankedService(IHttpClientFactory factory, ILogger<LoRRankedService> logger) : BaseService(factory, logger), ILoRRankedService
{
    public Task<RiotApiResult<LeaderboardDto>> GetLeaderboardsAsync(LoRRegion region)
    {
        var url = $"https://{region.ToString()}.api.riotgames.com/lor/ranked/v1/leaderboards";
        return GetAsync<LeaderboardDto>(url);
    }
}