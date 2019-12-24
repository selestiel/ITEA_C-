using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L9TaskA3
{
    class Program
    {
        static void Main(string[] args)
        {
            Info inf = new Info();
            inf.HeadLine();
            inf.DocumentContent();
            inf.Footer();
            Console.ReadKey();
        }
    }
    abstract class Document
    {
        void HeadLine()
        {

        }
        void DocumentContent()
        {

        }
        void Footer()
        {

        }
    }
    class Info : Document
    {
        public void HeadLine()
        {
            Console.WriteLine("Header");
        }
        public void DocumentContent()
        {
            Console.WriteLine("Content");
        }
        public void Footer()
        {
            Console.WriteLine("Bottom");
        }
    }
}
