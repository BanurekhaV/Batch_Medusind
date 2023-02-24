using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5prj
{
    abstract class Shape
    {           
        //decl an abstract method
        abstract public int Area();  
        
        public Shape()
        {
            Console.WriteLine("Hi from Shape");
        }
    }

    class Square : Shape
    {
        int side = 0;

        //constructor
        public Square(int x)
        {
            side = x;
        }
        public override int Area()
        {
            return side * side;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Shape shape;
            shape = new Square(6);
            Console.WriteLine(shape.Area());
            Console.WriteLine("-----------");
            Instantiation_of_Base iob = new Instantiation_of_Base(5,10);

            Console.Read();
        }
    }
}
