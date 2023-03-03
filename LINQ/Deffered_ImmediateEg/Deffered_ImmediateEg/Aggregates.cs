using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deffered_ImmediateEg
{
    class Aggregates
    {
        static void Main()
        {
            int[] numbers = { 5, 13, 15, 20, 45 };
            var avg = numbers.Average();
            var tot = numbers.Sum();

            int[] arr = { 1, 2, 3, 4, 5 };
            var aggnum = arr.Aggregate((a, b) => a * b);
            Console.WriteLine("Aggregated Multiplication :{0}",aggnum);

            Console.WriteLine("Aggregates with Seed");

            var agg_seed = arr.Aggregate(10, (a, b) => a + b);
            Console.WriteLine("Aggregate with seed {0}",agg_seed);

            //convertion of a collection into a list

            string[] fruits = { "apple", "banana", "oranges", "papaya" };
            List<string> flist = fruits.ToList();
            Console.WriteLine(String.Format("Fruits is of type :{0}",fruits.GetType().Name));
            Console.WriteLine(String.Format("Flist is of type :{0}",flist.GetType().Name));
            Console.Read();
        }
    }
}
