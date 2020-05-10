using LeagueManager.Shared.Models;
using System;

namespace LeagueManager.Tryouts.Models
{
    public interface ITryoutEvaluation
    {
        IPerson EvaluatedBy { get; set; }
        DateTime EvaluatedOn { get; set; }
        IPlayerEvaluation Evaluation { get; set; }
    }
}