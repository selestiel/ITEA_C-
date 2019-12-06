using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter two numbers: ");
            Console.WriteLine("A: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("B: ");
            int b = Convert.ToInt32(Console.ReadLine());
            if (a > b)
            {
                Console.WriteLine("A is greater then B!");
                int s = 0;
                for (int i =b; i <a; i++)
                {
                    s += b++;
                }
                Console.WriteLine("the sum of B to A is: " + s);
            }
            else if (a < b)
            {
                int x = 0;
                string y = "";
                for (int j  = a; j < b; j++)
                {
                    x = a++;
                    if (x % 2 != 0)
                    {
                        y = y + " " + x;
                    }
                   
                }
                Console.WriteLine("The odd numbers btw A and B is: " + y);
                
            }
            Console.ReadKey();
        }
    }
}
