namespace ApiBureau.Ringover.Api.Responses;

public class CallResponse
{
    [JsonPropertyName("user_id")]
    public required string UserId { get; set; }

    public List<CallDto> Items { get; set; } = [];
}