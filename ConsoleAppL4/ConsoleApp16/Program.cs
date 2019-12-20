using System;

namespace ConsoleApp16
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write("*" + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine("Next->");

            double r = 7.0;
            double r_in = r - 0.4;
            double r_out = r + 0.4;

            for (double y = r; y >= -r; --y)
            {
                for (double x = -r; x < r_out; x += 0.5)
                {
                    double value = x * x + y * y;
                    if (value >= r_in * r_in && value <= r_out * r_out)
                    {
                        Console.Write('*');
                    }
                    else
                    {
                        Console.Write(' ');
                    }
                }
                Console.WriteLine();


            }
            Console.WriteLine();
            Console.ReadKey();
        }


    }
}
