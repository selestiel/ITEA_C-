using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            int a_Var = 0;
            int b_Var = 0;

            Console.WriteLine("Enter first variable: ");
            a_Var = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second variable: ");
            b_Var = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            sum = a_Var + b_Var;
            int sub = 0;
            sub = a_Var - b_Var;
            int mul = 0;
            mul = a_Var * b_Var;
            int div = 0;
            div = a_Var / b_Var;
            int inc_a = 0;
            int dec_a = 0;
            int inc_b = 0;
            int dec_b = 0;
            inc_a = ++a_Var;
            dec_a = --a_Var;
            inc_b = ++b_Var;
            dec_b = --b_Var;
            int res = 0;
            res = a_Var % b_Var;
            string msgi = "Results: Addition: {0}, Substraction: {1}, Multiplication: {2}, Divination: {3}, Increment: {4} {5}, Decrement: {6} {7}, Rest: {8}";
            string msgo = string.Format( msgi,sum,sub,mul,div,inc_a,inc_b,dec_a,dec_b,res);
            Console.WriteLine(msgo);
            Console.ReadKey();

        }
    }
}
