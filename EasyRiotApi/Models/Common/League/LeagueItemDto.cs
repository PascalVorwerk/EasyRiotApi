namespace EasyRiotApi.Models.Common.League;

public class LeagueItemDto
{
    public bool FreshBlood { get; set; }
    public int Wins { get; set; }
    public bool Inactive { get; set; }
    public bool Veteran { get; set; }
    public bool HotStreak { get; set; }
    public string Rank { get; set; } = null!;
    public int LeaguePoints { get; set; }
    public int Losses { get; set; }
    public string SummonerId { get; set; } = null!;
    public MiniseriesDto? MiniSeries { get; set; }
}