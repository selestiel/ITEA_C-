using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L7TaskA5
{
    class Program
    {
        static void Main(string[] args)
        {
            Point A = new Point(4, 4, "A");
            Point B = new Point(7, 9, "B"); 
            Point C = new Point(1, 2, "C");
            Figure Tri = new Figure(A, B, C);
            Console.WriteLine("Triangle sides: {0}, {1},  {2}",
                Tri.side_fig(A, B),
                Tri.side_fig(B, C),
                Tri.side_fig(A, C));
            Console.WriteLine("Triangle perimeter: {0}",
                Tri.Perim(Tri.array_points));
            Point D = new Point(12, 5, "D");
            Figure Rect = new Figure(A, B, C, D);
            Console.WriteLine("Rectangle sides: {0} , {1}, {2}, {3}",
            Rect.side_fig(A, B),
            Rect.side_fig(B, C),
            Rect.side_fig(C, D),
            Rect.side_fig(A, D));
            Console.WriteLine("Rectangle perimeter: {0}",
            Rect.Perim(Rect.array_points));
            Point E = new Point(4, 4, "A");
            Point F = new Point(8, 8, "B");
            Point G = new Point(-8, -8, "C");
            Point H = new Point(-4, -4, "D");
            Figure Quad = new Figure(E, F, G, H);
            Console.WriteLine("Quad sides: {0}, {1}, {2}, {3}",
            Quad.side_fig(E, F),
            Quad.side_fig(F, G),
            Quad.side_fig(G, H),
            Quad.side_fig(E, H));
            Console.WriteLine("Quad perimeter: {0}",
            Quad.Perim(Quad.array_points));

            Console.ReadKey();
        }
    }
    class Point
    {
        private int coord_x { get; set; }
        private int coord_y { get; set; }
        private string coord_name { get; set; }

        public int C_A()
        {
            int A = coord_x;
            return A;
        }
        public int C_B()
        {
            int B = coord_y;
            return B;
        }
        public string C_N()
        {
            string N = coord_name;
            return N;
        }
        public Point(int a, int b, string c)
        {
            coord_x = a;
            coord_y = b;
            coord_name = c;
        }

    }
    class Figure 
    {
        public int[][] array_points { get; set; }
        public string array_name { get; set; }
        public double side_fig(Point a, Point b)
        {
            int x_2 = b.C_A();
            int x_1 = a.C_A();
            int y_2 = b.C_B();
            int y_1 = a.C_B();
            double result = Math.Sqrt(Math.Pow((x_2 - x_1), 2) + Math.Pow((y_2 - y_1), 2));
            return result;
        }

        public double Perim(int[][] array)
        {
            double result = 0;

            for(int i = 0; i< array.Length; i++)
            {
                for (int j = 0; j < array.Length; j++)
                {
                    int x_1 = array[i][j];
                    int x_2 = array[i + 1][j];
                    int y_1 = array[i][j + 1];
                    int y_2 = array[i + 1][j + 1];
                    result += Math.Sqrt(Math.Pow((x_2 - x_1), 2) + Math.Pow((y_2 - y_1), 2));
                }
            }

            return result;
        }
        public Figure(Point a,Point b, Point c)
        {
            array_points[0][0] = a.C_A();
            array_points[0][1] = a.C_B();
            array_points[1][0] = b.C_A();
            array_points[1][1] = b.C_B();
            array_points[2][0] = c.C_A();
            array_points[2][1] = c.C_B();
            array_name = "Triangle";
        }
        public Figure(Point a, Point b, Point c,Point d)
        {
            array_points[0][0] = a.C_A();
            array_points[0][1] = a.C_B();
            array_points[1][0] = b.C_A();
            array_points[1][1] = b.C_B();
            array_points[2][0] = c.C_A();
            array_points[2][1] = c.C_B();
            array_points[3][0] = d.C_A();
            array_points[3][1] = d.C_B();
            array_name = "Rectangle";
        }
    }
}
