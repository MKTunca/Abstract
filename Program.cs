using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangle triangle = new Triangle();
            triangle.Environment();
            triangle.Area();
            Square square = new Square();
            square.Environment();
            square.Area();
            Console.ReadLine();
        }
       abstract class Geometry
        {
            public void Environment()
            {
                Console.WriteLine("Şeklin kenarlarını topla");
            }
            public abstract void Area();
        }
        class Triangle : Geometry
        {
            public override void Area()
            {
                Console.WriteLine("(a*b)/2");
            }
        }
        class Square : Geometry
        {
            public override void Area()
            {
                Console.WriteLine("a*a");
            }
        }

    }
}
