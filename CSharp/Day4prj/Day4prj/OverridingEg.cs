using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4prj
{
    class Shape
    {
        protected float R=2, L=3, B=4;

        public virtual float Area()
        {
            return 3.14f * R * R;   // area of circle
        }

        public virtual float Circumference()
        {
            return 2 * 3.14f * R;
        }
    }

    class Rectangle : Shape
    {
        public void GetLB()
        {
            Console.WriteLine("Enter Length and Breadth : ");
            L = float.Parse(Console.ReadLine());
            B = Convert.ToSingle(Console.ReadLine());
        }

        public override float Area()
        {
            return L * B;
        }

        public override float Circumference()
        {
            base.Circumference();
            return 2 * (L + B);
        }
        ////method hiding
        //public new float Circumference()  //hiding the method implementation from the base class
        //{
        //    return 2 * (L + B);
        //}
    }

    class Circle : Shape
    {
        public void GetRadius()
        {
            Console.WriteLine("Enter Radius :");
            R = float.Parse(Console.ReadLine());
        }
        public override float Area()
        {
            // return base.Area();
            Console.WriteLine("Calculating Area of a Circle");
            return 3.14f * R * R;
        }
    }
    class OverridingEg
    {
        static void Main()
        {
            //Rectangle r = new Rectangle();
            //r.GetLB();
            //Console.WriteLine("Area of Rectangle is :{0}",r.Area());
            //Console.WriteLine("Circumference of Rectangle is :{0}",r.Circumference());
            //Circle c = new Circle();
            //c.GetRadius();
            //Console.WriteLine("Area of Circle is :{0}", c.Area());
            //Console.WriteLine("Circumference of Circle is :{0}", c.Circumference());

            //for the actual polymorphism of an object, 
            Console.WriteLine("----------------");
            Shape s = new Shape();
            Console.WriteLine("Shapes Area {0}", s.Area()); 
            s = new Rectangle();  //covariance
            Console.WriteLine("Rectangles Area {0}",s.Area());
          //  Console.WriteLine("Rects Circumference {0}", s.Circumference());
            s = new Circle();
            Console.WriteLine("Circles Area {0}", s.Area());
            
            Console.Read();
        }
    }
}
