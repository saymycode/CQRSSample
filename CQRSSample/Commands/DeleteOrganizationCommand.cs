using MediatR;

namespace CQRSSample.Commands
{
    public class DeleteOrganizationCommand : IRequest<Unit>
    {
        public int Id { get; set; }
        public DeleteOrganizationCommand(int id)
        {
            Id = id;
        }
    }
}