using EasyRiotApi.Models;
using EasyRiotApi.Models.Common;
using EasyRiotApi.Models.Common.Enums;
using EasyRiotApi.Services.TFT.Interfaces;
using Microsoft.Extensions.Logging;

namespace EasyRiotApi.Services.TFT;

internal class TftSummonerService(IHttpClientFactory factory, ILogger<TftSummonerService> logger) : BaseService(factory, logger), ITftSummonerService
{
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
        return $"https://{platform.ToString().ToLower()}.api.riotgames.com/tft/summoner/v1/summoners";
    }
}