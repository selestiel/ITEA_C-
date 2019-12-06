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
            double centS = 0;
            double meterS = 0;
            Console.WriteLine("Enter meters: ");
            meterS = Convert.ToDouble(Console.ReadLine());
            centS = meterS * 100;
            Console.WriteLine("Result: " + centS);
            Console.ReadKey();
        }
    }
}
