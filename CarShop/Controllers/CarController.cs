using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarShop.Data;
using CarShop.Infrastructure;
using CarShop.Models;
using Microsoft.AspNetCore.Mvc;

namespace CarShop.Controllers
{
    public class CarController : Controller
    {
        private readonly ICarRepository carRepository;

        private readonly ICategoryRepository categoryRepository;

        private readonly AppDBContent appDbContent;

        public CarController(ICarRepository carRepository, ICategoryRepository categoryRepository,AppDBContent appDbContent)
        {
            this.categoryRepository = categoryRepository;
            this.carRepository = carRepository;
            this.appDbContent = appDbContent;
        }

        public ViewResult Electro()
        {
            IEnumerable<Car> cars = null;

            cars = carRepository.Cars.Where(i => i.Category.CategoryName.Equals("Электромобили"))
                .OrderBy(i => i.Id);
            string currentCategory = "Электромобили";

            var car = new CarViewModel
            {
                GetAllCars = cars,
                CurrentCategory = currentCategory
            };

            return View(car);
        }

        public ViewResult Fuel()
        {
            IEnumerable<Car> cars = null;

            cars = carRepository.Cars.Where(i => i.Category.CategoryName.Equals("Машины на дизеле/бензине") || 
                                                 i.Category.CategoryName.Equals("Машины на дизеле") ||
                                                     i.Category.CategoryName.Equals("Машины на бензине"))
                .OrderBy(i => i.Id);
            string currentCategory = "Машины на дизеле/бензине";

            var car = new CarViewModel
            {
                GetAllCars = cars,
                CurrentCategory = currentCategory
            };

            return View(car);
        }

        public ViewResult Index(string category)
        {
            string _category = category;
            IEnumerable<Car> cars = null;
            string currentCategory = "";

            if (string.IsNullOrEmpty(category))
            {
                cars = carRepository.Cars.OrderBy(i => i.Id);
            }

            var car = new CarViewModel
            {
                GetAllCars = cars,
                CurrentCategory = currentCategory
            };

            return View(car);
        }

        public IActionResult Show(int id)
        {
            var cars = carRepository.GetById(id);

            return View(cars);
        }

        public IActionResult Delete(int id)
        {
            DbObjects.Delete(appDbContent, id);

            return View();
        }

        public IActionResult Add()
        {
            DbObjects.Add(appDbContent);

            return View();
        }

        public ViewResult Petrol()
        {
            IEnumerable<Car> cars = null;

            cars = carRepository.Cars.Where(i => i.Category.CategoryName.Equals("Машины на бензине"))
                .OrderBy(i => i.Id);
            string currentCategory = "Машины на бензине";

            var car = new CarViewModel
            {
                GetAllCars = cars,
                CurrentCategory = currentCategory
            };

            return View(car);
        }

        public ViewResult Diesel()
        {
            IEnumerable<Car> cars = null;

            cars = carRepository.Cars.Where(i => i.Category.CategoryName.Equals("Машины на дизеле"))
                .OrderBy(i => i.Id);
            string currentCategory = "Машины на дизеле";

            var car = new CarViewModel
            {
                GetAllCars = cars,
                CurrentCategory = currentCategory
            };

            return View(car);
        }
    }
}
