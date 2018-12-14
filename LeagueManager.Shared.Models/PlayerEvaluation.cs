using System;

namespace LeagueManager.Shared.Models
{
    public class PlayerEvaluation
    {
        public Player EvaluatedPlayer { get; set; }
        public DateTime EvaluatedOn { get; set; }
        public int TechnicalScore { get; set; }
        public int TacticalScore { get; set; }
        public int PhysicalScore { get; set; }
        public int PsychoSocialScore { get; set; }
    }
}