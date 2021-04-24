using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarShop.Infrastructure
{
    public interface ICategoryRepository
    {
        IEnumerable<Category> allCategories { get; }
    }
}
