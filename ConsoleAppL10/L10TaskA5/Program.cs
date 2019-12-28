using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L10TaskA5
{
    class Program
    {
        static void Main(string[] args)
        {
            Point A = new Point(5, 4, 3);
            Point B = new Point(10, 2, 7);
            A.ToString();
            B.ToString();
            Console.WriteLine("+ overload: {0}", A + B); 
            Console.WriteLine("- overload: {0}", A - B);
            Console.WriteLine("/ overload: {0}", A / B);
            Console.WriteLine("* overload: {0}", A * B);
            Console.WriteLine("% overload: {0}", A % B);
            Console.WriteLine("-- overload: {0}", B--);
            Console.WriteLine("++ overload: {0}", A++);
            Console.WriteLine(Equals(A, B));
            Console.WriteLine(A.ToString());
            Console.WriteLine(B.ToString());
            Console.WriteLine(A.GetHashCode());
            Console.WriteLine(B.GetHashCode());



            Console.ReadKey();
        }
    }
    class Point
    {
        int x { get; set; }
        int y { get; set; }
        int z { get; set; }

        public Point(int a, int b, int c)
        {
            x = a;
            y = b;
            z = c;
        }

        public override bool Equals(Object obj)
        { 
            Point p = (Point)obj;
            return (x == p.x) && (y == p.y) && (z == p.z);
        }

        public override int GetHashCode()
        {
            return (x*(y*(z)));
        }
        public override string ToString()
        {
            return string.Format("Point coord: x: {0}, y: {1}, z:{2}",x,y,z);
        }
        public static Point operator +(Point a, Point b)
        {
            return new Point(a.x + b.x, a.y + b.y, a.z + b.z);
        }
        public static Point operator -(Point a, Point b)
        {
            return new Point(a.x - b.x, a.y - b.y, a.z - b.z);
        }
        public static Point operator /(Point a, Point b)
        {
            return new Point(a.x / b.x, a.y / b.y, a.z / b.z);
        }
        public static Point operator *(Point a, Point b)
        {
            return new Point(a.x * b.x, a.y * b.y, a.z * b.z);
        }
        public static Point operator %(Point a, Point b)
        {
            return new Point(a.x % b.x, a.y % b.y, a.z % b.z);
        }
        public static Point operator ++(Point a)
        {
            return new Point(a.x++, a.y++, a.z++);
        }
        public static Point operator --(Point b)
        {
            return new Point(b.x--, b.y--, b.z--);
        }
    }
}
