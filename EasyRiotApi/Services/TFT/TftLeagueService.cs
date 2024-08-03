using EasyRiotApi.Models;
using EasyRiotApi.Models.Common.Enums;
using EasyRiotApi.Models.Common.League;
using EasyRiotApi.Services.TFT.Interfaces;
using Microsoft.Extensions.Logging;

namespace EasyRiotApi.Services.TFT;

internal class TftLeagueService(IHttpClientFactory factory, ILogger<TftLeagueService> logger): BaseService(factory, logger), ITftLeagueService
{
    public Task<RiotApiResult<LeagueListDto>> GetChallengerLeagueAsync(LeagueOfLegendsPlatform platform)
    {
        var url = $"{GetTftLeagueBaseUrl(platform)}/challenger";
        return GetAsync<LeagueListDto>(url);
    }

    public Task<RiotApiResult<List<LeagueEntryDto>>> GetEntriesBySummonerIdAsync(string summonerId, LeagueOfLegendsPlatform platform)
    {
        var url = $"{GetTftLeagueBaseUrl(platform)}/entries/by-summoner/{summonerId}";
        return GetAsync<List<LeagueEntryDto>>(url);
    }

    public Task<RiotApiResult<List<LeagueEntryDto>>> GetEntriesAsync(TftTier tier, TftDivision division, LeagueOfLegendsPlatform platform,
        TftQueue queue = TftQueue.RANKED_TFT, int page = 1)
    {
        var url = $"{GetTftLeagueBaseUrl(platform)}/entries/{tier.ToString()}/{division.ToString()}?page={page}&queue={queue.ToString()}";
        return GetAsync<List<LeagueEntryDto>>(url);
    }


    public Task<RiotApiResult<LeagueListDto>> GetGrandmasterLeagueAsync(LeagueOfLegendsPlatform platform)
    {
        var url = $"{GetTftLeagueBaseUrl(platform)}/grandmaster";
        return GetAsync<LeagueListDto>(url);
    }

    public Task<RiotApiResult<LeagueListDto>> GetLeaguesByLeagueIdAsync(string leagueId, LeagueOfLegendsPlatform platform)
    {
        var url = $"{GetTftLeagueBaseUrl(platform)}/leagues/{leagueId}";
        return GetAsync<LeagueListDto>(url);
    }

    public Task<RiotApiResult<LeagueListDto>> GetMasterLeagueAsync(LeagueOfLegendsPlatform platform)
    {
        var url = $"{GetTftLeagueBaseUrl(platform)}/master";
        return GetAsync<LeagueListDto>(url);
    }

    public Task<RiotApiResult<List<TopRatedLadderEntryDto>>> GetTopRatedLadderEntriesAsync(TftQueue queue, LeagueOfLegendsPlatform platform)
    {
        var url = $"{GetTftLeagueBaseUrl(platform)}/rated-ladders/{queue.ToString()}/top";
        return GetAsync<List<TopRatedLadderEntryDto>>(url);
    }
    
    private string GetTftLeagueBaseUrl(LeagueOfLegendsPlatform platform)
    {
        return $"https://{platform.ToString().ToLower()}.api.riotgames.com/tft/league/v1";
    }
}