using CQRSSample.Models;
using MediatR;

namespace CQRSSample.Queries
{
    public class GetProductQuery : IRequest<Product>
    {
    }
}
