namespace ApiBureau.Ringover.Api.Responses;

public class CallResponse
{
    [JsonPropertyName("user_id")]
    public required long UserId { get; set; }

    [JsonPropertyName("call_list")]
    public List<CallDto> CallList { get; set; } = [];
}