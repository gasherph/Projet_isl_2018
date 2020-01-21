using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace Burger2Home_ISL_Project
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                //name: "Accueille.aspx",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
