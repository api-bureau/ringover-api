namespace ApiBureau.Ringover.Api.Responses;

public class CallResponse
{
    [JsonPropertyName("user_id")]
    public required string UserId { get; set; }

    [JsonPropertyName("call_list")]
    public List<CallDto> CallList { get; set; } = [];
}