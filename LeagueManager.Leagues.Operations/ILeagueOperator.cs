using LeagueManager.Leagues.Models;

namespace LeagueManager.Leagues.Operations
{
    public interface ILeagueOperator
    {
        League CreateNewLeague(string nameOfNewLeague);
        Team CreateNewTeamInLeague(League leagueToCreateNewTeamIn, string nameOfNewTeam);
        void RemoveTeamFromLeague(Team teamToRemoveFromLeague);
    }
}
