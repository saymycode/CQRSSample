using CQRSSample.Domain.Entities;

namespace CQRSSample.Application.Features.Products.Queries.GetAllProducts
{
    public class ProductListDto
    {
        public int Id { get; set; }
        public string ProductCode { get; set; }
        public decimal Consumption { get; set; }
        public enComunicationType ComunicationType{ get; set; }
    }
}