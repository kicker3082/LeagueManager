namespace LeagueManager.Shared.Models
{
    /// <summary>
    /// E.g.: Head Coach, Assistant Coach, Skills Coach, etc..
    /// </summary>
    public class CoachRole
    {
        public int Id { get; set; }
        public string Name { get; set; }
        /// <summary>
        /// Indicates whether this coach has the top authority on the team. Usually the head coach.
        /// </summary>
        public bool IsAuthority { get; set; }
    }
}