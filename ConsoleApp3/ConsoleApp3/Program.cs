using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            a = Convert.ToInt32(Console.ReadLine());
            if (a < 10) 
            {
                Console.WriteLine("true");
            }
            else if(a >10)
            {
                Console.WriteLine("false");
            }
            else
            {
                Console.WriteLine("nothing");
            }
            Console.ReadKey();
        }
    }
}
