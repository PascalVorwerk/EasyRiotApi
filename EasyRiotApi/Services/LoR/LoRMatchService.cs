using EasyRiotApi.Models;
using EasyRiotApi.Models.LoR.Enums;
using EasyRiotApi.Models.LoR.Match;
using EasyRiotApi.Services.LoR.Interfaces;
using Microsoft.Extensions.Logging;

namespace EasyRiotApi.Services.LoR;

internal class LoRMatchService(IHttpClientFactory factory, ILogger<LoRMatchService> logger) : BaseService(factory, logger), ILoRMatchService
{
    public Task<RiotApiResult<List<string>>> GetMatchIdsByPuuidAsync(string puuid, LoRRegion region)
    {
        var url = $"{GetLoRMatchBaseUrl(region)}/by-puuid/{puuid}/ids";
        return GetAsync<List<string>>(url);
    }

    public Task<RiotApiResult<LoRMatchDto>> GetMatchByIdAsync(string matchId, LoRRegion region)
    {
        var url = $"{GetLoRMatchBaseUrl(region)}/{matchId}";
        return GetAsync<LoRMatchDto>(url);
    }

    private string GetLoRMatchBaseUrl(LoRRegion region)
    {
        return $"https://{region.ToString()}.api.riotgames.com/lor/match/v1/matches";
    }
}