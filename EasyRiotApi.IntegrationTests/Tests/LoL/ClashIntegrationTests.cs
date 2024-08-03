using EasyRiotApi.IntegrationTests.Fixtures;
using EasyRiotApi.Models.Common.Enums;
using EasyRiotApi.Models.LoL.Clash;
using EasyRiotApi.Services.LoL.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace EasyRiotApi.IntegrationTests.Tests.LoL;

public class ClashIntegrationTests: TestBase, IClassFixture<ClashIntegrationTestsFixture>
{
    private readonly IClashService _clashService;
    private ClashIntegrationTestsFixture Fixture { get; set; }
    
    public ClashIntegrationTests(ClashIntegrationTestsFixture fixture)
    {
        _clashService = ServiceProvider.GetRequiredService<IClashService>();
        Fixture = fixture;
    }
    
    [Fact]
    public async Task GetPlayersBySummonerId_Success_ReturnListPlayerDto()
    {
        // Act
        var result = await _clashService.GetPlayersBySummonerIdAsync(Fixture.SummonerId, LeagueOfLegendsPlatform.Euw1);
        
        // Assert
        Assert.True(result.IsSuccess);
        Assert.NotNull(result.Data);
        var players = Assert.IsType<List<PlayerDto>>(result.Data);
        if (players.Count != 0)
        {
            Assert.NotNull(players[0].SummonerId);
            Assert.NotNull(players[0].TeamId);
        }
    }
    
    
    [Fact]
    public async Task GetTournaments_Success_ReturnListTournamentDto()
    {
        // Act
        var result = await _clashService.GetTournamentsAsync(LeagueOfLegendsPlatform.Euw1);
        
        // Assert
        Assert.True(result.IsSuccess);
        Assert.NotNull(result.Data);
        var tournaments = Assert.IsType<List<TournamentDto>>(result.Data);
        if (tournaments.Count != 0)
        {
            Assert.NotNull(tournaments[0].NameKey);
        }
    }
}