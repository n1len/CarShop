using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarShop.Infrastructure;
using CarShop.Infrastructure.Models;
using CarShop.Infrastructure.Repositories;

namespace CarShop.Models
{
    public class CartViewModel
    {
        public CartRepository CartRepository { get; set; }
    }
}
