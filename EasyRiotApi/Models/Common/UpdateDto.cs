using System.Text.Json.Serialization;

namespace EasyRiotApi.Models.Common;

public class UpdateDto
{
    public int Id { get; set; }
    public string Author { get; set; } = null!;
    public bool Publish { get; set; }
    [JsonPropertyName("publish_locations")]
    public List<string> PublishLocations { get; set; } = null!;
    public List<ContentDto> Translations { get; set; } = null!;
    [JsonPropertyName("created_at")]
    public string CreatedAt { get; set; } = null!;
    [JsonPropertyName("updated_at")]
    public string UpdatedAt { get; set; } = null!;
}