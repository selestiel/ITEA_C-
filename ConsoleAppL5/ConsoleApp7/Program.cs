using System;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your year of birth: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter your month of birth: ");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Age(x,y));
            Console.ReadKey();
        }
        static string Age(int a,int b)
        {
            int year = DateTime.Now.Year;
            int month = DateTime.Now.Month;
            int z = year - a;
            int zz = month - b;
            string result = string.Format("Your age is: {0} years {1} months", z, zz);
            return result;
        }
    }
}
