namespace Booking__enter.BookableApp.Infrastructure.Seeder
{
    public class Seeder
    {
        public static async Task SeedAsync(AppDbContext context)
        {
            if (!context.Members.Any())
            {
                var members = CsvLoader.LoadMembers("members.csv");
                context.Members.AddRange(members);
            }
            if (!context.InventoryItems.Any())
            {
                var items = CsvLoader.LoadInventory("inventory.csv");
                context.InventoryItems.AddRange(items);
            }
            await context.SaveChangesAsync();
        }
    }
}
