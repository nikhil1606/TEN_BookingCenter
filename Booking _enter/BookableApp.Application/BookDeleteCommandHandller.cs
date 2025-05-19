using Booking_Center.BookableApp.Infrastructure;
using MediatR;
using System.Threading.Tasks;

namespace Booking_Center.BookableApp.Application
{
    public class BookDeleteCommandHandller:IRequestHandler<BookDeleteCommand,bool>
    {
        private readonly AppDbContext _context;

        public BookDeleteCommandHandller(AppDbContext context)
        {
            _context = context;
        }

        public async Task<bool> Handle(BookDeleteCommand request, CancellationToken cancellationToken)
        {
            var member = await _context.Members.FindAsync(request.Id);

            if (member == null)
                return false;

            _context.Members.Remove(member);
            await _context.SaveChangesAsync(cancellationToken);

            return true;
        }
    }
}
