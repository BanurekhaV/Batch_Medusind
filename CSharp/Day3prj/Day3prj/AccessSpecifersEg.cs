using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3prj
{
    public class AccessSpecifersEg
    {
        private int data=10;
        public string info="Medusind";
        internal double salary;

        void checkmembers()
        {
            Console.WriteLine(data);
            Console.WriteLine(info);
        }
    }

    internal class TestAccess
    {
        public void checkAccess()
        {
            AccessSpecifersEg aseg = new AccessSpecifersEg();
            aseg.info = "New Medusind";
            aseg.salary = 324567;
        }
    }
        

}
