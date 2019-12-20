using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[5];
            array[0] = 1;
            array[1] = 3;
            array[2] = 5;
            array[3] = 7;
            array[4] = 9;
            int[] stat = { 1,2,3,4,5};
            for(int a = 0;a<array.Length ;a++)
            {
                Console.Write(array[a] + " ");
            }
            Console.WriteLine();
            for (int a = 0; a < stat.Length; a++)
            {
                Console.Write(stat[a] + " ");
            }

            Console.ReadKey();

        }
    }
}
