namespace ApiBureau.Ringover.Api.Dtos;

public class UserDto : UserIdDto
{
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public required string Email { get; set; }

    [JsonPropertyName("concat_name")]
    public string? ConcatName { get; set; }
}