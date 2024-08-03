using EasyRiotApi.IntegrationTests.Fixtures;
using EasyRiotApi.Models.Common;
using EasyRiotApi.Models.Common.Enums;
using EasyRiotApi.Services.LoL.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace EasyRiotApi.IntegrationTests.Tests.LoL;

public class SummonerIntegrationTests: TestBase, IClassFixture<SummonerIntegrationTestsFixture>
{
    private readonly ISummonerService _summonerService;
    private SummonerIntegrationTestsFixture Fixture { get; set; }
    
    public SummonerIntegrationTests(SummonerIntegrationTestsFixture fixture)
    {
        Fixture = fixture;
        _summonerService = ServiceProvider.GetRequiredService<ISummonerService>();
    }
    
    [Fact]
    public async Task GetSummonerByPuuid_ShouldReturnSummoner()
    {
        var result = await _summonerService.GetSummonerByPuuidAsync(Fixture.Puuid, LeagueOfLegendsPlatform.Euw1);
        Assert.True(result.IsSuccess);
        Assert.NotNull(result.Data);
        var summoner = Assert.IsType<SummonerDto>(result.Data);
        Assert.Equal(Fixture.Puuid, summoner.Puuid);
    }
    
    [Fact]
    public async Task GetSummonerByAccountId_ShouldReturnSummoner()
    {
        var result = await _summonerService.GetSummonerByAccountIdAsync(Fixture.AccountId, LeagueOfLegendsPlatform.Euw1);
        Assert.True(result.IsSuccess);
        Assert.NotNull(result.Data);
        var summoner = Assert.IsType<SummonerDto>(result.Data);
        Assert.Equal(Fixture.AccountId, summoner.AccountId);
    }
    
    [Fact]
    public async Task GetBySummonerId_ShouldReturnSummoner()
    {
        var result = await _summonerService.GetBySummonerIdAsync(Fixture.SummonerId, LeagueOfLegendsPlatform.Euw1);
        Assert.True(result.IsSuccess);
        Assert.NotNull(result.Data);
        var summoner = Assert.IsType<SummonerDto>(result.Data);
        Assert.Equal(Fixture.SummonerId, summoner.Id);
    }
}