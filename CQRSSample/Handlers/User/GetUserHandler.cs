using CQRSSample.Queries;
using CQRSSample.Repository;
using MediatR;

namespace CQRSSample.Handlers
{
    public class GetUserHandler : IRequestHandler<GetUserQuery, CQRSSample.Models.User>
    {
        private readonly IRepository<CQRSSample.Models.User> _userRepository;

        public GetUserHandler(IRepository<CQRSSample.Models.User> userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<CQRSSample.Models.User> Handle(GetUserQuery request, CancellationToken cancellationToken)
        {
            var user = await _userRepository.GetByIdAsync(request.UserId);
            return user;
        }
    }
}
