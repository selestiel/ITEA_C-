using System;

namespace L11TaskA5
{
    class Program
    {
        static void Main(string[] args)
        {
            Accountant ACT = new Accountant();

      
            Console.WriteLine("Enter your position: ");
            string pos_name = Console.ReadLine();
            
            Console.WriteLine("Enter your work hours: ");
            int pos_hours = Convert.ToInt32(Console.ReadLine());
            Position POS = Position.NOT;

            CheckEntry(ref POS, pos_name);
            if (ACT.AskForBonus(POS, pos_hours) == true)
            {
                Console.WriteLine("Here is your Bonus.");
            }
            else
            {
                Console.WriteLine("You don't have a Bonus.");
            }

            Console.ReadKey();
        }
        static Position CheckEntry(ref Position N, string V)
        {
            if (V == Position.Accountant.ToString())
            {
                N = Position.Accountant;
            }
            else if (V == Position.Administrator.ToString())
            {
                N = Position.Administrator;
            }
            else if (V == Position.Auditor.ToString())
            {
                N = Position.Auditor;
            }
            else if (V == Position.BodyGuard.ToString())
            {
                N = Position.BodyGuard;
            }
            else if (V == Position.Director.ToString())
            {
                N = Position.Director;
            }
            else if (V == Position.Driver.ToString())
            {
                N = Position.Driver;
            }
            else if (V == Position.Engineer.ToString())
            {
                N = Position.Engineer;
            }
            else if (V == Position.Escort.ToString())
            {
                N = Position.Escort;
            }
            else if (V == Position.Guard.ToString())
            {
                N = Position.Guard;
            }
            else if (V == Position.Lawyer.ToString())
            {
                N = Position.Lawyer;
            }
            else if (V == Position.Manager.ToString())
            {
                N = Position.Manager;
            }
            else if (V == Position.President.ToString())
            {
                N = Position.President;
            }
            else if (V == Position.Programmer.ToString())
            {
                N = Position.Programmer;
            }
            else if (V == Position.Secretary.ToString())
            {
                N = Position.Secretary;
            }
            else if (V == Position.Technician.ToString())
            {
                N = Position.Technician;
            }
            else if (V == Position.ViceDirector.ToString())
            {
                N = Position.ViceDirector;
            }
            else if (V == Position.VicePresident.ToString())
            {
                N = Position.VicePresident;
            }
            else if (V == Position.Worker.ToString())
            {
                N = Position.Worker;
            }
            else if (V == Position.NOT.ToString())
            {
                Console.WriteLine("No Such a Position! GUARD!");
            }
            return N;
        }
        public enum Position
        {
            Worker = 160,
            Auditor = 192,
            Accountant = 164,
            Lawyer = 176,
            Programmer = 320,
            Engineer = 240,
            Technician = 160,
            Driver = 80,
            Guard = 200,
            Manager = 160,
            Administrator = 176,
            Director = 40,
            ViceDirector = 80,
            President = 160,
            VicePresident = 240,
            BodyGuard = 320,
            Escort = 120,
            Secretary = 160,
            NOT = 2147483647
        }
        public class Accountant
        {
            public bool AskForBonus(Position poser, int hours)
            {
                return ((int)poser < hours);
            }
        }
    }
}
