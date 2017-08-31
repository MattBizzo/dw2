using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Memorandos
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");


            routes.MapRoute(
                name: "SignIn",
                url: "Entrar",
                defaults: new { controller = "Home", action = "SignIn", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Memos",
                url: "Memorandos",
                defaults: new { controller = "Home", action = "Memos", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "NewMemo",
                url: "Novo",
                defaults: new { controller = "Home", action = "NewMemo", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Tracking",
                url: "Acompanhamento",
                defaults: new { controller = "Home", action = "Tracking", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Show",
                url: "Visao",
                defaults: new { controller = "Home", action = "Show", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
