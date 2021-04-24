using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarShop.Data;

namespace CarShop.Infrastructure.Repository
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly AppDBContent appDbContent;

        public CategoryRepository(AppDBContent appDbContent)
        {
            this.appDbContent = appDbContent;
        }

        public IEnumerable<Category> allCategories => appDbContent.Categories;
    }
}
