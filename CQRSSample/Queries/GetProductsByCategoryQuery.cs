using CQRSSample.Models;
using MediatR;

namespace CQRSSample.Queries
{
    public class GetProductsByCategoryQuery : IRequest<IEnumerable<Product>>
    {
        public string Category { get; }

        public GetProductsByCategoryQuery(string category)
        {
            Category = category;
        }
    }
}
