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
            int tc = 0;
            int tf = 0;
            for(tc =-50;tc <= 50; tc++)
            {
                tf = (9 / 5 * tc + 32);
                Console.WriteLine("Temp C = {0}; Tem F = {1}",tc,tf);
            }
            Console.ReadKey();
        }
    }
}
