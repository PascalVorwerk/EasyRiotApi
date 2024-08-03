namespace EasyRiotApi.Models.LoL.LeagueChallenges;

public class LoLPlayerInfoDto
{
    public string Puuid { get; set; } = null!;
    public double Value { get; set; }
    public int Position { get; set; }
}