using CQRSSample.Models;
using MediatR;

namespace CQRSSample.Commands
{
    public class CreateOrganizationCommand : IRequest<Organization>
    {
        public string Name { get; set; }

        public CreateOrganizationCommand(string name)
        {
            Name = name;
        }
    }
}