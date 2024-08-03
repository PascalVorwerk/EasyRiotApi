using EasyRiotApi.Models;
using EasyRiotApi.Models.Common.Enums;
using EasyRiotApi.Models.LoL.Champion;

namespace EasyRiotApi.Services.LoL.Interfaces;

public interface IChampionService
{
    public Task<RiotApiResult<ChampionInfoDto>> GetChampionRotationsAsync(LeagueOfLegendsPlatform platform);
}