using CQRSSample.Models;
using CQRSSample.Repository;
using MediatR;


namespace CQRSSample.Queries
{
    public class GetOrganizationHandler : IRequestHandler<GetOrganizationQuery, Organization>
    {
        private readonly IRepository<CQRSSample.Models.Organization> _productRepository;

        public GetOrganizationHandler(IRepository<CQRSSample.Models.Organization> productRepository)
        {
            _productRepository = productRepository;
        }
        public async Task<CQRSSample.Models.Organization> Handle(GetOrganizationQuery request, CancellationToken cancellationToken)
        {
            var product = await _productRepository.GetByIdAsync(request.Id);
            return product;
        }
    }
}
