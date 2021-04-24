using System.Collections.Generic;
using System.Linq;
using CarShop.Data;
using CarShop.Infrastructure.Interfaces;
using CarShop.Infrastructure.Models;

namespace CarShop.Infrastructure.Repositories
{
    public class CarRepository : ICarRepository
    {
        private readonly AppDBContent appDbContent;

        public CarRepository(AppDBContent appDbContent)
        {
            this.appDbContent = appDbContent;
        }

        public IEnumerable<Car> Cars => appDbContent.Cars;
        public IEnumerable<Car> GetAllByModelOrBrand(string query)
        {
            return appDbContent.Cars.Where(car => car.Brand.Contains(query)
                                                  || car.Model.Contains(query)).OrderBy(i => i.Id);
        }

        public IEnumerable<Car> GetAllByAdvancedSearch(string brand, string model, uint yearMin, uint yearMax, uint mileageMax,
            decimal priceMin, decimal priceMax,string bodyType,string engineType,double engineVolumeMin,double engineVolumeMax)
        {
            return appDbContent.Cars.Where(car => car.Brand == brand && car.Model.Contains(model)
                                                                     && car.Year >= yearMin && car.Year <= yearMax
                                                                     && car.Mileage <= mileageMax
                                                                     && car.Price >= priceMin && car.Price <= priceMax
                                                                     && car.BodyType == bodyType && car.EngineType == engineType
                                                                     && car.EngineVolume >= engineVolumeMin && car.EngineVolume <= engineVolumeMax )
                .OrderBy(i => i.Id);
        }

        public Car GetById(int id)
        {
            return appDbContent.Cars.Single(car => car.Id == id);
        }
    }
}
