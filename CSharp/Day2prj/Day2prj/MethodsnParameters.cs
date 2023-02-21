using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2prj
{
    class MethodsnParameters
    {
        public static void Main()
        {
            int data = 10;
            /* byValue(data);
             Console.WriteLine("Value outside the function :" + " " + data);

             byRef(ref data);  // calling a function/method
             Console.WriteLine("Value outside the function :" + " " + data);*/

            // int total,prod,subtract,division = 0;
            // division = Calculator(20, 10, out total, out prod, out subtract);
            // Console.WriteLine($"Sum is {total}, Product is {prod}, Difference is{subtract} and Division is {division}");

            // int result = AddElements();
            // Console.WriteLine(result);

            //params 2
            //int[] num = new int[3] { 10, 20, 30 };
            //ParamsMethod();  //0 arguments
            //ParamsMethod(num); // array of 3 elements
            //ParamsMethod(1, 2, 3, 4, 5, 6); //comma seperated values
            stringExample();
            Console.Read();
        }

        //call by value
        public static void byValue(int x) // being called
        {
            x = 100;
            Console.WriteLine(" Value inside the function is :" + " " + x);
        }

        //call by reference
        public static void byRef(ref int x)
        {
            x = 100;
            Console.WriteLine(" Value inside the function is :" + " "+x);
        }

        //out parameters (when we need more return values than just one from a function)
        //Eg: given 2 nos. as input, we want the sum,product,difference and division values
        public static int Calculator(int n1, int n2,out int sum,out int product,out int diff)
        {
            sum = n1 + n2;
            product = n1 * n2;
            diff = n1 - n2;
            return n1 / n2;
        }

        //params example 1
        public static int AddElements(params int[] arr)
        {
            int sum = 0;
            foreach(int i in arr)
            {
                sum += i;
            }
            return sum;
        }

        //params example 2
        public static void ParamsMethod(params int[] numbers)
        {
            Console.WriteLine("There are {0} elements passed ",numbers.Length);
            foreach(int x in numbers)
            {
                Console.WriteLine(x);
            }
        }

        //strings

        public static void stringExample()
        {
            string str = "hello";
            string s = str;
            Console.WriteLine(str + " " + str.GetHashCode());
            Console.WriteLine(s + " " + s.GetHashCode());
            str = "Hello World";
            Console.WriteLine(str + " " + str.GetHashCode());
            Console.WriteLine(s+ " " + s.GetHashCode());
            s = "Bye";
            Console.WriteLine(s + " "+ s.GetHashCode());
            Console.WriteLine("-----------------");
            StringBuilder sb = new StringBuilder("My World");
            Console.WriteLine(sb + " " + " " + sb.GetHashCode());
            sb.Append("New");
            Console.WriteLine(sb + " " + " " + sb.GetHashCode());
        }
    }
}
