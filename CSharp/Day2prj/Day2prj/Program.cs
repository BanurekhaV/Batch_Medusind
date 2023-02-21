using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2prj
{
    class Program
    {
        public static void Main(string[] args)
        {
            Program program = new Program();
            // program.SingleDimension();
            //program.twoDimension();
            // program.jaggedArray();
            ControlClass cc = new ControlClass();
            // cc.checkGrade();
            // cc.checkGrade_with_Switch();
          //  Loops.ForLoop();
            Loops loops = new Loops();
            //loops.WhileLoop();
            // Console.WriteLine("------------");
            //loops.DoWhileloop();
           // loops.gotoExample();

            //implicitly typed variable
            var temp = "Hello";
            temp = "Hello World";  // can change the values in a var type that matches the assigned type
                                   // temp = 56.45f; // we cannot chnage the data type

            dynamic d;
            d = 7;
            d = 'r';
            d = "abc";
            d = 125.5f;
            d = program;
            Console.WriteLine(d);
            Console.Read();
        }

        public void SingleDimension()
        {
            int[] arr1 = new int[5];
            Console.WriteLine("Enter Array Elements");
            for(int i=0; i<arr1.Length;i++)
            {
                arr1[i] = Convert.ToInt32(Console.ReadLine());
            }
            Array.Sort(arr1);
            Console.WriteLine("------Displaying Data------");
            for (int i = 0; i < arr1.Length; i++)
            {
                Console.WriteLine(arr1[i]);
            }
            Console.WriteLine(arr1.Rank);
        }

        public void twoDimension()
        {
            int[,] arr2 = new int[2, 3] { { 1, 2, 3 }, { 4, 5, 6 } };
            Console.WriteLine(arr2[0,1]); //return 2
            Console.WriteLine(arr2[1,0]); //returns 4

            //1st loop to track the row
            for (int i = 0; i < 2; i++)
            {
                Console.Write("Elements at Row " + i + ":");
                //inner loop to track columns
                for(int j=0; j < 3;j++)
                {
                    Console.Write(arr2[i,j] +" ");
                }
                Console.WriteLine();
            }
        }

        public void jaggedArray()
        {
            //decl jagged array of 2 rows
            int[][] jarray = new int[2][];
            //1. let us set the size of the columns for each jagged row
            jarray[0] = new int[3];
            jarray[1] = new int[2];

            //initialize the jarray
            jarray[0][0] = 2;
            jarray[0][1] = 4;
            jarray[0][2] = 6;

            jarray[1][0] = 3;
            jarray[1][1] = 5;

            //2 nd way to set the size and initialize data
            int[][] jarray1 =
            {
                new int[]{5,10,15,20},
                new int[]{25,30},
                new int[]{35,40,45}
            };

            //we need 2 lops to iterate the jagged array
            for(int i=0; i < jarray1.Length;i++)
            {
                Console.Write("Elements at Row No : "+ i + " ");
                for(int j=0; j < jarray1[i].Length;j++)
                {
                    Console.Write(jarray1[i][j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
