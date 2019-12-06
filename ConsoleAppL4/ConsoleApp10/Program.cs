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
            Console.WriteLine("Enter number: ");
            uint number = Convert.ToUInt32(Console.ReadLine());
            ulong res = 0;
            if (number > int.MaxValue)
            {
                Console.WriteLine("Error out of range!");
            }
            else
            { 
                for (int i = 0; i < number; i++)
                {
                    res += (ulong)(i);
                }
                Console.WriteLine(res);
            }
                Console.ReadKey();
        }
    }
}
