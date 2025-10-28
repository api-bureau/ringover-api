namespace ApiBureau.Ringover.Api.Interfaces;

/// <summary>
/// High-level Ringover API client that groups available endpoints.
/// </summary>
public interface IRingoverClient
{
    /// <summary>
    /// Access to call-related operations.
    /// </summary>
    CallEndpoint Calls { get; }

    /// <summary>
    /// Gets the endpoint for managing user-related operations.
    /// </summary>
    UserEndpoint Users { get; }

    /// <summary>
    /// Gets the endpoint for managing contact information.
    /// </summary>
    ContactEndpoint Contacts { get; }

    TranscriptEndpoint Transcripts { get; }
}