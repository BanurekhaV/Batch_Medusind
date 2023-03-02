using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class LambdaEg
    {
        static void Main()
        {
            List<int> numbers = new List<int>() { 16, 23, 12, 19, 42, 28, 57, 7, 9, 30 };

            //loop to display the List

            foreach(var v in numbers)
            {
                Console.Write(" {0} ", v);
            }

            //1. using lambda exp, to calculate the square of the number list
            var square = numbers.Select(x => x * x);

            //loop to display squares
            Console.WriteLine("----Squares----");

            foreach (var v in square)
            {
                Console.Write(" {0} ", v);
            }


            //2. find all numbers divisible by 3
            List<int> divby3 = numbers.FindAll(n => (n % 3) == 0);

            foreach (var n in divby3)
            {
                Console.WriteLine(" {0} ", n);
            }

            //3. Find a particular record
            Student s = Student.GetStudentData().Find(std => std.Id == 102);
            Console.WriteLine($"ID:{s.Id} Name:{s.Name} Email:{s.Email} Age:{s.Age}");


            //4. sorting on students on name

            var sortedstud = Student.GetStudentData().OrderBy(n => n.Name);

            foreach (var item in sortedstud)
            {
                Console.WriteLine(item.Id + " "+ item.Name);
            }
            Console.Read();
        }
    }
}
