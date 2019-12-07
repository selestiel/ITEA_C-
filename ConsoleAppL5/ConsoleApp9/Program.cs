using System;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {
            int y = 1;
            int z = 5;
            int x = 9;
            Console.WriteLine(@"Reuslts O: {0}   {1}   {2}", x, y, z);
            M_Mult(out x);
            Console.WriteLine(@"Reuslts A: {0}   {1}   {2}", x, y, z);
            M_Mult(ref x, out y);
            Console.WriteLine(@"Reuslts B: {0}   {1}   {2}", x, y, z);
            M_Mult(ref x, ref y, out z);
            Console.WriteLine(@"Reuslts C: {0}   {1}   {2}", x, y, z);

            Console.ReadKey();

        }
        static void M_Mult(out int a)
        {
            a = 4;
            a *= 10;
        }

        static void M_Mult(ref int a, out int b)
        {
            b = 8;
            a *= 10;
            b *= 10;
        }
        static void M_Mult(ref int a, ref int b, out int c)
        {
            c = 15;
            a *= 10;
            b *= 10;
            c *= 10;
        }
    }
}
