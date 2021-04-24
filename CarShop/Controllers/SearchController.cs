using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarShop.Infrastructure;
using CarShop.Models;

namespace CarShop.Controllers
{
    public class SearchController : Controller
    {
        public readonly SearchCarViewModel SearchCarViewModel;

        public SearchController(SearchCarViewModel searchCarViewModel)
        {
            this.SearchCarViewModel = searchCarViewModel;
        }

        public IActionResult Index(string query)
        {
            var cars = SearchCarViewModel.GetAllByQuery(query);

            return View(cars);
        }

        public IActionResult AdvancedSearch(string brand, string model, uint yearMin, uint yearMax,
            uint mileageMax, decimal priceMin, decimal priceMax,string bodyType, string engineType, double engineVolumeMin, double engineVolumeMax)
        {
            var cars = SearchCarViewModel.AdvancedSearch(brand, model, yearMin, yearMax, mileageMax, priceMin, priceMax,bodyType, engineType, engineVolumeMin, engineVolumeMax);

            return View(cars);
        }
    }
}
