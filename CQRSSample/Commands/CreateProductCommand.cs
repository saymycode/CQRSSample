// filepath: /CQRSSample/CQRSSample/Commands/CreateProductCommand.cs
using MediatR;
using CQRSSample.Models;

namespace CQRSSample.Commands
{
    public class CreateProductCommand : IRequest<Product>
    {
        public string Name { get; set; }
        public decimal Consumption { get; set; }
        public string Description { get; set; }

        public CreateProductCommand(string name, string description, decimal consumption)
        {
            Name = name;
            Consumption = consumption;
            Description = description;
        }
    }
}