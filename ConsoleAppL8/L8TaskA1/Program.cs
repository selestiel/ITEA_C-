using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L8TaskA1
{
    class Program
    {
        static void Main(string[] args)
        {
            Tail dog_tail = new Tail("Fluffy", 30);
            Dog dog_A = new Dog("White", 5, dog_tail, "Roxy");
            dog_A.Info();
            Console.ReadKey();
        }
    }
    class Tail
    {
        public string Tail_type { get; set; }
        public int Tail_length { get; set; }

        public Tail(string type, int len)
        {
            Tail_type = type;
            Tail_length = len;
        }
    }
    class Tailed_Animal
    {
        public string Animal_color { get; set; }
        public int Animal_age { get; set; }
        public Tail Animal_Tail { get; set; }
        public Tailed_Animal(string col,int age,Tail a_tail)
        {
            Animal_color = col;
            Animal_age = age;
            Animal_Tail = a_tail;
        }
    }
    class Dog : Tailed_Animal
    {
        public string nickname { get; set; }
        public Dog(string col,int age, Tail a_tail,string name)
            :base(col,age,a_tail)
        {
            nickname = name;
        }
        public void Info()
        {
            Console.WriteLine(" Your Pet name is: {0}, of {1} color, of {2} years old, has {3} tail of {4} cm long ", nickname, Animal_color, Animal_age, Animal_Tail.Tail_type, Animal_Tail.Tail_length);
        }
    }

}
