using System.Web;
using System.Web.Mvc;

namespace _1_LTUDDN_NguyenTuanAnh_100001_Tin14a6
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
