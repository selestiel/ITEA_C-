using System;

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
                Tri.Perim(Tri.arr_point));
            Point D = new Point(12, 5, "D");
            Figure Rect = new Figure(A, B, C, D);
            Console.WriteLine("Rectangle sides: {0} , {1}, {2}, {3}",
            Rect.side_fig(A, B),
            Rect.side_fig(B, C),
            Rect.side_fig(C, D),
            Rect.side_fig(A, D));
            Console.WriteLine("Rectangle perimeter: {0}",
            Rect.Perim(Rect.arr_point));
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
            Quad.Perim(Quad.arr_point));

            Console.ReadKey();
        }
    }
    class Point
    {
        private int coord_x { get; set; }
        private int coord_y { get; set; }
        private string coord_name { get; set; }

        public int Get_X()
        {
            int A = coord_x;
            return A;
        }
        public int Get_Y()
        {
            int B = coord_y;
            return B;
        }
        public string Get_N()
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
        public Point[] arr_point { get; set; }
        public string array_name { get; set; }
        public double side_fig(Point a, Point b)
        {
            int x_2 = b.Get_X();
            int x_1 = a.Get_X();
            int y_2 = b.Get_Y();
            int y_1 = a.Get_Y();
            double result = Math.Sqrt(Math.Pow((x_2 - x_1), 2) + Math.Pow((y_2 - y_1), 2));
            return result;
        }

        public double Perim(Point[] array)
        {
            double result = 0;

            for (int i = 0; i < array.Length - 1; i++)
            {
                int x_1 = array[i].Get_X();
                int x_2 = array[i + 1].Get_X();
                int y_1 = array[i].Get_Y();
                int y_2 = array[i + 1].Get_Y();
                result += Math.Sqrt(Math.Pow((x_2 - x_1), 2) + Math.Pow((y_2 - y_1), 2));

            }

            return result;
        }
        public Figure(Point a, Point b, Point c)
        {
            Point[] array = new Point[3] { a, b, c };
            arr_point = array;
            array_name = "Triangle";

        }
        public Figure(Point a, Point b, Point c, Point d)
        {
            Point[] array = new Point[4] { a, b, c, d };
            arr_point = array;
            array_name = "Rectangle";
        }
    }
}