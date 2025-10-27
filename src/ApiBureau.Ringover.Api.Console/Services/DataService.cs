using ApiBureau.Ringover.Api.Interfaces;
using ApiBureau.Ringover.Api.Queries;
using Microsoft.Extensions.Logging;
using System.Text.Json;

namespace ApiBureau.Ringover.Api.Console.Services;

public class DataService
{
    private readonly IRingoverClient _client;
    private readonly ILogger<DataService> _logger;

    public DataService(IRingoverClient client, ILogger<DataService> logger)
    {
        _client = client;
        _logger = logger;
    }

    public async Task RunAsync()
    {
        var callQuery = new CallQuery(DateTime.Now.AddDays(-1), DateTime.Now);

        var result = await _client.Calls.GetAsync(callQuery);

        _logger.LogInformation(JsonSerializer.Serialize(result, new JsonSerializerOptions { WriteIndented = true }));

        var users = await _client.Users.GetAsync(default);

        _logger.LogInformation(JsonSerializer.Serialize(users, new JsonSerializerOptions { WriteIndented = true }));
    }
}