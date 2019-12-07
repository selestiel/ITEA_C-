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
            Method(1,3,45);

            int Method(int a,int b, int c)
            {
                int y = (a + b + c) / 3;
                Console.WriteLine(y);
                return y;
            }
            Console.ReadKey();
        }
    }
}
