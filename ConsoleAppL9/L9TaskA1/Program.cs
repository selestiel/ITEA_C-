using System;

namespace L9TaskA1
{
    class Program
    {
        static void Main(string[] args)
        {
            Book B_A = new Book("Bleach");
            Book B_B = new Book("OnePiece");
            Book B_C = new Book("MeitanteiConan");
            Journal J_A = new Journal("Novel");
            Journal J_B = new Journal("Jump");
            Journal J_C = new Journal("Webtoon");

            IPrintable[] printable = {
                B_A,
                B_B,
                B_C,
                J_A,
                J_B,
                J_C
            };
            for (int i = 0; i < printable.Length; i++)
            {
                printable[i].Print();
            }
            for (int i = 0; i < printable.Length; i++)
            {
                
                B_A.PrintBook(printable[i]);
                B_B.PrintBook(printable[i]);
                B_C.PrintBook(printable[i]);
                J_A.PrintJournal(printable[i]);
                J_B.PrintJournal(printable[i]);
                J_C.PrintJournal(printable[i]);
            }



            Console.ReadKey();

        }
    }
    interface IPrintable
    {
        void Print();
   
    }
    class Book : IPrintable
    {
        public string Name { get; set; }
        public string Type = "Book";

        public void PrintBook(IPrintable printable)
        {
            if (printable is Book)
            {
                Console.WriteLine("B-Type: {0} B-Name: {1}", Type, Name);

            }
            else
            {
                Console.WriteLine();
            }
        }
        public void Print()
        {
            Console.WriteLine("B-Type: {0} B-Name: {1}", Type, Name);
        }

        public Book(string name)
        {
            Name = name;
        }
    }

    class Journal : IPrintable
    {
        public string Name { get; set; }
        public string Type = "Journal";

        public void PrintJournal(IPrintable printable)
        {
            if (printable is Journal)
            {
                Console.WriteLine("J-Type: {0} J-Name: {1}", Type, Name);
            }
            else
            {
                Console.WriteLine();
            }
        }
        public void Print()
        {
            Console.WriteLine("J-Type: {0} J-Name: {1}", Type, Name);
        }
        public Journal(string name)
        {
            Name = name;
        }
    }
}

