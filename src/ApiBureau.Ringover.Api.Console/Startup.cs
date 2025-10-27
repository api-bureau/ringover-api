using ApiBureau.Ringover.Api.Console.Services;
using ApiBureau.Ringover.Api.Extensions;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace ApiBureau.Ringover.Api.Console;

public class Startup
{
    private IConfigurationRoot Configuration { get; }

    public Startup()
    {
        var builder = new ConfigurationBuilder()
            .AddJsonFile("appsettings.json", true)
            .AddUserSecrets<Startup>()
            .AddEnvironmentVariables();

        Configuration = builder.Build();
    }

    public void ConfigureServices(IServiceCollection services)
    {
        services.AddLogging(configure =>
        {
            configure.AddConfiguration(Configuration.GetSection("Logging"));
            configure.AddConsole();
        });
        services.AddRingover(Configuration);
        services.AddScoped<DataService>();
    }
}