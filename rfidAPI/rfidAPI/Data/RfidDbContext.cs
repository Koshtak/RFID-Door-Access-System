using Microsoft.EntityFrameworkCore;
using rfidAPI.Models;

namespace rfidAPI.Data
{
    public class RfidDbContext : DbContext
    {
        public RfidDbContext(DbContextOptions<RfidDbContext> options ) : base(options) { }
        public DbSet <AuthorizedCard> AuthorizedCards { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AuthorizedCard>()
                .HasIndex(c => c.CardUID)
                .IsUnique();
        }

    }
}
