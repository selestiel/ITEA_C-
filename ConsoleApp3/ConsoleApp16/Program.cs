using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name please: ");
            string name = Console.ReadLine();
            string hello = "Hello ";
            string welcome = " and Welcome! ";
            string str1 = "Hello " + name + " and Welcome!";
            string str2 = string.Concat(hello, name, welcome);
            string str3 = "Hello {0} and Welcome! ";
            string str_f = string.Format(str3, name);
            Console.WriteLine(str_f);
            Console.WriteLine(str2);
            Console.WriteLine(str1);
            Console.ReadKey();

        }
    }
}
