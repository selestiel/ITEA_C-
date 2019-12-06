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
            Console.WriteLine("Введите какой бывает погода: ");
            string pogoda = (Console.ReadLine());
            switch (pogoda)
            {
                case ("Ясная"):
                    Console.WriteLine("Clear");
                    break;
                case ("Солнечная"):
                    Console.WriteLine("Sunny");
                    break;
                case ("Дождливая"):
                    Console.WriteLine("Rainy");
                    break;
                case ("Туманная"):
                    Console.WriteLine("Smog");
                    break;
                case ("Снежная"):
                    Console.WriteLine("Snowy");
                    break;
                case ("Облачная"):
                    Console.WriteLine("Cloudy");
                    break;
                case ("Гроза"):
                    Console.WriteLine("Thunderstorms");
                    break;
                case ("Ветренная"):
                    Console.WriteLine("Windy");
                    break;
                case ("Безветренная"):
                    Console.WriteLine("Windless");
                    break;
                case ("Холодная"):
                    Console.WriteLine("Cold");
                    break;
                default:
                    Console.WriteLine("Wrong input no such words");
                    break;
            }
            Console.ReadKey();
        }
    }
}
