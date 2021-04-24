using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarShop.Infrastructure
{
    public class Car
    {
        public int Id { get; set; }

        public string Brand { get; set; }

        public string Model { get; set; }

        public string Description { get; set; }

        public decimal Price { get; set; }

        public bool IsFavorite { get; set; }

        public virtual Category Category { get; set; }
    }
}
