using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            Console.WriteLine("Enter your angle size: ");
            int b = Convert.ToInt32(Console.ReadLine());
            if (b > 90)
            {
                a = 1;
            }
            else if (b < 90)
            {
                a = 2;
            }
            else
            {
                a = 0;
            }
            switch (a)
            {
                case 1:
                    Console.WriteLine("The angle is dull");
                    break;
                case 2:
                    Console.WriteLine("The angle is keen");
                    break;
                case 0:
                    Console.WriteLine("The angle is straight");
                    break;
                default:
                    break;
            }
            Console.ReadKey();
        }
    }
}
