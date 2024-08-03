using EasyRiotApi.Models;
using EasyRiotApi.Models.Common.Enums;
using EasyRiotApi.Models.LeagueExp;
using EasyRiotApi.Models.LeagueExp.Enums;
using EasyRiotApi.Services.Interfaces;
using Microsoft.Extensions.Logging;

namespace EasyRiotApi.Services;

internal class LeagueExpService(IHttpClientFactory clientFactory, ILogger<LeagueExpService> logger): BaseService(clientFactory, logger), ILeagueExpService
{
    public Task<RiotApiResult<List<LeagueEntryDto>>> GetLeagueEntriesAsync(Queue queue, Tier tier, Division division, int page, LeagueOfLegendsPlatform platform)
    {
        var url = $"{GetLeagueExpBaseUrl(platform)}/entries/{queue}/{tier}/{division}?page={page}";
        return GetAsync<List<LeagueEntryDto>>(url);
    }
    
    private string GetLeagueExpBaseUrl(LeagueOfLegendsPlatform platform)
    {
        return $"https://{platform.ToString().ToLower()}.api.riotgames.com/lol/league-exp/v4";
    }
}