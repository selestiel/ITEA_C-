using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L8TaskB1
{
    class Program
    {
        static void Main(string[] args)
        {
            Car mycar = new Car("Zapo","white",15000);
            mycar.print();
            Console.WriteLine("Enter car parameters: Name: Color: Price:");
            Car mycara = new Car();
            string N = Console.ReadLine();
            string C = Console.ReadLine();
            int P = Convert.ToInt32(Console.ReadLine());
            mycara.input(N,C,P);
            mycara.print();
            mycar.print();
            Console.WriteLine("Set color: ");
            mycar.setcol(Console.ReadLine());
            mycar.print();
            mycar.ChangePrice(10);
            Car newCar = new Car();
            newCar = mycar;
            newCar.ChangePrice(10);
            Console.WriteLine("Set color: ");
            newCar.setcol(Console.ReadLine());
            newCar.print();



            Console.ReadKey();
        }
    }
    class Car
    {
        const string CompanyName = "Mark";
        private string name { get; set; }
        private string color { get; set; }
        private int price { get; set; }
        

        public Car()
        {
        }
        public Car(string n, string col, int pr)
        {
            name = n;
            color = col;
            price = pr;
        }
        public int ChangePrice(double x)
        {
            x = x / 100;
            price = price - (int)(price * x);
            return price;
        }
        public void  setcol(string clr)
        {
            color = clr;
        }
        public void input(string a, string c, int p)
        {
            name = a;
            color = c;
            price = p;
        }
        public void print()
        {
            Console.WriteLine("Car is {0}, color is {1}, price is {2}, Mark is {3}",name,color,price,CompanyName);
        }

        
    }
}
