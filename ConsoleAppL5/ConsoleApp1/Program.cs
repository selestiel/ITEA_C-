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
            int counter = 0;
            while (counter < 3)
            {
                Console.WriteLine("Enter pin: ");
                string x = "1111";
                string y = Console.ReadLine();
                if (y == x)
                {
                    Console.WriteLine("Welcome User");
                    //goto end;
                    counter = 3;
                }
                else
                {
                    Console.WriteLine("Wrong pin");
                    counter++;
                    if (counter == 3)
                    {
                        Console.WriteLine("Card has been blocked!");
                    }

                }
            }
            //end:
            Console.ReadKey();
        }
    }
}
