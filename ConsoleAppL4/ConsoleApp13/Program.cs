using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            int b = 1;
            int c = 0;
            string f = "";
            Console.WriteLine("Enter amount of numbers in Fi raw");
            int x = Convert.ToInt32(Console.ReadLine());
            for(int i =0; i < x;i++)
            {
                c = a + b;
                a = b;
                b = c;
                f = (f + " " + c);
            }
            Console.WriteLine(" Fi raw is : 0, 1, " + f);
            Console.ReadKey();
        }
    }
}
