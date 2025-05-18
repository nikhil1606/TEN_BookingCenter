using Booking__enter.BookableApp.Domain;
using Booking__enter.BookableApp.Infrastructure;
using MediatR;

namespace Booking__enter.BookableApp.Application
{
    public class BookCommandHandler : IRequestHandler<BookCommand, string>
    {
        private readonly AppDbContext _context;
        public BookCommandHandler(AppDbContext context) => _context = context;

        public async Task<string> Handle(BookCommand request, CancellationToken cancellationToken)
        {
            var member = await _context.Members.FindAsync(request.MemberId);
            if (member == null || member.BookingCount >= 2)
                return "Booking not allowed: limit reached or member not found.";

            var item = await _context.InventoryItems.FindAsync(request.InventoryItemId);
            if (item == null || item.RemainingCount <= 0)
                return "Booking not allowed: no inventory.";

            var booking = new Booking
            {
                MemberId = request.MemberId,
                InventoryItemId = request.InventoryItemId,
                CreatedAt = DateTime.UtcNow
            };

            _context.Bookings.Add(booking);
            member.BookingCount++;
            item.RemainingCount--;

            await _context.SaveChangesAsync();
            return $"Booking successful with ID: {booking.Id}";
        }

    }
}
