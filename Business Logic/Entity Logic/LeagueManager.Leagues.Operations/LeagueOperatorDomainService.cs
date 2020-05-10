using System;
using System.Collections.Concurrent;
using LeagueManager.Leagues.Models;

namespace LeagueManager.Leagues.Operations
{
    public class LeagueOperatorDomainService : ILeagueOperator
    {
        #region Strings
        public static class Strings
        {
            public static readonly string LeagueNameEmptyErrorMessage = "The name cannot be empty.";
            public static readonly string TeamWithNameAlreadyExists = "A team with that name already exists.";
            public static readonly string TeamOfNameDoesNotExist = "That team does not exist.";
        }

        #endregion

        private static readonly ConcurrentDictionary<string, ITeam> teams = new ConcurrentDictionary<string, ITeam>();

        private Func<ITeam> Teambuilder { get; }

        public LeagueOperatorDomainService(Func<ITeam> teambuilder) {
            Teambuilder = teambuilder;
        }

        ILeague ILeagueOperator.CreateNewLeague(string nameOfNewLeague)
        {
            if (nameOfNewLeague.Length == 0)
                throw new ArgumentException(Strings.LeagueNameEmptyErrorMessage, nameof(nameOfNewLeague));

            return ILeague.Null;
        }

        ITeam ILeagueOperator.CreateNewTeamInLeague(ILeague leagueToCreateNewTeamIn, string nameOfNewTeam)
        {
            var newTeam = Teambuilder();
            newTeam.Name = nameOfNewTeam;

            if (!teams.TryAdd(nameOfNewTeam, newTeam))
                throw new InvalidOperationException(Strings.TeamWithNameAlreadyExists);

            return newTeam;
        }

        void ILeagueOperator.RemoveTeamFromLeague(ITeam teamToRemoveFromLeague)
        {
            if (!teams.TryRemove(teamToRemoveFromLeague.Name, out _))
                throw new InvalidOperationException(Strings.TeamOfNameDoesNotExist);
        }
    }
}