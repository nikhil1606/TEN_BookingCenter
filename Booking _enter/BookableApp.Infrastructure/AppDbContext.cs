using Booking__enter.BookableApp.Domain;
using Microsoft.EntityFrameworkCore;

namespace Booking__enter.BookableApp.Infrastructure
{
    public class AppDbContext : DbContext
    {
        public DbSet<Member> Members { get; set; }
        public DbSet<InventoryItem> InventoryItems { get; set; }
        public DbSet<Booking> Bookings { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
    }
}
