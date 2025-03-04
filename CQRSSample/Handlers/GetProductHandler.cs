using CQRSSample.Models;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace CQRSSample.Queries
{
    public class GetProdutHandler : IRequestHandler<GetProductQuery, Product>
    {
        private static Product product = new Product
        {
            Id = 1,
            ProductCode = "15042019",
            Consumption = 100
        };
        public async Task<Product> Handle(GetProductQuery request, CancellationToken cancellationToken)
        {
            return await Task.FromResult(product);
        }
    }
}
