using EasyRiotApi.Models;
using EasyRiotApi.Models.Common.Enums;
using EasyRiotApi.Models.TFT.Match;
using EasyRiotApi.Services.TFT.Interfaces;
using Microsoft.Extensions.Logging;

namespace EasyRiotApi.Services.TFT;

internal class TftMatchService(IHttpClientFactory factory, ILogger<TftMatchService> logger): BaseService(factory, logger), ITftMatchService
{
    public Task<RiotApiResult<List<string>>> GetMatchIdsByPuuidAsync(string puuid, long? startTime, long? endTime, LeagueOfLegendsRegion region, int count = 20, int start = 0)
    {
        var url = $"{GetTftMatchBaseUrl(region)}/by-puuid/{puuid}/ids?count={count}&start={start}";
        if(startTime != null) url += $"&startTime={startTime}";
        if(endTime != null) url += $"&endTime={endTime}";
        return GetAsync<List<string>>(url);
    }

    public Task<RiotApiResult<MatchDto>> GetMatchByMatchIdAsync(string matchId, LeagueOfLegendsRegion region)
    {
        var url = $"{GetTftMatchBaseUrl(region)}/{matchId}";
        return GetAsync<MatchDto>(url);
    }
    
    private string GetTftMatchBaseUrl(LeagueOfLegendsRegion region)
    {
        return $"https://{region.ToString().ToLower()}.api.riotgames.com/tft/match/v1/matches";
    }
}