using Indie_Book.Migrations;
using Indie_Book.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace Indie_Book
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            // Added 2014-09-29, to automatically update the database if needed. Same as doing Update-Database in Package Manager Console.
            Database.SetInitializer<ApplicationDbContext>(
                new MigrateDatabaseToLatestVersion<ApplicationDbContext, Configuration>());
        }
    }
}
