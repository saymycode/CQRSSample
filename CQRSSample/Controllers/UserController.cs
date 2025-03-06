using CQRSSample.Commands;
using CQRSSample.Models;
using CQRSSample.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CQRSSample.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IMediator _mediator;

        public UserController(IMediator mediator)
        {
            _mediator = mediator;
        }

        // ✅ GET: /api/user/{id} (Mevcut değeri döndürür)
        [HttpGet("{id}")]
        public async Task<ActionResult<User>> Get(int id)
        {
            var query = new GetUserQuery(id);
            var user = await _mediator.Send(query);
            if (user == null)
            {
                return NotFound();
            }
            return Ok(user);
        }

        // ✅ POST: /api/user (Yeni değeri ayarlar)
        [HttpPost]
        public async Task<ActionResult<int>> Post([FromBody] CreateUserCommand command)
        {
            var userId = await _mediator.Send(command);
            return CreatedAtAction(nameof(Get), new { id = userId }, userId);
        }

        // ✅ PUT: /api/user/{id} (Mevcut değeri günceller)
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, [FromBody] UpdateUserCommand command)
        {
            if (id != command.Id)
            {
                return BadRequest();
            }

            await _mediator.Send(command);
            return NoContent();
        }

        // ✅ DELETE: /api/user/{id} (Mevcut değeri siler)
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var command = new DeleteUserCommand(id);
            await _mediator.Send(command);
            return NoContent();
        }
    }
}