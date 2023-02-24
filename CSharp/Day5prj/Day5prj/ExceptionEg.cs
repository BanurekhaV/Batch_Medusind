using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5prj
{
    class ExceptionEg
    {
      static void Main()
        {
            int a, b, c;
            try
            {
                Console.WriteLine("Enter 2 nos:");
                a = Convert.ToInt32(Console.ReadLine());
                b = Convert.ToInt32(Console.ReadLine());
                c = a / b;
                int[] arr = { 2, 4, 6, 8 };
                Console.WriteLine(arr[6]);
                Console.WriteLine(c);
            }
            
            catch (DivideByZeroException de)
            {
                //Console.WriteLine(de.Message + de.StackTrace);
                Console.WriteLine("Denominator cannot be 0");
            }
            catch(FormatException fe)
            {
                Console.WriteLine("Enter only numbers");
            }
            //catch(IndexOutOfRangeException ie)
            //{
            //    Console.WriteLine("Cannot read data beyound the size");
            //}
            catch (Exception e)
            {
                Console.WriteLine("OOps.. something went wrong.");
            }
            //will be executed irrespective of the exceptions
            finally
            {
                Console.WriteLine("Reached Finally");
            }
            Console.Read();
        }
    }
}
