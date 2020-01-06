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
        }
    }
    class Article
    {
        string item_name { get; set; }
        string shop_name { get; set; }
        int item_price { get; set; }


    }
    class Store
    {
        Article[] shop;
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
    }
}
