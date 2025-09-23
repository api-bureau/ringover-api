namespace ApiBureau.Ringover.Api.Dtos;

/// <summary>
/// Represents a company record returned by the Ringover API.
/// </summary>
public class CompanyDto
{
    /// <summary>
    /// The unique identifier of the company.
    /// </summary>
    public required string CompanyId { get; set; }

    /// <summary>
    /// The display name of the company.
    /// </summary>
    public required string CompanyName { get; set; }

    /// <summary>
    /// The description of the SIC code associated with the company.
    /// </summary>
    public string? SicCodeDesc { get; set; }

    public static CompanyDto Empty => new()
    {
        CompanyId = string.Empty,
        CompanyName = string.Empty,
        SicCodeDesc = string.Empty
    };

    public override bool Equals(object? obj)
    {
        if (obj is not CompanyDto other) return false;

        return CompanyId == other.CompanyId &&
               CompanyName == other.CompanyName &&
               SicCodeDesc == other.SicCodeDesc;
    }

    public override int GetHashCode()
        => HashCode.Combine(CompanyId, CompanyName, SicCodeDesc);
}