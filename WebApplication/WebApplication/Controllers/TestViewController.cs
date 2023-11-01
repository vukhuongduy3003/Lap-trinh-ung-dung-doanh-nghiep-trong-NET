using System.Web.Mvc;

namespace WebApplication.Controllers
{
    public class TestViewController : Controller
    {
        // GET: TestView
        public ActionResult Index()
        {
            // return View("KoDungLayout");
            return View("~/Views/Home/Contact.cshtml");
        }

        public ActionResult KoDungLayout()
        {
            return View();
        }

        public ActionResult DungLayoutChiDinh()
        {
            return View();
        }

        public ActionResult ViewChinhDungViewPhu()
        {
            return View();
        }

        public ActionResult TruyenDuLieu()
        {
            ViewBag.HoTen = "Vũ Khương Duy";
            ViewData["Tuoi"] = 21;
            TempData["QueQuan"] = "Hải Phòng";
            //return View();
            return Redirect("/TestView/NhanChuyenHuong");
        }

        public ActionResult NhanChuyenHuong()
        {
            return View();
        }

        public ActionResult TestRazor()
        {
            ViewBag.a = 10;
            return View();
        }

        public ActionResult UCLN(int a, int b)
        {
            ViewBag.a = a;
            ViewBag.b = b;
            return View();
        }

        public ActionResult FormUCLN()
        {
            return View();
        }

        public ActionResult TimUCLN(int a, int b)
        {
            int x = a, y = b;
            while (x != y)
            {
                if (x > y)
                {
                    x -= y;
                }
                else
                {
                    y -= x;
                }
            }
            return Content($"UCLN của {a} và {b} là: {x}");
        }
    }
}