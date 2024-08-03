using EasyRiotApi.Models;
using EasyRiotApi.Models.Common;
using EasyRiotApi.Models.Common.Enums;

namespace EasyRiotApi.Services.LoL.Interfaces;

public interface ILolStatusService
{
    public Task<RiotApiResult<PlatformDataDto>> GetPlatformDataAsync(LeagueOfLegendsPlatform platform);
}