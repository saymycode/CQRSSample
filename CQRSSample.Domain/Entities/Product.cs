using System;

namespace CQRSSample.Domain.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public string ProductCode { get; set; }
        public string Description { get; set; }
        public decimal Consumption { get; set; }
        public enComunicationType ComunicationType { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
    public enum enComunicationType
    {
        Unknown = 0,
        LoRa = 1,
        NBIOT = 2,
        GPRS = 3
    }
}
