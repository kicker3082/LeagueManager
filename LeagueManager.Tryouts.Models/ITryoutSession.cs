using System;
using System.Collections.Generic;

namespace LeagueManager.Tryouts.Models
{
    public interface ITryoutSession
    {
        DateTime ScheduledFor { get; set; }
        ICollection<ITryoutRegistration> Registrations { get; set; }
        ICollection<ITryoutPlayer> Players { get; set; }

    }
}