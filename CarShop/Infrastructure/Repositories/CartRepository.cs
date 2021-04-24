using System;
using System.Collections.Generic;
using System.Linq;
using CarShop.Data;
using CarShop.Infrastructure.Interfaces;
using CarShop.Infrastructure.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace CarShop.Infrastructure.Repositories
{
    public class CartRepository : ICartRepository
    {
        private readonly AppDBContent appDbContent;

        public CartRepository(AppDBContent appDbContent)
        {
            this.appDbContent = appDbContent;
        }

        public string CartId { get; set; }

        public List<Cart> Carts { get; set; }

        public static CartRepository GetCart(IServiceProvider services)
        {
            ISession session = services.GetRequiredService<IHttpContextAccessor>()?.HttpContext.Session;

            var context = services.GetService<AppDBContent>();
            string cartId = session.GetString("cartId") ?? Guid.NewGuid().ToString();

            session.SetString("cartId", cartId);

            return new CartRepository(context) {CartId = cartId};
        }

        public void Add(Car car)
        {
            appDbContent.Cart.AddAsync(new Cart
            {
                CartId = CartId,
                MyCar = car,
                Price = car.Price
            });

            appDbContent.SaveChanges();
        }

        public void Delete(string id)
        {
            var cart = appDbContent.Cart.FirstOrDefault(cart => cart.CartId == id);

            appDbContent.Cart.Remove(cart!);

            appDbContent.SaveChanges();
        }

        public Cart GetCarById(int id)
        {
            return appDbContent.Cart.FirstOrDefault(car => car.MyCar.Id == id);
        }

        public Cart GetCartById(string id)
        {
            return appDbContent.Cart.FirstOrDefault(cart => cart.CartId == id);
        }

        public List<Cart> GetAllItems()
        {
            return appDbContent.Cart.Where(c => c.CartId == CartId).Include(s => s.MyCar).ToList();
        }
    }
}