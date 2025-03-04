using MediatR;

namespace CQRSSample.Commands
{
    public class IncrementProductConsumption : IRequest<int>
    {
    }
}
