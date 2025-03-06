using CQRSSample.Commands;
using CQRSSample.Models;
using CQRSSample.Repository;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace CQRSSample.Handlers.Organization
{
    public class CreateOrganizationHandler : IRequestHandler<CreateOrganizationCommand, CQRSSample.Models.Organization>
    {
        private readonly IRepository<CQRSSample.Models.Organization> _organizationRepository;

        public CreateOrganizationHandler(IRepository<CQRSSample.Models.Organization> organizationRepository)
        {
            _organizationRepository = organizationRepository;
        }

        public async Task<CQRSSample.Models.Organization> Handle(CreateOrganizationCommand request, CancellationToken cancellationToken)
        {
            var organization = new CQRSSample.Models.Organization
            {
                Name = request.Name,
            };

            await _organizationRepository.AddAsync(organization);
            return organization;
        }
    }
}