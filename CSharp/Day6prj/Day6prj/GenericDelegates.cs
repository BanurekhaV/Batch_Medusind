using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6prj
{
    //generic delegate declaration
    delegate T Util<T>(T arg);
    class GenericDelegates
    {
        public static void Changer<T>(T[]values,Util<T> t)
        {
            for(int i=0; i<values.Length;i++)
            {
                values[i] = t(values[i]);
            }
        }

        static void Main()
        {
            // int[] data = new int[] { 4, 5, 6 };
            float[] data = new float[] { 4.4f, 5.5f, 6.6f };
            Changer(data, square);
            foreach(var i in data)
            {
                Console.Write(i + " ");
            }
            Console.Read();
        }

        static int square(int x)
        {
            return x * x;
        }

        static float square(float x)
        {
            return x * x;
        }
    }
}
