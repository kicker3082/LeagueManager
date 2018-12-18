using System;

namespace LeagueManager.Shared.Models
{
    public interface IPlayerEvaluation
    {
        IPlayer EvaluatedPlayer { get; set; }
        DateTime EvaluatedOn { get; set; }
        int TechnicalScore { get; set; }
        int TacticalScore { get; set; }
        int PhysicalScore { get; set; }
        int PsychoSocialScore { get; set; }
    }
}