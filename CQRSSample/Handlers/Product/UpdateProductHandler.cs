using CQRSSample.Commands;
using CQRSSample.Repository;
using MediatR;

namespace CQRSSample.Handlers.Product
{
    public class UpdateProductHandler : IRequestHandler<UpdateProductCommand, Unit>
    {
        private readonly IRepository<CQRSSample.Models.Product> _productRepository;

        public UpdateProductHandler(IRepository<CQRSSample.Models.Product> productRepository)
        {
            _productRepository = productRepository;
        }

        public async Task<Unit> Handle(UpdateProductCommand request, CancellationToken cancellationToken)
        {
            var existingProduct = await _productRepository.GetByIdAsync(request.Id);
            if (existingProduct == null)
            {
                return Unit.Value; // or throw an exception based on your error handling strategy
            }

            existingProduct.Name = request.Name; // Update properties as needed
            existingProduct.Consumption = request.Consumption; // Example of updating another property

            await _productRepository.UpdateAsync(existingProduct);
            return Unit.Value;
        }
    }
}