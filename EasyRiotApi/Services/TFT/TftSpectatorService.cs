using EasyRiotApi.Models;
using EasyRiotApi.Models.Common.Enums;
using EasyRiotApi.Models.Common.Spectator;
using EasyRiotApi.Services.TFT.Interfaces;
using Microsoft.Extensions.Logging;

namespace EasyRiotApi.Services.TFT;

internal class TftSpectatorService(IHttpClientFactory factory, ILogger<TftSpectatorService> logger): BaseService(factory, logger), ITftSpectatorService
{
    public Task<RiotApiResult<CurrentGameInfo>> GetCurrentGameInfoByPuuidAsync(string puuid, LeagueOfLegendsPlatform platform)
    {
        var url = $"{GetTftSpectatorBaseUrl(platform)}/active-games/by-puuid/{puuid}";
        return GetAsync<CurrentGameInfo>(url);
    }

    public Task<RiotApiResult<FeaturedGamesDto>> GetFeaturedGamesAsync(LeagueOfLegendsPlatform platform)
    {
        var url = $"{GetTftSpectatorBaseUrl(platform)}/featured-games";
        return GetAsync<FeaturedGamesDto>(url);
    }
    
    private string GetTftSpectatorBaseUrl(LeagueOfLegendsPlatform platform)
    {
        return $"https://{platform.ToString().ToLower()}.api.riotgames.com/lol/spectator/tft/v5";
    }
}