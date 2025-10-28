namespace ApiBureau.Ringover.Api.Dtos;

public class CallIdDto
{
    [JsonPropertyName("cdr_id")]
    public required int CdrId { get; set; }

    [JsonPropertyName("call_id")]
    public required string CallId { get; set; }
}