using CQRSSample.Models;
using MediatR;

namespace CQRSSample.Queries
{
    public class GetProductQuery : IRequest<Product>
    {
        public int Id { get; set; }

        public GetProductQuery(int id)
        {
            Id = id;
        }
        public GetProductQuery()
        {
        }
    }
}