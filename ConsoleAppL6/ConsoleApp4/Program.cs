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
            Random mss = new Random();
            int[] mass = new int[5];
            for (int j = 0; j < mass.Length; j++)
            {
                mass[j] = mss.Next(1, 100);
            }
            for (int i = 0; i < mass.Length; i++)
            {
                Console.Write(" {0} ", mass[i]);
            }
            Console.WriteLine();
            for (int i = 4; i >= 0; i--)
            {
                Console.Write(" {0} ",mass[i]);
            }
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
