using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter year you want to check");
            int year = Convert.ToInt32(Console.ReadLine());
            if(year % 4 == 0 || year % 400 == 0)
            {
                Console.WriteLine("This " + year + " year is High na has 366 days");
            }
            else
            {
                Console.WriteLine("This " + year + " year is normal and has 365 days");
            }
            Console.ReadKey();
        }
    }
}
