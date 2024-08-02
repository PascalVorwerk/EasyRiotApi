using EasyRiotApi.Models;
using EasyRiotApi.Models.Enums;
using EasyRiotApi.Services.Interfaces;
using Microsoft.Extensions.Logging;

namespace EasyRiotApi.Services;

internal class ChampionService(IHttpClientFactory factory, ILogger<ChampionService> logger): BaseService(factory, logger), IChampionService
{
    public Task<RiotApiResult<ChampionInfoDto>> GetChampionByIdAsync(LeagueOfLegendsPlatform platform)
    {
        var url = GetChampionBaseUrl(platform);
        return GetAsync<ChampionInfoDto>(url);
    }
    
    private string GetChampionBaseUrl(LeagueOfLegendsPlatform platform)
    {
        return $"https://{platform.ToString().ToLower()}.api.riotgames.com/lol/platform/v3/champion-rotations";
    }
}