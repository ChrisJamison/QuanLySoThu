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
    public class ThuocDieuTriController : Controller
    {
        private QuanLySoThuDbEntities db = new QuanLySoThuDbEntities();

        //
        // GET: /ThuocDieuTri/

        public ActionResult Index()
        {
            return View(db.THUOCDIEUTRIs.ToList());
        }

        //
        // GET: /ThuocDieuTri/Details/5

        public ActionResult Details(string id = null)
        {
            THUOCDIEUTRI thuocdieutri = db.THUOCDIEUTRIs.Find(id);
            if (thuocdieutri == null)
            {
                return HttpNotFound();
            }
            return View(thuocdieutri);
        }

        //
        // GET: /ThuocDieuTri/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /ThuocDieuTri/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(THUOCDIEUTRI thuocdieutri)
        {
            if (ModelState.IsValid)
            {
                db.THUOCDIEUTRIs.Add(thuocdieutri);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(thuocdieutri);
        }

        //
        // GET: /ThuocDieuTri/Edit/5

        public ActionResult Edit(string id = null)
        {
            THUOCDIEUTRI thuocdieutri = db.THUOCDIEUTRIs.Find(id);
            if (thuocdieutri == null)
            {
                return HttpNotFound();
            }
            return View(thuocdieutri);
        }

        //
        // POST: /ThuocDieuTri/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(THUOCDIEUTRI thuocdieutri)
        {
            if (ModelState.IsValid)
            {
                db.Entry(thuocdieutri).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(thuocdieutri);
        }

        //
        // GET: /ThuocDieuTri/Delete/5

        public ActionResult Delete(string id = null)
        {
            THUOCDIEUTRI thuocdieutri = db.THUOCDIEUTRIs.Find(id);
            if (thuocdieutri == null)
            {
                return HttpNotFound();
            }
            return View(thuocdieutri);
        }

        //
        // POST: /ThuocDieuTri/Delete/5

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            THUOCDIEUTRI thuocdieutri = db.THUOCDIEUTRIs.Find(id);
            db.THUOCDIEUTRIs.Remove(thuocdieutri);
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