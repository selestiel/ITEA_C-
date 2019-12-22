using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L9TaskB1
{
    class Program
    {
        static void Main(string[] args)
        {
            Workman Wo_1 = new Workman("Word", 30, 10000, "fin");
            Console.WriteLine(Wo_1.ToString());
            Workman Wo_2 = new Workman("Ford", 40, 20000, "fin");
            Console.WriteLine(Wo_1.ToString());
            Workman Wo_3 = new Workman("Bord", 50, 30000, "fin");
            Console.WriteLine(Wo_1.ToString());
            Workman Wo_4 = new Workman("Lord", 60, 40000, "fin");
            Console.WriteLine(Wo_1.ToString());
            Director Di_A = new Director("Sora", 70, 50000, new Workman[] {Wo_1,Wo_2,Wo_3,Wo_4 });
            Director Di_B= new Director("Sora", 70, 50000, new Workman[] { Wo_1, Wo_2, Wo_3, Wo_4 });

            Employee[] employees = new Employee[]
            {
               Wo_1,
               Wo_2,
               Wo_3,
               Wo_4,
               Di_A,
               Di_B
            };

            Salary sal = new Salary();
            sal.salary_up(ref employees, 10);

            Console.ReadKey();

        }

    }
    class Employee
    {
        public string name { get; set; }
        public int age { get; set; }
        public double salary { get; set; }
        public override string ToString()
        {
            
            return "Employee: " + name + " " + age + " " + salary;
        }
        public Employee(string n, int a, double s)
        {
            name = n;
            age = a;
            salary = s;
        }
    }
    class Workman: Employee
    {
        public string Department { get; set; }
        public override string ToString()
        {
            string info = string.Format("Name: {0}, Age: {1}, Salary: {2}, Department {3}", name, age, salary, Department);
            return info;
        }
        public Workman(string name, int age, double salary, string dpt)
            : base(name, age, salary)
        {
            Department = dpt;
        }


    }
    class Director: Employee
    {
        string Direct { get; set; }
        public Workman[] listings { get; set; }
        public Director(string name, int age, double salary, Workman[] workarr)
        :base(name,age,salary)
        {
            listings = workarr;
        }
    }
    class Salary
    {
        public void salary_up (ref Employee[] z_list,double pcent)
        {
            Employee[] empl = new Employee[z_list.Length];
                for (int i = 0; i < z_list.Length; i++)
            {
                z_list[i].salary = z_list[i].salary * (100 + pcent) / 100; 
            }
        }
    }
}
