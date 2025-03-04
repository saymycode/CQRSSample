using CQRSSample.Models;
using MediatR;

namespace CQRSSample.Queries
{
    public class GetUserQuery : IRequest<User>
    {
    }
}
