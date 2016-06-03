using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DataModel;

namespace QuanLySoThu.Controllers
{
    public class PhanCongVeSinhController : Controller
    {
        private QuanLySoThuDbEntities db = new QuanLySoThuDbEntities();

        //
        // GET: /PhanCongVeSinh/

        public ActionResult Index()
        {
            var bangphancongvesinhs = db.BANGPHANCONGVESINHs.Include(b => b.CHUONG).Include(b => b.NHANVIEN);
            return View(bangphancongvesinhs.ToList());
        }

        //
        // GET: /PhanCongVeSinh/Details/5

        public ActionResult Details(string id = null)
        {
            BANGPHANCONGVESINH bangphancongvesinh = db.BANGPHANCONGVESINHs.Find(id);
            if (bangphancongvesinh == null)
            {
                return HttpNotFound();
            }
            return View(bangphancongvesinh);
        }

        //
        // GET: /PhanCongVeSinh/Create

        public ActionResult Create()
        {
            ViewBag.MaChuong = new SelectList(db.CHUONGs, "MaChuong", "LoaiChuong");
            ViewBag.MaNhanVien = new SelectList(db.NHANVIENs, "MaNhanVien", "LoaiNhanVien");
            return View();
        }

        //
        // POST: /PhanCongVeSinh/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(BANGPHANCONGVESINH bangphancongvesinh)
        {
            if (ModelState.IsValid)
            {
                db.BANGPHANCONGVESINHs.Add(bangphancongvesinh);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.MaChuong = new SelectList(db.CHUONGs, "MaChuong", "LoaiChuong", bangphancongvesinh.MaChuong);
            ViewBag.MaNhanVien = new SelectList(db.NHANVIENs, "MaNhanVien", "LoaiNhanVien", bangphancongvesinh.MaNhanVien);
            return View(bangphancongvesinh);
        }

        //
        // GET: /PhanCongVeSinh/Edit/5

        public ActionResult Edit(string id = null)
        {
            BANGPHANCONGVESINH bangphancongvesinh = db.BANGPHANCONGVESINHs.Find(id);
            if (bangphancongvesinh == null)
            {
                return HttpNotFound();
            }
            ViewBag.MaChuong = new SelectList(db.CHUONGs, "MaChuong", "LoaiChuong", bangphancongvesinh.MaChuong);
            ViewBag.MaNhanVien = new SelectList(db.NHANVIENs, "MaNhanVien", "LoaiNhanVien", bangphancongvesinh.MaNhanVien);
            return View(bangphancongvesinh);
        }

        //
        // POST: /PhanCongVeSinh/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(BANGPHANCONGVESINH bangphancongvesinh)
        {
            if (ModelState.IsValid)
            {
                db.Entry(bangphancongvesinh).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.MaChuong = new SelectList(db.CHUONGs, "MaChuong", "LoaiChuong", bangphancongvesinh.MaChuong);
            ViewBag.MaNhanVien = new SelectList(db.NHANVIENs, "MaNhanVien", "LoaiNhanVien", bangphancongvesinh.MaNhanVien);
            return View(bangphancongvesinh);
        }

        //
        // GET: /PhanCongVeSinh/Delete/5

        public ActionResult Delete(string id = null)
        {
            BANGPHANCONGVESINH bangphancongvesinh = db.BANGPHANCONGVESINHs.Find(id);
            if (bangphancongvesinh == null)
            {
                return HttpNotFound();
            }
            return View(bangphancongvesinh);
        }

        //
        // POST: /PhanCongVeSinh/Delete/5

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            BANGPHANCONGVESINH bangphancongvesinh = db.BANGPHANCONGVESINHs.Find(id);
            db.BANGPHANCONGVESINHs.Remove(bangphancongvesinh);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}