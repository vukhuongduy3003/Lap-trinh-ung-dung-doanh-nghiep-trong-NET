using LTDN_VuKhuongDuy_20103100764.Models;
using System.Web.Mvc;

namespace LTDN_VuKhuongDuy_20103100764.Controllers
{
    public class PhanSoController : Controller
    {
        // GET: PhanSo
        public ActionResult Index()
        {
            return View();
        }

        // GET: PhanSo/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: PhanSo/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PhanSo/Create
        [HttpPost]
        public ActionResult Create(PhanSo phanSo)
        {
            try
            {
                // TODO: Add insert logic here
                if (phanSo.MauSo == 0)
                {
                    return Content("Không phải là phân số.");
                }
                return RedirectToAction("Index5", phanSo);
            }
            catch
            {
                return View();
            }
        }

        public ActionResult Index5(PhanSo phanSo)
        {
            int a = phanSo.TuSo;
            int b = phanSo.MauSo;
            while (a != b)
            {
                if (a > b)
                {
                    a -= b;
                }
                else
                {
                    b -= a;
                }
            }
            phanSo.TuSo = phanSo.TuSo / a;
            phanSo.MauSo = phanSo.MauSo / a;
            return View(phanSo);
        }

        // GET: PhanSo/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: PhanSo/Edit/5
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

        // GET: PhanSo/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: PhanSo/Delete/5
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
