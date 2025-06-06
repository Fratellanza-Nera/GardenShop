﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using GardenShop.Models;

namespace GardenShop.Models
{
    public class ApplicationDbContext : DbContext
    {
          public ApplicationDbContext() : base("GardenShop") { }

          public DbSet<Product> Products { get; set; }
        public DbSet<User> Users { get; set; }
    }
}