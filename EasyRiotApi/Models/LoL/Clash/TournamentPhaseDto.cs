namespace EasyRiotApi.Models.LoL.Clash;

public class TournamentPhaseDto
{
    public int Id { get; set; }
    public long RegistrationTime { get; set; }
    public long StartTime { get; set; }
    public bool Cancelled { get; set; }
}