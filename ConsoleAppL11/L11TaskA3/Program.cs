using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L11TaskA3
{
    class Program
    {
        static void Main(string[] args)
        {
            MyStruct MS = new MyStruct();
            MS.change = "not changed";
            Console.WriteLine(MS.change);
            StructTaker(MS);
            Console.WriteLine(MS.change);
            MyClass MC = new MyClass();
            MC.change = "not changed";
            Console.WriteLine(MC.change);
            ClassTaker(MC);
            Console.WriteLine(MC.change);
            Console.ReadLine();
            

        }
        static void ClassTaker(MyClass myclass)
        {
            myclass.change = "changed";
        }
        static void StructTaker(MyStruct mystruct)
        {
            mystruct.change = "changed";
        }
    }
    class MyClass
    {
        public string change { get; set; }

    }
    struct MyStruct
    {
        public string change { get; set; }

    }
}
