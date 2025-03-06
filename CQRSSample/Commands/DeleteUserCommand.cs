// filepath: /CQRSSample/CQRSSample/Commands/DeleteUserCommand.cs
using MediatR;

namespace CQRSSample.Commands
{
    public class DeleteUserCommand : IRequest<bool>
    {
        public int Id { get; }

        public DeleteUserCommand(int id)
        {
            Id = id;
        }
    }
}