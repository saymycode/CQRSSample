using MediatR;

namespace CQRSSample.Commands
{
    public class UpdateProductCommand : IRequest<Unit>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Consumption { get; set; }
    }
}