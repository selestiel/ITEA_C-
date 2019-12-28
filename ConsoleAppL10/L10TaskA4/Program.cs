using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L10TaskA4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Some_Class.CreateRNDMZ_Array(10);

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(" " + array[i] + " ");
            }
            Console.WriteLine();
            array.ExtendedMethod_sortArray();
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(" " + array[i] + " ");
            }
            Console.ReadKey();
        }
    }
    static class Some_Class
    {
        public static int[] ExtendedMethod_sortArray( this int[] arg_a)
        {
            for(int i = 0; i < arg_a.Length; i++)
            {
                Array.Sort(arg_a);
            }
            return arg_a;
        }
        public static int[] CreateRNDMZ_Array(int arg_a)
        {
            int[] array = new int[arg_a];
            Random rnd = new Random();
            for(int i =0; i < array.Length; i++)
            {
                array[i] = rnd.Next(1, 100);
            }
            return array;
        }
    }
}
