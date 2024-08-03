using EasyRiotApi.Models;
using EasyRiotApi.Models.Common.Enums;
using EasyRiotApi.Models.Common.League;
using EasyRiotApi.Services.LoL.Interfaces;
using Microsoft.Extensions.Logging;

namespace EasyRiotApi.Services.LoL;

internal class LeagueExpService(IHttpClientFactory clientFactory, ILogger<LeagueExpService> logger): BaseService(clientFactory, logger), ILeagueExpService
{
    public Task<RiotApiResult<List<LeagueEntryDto>>> GetLeagueEntriesAsync(LolQueue lolQueue, LolTier lolTier, LolDivision lolDivision, int page, LeagueOfLegendsPlatform platform)
    {
        var url = $"{GetLeagueExpBaseUrl(platform)}/entries/{lolQueue.ToString()}/{lolTier.ToString()}/{lolDivision.ToString()}?page={page}";
        return GetAsync<List<LeagueEntryDto>>(url);
    }
    
    private string GetLeagueExpBaseUrl(LeagueOfLegendsPlatform platform)
    {
        return $"https://{platform.ToString().ToLower()}.api.riotgames.com/lol/league-exp/v4";
    }
}