namespace EasyRiotApi.Models.LoL.ChampionMastery;

public class NextSeasonMilestone
{
    public int RewardMarks { get; set; }
    public bool Bonus { get; set; }
    public int TotalGamesRequires { get; set; }
    public RewardConfig RewardConfig { get; set; } = null!;
    public RequireGradeCounts RequireGradeCounts { get; set; } = null!;
}