using LeagueManager.Leagues.Models;

namespace LeagueManager.Leagues.Operations
{
    public interface ILeagueOperator
    {
        ILeague CreateNewLeague(string nameOfNewLeague);
        ITeam CreateNewTeamInLeague(ILeague leagueToCreateNewTeamIn, string nameOfNewTeam);
        void RemoveTeamFromLeague(ITeam teamToRemoveFromLeague);
        public static ILeagueOperator Null => NullLeagueOperator.Get();
    }

    public class NullLeagueOperator : ILeagueOperator
    {
        protected NullLeagueOperator() { }
        private static readonly NullLeagueOperator _single = new NullLeagueOperator();
        public static NullLeagueOperator Get() => _single;

        ILeague ILeagueOperator.CreateNewLeague(string nameOfNewLeague) => ILeague.Null;

        ITeam ILeagueOperator.CreateNewTeamInLeague(ILeague leagueToCreateNewTeamIn, string nameOfNewTeam) => ITeam.Null;

        void ILeagueOperator.RemoveTeamFromLeague(ITeam teamToRemoveFromLeague) { }
    }
}
