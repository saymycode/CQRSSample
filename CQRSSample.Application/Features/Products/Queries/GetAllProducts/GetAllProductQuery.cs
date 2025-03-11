using MediatR;
using System.Collections.Generic;

namespace CQRSSample.Application.Features.Products.Queries.GetAllProducts
{
    public class GetAllProductsQuery : IRequest<List<ProductListDto>>
    {
    }
}
