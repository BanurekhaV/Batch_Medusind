using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4prj
{
    class OverloadEg
    {
        public void add(int a, int b)
        {
            Console.WriteLine("2 Parameter Add called");
        }

        public void add(int x, float y)
        {
             int res= x +(int)y;
            Console.WriteLine(res);           
        }

        public static void Main()
        {
            OverloadEg oeg = new OverloadEg();
            oeg.add(5, 5);  // go to line number 12
            oeg.add(10, 34.567f); //go to line number 17
            Console.Read();
        }

    }
}
