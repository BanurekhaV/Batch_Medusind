using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6prj
{
    public delegate int Arithmeticdelegate(int x, int y);
    class Delegates_as_Parameter
    {
        static void Main()
        {
            DoOperation(10, 2, Multiply);
            DoOperation(10, 2, Divide);
            Console.Read();
        }
        static void DoOperation(int x, int y, Arithmeticdelegate adel)
        {
            int z = adel(x, y);  //invoking of the delegate
            Console.WriteLine(z);
        }
        static int Multiply(int x, int y)
        {
            return x * y;
        }

        static int Divide(int x, int y)
        {
            return x / y;
        }
    }
}
