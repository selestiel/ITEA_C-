using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            Kitty Funny = new Kitty();
            Funny.Name_Prop = "Tama";
            Funny.Age_Prop = 3;
            Funny.Color_skin_Prop = "Black";
            Funny.Color_eye_Prop = "Green";
            Console.WriteLine("Kitty: Age: {0}, Name: {1}, Skin: {2}, Eyes: {3}",Funny.Age_Prop,Funny.Name_Prop, Funny.Color_skin_Prop, Funny.Color_eye_Prop) ;
            Funny.Nyau(3);
            Console.ReadKey();
        }
        class Kitty
        {
            string Name;
            public string Name_Prop
            {
                get
                {
                    return Name;
                }
                set
                {
                    Name = value;
                }
            }
            int Age;
            public int Age_Prop
            {
                get
                {
                    return Age;
                }
                set
                {
                    Age = value;
                }
            }
            string Color_skin;
            public string Color_skin_Prop
            {
                get
                {
                    return Color_skin;
                }
                set
                {
                    Color_skin = value;
                }
            }
            string Color_eye;
            public string Color_eye_Prop
            {
                get
                {
                    return Color_eye;
                }
                set
                {
                    Color_eye = value;
                }
            }

            public void Nyau(int arg)
            {
                for (int i = 0; i < arg; i++)
                {
                    Console.WriteLine(" Nyau ");
                }
            }
        }
    }

}
