using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L8TaskA3
{
    class Program
    {
        static void Main(string[] args)
        {
            ExcelentPupil S = new ExcelentPupil();
            GoodPupil A = new GoodPupil();
            GoodPupil B = new GoodPupil();
            BadPupil C = new BadPupil();
            ClassRoom CR = new ClassRoom(S, A, B, C);
            Console.WriteLine();
            Console.ReadKey();
        }
    }
    class ClassRoom
    {
        public ClassRoom( ExcelentPupil A, GoodPupil B, GoodPupil C, BadPupil D)
        {
            Console.WriteLine("Student A");
            A.Study();
            A.Write();

            Console.WriteLine("Student B");
            B.Read();

            Console.WriteLine("Student C");
            C.Write();

            Console.WriteLine("Student D");
            D.Relax();
        }
    }
    class Pupil
    {
        public void Study()
        {

            Console.WriteLine("Has to study");
        }
        public void Read()
        {

            Console.WriteLine("Has to read");
        }
        public void Relax()
        {

            Console.WriteLine("Has to Relax");
        }
        public void Write()
        {

            Console.WriteLine("Has to write");
        }
    }
    class ExcelentPupil : Pupil
    {
        public new void Study()
        {
            Console.WriteLine("Studies");
        }
        public new void Write()
        {

            Console.WriteLine("Writes");
        }
    }
    class GoodPupil : Pupil
    {
        public new void Read()
        {

            Console.WriteLine("Reads");
        }
    }
    class BadPupil : Pupil
    {
        public new void Relax()
        {

            Console.WriteLine("Relaxes");
        }
    }
}
