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
    public class NVKhoesController : Controller
    {
        private QuanLyKhoDBContext db = new QuanLyKhoDBContext();

        // GET: NVKhoes
        public ActionResult Index()
        {
            return View(db.NVKhos.ToList());
        }

        // GET: NVKhoes/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NVKho nVKho = db.NVKhos.Find(id);
            if (nVKho == null)
            {
                return HttpNotFound();
            }
            return View(nVKho);
        }

        // GET: NVKhoes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: NVKhoes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MaNV,TenNV,DiaChi,SĐT")] NVKho nVKho)
        {
            if (ModelState.IsValid)
            {
                db.NVKhos.Add(nVKho);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(nVKho);
        }

        // GET: NVKhoes/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NVKho nVKho = db.NVKhos.Find(id);
            if (nVKho == null)
            {
                return HttpNotFound();
            }
            return View(nVKho);
        }

        // POST: NVKhoes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MaNV,TenNV,DiaChi,SĐT")] NVKho nVKho)
        {
            if (ModelState.IsValid)
            {
                db.Entry(nVKho).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(nVKho);
        }

        // GET: NVKhoes/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NVKho nVKho = db.NVKhos.Find(id);
            if (nVKho == null)
            {
                return HttpNotFound();
            }
            return View(nVKho);
        }

        // POST: NVKhoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            NVKho nVKho = db.NVKhos.Find(id);
            db.NVKhos.Remove(nVKho);
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
