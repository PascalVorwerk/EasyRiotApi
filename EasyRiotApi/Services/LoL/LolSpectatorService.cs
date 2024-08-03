using EasyRiotApi.Models;
using EasyRiotApi.Models.Common.Enums;
using EasyRiotApi.Models.Common.Spectator;
using EasyRiotApi.Services.LoL.Interfaces;
using Microsoft.Extensions.Logging;

namespace EasyRiotApi.Services.LoL;

internal class LolSpectatorService(IHttpClientFactory factory, ILogger<LolSpectatorService> logger): BaseService(factory, logger), ILolSpectatorService
{
    public Task<RiotApiResult<CurrentGameInfo>> GetCurrentGameInfoByPuuidAsync(string puuid, LeagueOfLegendsPlatform platform)
    {
        var url = $"{GetLolSpectatorBaseUrl(platform)}/active-games/by-summoner/{puuid}";
        return GetAsync<CurrentGameInfo>(url);
    }

    public Task<RiotApiResult<FeaturedGamesDto>> GetFeaturedGamesAsync(LeagueOfLegendsPlatform platform)
    {
        var url = $"{GetLolSpectatorBaseUrl(platform)}/featured-games";
        return GetAsync<FeaturedGamesDto>(url);
    }
    
    public string GetLolSpectatorBaseUrl(LeagueOfLegendsPlatform platform)
    {
        return $"https://{platform.ToString().ToLower()}.api.riotgames.com/lol/spectator/v5";
    }
}