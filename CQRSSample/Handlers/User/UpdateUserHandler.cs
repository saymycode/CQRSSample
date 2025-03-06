using CQRSSample.Commands;
using CQRSSample.Models;
using CQRSSample.Repository;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace CQRSSample.Handlers.User
{
    public class UpdateUserHandler : IRequestHandler<UpdateUserCommand, CQRSSample.Models.User>
    {
        private readonly IRepository<CQRSSample.Models.User> _userRepository;

        public UpdateUserHandler(IRepository<CQRSSample.Models.User> userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<CQRSSample.Models.User> Handle(UpdateUserCommand request, CancellationToken cancellationToken)
        {
            var existingUser = await _userRepository.GetByIdAsync(request.Id);
            if (existingUser == null)
            {
                return null;
            }

            existingUser.Name = request.Name;
            existingUser.Password = request.Password;

            await _userRepository.UpdateAsync(existingUser);
            return existingUser;
        }
    }
}