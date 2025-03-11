using CQRSSample.Domain.Entities;
using MediatR;
using System;

namespace CQRSSample.Application.Features.Products.Commands.CreateProduct
{
    public class CreateProductCommand : IRequest<int>
    {
        public string ProductCode { get; set; }
        public string Description { get; set; }
        public decimal Consumption { get; set; }
        public enComunicationType ComunicationType { get; set; }
    }
}
