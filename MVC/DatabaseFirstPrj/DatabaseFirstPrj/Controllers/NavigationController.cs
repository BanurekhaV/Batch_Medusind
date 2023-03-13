using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DatabaseFirstPrj.Models;

namespace DatabaseFirstPrj.Controllers
{
    public class NavigationController : Controller
    {
        NorthwindEntities db = new NorthwindEntities();
        // GET: Navigation
        public ActionResult Index()
        {
            return View(db.Orders.ToList());
        }

        //to access mutliple attributes from other tables using navigation properties without joining tables
        public ActionResult MultiData()
        {
            return View(db.Orders.ToList());
        }
    }
}