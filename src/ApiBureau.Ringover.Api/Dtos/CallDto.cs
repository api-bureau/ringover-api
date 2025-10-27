namespace ApiBureau.Ringover.Api.Dtos;

public class CallDto
{
    [JsonPropertyName("cdr_id")]
    public required int CdrId { get; set; }

    [JsonPropertyName("call_id")]
    public required string CallId { get; set; }

    public string? Type { get; set; } = null!;


    public string CallerId { get; set; } = null!;
    public string CalledNumber { get; set; } = null!;
    public string Direction { get; set; } = null!;
    public DateTime StartTimeUtc { get; set; }
    public DateTime EndTimeUtc { get; set; }
    public int Duration { get; set; }
    public string Status { get; set; } = null!;
    public DateTime UpdateTimeUtc { get; set; }
    public string? RecordingUrl { get; set; }
    public string? PlatformLink { get; set; }
    public string? CallNotes { get; set; }
    public string? CallTag { get; set; }

    public int GetNumericCrmId()
    {
        //if (Contact is null) return 0;

        //_ = int.TryParse(Contact.CrmObjectInstanceId, out var crmId);

        int crmId = 0;

        return crmId;
    }
}