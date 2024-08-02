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
        services.Configure<RiotApiConfiguration>(configuration.GetSection("RiotApi"));
        services.AddHttpClient("RiotApiClient")
            .ConfigureHttpClient((provider, client) =>
            {
                var config = provider.GetRequiredService<IOptions<RiotApiConfiguration>>();
                client.DefaultRequestHeaders.Add("X-Riot-Token", config.Value.ApiKey);
            });

        services.AddTransient<IRiotAccountsService, RiotAccountsService>();
        services.AddTransient<IChampionMasteryService, ChampionMasteryService>();
        services.AddTransient<IChampionService, ChampionService>();
        
        return services;
    }
}