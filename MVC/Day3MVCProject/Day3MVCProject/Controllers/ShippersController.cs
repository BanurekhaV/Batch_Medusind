using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Day3MVCProject.Models;

namespace Day3MVCProject.Controllers
{
    public class ShippersController : Controller
    {
        NorthwindEntities db = new NorthwindEntities();
        // GET: Shippers
        public ActionResult Index()
        {
            return View(db.Shippers.ToList());
        }

        //adding a new shipper using forms collection
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(FormCollection frm)
        {
            Shipper s = new Shipper();
            s.ShipperID = Convert.ToInt32(frm["ShipperID"]);
            s.CompanyName = frm["CompanyName"].ToString();
            s.Phone = frm["Phone"].ToString();
            db.Shippers.Add(s);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        //calling a stored procedure with input parameter
        public ActionResult CustomerOrders()
        {
            return View(db.CustOrdersOrders("AlFkI"));
        }
    }

}