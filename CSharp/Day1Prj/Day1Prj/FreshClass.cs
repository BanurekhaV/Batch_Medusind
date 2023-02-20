using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1Prj
{
    class FreshClass
    {
        public void NullExample()
        {
            Console.WriteLine("This is to understand Concept of Null");
            int ? data1 = 10;
            int data2;
            if(data1==null)
            {
                data2 = 500;
            }
            else
            {
                data2 =(int)data1; //or
              //  data2 = data1.Value;
            }
            Console.WriteLine(data2);

            //the above if else checking null values can be replaced as below
            //using null coalescing operator ?? (ternary operator)
            data2 = data1 ?? 500;
            Console.WriteLine(data2);
           
        }
    }
}
