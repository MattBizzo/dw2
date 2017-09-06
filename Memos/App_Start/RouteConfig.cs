using System.Web.Mvc;
using System.Web.Routing;

namespace Memos
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "SignIn",
                url: "Entrar",
                defaults: new { controller = "Auth", action = "Index", id = UrlParameter.Optional }
            );

			routes.MapRoute(
				name: "SignOut",
				url: "Sair",
				defaults: new { controller = "Auth", action = "Delete", id = UrlParameter.Optional }
			);

            routes.MapRoute(
                name: "Memos",
                url: "Memorandos",
                defaults: new { controller = "Memos", action = "Index", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "NewMemo",
                url: "Novo",
                defaults: new { controller = "Memos", action = "New", id = UrlParameter.Optional }
            );

			routes.MapRoute(
				name: "EditMemo",
				url: "Editar",
				defaults: new { controller = "Memos", action = "Edit", id = UrlParameter.Optional }
			);

            routes.MapRoute(
                name: "Tracking",
                url: "Acompanhamento",
                defaults: new { controller = "Memos", action = "Details", id = UrlParameter.Optional }
            );

			routes.MapRoute(
				name: "Default",
				url: "{controller}/{action}/{id}",
				defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
			);
        }
    }
}
