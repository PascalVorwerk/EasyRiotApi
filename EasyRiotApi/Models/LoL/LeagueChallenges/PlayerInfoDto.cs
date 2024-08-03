namespace EasyRiotApi.Models.LoL.LeagueChallenges;

public class PlayerInfoDto
{
    public PlayerClientPreferences Preferences { get; set; } = null!;
    public ChallengePoints TotalPoints { get; set; } = null!;
    public Dictionary<string, ChallengePoints> CategoryPoints { get; set; } = null!;
}