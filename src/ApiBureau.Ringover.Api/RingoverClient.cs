namespace ApiBureau.Ringover.Api;

/// <summary>
/// Default implementation of <see cref="IRingoverClient"/> that exposes grouped Ringover endpoints.
/// </summary>
public class RingoverClient : IRingoverClient
{
    /// <summary>
    /// Provides operations related to company resources.
    /// </summary>
    public CompanyEndpoint Companies { get; }
    public PayrollEndpoint Payrolls { get; }

    /// <summary>
    /// Creates a new <see cref="RingoverClient"/> instance.
    /// </summary>
    /// <param name="apiConnection">The configured Ringover HTTP connection.</param>
    public RingoverClient(RingoverHttpClient apiConnection)
    {
        Companies = new CompanyEndpoint(apiConnection);
        Payrolls = new PayrollEndpoint(apiConnection);
    }
}