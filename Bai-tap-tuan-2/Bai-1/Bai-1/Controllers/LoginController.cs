using System.Web.Mvc;

namespace Bai_1.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(string username, string password)
        {
            if (username == "admin" && password == "admin")
            {
                return View("~/Views/Home/Index.cshtml");
            }
            else
            {
                return View("~/Views/Login/Alert.cshtml");
            }
        }
    }
}