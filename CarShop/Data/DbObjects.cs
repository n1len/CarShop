using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarShop.Infrastructure;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace CarShop.Data
{
    public class DbObjects
    {
        private static Dictionary<string, Category> categoriesDictionary;

        public static void Initial(AppDBContent content)
        {

            if (!content.Categories.Any())
                content.Categories.AddRange(Categories.Select(c => c.Value));

            if (!content.Cars.Any())
                content.AddRange(
                    new Car
                        {
                            Brand = "Mercedes-Bens",
                            Model = "GLC",
                            Description = "Современный авто",
                            IsFavorite = false,
                            Price = 30436000m,
                            Category = Categories["Машины на бензине"]
                        }
                );

            content.SaveChanges();
        }

        public static void Delete(AppDBContent content, int intId)
        {
            var car = content.Cars.Where(c => c.Id == intId).FirstOrDefault();

            content.Cars.Remove(car!);

            content.SaveChanges();
        }

        public static void Add(AppDBContent content)
        {
            content.AddRange(
                new Car
                {
                    Brand = "Mercedes-Bens",
                    Model = "CLS",
                    Description = "Современный авто",
                    IsFavorite = true,
                    Price = 1436000m,
                    Category = Categories["Машины на бензине"]
                }
            );

            content.SaveChanges();
        }

        public static Dictionary<string, Category> Categories
        {
            get
            {
                if (categoriesDictionary == null)
                {
                    var list = new Category[]
                    {
                        new Category
                        {
                            CategoryName = "Машины на бензине",
                            Description = "Машины с двигателем внутреннего сгорания"
                        },
                        new Category
                        {
                            CategoryName = "Машины на дизеле",
                            Description = "Машины с двигателем внутреннего сгорания"
                        },
                    };
                    categoriesDictionary = new Dictionary<string, Category>();

                    foreach (var category in list)
                        categoriesDictionary.Add(category.CategoryName,category);
                }

                return categoriesDictionary;
            }
        }
    }
}
