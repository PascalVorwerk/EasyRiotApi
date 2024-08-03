using EasyRiotApi.Models.LeagueExp.Enums;

namespace EasyRiotApi.Models.LeagueExp;

public class LeagueEntryDto
{
    public string LeagueId { get; set; } = null!;
    public string SummonerId { get; set; } = null!;
    public Queue QueueType { get; set; }
    public Tier Tier { get; set; }
    public Division Rank { get; set; }
    public int LeaguePoints { get; set; }
    public int Wins { get; set; }
    public int Losses { get; set; }
    public bool HotStreak { get; set; }
    public bool Veteran { get; set; }
    public bool FreshBlood { get; set; }
    public bool Inactive { get; set; }
    public MiniseriesDto? MiniSeries { get; set; }
}