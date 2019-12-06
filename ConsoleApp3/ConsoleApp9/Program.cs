using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter parameter a: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter parameter b: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter parameter c: ");
            int c = Convert.ToInt32(Console.ReadLine());

            
            /*
             int res = 0;
             res = a * x * 2 + b * x + c;
             -c = ax2 + bx
             - c = x * (2 * a + b);
             -c / x = 2 * a + b;
             1 / x = (2 * a + b) / c;
             x = c / (2 * a + b);
             */
            //int res = 0;
            //res = 2 * a * x + b * x;
            int x = c / (2 * a + b);
            
            double rt = Math.Sqrt(x);
            Console.WriteLine("Square root for quad eqation is: " + rt);
            Console.ReadKey();
        }
    }
}
