using Microsoft.EntityFrameworkCore;
using rfidAPI.Models;

namespace rfidAPI.Data
{
    public class RfidDbContext : DbContext
    {
        public RfidDbContext(DbContextOptions<RfidDbContext> options) : base(options) { }

        public DbSet<Card> Cards { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Card>()
                .HasIndex(c => c.KID)
                .IsUnique();
        }
    }
}
