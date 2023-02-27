using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6prj
{
    class Employee
    {
        //option no. 1 in order to access the fields of employee outside the employee class
        //public int Empid { get; set; }
        //public string Empname { get; set; }
        //public string Companyname { get; } = "Medusind";
        //public float Salary { get; set; }

        //option no.2 by overriding the toString Method()
        int Empid;
        string Empname;
        string Companyname = "Medusind";
        float Salary;
        public Employee(int eid, string name,float sal)
        {
            Empid = eid;
            Empname = name;
            Salary = sal;
        }
        //overide the tostring()
        public override string ToString()
        {
            return string.Format("Employee Id :" + Empid + " Employee Name :" + " "  + Empname +
                " Works With :" +" "+ Companyname + " and Earns :" + Salary);
        }

        public static void Greet(string s)
        {
            Console.WriteLine("Hello and Welcome " + s);
        }

        public void Wishes(string str)
        {
            Console.WriteLine(str);
        }
        public string Message(string str)
        {
            return "Welcome " + str;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //ListEg();
            //DictionaryEg();
            Generic_WithUserDefinedTypes();
            Console.Read();
        }

        public static void ListEg()
        {
            List<int> numbers = new List<int>();
            numbers.Add('a');  //ascii of a is 97
            numbers.Add(89);
            numbers.Add(19);
            numbers.Add(5);
            numbers.Add(58);
            numbers.Add(10);
            numbers.Add(34);
            numbers.Add(71);
            numbers.Add(25);

            numbers.Sort();
            foreach (int x in numbers)
            {
                Console.WriteLine(x);
            }
            Console.WriteLine(numbers.Count);
            Console.WriteLine(numbers.Capacity);

            List<string> colors = new List<string>() { "Red","Blue",
                "Yellow","Pink","White","Black"};

            foreach(string s in colors)
            {
                Console.WriteLine(s);
            }
         
        }

        public static void DictionaryEg()
        {
            Dictionary<int, string> dict = new Dictionary<int, string>();
            dict.Add(3, "Green");
            dict.Add(1, "Red");
            dict.Add(4, "Yellow");
            dict.Add(2, "Blue");

            foreach(int n in dict.Keys)
            {
                Console.WriteLine(n);
            }

            foreach (string s in dict.Values)
            {
                Console.WriteLine(s);
            }

            //inorder to iterate on both keys and values, we use a structure 
            //called as KeyValuePair
            foreach(KeyValuePair<int,string> kvp in dict)
            {
                Console.Write(kvp.Key + " ");
                Console.Write(kvp.Value);
                Console.WriteLine();
            }
        }
        public static void Generic_WithUserDefinedTypes()
        {
            List<Employee> emplist = new List<Employee>();
            emplist.Add(new Employee(1, "Asha", 25000));
            emplist.Add(new Employee(2, "Domnic", 25000));
            emplist.Add(new Employee(3, "Sailesh", 25000));
            emplist.Add(new Employee(4, "Suraj", 25000));
            
            foreach(Employee e in emplist)
            {
                //option 1 to access employee details
                // Console.WriteLine($"Employee {e.Empname} with ID {e.Empid} works with {e.Companyname} and Earns {e.Salary}");
                Console.WriteLine(e.ToString());
            }
            
        }
    }
}
