using EasyRiotApi.Models.Common.Enums;
using EasyRiotApi.Models.Common.League;
using EasyRiotApi.Services.LoL.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace EasyRiotApi.IntegrationTests.Tests.LoL;

public class LeagueExpIntegrationTests: TestBase
{
    private readonly ILeagueExpService _leagueExpService;
    
    public LeagueExpIntegrationTests()
    {
        _leagueExpService = ServiceProvider.GetRequiredService<ILeagueExpService>();
    }
    
    [Fact]
    public async Task GetLeagueEntries_Success_ReturnListOfLeagueEntryDto()
    {
        // Act
        var result = await _leagueExpService.GetLeagueEntriesAsync(LolQueue.RANKED_SOLO_5x5, LolTier.SILVER, LolDivision.II, 1, LeagueOfLegendsPlatform.Euw1);
        
        // Assert
        Assert.True(result.IsSuccess);
        Assert.NotNull(result.Data);
        var leagueEntries = Assert.IsType<List<LeagueEntryDto>>(result.Data);
        Assert.NotEmpty(leagueEntries);
    }
    
    [Fact]
    public async Task GetLeagueEntries_Fail_ReturnResultWithError()
    {
        // Act
        var result = await _leagueExpService.GetLeagueEntriesAsync(LolQueue.RANKED_SOLO_5x5, LolTier.GRANDMASTER, LolDivision.II, 1, LeagueOfLegendsPlatform.Euw1);
        
        // Assert
        Assert.False(result.IsSuccess);
        Assert.Null(result.Data);
        Assert.NotNull(result.ErrorMessage);
    }
}