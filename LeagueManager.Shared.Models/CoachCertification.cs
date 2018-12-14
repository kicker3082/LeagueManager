using System;

namespace LeagueManager.Shared.Models
{
    public class CoachCertification
    {
        public int Id { get; set; }
        public Certification Certification { get; set; }
        public DateTime CertificationReceivedOn { get; set; }
        public DateTime CertificationExpiresOn { get; set; }
    }
}