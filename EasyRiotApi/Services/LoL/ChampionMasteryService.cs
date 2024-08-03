using EasyRiotApi.Models;
using EasyRiotApi.Models.Common.Enums;
using EasyRiotApi.Models.LoL.ChampionMastery;
using EasyRiotApi.Services.LoL.Interfaces;
using Microsoft.Extensions.Logging;

namespace EasyRiotApi.Services.LoL;

internal class ChampionMasteryService(IHttpClientFactory factory, ILogger<ChampionMasteryService> logger): BaseService(factory, logger), IChampionMasteryService
{
    public Task<RiotApiResult<ChampionMasteryDto>> GetChampionMasteryByChampionIdAsync(string puuid, int championId, LeagueOfLegendsPlatform platform)
    {
        var url = $"{GetChampionMasteryBaseUrl(platform)}/champion-masteries/by-puuid/{puuid}/by-champion/{championId}";
        return GetAsync<ChampionMasteryDto>(url);
    }

    public Task<RiotApiResult<List<ChampionMasteryDto>>> GetChampionMasteriesAsync(string puuid, LeagueOfLegendsPlatform platform)
    {
        var url = $"{GetChampionMasteryBaseUrl(platform)}/champion-masteries/by-puuid/{puuid}";
        return GetAsync<List<ChampionMasteryDto>>(url);
    }

    public Task<RiotApiResult<List<ChampionMasteryDto>>> GetTopChampionMasteriesAsync(string puuid, int count, LeagueOfLegendsPlatform platform)
    {
        var url = $"{GetChampionMasteryBaseUrl(platform)}/champion-masteries/by-puuid/{puuid}/top?count={count}";
        return GetAsync<List<ChampionMasteryDto>>(url);
    }

    public Task<RiotApiResult<int>> GetTotalChampionMasteryScoreAsync(string puuid, LeagueOfLegendsPlatform platform)
    {
        var url = $"{GetChampionMasteryBaseUrl(platform)}/scores/by-puuid/{puuid}";
        return GetAsync<int>(url);
    }
    
    private string GetChampionMasteryBaseUrl(LeagueOfLegendsPlatform platform)
    {
        return $"https://{platform.ToString().ToLower()}.api.riotgames.com/lol/champion-mastery/v4";
    }
}