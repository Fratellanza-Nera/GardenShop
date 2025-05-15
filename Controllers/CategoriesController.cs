using GardenShop.Models;
using GardenShop.Services;
using System.Web.Mvc;

namespace GardenShop.Controllers
{
    public class CategoriesController : Controller
    {
        private readonly IProductService _productService;

        public CategoriesController()
        {
            _productService = new ProductService(); // подключение BLL
        }

        public ActionResult Index(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                return RedirectToAction("Index", "Home");
            }

            var products = _productService.GetByCategory(name);
            ViewBag.CategoryName = name;
            return View(products);
        }
    }
}