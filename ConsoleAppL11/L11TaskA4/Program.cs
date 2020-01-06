using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L11TaskA4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter string and set color: ");
            string mystr = Console.ReadLine();
            Console.WriteLine("Set Color: (0-15)");
            Console.WriteLine();
            MyStClass.Set_color((MyStClass.Color)Convert.ToInt32(Console.ReadLine()));
            MyStClass.Print(mystr);
            Console.ReadKey();
        }
    }
    static class MyStClass
    {
        public enum Color
        {
            White = ConsoleColor.White,
            Blue = ConsoleColor.Blue,
            Red = ConsoleColor.Red,
            Yellow = ConsoleColor.Yellow,
            Black = ConsoleColor.Black,
            Green = ConsoleColor.Green,
            DarkCyan = ConsoleColor.DarkCyan,
            Magenta = ConsoleColor.Magenta,
            DarkRed = ConsoleColor.DarkRed,
            DarkMagenta = ConsoleColor.DarkMagenta,
            DarkBlue = ConsoleColor.DarkBlue,
            DarkGreen = ConsoleColor.DarkGreen,
            Gray = ConsoleColor.Gray,
            DarkYellow = ConsoleColor.DarkYellow,
            Cyan = ConsoleColor.Cyan,
            DarkGray = ConsoleColor.DarkGray
        }
        public static void Set_color(MyStClass.Color clr)
        {
            switch (clr)
            {
                case Color.White:
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
                case Color.Blue:
                    Console.ForegroundColor = ConsoleColor.Blue;
                    break;
                case Color.DarkBlue:
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    break;
                case Color.Red:
                    Console.ForegroundColor = ConsoleColor.Red;
                    break;
                case Color.DarkRed:
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    break;
                case Color.Green:
                    Console.ForegroundColor = ConsoleColor.Green;
                    break;
                case Color.DarkGreen:
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    break;
                case Color.Gray:
                    Console.ForegroundColor = ConsoleColor.Gray;
                    break;
                case Color.DarkGray:
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    break;
                case Color.Cyan:
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    break;
                case Color.DarkCyan:
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    break;
                case Color.Magenta:
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    break;
                case Color.DarkMagenta:
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    break;
                case Color.Yellow:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    break;
                case Color.DarkYellow:
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    break;
                case Color.Black:
                    Console.ForegroundColor = ConsoleColor.Black;
                    break;
                default:
                    break;
            }
        }
        public static void Print(string argstr)
        { 
            Console.WriteLine(argstr);    
        }
    }
}
