using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter rectangle sides: Side A");
            int side_a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Side B: ");
            int side_b = Convert.ToInt32(Console.ReadLine());
            Funct(side_a, side_b);
            Console.ReadKey();
        }
        static void Funct(int a, int b)
        {
            int perim = 2 * (a + b);
            int square = a * b;
            string result = string.Format("Perimeter of rect is: {0} Square of rect is: {1}",perim,square);
            Console.WriteLine(result);
        }
    }
}
