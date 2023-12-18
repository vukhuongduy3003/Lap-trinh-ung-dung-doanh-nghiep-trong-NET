using Bai_tap_tuan_3.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web.Mvc;
using static Bai_tap_tuan_3.Models.NhanVien;

namespace Bai_tap_tuan_3.Controllers
{
    public class NhanVienController : Controller
    {
        static List<NhanVien> nhanViens = new List<NhanVien>
        {
            new NhanVien { Id = 1, Name = "Vũ", Gender = GENDER.MALE, DateOfBirth = DateTime.ParseExact("30/03/2002", "dd/MM/yyyy", CultureInfo.InvariantCulture), Department = DEPARTMENT.BaoVe, HeSoLuong = (float)1.2, Luong = (float)1.2 * 1800000},
            new NhanVien { Id = 2, Name = "Khương", Gender = GENDER.FEMALE, DateOfBirth = DateTime.ParseExact("30/03/2003", "dd/MM/yyyy", CultureInfo.InvariantCulture), Department = DEPARTMENT.sale, HeSoLuong = (float)1.3, Luong = (float)1.3 * 1800000 },
            new NhanVien { Id = 3, Name = "Duy", Gender = GENDER.OTHER, DateOfBirth = DateTime.ParseExact("30/03/2004", "dd/MM/yyyy", CultureInfo.InvariantCulture), Department = DEPARTMENT.NhanSu, HeSoLuong = (float)1.4, Luong = (float)1.4 * 1800000 }
        };
        // GET: NhanVien
        public ActionResult Index()
        {
            return View(nhanViens);
        }

        // GET: NhanVien/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: NhanVien/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: NhanVien/Create
        [HttpPost]
        public ActionResult Create(NhanVien newNhanVien)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    // TODO: Add insert logic here
                    if (nhanViens.Count > 0)
                    {
                        newNhanVien.Id = nhanViens.Max(u => u.Id) + 1;
                    }
                    else
                    {
                        newNhanVien.Id = 1;
                    }
                    newNhanVien.Luong = newNhanVien.HeSoLuong * 1800000;
                    nhanViens.Add(newNhanVien);
                    return RedirectToAction("Index");
                }
                catch
                {
                    return View();
                }
            }
            return View();
        }

        // GET: NhanVien/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: NhanVien/Edit/5
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

        // GET: NhanVien/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: NhanVien/Delete/5
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
