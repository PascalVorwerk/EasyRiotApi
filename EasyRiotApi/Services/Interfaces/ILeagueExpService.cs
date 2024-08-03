using EasyRiotApi.Models;
using EasyRiotApi.Models.Common.Enums;
using EasyRiotApi.Models.LeagueExp;
using EasyRiotApi.Models.LeagueExp.Enums;

namespace EasyRiotApi.Services.Interfaces;

public interface ILeagueExpService
{
    public Task<RiotApiResult<List<LeagueEntryDto>>> GetLeagueEntriesAsync(Queue queue, Tier tier, Division division, int page,
        LeagueOfLegendsPlatform platform);
}