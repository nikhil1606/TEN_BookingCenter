using MediatR;

namespace Booking__enter.BookableApp.Application
{
    public class BookCommand : IRequest<string>
    {
        public int MemberId { get; set; }
        public int InventoryItemId { get; set; }
    }
}
