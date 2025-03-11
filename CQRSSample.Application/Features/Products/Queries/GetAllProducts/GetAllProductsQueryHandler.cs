using CQRSSample.Application.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace CQRSSample.Application.Features.Products.Queries.GetAllProducts
{
    public class GetAllProductsQueryHandler : IRequestHandler<GetAllProductsQuery, List<ProductListDto>>
    {
        private readonly IApplicationDbContext _context;

        public GetAllProductsQueryHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<ProductListDto>> Handle(GetAllProductsQuery request, CancellationToken cancellationToken)
        {
            return await _context.Products
                .Select(p => new ProductListDto
                {
                    Id = p.Id,
                    ProductCode = p.ProductCode,
                    Consumption = p.Consumption,
                    ComunicationType = p.ComunicationType
                })
                .ToListAsync(cancellationToken);
        }
    }
}