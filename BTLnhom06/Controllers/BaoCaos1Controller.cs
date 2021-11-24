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
    public class BaoCaos1Controller : Controller
    {
        private QuanLyKhoDBContext db = new QuanLyKhoDBContext();

        // GET: BaoCaos1
        public ActionResult Index()
        {
            return View(db.BaoCaos.ToList());
        }

        // GET: BaoCaos1/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BaoCao baoCao = db.BaoCaos.Find(id);
            if (baoCao == null)
            {
                return HttpNotFound();
            }
            return View(baoCao);
        }

        // GET: BaoCaos1/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: BaoCaos1/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "DoanhThuTheoThang,DoanhThuTheoQuy,DonHangTrongNgay,DonHangTrongThang")] BaoCao baoCao)
        {
            if (ModelState.IsValid)
            {
                db.BaoCaos.Add(baoCao);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(baoCao);
        }

        // GET: BaoCaos1/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BaoCao baoCao = db.BaoCaos.Find(id);
            if (baoCao == null)
            {
                return HttpNotFound();
            }
            return View(baoCao);
        }

        // POST: BaoCaos1/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "DoanhThuTheoThang,DoanhThuTheoQuy,DonHangTrongNgay,DonHangTrongThang")] BaoCao baoCao)
        {
            if (ModelState.IsValid)
            {
                db.Entry(baoCao).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(baoCao);
        }

        // GET: BaoCaos1/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BaoCao baoCao = db.BaoCaos.Find(id);
            if (baoCao == null)
            {
                return HttpNotFound();
            }
            return View(baoCao);
        }

        // POST: BaoCaos1/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            BaoCao baoCao = db.BaoCaos.Find(id);
            db.BaoCaos.Remove(baoCao);
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
