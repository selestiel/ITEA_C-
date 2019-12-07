using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            int sub = Square(3);
            Console.WriteLine(sub);
            Console.ReadKey();
        }
        /// <summary>
        /// Kvadrat of number
        /// </summary>
        /// <param name="arg">number</param>
        /// <returns>Kvadrat of number</returns>
        static int Square(int arg)
        {
            int result = arg * arg;
            return result;
        }
    }
}
