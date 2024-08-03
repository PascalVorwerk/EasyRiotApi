namespace EasyRiotApi.Models.Common.League;

public class MiniseriesDto
{
    public int Losses { get; set; }
    public string Progress { get; set; } = null!;
    public int Target { get; set; }
    public int Wins { get; set; }
}