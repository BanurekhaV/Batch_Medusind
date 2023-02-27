using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6prj
{
    public delegate int NumberChanger(int n);
    class DelegatesEg2
    {
        static int num = 10;

        public static int AddNum(int p)
        {
            num += p;
            return num;
        }

        public static int MultiNum(int q)
        {
            num *= q;
            return num;
        }

        public static int getNum()
        {
            return num;
        }

        static void Main()
        {
            //create delegate instances
            NumberChanger nc1 = new NumberChanger(AddNum);
            NumberChanger nc2 = new NumberChanger(MultiNum);

            //call the methods thru the delegate
            nc1(25);
            Console.WriteLine("Value of Num :{0}", getNum());
            nc2(5);
            Console.WriteLine("Value of Num :{0}", getNum());
            nc1 = MultiNum;
            Console.Read();
        }
    }
}
