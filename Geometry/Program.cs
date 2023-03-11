using System;
using FiguresLibrary;

namespace Geometry
{
    class Program
    {
        static void Main(string[] args)
        {
            Figure figure = new Figure();
            figure.DisplayInfo();

            Console.WriteLine("Впишите  длины сторон треугольника по одному в строчку :");
            double a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());
            double c = Convert.ToDouble(Console.ReadLine());

            Figure triangle = new Triangle(a,b,c);
            triangle.DisplayInfo();//both work
            Console.WriteLine();

            Console.WriteLine("Впишите радиус круга :");
            double r = Convert.ToDouble(Console.ReadLine());
            Figure circumference = new Circumference(r);
            circumference.DisplayInfo();



        }
    }
}
