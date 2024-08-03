using EasyRiotApi.Models;
using EasyRiotApi.Models.Common.Enums;
using EasyRiotApi.Models.LoL.Match;

namespace EasyRiotApi.Services.LoL.Interfaces;

public interface ILolMatchService
{
    public Task<RiotApiResult<List<string>>> GetMatchIdsByPuuidAsync(string puuid, LeagueOfLegendsRegion region);
    public Task<RiotApiResult<MatchDto>> GetMatchByIdAsync(string matchId, LeagueOfLegendsRegion region);
    public Task<RiotApiResult<TimelineDto>> GetTimelineByMatchIdAsync(string matchId, LeagueOfLegendsRegion region);
}