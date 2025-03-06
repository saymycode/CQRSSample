using MediatR;

namespace CQRSSample.Commands
{
    public class DeleteProductCommand : IRequest<Unit>
    {
        public int Id { get; set; }
        public DeleteProductCommand(int id)
        {
            Id = id;
        }
    }
}