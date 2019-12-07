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
            Console.WriteLine("Enter number:");
            int a = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            int count = 0;
            sum = loader(a, ref count, sum);
            Console.WriteLine("Here is sum: {0}", sum);
            Console.ReadKey();
        }
        static int loader(int arg, ref int z,int sum)
        {
            if (z != arg)
            {
                ++z;
                sum += z;  ;
                return loader(arg, ref z,sum);
            }
            else
            {
                return sum;
            }
        }
    }
}