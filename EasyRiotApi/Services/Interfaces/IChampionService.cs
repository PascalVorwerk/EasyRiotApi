using EasyRiotApi.Models;
using EasyRiotApi.Models.ChampionMastery;
using EasyRiotApi.Models.Common.Enums;

namespace EasyRiotApi.Services.Interfaces;

public interface IChampionService
{
    public Task<RiotApiResult<ChampionInfoDto>> GetChampionRotationsAsync(LeagueOfLegendsPlatform platform);
}