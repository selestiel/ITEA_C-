using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L12TaskA3
{
    class Program
    {
        static void Main(string[] args)
        {
            Price[] prices = new Price[2];
            for (int i = 0; i < prices.Length; i++)
            {
                Console.WriteLine("Enter shop name: ");
                prices[i].shop_name = Console.ReadLine();
                Console.WriteLine("Enter item name: ");
                prices[i].item_name = Console.ReadLine();
                Console.WriteLine("Enter item price: ");
                prices[i].item_price = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Choose shop: ");
            string cshop = Console.ReadLine();
            GetItem(prices,cshop);

            Console.ReadKey();
        }
        static void GetItem(Price[] price,string shop)
        {
            try
            {
                int count = 0;
                for (int i = 0; i < price.Length; i++)
                {
                    if (price[i].shop_name == shop)
                    {
                        count++;
                        price[i].Info();
                    }
                }
                if (count == 0)
                {
                    throw new Exception("Item of this shop are not exist!");
                }
            }
            catch (Exception exception) 
            {
                Console.WriteLine(exception.Message);
            } 
        }
    }
    struct Price
    {
        public string item_name { get; set; }
        public string shop_name { get; set; }
        public int item_price { get; set; }

        public void Info() 
        {
            Console.WriteLine("Shop: {0} Item: {1} Price: {2}",shop_name,item_name,item_price);
        }

    }
}
