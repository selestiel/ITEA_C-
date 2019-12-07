using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter two numbers: ");
            int x = Convert.ToInt32(Console.ReadLine());
            int y = Convert.ToInt32(Console.ReadLine());
            funct(x, y);
            void funct(int a, int b)
        {
            int z = a < b ? a : b;
            Console.WriteLine(z);

        }
            Console.ReadKey();
        }
    }
}
