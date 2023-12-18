using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using _08_LTUDDN_VuKhuongDuy_20103100764.Models;

namespace _08_LTUDDN_VuKhuongDuy_20103100764.Controllers
{
    public class MuonTrasController : Controller
    {
        private DatabaseEntities db = new DatabaseEntities();

        // GET: MuonTras
        public ActionResult Index(int MaDG = 0)
        {
            var muonTras = db.MuonTras.Include(m => m.DocGia);
            ViewBag.MaDG = new SelectList(db.DocGias, "MaDG", "HoTen");
            if (MaDG != 0)
            {
                muonTras = muonTras.Where(k => k.MaDG == MaDG);
            }
            return View(muonTras.ToList());
        }

        public ActionResult HienThi()
        {
            var muonTras = db.MuonTras.Include(m => m.DocGia);
            return View(muonTras.ToList());
        }

        // GET: MuonTras/Details/5
        public ActionResult Details(int? id, string tensach)
        {
            if (id == null || tensach == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MuonTra muonTra = db.MuonTras.Find(id, tensach);
            if (muonTra == null)
            {
                return HttpNotFound();
            }
            return View(muonTra);
        }

        // GET: MuonTras/Create
        public ActionResult Create()
        {
            ViewBag.MaDG = new SelectList(db.DocGias, "MaDG", "HoTen");
            return View();
        }

        // POST: MuonTras/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MaDG,TenSach,NgayMuon,GiaSach")] MuonTra muonTra)
        {
            if (ModelState.IsValid)
            {
                db.MuonTras.Add(muonTra);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.MaDG = new SelectList(db.DocGias, "MaDG", "HoTen", muonTra.MaDG);
            return View(muonTra);
        }

        // GET: MuonTras/Edit/5
        public ActionResult Edit(int? id, string tensach)
        {
            if (id == null || tensach == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MuonTra muonTra = db.MuonTras.Find(id, tensach);
            if (muonTra == null)
            {
                return HttpNotFound();
            }
            ViewBag.MaDG = new SelectList(db.DocGias, "MaDG", "HoTen", muonTra.MaDG);
            return View(muonTra);
        }

        // POST: MuonTras/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MaDG,TenSach,NgayMuon,GiaSach")] MuonTra muonTra)
        {
            if (ModelState.IsValid)
            {
                db.Entry(muonTra).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.MaDG = new SelectList(db.DocGias, "MaDG", "HoTen", muonTra.MaDG);
            return View(muonTra);
        }

        // GET: MuonTras/Delete/5
        public ActionResult Delete(int? id, string tensach)
        {
            if (id == null || tensach == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MuonTra muonTra = db.MuonTras.Find(id, tensach);
            if (muonTra == null)
            {
                return HttpNotFound();
            }
            return View(muonTra);
        }

        // POST: MuonTras/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id, string tensach)
        {
            MuonTra muonTra = db.MuonTras.Find(id, tensach);
            db.MuonTras.Remove(muonTra);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
