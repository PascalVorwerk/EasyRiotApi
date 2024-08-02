namespace EasyRiotApi.Models;

public class ChampionInfoDto
{
    public List<int> FreeChampionIds { get; set; } = null!;
    public List<int> FreeChampionIdsForNewPlayers { get; set; } = null!;
    public int MaxNewPlayerLevel { get; set; }
}