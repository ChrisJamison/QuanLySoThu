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
    public class DieuTriController : Controller
    {
        private QuanLySoThuDbEntities db = new QuanLySoThuDbEntities();

        //
        // GET: /DieuTri/

        public ActionResult Index()
        {
            var bangdieutris = db.BANGDIEUTRIs.Include(b => b.BENH).Include(b => b.DONGVAT).Include(b => b.NHANVIEN);
            return View(bangdieutris.ToList());
        }

        //
        // GET: /DieuTri/Details/5

        public ActionResult Details(string id = null)
        {
            BANGDIEUTRI bangdieutri = db.BANGDIEUTRIs.Find(id);
            if (bangdieutri == null)
            {
                return HttpNotFound();
            }
            return View(bangdieutri);
        }

        //
        // GET: /DieuTri/Create

        public ActionResult Create()
        {
            ViewBag.MaBenh = new SelectList(db.BENHs, "MaBenh", "MaThuocDieuTri");
            ViewBag.MaDongVat = new SelectList(db.DONGVATs, "MaDongVat", "TenDongVat");
            ViewBag.MaNhanVien = new SelectList(db.NHANVIENs, "MaNhanVien", "LoaiNhanVien");
            return View();
        }

        //
        // POST: /DieuTri/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(BANGDIEUTRI bangdieutri)
        {
            if (ModelState.IsValid)
            {
                db.BANGDIEUTRIs.Add(bangdieutri);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.MaBenh = new SelectList(db.BENHs, "MaBenh", "MaThuocDieuTri", bangdieutri.MaBenh);
            ViewBag.MaDongVat = new SelectList(db.DONGVATs, "MaDongVat", "TenDongVat", bangdieutri.MaDongVat);
            ViewBag.MaNhanVien = new SelectList(db.NHANVIENs, "MaNhanVien", "LoaiNhanVien", bangdieutri.MaNhanVien);
            return View(bangdieutri);
        }

        //
        // GET: /DieuTri/Edit/5

        public ActionResult Edit(string id = null)
        {
            BANGDIEUTRI bangdieutri = db.BANGDIEUTRIs.Find(id);
            if (bangdieutri == null)
            {
                return HttpNotFound();
            }
            ViewBag.MaBenh = new SelectList(db.BENHs, "MaBenh", "MaThuocDieuTri", bangdieutri.MaBenh);
            ViewBag.MaDongVat = new SelectList(db.DONGVATs, "MaDongVat", "TenDongVat", bangdieutri.MaDongVat);
            ViewBag.MaNhanVien = new SelectList(db.NHANVIENs, "MaNhanVien", "LoaiNhanVien", bangdieutri.MaNhanVien);
            return View(bangdieutri);
        }

        //
        // POST: /DieuTri/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(BANGDIEUTRI bangdieutri)
        {
            if (ModelState.IsValid)
            {
                db.Entry(bangdieutri).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.MaBenh = new SelectList(db.BENHs, "MaBenh", "MaThuocDieuTri", bangdieutri.MaBenh);
            ViewBag.MaDongVat = new SelectList(db.DONGVATs, "MaDongVat", "TenDongVat", bangdieutri.MaDongVat);
            ViewBag.MaNhanVien = new SelectList(db.NHANVIENs, "MaNhanVien", "LoaiNhanVien", bangdieutri.MaNhanVien);
            return View(bangdieutri);
        }

        //
        // GET: /DieuTri/Delete/5

        public ActionResult Delete(string id = null)
        {
            BANGDIEUTRI bangdieutri = db.BANGDIEUTRIs.Find(id);
            if (bangdieutri == null)
            {
                return HttpNotFound();
            }
            return View(bangdieutri);
        }

        //
        // POST: /DieuTri/Delete/5

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            BANGDIEUTRI bangdieutri = db.BANGDIEUTRIs.Find(id);
            db.BANGDIEUTRIs.Remove(bangdieutri);
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