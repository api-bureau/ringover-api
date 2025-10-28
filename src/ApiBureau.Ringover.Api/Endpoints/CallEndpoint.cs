namespace ApiBureau.Ringover.Api.Endpoints;

/// <summary>
/// Provides operations related to calls within an organization.
/// </summary>
public class CallEndpoint : BaseEndpoint
{
    /// <summary>
    /// Creates a new <see cref="CallEndpoint"/>.
    /// </summary>
    /// <param name="httpClient">The configured Ringover HTTP connection.</param>
    public CallEndpoint(RingoverHttpClient httpClient) : base(httpClient) { }

    /// <summary>
    /// Retrieves calls for a specific organization with pagination support.
    /// </summary>
    /// <param name="cancellationToken">A token to observe for cancellation.</param>
    public async Task<List<CallDto>> GetAsync(CallQuery query,
        CancellationToken cancellationToken = default)
    {
        var queryParams = QueryBuilder.BuildCallQuery(query);

        var response = await HttpClient.GetAsync<CallResponse>(queryParams, cancellationToken);

        return response?.CallList ?? [];
    }
}