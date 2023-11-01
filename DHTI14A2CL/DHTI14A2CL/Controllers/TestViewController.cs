using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DHTI14A2CL.Controllers
{
    public class TestViewController : Controller
    {
        // GET: TestView
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult ViewKhongDungLayout()
        {
            return View();
        }
        public ActionResult ViewDungLayout()
        {
            /*return View("ViewKhongDungLayout");*/
            return View("~/Views/Home/Contact.cshtml");
        }
        public ActionResult ViewDungLayoutChiDinh()
        {
            return View();
        }
        public ActionResult ViewDungLayoutChinh()
        {
            return View();
        }
        public ActionResult TruyenDuLieu()
        {
            ViewBag.HoTen = "Nguyễn Đức Tùng";
            ViewData["NamSinh"] = 2002;
            TempData["QueQuan"] = "Hà Nội";
            return RedirectToAction("NhanChuyenHuong");
            /*return Redirect("/TestView/NhanChuyenHuong");*/
        }
        public ActionResult NhanChuyenHuong()
        {
           
            return View();
        }
        public ActionResult Incacsochan()
        {

            return View();
        }

        public ActionResult UCLN()
        {
            
            return View();
        }
        [HttpPost]
        public ActionResult UCLN(int a, int b)
        {
            String msg = string.Format("a = {0}, b = {1}",a,b);
            int x = a;
            int y = b;
            while (x != y)
            {
                if (x > y)
                {
                    x = x - y;
                }
                else
                {
                    y = y - x;
                }
            }
            msg = string.Format("UCLN của {0} và {1} là {2}", a, b,x);
            msg = $"UCLN là {a} và {b} là {x}";
            return Content(msg);
        }
        public ActionResult TestHTML()
        {
            return View();
        }
    }
}