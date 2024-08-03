using EasyRiotApi.Models;
using EasyRiotApi.Models.Common;
using EasyRiotApi.Models.LoR.Enums;
using EasyRiotApi.Services.LoR.Interfaces;
using Microsoft.Extensions.Logging;

namespace EasyRiotApi.Services.LoR;

internal class LoRStatusService(IHttpClientFactory factory, ILogger<LoRStatusService> logger) : BaseService(factory, logger), ILoRStatusService
{
    public Task<RiotApiResult<PlatformDataDto>> GetPlatformDataAsync(LoRRegion region)
    {
        var url = $"https://{region.ToString().ToLower()}.api.riotgames.com/lor/status/v1/platform-data";
        return GetAsync<PlatformDataDto>(url);
    }
}