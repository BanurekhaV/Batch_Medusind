using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5prj
{
    class User
    {
        int userId = 101;
        string username = "Medusind";
        string password;

        //Automatic implementation of properties
        public int uid { get; protected set; }  // allowing writing only by the parent and its child classes
        public string name { get; }

        //declare manual properties 1. userId
        public int _uid
        {
            get { return userId; }
            set { if (value < 50)
                    userId = value;
                else userId = 100;
            }
        }

        //2. username  only get accessor
        public string uname
        {
            get { return username; }
        }
    }
    class PropertiesEg : User
    {
        public static void Main()
        {
            User user = new User();
            Console.WriteLine(user._uid);  // get accessor
            user._uid = 200;  //set accessor
            Console.WriteLine(user._uid);
            Console.WriteLine(user.uname);
            //PropertiesEg peg = new PropertiesEg();
            //peg.uid = 5;
            Console.Read();
        }
    }

    class Employee
    {
        public int Empid { get; }
        public string Empname { get; set; }
        public float EmpSalary { get; private set; }
        public float commission { get; protected set; }
    }
}
