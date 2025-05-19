namespace Booking_Center.BookableApp.Domain
{
    public class InventoryItem
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int RemainingCount { get; set; }
        public DateTime ExpirationDate { get; set; }
        public ICollection<Booking> Bookings { get; set; }
    }
}
