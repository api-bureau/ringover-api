namespace ApiBureau.Ringover.Api.Dtos;

public class CallDto
{
    [JsonPropertyName("cdr_id")]
    public required int CdrId { get; set; }

    [JsonPropertyName("call_id")]
    public required string CallId { get; set; }

    public string? Type { get; set; } = null!;
    public string Direction { get; set; } = null!;

    [JsonPropertyName("from_number")]
    public required string FromNumber { get; set; }

    [JsonPropertyName("to_number")]
    public required string ToNumber { get; set; }

    [JsonPropertyName("start_time")]
    public DateTime StartTime { get; set; }

    [JsonPropertyName("end_time")]
    public DateTime EndTime { get; set; }

    [JsonPropertyName("total_duration")]
    public int TotalDuration { get; set; }

    [JsonPropertyName("last_state")]
    public string LastState { get; set; } = null!;

    //public DateTime UpdateTimeUtc { get; set; }
    //public string? RecordingUrl { get; set; }
    //public string? PlatformLink { get; set; }
    public string? Note { get; set; }
    //public string? CallTag { get; set; }

    //public int GetNumericCrmId()
    //{
    //    //if (Contact is null) return 0;

    //    //_ = int.TryParse(Contact.CrmObjectInstanceId, out var crmId);

    //    int crmId = 0;

    //    return crmId;
    //}
}