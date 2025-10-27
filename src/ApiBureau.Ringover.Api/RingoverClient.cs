namespace ApiBureau.Ringover.Api;

/// <summary>
/// Default implementation of <see cref="IRingoverClient"/> that exposes grouped Ringover endpoints.
/// </summary>
public class RingoverClient : IRingoverClient
{
    /// <summary>
    /// Operations related to call records and call history.
    /// </summary>
    public CallEndpoint Calls { get; }
    public ContactEndpoint Contacts { get; }
    public UserEndpoint Users { get; }

    /// <summary>
    /// Creates a new <see cref="RingoverClient"/> instance.
    /// </summary>
    /// <param name="apiConnection">The configured Ringover HTTP connection.</param>
    public RingoverClient(RingoverHttpClient apiConnection)
    {
        Calls = new CallEndpoint(apiConnection);
        Contacts = new ContactEndpoint(apiConnection);
        Users = new UserEndpoint(apiConnection);
    }
}