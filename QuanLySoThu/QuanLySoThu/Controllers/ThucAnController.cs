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
    public class ThucAnController : Controller
    {
        private QuanLySoThuDbEntities db = new QuanLySoThuDbEntities();

        //
        // GET: /ThucAn/

        public ActionResult Index()
        {
            return View(db.THUCANs.ToList());
        }

        //
        // GET: /ThucAn/Details/5

        public ActionResult Details(string id = null)
        {
            THUCAN thucan = db.THUCANs.Find(id);
            if (thucan == null)
            {
                return HttpNotFound();
            }
            return View(thucan);
        }

        //
        // GET: /ThucAn/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /ThucAn/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(THUCAN thucan)
        {
            if (ModelState.IsValid)
            {
                db.THUCANs.Add(thucan);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(thucan);
        }

        //
        // GET: /ThucAn/Edit/5

        public ActionResult Edit(string id = null)
        {
            THUCAN thucan = db.THUCANs.Find(id);
            if (thucan == null)
            {
                return HttpNotFound();
            }
            return View(thucan);
        }

        //
        // POST: /ThucAn/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(THUCAN thucan)
        {
            if (ModelState.IsValid)
            {
                db.Entry(thucan).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(thucan);
        }

        //
        // GET: /ThucAn/Delete/5

        public ActionResult Delete(string id = null)
        {
            THUCAN thucan = db.THUCANs.Find(id);
            if (thucan == null)
            {
                return HttpNotFound();
            }
            return View(thucan);
        }

        //
        // POST: /ThucAn/Delete/5

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            THUCAN thucan = db.THUCANs.Find(id);
            db.THUCANs.Remove(thucan);
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