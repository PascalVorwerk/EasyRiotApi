using EasyRiotApi.Models;
using EasyRiotApi.Models.Common;
using EasyRiotApi.Models.Common.Enums;
using EasyRiotApi.Services.LoL.Interfaces;
using Microsoft.Extensions.Logging;

namespace EasyRiotApi.Services.LoL;

internal class LolStatusService(IHttpClientFactory factory, ILogger<LolStatusService> logger): BaseService(factory, logger), ILolStatusService
{
    public Task<RiotApiResult<PlatformDataDto>> GetPlatformDataAsync(LeagueOfLegendsPlatform platform)
    {
        var url = $"https://{platform.ToString().ToLower()}.api.riotgames.com/lol/status/v4/platform-data";
        return GetAsync<PlatformDataDto>(url);
    }
}