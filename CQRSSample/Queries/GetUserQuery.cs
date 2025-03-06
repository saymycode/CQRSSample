using CQRSSample.Models;
using MediatR;

namespace CQRSSample.Queries
{
    public class GetUserQuery : IRequest<User>
    {
        public int UserId { get; set; }

        public GetUserQuery(int userId)
        {
            UserId = userId;
        }
    }
}