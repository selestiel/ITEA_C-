using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            string a_str = "";
            int a = 0;
            a = Convert.ToInt32(Console.ReadLine());
            a_str = a < 10 ? "true" : "false";
            Console.WriteLine(a_str);
            Console.ReadKey();

        }
    }
}

  
