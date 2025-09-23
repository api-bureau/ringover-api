namespace ApiBureau.Ringover.Api.Core;

using System.ComponentModel.DataAnnotations;

/// <summary>
/// Typed configuration for the Ringover API client.
/// </summary>
/// <remarks>
/// Provide these values via configuration (e.g., appsettings or user secrets) and bind them
/// when registering the client in dependency injection.
/// </remarks>
public class RingoverSettings
{
    /// <summary>
    /// The absolute base URL of the Ringover API (e.g., https://api.ringover.com).
    /// </summary>
    [Required(ErrorMessage = "BaseUrl is required.")]
    [Url]
    public required string BaseUrl { get; set; }

    /// <summary>
    /// The API key used to authenticate requests to Ringover.
    /// </summary>
    [Required(ErrorMessage = "ApiKey is required.")]
    public required string ApiKey { get; set; }
}