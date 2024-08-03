using EasyRiotApi.Models;
using EasyRiotApi.Models.Common.Enums;
using EasyRiotApi.Models.Common.Spectator;

namespace EasyRiotApi.Services.LoL.Interfaces;

public interface ILolSpectatorService
{
    public Task<RiotApiResult<CurrentGameInfo>> GetCurrentGameInfoByPuuidAsync(string puuid, LeagueOfLegendsPlatform platform);
    public Task<RiotApiResult<FeaturedGamesDto>> GetFeaturedGamesAsync(LeagueOfLegendsPlatform platform);
}