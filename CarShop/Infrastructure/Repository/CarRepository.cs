using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarShop.Data;
using Microsoft.EntityFrameworkCore;

namespace CarShop.Infrastructure.Repository
{
    public class CarRepository : ICarRepository
    {
        private readonly AppDBContent appDbContent;

        public CarRepository(AppDBContent appDbContent)
        {
            this.appDbContent = appDbContent;
        }

        public IEnumerable<Car> Cars => appDbContent.Cars.Include(c => c.Category);
        public IEnumerable<Car> GetAllByTitleOrBrand(string query)
        {
            return appDbContent.Cars.Where(car => car.Brand.Contains(query)
                                                  || car.Model.Contains(query)).OrderBy(i => i.Id);
        }

        public Car GetById(int id)
        {
            return appDbContent.Cars.Single(car => car.Id == id);
        }

        public IEnumerable<Car> getFavoriteCars => appDbContent.Cars.Where(p => p.IsFavorite)
            .Include(c => c.Category);
    }
}
