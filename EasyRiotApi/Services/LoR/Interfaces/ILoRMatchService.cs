using EasyRiotApi.Models;
using EasyRiotApi.Models.LoR.Enums;
using EasyRiotApi.Models.LoR.Match;

namespace EasyRiotApi.Services.LoR.Interfaces;

public interface ILoRMatchService
{
    public Task<RiotApiResult<List<string>>> GetMatchIdsByPuuidAsync(string puuid, LoRRegion region);
    public Task<RiotApiResult<LoRMatchDto>> GetMatchByIdAsync(string matchId, LoRRegion region);
}