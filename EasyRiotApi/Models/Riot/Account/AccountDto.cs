using System.Text.Json.Serialization;

namespace EasyRiotApi.Models.Riot.Account;

public class AccountDto
{
    [JsonRequired] public string Puuid { get; set; } = null!;
    public string? GameName { get; set; }
    public string? TagLine { get; set; }
}