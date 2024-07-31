using Microsoft.EntityFrameworkCore;
using PropertyApi.Models;

namespace PropertyApi.Models
{
    public class ArtContext : DbContext
    {
        public ArtContext(DbContextOptions<ArtContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Artist>()
                .HasMany(c => c.Paintings)
                .WithOne(a => a.Artist)
                .HasForeignKey(a => a.ArtistId);

            modelBuilder.Seed();    
        }

        public DbSet<Painting> Paintings { get; set; }
        public DbSet<Artist> Artists { get; set; }
    }
}