using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L12TaskA1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter param A: ");
            int I = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter param B: ");
            int J = Convert.ToInt32(Console.ReadLine());
            flag:
            Console.WriteLine("Enter operation: ('*','-','+','/')");
            char A = Convert.ToChar(Console.ReadLine());
            int sum = 0;
            switch (A)
            {
                case '*':
                    sum = Calculator.MUL(I, J);
                    break;
                case '/':
                    try
                    {
                        if (J == 0)
                        {
                            throw new Exception("DivideByZeroException");
                        }
                        sum = Calculator.DIV(I, J);

                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }
                    
                    break;
                case '+':
                    sum = Calculator.ADD(I, J);
                    break;
                case '-':
                    sum = Calculator.SUB(I, J);
                    break;
                default:
                    Console.WriteLine("Error no existing operation");
                    goto flag;
            }
            Console.WriteLine("Sum is: {0}",sum);
            Console.ReadKey();
        }
    }
    static class Calculator
    {
        static public int SUB(int arg_a, int arg_b)
        {
            int sum = arg_a - arg_b;
            return sum;
        }
        static public int ADD(int arg_a, int arg_b)
        {
            int sum = arg_a + arg_b;
            return sum;
        }
        static public int MUL(int arg_a, int arg_b)
        {
            int sum = arg_a * arg_b;
            return sum;
        }
        static public int DIV(int arg_a, int arg_b)
        {
            int sum = arg_a / arg_b;
            if(arg_b == 0)
            {
                Console.WriteLine("ERROR DIVIDE BY ZERO");
            }
            return sum;
        }
    }
}
