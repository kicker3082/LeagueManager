namespace LeagueManager.Shared.Models
{
    /// <summary>
    /// E.g.: Head Coach, Assistant Coach, Skills Coach, etc..
    /// </summary>
    public interface ICoachRole
    {
        int Id { get; set; }
        string Name { get; set; }
        /// <summary>
        /// Indicates whether this coach has the top authority on the team. Usually the head coach.
        /// </summary>
        bool IsAuthority { get; set; }
    }
}