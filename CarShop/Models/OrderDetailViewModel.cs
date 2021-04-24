using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarShop.Infrastructure.Models;

namespace CarShop.Models
{
    public class OrderDetailViewModel
    {
        public IEnumerable<OrderDetail> GetAllOrderDetails { get; set; }

        public int OrderId { get; set; }
    }
}
