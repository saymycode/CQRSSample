// filepath: /CQRSSample/CQRSSample/Queries/GetOrganizationQuery.cs
using CQRSSample.Models;
using MediatR;

namespace CQRSSample.Queries
{
    public class GetOrganizationQuery : IRequest<Organization>
    {
        public int Id { get; }

        public GetOrganizationQuery(int id)
        {
            Id = id;
        }
    }
}