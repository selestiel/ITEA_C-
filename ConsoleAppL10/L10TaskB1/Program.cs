using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L10TaskB1
{
    class Program
    {
        static void Main(string[] args)
        {
            Unicorn Uni_A = new Unicorn(1000, 12, 10);

            Unicorn Uni_B = new Unicorn(1000, 10, 12);
            ICharacter A_char = Uni_A;
            ICharacter B_char = Uni_B;
            B_char.Attack(A_char, 10, B_char);
            A_char.Attack(B_char, 10,A_char);
            Console.WriteLine("Health after 1 hit: PlA {0}  PlB {1}",A_char.health,B_char.health);
            Console.ReadKey();
        }
    }
    public interface ICharacter
    {
        /// <summary>
        /// Health of Char
        /// </summary>
        double health { get; set; }
        /// <summary>
        /// Agility of Char
        /// </summary>
        double agility { get; set; }
        /// <summary>
        /// Strength of Char
        /// </summary>
        double strength { get; set; }
        /// <summary>
        /// Char Attack on Char
        /// </summary>
        /// <param name="Aim"></param>
        /// <param name="distance"></param>
        /// <param name="D_Aim"></param>
        void Attack(ICharacter Aim, double distance, ICharacter D_Aim);
        
        double Damage(ICharacter Dealer);

    }
    class Unicorn : ICharacter
    {
        public double agility { get; set; }
        public double health { get; set; }
        public double strength { get; set; }
        public Unicorn(double heal, double str, double agi)
        {
            health = heal;
            strength = str;
            agility = agi;
            
        }
        public void Attack(ICharacter aim, double distance, ICharacter D_Aim)
        {
            double distance_b = 10;
            if(distance <= distance_b)
            {
                if (D_Aim.strength == aim.agility)
                {
                    aim.health -= Damage(D_Aim);
                }
                else if (D_Aim.strength < aim.agility)
                {
                    aim.health -= Damage(D_Aim) - (D_Aim.agility - aim.strength);
                }
                else
                {
                    aim.health -= Damage(D_Aim) + (aim.strength - D_Aim.agility);
                }


            }
            else
            {
                aim.health = aim.health;
            }
        }
        public double Damage(ICharacter dealer)
        {
            double damage = dealer.agility + dealer.strength;
            return damage;
        }

    }
}
