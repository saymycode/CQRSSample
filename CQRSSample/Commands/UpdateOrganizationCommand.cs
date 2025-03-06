using CQRSSample.Models;
using MediatR;

namespace CQRSSample.Commands
{
    public class UpdateOrganizationCommand : IRequest<Organization>
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}