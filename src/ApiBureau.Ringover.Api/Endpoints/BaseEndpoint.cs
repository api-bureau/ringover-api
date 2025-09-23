namespace ApiBureau.Ringover.Api.Endpoints;

/// <summary>
/// Base class for Ringover API endpoint wrappers providing access to the shared <see cref="RingoverHttpClient"/>.
/// </summary>
public class BaseEndpoint
{
    /// <summary>
    /// The low-level HTTP connection used by derived endpoints.
    /// </summary>
    protected RingoverHttpClient HttpClient { get; }

    /// <summary>
    /// Initializes the endpoint with a shared <see cref="RingoverHttpClient"/> instance.
    /// </summary>
    /// <param name="httpClient">The configured Ringover HTTP connection.</param>
    public BaseEndpoint(RingoverHttpClient httpClient) => HttpClient = httpClient;
}