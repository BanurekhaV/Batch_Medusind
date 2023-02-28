using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExtensionProject;


namespace Library_addons
{
    public static class addOns
    {
        public static int Subtract(this Calculator c, int a, int b)
        {
            return a - b;
        }

        public static int Multiply(this Calculator c, int a, int b)
        {
            return a * b;
        }
    }
}
