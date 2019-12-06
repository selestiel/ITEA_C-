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
            //
            Console.WriteLine("Please enter next:  a = :");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter next:  b = :");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter next:  c = :");
            int c = Convert.ToInt32(Console.ReadLine());
            int x_1 = 0;
            int x_2 = 0;
            //ax^2 + bx + c = 0;
            int D = b * b - 4 * a * c;
            if (D < 0)
            {
                Console.WriteLine("D can't be less then 0");
            }
            else if (D == 0)
            { 
                x_1 = -b / 2 * a;
                x_2 = x_1;
                Console.WriteLine("X_1 = {0}, X_2 = {1}",x_1,x_2);
            }
            else
            {
                x_1 = (int)((-b - Math.Sqrt(D)) / (2 * a));
                x_2 = (int)((-b + Math.Sqrt(D)) / (2 * a));
                Console.WriteLine("X_1 = {0}, X_2 = {1}", x_1, x_2);
            }
            Console.ReadKey();
                  
                                    
        }
    }
}
