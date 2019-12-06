using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter radius of circle");
            double radius = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter size of quad");
            double side = Convert.ToDouble(Console.ReadLine());
            const double Pi = 3.14;
            double resc = Pi * radius * radius;
            double resq = side * side;
            if(resc > resq)
            {
                Console.WriteLine("Square of circle is greater then quad " + resc);
            }else
            {
                Console.WriteLine("Square of quad is greater then circle " + resq);
            }
            Console.ReadKey();
        }
    }
}
