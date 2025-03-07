namespace WebApplication1.Models
{
    public class Product
    {
        public int Id { get; set; }
        public required string ProductName { get; set; }
        public required string ProductDescription { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }
    }
}
