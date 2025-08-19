using Microsoft.EntityFrameworkCore;
using rfidAPI.Models;

namespace rfidAPI.Data
{
    public class RfidDbContext : DbContext
    {
        public RfidDbContext(DbContextOptions<RfidDbContext> options) : base(options) { }

        public DbSet<Kayıt> Kayıt { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Kayıt>()
                .HasIndex(c => c.KID)
                .IsUnique();
        }
    }
}
