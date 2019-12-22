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
            Console.WriteLine(CR);
            Console.ReadKey();
        }
    }
    class ClassRoom
    {
        public ClassRoom(Pupil A, Pupil B, Pupil C, Pupil D)
        {
            A.Study();
            A.Write();
            B.Read();
            C.Read();
            D.Relax();
        }
    }
    class Pupil
    {
        public void Study()
        {

        }
        public void Read()
        {

        }
        public void Relax()
        {

        }
        public void Write()
        {

        }
    }
    class ExcelentPupil : Pupil
    {
        public new void Study()
        {

        }
        public new void Write()
        {

        }
    }
    class GoodPupil : Pupil
    {
        public new void Read()
        {

        }
    }
    class BadPupil : Pupil
    {
        public new void Relax()
        {
           
        }
    }
}
