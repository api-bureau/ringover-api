namespace ApiBureau.Ringover.Api.Dtos;

public class ContactDto
{
    [JsonPropertyName("contact_id")]
    public required string ContactId { get; set; }
    public string? FirstName { get; set; }
    public string? LastName { get; set; }

    [JsonPropertyName("concat_name")]
    public string? ConcatName { get; set; }

    public List<PhoneNumberDto> Numbers { get; set; } = [];
    public string? Note { get; set; }

    [JsonPropertyName("social_profile")]
    public string? SocialProfile { get; set; }

    [JsonPropertyName("social_service")]
    public string? SocialService { get; set; }

    [JsonPropertyName("social_service_id")]
    public string? SocialServiceId { get; set; }
}