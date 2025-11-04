namespace ApiBureau.Ringover.Api.Dtos;

public class TranscriptionDto
{
    public long Id { get; set; }

    [JsonPropertyName("call_id")]
    public required string CallId { get; set; }

    public string Transcript { get; set; } = null!;
    public string? Provider { get; set; }

    [JsonPropertyName("user_id")]
    public required long UserId { get; set; }

    [JsonPropertyName("team_id")]
    public required long TeamId { get; set; }

    [JsonPropertyName("transcription_data")]
    public TranscriptionDataDto? TranscriptionData { get; set; }

    [JsonPropertyName("creation_date")]
    public DateTime CreationDate { get; set; }
}

public class TranscriptionDataDto
{
    public List<SpeechDto> Speeches { get; set; } = [];
    public string? Text { get; set; }

    public string? GetSpeechText()
    {
        if (Speeches.Count == 0) return null;

        return string.Join("\n", Speeches.Where(s => !string.IsNullOrEmpty(s.Text)).Select(s => $"Channel {s.ChannelId}: {s.Text}"));
    }
}

public class SpeechDto
{
    public int ChannelId { get; set; }
    public float Start { get; set; }
    public float End { get; set; }
    public float Duration { get; set; }
    public string? Text { get; set; }
}