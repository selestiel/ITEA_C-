using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    class Program
    {
        static void Main(string[] args)
        {
            int m = Convert.ToInt32(Console.ReadLine());
            int k = Convert.ToInt32(Console.ReadLine());
            int i;
            int count = 0;
            for (i = k; i < m; i+=k)
            {
                count++;
            }
            
            i = m - i;
            if (i < 0)
            {
                i = k + i;
            }else if (i >= 0)
            {
                count++;
            }
            Console.WriteLine("Amount of icecream is: {0}, leftover of money is: {1}", count, i);
            Console.ReadKey();
        }
    }
}
