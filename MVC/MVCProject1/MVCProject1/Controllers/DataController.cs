using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCProject1.Controllers
{
    public class DataController : Controller
    {
        // GET: Data
        public ActionResult Index()
        {
            //return View();
            return RedirectToAction("TestAction", "HR");
        }

        //1. ViewBag and ViewData 
        public ActionResult EmployeeRules()
        {
            List<string> rules = new List<string>()
            {
                "Avoid T-Shirts", "Carry Your ID Card","Be on Time",
                "Only Formals"
            };

            //a. thru ViewBag
            ViewBag.getRules = rules;

            //b. thru ViewData
            ViewData["followrules"] = rules;
             return View();
          //  return RedirectToAction("GetData");
        }

        public ActionResult GetData()
        {
            return View();
        }

        //1. Using the TempData in each and every action method by recalling
        public ActionResult FirstRequest()
        {
            List<string> Flowerlist = new List<string>()
            {
                "Roses","Jasmine","Lilies","Mogras","Chrysanthimum"
            };

            TempData["flowers"] = Flowerlist;
            // return View();
            //   return View("SecondRequest", TempData["flowers"]); // this stops at the secondrequest
            //because we are asking to show the view of secondrequest
            return RedirectToAction("SRequest");
        }

        public ActionResult SRequest()
        {
           // List<string> lstflw = TempData["flowers"] as List<string>;
            return RedirectToAction("TRequest");
        }

        public ActionResult TRequest()
        {
            // List<string> tlist = TempData["flowers"] as List<string>;
            return RedirectToAction("Index");
        }
        public ActionResult SecondRequest(List<string> flwlist)
        {
            TempData.Keep();
            // return View(flwlist);
            return View("ThirdRequest", flwlist);
               
        }

        public ActionResult ThirdRequest(List<string> lstflowers)
        {
            return View(lstflowers);
        }


    }
}