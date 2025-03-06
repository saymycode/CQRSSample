using CQRSSample.Commands;
using CQRSSample.Models;
using CQRSSample.Repository;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace CQRSSample.Handlers.User
{
    public class CreateUserHandler : IRequestHandler<CreateUserCommand, CQRSSample.Models.User>
    {
        private readonly IRepository<CQRSSample.Models.User> _userRepository;

        public CreateUserHandler(IRepository<CQRSSample.Models.User> userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<CQRSSample.Models.User> Handle(CreateUserCommand request, CancellationToken cancellationToken)
        {
            var user = new CQRSSample.Models.User
            {
                Id = request.Id,
                Name = request.Name,
                Password = request.Password
            };

            await _userRepository.AddAsync(user);
            return user;
        }
    }
}