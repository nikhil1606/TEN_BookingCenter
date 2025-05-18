using MediatR;

namespace Booking_Center.BookableApp.Application
{
    public class BookDeleteCommand:IRequest<int>
    {
        public int id { get; set; }
    }
}
