using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4prj
{
    static class Classstatic
    {
        // all members have to be static
       public static int x;

        public static void statFunction()
        {
            Console.WriteLine("Hi I am a Static Method");
        }

    }

    sealed class Classsealed
    {
        public void sealedFunction()
        {
            Console.WriteLine("Hi I am a sealed Function");
        }
    }

    abstract class Classabstract
    {
        //abstract method with the abstract keyword
        public abstract void show();  //only declaration/signature

        public void Display()
        {
            Console.WriteLine("Hello Non Abstract");
        }
    }
   partial class TypesofClasses :Classabstract
    {
        static int staticdata = 5;
        string info;
        static void Main()
        {
            Classstatic.x = 5;
            Classstatic.statFunction();

            Classsealed cs = new Classsealed();
            cs.sealedFunction();

            TypesofClasses toc = new TypesofClasses();
            toc.Display();
            toc.show();

            PartialMethodEg pme = new PartialMethodEg();
            pme.newfunc1(5);
            Console.Read();
        }

        public override void show()
        {
            Console.WriteLine("Implementing abstract method");
            Console.WriteLine("Original static data values" + " " + staticdata);
            staticdata = 10;
            Console.WriteLine(staticdata + "  " + "after changes");
        }
    }

   partial class PartialMethodEg
    {
        partial void func1(int num);

        public string Message()
        {
            return "Welcome All to cSharp !!";
        }
    }
}
