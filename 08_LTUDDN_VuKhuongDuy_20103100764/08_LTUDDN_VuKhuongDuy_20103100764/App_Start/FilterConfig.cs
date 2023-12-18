using System.Web;
using System.Web.Mvc;

namespace _08_LTUDDN_VuKhuongDuy_20103100764
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
