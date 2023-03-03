using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deffered_ImmediateEg
{
    class ElementOperators
    {
        static void ElementAt1()
        {
            string[] cities = { "Bombay", "Chennai", "Pune", "Shillong", "Hyderabad" };
            var result = cities.ElementAt(3);
            Console.WriteLine(result);
            var result1 = cities.ElementAtOrDefault(5); // no exceptions raised
            Console.WriteLine("Resultant City {0}",result1);
        }

        static void First_lambda()
        {
            string[] countries = { "Australia","India", "Japan", "Sweeden", "Taiwan" };
            // var result = countries.First();
            var result = countries.Last();
            Console.WriteLine(result);
            string[] colors = { };
            Console.WriteLine(colors.LastOrDefault());
            Console.WriteLine(colors.FirstOrDefault());

            var res = countries.Last(c => c.Length == 5);
            Console.WriteLine(res);
        }

        static void single_lambda()
        {
            string[] names = { "Ram" };
            string[] names1 = { "John", "Johnny", "Janardhan" };
            string[] names2 = { };

            //Console.WriteLine(names.Single()); //gives result
            //Console.WriteLine(names1.Single()); // throws error
            //Console.WriteLine(names2.Single()); //throws error

            Console.WriteLine(names.SingleOrDefault()); //gives result
           // Console.WriteLine(names1.SingleOrDefault()); //throws an error
            Console.WriteLine(names2.SingleOrDefault()); //no result, no error
        }

        static void Main()
        {
            // ElementAt1();
            First_lambda();
           // single_lambda();
            Console.ReadKey();

        }
    }
}
