﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarShop.Infrastructure;
using Microsoft.EntityFrameworkCore;

namespace CarShop.Data
{
    public class AppDBContent : DbContext
    {
        public AppDBContent(DbContextOptions<AppDBContent> options) : base(options)
        {

        }

        public DbSet<Car> Cars { get; set; }

        public DbSet<Category> Categories { get; set; }
    }
}
