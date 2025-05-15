using GardenShop.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;
using GardenShop.Data; // где находится DbInitializer


namespace GardenShop
{
    public class MvcApplication : HttpApplication
    {
        protected void Application_Start()
        {
            // Включаем автоматическую инициализацию базы данных
            Database.SetInitializer(new DbInitializer());

            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
        }
    }
}