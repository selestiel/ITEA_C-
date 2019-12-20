using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L7TaskA4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter triangle sides: ");
            Console.WriteLine("Side A: ");
            double A = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Side B: ");
            double B = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Side C: ");
            double C = Convert.ToDouble(Console.ReadLine());
            Triangle new_Triangle = new Triangle(A,B,C);
            new_Triangle.info(new_Triangle.Square(A, B, C), new_Triangle.Perimeter(A, B, C));
            Console.ReadKey();
        }
    }
    class Triangle
    {
        private double side_a { get; set; }
        private double side_b { get; set; }
        private double side_c { get; set; }

        public void info(double x, double y)
        {
            Console.WriteLine("Triangle square is : {0}, perimeter is: {1}", x, y);
        }
        public double Square(double a, double b, double c)
        {
            double p = Perimeter(a, b, c) / 2;
            double result = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            return result;
        } 
        public double Perimeter(double a,double b, double c)
        {
            double result = a + b + c;
            return result;
        }
        public Triangle(double a, double b, double c)
        {
            side_a = a;
            side_b = b;
            side_c = c;
            Console.WriteLine("Triangle sides is : A: {0}, B: {1}, C: {2}",a,b,c);
        }
    }
}
