using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6prj
{
    //Generic class
    class GenericsEg1<T>
    {
        private T field1;

        public T _prop1
        {
            get { return this.field1; }
            set { field1 = value; }
        }

        //generic method
        public void Display<T>(string msg, T val)
        {
            Console.WriteLine("{0} :{1}" , msg, val);
        }
    }

    class Driver
    {
        static void Main()
        {
           explore_Generics1();
          //  explore_Generics2();
            Console.Read();
        }

        public static void explore_Generics1()
        {
            //string instance of the generic class
            GenericsEg1<string> genstring = new GenericsEg1<string>();
            genstring._prop1 = "Generic of type String";
            Console.WriteLine(genstring._prop1);

            //float instance of the generic class
            GenericsEg1<float> genfloat = new GenericsEg1<float>();
            genfloat._prop1 = 12345.4567f;
            Console.WriteLine(genfloat._prop1);
        }

        public static void explore_Generics2()
        {
            GenericsEg1<int> genint = new GenericsEg1<int>();
            genint.Display<int>("Integer", 256);

            genint.Display<string>("String", "String Value");

            genint.Display<char>("Character", 'A');
        }
    }
}
