using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using Polly;

namespace ApiBureau.Ringover.Api.Extensions;

/// <summary>
/// Dependency injection helpers for registering the Ringover API client.
/// </summary>
public static class ServiceExtensions
{
    /// <summary>
    /// Registers Ringover client services and binds <see cref="RingoverSettings"/> from configuration.
    /// </summary>
    /// <param name="services">The target service collection.</param>
    /// <param name="configuration">Application configuration used to bind settings.</param>
    /// <returns>The original service collection for chaining.</returns>
    public static IServiceCollection AddRingover(this IServiceCollection services, IConfiguration configuration)
    {
        services
            .AddOptions<RingoverSettings>()
            .Bind(configuration.GetSection(nameof(RingoverSettings)))
            .ValidateDataAnnotations()
            .ValidateOnStart();

        services
            .AddHttpClient<RingoverHttpClient>((sp, client) =>
            {
                var settings = sp.GetRequiredService<IOptions<RingoverSettings>>().Value;
                client.BaseAddress = new Uri(settings.BaseUrl);
                //client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes($"{settings.ApiKey}:")));
                client.DefaultRequestHeaders.Add("Authorization", settings.ApiKey);
                client.DefaultRequestHeaders.UserAgent.ParseAdd("ApiBureau.Ringover.Api/1.0");
            })
            .AddPolicyHandler(Policy.TimeoutAsync<HttpResponseMessage>(TimeSpan.FromSeconds(20)))
            .AddTransientHttpErrorPolicy(pb => pb.WaitAndRetryAsync(
            [
                TimeSpan.FromMilliseconds(200),
                TimeSpan.FromSeconds(1),
                TimeSpan.FromSeconds(3)
            ]));

        services.AddSingleton<IRingoverClient, RingoverClient>();

        return services;
    }
}