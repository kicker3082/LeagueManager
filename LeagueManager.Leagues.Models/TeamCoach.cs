using LeagueManager.Shared.Models;

namespace LeagueManager.Leagues.Models
{
    public class TeamCoach : Coach
    {
        public Team Team { get; set; }
        public string JerseyNumber { get; set; }
    }
}