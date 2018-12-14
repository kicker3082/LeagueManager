using LeagueManager.Shared.Models;
using System;
using System.Collections.Generic;

namespace LeagueManager.Tryouts.Models
{
    public class TryoutSession
    {
        public DateTime ScheduledFor { get; set; }
        public ICollection<TryoutRegistration> Registrations { get; set; }
        public ICollection<TryoutPlayer> Players { get; set; }

    }
    public class TryoutRegistration
    {
        public DateTime RegisteredOn { get; set; }
        public TryoutPlayer Player { get; set; }

    }
    public class TryoutPlayer : Player
    {
        public DateTime TryoutOn { get; set; }
        public bool WasPresent { get; set; }
        public bool WasLate { get; set; }
        public string Pinnie { get; set; }
        public TryoutEvaluation Result { get; set; }

    }
}