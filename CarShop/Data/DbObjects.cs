using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarShop.Infrastructure;
using CarShop.Infrastructure.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace CarShop.Data
{
    public class DbObjects
    {
        public static void Delete(AppDBContent context, int Id)
        {
            var car = context.Cars.Where(c => c.Id == Id).FirstOrDefault();

            context.Cars.Remove(car!);

            context.SaveChanges();
        }

        public static void Add(AppDBContent context,Car car)
        {
            context.AddAsync(new Car
            {
                Brand = car?.Brand,
                Model = car?.Model,
                Description = car?.Description,
                Mileage = car.Mileage,
                Color = car?.Color,
                Year = car.Year,
                EngineVolume = car.EngineVolume,
                EngineType = car?.EngineType,
                BodyType = car?.BodyType,
                GearBox = car?.GearBox,
                DriveUnit = car?.DriveUnit,
                Price = car.Price
            });

            context.SaveChanges();
        }

        public static void DeleteOrder(AppDBContent context, int Id)
        {
            var order = context.Orders.Where(c => c.Id == Id).FirstOrDefault();

            var orderDetail = context.OrderDetails.Where(c => c.OrderId == Id).FirstOrDefault();

            context.OrderDetails.Remove(orderDetail!);

            context.SaveChanges();

            context.Orders.Remove(order!);

            context.SaveChanges();
        }
    }
}
