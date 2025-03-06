using CQRSSample.Commands;
using CQRSSample.Repository;
using MediatR;

namespace CQRSSample.Handlers.Product
{
    public class DeleteProductHandler : IRequestHandler<DeleteProductCommand, Unit>
    {
        private readonly IRepository<CQRSSample.Models.Product> _productRepository;

        public DeleteProductHandler(IRepository<CQRSSample.Models.Product> productRepository)
        {
            _productRepository = productRepository;
        }

        public async Task<Unit> Handle(DeleteProductCommand request, CancellationToken cancellationToken)
        {
            await _productRepository.DeleteAsync(request.Id);
            return Unit.Value;
        }
    }
}