using CQRSSample.Commands;
using CQRSSample.Models;
using CQRSSample.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace CQRSSample.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class OrganizationController : ControllerBase
    {
        private readonly IMediator _mediator;

        public OrganizationController(IMediator mediator)
        {
            _mediator = mediator;
        }

        // GET: /api/organization/{id}
        [HttpGet("{id}")]
        public async Task<ActionResult<Organization>> Get(int id)
        {
            var query = new GetOrganizationQuery(id);
            var organization = await _mediator.Send(query);
            if (organization == null)
            {
                return NotFound();
            }
            return Ok(organization);
        }

        // POST: /api/organization
        [HttpPost]
        public async Task<ActionResult<int>> Post([FromBody] CreateOrganizationCommand command)
        {
            var organization = await _mediator.Send(command);
            return CreatedAtAction(nameof(Get), new { id = organization.Id }, organization);
        }

        // PUT: /api/organization/{id}
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, [FromBody] UpdateOrganizationCommand command)
        {
            if (id != command.Id)
            {
                return BadRequest();
            }

            var organization = await _mediator.Send(command);
            if (organization == null)
            {
                return NotFound();
            }

            return NoContent();
        }

        // DELETE: /api/organization/{id}
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var command = new DeleteOrganizationCommand(id);
            await _mediator.Send(command);
            return NoContent();
        }
    }
}