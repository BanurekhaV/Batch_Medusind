using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5prj
{
    class Base_class
    {
        int member1;
        //public Base_class()
        //{
        //    Console.WriteLine("Empty Constructor");
        //}
        public Base_class(int x)
        {
            member1 = x;
            Console.WriteLine(member1);
        }
    }
    class Instantiation_of_Base :Base_class
    {
        int childmember;
        //public Instantiation_of_Base()
        //{
        //    Console.WriteLine(" I am Child");
        //}

        public Instantiation_of_Base(int a):base(a)
        {
            childmember = a;
        }
        public Instantiation_of_Base(int a, int b):base(a)
        {
            childmember = b;
            Console.WriteLine(childmember);
        }
    }
}
