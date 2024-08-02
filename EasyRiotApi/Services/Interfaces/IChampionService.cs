using EasyRiotApi.Models;
using EasyRiotApi.Models.Enums;

namespace EasyRiotApi.Services.Interfaces;

public interface IChampionService
{
    public Task<RiotApiResult<ChampionInfoDto>> GetChampionByIdAsync(LeagueOfLegendsPlatform platform);
}