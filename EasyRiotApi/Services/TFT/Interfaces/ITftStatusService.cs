using EasyRiotApi.Models;
using EasyRiotApi.Models.Common;
using EasyRiotApi.Models.Common.Enums;

namespace EasyRiotApi.Services.TFT.Interfaces;

public interface ITftStatusService
{
    public Task<RiotApiResult<PlatformDataDto>> GetPlatformDataAsync(LeagueOfLegendsPlatform platform);
}