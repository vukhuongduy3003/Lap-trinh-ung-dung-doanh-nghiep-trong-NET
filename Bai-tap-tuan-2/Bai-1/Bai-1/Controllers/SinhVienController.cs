using Bai_1.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web.Mvc;

namespace Bai_1.Controllers
{
    public class SinhVienController : Controller
    {
        static List<SinhVien> sinhViens = new List<SinhVien>
        {
            new SinhVien {MaSV = 1, HoTen = "Vũ Khương Duy", NgaySinh = DateTime.ParseExact("30/03/2002", "dd/MM/yyyy", CultureInfo.InvariantCulture), GioiTinh = "Nam", LopHoc = "DHTI14A1CL"},
            new SinhVien {MaSV = 2, HoTen = "Vũ Khương Duy 2", NgaySinh = DateTime.ParseExact("10/03/2002", "dd/MM/yyyy", CultureInfo.InvariantCulture), GioiTinh = "Nữ", LopHoc = "DHTI14A1CL"},
        };
        // GET: SinhVienControler
        public ActionResult Index()
        {
            return View(sinhViens);
        }

        // GET: SinhVienControler/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: SinhVienControler/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SinhVienControler/Create
        [HttpPost]
        public ActionResult Create(SinhVien sinhVien)
        {
            try
            {
                // TODO: Add insert logic here
                if (sinhViens.Count > 0)
                {
                    sinhVien.MaSV = sinhViens.Max(u => u.MaSV) + 1;
                }
                else
                {
                    sinhVien.MaSV = 1;
                }
                sinhViens.Add(sinhVien);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: SinhVienControler/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: SinhVienControler/Edit/5
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

        // GET: SinhVienControler/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: SinhVienControler/Delete/5
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
