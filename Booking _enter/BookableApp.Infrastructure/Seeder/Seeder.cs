namespace Booking_Center.BookableApp.Infrastructure.Seeder
{
    public class Seeder
    {
        public static async Task SeedAsync(AppDbContext context)
        {
            if (!context.Members.Any())
            {
                var members = CsvLoader.LoadMembers("~/Data/members.csv");
                context.Members.AddRange(members);
            }
            if (!context.InventoryItems.Any())
            {
                var items = CsvLoader.LoadInventory("~/Data/inventory.csv");
                context.InventoryItems.AddRange(items);
            }
            await context.SaveChangesAsync();
        }
    }
}
