using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    class Program
    {
        static void Main(string[] args)    
        {
            Console.WriteLine("Enter number:");
            int a = Convert.ToInt32(Console.ReadLine());
            string raw = "Number order is: ";
            int x = 0;
            string duo = loader(a, raw,ref x);
            Console.WriteLine("Here is : {0}",duo);
            Console.ReadKey();
        }
        static string loader(int arg, string box, ref int z)
        { 
            if (z != arg)
            {
                ++z;
                string d = box + " " + z;
                return loader(arg, d, ref z);
            }
            else
            {
                string f = box + " \nEnd list";
                return f;
            }           
        }
    }
}
