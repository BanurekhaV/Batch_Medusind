using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3prj
{
    enum cities { Agra=5,Bangalore=1,Chennai=3,Delhi=0,Mumbai=4,Kolkatta=2}
    struct student    //try changing the struct to class and check
    {
        //fields that can contain data
        public int m1;
        public int m2;
    }
    class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            //  program.enumExample2();
           
            Employee employee = new Employee();
            employee.ShowEmployee();
            Employee e2 = new Employee(200, "Prema", 40000);
          //  e2 = null;
           // e2.GetEmployee();
           // GC.Collect();
             e2.ShowEmployee();
             Employee e3 = new Employee(500, "Jayanth", 41000, Convert.ToDateTime("09/02/2023"));
             e3.ShowEmployee();

            AccessSpecifersEg accesseg = new AccessSpecifersEg();
            accesseg.salary = 1200000;
            accesseg.info = "Hi";
            accesseg.val = 56;
            Console.Read();
        }

        public void structExample()
        {
            student s1 = new student();  //instantiating/constructing
            s1.m1 = 75;
            s1.m2 = 80;
            Console.WriteLine(s1.m1 + s1.m2);

            student s2 = new student();
            s2 = s1;  // the values are copied
            Console.WriteLine(s2.m1 + s2.m2);

            s1.m1 = 90;
            s1.m2 = 90;
            Console.WriteLine("After Reassigning s1 values");
            Console.WriteLine(s1.m1 + s1.m2);
            Console.WriteLine(s2.m1 + s2.m2);
        }
        public void enumExample1()
        {
            string city = Convert.ToString(cities.Bangalore);
            switch (city)
            {
                case "Agra":
                    Console.WriteLine("It is a Monument city");
                    break;
                case "Bangalore":
                    Console.WriteLine("It is a Garden city");
                    break;
                case "Chennai":
                    Console.WriteLine("It is a Temple city");
                    break;
                default: Console.WriteLine("Invalid City"); break;
            }
        }

        public void enumExample2()
        {
            //to get all values of the enumeration list items
            Console.WriteLine("Read the Values of Cities Enum");
            foreach(int i in Enum.GetValues(typeof(cities)))
                Console.WriteLine(i);

            //get all names in the enumeration list
            foreach(var s in Enum.GetNames(typeof(cities)))
                Console.WriteLine(s);

            //get an enum name by a specific value
            string enumname = Enum.GetName(typeof(cities), 3);
            Console.WriteLine(enumname);
        }
    }
        
}
