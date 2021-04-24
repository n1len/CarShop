using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarShop.Infrastructure.Models;

namespace CarShop.Infrastructure.Interfaces
{
    public interface ICartRepository
    {
        public Cart GetCarById(int id);

        public Cart GetCartById(string id);
    }
}
