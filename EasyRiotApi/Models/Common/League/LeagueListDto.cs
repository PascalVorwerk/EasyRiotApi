namespace EasyRiotApi.Models.Common.League;

public class LeagueListDto
{
    public string LeagueId { get; set; } = null!;
    public string Tier { get; set; } = null!;
    public string Name { get; set; } = null!;
    public string Queue { get; set; } = null!;
    public List<LeagueItemDto> Entries { get; set; } = null!;
}