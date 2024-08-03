using EasyRiotApi.Models;
using EasyRiotApi.Models.Common;
using EasyRiotApi.Models.LoR.Enums;

namespace EasyRiotApi.Services.LoR.Interfaces;

public interface ILoRStatusService
{
    public Task<RiotApiResult<PlatformDataDto>> GetPlatformDataAsync(LoRRegion region);
}