using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace ProjectManagement
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "ProjectRedirect",
                url: "Project/redirecttoroute",
                defaults: new { controller = "Home", action = "About", name = UrlParameter.Optional });


            routes.MapRoute(
                name: "Project",
                url: "Project/doanaction",
                defaults: new { controller = "Project", action = "doanaction", name = UrlParameter.Optional });

            routes.MapRoute(
                name: "ProjectAlfa",
                url: "Project/{alpha}",
                defaults: new { controller = "Project", action = "Search", alpha = UrlParameter.Optional });


            routes.MapRoute(
              name: "ProjectName",
              url: "Project/HelloUser/{name}",
              defaults: new { controller = "Project", action = "HelloUser", name = UrlParameter.Optional });


            routes.MapRoute(
             name: "RedirectToHome",
             url: "ActionResult/RedirectToActionInHomeController",
             defaults: new { controller = "Home", action = "Index", name = UrlParameter.Optional });

            routes.MapRoute(
            name: "RedirectToHomeAbout",
            url: "ActionResult/RedirectToRoute",
            defaults: new { controller = "Home", action = "About", name = UrlParameter.Optional });


            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
