using GardenShop.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

public class AutentificationController : Controller
{
    private readonly UserService _userService = new UserService();

    public ActionResult Login() => View();

    [HttpPost]
    public ActionResult Login(string username, string password)
    {
        if (_userService.Login(username, password))
        {
            Session["Username"] = username;
            return RedirectToAction("Index", "Home");
        }

        ViewBag.Error = "Invalid username or password.";
        return View();
    }

    public ActionResult Register() => View();

    [HttpPost]
    public ActionResult Register(string username, string password)
    {
        if (_userService.Register(username, password))
        {
            Session["Username"] = username;
            return RedirectToAction("Index", "Home");
        }

        ViewBag.Error = "Username already exists.";
        return View();
    }

    public ActionResult Logout()
    {
        Session.Clear();
        return RedirectToAction("Index", "Home");
    }
}