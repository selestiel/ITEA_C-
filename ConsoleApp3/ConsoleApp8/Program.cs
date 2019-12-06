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
            Console.WriteLine("Enter number please: ");
            int number = Convert.ToInt32(Console.ReadLine());
            if (number % 2 == 0)
            {
                Console.WriteLine("Even number");
                if (number % 6 == 0)
                {
                    Console.WriteLine("Number can be divided by 6");
                }
                else if (number % 3 == 0)
                {
                    Console.WriteLine("Number can be divided by 3");
                }
                else
                {
                    Console.WriteLine("Number can't be divided by 3 or 6");
                }
            }
            else
            {
                Console.WriteLine("Odd number");
                if (number % 6 == 0)
                {
                    Console.WriteLine("Number can be divided by 6");
                }
                else if (number % 3 == 0)
                {
                    Console.WriteLine("Number can be divided by 3");
                }
                else
                {
                    Console.WriteLine("Number can't be divided by 3 or 6");
                }
            }
            Console.ReadKey();
        }
    }
}
