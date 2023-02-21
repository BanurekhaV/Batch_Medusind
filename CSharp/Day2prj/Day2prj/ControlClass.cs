using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2prj
{
    class ControlClass
    {
        //if else
        public void checkGrade()
        {
            char grade;
            Console.WriteLine("Enter your Grade (O/A/B/C/D :");
            grade = Convert.ToChar(Console.ReadLine());
            if (grade == 'O') 
                Console.WriteLine("outstanding");
            else if(grade=='A')
                Console.WriteLine("Excellent");
            else if (grade == 'B')
                Console.WriteLine("Very Good");
            else if (grade == 'C')
                Console.WriteLine("Good");
            else if (grade == 'D')
                Console.WriteLine("Poor");
            else
                Console.WriteLine("Invalid Grade");
        }

        //switch case grade check
        public void checkGrade_with_Switch()
        {
            char grade;
            Console.WriteLine("Enter your Grade (O/A/B/C/D :");
            grade = Convert.ToChar(Console.ReadLine());
            switch(grade)
            {
                case 'O': Console.WriteLine("Outstanding"); break;
                case 'A': Console.WriteLine("Excellent"); break;
                case 'B': Console.WriteLine("VeryGood"); break;
                case 'C': Console.WriteLine("Good"); break;
                case 'D': Console.WriteLine("Poor"); break;
                default: Console.WriteLine("Invalid Grade"); break;
            }
        }
    }

    class Loops
    {
        public static void ForLoop()
        {
            int total = 0;
            for(int i=0; i<=5; i++)
            {
                if (i == 3)
                    // break;
                    continue;
                Console.WriteLine("Looping the Values {0}",i);
                total += i;
            }
            Console.WriteLine("The sum of all the loop values is :{0}", total);
        }

        public void WhileLoop()
        {
            int i = 5;   //initialization of a counter value
            while(i<5)  // condition for iteration
            {
                Console.WriteLine("The value of i is :{0}", i);
                i++;     //change of the initial value
            }
            Console.WriteLine("sorry..");
        }

        public void DoWhileloop()
        {
            int i = 4;
            do
            {
                Console.WriteLine("The value of i is :{0}",i);
                i++;
            } while (i < 5);
        }

        public void gotoExample()
        {
        label1:
            Console.WriteLine("Enter a number between 1 and 9");
            int num = Convert.ToInt32(Console.ReadLine());
            if(num>=10)
            {
                //transfer the control back to label1
                goto label1;
            }
            Console.WriteLine(num  + " "+ "is less than 10");
        }
    }
}
