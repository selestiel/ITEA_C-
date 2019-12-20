using System;

namespace L7TaskA3
{
    class Program
    {
        static void Main(string[] args)
        {
            Bank_Account BaAc = new Bank_Account(0, 0, 0, 0, 0, 0);
            Console.WriteLine("Enter your account opening date: ");
            Console.WriteLine("Year:  Month:  Day:  ");
            Console.WriteLine("Total Days passed from opening ~: {0}",
                BaAc.Days_pass(Convert.ToInt32(Console.ReadLine()),
                Convert.ToInt32(Console.ReadLine()),
                Convert.ToInt32(Console.ReadLine())));
            Console.WriteLine();
            Console.WriteLine("Enter your amount of deposit:  and deposit rate: ");
            Console.WriteLine("Your Current deposit amount: ");
            BaAc.dep_sum(Convert.ToDouble(Console.ReadLine()), Convert.ToDouble(Console.ReadLine()));
            Console.WriteLine();
            Console.WriteLine("Your Account info: ");
            BaAc.get_info();
            Console.WriteLine();


            Console.WriteLine("If you want to check how much you get from investing: ");
            Console.WriteLine("Enter your amount: rate: and amount of years: ");
            Console.WriteLine("You'll get ~: {0}",
            BaAc.inv_sum(Convert.ToDouble(Console.ReadLine()),
            Convert.ToDouble(Console.ReadLine()),
            Convert.ToInt32(Console.ReadLine())));

            Bank_Account BaAcc = new Bank_Account(2000, 8, 21, 5000.0, 0.15, 25);
            Console.ReadKey();
        }
    }
    class Bank_Account
    {
        int opening_date_year { get; set; }
        int opening_date_month { get; set; }
        int opening_date_day { get; set; }

        double rate { get; set; }
        double sum { get; set; }

        public void get_info()
        {
            Console.WriteLine("Your Account Data:");
            Console.WriteLine("Date Year: {0}, Month: {1}, Day: {2} Sum: {3}, Rate: {4}, Total Deposit: {5}"
                , opening_date_year, opening_date_month, opening_date_day, sum, rate, dep_sum(sum, rate));
        }
        public double dep_sum(double dep_sum_am, double perc_rate)
        {
            int D = DateTime.Now.Year - opening_date_year;
            sum = dep_sum_am;
            rate = perc_rate;
            double newsum = sum + (D * (sum * rate)) / 100 ;

            Console.WriteLine("Your current deposit is: {0}", newsum);
            return newsum;
        }
        public double inv_sum(double dep_sum_am, double perc_rate, int year)
        {
            int D = year;
            sum = dep_sum_am;
            rate = perc_rate;
            double resum = sum + (D * (sum * rate)) / 100;
            return resum;
        }
        public int Days_pass(int year, int month, int day)
        {
            opening_date_year = year;
            opening_date_month = month;
            opening_date_day = day;
            int Y = DateTime.Now.Year - year;
            int M = DateTime.Now.Month - month;
            int D = DateTime.Now.Day - day;
            int res = Y * 365 + M * 30 + D;
            Console.WriteLine("Account opened at: {0} , {1} , {2}"
                , opening_date_year, opening_date_month, opening_date_day);
            Console.WriteLine("Time passed from opening: Years: {0}, Months: {1}, Days: {2}", Y, M, D);
            return res;
        }
        public int Days_pass()
        {
            int Y = DateTime.Now.Year - opening_date_year;
            int M = DateTime.Now.Month - opening_date_month;
            int D = DateTime.Now.Day - opening_date_day;
            int res = Y * 365 + M * 30 + D;
            Console.WriteLine("Account opened at: {0} , {1} , {2}"
                , opening_date_year, opening_date_month, opening_date_day);
            Console.WriteLine("Time passed from opening: Years: {0}, Months: {1}, Days: {2}", Y, M, D);
            return res;
        }
        public Bank_Account(int year, int month, int day, double ssum, double rrate, int inv_year)
        {
            opening_date_year = year;
            opening_date_month = month;
            opening_date_day = day;
            sum = ssum;
            rate = rrate;
            get_info();
            Days_pass();
            inv_sum(sum, rate, inv_year);

        }
    }
}
