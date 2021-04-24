namespace CarShop.Infrastructure.Models
{
    public class Cart
    {
        public int Id { get; set; }

        public Car MyCar { get; set; }

        public decimal Price { get; set; }

        public string CartId { get; set; }
    }
}
