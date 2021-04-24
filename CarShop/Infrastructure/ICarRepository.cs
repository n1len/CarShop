using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarShop.Infrastructure
{
    public interface ICarRepository
    {
        IEnumerable<Car> Cars { get; }

        IEnumerable<Car> GetAllByTitleOrBrand(string query);
        Car GetById(int id);

        IEnumerable<Car> getFavoriteCars { get; }
    }
}
