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
                name: "GetNewUserMessages",
                routeTemplate: "api/user/{userName}/messages/{last}",
                defaults: new { controller = "Messages", action = "GetNewUserMessages" }
            );

            config.Routes.MapHttpRoute(
                name: "GetOldUserMessages",
                routeTemplate: "api/user/{userName}/old_messages/{last}",
                defaults: new { controller = "Messages", action = "GetOldUserMessages" }
            );

            config.Routes.MapHttpRoute(
                name: "GetNewPublicMessages",
                routeTemplate: "api/public_messages/{last}",
                defaults: new { controller = "PublicMessages", action = "GetNewPublicMessages" }
            );

            config.Routes.MapHttpRoute(
                name: "GetOldPublicMessages",
                routeTemplate: "api/old_public_messages/{last}",
                defaults: new { controller = "PublicMessages", action = "GetOldPublicMessages" }
            );

            config.Routes.MapHttpRoute(
                name: "GetYearsByUser",
                routeTemplate: "api/user/{userName}/years",
                defaults: new { controller = "Years", action = "GetYearsByUser" }
            );

            config.Routes.MapHttpRoute(
                name: "GetPeriodsByYearAndUser",
                routeTemplate: "api/user/{userName}/year/{year}/periods",
                defaults: new { controller = "Periods", action = "GetPeriodsByYearAndUser" }
            );

            config.Routes.MapHttpRoute(
                name: "GetGrades",
                routeTemplate: "api/user/{userName}/year/{year}/period/{period}/grades",
                defaults: new { controller = "Grades", action = "GetGrades" }
            );

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );            
        }
    }
}
