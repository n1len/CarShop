using CarShop.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using CarShop.Infrastructure;

namespace CarShop.Controllers
{
    public class HomeController : Controller
    {
        private ICarRepository carRepository;

        public HomeController(ICarRepository carRepository)
        {
            this.carRepository = carRepository;
        }

        public IActionResult Index()
        {
            var homeCars = new HomeViewModel
            {
                FavCars = carRepository.getFavoriteCars
            };

            return View(homeCars);
        }

    }
}
