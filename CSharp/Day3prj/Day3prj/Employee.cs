using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3prj
{
    class Employee
    {
        int Empid;   
        string EmpName;
        float EmpSalary;
        DateTime DOJ;

        public Employee()   // 1. empty constructor
        {
            Empid = 100;
            EmpName = "Rishan";
            EmpSalary = 40000.50f;
            DOJ = Convert.ToDateTime("09/02/2023");
        }

        public Employee(int eid,string ename,float esal)   //2 constructor with parameters
        {
            Empid = eid;
            EmpName = ename;
            EmpSalary = esal;           
        }
        public void GetEmployee()
        {
           // Console.WriteLine($"Employee Id :{Empid}, Name : {EmpName}, Salary : {EmpSalary} and Date of Joining :{DOJ}");
            Console.WriteLine("Enter Emp Id, Name,Salary and DOJ :");
            Empid = Convert.ToInt32(Console.ReadLine());
            EmpName = Console.ReadLine();
            EmpSalary = Convert.ToSingle(Console.ReadLine());
            DOJ = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine($"Employee Id :{Empid}, Name : {EmpName}, Salary : {EmpSalary} and Date of Joining :{DOJ}");
        }

        public void ShowEmployee()
        {
            Console.WriteLine($"Employee Id :{Empid}, Name : {EmpName}, Salary : {EmpSalary} and Date of Joining :{DOJ}");
        }
    }
}
