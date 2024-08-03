using EasyRiotApi.Config;
using EasyRiotApi.Services;
using EasyRiotApi.Services.LoL;
using EasyRiotApi.Services.LoL.Interfaces;
using EasyRiotApi.Services.LoR;
using EasyRiotApi.Services.LoR.Interfaces;
using EasyRiotApi.Services.Riot;
using EasyRiotApi.Services.Riot.Interfaces;
using EasyRiotApi.Services.TFT;
using EasyRiotApi.Services.TFT.Interfaces;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;

namespace EasyRiotApi;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddEasyRiotApi(this IServiceCollection services, IConfiguration configuration)
    {
        services.Configure<EasyRiotApiConfiguration>(configuration.GetSection("EasyRiotApi"));
        services.AddHttpClient("RiotApiClient")
            .ConfigureHttpClient((provider, client) =>
            {
                var config = provider.GetRequiredService<IOptions<EasyRiotApiConfiguration>>();
                client.DefaultRequestHeaders.Add("X-Riot-Token", config.Value.ApiKey);
            });

        // LoL services
        services.AddTransient<IChampionMasteryService, ChampionMasteryService>();
        services.AddTransient<IChampionService, ChampionService>();
        services.AddTransient<ILeagueExpService, LeagueExpService>();
        services.AddTransient<IClashService, ClashService>();
        services.AddTransient<ISummonerService, SummonerService>();
        services.AddTransient<ILeagueService, LeagueService>();
        services.AddTransient<ILolChallengesService, LolChallengesService>();
        services.AddTransient<ILolStatusService, LolStatusService>();
        services.AddTransient<ILolSpectatorService, LolSpectatorService>();
        services.AddTransient<ILolMatchService, LolMatchService>();
        
        // LoR services
        services.AddTransient<ILoRMatchService, LoRMatchService>();
        services.AddTransient<ILoRRankedService, LoRRankedService>();
        services.AddTransient<ILoRStatusService, LoRStatusService>();
        
        // TFT services
        services.AddTransient<ITftSpectatorService, TftSpectatorService>();
        services.AddTransient<ITftLeagueService, TftLeagueService>();
        services.AddTransient<ITftMatchService, TftMatchService>();
        services.AddTransient<ITftStatusService, TftStatusService>();
        services.AddTransient<ITftSummonerService, ITftSummonerService>();
        
        // Riot services
        services.AddTransient<IRiotAccountsService, RiotAccountsService>();
        
        return services;
    }
}