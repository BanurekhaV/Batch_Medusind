using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExtensionProject;
using Library_addons;

namespace ExtensionClient
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calc = new Calculator();
            Console.WriteLine(calc.Add(25,20));
            Console.WriteLine(calc.Subtract(15, 5));
            Console.WriteLine(calc.Multiply(5,4));
            Console.Read();
        }
    }
}
