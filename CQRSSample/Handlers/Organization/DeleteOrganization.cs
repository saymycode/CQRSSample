using CQRSSample.Commands;
using CQRSSample.Repository;
using MediatR;

namespace CQRSSample.Handlers.Organization
{
    public class DeleteOrganizationHandler : IRequestHandler<DeleteOrganizationCommand, Unit>
    {
        private readonly IRepository<CQRSSample.Models.Organization> _organizationRepository;

        public DeleteOrganizationHandler(IRepository<CQRSSample.Models.Organization> organizationRepository)
        {
            _organizationRepository = organizationRepository;
        }

        public async Task<Unit> Handle(DeleteOrganizationCommand request, CancellationToken cancellationToken)
        {
            await _organizationRepository.DeleteAsync(request.Id);
            return Unit.Value;
        }
    }
}