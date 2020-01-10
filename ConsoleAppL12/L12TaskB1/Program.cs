using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L12TaskB1
{
    class Program
    {
        static void Main(string[] args)
        {
            MyClassGC Char = new MyClassGC("NPC", 50, 50, 50, 50, 50, 12.5, 12.5, 12.5, 500000);
            Console.WriteLine(GC.GetTotalMemory(true));
            Console.WriteLine(GC.MaxGeneration);
            Console.WriteLine(GC.GetGeneration(Char));

            Console.ReadKey();

        }
        class MyClassGC
        {
            string name { get; set; }
            int strength { get; set; }
            int vitality { get; set; }
            int agility { get; set; }
            int dexterity { get; set; }
            int wisdom { get; set; }
            double evasion { get; set; }
            double accuracy { get; set; }
            double crit { get; set; }
            long money { get; set; }
            public MyClassGC(string n,int str, int vit, int agi, int dex, int wis, double eva, double acc, double cri, long mon)
            {
                name = n;
                strength = str;
                vitality = vit;
                agility = agi;
                dexterity = dex;
                wisdom = wis;
                evasion = eva;
                accuracy = acc;
                crit = cri;
                money = mon;
            }
        }
    }
}
