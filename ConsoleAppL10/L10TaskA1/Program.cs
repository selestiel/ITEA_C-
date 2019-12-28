using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L10TaskA1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to console calculator!");
            bool exit = true;
            while (exit == true)
            {
                Calculator.Functions(Convert.ToInt32(Console.ReadLine()),
                    Convert.ToChar(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()));
                Console.WriteLine("...would you like repeat operation input? Type 'true' to continue or 'false' to exit...");
                exit = Convert.ToBoolean(Console.ReadLine());    
            }
            Console.ReadKey();
        }
    }
    static class Calculator
    {
        public static int Functions(int arg_a, char arg_b, int arg_c)
        {
            int result = 0;
            switch (arg_b)
            {
                case '+':
                    result = arg_a + arg_c;
                    break;
                case '-':
                    result = arg_a - arg_c;
                    break;
                case '*':
                    result = arg_a * arg_c;
                    break;
                case '/':
                    result = arg_a / arg_c;
                    break;
                case '%':
                    result = arg_a % arg_c;
                    break;
                default:
                    break;
            }
            Console.WriteLine("Operation Result: {0}", result);
            return result;
        }
    }
}
