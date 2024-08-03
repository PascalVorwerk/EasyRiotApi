using EasyRiotApi.Models.ChampionMastery;
using EasyRiotApi.Models.Common.Enums;
using EasyRiotApi.Services.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace EasyRiotApi.IntegrationTests.Tests;

public class ChampionIntegrationTests: TestBase
{
    private readonly IChampionService _championService;
    
    public ChampionIntegrationTests()
    {
        _championService = ServiceProvider.GetRequiredService<IChampionService>();
    }
    
    [Fact]
    public async Task GetChampionRotations_Success_ReturnChampionInfoDto()
    {
        // Act
        var result = await _championService.GetChampionRotationsAsync(LeagueOfLegendsPlatform.Euw1);
        
        // Assert
        Assert.True(result.IsSuccess);
        Assert.NotNull(result.Data);
        var championInfo = Assert.IsType<ChampionInfoDto>(result.Data);
        Assert.NotEmpty(championInfo.FreeChampionIds);
        Assert.NotEmpty(championInfo.FreeChampionIdsForNewPlayers);
        Assert.True(championInfo.MaxNewPlayerLevel > 0);
    }
}