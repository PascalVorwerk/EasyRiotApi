using EasyRiotApi.Models.LoL.LeagueChallenges.Enums;

namespace EasyRiotApi.Models.LoL.LeagueChallenges;

public class ChallengeConfigInfoDto
{
    public long Id { get; set; }
    public Dictionary<string, Dictionary<string, string>> LocalizedNames { get; set; } = null!;
    public Tracking Tracking { get; set; }
    public State State { get; set; }
    public long StartTimestamp { get; set; }
    public long EndTimestamp { get; set; }
    public bool Leadership { get; set; }
    public Dictionary<string, double> Thresholds { get; set; } = null!;
}