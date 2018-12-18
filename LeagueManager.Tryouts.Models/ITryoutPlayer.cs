using LeagueManager.Shared.Models;
using System;

namespace LeagueManager.Tryouts.Models
{
    public interface ITryoutPlayer : IPlayer
    {
        DateTime TryoutOn { get; set; }
        bool WasPresent { get; set; }
        bool WasLate { get; set; }
        string Pinnie { get; set; }
        ITryoutEvaluation Result { get; set; }

    }
}