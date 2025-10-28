namespace ApiBureau.Ringover.Api.Responses;

public class UserResponse
{
    [JsonPropertyName("list_count")]
    public int ListCount { get; set; }
    public List<UserDto> List { get; set; } = [];
}