using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppL5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number: ");
            int x = Convert.ToInt32(Console.ReadLine());
            int y = 0;
            for (int i = 0; i <= x; i++)
            {
                y += i;
            }
            Console.WriteLine(y);
            Console.ReadKey();
        }
    }
}
