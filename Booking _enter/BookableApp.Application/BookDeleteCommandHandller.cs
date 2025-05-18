using Booking__enter.BookableApp.Infrastructure;
using MediatR;
using System.Threading.Tasks;

namespace Booking_Center.BookableApp.Application
{
    public class BookDeleteCommandHandller:IRequestHandler<BookDeleteCommand,int>
    {
        public readonly AppDbContext context;
        public BookDeleteCommandHandller(AppDbContext context)
        {
            this.context = context;
        }
        public async Task<int> Handle(BookDeleteCommand request,CancellationToken cancellationToken)
        {
             context.Remove(request.id);
            await context.SaveChangesAsync();

            return 1;

        }
    }
}
