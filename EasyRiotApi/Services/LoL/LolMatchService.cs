using EasyRiotApi.Models;
using EasyRiotApi.Models.Common.Enums;
using EasyRiotApi.Models.LoL.Match;
using EasyRiotApi.Services.LoL.Interfaces;
using Microsoft.Extensions.Logging;

namespace EasyRiotApi.Services.LoL;

internal class LolMatchService(IHttpClientFactory factory, ILogger<LolMatchService> logger): BaseService(factory, logger), ILolMatchService
{
    public Task<RiotApiResult<List<string>>> GetMatchIdsByPuuidAsync(string puuid, LeagueOfLegendsRegion region)
    {
        var url = $"{GetMatchBaseUrl(region)}/by-puuid/{puuid}/ids";
        return GetAsync<List<string>>(url);
    }

    public Task<RiotApiResult<MatchDto>> GetMatchByIdAsync(string matchId, LeagueOfLegendsRegion region)
    {
        var url = $"{GetMatchBaseUrl(region)}/{matchId}";
        return GetAsync<MatchDto>(url);
    }

    public Task<RiotApiResult<TimelineDto>> GetTimelineByMatchIdAsync(string matchId, LeagueOfLegendsRegion region)
    {
        var url = $"{GetMatchBaseUrl(region)}/{matchId}/timeline";
        return GetAsync<TimelineDto>(url);
    }
    
    private string GetMatchBaseUrl(LeagueOfLegendsRegion region)
    {
        return $"https://{region.ToString().ToLower()}.api.riotgames.com/lol/match/v5/matches";
    }
}