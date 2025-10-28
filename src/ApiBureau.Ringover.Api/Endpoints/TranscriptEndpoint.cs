namespace ApiBureau.Ringover.Api.Endpoints;

public class TranscriptEndpoint : BaseEndpoint
{
    /// <summary>
    /// Creates a new <see cref="TranscriptEndpoint"/>.
    /// </summary>
    /// <param name="httpClient">The configured Ringover HTTP connection.</param>
    public TranscriptEndpoint(RingoverHttpClient httpClient) : base(httpClient) { }

    /// <summary>
    /// Retrieves all users for a specific organization.
    /// </summary>
    public async Task<List<TranscriptionDto>> GetAsync(TranscriptQuery query, CancellationToken cancellationToken = default)
    {
        var queryParams = QueryBuilder.BuildTranscriptQuery(query);

        var items = await HttpClient.GetAsync<List<TranscriptionDto>>(queryParams, cancellationToken);

        return items ?? [];
    }
}