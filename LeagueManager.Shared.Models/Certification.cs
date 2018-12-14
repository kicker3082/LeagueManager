namespace LeagueManager.Shared.Models
{
    public class Certification
    {
        public int Id { get; set; }
        public string CertifyingAuthority { get; set; }
        public string Name { get;set; }
        public CertificationKind Kind { get; set; }
        public int Rank { get; set; }
    }
}