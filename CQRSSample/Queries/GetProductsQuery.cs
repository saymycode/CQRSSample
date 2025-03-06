using CQRSSample.Models;
using MediatR;

namespace CQRSSample.Queries
{
    public class GetProductsQuery : IRequest<Product>
    {
        public GetProductsQuery()
        {
        }
    }
}