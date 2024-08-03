using EasyRiotApi.Models;
using EasyRiotApi.Models.Common.Enums;
using EasyRiotApi.Models.LoL.LeagueChallenges;

namespace EasyRiotApi.Services.LoL.Interfaces;

public interface ILolChallengesService
{
    public Task<RiotApiResult<List<ChallengeConfigInfoDto>>> GetChallengeConfigInfoAsync(LeagueOfLegendsPlatform platform);
    public Task<RiotApiResult<Dictionary<long, Dictionary<int, Dictionary<string, double>>>>> GetChallengePercentilesAsync(LeagueOfLegendsPlatform platform);
    public Task<RiotApiResult<ChallengeConfigInfoDto>> GetChallengeConfigInfoByIdAsync(long challengeId, LeagueOfLegendsPlatform platform);
    public Task<RiotApiResult<List<LoLPlayerInfoDto>>> GetApexPlayerInfoAsync(long challengeId, string level, LeagueOfLegendsPlatform platform);
    public Task<RiotApiResult<Dictionary<string, double>>> GetChallengePercentilesByChallengeIdAsync(long challengeId, LeagueOfLegendsPlatform platform);
    public Task<RiotApiResult<PlayerInfoDto>> GetPlayerInfoAsync(string puuid, LeagueOfLegendsPlatform platform);
}