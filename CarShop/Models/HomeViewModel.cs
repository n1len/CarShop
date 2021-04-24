using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarShop.Infrastructure;

namespace CarShop.Models
{
    public class HomeViewModel
    {
        public IEnumerable<Car> FavCars { get; set; }
    }
}
