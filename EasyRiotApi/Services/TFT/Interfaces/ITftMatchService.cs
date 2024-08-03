using EasyRiotApi.Models;
using EasyRiotApi.Models.Common.Enums;
using EasyRiotApi.Models.TFT.Match;

namespace EasyRiotApi.Services.TFT.Interfaces;

public interface ITftMatchService
{
    public Task<RiotApiResult<List<string>>> GetMatchIdsByPuuidAsync(string puuid, long? startTime, long? endTime,LeagueOfLegendsRegion region, int count = 20, int start = 0);
    public Task<RiotApiResult<MatchDto>> GetMatchByMatchIdAsync(string matchId, LeagueOfLegendsRegion region);
}