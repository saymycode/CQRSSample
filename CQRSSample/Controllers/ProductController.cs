using System.Security.Cryptography;
using CQRSSample.Commands;
using CQRSSample.Models;
using CQRSSample.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CQRSSample.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ProductController(IMediator mediator)
        {
            _mediator = mediator;
        }

        // ✅ GET: /api/product (Mevcut değeri döndürür)
        [HttpGet]
        public async Task<ActionResult<Product>> Get()
        {
            var result = await _mediator.Send(new GetProductQuery());
            return Ok(result);
        }

        // ✅ POST: /api/product (Yeni değeri ayarlar)
        [HttpPost]
        public async Task<ActionResult<int>> Post()
        {
            var result = await _mediator.Send(new IncrementProductConsumption());
            return Ok(result);
        }
    }
}