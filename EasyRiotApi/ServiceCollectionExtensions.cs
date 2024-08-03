using EasyRiotApi.Config;
using EasyRiotApi.Services;
using EasyRiotApi.Services.Interfaces;
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

        services.AddTransient<IRiotAccountsService, RiotAccountsService>();
        services.AddTransient<IChampionMasteryService, ChampionMasteryService>();
        services.AddTransient<IChampionService, ChampionService>();
        services.AddTransient<ILeagueExpService, LeagueExpService>();
        services.AddTransient<IClashService, ClashService>();
        services.AddTransient<ISummonerService, SummonerService>();
        
        return services;
    }
}