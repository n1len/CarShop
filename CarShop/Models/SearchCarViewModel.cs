using System.Collections.Generic;
using CarShop.Infrastructure;

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
            return carRepository.GetAllByTitleOrBrand(query);
        }
    }
}
