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
            //task 3 lesson 4
            Console.WriteLine("Enter number of minutes");
            int min = Convert.ToInt32(Console.ReadLine());
            if (min >= 0 && min <= 59)
            {
                if (min >= 0 && min < 15)
                {
                    Console.WriteLine("First quarter of hour");
                }
                else if(min >= 15 && min < 30)
                {
                    Console.WriteLine("Second quarter of hour");
                }
                else if (min >= 30 && min < 45)
                {
                    Console.WriteLine("Third quarter of hour");
                }
                else
                {
                    Console.WriteLine("Fourth quarter of hour");
                }
            }
            else
            {
                Console.WriteLine("WRONG INPUT");
            }
            Console.ReadKey();
        }
    }
}
