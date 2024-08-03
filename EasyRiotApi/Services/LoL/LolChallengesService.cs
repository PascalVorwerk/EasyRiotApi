using EasyRiotApi.Models;
using EasyRiotApi.Models.Common.Enums;
using EasyRiotApi.Models.LoL.LeagueChallenges;
using EasyRiotApi.Services.LoL.Interfaces;
using Microsoft.Extensions.Logging;

namespace EasyRiotApi.Services.LoL;

internal class LolChallengesService(IHttpClientFactory factory, ILogger<LolChallengesService> logger): BaseService(factory, logger), ILolChallengesService
{
    public Task<RiotApiResult<List<ChallengeConfigInfoDto>>> GetChallengeConfigInfoAsync(LeagueOfLegendsPlatform platform)
    {
        var url = $"{GetBaseChallengesUrl(platform)}/challenges/config";
        return GetAsync<List<ChallengeConfigInfoDto>>(url);
    }

    public Task<RiotApiResult<Dictionary<long, Dictionary<int, Dictionary<string, double>>>>> GetChallengePercentilesAsync(LeagueOfLegendsPlatform platform)
    {
        var url = $"{GetBaseChallengesUrl(platform)}/challenges/percentiles";
        return GetAsync<Dictionary<long, Dictionary<int, Dictionary<string, double>>>>(url);
    }

    public Task<RiotApiResult<ChallengeConfigInfoDto>> GetChallengeConfigInfoByIdAsync(long challengeId, LeagueOfLegendsPlatform platform)
    {
        var url = $"{GetBaseChallengesUrl(platform)}/challenges/{challengeId}/config";
        return GetAsync<ChallengeConfigInfoDto>(url);
    }

    public Task<RiotApiResult<List<LoLPlayerInfoDto>>> GetApexPlayerInfoAsync(long challengeId, string level, LeagueOfLegendsPlatform platform)
    {
        var url = $"{GetBaseChallengesUrl(platform)}/challenges/{challengeId}/leaderboards/by-level/{level}";
        return GetAsync<List<LoLPlayerInfoDto>>(url);
    }

    public Task<RiotApiResult<Dictionary<string, double>>> GetChallengePercentilesByChallengeIdAsync(long challengeId, LeagueOfLegendsPlatform platform)
    {
        var url = $"{GetBaseChallengesUrl(platform)}/challenges/{challengeId}/percentiles";
        return GetAsync<Dictionary<string, double>>(url);
    }

    public Task<RiotApiResult<PlayerInfoDto>> GetPlayerInfoAsync(string puuid, LeagueOfLegendsPlatform platform)
    {
        var url = $"{GetBaseChallengesUrl(platform)}/player-data/{puuid}";
        return GetAsync<PlayerInfoDto>(url);
    }

    private string GetBaseChallengesUrl(LeagueOfLegendsPlatform platform)
    {
        return $"https://{platform.ToString().ToLower()}.api.riotgames.com/lol/challenges/v1";
    }
}