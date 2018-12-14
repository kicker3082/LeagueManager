using System.Collections.Generic;

namespace LeagueManager.Shared.Models
{
    public class Coach : Person
    {
        public int Id { get; set; }
        public ICollection<CoachCertification> Certifications { get; set; }
    }
}