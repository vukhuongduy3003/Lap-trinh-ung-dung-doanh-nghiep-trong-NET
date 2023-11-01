using System.Web.Mvc;

namespace BaiTap25102023.Controllers
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
            //return View("ViewDungLayoutMacDinh");
            return View("~/Views/Home/Contact.cshtml");
        }

        public ActionResult ViewDungLayoutMacDinh()
        {
            return View();
        }

        public ActionResult ViewDungLayoutChiDinh()
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
            ViewData["NamSinh"] = 2002;
            TempData["QueQuan"] = "Hải Phòng";
            //return View();
            return Redirect("/TestView/NhanChuyenHuong");
        }

        public ActionResult NhanChuyenHuong()
        {
            return View();
        }

        public ActionResult InCacSoChanTu1Den10()
        {
            return View();
        }
    }
}