using System.Collections.Generic;

namespace LeagueManager.Shared.Models
{
    public interface ICoach : IPerson
    {
        ICollection<ICoachCertification> Certifications { get; set; }
    }
}