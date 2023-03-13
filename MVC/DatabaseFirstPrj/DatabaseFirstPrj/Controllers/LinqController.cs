using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DatabaseFirstPrj.Models;

namespace DatabaseFirstPrj.Controllers
{
   
    public class LinqController : Controller
    {
        NorthwindEntities db = new NorthwindEntities();
        // GET: Linq
        public ActionResult Index()
        {
            return View();
        }

        //display all customers who are from germany
        public ActionResult CustomersByCountry()
        {
            List<Customer> custlist = (from c in db.Customers
                                       where c.Country == "Germany"
                                       select c).ToList();
            return View(custlist);
        }
    }
}