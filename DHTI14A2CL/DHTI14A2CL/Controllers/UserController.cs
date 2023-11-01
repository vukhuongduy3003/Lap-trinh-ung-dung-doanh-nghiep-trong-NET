using DHTI14A2CL.Models;
using System.Collections.Generic;
using System.Web.Mvc;

namespace DHTI14A2CL.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        static List<User> users = new List<User>
        {
            new User { Id = 1, Name = "Duy", Address = "Hải Phòng", Email = "vukhuongduy@gmail.com" },
            new User { Id = 2, Name = "Duy 2", Address = "Hà Nội", Email = "vukhuongduy2@gmail.com" },
            new User { Id = 3, Name = "Duy 3", Address = "Nam Định", Email = "vukhuongduy3@gmail.com" }
        };

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult TruyenDoiTuong()
        {
            User user1 = new User();
            user1.Id = 1;
            user1.Name = "Vũ Khương Duy";
            user1.Address = "Hà Nội";
            user1.Email = "vukhuongduy3003@gmail.com";
            //ViewBag.user = user1;
            //return View();
            return View(user1);
        }

        [HttpPost]
        public ActionResult TruyenDoiTuong(User user)
        {
            string msg = $"Mã: {user.Id}, Họ tên: {user.Name}, Địa chỉ: {user.Address}, Email: {user.Email}";
            return Content(msg);
        }

        public ActionResult TruyenTapDoiTuong()
        {
            var users = new List<User>();
            var user1 = new User { Id = 1, Name = "Duy", Address = "Hải Phòng", Email = "vukhuongduy@gmail.com" };
            var user2 = new User { Id = 2, Name = "Duy 2", Address = "Hà Nội", Email = "vukhuongduy2@gmail.com" };
            var user3 = new User { Id = 3, Name = "Duy 3", Address = "Nam Định", Email = "vukhuongduy3@gmail.com" };
            users.Add(user1);
            users.Add(user2);
            users.Add(user3);
            //ViewBag.users = users;
            //return View();
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
