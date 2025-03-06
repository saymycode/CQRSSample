using CQRSSample.Commands;
using CQRSSample.Repository;
using MediatR;

namespace CQRSSample.Handlers.Organization
{
    public class UpdateOrganizationHandler : IRequestHandler<UpdateOrganizationCommand, CQRSSample.Models.Organization>
    {
        private readonly IRepository<CQRSSample.Models.Organization> _organizationRepository;

        public UpdateOrganizationHandler(IRepository<CQRSSample.Models.Organization> organizationRepository)
        {
            _organizationRepository = organizationRepository;
        }

        public async Task<CQRSSample.Models.Organization> Handle(UpdateOrganizationCommand request, CancellationToken cancellationToken)
        {
            var existingOrganization = await _organizationRepository.GetByIdAsync(request.Id);
            if (existingOrganization == null)
            {
                return null; // Or throw an exception based on your error handling strategy
            }

            existingOrganization.Name = request.Name; // Update properties as needed
            await _organizationRepository.UpdateAsync(existingOrganization);
            return existingOrganization;
        }
    }
}