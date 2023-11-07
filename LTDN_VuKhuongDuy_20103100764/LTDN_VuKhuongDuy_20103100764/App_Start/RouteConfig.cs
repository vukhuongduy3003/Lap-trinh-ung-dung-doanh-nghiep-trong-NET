using System.Web.Mvc;
using System.Web.Routing;

namespace LTDN_VuKhuongDuy_20103100764
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "PhanSo", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
