using System;


namespace Day4prj
{
    class Student
    {
        private string RollNo;
        string SName;
        string Class;

        public void GetData()
        {
            Console.WriteLine("Enter RollNo :");
            RollNo = Console.ReadLine();
            Console.WriteLine("Enter Name :");
            SName = Console.ReadLine();
            Console.WriteLine("Enter Class :");
            Class = Console.ReadLine();
        }

        public void PutData()
        {
            Console.WriteLine("Name of the Student :" + SName);
            Console.WriteLine("RollNo of the Student :{0}", RollNo);
            Console.WriteLine($"Class of the Student :{Class}");
        }
    }

    class Marks : Student
    {
        protected int[] marks = new int[5];

        public void GetMarks()
        {
            for(int i=0; i<marks.Length;i++)
            {
                Console.Write("Enter Subject {0} Marks :", i + 1);
                marks[i] = Convert.ToInt32(Console.ReadLine());
            }
        }

        public void PutMarks()
        {
            for (int i = 0; i < marks.Length; i++)
            {
                Console.WriteLine("Marks in Subject {0} : {1}", i+1, marks[i]);
            }
        }
    }

    class Result : Marks
    {
        int Totalmarks = 0;

        public void GetResult()
        {
            for (int i = 0; i < marks.Length; i++)
            {
                Totalmarks = Totalmarks + marks[i];
            }
        }

        public void PutResult()
        {
            Console.WriteLine("==============Results==============");
            PutData();
            PutMarks();
            Console.WriteLine("Total Marks Scored =" + Totalmarks);
        }
    }
    class Program
    {
        public void add(int a, int b)
        {

        }
        static void Main(string[] args)
        {
            Result result = new Result();
            result.GetData();
            result.GetMarks();
            result.GetResult();
            result.PutResult();
            Console.Read();
        }
    }
}
