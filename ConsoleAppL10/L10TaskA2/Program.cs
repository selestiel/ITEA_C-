using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L10TaskA2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool exit = true;

            Console.WriteLine("What would you like to convert?");
            Console.WriteLine("If Celsius to Farenheit Type 'C' vice versa 'F'...");
            while (exit == true)
            {
                char input = Convert.ToChar(Console.ReadLine());
                switch (input)
                {
                    case 'c':
                    case 'C':
                        Convertor.CelsiusToFarenheit(Console.ReadLine());
                        break;
                    case 'f':
                    case 'F':
                        Convertor.FarenheitToCelsius(Console.ReadLine());
                        break;
                    default:
                        break;
                }
                Console.WriteLine("Would you like to repeat? type 'true' / 'false' ");
                exit = Convert.ToBoolean(Console.ReadLine());
            }
        }
    }
    static class Convertor
    {
        public static void CelsiusToFarenheit(string temperatureCelsius)
        {
            double farenheit = ((Convert.ToDouble(temperatureCelsius) * 9) / 5) + 32;
            Console.WriteLine("In farenheaits is: {0}",farenheit);
        }
        public static void FarenheitToCelsius(string temperatureFarenheit)
        {
            double celsius = (((Convert.ToDouble(temperatureFarenheit) - 32) * 5 )/ 9);
            Console.WriteLine("In celsius is: {0}",celsius);
        }
    }
}
