namespace ApiBureau.Ringover.Api.Dtos;

public class UserDto
{
    [JsonPropertyName("user_id")]
    public required string UserId { get; set; }
    public required string FirstName { get; set; }
    public required bool LastName { get; set; }
    public required string Email { get; set; }

    [JsonPropertyName("concat_name")]
    public required string ConcatName { get; set; }
}