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
            Console.WriteLine("Hello user, Welcome to currency converter!");
            Console.WriteLine("What currency do you wish to convert? first sum, second tag");
            double curr = Convert.ToDouble(Console.ReadLine());
            string curr_n = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Into what convert? first exchange rate, second tag:");
            double rate = Convert.ToDouble(Console.ReadLine());
            string rate_n = Convert.ToString(Console.ReadLine());
            Console.WriteLine(@"Result of convertions is:  you get {2}  {3} for {0}  {1}",
                curr,curr_n,convertion(curr,rate),rate_n);
            Console.ReadKey();
        }
        static double convertion(double arg_1,double arg_2)
        {
            double result = 0;
            if (arg_2 > 1)
            {
                result = arg_1 / arg_2;
            }
            else if (arg_2 <= 1 && arg_2 > 0)
            {
                result = arg_1 * arg_2;
            }
            else if (arg_2 == 0)
            {
                Console.WriteLine("Non exchangeble currency");
            }
            return result;
        }

            
        
    }
}
