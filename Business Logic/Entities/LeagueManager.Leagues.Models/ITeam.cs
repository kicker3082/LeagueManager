using System;
using System.Collections.Generic;

namespace LeagueManager.Leagues.Models
{
    public interface ITeam
    {
        ILeague LeagueOfTeam { get; set; }

        string Name { get; set; }

        ICollection<ITeamPlayer> Players { get; }

        public static ITeam Null => NullTeam.Get();
    }

    public class NullTeam : ITeam
    {
        protected NullTeam() { }
        private static readonly NullTeam _single = new NullTeam();

        ILeague ITeam.LeagueOfTeam { get => ILeague.Null; set { } }
        string ITeam.Name { get => string.Empty; set { } }

        ICollection<ITeamPlayer> ITeam.Players => _players;

        private readonly static ICollection<ITeamPlayer> _players = new ITeamPlayer[0];

        public static NullTeam Get() => _single;
    }
}