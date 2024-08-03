using System.Text.Json.Serialization;

namespace EasyRiotApi.Models.Clash;

public class TournamentDto
{
    public int Id { get; set; }
    public int ThemeId { get; set; }
    public string NameKey { get; set; } = null!;
    public string NameKeySecondary { get; set; } = null!;
    public List<TournamentDto> Schedule { get; set; } = null!;
}