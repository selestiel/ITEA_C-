using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L11TaskA1
{
    class Program
    {
        static void Main(string[] args)
        {
            Notebook nb = new Notebook("Base", "ITEA", 15);
            Notebook nba = new Notebook("Adv", "ITEA", 30);
            Notebook nbb = new Notebook("Base", "++", 150);
            Notebook nbc = new Notebook("Adv", "ITEA", 1500);
            nb.Info();
            nba.Info();
            nbb.Info();
            nbc.Info();
            Console.ReadKey();
        }
    }
    struct Notebook
    {
        string model { get; set; }
        string maker { get; set; }
        int price { get; set; }

        public void Info()
        {
            Console.WriteLine("Model: {0} Manufacturer: {1} Price: {2}",model,maker,price);
        }
        public Notebook(string Mod, string Mak, int Pr)
        {
            model = Mod;
            maker = Mak;
            price = Pr;
        }
    }
}
