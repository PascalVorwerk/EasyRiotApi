using System.Text.Json.Serialization;

namespace EasyRiotApi.Models.TFT.Match;

public class ParticipantDto
{
    [JsonPropertyName("companion")] public object Companion { get; set; } = null!;
    [JsonPropertyName("gold_left")] public int GoldLeft { get; set; }
    [JsonPropertyName("last_round")] public int LastRound { get; set; }
    [JsonPropertyName("level")] public int Level { get; set; }
    [JsonPropertyName("placement")] public int Placement { get; set; }
    [JsonPropertyName("players_eliminated")] public int PlayersEliminated { get; set; }
    [JsonPropertyName("puuid")] public string Puuid { get; set; } = null!;
    [JsonPropertyName("time_eliminated")] public double TimeEliminated { get; set; }
    [JsonPropertyName("total_damage_to_players")] public int TotalDamageToPlayers { get; set; }
    [JsonPropertyName("traits")] public List<TraitDto> Traits { get; set; } = null!;
    [JsonPropertyName("units")] public List<UnitDto> Units { get; set; } = null!;
}