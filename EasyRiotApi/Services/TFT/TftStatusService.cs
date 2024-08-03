using EasyRiotApi.Models;
using EasyRiotApi.Models.Common;
using EasyRiotApi.Models.Common.Enums;
using EasyRiotApi.Services.TFT.Interfaces;
using Microsoft.Extensions.Logging;

namespace EasyRiotApi.Services.TFT;

internal class TftStatusService(IHttpClientFactory factory, ILogger<TftStatusService> logger) : BaseService(factory, logger), ITftStatusService
{
    public Task<RiotApiResult<PlatformDataDto>> GetPlatformDataAsync(LeagueOfLegendsPlatform platform)
    {
        var url = $"https://{platform.ToString().ToLower()}.api.riotgames.com/tft/status/v1/platform-data";
        return GetAsync<PlatformDataDto>(url);
    }
}