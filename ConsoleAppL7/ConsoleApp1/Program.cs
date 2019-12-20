using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arra = method(10);
            int sumev = 0;
            int sum = 0;
            for (int i = 0; i < arra.Length; i++)
            {
                sum += arra[i];
                sumev += (arra[i] % 2 == 0 ? arra[i] : 0);
            }
            int midar = 0;
            midar = sum / arra.Length;
            Console.WriteLine("All that > midl arith: ");
            for (int i= 0; i < arra.Length; i++)
            {
                if(arra[i] > midar)
                {
                    Console.Write(arra[i]);
                }
            }
            Console.WriteLine();
            Console.WriteLine("Sum of all elem: {0} , sum of all even elem: {1}, Midl arithm:  {2} ", sum, sumev, midar);
            Console.ReadKey();
    }
        static int[] method(int val)
        {
            //Randomization of array with random values for array;
            Random rann = new Random();

            int[] arrn = new int[val];
            
            //filling array with random numbers;
            for (int i = 0; i < arrn.Length; i++)
            {
                arrn[i] = rann.Next(1,100);
            }
            // returning array;
            return arrn;
        }
    }
}
