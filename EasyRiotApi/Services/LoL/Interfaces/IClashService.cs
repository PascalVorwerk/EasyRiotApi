using EasyRiotApi.Models;
using EasyRiotApi.Models.Common.Enums;
using EasyRiotApi.Models.LoL.Clash;

namespace EasyRiotApi.Services.LoL.Interfaces;

public interface IClashService
{
    public Task<RiotApiResult<List<PlayerDto>>> GetPlayersBySummonerIdAsync(string summonerId, LeagueOfLegendsPlatform platform);
    public Task<RiotApiResult<TeamDto>> GetTeamByIdAsync(string teamId, LeagueOfLegendsPlatform platform);
    public Task<RiotApiResult<List<TournamentDto>>> GetTournamentsAsync(LeagueOfLegendsPlatform platform);
    public Task<RiotApiResult<TournamentDto>> GetTournamentByTeamIdAsync(string teamId, LeagueOfLegendsPlatform platform);
    public Task<RiotApiResult<TournamentDto>> GetTournamentByTournamentIdAsync(int tournamentId, LeagueOfLegendsPlatform platform);
}