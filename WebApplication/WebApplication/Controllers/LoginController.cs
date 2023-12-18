using System;
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
            //var kq = logins.Where(u => u.Age == 21).ToList();
            //var kq = logins.OrderByDescending(x => x.Name).Take(1);
            //TakeWhile(x => x.Age == 21) tìm đến nó không thoả mãi điều kiện thì dừng lại
            //SkipWhile(x => x.Age == 21) bỏ qua phần tử đến nó không thoả mãi điều kiện thì mới cho hiển thị các phần tử sau
            var kq = logins.OrderByDescending(x => x.Name).Skip(1);
            var sum = logins.Sum(x => x.Age); // tổng
            var avg = logins.Average(x => x.Age); // trung bình cộng
            var max = logins.Max(x => x.Age); // lớn nhất
            var min = logins.Min(x => x.Age); // nhỏ nhất
            //bool kt = logins.All(u => u.Age == 21);
            //if (kt)
            //{
            //    string s = "Tất cả mọi người đều có tuổi là 21.";
            //}
            //else
            //{
            //    string s = "có người khác tuổi 21.";
            //}
            bool kt = logins.Any(u => u.Age == 21);
            if (kt)
            {
                string s = "Tồn tại người có tuổi bằng 21";
            }
            else
            {
                string s = "Không tồn tại người có tuổi bằng 21";
            }
            return View(kq);
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
            if (ModelState.IsValid)
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
                    newLogin.Age = DateTime.Today.Year - newLogin.Birthday.Year;
                    logins.Add(newLogin);
                    return RedirectToAction("Index");
                }
                catch
                {
                    return View();
                }
            }
            return View();
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
            if (ModelState.IsValid)
            {
                try
                {
                    // TODO: Add update logic here
                    int i = logins.FindIndex(u => u.Id == id);
                    if (i == -1)
                    {
                        return HttpNotFound();
                    }
                    logins[i] = editLogin;
                    logins[i].Age = DateTime.Today.Year - logins[i].Birthday.Year;
                    return RedirectToAction("Index");
                }
                catch
                {
                    return View();
                }
            }
            return View(editLogin);
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
