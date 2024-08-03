using EasyRiotApi.Models;
using EasyRiotApi.Models.Common.Enums;
using EasyRiotApi.Models.Summoner;
using EasyRiotApi.Services.Interfaces;
using Microsoft.Extensions.Logging;

namespace EasyRiotApi.Services;

internal class SummonerService(IHttpClientFactory factory, ILogger<SummonerService> logger): BaseService(factory, logger), ISummonerService
{
    public Task<RiotApiResult<SummonerDto>> GetSummonerByRsoPuuidAsync(string rsoPuuid, LeagueOfLegendsPlatform platform)
    {
        var url = $"https://{platform.ToString().ToLower()}.api.riotgames.com/fulfillment/v1/summoners/by-puuid/{rsoPuuid}";
        return GetAsync<SummonerDto>(url);
    }

    public Task<RiotApiResult<SummonerDto>> GetSummonerByAccountIdAsync(string accountId, LeagueOfLegendsPlatform platform)
    {
        var url = $"{GetSummonerBaseUrl(platform)}/by-account/{accountId}";
        return GetAsync<SummonerDto>(url);
    }

    public Task<RiotApiResult<SummonerDto>> GetSummonerByPuuidAsync(string puuid, LeagueOfLegendsPlatform platform)
    {
        var url = $"{GetSummonerBaseUrl(platform)}/by-puuid/{puuid}";
        return GetAsync<SummonerDto>(url);
    }

    public Task<RiotApiResult<SummonerDto>> GetOwnSummonerAsync(LeagueOfLegendsPlatform platform)
    {
        var url = $"{GetSummonerBaseUrl(platform)}/me";
        return GetAsync<SummonerDto>(url);
    }

    public Task<RiotApiResult<SummonerDto>> GetBySummonerIdAsync(string summonerId, LeagueOfLegendsPlatform platform)
    {
        var url = $"{GetSummonerBaseUrl(platform)}/{summonerId}";
        return GetAsync<SummonerDto>(url);
    }
    
    private string GetSummonerBaseUrl(LeagueOfLegendsPlatform platform)
    {
        return $"https://{platform.ToString().ToLower()}.api.riotgames.com/lol/summoner/v4/summoners";
    }
}