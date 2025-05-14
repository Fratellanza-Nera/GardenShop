using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc;

namespace GardenShop.Controllers
{
    public class AutentificationController : Controller
    {
        // GET: /Autentification/Login
        public ActionResult Login()
        {
            return View();
        }

        // GET: /Autentification/Register
        public ActionResult Register()
        {
            return View();
        }

        // POST: /Autentification/Login
        [HttpPost]
        public ActionResult Login(string username, string password)
        {
            // Здесь логика авторизации
            if (username == "admin" && password == "admin")
                return RedirectToAction("Index", "Home");

            ViewBag.Error = "Invalid credentials";
            return View();
        }

        // POST: /Autentification/Register
        [HttpPost]
        public ActionResult Register(string username, string password)
        {
            // Здесь логика регистрации (например, сохранить в БД)
            ViewBag.Message = "Account created!";
            return RedirectToAction("Login");
        }
    }
}