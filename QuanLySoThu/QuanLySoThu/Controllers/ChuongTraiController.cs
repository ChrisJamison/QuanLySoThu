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
    public class ChuongTraiController : Controller
    {
        private QuanLySoThuDbEntities db = new QuanLySoThuDbEntities();

        //
        // GET: /ChuongTrai/

        public ActionResult Index()
        {
            var chuongs = db.CHUONGs.Include(c => c.DONGVAT);
            return View(chuongs.ToList());
        }

        //
        // GET: /ChuongTrai/Details/5

        public ActionResult Details(string id = null)
        {
            CHUONG chuong = db.CHUONGs.Find(id);
            if (chuong == null)
            {
                return HttpNotFound();
            }
            return View(chuong);
        }

        //
        // GET: /ChuongTrai/Create

        public ActionResult Create()
        {
            ViewBag.MaDongVat = new SelectList(db.DONGVATs, "MaDongVat", "TenDongVat");
            return View();
        }

        //
        // POST: /ChuongTrai/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(CHUONG chuong)
        {
            if (ModelState.IsValid)
            {
                db.CHUONGs.Add(chuong);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.MaDongVat = new SelectList(db.DONGVATs, "MaDongVat", "TenDongVat", chuong.MaDongVat);
            return View(chuong);
        }

        //
        // GET: /ChuongTrai/Edit/5

        public ActionResult Edit(string id = null)
        {
            CHUONG chuong = db.CHUONGs.Find(id);
            if (chuong == null)
            {
                return HttpNotFound();
            }
            ViewBag.MaDongVat = new SelectList(db.DONGVATs, "MaDongVat", "TenDongVat", chuong.MaDongVat);
            return View(chuong);
        }

        //
        // POST: /ChuongTrai/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(CHUONG chuong)
        {
            if (ModelState.IsValid)
            {
                db.Entry(chuong).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.MaDongVat = new SelectList(db.DONGVATs, "MaDongVat", "TenDongVat", chuong.MaDongVat);
            return View(chuong);
        }

        //
        // GET: /ChuongTrai/Delete/5

        public ActionResult Delete(string id = null)
        {
            CHUONG chuong = db.CHUONGs.Find(id);
            if (chuong == null)
            {
                return HttpNotFound();
            }
            return View(chuong);
        }

        //
        // POST: /ChuongTrai/Delete/5

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            CHUONG chuong = db.CHUONGs.Find(id);
            db.CHUONGs.Remove(chuong);
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