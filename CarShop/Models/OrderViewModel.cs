using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarShop.Infrastructure.Models;

namespace CarShop.Models
{
    public class OrderViewModel
    {
        public IEnumerable<Order> GetAllOrders { get; set; }
    }
}
