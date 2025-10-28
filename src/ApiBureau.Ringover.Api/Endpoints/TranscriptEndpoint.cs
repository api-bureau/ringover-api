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
    public async Task<List<UserDto>> GetAsync(CancellationToken cancellationToken)
    {
        var result = await HttpClient.GetAsync<UserResponse>(
            $"/users",
            cancellationToken);

        return result?.List ?? [];
    }
}