using ApiBureau.Ringover.Api.Interfaces;
using ApiBureau.Ringover.Api.Queries;
using Microsoft.Extensions.Logging;
using System.Text.Json;

namespace ApiBureau.Ringover.Api.Console.Services;

public class DataService
{
    private readonly IRingoverClient _client;
    private readonly ILogger<DataService> _logger;
    private readonly JsonSerializerOptions _indentedJsonOptions = new() { WriteIndented = true };

    public DataService(IRingoverClient client, ILogger<DataService> logger)
    {
        _client = client;
        _logger = logger;
    }

    public async Task RunAsync()
    {
        var startDate = DateTime.Now.AddDays(-3);

        var callQuery = new CallQuery(startDate, DateTime.Now);

        var result = await _client.Calls.GetAsync(callQuery);

        _logger.LogInformation(JsonSerializer.Serialize(result, _indentedJsonOptions));

        var users = await _client.Users.GetAsync(default);

        _logger.LogInformation(JsonSerializer.Serialize(users, _indentedJsonOptions));

        var transcriptQuery = new TranscriptQuery(startDate, DateTime.Now);

        var transcripts = await _client.Transcripts.GetAsync(transcriptQuery);

        _logger.LogInformation(JsonSerializer.Serialize(transcripts, _indentedJsonOptions));
    }
}