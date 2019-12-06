using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 10;
            int y = 12;
            int z = 3;

            x += (y - x++ * z);
            Console.WriteLine("x += (y - x++ * z) " + " x = " + x);
            x = 10;
            z = --x - y * 5;
            Console.WriteLine("z = --x - y * 5 " + " z = " + z);
            z = 3;
            y /= (x + 5 % z);
            Console.WriteLine("y /= x + 5 % z " + " y = " + y);
            y = 12;
            z = x++ + y * 5;
            Console.WriteLine("z = x++ + y * 5 " + " z = " + z);
            z = 3;
            x = y - x++ * z;
            Console.WriteLine("x = y - x++ * z " + " x = " + x);
            Console.ReadKey();
        }
    }
}
