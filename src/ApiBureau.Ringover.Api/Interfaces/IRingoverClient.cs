namespace ApiBureau.Ringover.Api.Interfaces;

/// <summary>
/// High-level Ringover API client that groups available endpoints.
/// </summary>
public interface IRingoverClient
{
    /// <summary>
    /// Access to company-related operations.
    /// </summary>
    CompanyEndpoint Companies { get; }
    PayrollEndpoint Payrolls { get; }
}