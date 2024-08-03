namespace EasyRiotApi.Models.LoL.LeagueChallenges;

public class ChallengePoints
{
    public string Level { get; set; } = null!;
    public int Current { get; set; }
    public int Max { get; set; }
    public double Percentile { get; set; }
}