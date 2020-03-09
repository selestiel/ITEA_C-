using System;

namespace ConsoleApp4SN
{
    class Program
    {
        static void Main(string[] args)
        {
            int y = 1;
            int[] numbers = new int[3647];
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = y++;
            }
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write(numbers[i] + " ");

            }
            Console.WriteLine();
            Console.WriteLine("Simple numbers: ");
            int[] num = numbers;
            int z = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    if (num[j] != 0)
                    {
                        if (numbers[i] % num[j] != 0 & numbers[i]!=z)
                        {
                            z = num[i];
                            Console.Write(numbers[i] + " ");

                        }

                    }
                }
            }
        
        Console.WriteLine();
            Console.ReadKey();
        }
}
}
