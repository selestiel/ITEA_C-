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
            Console.WriteLine("Enter your name please: ");
            string uname = Console.ReadLine();
            Console.WriteLine(Hello(uname));
            Console.ReadLine();
        }
        static string Hello(string name)
        {
            string greet = string.Concat("Hello ", name);
            return greet;
        }
    }
}
