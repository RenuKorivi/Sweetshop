using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Sweetshop.Models;

namespace Sweetshop.Controllers
{
    [Authorize(Roles = "Admin")]
    public class AddProductsController : Controller
    {
        private SweetShopContext db = new SweetShopContext();

        // GET: AddProducts
        public ActionResult Index()
        {
            var addProducts = db.AddProducts.Include(a => a.Category);
            return View(addProducts.ToList());
        }

        // GET: AddProducts/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AddProduct addProduct = db.AddProducts.Find(id);
            if (addProduct == null)
            {
                return HttpNotFound();
            }
            return View(addProduct);
        }

        // GET: AddProducts/Create
        public ActionResult Create()
        {
            ViewBag.CategoryId = new SelectList(db.Categories, "Id", "Name");
            return View();
        }

        // POST: AddProducts/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,ProductName,CategoryId,Price")] AddProduct addProduct)
        {
            if (ModelState.IsValid)
            {
                db.AddProducts.Add(addProduct);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.CategoryId = new SelectList(db.Categories, "Id", "Name", addProduct.CategoryId);
            return View(addProduct);
        }

        // GET: AddProducts/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AddProduct addProduct = db.AddProducts.Find(id);
            if (addProduct == null)
            {
                return HttpNotFound();
            }
            ViewBag.CategoryId = new SelectList(db.Categories, "Id", "Name", addProduct.CategoryId);
            return View(addProduct);
        }

        // POST: AddProducts/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,ProductName,CategoryId,Price")] AddProduct addProduct)
        {
            if (ModelState.IsValid)
            {
                db.Entry(addProduct).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.CategoryId = new SelectList(db.Categories, "Id", "Name", addProduct.CategoryId);
            return View(addProduct);
        }

        // GET: AddProducts/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AddProduct addProduct = db.AddProducts.Find(id);
            if (addProduct == null)
            {
                return HttpNotFound();
            }
            return View(addProduct);
        }

        // POST: AddProducts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            AddProduct addProduct = db.AddProducts.Find(id);
            db.AddProducts.Remove(addProduct);
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
