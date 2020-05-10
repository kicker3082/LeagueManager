using System;
using System.Collections.Generic;

namespace LeagueManager.Leagues.Models
{
    public interface ILeague
    {
        int Id { get; set; }
        string Name { get; set; }
        ICollection<ITeam> TeamsWithinLeague { get; }
        public static ILeague Null => NullLeague.Get();
    }

    public class NullLeague : ILeague
    {
        protected NullLeague() { }
        private static readonly NullLeague _single = new NullLeague();

        int ILeague.Id { get => default; set { } }
        string ILeague.Name { get => string.Empty; set { } }
        ICollection<ITeam> ILeague.TeamsWithinLeague { get => _teamsWithinLeague; }

        public static NullLeague Get() => _single;
        private static readonly ICollection<ITeam> _teamsWithinLeague = new ITeam[0];
    }
}
