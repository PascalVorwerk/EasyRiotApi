using EasyRiotApi.Models;
using EasyRiotApi.Models.Common.Enums;
using EasyRiotApi.Models.Common.League;

namespace EasyRiotApi.Services.TFT.Interfaces;

public interface ITftLeagueService
{
    public Task<RiotApiResult<LeagueListDto>> GetChallengerLeagueAsync(LeagueOfLegendsPlatform platform);
    public Task<RiotApiResult<List<LeagueEntryDto>>> GetEntriesBySummonerIdAsync(string summonerId, LeagueOfLegendsPlatform platform);
    public Task<RiotApiResult<List<LeagueEntryDto>>> GetEntriesAsync(TftTier tier, TftDivision division, LeagueOfLegendsPlatform platform, TftQueue queue = TftQueue.RANKED_TFT, int page = 1);
    public Task<RiotApiResult<LeagueListDto>> GetGrandmasterLeagueAsync(LeagueOfLegendsPlatform platform);
    public Task<RiotApiResult<LeagueListDto>> GetLeaguesByLeagueIdAsync(string leagueId, LeagueOfLegendsPlatform platform);
    public Task<RiotApiResult<LeagueListDto>> GetMasterLeagueAsync(LeagueOfLegendsPlatform platform);
    public Task<RiotApiResult<List<TopRatedLadderEntryDto>>> GetTopRatedLadderEntriesAsync(TftQueue queue, LeagueOfLegendsPlatform platform);
}