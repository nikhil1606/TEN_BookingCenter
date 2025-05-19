using MediatR;

namespace Booking_Center.BookableApp.Application
{
    public record BookDeleteCommand(int Id) : IRequest<bool>;
   
}
