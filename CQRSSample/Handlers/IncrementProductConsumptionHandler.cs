using CQRSSample.Models;
using CQRSSample.Commands;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace CQRSSample.Handlers
{
    public class IncrementProductConsumptionHandler : IRequestHandler<IncrementProductConsumption, int>
    {
        private static Product product = new Product
        {
            Id = 1,
            ProductCode = "15042019",
            Consumption = 100
        };

        public Task<int> Handle(IncrementProductConsumption request, CancellationToken cancellationToken)
        {
            product.Consumption += 1;
            return Task.FromResult(product.Consumption);
        }
    }
}
