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
            Console.WriteLine("First: ");
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Second: ");
            int x = 0;
            while(x < 5)
            {
                Console.WriteLine(++x);
            }
            Console.WriteLine("Third: ");
            x = 0;
            do
            {
                
                ++x;
                
                Console.WriteLine(x);
                
            } while (x < 5);
            Console.ReadKey();
        }
    }
}
