using System.Collections.Generic;
using LeagueManager.Leagues.Models;
using Microsoft.EntityFrameworkCore;

namespace LeagueManager.Registration.Operations.EF
{
    public class Team : ITeam
    {
        public ILeague LeagueOfTeam { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
        public string Name { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }

        public ICollection<ITeamPlayer> Players => throw new System.NotImplementedException();
    }
    public class League : ILeague
    {
        public int Id { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
        public string Name { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
        public ICollection<ITeam> TeamsWithinLeague { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
    }
    public class OperationsContext : DbContext
    {
        public OperationsContext() { }
        public OperationsContext(DbContextOptions<OperationsContext> options) : base(options) { }

        public DbSet<Team> Teams { get; set; }
        public DbSet<League> Leagues { get; set; }

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
