using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L12TaskA2
{
    class Program
    {
        static void Main(string[] args)
        {
            Worker[] worker = new Worker[5];
            for (int i = 0; i < worker.Length; i++)
            {
                Console.WriteLine("Enter name and initials: ");
                worker[i].name = Console.ReadLine();
                Console.WriteLine("Enter position: ");
                worker[i].pos = Console.ReadLine();
                Console.WriteLine("Enter year of duty entrance: ");
                try
                {
                    worker[i].year = Convert.ToDateTime(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Wrong year data.");
                }
            }
            Array.Sort(worker);
            Console.WriteLine("Enter exp years: ");
            int exp = Convert.ToInt32(Console.ReadLine());
            int year = DateTime.Now.Year;
            for (int i = 0; i < worker.Length; i++)
            {
                int w_year = Convert.ToInt32(worker[i].year);
                if (exp > (year - w_year))
                {
                    Console.WriteLine(worker[i].name);
                }
            }
            Console.ReadKey();
        }
    }
    class Worker
    {
        public string name { get; set; }
        public string pos { get; set; }
        public DateTime year { get; set; }
        
    }
}
