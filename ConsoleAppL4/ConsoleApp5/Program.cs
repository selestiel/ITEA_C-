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
            int a = 20; ;
            while(a>=20 && a<= 50)
            {
                a++;
                if ((a%3)==0 && (a % 5) != 0)
                {
                    Console.WriteLine("Required number divided by 3 but not 5 is: " + a);
                }
            }
            Console.ReadKey();
        }
    }
}
