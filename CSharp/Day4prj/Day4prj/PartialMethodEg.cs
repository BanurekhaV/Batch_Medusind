using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4prj
{
    partial class PartialMethodEg
    {
        partial void func1(int num)
        {
            num++;
            Console.WriteLine(num);
        }

        public void newfunc1(int n)
        {
            n = n + 5;
            func1(n);
        }
    }
}
