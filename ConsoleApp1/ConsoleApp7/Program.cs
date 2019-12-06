using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            double Pi = 3.1416;
            double V = 0;
            double S = 0;
            double R = 0;
            double h = 0;
            Console.WriteLine("Enter radius: ");
            R = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter height: ");
            h = Convert.ToDouble(Console.ReadLine());
            V = Pi * R * 2 * h;
            S = 2 * Pi * R *(R + h);
            string msgi = "If radius of cylinder is: {0}, and height of cylinder is: {1}, then Value is: {2}, and square is: {3}";
            string msgo = string.Format(msgi,R,h,V,S);
            Console.WriteLine(msgo);
            Console.ReadKey();
        }
    }
}
