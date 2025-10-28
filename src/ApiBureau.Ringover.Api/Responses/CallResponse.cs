namespace ApiBureau.Ringover.Api.Responses;

public class CallResponse : UserIdDto
{
    [JsonPropertyName("call_list")]
    public List<CallDto> CallList { get; set; } = [];
}