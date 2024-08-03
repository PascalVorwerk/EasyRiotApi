using EasyRiotApi.Models;
using EasyRiotApi.Models.Common.Enums;
using EasyRiotApi.Models.Common.League;

namespace EasyRiotApi.Services.LoL.Interfaces;

public interface ILeagueService
{
    public Task<RiotApiResult<LeagueListDto>> GetChallengerLeaguesAsync(LolQueue lolQueue, LeagueOfLegendsPlatform platform);
    public Task<RiotApiResult<List<LeagueEntryDto>>> GetEntriesBySummonerIdAsync(string summonerId, LeagueOfLegendsPlatform platform);
    public Task<RiotApiResult<List<LeagueEntryDto>>> GetEntriesAsync(LolQueue lolQueue, LolTier lolTier, LolDivision lolDivision, LeagueOfLegendsPlatform platform);
    public Task<RiotApiResult<LeagueListDto>> GetGrandmasterLeaguesAsync(LolQueue lolQueue, LeagueOfLegendsPlatform platform);
    public Task<RiotApiResult<LeagueListDto>> GetLeaguesByLeagueIdAsync(string leagueId, LeagueOfLegendsPlatform platform);
    public Task<RiotApiResult<LeagueListDto>> GetMasterLeaguesAsync(LolQueue lolQueue, LeagueOfLegendsPlatform platform);
}