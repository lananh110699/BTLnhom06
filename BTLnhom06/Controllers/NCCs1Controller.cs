using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using BTLnhom06.Models;

namespace BTLnhom06.Controllers
{
    public class NCCs1Controller : Controller
    {
        private QuanLyKhoDBContext db = new QuanLyKhoDBContext();

        // GET: NCCs1
        public ActionResult Index()
        {
            return View(db.NCCs.ToList());
        }

        // GET: NCCs1/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NCC nCC = db.NCCs.Find(id);
            if (nCC == null)
            {
                return HttpNotFound();
            }
            return View(nCC);
        }

        // GET: NCCs1/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: NCCs1/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MaNCC,TenNCC,TenHang,DiaChi,SĐT")] NCC nCC)
        {
            if (ModelState.IsValid)
            {
                db.NCCs.Add(nCC);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(nCC);
        }

        // GET: NCCs1/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NCC nCC = db.NCCs.Find(id);
            if (nCC == null)
            {
                return HttpNotFound();
            }
            return View(nCC);
        }

        // POST: NCCs1/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MaNCC,TenNCC,TenHang,DiaChi,SĐT")] NCC nCC)
        {
            if (ModelState.IsValid)
            {
                db.Entry(nCC).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(nCC);
        }

        // GET: NCCs1/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NCC nCC = db.NCCs.Find(id);
            if (nCC == null)
            {
                return HttpNotFound();
            }
            return View(nCC);
        }

        // POST: NCCs1/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            NCC nCC = db.NCCs.Find(id);
            db.NCCs.Remove(nCC);
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
