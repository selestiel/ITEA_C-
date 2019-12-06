using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number");
            int number = Convert.ToInt32(Console.ReadLine());
            if (number >= 0 && number <= 100)
            {
                if (number >= 0 && number <= 14)
                {
                    Console.WriteLine("Your number is less than 15");
                }
                if (number >= 15 && number <= 35)
                {
                    Console.WriteLine("Your number is less than or equal 35");
                }
                if (number >= 36 && number <= 50)
                {
                    Console.WriteLine("Your number is less than or equal 50");
                }
                if (number >= 50 && number <= 100)
                {
                    Console.WriteLine("Your number is less than or equal 100");
                }
            }
            else
            {
                Console.WriteLine("Wrong input out of range");
            }
            Console.ReadKey();
        }
    }
}
