using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5prj
{
    interface ICustomer
    {
        //only decl.
        void Print();
        string Message(string s);
        string companyname { get;}
    }

    interface ISupplier
    {
        void Show();
    }
        
    interface Iproduct :ICustomer,ISupplier
    {
        int add(int a, int b);
    }
    class Customer : Iproduct
    {
        public string companyname { get; set; }

        public int add(int a, int b)
        {
            return a + b;
        }
        public string Message(string uname)
        {
            return "Hello" + " " + uname;
        }

        public void Print()
        {
            Console.WriteLine("Print of ICustomer");
        }

        public void Show()
        {
            Console.WriteLine("Show Method of ISupplier");
        }
        static void Main()
        {
            //using the objects of the interface and referencing the implementing class
            ICustomer ic;
            ISupplier Isup;
            Isup = new Customer();
            ic = new Customer();
            ic.Print();
            Console.WriteLine(ic.Message("Gayathri"));
            Isup.Show();

            //using the object of implementing class
            Customer c = new Customer();
            c.Print();
            c.Show();
            Console.WriteLine(c.Message("Kailash")); 
            Console.Read();
        }
    }
}
