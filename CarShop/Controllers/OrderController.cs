using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarShop.Data;
using CarShop.Infrastructure.Interfaces;
using CarShop.Infrastructure.Models;
using CarShop.Infrastructure.Repositories;
using CarShop.Models;
using Microsoft.AspNetCore.Authorization;

namespace CarShop.Controllers
{
    public class OrderController : Controller
    {
        private readonly IOrderRepository iOrderRepository;

        private readonly IOrderDetailRepository iOrderDetailRepository;

        private readonly ICarRepository iCarRepository;

        private readonly CartRepository cartRepository;

        private readonly AppDBContent appDbContent;

        public OrderController(IOrderRepository iOrderRepository, IOrderDetailRepository iOrderDetailRepository,
            ICarRepository iCarRepository, CartRepository cartRepository,
            AppDBContent appDbContent)
        {
            this.iOrderRepository = iOrderRepository;
            this.cartRepository = cartRepository;
            this.iOrderDetailRepository = iOrderDetailRepository;
            this.iCarRepository = iCarRepository;
            this.appDbContent = appDbContent;
        }


        public IActionResult Payment()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Payment(Order order)
        {
            cartRepository.Carts = cartRepository.GetAllItems();

            if (cartRepository.Carts.Count == 0)
            {
                ModelState.AddModelError("","У вас должны быть товары в корзине");
            }

            if (ModelState.IsValid)
            {
                iOrderRepository.CreateOrder(order);

                return RedirectToAction("Complete");
            }

            return View(order);
        }

        public IActionResult Complete()
        {
            return View();
        }

        public ViewResult Show()
        {
            IEnumerable<Order> orders = null;

            orders = iOrderRepository.Orders;

            var order = new OrderViewModel
            {
                GetAllOrders = orders
            };

            return View(order);
        }

        public ViewResult ShowDetail(int id)
        {
            IEnumerable<OrderDetail> orderDetail = null;

            orderDetail = iOrderDetailRepository.OrderDetails.Where(i => i.OrderId == id);

            var orderDetails = new OrderDetailViewModel()
            {
                GetAllOrderDetails = orderDetail,
                OrderId = id
            };

            return View(orderDetails);
        }


        public IActionResult DeleteOrder(int id)
        {
            DbObjects.DeleteOrder(appDbContent, id);

            return View();
        }
    }
}
