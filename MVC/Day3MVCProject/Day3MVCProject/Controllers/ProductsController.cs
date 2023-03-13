using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Day3MVCProject.Models;
using System.Data.Entity;

namespace Day3MVCProject.Controllers
{
    public class ProductsController : Controller
    {
        NorthwindEntities db = new NorthwindEntities();
        // GET: Products

        //understanding eager loading
        public ActionResult Index()
        {
            var products = db.Products.Include(p => p.Category).Include(p => p.Supplier);
            return View(products.ToList());
            // return View(db.Products.ToList());
        }

        //create
        [HttpGet]
        public ActionResult Create()
        {
            ViewBag.CategoryID = new SelectList(db.Categories, "CategoryID", "CategoryName");
            ViewBag.SupplieriD = new SelectList(db.Suppliers, "SupplierID", "CompanyName");
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Product product)
        {
            if (ModelState.IsValid)
            {
                db.Products.Add(product);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            //for dropdown data
            ViewBag.CategoryID = new SelectList(db.Categories, "CategoryID", "CategoryName", product.CategoryID);
            ViewBag.SupplierID = new SelectList(db.Suppliers, "SupplierID", "CompanyName", product.SupplierID);
            return View(product);
        }

    }
}