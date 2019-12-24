using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L6TaskA8
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[10];
            Random rnd = new Random();
            for(int i = 0; i < 10; i++)
            {
                array[i] = rnd.Next(1, 100);
            }
            for (int j = 0; j < 10; j++)
            {
                int[] a_arr = Fun_Arr_Inc(array, j);
                for(int c = 0; c < a_arr.Length; c++)
                {
                    Console.Write(a_arr[c] + " ");

                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
        static int[] Fun_Arr_Inc(int[] arr, int val)
        {
            int[] sub_arr = new int[arr.Length + val];
            arr.CopyTo(sub_arr, 0);
            
            sub_arr[0] = val;
            int[] sub_arr2 = new int[sub_arr.Length + 1];

            sub_arr.CopyTo(sub_arr2, 1);
            
            return sub_arr2;
        }
    }
}
