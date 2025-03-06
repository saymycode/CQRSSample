using CQRSSample.Commands;
using CQRSSample.Repository;
using MediatR;

namespace CQRSSample.Handlers.User
{
    public class DeleteUserHandler : IRequestHandler<DeleteUserCommand, bool>
    {
        private readonly IRepository<CQRSSample.Models.User> _userRepository;

        public DeleteUserHandler(IRepository<CQRSSample.Models.User> userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<bool> Handle(DeleteUserCommand request, CancellationToken cancellationToken)
        {
            try
            {
                await _userRepository.DeleteAsync(request.Id);
                return true;
            }
            catch (KeyNotFoundException)
            {
                return false;
            }
        }
    }
}