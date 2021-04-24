using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarShop.Data;
using CarShop.Infrastructure.Interfaces;
using CarShop.Infrastructure.Models;

namespace CarShop.Infrastructure.Repositories
{
    public class OrderRepository : IOrderRepository
    {
        private readonly AppDBContent appDbContent;

        private readonly CartRepository cartRepository;

        public OrderRepository(AppDBContent appDbContent, CartRepository cartRepository)
        {
            this.appDbContent = appDbContent;
            this.cartRepository = cartRepository;
        }

        public IEnumerable<Order> Orders => appDbContent.Orders;

        public void CreateOrder(Order order)
        {
            order.OrderTime = DateTime.Now;
            appDbContent.Orders.Add(order);
            appDbContent.SaveChanges();

            var items = cartRepository.Carts;

            foreach (var item in items)
            {
                var orderDetail = new OrderDetail
                {
                    CarId = item.MyCar.Id,
                    OrderId = order.Id,
                    Price = item.MyCar.Price
                };
                appDbContent.OrderDetails.Add(orderDetail);
            }

            appDbContent.SaveChanges();
        }
    }
}
