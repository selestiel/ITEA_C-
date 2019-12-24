using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L9TaskA1
{
    class Program
    {
        static void Main(string[] args)
        {
            IPrintable[] array = new IPrintable[10];
            for(int i=0; i < array.Length; i++)
            {
                array[i].Print();
            }
        }
    }
    interface IPrintable
    {
        void Print();

    }
    class Book : IPrintable
    {
        public void Print()
        {
            Console.WriteLine("Printing:");
        }

    }
    class Magazine : IPrintable
    {
       
        public void Print()
        {
            Console.WriteLine("Printing:");

        }
        public void Print_mag(IPrintable[] printable)
        {
            for(int i=0; i < printable.Length; i++)
            {

            }
        }
    }
}
