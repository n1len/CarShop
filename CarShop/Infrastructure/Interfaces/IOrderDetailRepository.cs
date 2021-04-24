using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarShop.Infrastructure.Models;

namespace CarShop.Infrastructure.Interfaces
{
    public interface IOrderDetailRepository
    {
        IEnumerable<OrderDetail> OrderDetails { get; }
        public OrderDetail GetById(int id);

        public OrderDetail GetCarById(int id);
    }
}
