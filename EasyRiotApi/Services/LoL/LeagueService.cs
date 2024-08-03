using EasyRiotApi.Models;
using EasyRiotApi.Models.Common.Enums;
using EasyRiotApi.Models.Common.League;
using EasyRiotApi.Services.LoL.Interfaces;
using Microsoft.Extensions.Logging;

namespace EasyRiotApi.Services.LoL;

internal class LeagueService(IHttpClientFactory factory, ILogger<LeagueService> logger): BaseService(factory, logger), ILeagueService
{
    public Task<RiotApiResult<LeagueListDto>> GetChallengerLeaguesAsync(LolQueue lolQueue, LeagueOfLegendsPlatform platform)
    {
        var url = $"{GetLeagueBaseUrl(platform)}/challengerleagues/by-queue/{lolQueue.ToString()}";
        return GetAsync<LeagueListDto>(url);
    }

    public Task<RiotApiResult<List<LeagueEntryDto>>> GetEntriesBySummonerIdAsync(string summonerId, LeagueOfLegendsPlatform platform)
    {
        var url = $"{GetLeagueBaseUrl(platform)}/entries/by-summoner/{summonerId}";
        return GetAsync<List<LeagueEntryDto>>(url);
    }

    public Task<RiotApiResult<List<LeagueEntryDto>>> GetEntriesAsync(LolQueue lolQueue, LolTier lolTier, LolDivision lolDivision, LeagueOfLegendsPlatform platform)
    {
        var url = $"{GetLeagueBaseUrl(platform)}/entries/{lolQueue.ToString()}/{lolTier.ToString()}/{lolDivision.ToString()}";
        return GetAsync<List<LeagueEntryDto>>(url);
    }

    public Task<RiotApiResult<LeagueListDto>> GetGrandmasterLeaguesAsync(LolQueue lolQueue, LeagueOfLegendsPlatform platform)
    {
        var url = $"{GetLeagueBaseUrl(platform)}/grandmasterleagues/by-queue/{lolQueue.ToString()}";
        return GetAsync<LeagueListDto>(url);
    }

    public Task<RiotApiResult<LeagueListDto>> GetLeaguesByLeagueIdAsync(string leagueId, LeagueOfLegendsPlatform platform)
    {
        var url = $"{GetLeagueBaseUrl(platform)}/leagues/{leagueId}";
        return GetAsync<LeagueListDto>(url);
    }

    public Task<RiotApiResult<LeagueListDto>> GetMasterLeaguesAsync(LolQueue lolQueue, LeagueOfLegendsPlatform platform)
    {
        var url = $"{GetLeagueBaseUrl(platform)}/masterleagues/by-queue/{lolQueue.ToString()}";
        return GetAsync<LeagueListDto>(url);
    }
    
    private string GetLeagueBaseUrl(LeagueOfLegendsPlatform platform)
    {
        return $"https://{platform.ToString().ToLower()}.api.riotgames.com/lol/league/v4";
    }
}