using GardenShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GardenShop.Controllers
{
    public class CategoriesController : Controller
    {
        // Симуляция БД (временный список)
        private static List<Product> AllProducts = new List<Product>
        {
            new Product { Id = 1, Name = "Apple Tree", Category = "Trees", Description = "Green apple tree", ImageUrl = "/img/AppleTree.png", Price = 25 },
            new Product { Id = 2, Name = "Cherry Blossom", Category = "Trees", Description = "Beautiful cherry blossom", ImageUrl = "/img/Cherry Blossom.png", Price = 30 },
            new Product { Id = 3, Name = "Rose", Category = "Flowers", Description = "Red rose", ImageUrl = "/img/Rose.png", Price = 10 },
            new Product { Id = 4, Name = "Shovel", Category = "Tools", Description = "Metal shovel", ImageUrl = "/img/Shovel.png", Price = 15 }
        };

        public ActionResult Index(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                return RedirectToAction("Home", "Home");
            }

            var products = AllProducts
                .Where(p => p.Category != null && p.Category.ToLower() == name.ToLower())
                .ToList();

            ViewBag.CategoryName = name;
            return View(products);
        }
    }
}