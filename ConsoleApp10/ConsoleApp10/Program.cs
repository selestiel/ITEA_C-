using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your angle in grad.: ");
            int angle = Convert.ToInt32(Console.ReadLine());
            double angle_sin = 0;
          //  double angle_cos = 0;
         //   double angle_tan = 0;
            double angle_rad = (angle * 180) / 3.1416;  //convert to radians
            angle_sin = Math.Sin(angle);
           // angle_cos = Math.Cos(angle);
           // angle_tan = Math.Tan(angle);
            string res = "Your angle is: {0}, sin: {1}";//, cos: {2}, tan: {3}";
            string str = string.Format(res, angle, angle_sin);//,angle_cos,angle_tan);
            Console.WriteLine(str); // Result output
            Console.ReadKey();

        }
    }
}
