using System.Net;
using EasyRiotApi.Models.ChampionMastery;
using EasyRiotApi.Models.Common.Enums;
using EasyRiotApi.Services.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace EasyRiotApi.IntegrationTests.Tests;

public class ChampionMasteryIntegrationTests: TestBase
{
    private readonly IChampionMasteryService _championMasteryService;
    private const string Puuid = "JjKdGcffExfOCsfimlsP2QOnoXA-lZCJL9jM2KeLkmEw6UGxi1ZguLAEaCs_eOY3zJeyaZO1KmcMDQ";

    public ChampionMasteryIntegrationTests()
    {
        _championMasteryService = ServiceProvider.GetRequiredService<IChampionMasteryService>();
    }
    
    [Fact]
    public async Task GetChampionMasteryByChampionId_Success_ReturnChampionMasteryDto()
    {
        // Act
        var result = await _championMasteryService.GetChampionMasteryByChampionIdAsync(Puuid, 1, LeagueOfLegendsPlatform.Euw1);
        
        // Assert
        Assert.True(result.IsSuccess);
        Assert.NotNull(result.Data);
        var championMastery = Assert.IsType<ChampionMasteryDto>(result.Data);
        Assert.Equal(1, championMastery.ChampionId);
        var nextSeasonMilestone = Assert.IsType<NextSeasonMilestone>(championMastery.NextSeasonMilestone);
        var requireGradeCounts = Assert.IsType<RequireGradeCounts>(nextSeasonMilestone.RequireGradeCounts);
        var rewardConfig = Assert.IsType<RewardConfig>(nextSeasonMilestone.RewardConfig);
        
        Assert.NotNull(nextSeasonMilestone);
        Assert.NotNull(requireGradeCounts);
        Assert.NotNull(rewardConfig);
    }
    
    [Fact]
    public async Task GetChampionMasteryByChampionId_Fail_ReturnResultWithError()
    {
        // Act
        var result = await _championMasteryService.GetChampionMasteryByChampionIdAsync(Puuid, 0, LeagueOfLegendsPlatform.Euw1);
        
        // Assert
        Assert.False(result.IsSuccess);
        Assert.Equal(HttpStatusCode.NotFound, result.StatusCode);
        Assert.Null(result.Data);
        Assert.NotNull(result.ErrorMessage);
    }
    
    [Fact]
    public async Task GetChampionMasteries_Success_ReturnListOfChampionMasteryDto()
    {
        // Act
        var result = await _championMasteryService.GetChampionMasteriesAsync(Puuid, LeagueOfLegendsPlatform.Euw1);
        
        // Assert
        Assert.True(result.IsSuccess);
        Assert.NotNull(result.Data);
        var championMasteries = Assert.IsType<List<ChampionMasteryDto>>(result.Data);
        Assert.NotEmpty(championMasteries);
    }
    
    [Fact]
    public async Task GetChampionMasteries_Fail_ReturnResultWithError()
    {
        // Act
        var result = await _championMasteryService.GetChampionMasteriesAsync("", LeagueOfLegendsPlatform.Euw1);
        
        // Assert
        Assert.False(result.IsSuccess);
        Assert.Equal(HttpStatusCode.Forbidden, result.StatusCode);
        Assert.Null(result.Data);
        Assert.NotNull(result.ErrorMessage);
    }
    
    [Fact]
    public async Task GetTopChampionMasteries_Success_ReturnListOfChampionMasteryDto()
    {
        // Act
        var result = await _championMasteryService.GetTopChampionMasteriesAsync(Puuid, 3, LeagueOfLegendsPlatform.Euw1);
        
        // Assert
        Assert.True(result.IsSuccess);
        Assert.NotNull(result.Data);
        var championMasteries = Assert.IsType<List<ChampionMasteryDto>>(result.Data);
        Assert.NotEmpty(championMasteries);
        Assert.True(championMasteries.Count == 3);
    }
    
    [Fact]
    public async Task GetTopChampionMasteries_Fail_ReturnResultWithError()
    {
        // Act
        var result = await _championMasteryService.GetTopChampionMasteriesAsync("", 3, LeagueOfLegendsPlatform.Euw1);
        
        // Assert
        Assert.False(result.IsSuccess);
        Assert.Equal(HttpStatusCode.Forbidden, result.StatusCode);
        Assert.Null(result.Data);
        Assert.NotNull(result.ErrorMessage);
    }
    
    [Fact]
    public async Task GetTotalChampionMasteryScore_Success_ReturnInt()
    {
        // Act
        var result = await _championMasteryService.GetTotalChampionMasteryScoreAsync(Puuid, LeagueOfLegendsPlatform.Euw1);
        
        // Assert
        Assert.True(result.IsSuccess);
        var score = Assert.IsType<int>(result.Data);
        Assert.True(score > 0);
    }
    
    [Fact]
    public async Task GetTotalChampionMasteryScore_Fail_ReturnResultWithError()
    {
        // Act
        var result = await _championMasteryService.GetTotalChampionMasteryScoreAsync("", LeagueOfLegendsPlatform.Euw1);
        
        // Assert
        Assert.False(result.IsSuccess);
        Assert.Equal(HttpStatusCode.Forbidden, result.StatusCode);
        Assert.NotNull(result.ErrorMessage);
    }
}