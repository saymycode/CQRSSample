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

        // ✅ GET: /api/product (Tüm ürünleri döndürür)
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Product>>> GetAll()
        {
            var query = new GetProductsQuery();
            var products = await _mediator.Send(query);
            return Ok(products);
        }

        // ✅ GET: /api/product/{id} (Mevcut değeri döndürür)
        [HttpGet("{id}")]
        public async Task<ActionResult<Product>> Get(int id)
        {
            var query = new GetProductQuery(id);
            var product = await _mediator.Send(query);
            if (product == null)
            {
                return NotFound();
            }
            return Ok(product);
        }

        // ✅ POST: /api/product (Yeni değeri ayarlar)
        [HttpPost]
        public async Task<ActionResult<Product>> Post([FromBody] CreateProductCommand command)
        {
            var product = await _mediator.Send(command);
            return CreatedAtAction(nameof(Get), new { id = product.Id }, product);
        }

        // ✅ PUT: /api/product/{id} (Mevcut değeri günceller)
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, [FromBody] UpdateProductCommand command)
        {
            if (id != command.Id)
            {
                return BadRequest();
            }

            await _mediator.Send(command);
            return NoContent();
        }

        // ✅ DELETE: /api/product/{id} (Mevcut değeri siler)
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var command = new DeleteProductCommand(id);
            await _mediator.Send(command);
            return NoContent();
        }
    }
}