using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L6TaskA9
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] array = new int[10, 10];
            Random rand = new Random();
            for(int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++) 
                {
                    array[i, j] = rand.Next(1, 100);
                }
                
            }
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {

                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }
            int[] sum_str = new int[10];
            
            int sum_dia = 0;
            int c = 0;
            for (int i = 0; i< 10; i++)
            {
                int sum_stb = 0;
                for (int j = 0; j < 10; j++)
                {
                    sum_stb += array[i, j];
                    if (i == j)
                    {
                        sum_dia += array[i, j];
                    }
                    if (j == 0)
                    {
                        sum_str[0] += array[i, j];
                    }
                    if (j == 1)
                    {
                        sum_str[1] += array[i, j];
                    }
                    if (j == 2)
                    {
                        sum_str[2] += array[i, j];
                    }
                    if (j == 3)
                    {
                        sum_str[3] += array[i, j];
                    }
                    if (j == 4)
                    {
                        sum_str[4] += array[i, j];
                    }
                    if (j == 5)
                    {
                        sum_str[5] += array[i, j];
                    }
                    if (j == 6)
                    {
                        sum_str[6] += array[i, j];
                    }
                    if (j == 7)
                    {
                        sum_str[7] += array[i, j];
                    }
                    if (j == 8)
                    {
                        sum_str[8] += array[i, j];
                    }
                    if (j == 9)
                    {
                        sum_str[9] += array[i, j];
                    }
                }
                Console.Write("Sum str {0} is: {1} ", i, sum_stb);

                
            }
            Console.WriteLine("sum stb is: ");
            for(int i = 0; i<10;i++){
                Console.WriteLine(sum_str[i] + " ");
            }
            Console.WriteLine("Sum diag is: {0}", sum_dia);



            Console.ReadKey();
        }
    }
}
