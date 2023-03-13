using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DatabaseFirstPrj.Models;
using System.Net;

namespace DatabaseFirstPrj.Controllers
{
    public class CategoryController : Controller
    {
        //create an object of the context class

        NorthwindEntities db = new NorthwindEntities();
        // GET: Category
        public ActionResult Index()
        {
            List<Category> cat = db.Categories.ToList();
            return View(cat);
        }

        //with scaffolded views
        public ActionResult GetCategories()
        {
            List<Category> catlist = db.Categories.ToList();
            return View(catlist);
        }

        //adding a new record into the category table
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Category category)
        {
            db.Categories.Add(category);
            db.SaveChanges();
            return RedirectToAction("GetCategories");
        }

        //displaying a particular record
        public ActionResult Details(int id)
        {
            Category c = db.Categories.Find(id);
            return View(c);
        }

        //Edit category
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Category c = db.Categories.Find(id);
            if (c == null)
            {
                return HttpNotFound();
            }
            return View(c);
        }

        [HttpPost]
       
        public ActionResult Edit([Bind(Exclude = "Picture")]Category c)
        {
            Category cat = db.Categories.Find(c.CategoryID);
            cat.CategoryName = c.CategoryName;
            cat.Description = c.Description;
            //cat.Picture = c.Picture;
            db.SaveChanges();
            return RedirectToAction("GetCategories");
        }

        public ActionResult Delete(int id)
        {
            Category c = db.Categories.Find(id);
            return View(c);
        }

        //delete a category
        [HttpPost]
        [ActionName("Delete")]
        public ActionResult DeletePost(int id)
        {
            Category c = db.Categories.Find(id);
            db.Categories.Remove(c);
            db.SaveChanges();
            return RedirectToAction("GetCategories");
        }

        //get category by name
        public ActionResult GetCategoryByname()
        {
            //query syntax
            List<string> catlist = (from c in db.Categories
                                    orderby c.CategoryName
                                    select c.CategoryName).ToList();

            //method syntax
           var c1 = (db.Categories.OrderBy(cn => cn.CategoryName)).ToList();
            return View(c1);
        }
    }
}
