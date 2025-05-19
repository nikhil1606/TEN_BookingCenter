using MediatR;

namespace Booking_Center.BookableApp.Application
{
    public class BookCommand : IRequest<string>
    {
        public int MemberId { get; set; }
        public int InventoryItemId { get; set; }
    }
}
