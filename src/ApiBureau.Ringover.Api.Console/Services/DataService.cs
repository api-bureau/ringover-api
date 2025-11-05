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
        var startDate = DateTime.Now.AddMinutes(-1200);

        await FetchCallsAsync(startDate);

        await FetchUsersAsync();

        await FetchTranscriptsAsync(startDate);

        // Small delay to ensure all logs are flushed before exiting
        await Task.Delay(100);
    }

    private async Task FetchCallsAsync(DateTime startDate)
    {
        var callQuery = new CallQuery(startDate, DateTime.Now);

        var result = await _client.Calls.GetAsync(callQuery);

        _logger.LogInformation(JsonSerializer.Serialize(result, _indentedJsonOptions));
    }

    private async Task FetchUsersAsync()
    {
        var users = await _client.Users.GetAsync(default);

        _logger.LogInformation("Users: {users}", JsonSerializer.Serialize(users, _indentedJsonOptions));
    }

    private async Task FetchTranscriptsAsync(DateTime startDate)
    {
        var transcriptQuery = new TranscriptQuery(startDate, DateTime.Now);

        var transcripts = await _client.Transcripts.GetAsync(transcriptQuery);

        _logger.LogInformation(JsonSerializer.Serialize(transcripts, _indentedJsonOptions));

        if (transcripts.Count > 0)
        {
            _logger.LogInformation("Transcript: {example}", transcripts[0].TranscriptionData?.GetSpeechText());
        }
        else
        {
            _logger.LogInformation("No transcripts found in the specified time range.");
        }
    }
}