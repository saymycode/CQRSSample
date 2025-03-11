using CQRSSample.Domain.Entities;
using MediatR;
using System;

namespace CQRSSample.Application.Features.Products.Commands.UpdateProduct
{
    public class UpdateProductCommand : IRequest<bool>
    {
        public int Id { get; set; }
        public string ProductCode { get; set; }
        public string Description { get; set; }
        public decimal Consumption { get; set; }
        public enComunicationType ComunicationType { get; set; }
    }
}
