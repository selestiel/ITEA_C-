using System;

namespace L6TaskA5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your profit/month for 12 months: ");
            int[] profit = new int[12];
            for (int i = 0; i < profit.Length; i++)
            {
                profit[i] = Convert.ToInt32(Console.ReadLine());
            } //filling array profit
            Console.WriteLine();
            for (int i = 0; i < profit.Length; i++)
            {
                Console.Write(" {0} ", profit[i]);
            } // showing array profit
            Console.WriteLine();
            Console.WriteLine("Maxed profit in: {0}",Maxed(profit));
            Console.WriteLine("Minimum profit in: {0}", Minis(profit));

            Console.ReadKey();
        }
        static int Maxed(int[] arg)
        {
            Console.WriteLine("Choose your region start: ");
            int S = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Choose your region start: ");
            int E = Convert.ToInt32(Console.ReadLine());
            int i = 0;
            int max = 0;
            for (i = S; i < E; i++)
            {
                if (max < arg[i])
                {
                    max = arg[i];
                    Console.WriteLine("{0}", i);
                }
                
            }
            Console.WriteLine("Month of high: {0}", i);

            return max;
        }
        static int Minis(int[] arg)
        {
            Console.WriteLine("Choose your region start: ");
            int S = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Choose your region start: ");
            int E = Convert.ToInt32(Console.ReadLine());
            int i = 0;
            int min = 0;
            for (i = S; i < E; i++)
            {
                if (min > arg[i])
                {
                    min = arg[i];
                }
            }
            Console.WriteLine("Month of low: {0}", i);

            return min;
        }

    }
}
