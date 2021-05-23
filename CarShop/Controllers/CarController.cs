using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarShop.Data;
using CarShop.Infrastructure;
using CarShop.Infrastructure.Interfaces;
using CarShop.Infrastructure.Models;
using CarShop.Models;
using Microsoft.AspNetCore.Mvc;

namespace CarShop.Controllers
{
    public class CarController : Controller
    {
        private readonly ICarRepository carRepository;

        private readonly AppDBContent appDbContent;

        public CarController(ICarRepository carRepository,AppDBContent appDbContent)
        {
            this.carRepository = carRepository;
            this.appDbContent = appDbContent;
        }

        public ViewResult ShowPopularBrand()
        {
            return View();
        }

        public ViewResult ShowByBodyType()
        {
            return View();
        }

        public ViewResult Index(string category)
        {
            IEnumerable<Car> cars;
            cars = carRepository.Cars;

            var car = new CarViewModel
            {
                GetAllCars = cars
            };

            return View(car);
        }

        public IActionResult Show(int id)
        {
            var cars = carRepository.GetById(id);

            return View(cars);
        }

        public IActionResult GetCarsByBrand(string brand)
        {
            ViewBag.Title = brand;

            IEnumerable<Car> cars;

            cars = carRepository.Cars.Where(i => i.Brand.Equals(brand))
                .OrderBy(i => i.Id);

            var car = new CarViewModel
            {
                GetAllCars = cars
            };

            return View("ShowPopularBrand", car);
        }

        public IActionResult GetCarsByBodyType(string bodyType)
        {
            ViewBag.Title = bodyType;

            IEnumerable<Car> cars;

            cars = carRepository.Cars.Where(i => i.BodyType.Equals(bodyType))
                .OrderBy(i => i.Id);

            var car = new CarViewModel
            {
                GetAllCars = cars
            };

            return View("ShowByBodyType",car);
        }
    }
}
