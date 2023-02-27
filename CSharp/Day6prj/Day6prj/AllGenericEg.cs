using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6prj
{
    //generic class
    class AllGenericEg<T>  //where T:struct  or T:class is a constraint applicable for either
        //value types or reference types
    {
        //generic field
        private T genericfield;

        //generic property
        public T genericProperty { get; set; }

        //generic constructor
        public AllGenericEg(T value)
        {
            genericfield = value;
        }

        //generic method
        public T genericMethod(T genericparameter)
        {
            Console.WriteLine("Parameter Type is : {0}, and the Value is :{1}",
                typeof(T).ToString(),genericparameter);
            Console.WriteLine("Return Type is : {0}, and the Value is :{1}",
                typeof(T).ToString(), genericfield);

            return genericfield;
        }
    }

    class TestAllGeneric
    {
        static void Main()
        {
            AllGenericEg<int> int_allgen = new AllGenericEg<int>(20);
       int result = int_allgen.genericMethod(200);
           

            AllGenericEg<string> string_allgen = new AllGenericEg<string>("Hi Generics");

           string_allgen.genericMethod("Generic Method with string");

            Console.Read();
        }
    }
}
