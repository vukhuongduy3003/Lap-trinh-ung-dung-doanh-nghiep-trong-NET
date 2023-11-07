using Bai1.Models;
using System;
using System.Web.Mvc;

namespace Bai1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult TimNgay()
        {
            return View();
        }

        [HttpPost]
        public ActionResult TimNgay(TimNgay timNgay)
        {
            switch (timNgay.Thang)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    ViewBag.kq = String.Format("Có {0} ngày", 31);
                    break;

                case 4:
                case 6:
                case 9:
                case 11:
                    ViewBag.kq = String.Format("Có {0} ngày", 30);
                    break;

                case 2:
                    if ((timNgay.Nam % 4 == 0 && timNgay.Nam % 100 != 0) || timNgay.Nam % 400 == 0)
                    {
                        ViewBag.kq = String.Format("Có {0} ngày", 29);
                    }
                    else
                    {
                        ViewBag.kq = String.Format("Có {0} ngày", 28);
                    }
                    break;

                default:
                    ViewBag.kq = String.Format("Có {0} ngày", 0);
                    break;
            }
            return View(timNgay);
        }
    }
}