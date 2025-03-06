using CQRSSample.Models;
using MediatR;

namespace CQRSSample.Commands
{
    public class CreateUserCommand : IRequest<User>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }

        public CreateUserCommand(int id, string name, string password)
        {
            Id = id;
            Name = name;
            Password = password;
        }
    }
}