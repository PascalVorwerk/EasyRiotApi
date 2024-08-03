using EasyRiotApi.Models;
using EasyRiotApi.Models.ChampionMastery;
using EasyRiotApi.Models.Common.Enums;

namespace EasyRiotApi.Services.Interfaces;

public interface IChampionMasteryService
{
    public Task<RiotApiResult<ChampionMasteryDto>> GetChampionMasteryByChampionIdAsync(string puuid, int championId, LeagueOfLegendsPlatform platform);
    public Task<RiotApiResult<List<ChampionMasteryDto>>> GetChampionMasteriesAsync(string puuid, LeagueOfLegendsPlatform platform);
    public Task<RiotApiResult<List<ChampionMasteryDto>>> GetTopChampionMasteriesAsync(string puuid, int count, LeagueOfLegendsPlatform platform);
    public Task<RiotApiResult<int>> GetTotalChampionMasteryScoreAsync(string puuid, LeagueOfLegendsPlatform platform);
}