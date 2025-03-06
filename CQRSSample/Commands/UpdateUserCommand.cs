using CQRSSample.Models;
using MediatR;

namespace CQRSSample.Commands
{
    public class UpdateUserCommand : IRequest<User>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }

        public UpdateUserCommand(int id, string name, string password)
        {
            Id = id;
            Name = name;
            Password = password;
        }
    }
}