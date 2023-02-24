using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5prj
{
    //1. create an user defined exception class inheriting from ApplicationException class
    class VotingException : ApplicationException
    {
        public VotingException(string msg) : base(msg)
        {   }
    }

    class Vote
    {
        int age;
        public void GetAge()
        {
            Console.WriteLine("Enter your Age :");
            age = Convert.ToInt32(Console.ReadLine());

            //select the code logic where we can throw the exception
            if(age<18)
            {
                throw new VotingException("Age should be greater than 18 to Vote ..");
            }
            else
                Console.WriteLine("Thanks for Voting..");
        }
    }
    class UserDefinedExceptionEg
    {
        static void Main()
        {
            Vote vote = new Vote();
            try
            {
                vote.GetAge();
            }
            catch(VotingException ve)
            {
                Console.WriteLine(ve.Message);
            }

            //anonymous type 
            var mytype = new {data1="CSharp",
            data2=5,
            data3=true,
            data4=12.56f
            };
            Console.WriteLine(mytype.GetType().ToString());
            Console.WriteLine(mytype.data1);
            Console.Read();          
        }
    }
}
