using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] A = new string[4];
            string[] B = new string[4];
            Console.WriteLine("Enter array: ");
            for(int a = 0; a < A.Length; a++)
            {
                A[a] = Console.ReadLine();
            } //array input
            Console.WriteLine("Array A as is: ");
            for (int c = 0; c < A.Length; c++)
            {
                Console.Write(A[c] + " ");
            } //array show
            int counter = 0;
            for (int i = A.Length - 1; i >= 0; i--)
            {
                B[counter] = A[i];
                counter++;
            } //Reversing array
            Console.WriteLine();
            Console.WriteLine("Array B is: ");
            for (int c = 0; c < B.Length; c++)
            {
                Console.Write(B[c] + " ");
            }
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
