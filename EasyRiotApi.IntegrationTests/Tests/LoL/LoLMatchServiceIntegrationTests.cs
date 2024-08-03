using EasyRiotApi.IntegrationTests.Fixtures;
using EasyRiotApi.IntegrationTests.Orderers;
using EasyRiotApi.Models.Common.Enums;
using EasyRiotApi.Models.LoL.Match;
using EasyRiotApi.Services.LoL.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace EasyRiotApi.IntegrationTests.Tests.LoL;

[TestCaseOrderer(ordererTypeName: "EasyRiotApi.IntegrationTests.Orderers.PriorityOrderer", ordererAssemblyName: "EasyRiotApi.IntegrationTests")]
public class LoLMatchServiceIntegrationTests: TestBase, IClassFixture<LoLMatchServiceTestsFixture>
{
    private readonly ILolMatchService _lolMatchService;
    private LoLMatchServiceTestsFixture _fixture;

    public LoLMatchServiceIntegrationTests(LoLMatchServiceTestsFixture fixture)
    {
        _lolMatchService = ServiceProvider.GetRequiredService<ILolMatchService>();
        _fixture = fixture;
    }
    
    [Fact, TestPriority(0)]
    public async Task GetMatchIdsByPuuid_Success_ReturnListOfMatchIds()
    {
        // Act
        var result = await _lolMatchService.GetMatchIdsByPuuidAsync(_fixture.Puuid, LeagueOfLegendsRegion.Europe);
        
        // Assert
        Assert.True(result.IsSuccess);
        Assert.NotNull(result.Data);
        var matchIds = Assert.IsType<List<string>>(result.Data);
        Assert.NotEmpty(matchIds);
        _fixture.MatchIds = matchIds;
    }
    
    [Fact, TestPriority(1)]
    public async Task GetMatchById_Success_ReturnMatchDto()
    {
        // Act
        var result = await _lolMatchService.GetMatchByIdAsync(_fixture.MatchIds.First(), LeagueOfLegendsRegion.Europe);
        
        // Assert
        Assert.True(result.IsSuccess);
        Assert.NotNull(result.Data);
        var match = Assert.IsType<MatchDto>(result.Data);
        Assert.NotEmpty(match.Metadata.MatchId);
        Assert.NotEmpty(match.Info.GameMode);
        Assert.NotEmpty(match.Info.GameType);
    }
    
    [Fact, TestPriority(2)]
    public async Task GetTimelineByMatchId_Success_ReturnTimelineDto()
    {
        // Act
        var result = await _lolMatchService.GetTimelineByMatchIdAsync(_fixture.MatchIds.First(), LeagueOfLegendsRegion.Europe);
        
        // Assert
        Assert.True(result.IsSuccess);
        Assert.NotNull(result.Data);
        var timeline = Assert.IsType<TimelineDto>(result.Data);
        Assert.NotEmpty(timeline.Metadata.MatchId);
        Assert.NotEmpty(timeline.Info.Frames);
    }
}