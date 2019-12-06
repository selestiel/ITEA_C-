using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int k = 0;
           
            for (int i = 0;i <= 5; i++)
            { 
                for (int d = 5; d > k; d--)
                {
                    Console.Write(" ");
                    
                }
                for (int j =-1; j < k; j++)
                {
                    Console.Write("*");
                }
                for (int j = 0; j<k; j++)
                {
                    Console.Write("*");   
                }
                

                k++;
                Console.WriteLine();
            }
            for (int i = -1; i <= 5; i++)
            {
                for (int d = 5; d > k; d--)
                {
                    Console.Write(" ");

                }
                for (int j = -1; j < k; j++)
                {
                    Console.Write("*");
                }
                for (int j = 0; j < k; j++)
                {
                    Console.Write("*");
                }


                k--;
                Console.WriteLine();
            }

            
            Console.ReadKey();
        }
    }
}
