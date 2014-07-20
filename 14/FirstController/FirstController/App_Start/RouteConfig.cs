using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace FirstController
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            
            // http://mywebsite.com/home/about
            // foo/index
            
            // products/cpu/11

            routes.MapMvcAttributeRoutes();
            
            //routes.MapRoute(
            //    name: "Products",
            //    url: "products/{category}/{id}",
            //    defaults: new
            //    {
            //        controller = "products",
            //        action = "Index",
            //        category = UrlParameter.Optional,
            //        id = 0
            //    },
            //    constraints: new { id = @"\d+" }
            //);

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new
                {
                    controller = "Home",
                    action = "Index",
                    id = UrlParameter.Optional
                }
            );
         
            
        }
    }
}
