using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            int amount = 0;
            int price = 0;
            double disc = 0;
            int res = 0;
            Console.WriteLine("Enter amount of item"); 
            amount = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter price of item");
            price = Convert.ToInt32(Console.ReadLine());
            if (amount < 3)
            {
                disc = 0.1;
                res = (int)amount * (int)(price - (price * disc));
                Console.WriteLine("Total: " + res);
            }
            else if(amount > 3 && amount < 7)
            {
                disc = 0.2;
                res = (int)amount * (int)(price - (price * disc));
                Console.WriteLine("Total: " + res);
            }
            else if(amount > 7)
            {
                disc = 0.25;
                res = (int)amount * (int)(price - (price * disc));
                Console.WriteLine("Total: " + res);
            }
            Console.ReadKey();
        }
    }
}
