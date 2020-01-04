using System;

namespace L8TaskA4
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] SC = { "Math", "Phys", "Lang", "Bio", "Prog" };
            Student A = new Student("Mark", "Wall", 2000, SC);
            Student B = new Student("Evan", "Mosk", 1995, SC);
            Student C = new Student("Cang", "Gool", 2002, SC);
            Student D = new Student("Bak", "Ram", 1998, SC);
            Student E = new Student("Chuck", "Slow", 1990, SC);
            Student[] SA = { A, B, C, D, E };
            Teacher AA = new Teacher("Joe", "Kram", 1950, SA);
            Teacher SS = new Teacher("Cole", "Woghn", 1960, SA);
            PeopleInfo ninfo = new PeopleInfo();
            Person[] AS = { AA, SS };
            ninfo.Get_Info(AS, SA, SC);
            Array.Reverse(SC);
            Console.WriteLine();
            Person[] BS = { SS, AA };
            ninfo.Get_Info(BS, SA, SC);
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
        public string[] StudyCources { get; set; }
        public void DisplayStudyCources()
        {
            for (int i = 0; i < StudyCources.Length; i++)
            {
                Console.WriteLine(" {0} ", StudyCources[i]);
            }
        }
        public Student(string N, string SN, int BY, string[] SC)
            : base(N, SN, BY)
        {
            StudyCources = SC;
        }
    }
    class Teacher : Person
    {
        Student[] StudentsArray { get; set; }
        public Teacher(string N, string SN, int BY, Student[] SA)
            : base(N, SN, BY)
        {
            StudentsArray = SA;
        }
    }
    class PeopleInfo
    {
        Person[] PeopleArray { get; set; }

        public void Get_Info(Person[] PST, Person[] PSS, string[] PSC)
        {
            for (int i = 0; i < PST.Length; i++)
            {
                Console.WriteLine("INFO: Born: {0}, Name: {1}, Surname: {2}", PST[i].BirthYear, PST[i].Name, PST[i].Surname);
            }
            for (int i = 0; i < PSS.Length; i++)
            {
                Console.WriteLine("INFO: Born: {0}, Name: {1}, Surname: {2}, Courses: {3}", PSS[i].BirthYear, PSS[i].Name, PSS[i].Surname, PSC[i]);
            }
        }
    }
}
