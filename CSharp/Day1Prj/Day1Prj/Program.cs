using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1Prj
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello All.. Welcome to CSharp Programming");
            getNumbers();  //invoking static method of the same class
            Myclass mc = new Myclass(); //instantiating an object of MyClass
            mc.SampleMethod();  //invoking the instance method of other class

            Program p = new Program();
            p.outputExample();  //instance method of same class

            FreshClass fc = new FreshClass();
            fc.NullExample();
            Console.Read();
        }

        public static void getNumbers()
        {
            Console.WriteLine("Enter first number :");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number :");
            int num2 = Convert.ToInt32(Console.ReadLine());
            int result = Add(num1, num2);
            Console.WriteLine(result);
        }

        static int Add(int x, int y)
        {
            return x + y;
        }

        public void outputExample()
        {
            Console.WriteLine("Enter Your First Name :");
            string uname = Console.ReadLine();
            Console.WriteLine("Enter Your Last Name :");
            string lname = Console.ReadLine();
            Console.WriteLine("Your Full name is " + uname + " " + lname); //concatenation
            Console.WriteLine("Your Full Name is {0} {1}", uname, lname); //placeholder
            Console.WriteLine($"Your Full Name is {uname} {lname}");  //string interpolation
        }
    }

    class Myclass
    {
        public void SampleMethod()
        {
            int x = 10;
           // float f = x;  //implicit 
           // Console.WriteLine(f);
           // f = 12345680567897.45f;
           //// x =(int)f; // explicit conversion  typecasting
           //  x = Convert.ToInt32(f); //explicit conversion using conversion method
           // Console.WriteLine(x);
           // object o = x;  //boxing
           // x = (int)o;    //unboxing

            //tryparse() takes string and converts to int, If suucessful gives the converted
            //number as output and returns a boolean indicating success or failure

            string str = "100";
           // x = int.Parse(str);
           // Console.WriteLine(x);

            //let us change the value of str from "100" to "100ab"
            str = "100dfghj";
            int result ;
            bool status = int.TryParse(str, out result);
            if (status)
            {
                Console.WriteLine(result);
            }
            else
                Console.WriteLine("Invalid data");
        }

    }
}
