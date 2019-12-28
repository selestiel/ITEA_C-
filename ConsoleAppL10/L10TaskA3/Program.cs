using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L10TaskA3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter string to count: ");
            string input = Console.ReadLine();
            Console.WriteLine("Enter from what sign to count: ");
            int enumer = Convert.ToInt32(Console.ReadLine());
            StringExtension.StrCount(input, enumer);


            Console.ReadKey();
        }
    }
    static class StringExtension
    {
        public static int StrCount(string arg_a, int arg_b)
        {
            char[] sub_arr = new char[arg_a.Length];
            foreach (char elem in arg_a)
            {
                for (int i = 0; i < arg_a.Length; i++)
                {
                    sub_arr[i] = elem;
                }
            }
            char[] sub_arr2 = new char[sub_arr.Length];
            int count = 0;
            int j = 0;
            for (int i =arg_b; i < sub_arr.Length; i++)
            {
                sub_arr2[j++] = sub_arr[i];
                count++;
            }
            Console.WriteLine("Signs till end of string is: {0}",count);
            return count;
        }
    }
}
