using CQRSSample.Models;
using MediatR;

namespace CQRSSample.Queries
{
    public class GetOrganizationQuery : IRequest<Organization>
    {
    }
}
