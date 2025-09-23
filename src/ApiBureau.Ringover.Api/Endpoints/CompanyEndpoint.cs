namespace ApiBureau.Ringover.Api.Endpoints;

/// <summary>
/// Provides operations related to Ringover companies.
/// </summary>
public class CompanyEndpoint : BaseEndpoint
{
    private const string Endpoint = "/organization/kb";

    /// <summary>
    /// Creates a new <see cref="CompanyEndpoint"/>.
    /// </summary>
    /// <param name="apiConnection">The configured Ringover HTTP connection.</param>
    public CompanyEndpoint(RingoverHttpClient apiConnection) : base(apiConnection) { }

    /// <summary>
    /// Retrieves the list of companies from Ringover.
    /// </summary>
    /// <param name="cancellationToken">A token to observe for cancellation.</param>
    /// <returns>A list of companies; an empty list if the response body is empty.</returns>
    public async Task<List<CompanyDto>> GetCompaniesAsync(CancellationToken cancellationToken = default)
        => await HttpClient.GetAsync<List<CompanyDto>>($"{Endpoint}/getCompanyDetails", cancellationToken) ?? [];
}