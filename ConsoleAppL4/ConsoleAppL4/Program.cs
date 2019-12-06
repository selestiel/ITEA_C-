using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppL4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter X: ");
            int x = Convert.ToInt32(Console.ReadLine());

            int y = 0;
            if (x <= -20)
            {
                y = 3 * x * x * x;
                
            }
            else 
            {
                if (x > -20 && x <= 30)
                {
                    y = Math.Abs(x);
                }
                else
                {
                    y = 30;
                }
            }
           
            Console.WriteLine("y = " + y);
            Console.ReadKey();
        }
    }
}
