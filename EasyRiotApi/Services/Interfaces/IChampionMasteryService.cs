using EasyRiotApi.Models;
using EasyRiotApi.Models.Enums;

namespace EasyRiotApi.Services.Interfaces;

public interface IChampionMasteryService
{
    public Task<RiotApiResult<ChampionMasteryDto>> GetChampionMasteryByChampionId(string puuid, int championId, LeagueOfLegendsPlatform platform);
    public Task<RiotApiResult<List<ChampionMasteryDto>>> GetChampionMasteries(string puuid, LeagueOfLegendsPlatform platform);
    public Task<RiotApiResult<List<ChampionMasteryDto>>> GetTopChampionMasteries(string puuid, int count, LeagueOfLegendsPlatform platform);
    public Task<RiotApiResult<int>> GetTotalChampionMasteryScore(string puuid, LeagueOfLegendsPlatform platform);
}