using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L12TaskC1
{
class Program
    {
        static void Main(string[] args)
        {
            MyClass1 myClass1 = new MyClass1();

            MyClass Class1 = new MyClass();
            MyClass Class2 = new MyClass();
            MyClass Class3 = new MyClass();
            MyClass Class4 = new MyClass();

            MyClass[] myClassesArray = new MyClass[]
            {
                Class1,
                Class2,
                Class3,
                Class4
            };

            myClass1.MyProperty = myClassesArray;

            for (int i = 0; i < myClass1.MyProperty.Length; i++)
            {
                myClass1.MyProperty[i].MyProperty_from_MeClass = i;
            }

            for (int i = 0; i < myClass1.MyProperty.Length; i++)
            {
                myClass1.MyProperty[i].Method();
            }

            Console.ReadKey();
            Console.WriteLine();
        }
    }

    class MyClass1
    {
        public MyClass[] MyProperty { get; set; }
    }
    class MyClass
    {
        public int MyProperty_from_MeClass { get; set; }

        public void Method()
        {
            Console.WriteLine(MyProperty_from_MeClass);
        }
    }
}
