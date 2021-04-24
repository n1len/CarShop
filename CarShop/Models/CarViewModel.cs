using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarShop.Infrastructure;

namespace CarShop.Models
{
    public class CarViewModel
    {
        public IEnumerable<Car> GetAllCars { get; set; }

        public string CurrentCategory { get; set; }
    }
}
