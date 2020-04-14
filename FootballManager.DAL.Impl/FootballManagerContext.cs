using FootballManager.Entities;
using Microsoft.EntityFrameworkCore;

namespace FootballManager.DAL.Impl
{
    class FootballManagerContext : DbContext
    {
         public FootballManagerContext(DbContextOptions<FootballManagerContext> options) : base(options)
         {
         }

        public DbSet<Championship> Championships { get; set; }
        public DbSet<ChampionshipCommand> ChampionshipCommands { get; set; }
        public DbSet<Command> Commands { get; set; }
        public DbSet<Player> Players { get; set; }
        public DbSet<Match> Matches { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Championship>().ToTable("Championship");
            modelBuilder.Entity<ChampionshipCommand>().ToTable("ChampionshipCommand");
            modelBuilder.Entity<Command>().ToTable("Command");
            modelBuilder.Entity<Player>().ToTable("Player");
            modelBuilder.Entity<Match>().ToTable("Match");
        }
    }
}
