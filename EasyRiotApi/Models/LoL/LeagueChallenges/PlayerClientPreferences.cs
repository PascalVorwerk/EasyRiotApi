namespace EasyRiotApi.Models.LoL.LeagueChallenges;

public class PlayerClientPreferences
{
    public string Title { get; set; } = null!;
    public List<long> ChallengeIds { get; set; } = null!;
    public string CrestBorder { get; set; } = null!;
    public int CrestBorderLevel { get; set; }
    public string? BannerAccent { get; set; }
}