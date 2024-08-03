using EasyRiotApi.Models;
using EasyRiotApi.Models.Clash;
using EasyRiotApi.Models.Common.Enums;
using EasyRiotApi.Services.Interfaces;
using Microsoft.Extensions.Logging;

namespace EasyRiotApi.Services;

internal class ClashService(IHttpClientFactory factory, ILogger<ClashService> logger): BaseService(factory, logger), IClashService
{
    public Task<RiotApiResult<List<PlayerDto>>> GetPlayersBySummonerIdAsync(string summonerId, LeagueOfLegendsPlatform platform)
    {
        var url = $"{GetClashBaseUrl(platform)}/players/by-summoner/{summonerId}";
        return GetAsync<List<PlayerDto>>(url);
    }

    public Task<RiotApiResult<TeamDto>> GetTeamByIdAsync(string teamId, LeagueOfLegendsPlatform platform)
    {
        var url = $"{GetClashBaseUrl(platform)}/teams/{teamId}";
        return GetAsync<TeamDto>(url);
    }

    public Task<RiotApiResult<List<TournamentDto>>> GetTournamentsAsync(LeagueOfLegendsPlatform platform)
    {
        var url = $"{GetClashBaseUrl(platform)}/tournaments";
        return GetAsync<List<TournamentDto>>(url);
    }

    public Task<RiotApiResult<TournamentDto>> GetTournamentByTeamIdAsync(string teamId, LeagueOfLegendsPlatform platform)
    {
        var url = $"{GetClashBaseUrl(platform)}/tournaments/by-team/{teamId}";
        return GetAsync<TournamentDto>(url);
    }

    public Task<RiotApiResult<TournamentDto>> GetTournamentByTournamentIdAsync(int tournamentId, LeagueOfLegendsPlatform platform)
    {
        var url = $"{GetClashBaseUrl(platform)}/tournaments/{tournamentId}";
        return GetAsync<TournamentDto>(url);
    }

    private string GetClashBaseUrl(LeagueOfLegendsPlatform platform)
    {
        return $"https://{platform.ToString().ToLower()}.api.riotgames.com/lol/clash/v1";
    }
}