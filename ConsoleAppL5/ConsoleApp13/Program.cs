using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number:");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Function(a);
            string d_num1 = Bits(b);
            Console.WriteLine("Bit of number is: {0}",d_num1);
            Console.ReadKey();
        }
        static int Function(int arg)
        {
            int counter = 0;
            if(arg > 0)
            {
                ++counter;
                if (arg >= 10)
                {
                    ++counter;
                    if (arg >= 100)
                    {
                        ++counter;
                        if (arg >= 1000)
                        {
                            ++counter;
                            if (arg >= 10000)
                            {
                                ++counter;
                                if (arg >= 100000)
                                {
                                    ++counter;
                                    if (arg >= 1000000)
                                    {
                                        ++counter;
                                        if (arg >= 10000000)
                                        {
                                            ++counter;
                                            if (arg >= 100000000)
                                            {
                                                ++counter;
                                                if (arg >= 1000000000)
                                                {
                                                    ++counter;
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            return counter;
        }
        static string Bits(int arg_a)
        {
            string d_num;
            switch (arg_a)
            {
                case 1:
                case -1:
                    d_num = "unit";
                    break;
                case 2:
                case -2:
                    d_num = "decade";
                    break;
                case 3:
                case -3:
                    d_num = "hundred";
                    break;
                case 4:
                case -4:
                    d_num = "thousand";
                    break;
                case 5:
                case -5:
                    d_num = "tens of thousands";
                    break;
                case 6:
                case -6:
                    d_num = "hundreds of thousands";
                    break;
                case 7:
                case -7:
                    d_num = "million";
                    break;
                case 8:
                case -8:
                    d_num = "tens of millions";
                    break;
                case 9:
                case -9:
                    d_num = "hundreds of millions";
                    break;
                case 10:
                case -10:
                    d_num = "billion";
                    break;
                default:
                    d_num = "zeros";
                    break;
            }
            return d_num;
        }
    }
}
