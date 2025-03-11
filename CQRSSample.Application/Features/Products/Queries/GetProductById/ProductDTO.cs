using System;
using CQRSSample.Domain.Entities;

namespace CQRSSample.Application.Features.Products.Queries.GetProductById
{
    public class ProductDto
    {
        public int Id { get; set; }
        public string ProductCode { get; set; }
        public string Description { get; set; }
        public decimal Consumption { get; set; }
        public enComunicationType ComunicationType { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
