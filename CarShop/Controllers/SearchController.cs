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
    }
}
