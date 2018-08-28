using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;
using System.Web.Http;
using System.Threading;
using System.Globalization;

namespace KC.SPARTA.Web
{
    public class Global : HttpApplication
    {
        void Application_Start(object sender, EventArgs e)
        {
            // Code that runs on application startup
            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            
        }

        protected void Application_AcquireRequestState(object sender, EventArgs e)
        {
            string defaultCulture = "en-US";


            var routes = RouteTable.Routes;
            var httpContext = Request.RequestContext.HttpContext;
            if (httpContext == null) return;

            var routeData = routes.GetRouteData(httpContext);

            string lang_route = routeData.Values["lang"] as string;

            if (!string.IsNullOrEmpty(lang_route))
            {
                defaultCulture = lang_route;
            }
         
            Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo(defaultCulture);
            Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo(defaultCulture);
        }

        void Application_BeginRequest(object sender, EventArgs e)
        {

        }

    
        void Session_Start(object sender, EventArgs e)
        {

           
        }
    }
}