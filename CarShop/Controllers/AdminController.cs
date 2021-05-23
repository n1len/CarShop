using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarShop.Data;
using CarShop.Infrastructure;
using CarShop.Infrastructure.Interfaces;
using CarShop.Infrastructure.Models;
using CarShop.Infrastructure.Repositories;
using Microsoft.AspNetCore.Authorization;

namespace CarShop.Controllers
{
    [Authorize]
    public class AdminController : Controller
    {
        private readonly IOrderRepository iOrderRepository;

        private readonly IOrderDetailRepository iOrderDetailRepository;

        private readonly ICartRepository iCartRepository;

        private readonly AppDBContent appDbContent;

        public AdminController(AppDBContent appDbContent, ICartRepository iCartRepository,
            IOrderRepository iOrderRepository, IOrderDetailRepository iOrderDetailRepository)
        {
            this.iCartRepository = iCartRepository;
            this.iOrderRepository = iOrderRepository;
            this.iOrderDetailRepository = iOrderDetailRepository;
            this.appDbContent = appDbContent;
        }

        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(Car car)
        {
            if (ModelState.IsValid)
            {
                DbObjects.Add(appDbContent, car);

                return RedirectToAction("AddSuccess");
            }
            return View(car);
        }

        public IActionResult Delete(int id)
        {
            if (iCartRepository.GetCarById(id) != null)
            {
                return RedirectToAction("ErrorMessageCart");
            }

            if (iOrderDetailRepository.GetCarById(id) != null)
            {
                return RedirectToAction("ErrorMessage");
            }

            if (ModelState.IsValid)
            {
                DbObjects.Delete(appDbContent, id);

                return View();
            }

            return View();
        }

        public IActionResult AddSuccess()
        {
            return View();
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ErrorMessage()
        {
            return View();
        }

        public IActionResult ErrorMessageCart()
        {
            return View();
        }
    }
}
