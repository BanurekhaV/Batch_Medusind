using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deffered_ImmediateEg
{
    class Others
    {
        static void Main()
        {
            //sorting();
            // Console.WriteLine("--------");
            //reverse();
            //Console.WriteLine("---------");
            //sorting2();
            //Console.WriteLine("--------");
            // skip();
            // take();
            //groupby();
            joins();
            Console.Read();
        }
        static void sorting()
        {
            int[] numbers = { 5, 26, 7, 11, 34, 2 };
            var sortednumbers = numbers.OrderBy(n => n);

            foreach (int n in sortednumbers)
            {
                Console.WriteLine(n);
            }

            var descsortnumbers = numbers.OrderByDescending(n => n);

            foreach (int n in descsortnumbers)
            {
                Console.WriteLine(n);
            }
        }

        //multiple sorting
        static void sorting2()
        {
            string[] capitals = {"Berlin","Paris","Delhi","Tokyo","Madrid","London",
            "Seoul"};
            var res = capitals.OrderBy(c => c.Length).ThenBy(c => c);

            foreach (string s in res)
            {
                Console.WriteLine(s);
            }
        }

       // skip - skips specified number of elements and returns the balance in the collection
//   skipwhile - skips some elements in a collection while a specified condition is met.
//Once the condition is false, it stops skipping and returns all the balance elements
        public static void skip()
        {
            string[] words = { "Bye", "See", "Hello", "Sea", "I", "Salut", "Welcome", "Good", "Bad", "Hi" };
            var res = words.Skip(3);

            foreach (var v in res)
            {
                Console.WriteLine(v);
            }
            Console.WriteLine("-----------");
            //skipwhile
            var res1 = words.SkipWhile(w => w.Length == 3);
            foreach (var v in res1)
            {
                Console.WriteLine(v);
            }
        }
        static void reverse()
        {
            char[] chrs = { 'm', 'e', 'd', 'u', 's', 'i', 'n', 'd' };
            var res = chrs.Reverse();
            foreach (char c in res)
            {
                Console.WriteLine(c);
            }
        }

        //take takes some elements specified from the beginning of the collection
        //takewhile - takes some elements from the beginning while the condition is met, and stops when condition is false
        public static void take()
        {
            int[] arr = { 11, 2, 6, 7, 3, 4, 5, 8, 9, 10 };
            var res = arr.Take(5);

            foreach (int n in res)
            {
                Console.WriteLine(n);
            }

            //take while

            var res1 = arr.TakeWhile(n => n < 5);
            Console.WriteLine("------------");
            foreach (int x in res1)
            {
                Console.WriteLine(x);
            }
        }

        //GroupBy - projects elements of a collection into groups by key
        public static void groupby()
        {
            int[] numbers = { 10, 15, 20, 25, 30, 35 }; //{10,20,30
                                                        // 15,25,35}

            var result = numbers.GroupBy(n => (n % 10 == 0));

            Console.WriteLine("The Groups ...");

            foreach(IGrouping<bool,int> grp in result)
            {
                if(grp.Key==true)
                {
                    Console.WriteLine("Divisible By 10" );
                }
                else
                    Console.WriteLine("Not Divisible by 10");
                foreach(int n in grp)
                {
                    Console.WriteLine(n);
                }
            }

        }

        //join(inner join)joins 2 collections by a common key
        public static void joins()
        {
            string[] warmcountries = { "Turkey", "Italy", "Spain", "Saudi Arabia", "Etopia" ,"SriLanka"};
            string[] coldcountries = { "Canada", "Italy", "Denmark", "Switzerland", "Spain" };

            //  var result = warmcountries.Join(coldcountries, warm => warm, cold => cold, (warm, cold) =>cold);

            var result = warmcountries.Intersect(coldcountries);
            foreach(var country in result)
            {
                Console.WriteLine(country);
            }
            Console.WriteLine("---------");
            //except
            var res = coldcountries.Except(warmcountries);
            foreach (var c in res)
            {
                Console.WriteLine(c);
            }

        }
    }
}
