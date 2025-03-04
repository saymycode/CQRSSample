using System.Security.Cryptography;
using CQRSSample.Commands;
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

        // ✅ GET: /api/user (Mevcut değeri döndürür)
        [HttpGet]
        public async Task<ActionResult<int>> Get()
        {
            var result = await _mediator.Send(new GetUserQuery());
            return Ok(result);
        }

        // ✅ POST: /api/user (Yeni değeri ayarlar)
        // [HttpPost]
        // public async Task<ActionResult<int>> Post()
        // {
        //     var result = await _mediator.Send(new GetUserHandler());
        //     return Ok(result);
        // }
    }
}