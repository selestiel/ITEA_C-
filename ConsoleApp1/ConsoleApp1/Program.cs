using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            double a = 0;
            double c = 0;
            double b = 0;
            Console.WriteLine("Enter first number: ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter second number: ");
            b = Convert.ToDouble(Console.ReadLine());
            c = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));
            Console.WriteLine("Result: " + c);
            Console.ReadKey();
                

    }
    }
}
