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
    public class DongVatController : Controller
    {
        private QuanLySoThuDbEntities db = new QuanLySoThuDbEntities();

        //
        // GET: /DongVat/

        public ActionResult Index()
        {
            return View(db.DONGVATs.ToList());
        }

        //
        // GET: /DongVat/Details/5

        public ActionResult Details(string id = null)
        {
            DONGVAT dongvat = db.DONGVATs.Find(id);
            if (dongvat == null)
            {
                return HttpNotFound();
            }
            return View(dongvat);
        }

        //
        // GET: /DongVat/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /DongVat/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(DONGVAT dongvat)
        {
            if (ModelState.IsValid)
            {
                db.DONGVATs.Add(dongvat);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(dongvat);
        }

        //
        // GET: /DongVat/Edit/5

        public ActionResult Edit(string id = null)
        {
            DONGVAT dongvat = db.DONGVATs.Find(id);
            if (dongvat == null)
            {
                return HttpNotFound();
            }
            return View(dongvat);
        }

        //
        // POST: /DongVat/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(DONGVAT dongvat)
        {
            if (ModelState.IsValid)
            {
                db.Entry(dongvat).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(dongvat);
        }

        //
        // GET: /DongVat/Delete/5

        public ActionResult Delete(string id = null)
        {
            DONGVAT dongvat = db.DONGVATs.Find(id);
            if (dongvat == null)
            {
                return HttpNotFound();
            }
            return View(dongvat);
        }

        //
        // POST: /DongVat/Delete/5

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            DONGVAT dongvat = db.DONGVATs.Find(id);
            db.DONGVATs.Remove(dongvat);
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