using Employee.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Employee.Controllers
{
    public class NhanVienController : Controller
    {
        // GET: NhanVien
        public ActionResult Index()
        {
            var ListNV = new NhanVienDBContext().NhanViens.ToList();

            return View(ListNV);
        }

        // GET: NhanVien/Details/5
        public ActionResult Permission(int id)
        {
            var context = new NhanVienDBContext();
            var editting = context.NhanViens.Find(id);
            var ChucVuSelect = new SelectList(context.ChucVus, "Id", "TenChucVu");
            ViewBag.IdChucVu = ChucVuSelect;
            return View(editting);
        }
        [HttpPost]
        public ActionResult Permission(NhanVien model)
        {
            try
            {
                // TODO: Add update logic here
                var context = new NhanVienDBContext();
                var oldItem = context.NhanViens.Find(model.id);
                oldItem.MatKhau = model.MatKhau;
                oldItem.LaChuyenVien = model.LaChuyenVien;
                oldItem.LaQuanTri = model.LaQuanTri;
                oldItem.LaNhanVien = model.LaNhanVien;
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: NhanVien/Create
        public ActionResult Create()
        {
            var context = new NhanVienDBContext();
            var ChucVuSelect = new SelectList(context.ChucVus, "Id", "TenChucVu");
            ViewBag.IdChucVu = ChucVuSelect;
            return View();
        }

        // POST: NhanVien/Create
        [HttpPost]
        public ActionResult Create(NhanVien model)
        {
            try
            {
                // TODO: Add insert logic here
                var context = new NhanVienDBContext();
                context.NhanViens.Add(model);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: NhanVien/Edit/5
        public ActionResult Edit(int id)
        {
            var context = new NhanVienDBContext();
            var editting = context.NhanViens.Find(id);
            var ChucVuSelect = new SelectList(context.ChucVus, "Id", "TenChucVu");
            ViewBag.IdChucVu = ChucVuSelect;

            return View(editting);
        }

        // POST: NhanVien/Edit/5
        [HttpPost]
        public ActionResult Edit(NhanVien model)
        {
            try
            {
                // TODO: Add update logic here
                var context = new NhanVienDBContext();
                var oldItem = context.NhanViens.Find(model.id);
                oldItem.HoVaTen = model.HoVaTen;
                oldItem.GioiTinh = model.GioiTinh;
                oldItem.Email = model.Email;
                oldItem.IdChucVu = model.IdChucVu;
                oldItem.SoDienThoai = model.SoDienThoai;
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: NhanVien/Delete/5
        public ActionResult Delete(int id)
        {
            var context = new NhanVienDBContext();
            var deleting = context.NhanViens.Find(id);
            return View(deleting);
        }

        // POST: NhanVien/Delete/5
        [HttpPost]
        public ActionResult Delete(int id , FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
                var context = new NhanVienDBContext();
                var deleting = context.NhanViens.Find(id);
                context.NhanViens.Remove(deleting);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
