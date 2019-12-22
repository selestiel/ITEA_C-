using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L8TaskA4
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] SC = { "Math", "Phys", "Lang" };

            Student A = new Student("Mark", "Wall", 2000,SC);
            Student B = new Student("Evan", "Mosk",1995,SC);
            Student C = new Student("Cang","Gool",2002,SC);
            Student D = new Student("Bak","Ram",1998,SC);
            Student E = new Student("Chuck","Slow",1990,SC);
            Student[] SA = { A, B, C, D, E };
            Teacher AA = new Teacher("Joe", "Kram", 1950, SA);
            Teacher SS = new Teacher("Cole", "Woghn", 1960, SA);
            PeopleInfo ninfo = new PeopleInfo();
            Person[] PS = { AA, SS };
            ninfo.Get_Info(PS);
            Console.ReadKey();
        }
    }
    class Person
    {
        public int BirthYear { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public Person(string N, string SN, int BY)
        {
            Name = N;
            Surname = SN;
            BirthYear = BY;
        }
    }
    class Student : Person
    {
        public string[] StudyCources
        {
            get
            {
                return StudyCources;
            }
            set
            {
                for (int i = 0; i < StudyCources.Length;i++)
                {
                StudyCources[i] = Convert.ToString(value);
                }
            }
        }
        public void DisplayStudyCources()
        {
            for (int i = 0; i < StudyCources.Length; i++)
            {
                Console.WriteLine(" {0} ", StudyCources[i]);
            }
        }
        public Student(string N,string SN, int BY,string[] SC)
            :base(N,SN,BY)
        {
            StudyCources = SC;
        }
    }
    class Teacher : Person
    {
        Student[] StudentsArray
        {
            get
            {
                return StudentsArray;
            }
            set
            {
                StudentsArray = value;
                
            }

        }
        public Teacher(string N,string SN, int BY, Student[] SA)
            :base(N,SN,BY)
        {
            StudentsArray = SA;
        }
    }
    class PeopleInfo
    {
        Person[] PeopleArray
        {
            get
            {
                return PeopleArray;
            }
            set
            {
                PeopleArray = value;
            }
        }
        public void Get_Info(Person[] PSP)
        {
            for(int i = 0;  i < PSP.Length; i++)
            {
                Console.WriteLine(PSP[i]);
            }
            
        }
    }
}
