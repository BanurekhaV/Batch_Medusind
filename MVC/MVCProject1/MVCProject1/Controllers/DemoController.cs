using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCProject1.Models;

namespace MVCProject1.Controllers
{
    public class DemoController : Controller
    {
        // GET: Demo
        public ActionResult Index()
        {
            return View();
        }

        //1. Normal Method
        public string NormalMethod()
        {
            return "Hi All.. Welcome to MVC";
        }

        //2. ContentResult
        public ContentResult ContentMethod()
        {
            // return Content("Good Evening All !!!", "text/plain");
            return Content("<h1>Good Evening All !!!</h1>");
        }

        //3. Empty Result
        public EmptyResult Empty()
        {
            int amount = 45000;
            float SI = (amount * 3 * 2) / 100;
            return new EmptyResult();
        }

        //4. JsonResult
        public JsonResult Empdata() 
        {
            Employee emp = new Employee();
            emp.ID = 100;
            emp.Name = "Ajith";
            emp.Age = 28;
            return Json(emp,JsonRequestBehavior.AllowGet);
        }

        //5. ViewResult

        public ViewResult ViewMethod()
        {
            return View();
        }

        //6. RedirectResult

        public RedirectResult RedirectMethod()
        {
            // return Redirect("Empdata");
            return Redirect("~/Home/Contact");
        }

        //7. Redirect To Action
        public ActionResult RedirectAction()
        {
            // return RedirectToAction("ContentMethod", "Demo");
            return RedirectToAction("Index", "Home");
        }
    }
}