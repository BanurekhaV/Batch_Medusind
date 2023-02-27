using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6prj
{
    public delegate void Greetings(string uname);  //delegate declaration
    
    class DelegatesEg1
    {
        static void Main()
        {
            Employee employee = new Employee(5,"Banurekha",30000);
            //to the object of the delegate, we pass the name of the function
            Greetings g1 = new Greetings(Employee.Greet);
            g1.Invoke("Medusind"); //executes the actual function refered by the delegate object g1
            g1("New Medusind");  // executes the actual function refered by the delegate object g1

            Greetings g2 = new Greetings(employee.Wishes);
            g2("Delegates");
            Console.Read();

        }
    }
}
