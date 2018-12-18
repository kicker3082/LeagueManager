using System;

namespace LeagueManager.Shared.Models
{
    public interface ICoachCertification
    {
        ICertification Certification { get; set; }
        DateTime CertificationReceivedOn { get; set; }
        DateTime CertificationExpiresOn { get; set; }
    }
}