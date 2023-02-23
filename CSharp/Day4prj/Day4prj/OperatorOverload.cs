using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4prj
{
    class Distance
    {
        public int d;
        public int d1;

        //operator '+' is being overloaded to work with objects

        public static Distance operator +(Distance d1, Distance d2)
        {
            Distance temp = new Distance();
            temp.d = d1.d + d2.d;
            return temp;
        }

        //operator '*' is being overloaded to work with objects

        public static Distance operator *(Distance dist1, Distance dist2)
        {
            Distance temp = new Distance();
            temp.d = dist1.d * dist2.d;
            return temp;
        }
    }
    class OperatorOverload
    {
        static void Main()
        {
            Distance d1, d2, d3;
            d1 = new Distance();
            d2 = new Distance();
            d1.d = 10;
            d2.d = 20;
            d3 = d1 + d2; //this call will reach an + operator that is being overloaded
            Console.WriteLine("The Total Distance is {0}", d3.d);
            d3 = d1 * d2;
           // d3++;
            Console.WriteLine("The product of the Distance is {0}",d3.d);
            Console.WriteLine("The Incremental value of D3 is {0}", d3.d);
            Console.ReadKey();
        }
    }
}
