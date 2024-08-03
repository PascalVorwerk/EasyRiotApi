using EasyRiotApi.Models;
using EasyRiotApi.Models.Common.Enums;
using EasyRiotApi.Models.Common.League;

namespace EasyRiotApi.Services.LoL.Interfaces;

public interface ILeagueExpService
{
    public Task<RiotApiResult<List<LeagueEntryDto>>> GetLeagueEntriesAsync(LolQueue lolQueue, LolTier lolTier, LolDivision lolDivision, int page,
        LeagueOfLegendsPlatform platform);
}