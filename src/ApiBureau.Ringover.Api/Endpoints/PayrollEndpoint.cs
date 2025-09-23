using ApiBureau.Ringover.Api.Internals;
using ApiBureau.Ringover.Api.Queries;

namespace ApiBureau.Ringover.Api.Endpoints;

/// <summary>
/// Provides operations related to Ringover payrolls.
/// </summary>
public class PayrollEndpoint : BaseEndpoint
{
    private const string EarningCodesEndpoint = "/payroll/companyEarnings/getAllEarningsCode";

    /// <summary>
    /// Creates a new <see cref="PayrollEndpoint"/>.
    /// </summary>
    /// <param name="httpClient">The configured Ringover HTTP connection.</param>
    public PayrollEndpoint(RingoverHttpClient httpClient) : base(httpClient) { }

    /// <summary>
    /// Retrieves payrolls matching the supplied query.
    /// </summary>
    /// <param name="query">The payroll query parameters.</param>
    /// <param name="cancellationToken">A token to observe for cancellation.</param>
    /// <returns>A list of payrolls; an empty list if the response body is empty.</returns>
    public async Task<List<PayrollDto>> GetAllPayrollsAsync(PayrollQuery query, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(query);

        var relativeUrl = QueryBuilder.BuildPayrollQuery(query);

        var responseDto = await HttpClient.GetAsync<PayrollsResponseDto>(relativeUrl, query.CompanyId, cancellationToken);

        return responseDto?.Payrolls ?? [];
    }
}