using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello user: ");
            string user = Console.ReadLine();
            Console.WriteLine("Enter how many years you worked dear " + user + " .");
            int work_years = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter how much is your monthly salary dear " + user + " .");
            int salary = Convert.ToInt32(Console.ReadLine());
            double premium = 0;
            if(work_years < 5)
            {
                premium = 0.10;
            }
            else if(work_years >=5 && work_years < 10)
            {
                premium = 0.15;
            }
            else if(work_years >=10 && work_years< 15)
            {
                premium = 0.25;
            }
            else if(work_years>=15 && work_years < 20)
            {
                premium = 0.35;
            }
            else if(work_years>=20 && work_years < 25)
            {
                premium = 0.45;
            }
            else if(work_years >= 25)
            {
                premium = 0.5;
            }
            else
            {
                Console.WriteLine("Wrong year input try again!");
            }
            int premium_o = 0;
            switch (premium)
            {
                case 0.10:
                    premium_o = (int)(salary * premium);
                    break;
                case 0.15:
                    premium_o = (int)(salary * premium);
                    break;
                case 0.25:
                    premium_o = (int)(salary * premium);
                    break;
                case 0.35:
                    premium_o = (int)(salary * premium);
                    break;
                case 0.45:
                    premium_o = (int)(salary * premium);
                    break;
                case 0.50:
                    premium_o = (int)(salary * premium);
                    break;
                default:
                    Console.WriteLine("Wrong input;");
                    break;
            }
            int income = salary + premium_o;
            string str_f = @"
If your salary is: {0},
and  your work years is: {1},
then your premium is: {2},
and your total income monthly is: {3}";
            string str = string.Format(str_f,salary,work_years,premium_o,income);
            Console.WriteLine(str);
            Console.ReadKey();
        }
    }
}
