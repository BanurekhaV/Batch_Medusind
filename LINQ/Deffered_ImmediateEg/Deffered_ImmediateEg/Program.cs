using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deffered_ImmediateEg
{
    class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var employees = new List<Employee>
            {
                new Employee{ID=1,Name="Rishan",Salary=30000 }, 
                new Employee {ID=2,Name="Shahul",Salary=42000} ,
                new Employee{ID=3,Name="Elizabeth",Salary=50000}
            };

            //Deferred - Query is constructed but not executed
           // var emp = employees.Where(x => x.Salary < 35000).Select(y => y.Name); //output is both Rishan and Devkanta

            //immediate - Query is executed at the point of its construction itself  
            var emp = employees.Where(x => x.Salary < 35000).Select(y => y.Name).ToList(); //output is only Rishan
            
            //add one more employee to the collection
            employees.Add(new Employee { ID = 4, Name = "Devkanta", Salary = 32000 });

            foreach(var e in emp)
            {
                Console.WriteLine(e);
            }
            Console.ReadLine();
        }
    }
}
