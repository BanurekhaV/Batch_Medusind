using System;
using Day3prj;


namespace Day3prj_2
{
    class Newprogram : AccessSpecifersEg
    {
        static void Main(string[] args)
        {
            //with the object of the class which declares all types of access specifer members
            //we can access only public members being outside the assembly

            AccessSpecifersEg ag = new AccessSpecifersEg();
            ag.info = "Medusind Inc.";
            

            //with the object of the derived class, we will be able to access
            //public members, protected members only
            Newprogram np = new Newprogram();
            np.info = "outside Medusind";
            np.age = 20;
            np.val = 100;
        }
    }
}
