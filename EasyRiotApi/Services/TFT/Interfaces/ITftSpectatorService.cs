using EasyRiotApi.Models;
using EasyRiotApi.Models.Common.Enums;
using EasyRiotApi.Models.Common.Spectator;

namespace EasyRiotApi.Services.TFT.Interfaces;

public interface ITftSpectatorService
{
    public Task<RiotApiResult<CurrentGameInfo>> GetCurrentGameInfoByPuuidAsync(string puuid, LeagueOfLegendsPlatform platform);
    public Task<RiotApiResult<FeaturedGamesDto>> GetFeaturedGamesAsync(LeagueOfLegendsPlatform platform);
}