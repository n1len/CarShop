using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarShop.Infrastructure;
using CarShop.Infrastructure.Models;

namespace CarShop.Models
{
    public class CarViewModel
    {
        public IEnumerable<Car> GetAllCars { get; set; }
    }
}
