using System.Web;
using System.Web.Mvc;

namespace LTDN_VuKhuongDuy_20103100764
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
