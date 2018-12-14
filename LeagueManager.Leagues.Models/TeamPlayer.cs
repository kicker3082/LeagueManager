namespace LeagueManager.Leagues.Models
{
    public class TeamPlayer : LeaguePlayer
    {
        public Team Team { get; set; }
        public string JerseyNumber { get; set; }
    }
}