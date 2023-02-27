using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6prj
{
    public delegate void delegate1();
    public delegate int delegate2(int x);
    class MulticastDelegate1
    {
        public static void Method1()
        {
            Console.WriteLine("Method 1");
        }
        public static void Method2()
        {
            Console.WriteLine("Method 2");
        }
        public void Method3()
        {
            Console.WriteLine("Method 3");
        }

        static void Main()
        {
            //1st way of multicasting
            //Multidelegate d1, d2, d3, d4;
            //d1 = new Multidelegate(Method1);
            //d2 = new Multidelegate(Method2);
            //d3 = new Multidelegate(Method3);
            //d4 =  d2 + d3 +d1; // adding delegate objects
            //d4();
            //Console.WriteLine("---------");
            //d4 = d3+d1-d2; // removing a delegate object
            //d4();

            //2nd way of multicasting
           delegate1 multi = new delegate1(Method1);
            multi += Method2; //adding a method reference

            //create class object to assign non-static methods to the delegate
            MulticastDelegate1 mcd = new MulticastDelegate1(); 
            multi += mcd.Method3;
            multi();

            multi -= Method2; //remove a method reference
            multi();

            Console.WriteLine("------Muticast Delegates with Return Values-------");

           class2 multi2 = new class2();

           delegate2 m2 = new delegate2(multi2.Square);
            m2 += multi2.Triplet;

            int retval=m2(5);
            Console.WriteLine(retval);
            Console.Read();
        }
    }

    class class2
    {
        static int p;
        public int Square(int x)
        {
            p = x * x;
            Console.WriteLine(p);
            return p;
        }

        public int Triplet(int y)
        {
            p = y * y * y;
            return p;
        }
    }
}
