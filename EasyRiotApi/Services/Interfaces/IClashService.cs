using EasyRiotApi.Models;
using EasyRiotApi.Models.Clash;
using EasyRiotApi.Models.Common.Enums;

namespace EasyRiotApi.Services.Interfaces;

public interface IClashService
{
    public Task<RiotApiResult<List<PlayerDto>>> GetPlayersBySummonerIdAsync(string summonerId, LeagueOfLegendsPlatform platform);
    public Task<RiotApiResult<TeamDto>> GetTeamByIdAsync(string teamId, LeagueOfLegendsPlatform platform);
    public Task<RiotApiResult<List<TournamentDto>>> GetTournamentsAsync(LeagueOfLegendsPlatform platform);
    public Task<RiotApiResult<TournamentDto>> GetTournamentByTeamIdAsync(string teamId, LeagueOfLegendsPlatform platform);
    public Task<RiotApiResult<TournamentDto>> GetTournamentByTournamentIdAsync(int tournamentId, LeagueOfLegendsPlatform platform);
}