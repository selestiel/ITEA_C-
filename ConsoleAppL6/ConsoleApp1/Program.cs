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
            Console.WriteLine("Enter your Meters: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Conv_met(x, out int b, out int c, out double d);
            Console.WriteLine("Converted value of {0} m is: {1} cm, {2} mm, {3} km",x,b,c,d);
            Console.ReadKey();
        }
        static void Conv_met(int a, out int b)
        {
            b = 0;
            b = a * 100;
        }
        static  void Conv_met(int a, out int b, out int c)
        {
            b = 0;
            c = 0;
            b = a * 100;
            c = a * 1000;


        }
        static void Conv_met(int a, out int b,  out int c ,out double d)
        {
            b = 0;
            c = 0;
            d = 0;
            b = a * 100;
            c = a * 1000;
            
            d = (double)(a) / 1000;
           
        }
    }
}
