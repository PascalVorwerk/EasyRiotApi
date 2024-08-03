using EasyRiotApi.Models;
using EasyRiotApi.Models.Common;
using EasyRiotApi.Models.Common.Enums;

namespace EasyRiotApi.Services.TFT.Interfaces;

public interface ITftSummonerService
{
    public Task<RiotApiResult<SummonerDto>> GetSummonerByAccountIdAsync(string accountId, LeagueOfLegendsPlatform platform);
    public Task<RiotApiResult<SummonerDto>> GetSummonerByPuuidAsync(string puuid, LeagueOfLegendsPlatform platform);
    public Task<RiotApiResult<SummonerDto>> GetOwnSummonerAsync(LeagueOfLegendsPlatform platform);
    public Task<RiotApiResult<SummonerDto>> GetBySummonerIdAsync(string summonerId, LeagueOfLegendsPlatform platform);
}