using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DHTI14A2CL.Controllers
{
    public class NgayThangController : Controller
    {
        // GET: NgayThang
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult TimNgay(int thang, int nam)
        {
            ViewBag.Thang = thang;
            ViewBag.Nam = nam;

            return View();
        }
    }
}