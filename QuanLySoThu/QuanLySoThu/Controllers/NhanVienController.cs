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
    public class NhanVienController : Controller
    {
        private QuanLySoThuDbEntities db = new QuanLySoThuDbEntities();

        //
        // GET: /NhanVien/

        public ActionResult Index()
        {
            return View(db.NHANVIENs.ToList());
        }

        //
        // GET: /NhanVien/Details/5

        public ActionResult Details(string id = null)
        {
            NHANVIEN nhanvien = db.NHANVIENs.Find(id);
            if (nhanvien == null)
            {
                return HttpNotFound();
            }
            return View(nhanvien);
        }

        //
        // GET: /NhanVien/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /NhanVien/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(NHANVIEN nhanvien)
        {
            if (ModelState.IsValid)
            {
                db.NHANVIENs.Add(nhanvien);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(nhanvien);
        }

        //
        // GET: /NhanVien/Edit/5

        public ActionResult Edit(string id = null)
        {
            NHANVIEN nhanvien = db.NHANVIENs.Find(id);
            if (nhanvien == null)
            {
                return HttpNotFound();
            }
            return View(nhanvien);
        }

        //
        // POST: /NhanVien/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(NHANVIEN nhanvien)
        {
            if (ModelState.IsValid)
            {
                db.Entry(nhanvien).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(nhanvien);
        }

        //
        // GET: /NhanVien/Delete/5

        public ActionResult Delete(string id = null)
        {
            NHANVIEN nhanvien = db.NHANVIENs.Find(id);
            if (nhanvien == null)
            {
                return HttpNotFound();
            }
            return View(nhanvien);
        }

        //
        // POST: /NhanVien/Delete/5

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            NHANVIEN nhanvien = db.NHANVIENs.Find(id);
            db.NHANVIENs.Remove(nhanvien);
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