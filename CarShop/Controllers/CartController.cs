using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarShop.Infrastructure;
using CarShop.Infrastructure.Interfaces;
using CarShop.Infrastructure.Repositories;
using CarShop.Models;

namespace CarShop.Controllers
{
    public class CartController : Controller
    {
        private readonly ICarRepository iCarRepository;
        private readonly CartRepository _cartRepository;

        public CartController(ICarRepository iCarRepository, CartRepository cartRepository)
        {
            this.iCarRepository = iCarRepository;
            this._cartRepository = cartRepository;
        }

        public ViewResult Index()
        {
            var items = _cartRepository.GetAllItems();
            _cartRepository.Carts = items;

            var cartViewModel = new CartViewModel
            {
                CartRepository = _cartRepository
            };

            return View(cartViewModel);
        }

        public ViewResult AddPage()
        {
            return View();
        }

        public RedirectToActionResult Add(int id)
        {
            var item = iCarRepository.Cars.FirstOrDefault(i => i.Id == id);
            if(item != null)
                _cartRepository.Add(item);

            return RedirectToAction("AddPage");
        }

        public RedirectToActionResult Delete(string id)
        {
            _cartRepository.Delete(id);

            return RedirectToAction("Index");
        }
    }
}
