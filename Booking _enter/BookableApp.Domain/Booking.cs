namespace Booking_Center.BookableApp.Domain
{
    public class Booking
    {
      
        public int Id { get; set; }
        public int MemberId { get; set; }
        public Member Member { get; set; }
        public int InventoryItemId { get; set; }
        public InventoryItem InventoryItem { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
