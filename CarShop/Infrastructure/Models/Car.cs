namespace CarShop.Infrastructure.Models
{
    public class Car
    {
        public int Id { get; set; }

        public string Model { get; set; }

        public string Description { get; set; }

        public uint Mileage { get; set; }

        public string Color { get; set; }

        public uint Year { get; set; }

        public double EngineVolume { get; set; }

        public string Brand { get; set; }

        public string BodyType { get; set; }

        public string EngineType { get; set; }

        public string GearBox { get; set; }

        public string DriveUnit { get; set; }
        public decimal Price { get; set; }
    }
}
