using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3prj
{
    public class AccessSpecifersEg
    {
        private int data=10;
        public string info="Medusind";
        internal double salary;
        protected int age;
        protected internal int val;

        void checkmembers()
        {
            Console.WriteLine(data);
            Console.WriteLine(info);
            Console.WriteLine(salary);
            Console.WriteLine(age);
            Console.WriteLine(val);
        }
    }

    internal class TestAccess : AccessSpecifersEg
    {
        public void checkAccess()
        {
            //with the object of the class that has declared all types of access specifer members
            AccessSpecifersEg aseg = new AccessSpecifersEg();
            //we will be able to access public members, internal protected, internal members if sharing the same assembly
            ////else only public members
            aseg.info = "New Medusind";
            aseg.salary = 324567;
            aseg.val = 10;
            //with the object of the derived class, we will be able to access
            //public members, protected members , internal protected and internal members if sharing same assembly else no
            TestAccess ta = new TestAccess();
            ta.info = "child Medusind";  //public
            ta.salary = 123467;  //internal
            ta.age = 25; //protected
            ta.val = 50; //internal and protected
        }
    }
        

}
