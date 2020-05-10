namespace LeagueManager.Shared.Models
{
    public interface ICertification
    {
        string CertifyingAuthority { get; set; }
        string Name { get;set; }
        ICertificationKind Kind { get; set; }
        int Rank { get; set; }
    }
}