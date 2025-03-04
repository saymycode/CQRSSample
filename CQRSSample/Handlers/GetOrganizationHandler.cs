using CQRSSample.Models;
using MediatR;
using System.Threading;
using System.Threading.Tasks;
using static CQRSSample.Models.Organization;


namespace CQRSSample.Queries
{
    public class GetOrganizationHandler : IRequestHandler<GetOrganizationQuery, Organization>
    {
        private static Organization organization = new Organization
        {
            Id = 1,
            Name = "Organization 1",
            OrganizationType = OrganizationType.MainOrganization
        };
        public async Task<Organization> Handle(GetOrganizationQuery request, CancellationToken cancellationToken)
        {
            return await Task.FromResult(organization);
        }
    }
}
