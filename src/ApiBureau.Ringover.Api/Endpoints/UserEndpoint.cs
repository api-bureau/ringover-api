namespace ApiBureau.Ringover.Api.Endpoints;

/// <summary>
/// Provides operations related to users within an organization.
/// </summary>
public class UserEndpoint : BaseEndpoint
{
    /// <summary>
    /// Creates a new <see cref="UserEndpoint"/>.
    /// </summary>
    /// <param name="httpClient">The configured Ringover HTTP connection.</param>
    public UserEndpoint(RingoverHttpClient httpClient) : base(httpClient) { }

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