using Booking_Center.BookableApp.Domain;
using Microsoft.EntityFrameworkCore;

namespace Booking_Center.BookableApp.Infrastructure
{
    public class AppDbContext : DbContext
    {
        public DbSet<Member> Members { get; set; }
        public DbSet<InventoryItem> InventoryItems { get; set; }
        public DbSet<Booking> Bookings { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
    }
}
