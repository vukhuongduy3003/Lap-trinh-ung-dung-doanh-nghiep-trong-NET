using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using WebApplication.Models;

namespace WebApplication.Controllers
{
    public class LoginController : Controller
    {
        static List<Login> logins = new List<Login>
        {
            new Login {Id = 1, Name = "Duy", Age = 21, Email = "vukhuongduy3003@gmail.com", Password = "123456", ReEnterPassword = "123456"},
            new Login {Id = 2, Name = "Duy 2", Age = 22, Email = "vukhuongduy3000@gmail.com", Password = "12345", ReEnterPassword = "12345"},
        };
        // GET: Login
        public ActionResult Index()
        {
            return View(logins);
        }

        // GET: Login/Details/5
        public ActionResult Details(int id)
        {
            Login login = logins.FirstOrDefault(u => u.Id == id);
            if (login == null)
            {
                return HttpNotFound();
            }
            return View(login);
        }

        // GET: Login/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Login/Create
        [HttpPost]
        public ActionResult Create(Login newLogin)
        {
            try
            {
                // TODO: Add insert logic here
                if (logins.Count > 0)
                {
                    newLogin.Id = logins.Max(u => u.Id) + 1;
                }
                else
                {
                    newLogin.Id = 1;
                }
                logins.Add(newLogin);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Login/Edit/5
        public ActionResult Edit(int id)
        {
            Login login = logins.FirstOrDefault(u => u.Id == id);
            if (login == null)
            {
                return HttpNotFound();
            }
            return View(login);
        }

        // POST: Login/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Login editLogin)
        {
            try
            {
                // TODO: Add update logic here
                int i = logins.FindIndex(u => u.Id == id);
                if (i != -1)
                {
                    return HttpNotFound();
                }
                logins[i] = editLogin;
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Login/Delete/5
        public ActionResult Delete(int id)
        {
            var deleteLogin = logins.FirstOrDefault((u) => u.Id == id);
            if (deleteLogin == null)
            {
                return HttpNotFound();
            }
            return View(deleteLogin);
        }

        // POST: Login/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, Login deleteLogin)
        {
            try
            {
                // TODO: Add delete logic here
                Login login = logins.FirstOrDefault(u => u.Id == id);
                if (login == null) { return HttpNotFound(); }
                logins.Remove(login);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
