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
            Console.WriteLine("Guess what vehicle has 4 wheels and 2 long pipes moves on electricity and it's comunity vessel");
            string a = Console.ReadLine();
            switch (a)
            {
                case "Trollybus":
                    Console.WriteLine("Right");
                    break;
                case "GiveUp":
                    Console.WriteLine("Right");
                    break;
                default:
                    Console.WriteLine("Think Again");
                    break;
            }
            Console.ReadKey();
        }
    }
}
