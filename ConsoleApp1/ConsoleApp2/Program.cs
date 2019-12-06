using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = 0;
            double Pi = 3.1416;
            double t = 0;
            Console.WriteLine("Enter Radius: ");
            a = Convert.ToDouble(Console.ReadLine());

            t = Pi * (a * a);
            Console.WriteLine("Result: " + t);
            Console.ReadKey();
        }
    }
}
