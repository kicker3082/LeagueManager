using LeagueManager.Shared.Models;
using System;

namespace LeagueManager.Tryouts.Models
{
    public class TryoutEvaluation
    {
        public Person EvaluatedBy { get; set; }
        public DateTime EvaluatedOn { get; set; }
        public PlayerEvaluation Evaluation { get; set; }
    }
}