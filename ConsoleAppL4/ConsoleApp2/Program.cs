using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Answer on the following question: " + 
                @"On colorful pages many holidays are stored");
            string answ = "Calendar";
            string guess = "";
            int counter = 0; 
            while (guess != answ)
            {
                guess = Console.ReadLine();

                counter++;

                if (counter > 9)
                {
                    Console.WriteLine("0 tries left you failed!");
                    break;
                    
                }
                else if (guess == answ)
                {
                    Console.WriteLine("You guessed right!");
                    break;
                }
                else
                {
                    Console.WriteLine("You have " + (10-counter) +" tries left");
                    continue;
                }
                
            }
            Console.ReadKey();
        }
    }
}
