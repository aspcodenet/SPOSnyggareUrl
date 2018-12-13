using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace SnyggareUrlWeb
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");


            //routes.MapRoute(
            //name: "mappa movies och version mot home-movies",
            //url: "Home/Movies/{movieName}/{Version}",
            //defaults: new { controller = "Home", action = "Movies"
            //     }
            //);


            routes.MapRoute(
            name: "contact-us-link",
            url: "contact-us",
            defaults: new { controller = "Home", action = "Contact", id = UrlParameter.Optional }            
            );


            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );


        }
    }
}
