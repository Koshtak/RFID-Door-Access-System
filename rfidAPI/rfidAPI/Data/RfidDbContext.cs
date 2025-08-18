using Microsoft.EntityFrameworkCore;
using rfidAPI.Models;

namespace rfidAPI.Data
{
    public class RfidDbContext : DbContext
    {
        public RfidDbContext(DbContextOptions<RfidDbContext> options ) : base(options) { }
        public DbSet <AuthorizedCard> AuthorizedCards { get; set; }

    }
}
