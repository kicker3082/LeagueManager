using LeagueManager.Leagues.Models;

namespace LeagueManager.Leagues.Operations
{
    public interface ILeagueOperator
    {
        ILeague CreateNewLeague(string nameOfNewLeague);
        ITeam CreateNewTeamInLeague(ILeague leagueToCreateNewTeamIn, string nameOfNewTeam);
        void RemoveTeamFromLeague(ITeam teamToRemoveFromLeague);
    }
}
