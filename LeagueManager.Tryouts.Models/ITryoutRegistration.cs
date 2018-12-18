using System;

namespace LeagueManager.Tryouts.Models
{
    public interface ITryoutRegistration
    {
        DateTime RegisteredOn { get; set; }
        ITryoutPlayer Player { get; set; }

    }
}