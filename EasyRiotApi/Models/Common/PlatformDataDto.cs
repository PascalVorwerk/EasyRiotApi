namespace EasyRiotApi.Models.Common;

public class PlatformDataDto
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public List<string> Locales { get; set; } = null!;
    public List<StatusDto> Maintenances { get; set; } = null!;
    public List<StatusDto> Incidents { get; set; } = null!;
}