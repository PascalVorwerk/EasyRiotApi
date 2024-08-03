using System.Text.Json.Serialization;

namespace EasyRiotApi.Models.Common;

public class StatusDto
{
    public int Id { get; set; }
    [JsonPropertyName("maintenance_status")]
    public string MaintenanceStatus { get; set; } = null!;
    [JsonPropertyName("incident_severity")]
    public string IncidentSeverity { get; set; } = null!;
    public List<ContentDto> Titles { get; set; } = null!;
    public List<UpdateDto> Updates { get; set; } = null!;
    [JsonPropertyName("created_at")]
    public string CreatedAt { get; set; } = null!;
    [JsonPropertyName("archive_at")]
    public string ArchiveAt { get; set; } = null!;
    [JsonPropertyName("updated_at")]
    public string UpdatedAt { get; set; } = null!;
    public List<string> Platforms { get; set; } = null!;
}