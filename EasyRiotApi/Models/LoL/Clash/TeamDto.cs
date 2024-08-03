namespace EasyRiotApi.Models.LoL.Clash;

public class TeamDto
{
    public string Id { get; set; } = null!;
    public int TournamentId { get; set; }
    public string Name { get; set; } = null!;
    public int IconId { get; set; }
    public int Tier { get; set; }
    public string Captain { get; set; } = null!;
    public string Abbreviation { get; set; } = null!;
    public List<PlayerDto> Players { get; set; } = null!;
}