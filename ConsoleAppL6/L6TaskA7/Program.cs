using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L6TaskA7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your array:");
            int[] main_arr = new int[10];
            for (int i =0; i <10;i++)
            {
                main_arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Enter your parameter to show array parts: from: to:");
            int s = Convert.ToInt32(Console.ReadLine());
            int f = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your array part from {0}: to: {1} is: ",s,f);
            int[] ssub_arr = Func_Arr(main_arr, s, f);
            for (int i = 0; i < ssub_arr.Length; i++)
            {
                Console.Write(" " + ssub_arr[i] + " ");
            }
            Console.WriteLine();
            Console.ReadKey();

        }
        static int[] Func_Arr(int[] array, int index, int count)
        {
            int z = count - index;
            int[] sub_arr = new int[array.Length];
            for (int i = index; i <= count; i++)
            {
                sub_arr[i] = array[i];
            }   

            return sub_arr;
        }
    }
}
