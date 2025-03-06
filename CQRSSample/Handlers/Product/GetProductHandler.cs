using CQRSSample.Repository;
using CQRSSample.Queries;
using MediatR;

namespace CQRSSample.Handlers
{
    public class GetProductHandler : IRequestHandler<GetProductQuery, CQRSSample.Models.Product>
    {
        private readonly IRepository<CQRSSample.Models.Product> _productRepository;

        public async Task<List<CQRSSample.Models.Product>> GetAllProducts(IRepository<CQRSSample.Models.Product> productRepository)
        {
            var products = await productRepository.GetAllAsync();
            return (List<Models.Product>)products;
        }

        public async Task<CQRSSample.Models.Product> Handle(GetProductQuery request, CancellationToken cancellationToken)
        {
            var product = await _productRepository.GetByIdAsync(request.Id);
        
            return product;
        }
    }
}