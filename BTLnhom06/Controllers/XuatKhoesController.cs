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
    public class XuatKhoesController : Controller
    {
         QuanLyKhoDBContext db = new QuanLyKhoDBContext();
        AutoGenerateKey aukey = new AutoGenerateKey();
        // GET: XuatKhoes
        public ActionResult Index()
        {
            return View(db.XuatKhos.ToList());
        }

        // GET: XuatKhoes/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            XuatKho xuatKho = db.XuatKhos.Find(id);
            if (xuatKho == null)
            {
                return HttpNotFound();
            }
            return View(xuatKho);
        }

        // GET: XuatKhoes/Create
        public ActionResult Create()
        {
            var MPXID = db.XuatKhos.OrderByDescending(m => m.MaPhieuXuat).FirstOrDefault().MaPhieuXuat;
            var newID = aukey.GenerateKey(MPXID);
            ViewBag.NewMPXID = newID;
            return View();
        
        }

        // POST: XuatKhoes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MaPhieuXuat,NgayXuat,MaHang,SoLuong,DonGia,ThanhTien,MaNV")] XuatKho xuatKho)
        {
            if (ModelState.IsValid)
            {
                db.XuatKhos.Add(xuatKho);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(xuatKho);
        }

        // GET: XuatKhoes/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            XuatKho xuatKho = db.XuatKhos.Find(id);
            if (xuatKho == null)
            {
                return HttpNotFound();
            }
            return View(xuatKho);
        }

        // POST: XuatKhoes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MaPhieuXuat,NgayXuat,MaHang,SoLuong,DonGia,ThanhTien,MaNV")] XuatKho xuatKho)
        {
            if (ModelState.IsValid)
            {
                db.Entry(xuatKho).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(xuatKho);
        }

        // GET: XuatKhoes/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            XuatKho xuatKho = db.XuatKhos.Find(id);
            if (xuatKho == null)
            {
                return HttpNotFound();
            }
            return View(xuatKho);
        }

        // POST: XuatKhoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            XuatKho xuatKho = db.XuatKhos.Find(id);
            db.XuatKhos.Remove(xuatKho);
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
