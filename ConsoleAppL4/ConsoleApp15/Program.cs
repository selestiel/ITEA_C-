using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    class Program
    {
        static void Main(string[] args)
        {
            int z = 1;
            while (z == 1)
            {

                Console.WriteLine("Hello guest are you ready?");
                Console.WriteLine("Enter number A: ");
                int a = Convert.ToInt32(Console.ReadLine());
                operation:
                Console.WriteLine("Enter operation, it's either '+' or '-' or '/' or '*' or '%': ");
                char x = Convert.ToChar(Console.ReadLine());
                b_number:
                Console.WriteLine("Enter number B: ");
                int b = Convert.ToInt32(Console.ReadLine());
                int y = 0;
                switch (x)
                {
                    case '*':
                        y = a * b;

                        break;
                    case '/':
                        if (b == 0)
                        {
                            Console.WriteLine("Can't be divided by zero enter new B number!");
                            goto b_number;
                        }
                        y = a / b;
                        
                        break;
                    case '+':
                        y = a + b;
                       
                        break;
                    case '-':
                        y = a - b;
                        
                        break;
                    case '%':
                        if (a >= b)
                        {
                            if(b == 0)
                            {
                                Console.WriteLine("Can't be divided by zero enter new B number!");
                                goto b_number;
                            }
                            y = a % b;
                            
                        }
                        else
                        {
                            Console.WriteLine("B is bigger than A");
                        }
                        break;
                    default:
                        Console.WriteLine("Wrong operation entered! please enter again");
                        goto operation;
                }
                Console.WriteLine("Result is : " + y);
                Console.WriteLine("Redo operation or exit? 1/0");
                condition:
                x = Convert.ToChar(Console.ReadLine());
                switch (x)
                {
                    case '0':
                        z = 0;
                        break;
                    case '1':
                        z = 1;
                        break;
                    default:
                    Console.WriteLine("Invalid operator entered!");
                    goto condition;
                }
            }
            Console.ReadKey();
        }
    }
}
