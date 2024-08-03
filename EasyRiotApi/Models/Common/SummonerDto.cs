namespace EasyRiotApi.Models.Common;

public class SummonerDto
{
    public string AccountId { get; set; } = null!;
    public int ProfileIconId { get; set; }
    public long RevisionDate { get; set; }
    public string Id { get; set; } = null!;
    public string Puuid { get; set; } = null!;
    public long SummonerLevel { get; set; }
}