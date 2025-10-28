namespace ApiBureau.Ringover.Api.Dtos;

public class UserIdDto
{
    [JsonPropertyName("user_id")]
    public required long UserId { get; set; }

    [JsonPropertyName("team_id")]
    public required long TeamId { get; set; }
}