using System.Collections.Generic;
using LeagueManager.Leagues.Models;
using Microsoft.EntityFrameworkCore;

namespace LeagueManager.Registration.Operations.EF
{
    public class Team : ITeam
    {
        public ILeague LeagueOfTeam { get; set; } = ILeague.Null;
        public string Name { get; set; } = string.Empty;

        public ICollection<ITeamPlayer> Players { get; } = new ITeamPlayer[0];
    }
    public class League : ILeague
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public ICollection<ITeam> TeamsWithinLeague { get; } = new ITeam[0];
    }
    public class OperationsContext : DbContext
    {
        public OperationsContext() { }
        public OperationsContext(DbContextOptions<OperationsContext> options) : base(options) { }

        public DbSet<Team> Teams { get; set; } = null!;
        public DbSet<League> Leagues { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Team>()
                .HasKey(t => new { t.Name, LeagueName = t.LeagueOfTeam.Name });
            modelBuilder.Entity<Team>()
                .Property(t => t.Name)
                .HasMaxLength(120)
                .IsRequired();
            modelBuilder.Entity<Team>()
                .Property(t => t.LeagueOfTeam)
                .IsRequired();

            base.OnModelCreating(modelBuilder);
        }
    }
}
