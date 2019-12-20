using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter string: ");
            string string_A = Console.ReadLine();
            Console.WriteLine("String A as is: {0}", string_A);
            string string_B = string.Concat(Reverse_String_Array(string_A));
            Console.WriteLine("Reversed string A: {0}", string_B);
            Console.ReadKey();
        }
        static char[] Reverse_String_Array(string array)
        {
            char[] reverse = new char[array.Length];
            int counter = 0;
            for (int i = array.Length - 1; i >= 0; i--)
            {
                reverse[counter] = array[i];
                counter++;
            }
            return reverse;
        }
    }
}
            