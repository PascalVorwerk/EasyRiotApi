using EasyRiotApi.Models;
using EasyRiotApi.Models.Common.Enums;
using EasyRiotApi.Models.Summoner;

namespace EasyRiotApi.Services.Interfaces;

public interface ISummonerService
{
    public Task<RiotApiResult<SummonerDto>> GetSummonerByRsoPuuidAsync(string rsoPuuid, LeagueOfLegendsPlatform platform);
    public Task<RiotApiResult<SummonerDto>> GetSummonerByAccountIdAsync(string accountId, LeagueOfLegendsPlatform platform);
    public Task<RiotApiResult<SummonerDto>> GetSummonerByPuuidAsync(string puuid, LeagueOfLegendsPlatform platform);
    public Task<RiotApiResult<SummonerDto>> GetOwnSummonerAsync(LeagueOfLegendsPlatform platform);
    public Task<RiotApiResult<SummonerDto>> GetBySummonerIdAsync(string summonerId, LeagueOfLegendsPlatform platform);
}