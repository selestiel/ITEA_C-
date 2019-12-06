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
            double disc = 0;
            double price = 0;
            double amount = 0;
            double result = 0;
            Console.WriteLine("Enter amount you want to buy in grams: ");
            amount = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter price per kilogram: ");
            price = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter discount you wish to get in percents: ");
            disc = Convert.ToDouble(Console.ReadLine());
            disc = disc / 100;
            if (disc >= 1.00)
            {
                Console.WriteLine(" Aren't you a little too bold man?....");
                Console.ReadKey();
                return;

            }
            else result = (amount / 1000) * (price - (price * disc));
            Console.WriteLine("You have to pay: " + result + " UAH");
            Console.ReadKey();
        }
    }
}
