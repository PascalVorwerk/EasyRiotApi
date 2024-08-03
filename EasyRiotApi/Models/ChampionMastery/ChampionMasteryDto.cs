namespace EasyRiotApi.Models.ChampionMastery;

public class ChampionMasteryDto
{
    public string Puuid { get; set; } = null!;
    public int ChampionId { get; set; }
    public int ChampionLevel { get; set; }
    public int ChampionPoints { get; set; }
    public long LastPlayTime { get; set; }
    public int ChampionPointsSinceLastLevel { get; set; }
    public int ChampionPointsUntilNextLevel { get; set; }
    public int MarkRequiredForNextLevel { get; set; }
    public int TokensEarned { get; set; }
    public int ChampionSeasonMilestone { get; set; }
    public NextSeasonMilestone NextSeasonMilestone { get; set; } = null!;
}