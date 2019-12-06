using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number: ");
            double operand1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter operation: ");
            char sign = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Enter second number: ");
            double operand2 = Convert.ToDouble(Console.ReadLine());
            double result = 0;
            switch (sign)
            {
                
                case '*':
                    result = operand1 * operand2;
                    break;
                case '/':
                    if (operand2 == 0)
                    {
                        Console.WriteLine("Error you can't divide by 0");
                        break;
                    }
                    else
                    {
                        result = operand1 / operand2;
                        break;
                    }
                case '+':
                    result = operand1 + operand2;
                    break;
                case '-':
                    result = operand1 - operand2;
                    break;
                case '%':
                    if (operand2 == 0)
                    {
                        Console.WriteLine("Error you can't divide by 0");
                        break;
                    }
                    else
                    {
                        result = operand1 % operand2;
                        break;
                    }
                default:
                    break;
            }
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
