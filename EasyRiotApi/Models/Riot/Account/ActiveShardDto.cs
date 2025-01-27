using System.Text.Json.Serialization;

namespace EasyRiotApi.Models.Riot.Account;

public class ActiveShardDto
{
    [JsonRequired] public string Puuid { get; set; } = null!;
    public string? Game { get; set; }
    public string? ActiveShard { get; set; }
}