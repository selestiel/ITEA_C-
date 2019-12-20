using System;

namespace L6TaskA6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter array size: ");
            int a = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[a];
            Random rand = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next(1, 100);
            }
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Max value in array is: {0}", Maxed(array));
            Console.WriteLine("Min value in array is: {0}", Minimied(array));
            Console.WriteLine("Sum values in array is: {0}", Summary(array));
            Console.WriteLine("Mid arithmetical value in array is: {0}", Midarith(array));
            Console.WriteLine(" Odd values in array is: ");
            Odds(array);
            Console.ReadKey();
        }
        static int Maxed(int[] arg)
        {
            int max = 0;
            for (int i = 0; i < arg.Length; i++)
            {
                if (max < arg[i])
                {
                    max = arg[i];
                }
            }

            return max;
        }
        static int Minimied(int[] arg)
        {
            int min = 0;
            for (int i = 0; i < arg.Length; i++)
            {
                if (min > arg[i])
                {
                    min = arg[i];
                }
            }

            return min;
        }
        static int Summary(int[] arg)
        {
            int sum = 0;
            for (int i =0; i < arg.Length; i++)
            {
                sum += arg[i];
            }
            return sum;
        }
        static int Midarith(int[] arg)
        {
            int mid = 0;

            for(int i = 0; i < arg.Length; i++)
            {
                mid += arg[i];
            }
            mid = mid / arg.Length;
            return mid;
        }
        static void Odds(int[] arg)
        {
            for ( int i = 0; i < arg.Length; i++)
            {
                if (arg[i] % 2 != 0)
                {
                    Console.Write(" " + arg[i] + " ");
                }
            }
        }

    }
}
