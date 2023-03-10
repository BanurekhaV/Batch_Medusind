using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCProject1.Models;

namespace MVCProject1.Controllers
{
    public class HRController : Controller
    {
        // GET: HR
        //Th Index action method populates list of departments and passes the list
        //to another view
        public ActionResult Index()
        {
            List<Department> deptlist = new List<Department>()
            {
                new Department{ID=10, DeptName="CSE"},
                new Department{ID=20,DeptName="IT"},
                new Department{ID=30, DeptName="ECE"},
                new Department{ID=40,DeptName="Mech"},
                new Department{ID=50, DeptName="Civil"},               
            };
            //viewname, object
              return View("ListDepartment",deptlist);
           // return View("TestAction");

        }

        //receives the populated list of departments from the Index action method and 
        //returns a view of the List collection
        public ActionResult ListDepartment(List<Department> dlist)
        {
            return View(dlist);
        }

        public ActionResult TestAction()
        {
            // return RedirectToAction("ListEmployee");
            return View();
        }
        public ActionResult ListEmployee()
        {
            List<Employee> emplist = new List<Employee>()
            {
                new Employee{ID=1, Name="Paionia",Age=21},
                new Employee{ID=2, Name="Shahul",Age=22},
                new Employee{ID=3, Name="Jonnah",Age=20},
                new Employee{ID=4, Name="Prema",Age=21},
            };
            return View(emplist);
        }

        public ActionResult ScaffoldedEmployeeList()
        {
            List<Employee> employeelist = new List<Employee>()
            {
                new Employee{ID=1, Name="Gayathri",Age=22},
                  new Employee{ID=2, Name="Kailash",Age=21},
                    new Employee{ID=3, Name="Harish",Age=21},
                      new Employee{ID=4, Name="Vignesh",Age=22},
            };
            return View(employeelist);
        }

        [ActionName("Employee")]
        public ActionResult DisplayEmployee()
        {
            Employee e = new Employee() { ID = 101, Name = "Elizabeth", Age = 21 };
            return View("DisplayEmployee",e); //specify the view name which is not the same as that of the Actionname
        }

        
    }
}