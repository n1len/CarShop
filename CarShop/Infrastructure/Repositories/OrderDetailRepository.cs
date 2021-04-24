using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarShop.Data;
using CarShop.Infrastructure.Interfaces;
using CarShop.Infrastructure.Models;

namespace CarShop.Infrastructure.Repositories
{
    public class OrderDetailRepository : IOrderDetailRepository
    {
        private readonly AppDBContent appDbContent;

        public OrderDetailRepository(AppDBContent appDbContent)
        {
            this.appDbContent = appDbContent;
        }

        public IEnumerable<OrderDetail> OrderDetails => appDbContent.OrderDetails;

        public OrderDetail GetById(int id)
        {
            return appDbContent.OrderDetails.FirstOrDefault(order => order.OrderId == id);
        }

        public OrderDetail GetCarById(int id)
        {
            return appDbContent.OrderDetails.FirstOrDefault(order => order.CarId == id);
        }
    }
}
