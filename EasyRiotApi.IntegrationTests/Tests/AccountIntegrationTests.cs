using EasyRiotApi.IntegrationTests.Fixtures;
using EasyRiotApi.IntegrationTests.Orderers;
using EasyRiotApi.Models.Account;
using EasyRiotApi.Models.Account.Enums;
using EasyRiotApi.Services.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace EasyRiotApi.IntegrationTests.Tests;

[TestCaseOrderer(ordererTypeName: "EasyRiotApi.IntegrationTests.Orderers.PriorityOrderer", ordererAssemblyName: "EasyRiotApi.IntegrationTests")]
public class AccountIntegrationTests : TestBase, IClassFixture<AccountIntegrationTestsFixture>
{
    private readonly IRiotAccountsService _riotAccountsService;
    private AccountIntegrationTestsFixture Fixture { get; set; }
    
    public AccountIntegrationTests(AccountIntegrationTestsFixture fixture)
    {
        _riotAccountsService = ServiceProvider.GetRequiredService<IRiotAccountsService>();
        Fixture = fixture;
    }
    
    [Fact, TestPriority(0)]
    public async Task GetAccountByRiotId_Success_ReturnAccountDto()
    {
        // Act
        var result = await _riotAccountsService.GetAccountByRiotIdAsync("", "", AccountRegion.Europe);
        
        // Assert
        Assert.True(result.IsSuccess);
        Assert.NotNull(result.Data);
        var account = Assert.IsType<AccountDto>(result.Data);
        Assert.Equal("Bob", account.GameName);
        Assert.Equal("0002", account.TagLine);
        Assert.NotEmpty(account.Puuid);
        Fixture.Puuid = account.Puuid;
    }

    [Fact, TestPriority(0)]
    public async Task GetAccountByRiotId_Fail_ReturnResultWithError()
    {
        // Act
        var result = await _riotAccountsService.GetAccountByRiotIdAsync("", "", AccountRegion.Esports);
        
        // Assert
        Assert.False(result.IsSuccess);
        Assert.Null(result.Data);
        Assert.NotNull(result.ErrorMessage);
    }
    
    [Fact, TestPriority(1)]
    public async Task GetAccountByPuuid_Success_ReturnAccountDto()
    {
        // Act
        var result = await _riotAccountsService.GetAccountByPuuidAsync(Fixture.Puuid, AccountRegion.Europe);
        
        // Assert
        Assert.True(result.IsSuccess);
        Assert.NotNull(result.Data);
        var account = Assert.IsType<AccountDto>(result.Data);
        Assert.Equal("Bob", account.GameName);
        Assert.Equal("0002", account.TagLine);
        Assert.Equal(Fixture.Puuid, account.Puuid);
    }
    
    [Fact, TestPriority(1)]
    public async Task GetAccountByPuuid_Fail_ReturnResultWithError()
    {
        // Act
        var result = await _riotAccountsService.GetAccountByPuuidAsync("", AccountRegion.Esports);
        
        // Assert
        Assert.False(result.IsSuccess);
        Assert.Null(result.Data);
        Assert.NotNull(result.ErrorMessage);
    }
    
    [Fact, TestPriority(2)]
    public async Task GetActiveShard_Success_ReturnActiveShardDto()
    {
        // Act
        var result = await _riotAccountsService.GetActiveShardAsync(Fixture.Puuid, ActiveShardGame.Val, AccountRegion.Europe);
        
        // Assert
        Assert.True(result.IsSuccess);
        Assert.NotNull(result.Data);
        var activeShard = Assert.IsType<ActiveShardDto>(result.Data);
        Assert.Equal("eu", activeShard.ActiveShard);
        Assert.Equal("val", activeShard.Game);
    }
    
    [Fact, TestPriority(2)]
    public async Task GetActiveShard_Fail_ReturnResultWithError()
    {
        // Act
        var result = await _riotAccountsService.GetActiveShardAsync("", ActiveShardGame.Val, AccountRegion.Esports);
        
        // Assert
        Assert.False(result.IsSuccess);
        Assert.Null(result.Data);
        Assert.NotNull(result.ErrorMessage);
    }
}