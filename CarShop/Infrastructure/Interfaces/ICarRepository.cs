using System.Collections.Generic;
using CarShop.Infrastructure.Models;

namespace CarShop.Infrastructure.Interfaces
{
    public interface ICarRepository
    {
        IEnumerable<Car> Cars { get; }

        IEnumerable<Car> GetAllByModelOrBrand(string query);

        IEnumerable<Car> GetAllByAdvancedSearch(string brand,string model,uint yearMin,uint yearMax,
            uint mileageMax,decimal priceMin,decimal priceMax,string bodyType, string engineType, double engineVolumeMin, double engineVolumeMax);
        Car GetById(int id);
    }
}
