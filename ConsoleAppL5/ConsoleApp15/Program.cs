using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    class Program
    {
     //Алексей, просьба сверить с 11-м заданием в практике к 6-му уроку и указать что поменять....
        static void Main(string[] args)
        {
            Console.WriteLine("Enter sum of credit");
            int sum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter time of credit");
            int count = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter rate of credit");
            int rate = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter deposit money");
            int debet = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter deposit months");
            int count_d = Convert.ToInt32(Console.ReadLine());
            string status = Rating(rate,sum,count,debet,count_d);
            Console.WriteLine(status);
            Console.ReadKey();
        }
        static string Rating(int rates, int sums, int counts, int debets,int counts_d)
        {
            double rates_s = rates / 100;
            string total;
            double result_m = ((sums * rates_s) / counts);
            double leftovers_m = (result_m - (debets / counts_d));
            double result_t = (sums + sums * rates_s);
            int leftovers = (sums - debets);
            total = string.Format(@"Credit[C] amount: {0} Status: C-Sum: {1}, C-Rate: {2}%, 
C-Time: {3}, Returned: {4}, R-Time: {5},R/R-T: {6} Left: {7}", sums, result_t, rates,
                counts, debets, counts_d, leftovers_m, leftovers);

            return total;
        }
    }
}
