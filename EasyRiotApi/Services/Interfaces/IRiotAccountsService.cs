using EasyRiotApi.Models;
using EasyRiotApi.Models.Enums;

namespace EasyRiotApi.Services.Interfaces;

public interface IRiotAccountsService
{
    public Task<RiotApiResult<AccountDto>> GetAccountByPuuidAsync(string puuid, AccountRegion region);
    
    public Task<RiotApiResult<AccountDto>> GetAccountByRiotIdAsync(string gameName, string tagLine, AccountRegion region);
    
    public Task<RiotApiResult<ActiveShardDto>> GetActiveShardAsync(string puuid, ActiveShardGame game, AccountRegion region);
    
    public Task<RiotApiResult<AccountDto>> GetOwnAccount(AccountRegion region);
}