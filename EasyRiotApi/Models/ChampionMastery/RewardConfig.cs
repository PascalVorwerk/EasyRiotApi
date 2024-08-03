namespace EasyRiotApi.Models.ChampionMastery;

public class RewardConfig
{
    public string RewardValue { get; set; } = null!;
    public string RewardType { get; set; } = null!;
    public int MaximumReward { get; set; }
}