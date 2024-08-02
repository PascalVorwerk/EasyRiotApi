using System.Text.Json.Serialization;

namespace EasyRiotApi.Models;

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

public class NextSeasonMilestone
{
    public int RewardMarks { get; set; }
    public bool Bonus { get; set; }
    public int TotalGamesRequires { get; set; }
    public RewardConfig RewardConfig { get; set; } = null!;
    public RequireGradeCounts RequireGradeCounts { get; set; } = null!;
}

public class RequireGradeCounts
{
    [JsonPropertyName("B-")]
    public int B { get; set; }

    [JsonPropertyName("C-")]
    public int C { get; set; }
}

public class RewardConfig
{
    public string RewardValue { get; set; } = null!;
    public string RewardType { get; set; } = null!;
    public int MaximumReward { get; set; }
}