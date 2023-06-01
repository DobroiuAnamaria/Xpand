using backend.Entities;
using Microsoft.EntityFrameworkCore;

namespace backend
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options)
        {

        }

        public DbSet<Planet> Planets { get; set; }
        public DbSet<Robot> Robots { get; set; }
        public DbSet<Captain> Captains { get; set; }
        public DbSet<Team> Teams { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Team>().HasOne(t => t.Captain)
                                         .WithOne(c => c.Team)
                                         .HasForeignKey<Captain>(c => c.TeamId);

            modelBuilder.Entity<Robot>().HasOne(r => r.Team)
                                        .WithMany(t => t.Robots)
                                        .HasForeignKey(r => r.TeamId)
                                        .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
