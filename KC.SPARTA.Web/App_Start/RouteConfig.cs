using System.Web.Mvc;
using System.Web.Routing;

namespace KC.SPARTA.Web
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
              name: "Default",
              url: "{controller}/{action}",
              defaults: new { controller = "Home", action = "Index" }
          );

            routes.MapRoute(
                name: "DefaultLang",
                url: "{lang}/{controller}/{action}",
                defaults: new {controller = "Home", action = "Index", lang ="en-US"}
            );

           
        }
    }
}
