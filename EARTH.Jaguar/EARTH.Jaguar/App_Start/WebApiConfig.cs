using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace EARTH.Jaguar
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            config.Routes.MapHttpRoute(
                name: "GetUserMessages",
                routeTemplate: "api/user/{id}/messages",
                defaults: new { id = RouteParameter.Optional, controller = "Messages", action = "GetUserMessages" }
            );

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );            
        }
    }
}
