using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter circle length: ");
            int L = Convert.ToInt32(Console.ReadLine());
            const double Pi = 3.14;
            double R = L / (2 * Pi);
            double S = 2 * Pi * R * R;
            //L = 2 * Pi *R;
            //S = 2 * Pi * R * R;
            string str_f = "If length is {0}, then radius is {1}, and square is {2}";
            string str = string.Format(str_f, L, R, S);
            Console.WriteLine(str);
            Console.ReadKey();

        }
    }
}
