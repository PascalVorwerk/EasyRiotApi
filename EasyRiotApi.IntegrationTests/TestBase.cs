using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace EasyRiotApi.IntegrationTests;

public class TestBase : IDisposable
{
    protected IServiceProvider ServiceProvider { get; private set;}
    
    public TestBase()
    {
        var services = new ServiceCollection();
        
        var configuration = new ConfigurationBuilder()
            .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
            .AddEnvironmentVariables()
            .Build();
        
        services.AddLogging(configure => configure.AddConfiguration(configuration.GetSection("Logging")));
        services.AddEasyRiotApi(configuration);

        ServiceProvider = services.BuildServiceProvider();
    }
    
    
    public void Dispose()
    {
        if(ServiceProvider is IDisposable disposable)
        {
            disposable.Dispose();
        }
    }
}