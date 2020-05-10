namespace LeagueManager.Leagues.Models
{
    public interface ITeamPlayer : ILeaguePlayer
    {
        ITeam Team { get; set; }
        string JerseyNumber { get; set; }
    }
}