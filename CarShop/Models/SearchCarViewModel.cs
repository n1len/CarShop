using System.Collections.Generic;
using CarShop.Infrastructure;
using CarShop.Infrastructure.Interfaces;
using CarShop.Infrastructure.Models;

namespace CarShop.Models
{
    public class SearchCarViewModel
    {
        private readonly ICarRepository carRepository;

        public SearchCarViewModel(ICarRepository carRepository)
        {
            this.carRepository = carRepository;
        }

        public IEnumerable<Car> GetAllByQuery(string query)
        {
            return carRepository.GetAllByModelOrBrand(query);
        }

        public IEnumerable<Car> AdvancedSearch(string brand, string model, uint yearMin, uint yearMax,
            uint mileageMax, decimal priceMin, decimal priceMax,string bodyType, string engineType, double engineVolumeMin, double engineVolumeMax)
        {
            return carRepository.GetAllByAdvancedSearch(brand, model, yearMin, yearMax, mileageMax, priceMin, priceMax,bodyType,engineType,engineVolumeMin,engineVolumeMax);
        }
    }
}
