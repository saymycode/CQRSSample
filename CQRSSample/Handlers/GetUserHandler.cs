using CQRSSample.Models;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace CQRSSample.Queries
{
    public class GetUserHandler : IRequestHandler<GetUserQuery, User>
    {
        private static User user = new User
        {
            Id = 1,
            Username = "User_1",
            Password = "********"
        };
        public async Task<User> Handle(GetUserQuery request, CancellationToken cancellationToken)
        {
            return await Task.FromResult(user);
        }
    }
}
