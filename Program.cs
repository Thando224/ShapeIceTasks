using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Area
{
    interface Ishape
    {
        void shape();

        void color();
    }

    class Rectangle : Ishape
    {
        public void shape()
        {
            int b = 12;
            int h = 8;
            int a = b * h;

            Console.WriteLine("The area of a Rectangle is " + a);

        }

        public void color()
        {
            Console.WriteLine("Rectangle color is blue");
        }
    }

    class Triangle : Ishape
    {
        public void shape()
        {
            int b = 8;
            int h = 10;
            double a = 0.5 * (b * h);

            Console.WriteLine("The area of a Triangle is " + a);
        }

        public void color()
        {
            Console.WriteLine("Triangle color is orange");
        }
    }

    class parallelogram : Ishape
    {
        public void shape()
        {
            int b = 8;
            int h = 12;
            int a = b * h;

            Console.WriteLine("The area of the Parallelogram is " + a);
        }

        public void color()
        {
            Console.WriteLine("Parallelogram color is red");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle();
            rectangle.shape();
            rectangle.color();

            Triangle triangle = new Triangle();
            triangle.shape();
            triangle.color();

            parallelogram parallelogram = new parallelogram();
            parallelogram.shape();
            parallelogram.color();

            Console.ReadLine();

        }
    }
}