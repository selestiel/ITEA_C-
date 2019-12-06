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
            int counter = 0;
            int x = 3;
            for (int y = 0; y < byte.MaxValue; y++)
            {
                long res = x * y;
                counter++;
                Console.Write(" " + res + " ");
                if (counter == 15)
                {
                    Console.WriteLine();
                    counter = 0;
                }
            }
            
            Console.ReadKey();
        }
    }
}
