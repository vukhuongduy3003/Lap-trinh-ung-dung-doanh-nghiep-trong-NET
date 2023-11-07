using Bai_1.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web.Mvc;

namespace Bai_1.Controllers
{
    public class NhanVienController : Controller
    {
        static List<NhanVien> nhanViens = new List<NhanVien>
        {
            new NhanVien {MaNhanVien = 1, HoTen = "Vũ Khương Duy", NgaySinh = DateTime.ParseExact("30/03/2002", "dd/MM/yyyy", CultureInfo.InvariantCulture), GioiTinh = "Nam", DienThoai = "0123456789", HeSoLuong = 3, Luong = 3000, TenPhong = "Nhân sự"},
            new NhanVien {MaNhanVien = 2, HoTen = "Vũ Khương Duy 2", NgaySinh = DateTime.ParseExact("10/03/2002", "dd/MM/yyyy", CultureInfo.InvariantCulture), GioiTinh = "Nữ", DienThoai = "0987654321", HeSoLuong = 4, Luong = 5000, TenPhong = "Sale"},
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
        public ActionResult Create(NhanVien nhanVien)
        {
            try
            {
                // TODO: Add insert logic here
                if (nhanViens.Count > 0)
                {
                    nhanVien.MaNhanVien = nhanViens.Max(u => u.MaNhanVien) + 1;
                }
                else
                {
                    nhanVien.MaNhanVien = 1;
                }
                nhanViens.Add(nhanVien);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: NhanVien/Edit/5
        public ActionResult Edit(int id)
        {
            NhanVien nhanVien = nhanViens.FirstOrDefault(u => u.MaNhanVien == id);
            if (nhanVien == null)
            {
                return HttpNotFound();
            }
            return View(nhanVien);
        }

        // POST: NhanVien/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, NhanVien nhanVien)
        {
            try
            {
                // TODO: Add update logic here
                int i = nhanViens.FindIndex(u => u.MaNhanVien == id);
                if (i == -1)
                {
                    return HttpNotFound();
                }
                nhanViens[i] = nhanVien;
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
            var nhanVien = nhanViens.FirstOrDefault((u) => u.MaNhanVien == id);
            if (nhanVien == null)
            {
                return HttpNotFound();
            }
            return View(nhanVien);
        }

        // POST: NhanVien/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, NhanVien nhanVien)
        {
            try
            {
                // TODO: Add delete logic here
                NhanVien nhanVien1 = nhanViens.FirstOrDefault(u => u.MaNhanVien == id);
                if (nhanVien1 == null) { return HttpNotFound(); }
                nhanViens.Remove(nhanVien1);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
