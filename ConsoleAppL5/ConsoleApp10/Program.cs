using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        {
            start:
            Console.WriteLine("Hello user!, Lets calculate, i can Divide, Multiply, Substract, Add, Modulate");
            Console.WriteLine("Enter first value:");
            int value_1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second value:");
            int value_2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Choose what to do with values:");
            char sign = Convert.ToChar(Console.ReadLine());
            int data = 0;
            switch (sign)
            {
                case '*':
                    data = mult(value_1, value_2);
                    break;
                case '/':
                    data = divi(value_1, value_2);
                    break;
                case '+':
                    data = addi(value_1, value_2);
                    break;
                case '-':
                    data = subs(value_1, value_2);
                    break;
                case '%':
                    data = modu(value_1, value_2);
                    break;
                default:
                    break;
            }
            Console.WriteLine("Result of operation is: {0}", data);
            loop:
            Console.WriteLine("What to calculate again?: yes, no?");
            string check = Console.ReadLine();
            switch (check)
            {
                case "yes":
                    goto start;
                    break;
                case "no":
                    break;
                default:
                    goto loop;
            }
            Console.ReadKey();
        }
        static int mult(int arg_1, int arg_2)
        {
            int result = arg_1 * arg_2;
            return result;
        }
        static int divi(int arg_1, int arg_2)
        {
            int result = arg_1 / arg_2;
            return result;
        }
        static int addi(int arg_1, int arg_2)
        {
            int result = arg_1 + arg_2;
            return result;
        }
        static int subs(int arg_1, int arg_2)
        {
            int result = arg_1 - arg_2;
            return result;
        }
        static int modu(int arg_1, int arg_2)
        {
            int result = arg_1 % arg_2;
            return result;
        }
    }
}
