using EasyRiotApi.Models;
using EasyRiotApi.Models.Account;
using EasyRiotApi.Models.Account.Enums;
using EasyRiotApi.Services.Interfaces;
using Microsoft.Extensions.Logging;

namespace EasyRiotApi.Services;

internal class RiotAccountsService(IHttpClientFactory factory, ILogger<RiotAccountsService> logger) : BaseService(factory, logger), IRiotAccountsService
{
    public Task<RiotApiResult<AccountDto>> GetAccountByPuuidAsync(string puuid, AccountRegion region = AccountRegion.Europe)
    {
        var url = $"{GetAccountsBaseUrl(region)}/accounts/by-puuid/{puuid}";
        return GetAsync<AccountDto>(url);
    }

    public Task<RiotApiResult<AccountDto>> GetAccountByRiotIdAsync(string gameName, string tagLine, AccountRegion region = AccountRegion.Europe)
    {
        var url = $"{GetAccountsBaseUrl(region)}/accounts/by-riot-id/{gameName}/{tagLine}";
        return GetAsync<AccountDto>(url);
    }

    public Task<RiotApiResult<ActiveShardDto>> GetActiveShardAsync(string puuid, ActiveShardGame game, AccountRegion region = AccountRegion.Europe)
    {
        var url = $"{GetAccountsBaseUrl(region)}/active-shards/by-game/{game.ToString().ToLower()}/by-puuid/{puuid}";
        return GetAsync<ActiveShardDto>(url);
    }

    public Task<RiotApiResult<AccountDto>> GetOwnAccountAsync(AccountRegion region = AccountRegion.Europe)
    {
        var url = $"{GetAccountsBaseUrl(region)}/accounts/me";
        return GetAsync<AccountDto>(url);
    }
    
    private string GetAccountsBaseUrl(AccountRegion region)
    {
        return $"https://{region.ToString().ToLower()}.api.riotgames.com/riot/account/v1";
    }
}