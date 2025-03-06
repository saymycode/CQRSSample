using CQRSSample.Commands;
using CQRSSample.Repository;
using MediatR;

namespace CQRSSample.Handlers.Product
{
    public class CreateProductHandler : IRequestHandler<CreateProductCommand, CQRSSample.Models.Product>
    {
        private readonly IRepository<CQRSSample.Models.Product> _productRepository;

        public CreateProductHandler(IRepository<CQRSSample.Models.Product> productRepository)
        {
            _productRepository = productRepository;
        }

        public async Task<CQRSSample.Models.Product> Handle(CreateProductCommand request, CancellationToken cancellationToken)
        {
            var product = new CQRSSample.Models.Product
            {
                Consumption = request.Consumption,
                Description = request.Description,
                Name = request.Name,
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow
            };

            await _productRepository.AddAsync(product);
            return product;
        }
    }
}