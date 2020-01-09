using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L11TaskB1
{
    class Program
    {
        static void Main(string[] args)
        {
            Article[] shops = new Article[5];
            Store store = new Store(shops);
            Console.WriteLine("Enter item name you are looking for: ");
            string item_names = Console.ReadLine();
            Console.WriteLine("Enter item ID you are looking for: ");
            int id = Convert.ToInt32(Console.ReadLine());


            for (int i = 0; i < shops.Length; i++)
            {
                shops[i].Info();
            }

            Console.ReadKey();
            
        }
    }
    class Article
    {
        private string item_name { get; set; }
        private string shop_name { get; set; }
        private int item_price { get; set; }

        public Article(string IN, string SN, int IP)
        {
            item_name = IN;
            shop_name = SN;
            item_price = IP;
        }

        public void Info()
        {
            Console.WriteLine(@"Shop name : {0}   Item name: {1}   Item price: {2}",shop_name,item_name,item_price);
        }
    }
    class Store
    {
        private Article[] shop;
        public Article this[int index]
        {
            get
            {
                return shop[index];
            }
            set
            {
                shop[index] = value;
            }
        }

        public Store(Article[] shops)
        {
            shop = shops;
        }
    }
}
