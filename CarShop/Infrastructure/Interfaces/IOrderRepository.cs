using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarShop.Infrastructure.Models;

namespace CarShop.Infrastructure.Interfaces
{
    public interface IOrderRepository
    {
        IEnumerable<Order> Orders { get; }

        public void CreateOrder(Order order);
    }
}
