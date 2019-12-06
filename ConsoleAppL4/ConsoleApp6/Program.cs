using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first years of deposit");
            int years = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter rate of deposit");
            double rate = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter amount of deposit");
            int amount = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            int total = 0;
            for(int i = 0; i <= years; ++i)
            {
                if(rate <0 && rate >100)
                {
                    break;
                }
                rate /= 100;
                sum = (int)(amount + (amount * rate));
                total += sum;
                int inr = (int)(amount * rate);
                Console.WriteLine("Yearly :{0} Total: {1} Years: {2} Increment: {3}", sum, total,i,inr);
            }
            Console.ReadKey();
        }
    }
}
