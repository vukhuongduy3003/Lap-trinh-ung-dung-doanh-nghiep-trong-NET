using System.Collections.Generic;
using System.Web.Mvc;
using WebApplication.Models;

namespace WebApplication.Controllers
{
    public class UserController : Controller
    {
        static List<User> users = new List<User>();
        // GET: User
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Index1()
        {
            User user = new User();
            user.Id = 1;
            user.Name = "Vũ Khương Duy";
            user.Address = "Hải Phòng";
            user.Email = "vukhuongduy3003@gmail.com";
            ViewBag.user = user;
            return View();
        }

        public ActionResult Index4()
        {
            User user = new User();
            user.Id = 1;
            user.Name = "Vũ Khương Duy";
            user.Address = "Hải Phòng";
            user.Email = "vukhuongduy3003@gmail.com";
            return View(user);
        }

        [HttpPost]
        public ActionResult Index4(User user)
        {
            return Content(string.Format("User Id: {0}<br /> User Name: {1}<br /> User Address: {2}<br /> User Email: {3}", user.Id, user.Name, user.Address, user.Email));
        }

        public ActionResult Index2()
        {
            var users = new List<User>();
            var user1 = new User { Id = 1, Name = "Duy", Address = "HP", Email = "duy@gmail.com" };
            var user2 = new User { Id = 2, Name = "Duy 2", Address = "HN", Email = "duy2@gmail.com" };
            users.Add(user1);
            users.Add(user2);
            ViewBag.users = users;
            return View();
        }

        public ActionResult Index3()
        {
            var users = new List<User>();
            var user1 = new User { Id = 1, Name = "Duy", Address = "HP", Email = "duy@gmail.com" };
            var user2 = new User { Id = 2, Name = "Duy 2", Address = "HN", Email = "duy2@gmail.com" };
            users.Add(user1);
            users.Add(user2);
            return View(users);
        }

        public ActionResult Index5()
        {
            var users = new List<User>();
            var user1 = new User { Id = 1, Name = "Duy", Address = "HP", Email = "duy@gmail.com" };
            var user2 = new User { Id = 2, Name = "Duy 2", Address = "HN", Email = "duy2@gmail.com" };
            users.Add(user1);
            users.Add(user2);
            return View(users);
        }

        // GET: User/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: User/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: User/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: User/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: User/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: User/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: User/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
