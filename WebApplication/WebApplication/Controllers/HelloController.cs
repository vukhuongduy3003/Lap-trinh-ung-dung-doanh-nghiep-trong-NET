using System.Web;
using System.Web.Mvc;

namespace WebApplication.Controllers
{
    public class HelloController : Controller
    {
        // GET: Hello
        //public ActionResult Index()
        //{
        //    return View();
        //}
        public string Index()
        {
            return "This is my <b>default</b> action...";
        }

        // 
        // GET: /HelloWorld/Welcome/ 

        //public string Welcome()
        //{
        //    return "This is the Welcome action method...";
        //}

        // 
        // GET: /Hello/Welcome/ 

        public string Welcome(string name, int id = 1)
        {
            return HttpUtility.HtmlEncode("Hello " + name + ", NumTimes is: " + id);
        }
    }
}