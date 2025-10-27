namespace ApiBureau.Ringover.Api.Dtos;

public class UserDto
{
    [JsonPropertyName("user_id")]
    public required long UserId { get; set; }

    [JsonPropertyName("team_id")]
    public required long TeamId { get; set; }

    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public required string Email { get; set; }

    [JsonPropertyName("concat_name")]
    public string? ConcatName { get; set; }
}