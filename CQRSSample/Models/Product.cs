namespace CQRSSample.Models
{
    public class Product
    {
        public int Id  { get; set; }
        public required string ProductCode  { get; set; }
        public int Consumption { get; set; }
    }
}