using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 20;
            byte res = (byte)(a * b);
            byte res1 = (byte)(a / b);
            byte res2 = (byte)(a + b);
            byte res3 = (byte)(a - b);
            byte res4 = (byte)(a % b);
            string str_f = "Result is: *: {0}, /: {1}, +: {2}, -: {3}, %: {4}";
            string str = string.Format(str_f,res,res1,res2,res3,res4);
            Console.WriteLine(str);
            Console.ReadKey();
        }

    }
}
