using Booking_Center.BookableApp.Application;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Booking_Center.BookableApp.API
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookingController : ControllerBase
    {
        private readonly IMediator _mediator;
        public BookingController(IMediator mediator) => _mediator = mediator;

        [HttpPost("book")]
        public async Task<IActionResult> Book([FromBody] BookCommand command)
        {
            var result = await _mediator.Send(command);
            return Ok(result);
        }

        [HttpDelete("cancel/{id}")]
        public async Task<IActionResult> Cancel(int id)
        {
            var result= await _mediator.Send(new BookDeleteCommand(id));
            if (!result) return NotFound();
            return NoContent();
        }
    }
}
