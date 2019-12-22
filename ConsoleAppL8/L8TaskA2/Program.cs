using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L8TaskA2
{
    class Program
    {
        static void Main(string[] args)
        {
            Pyramid P = new Pyramid();
            Cylinder C = new Cylinder();
            Ball B = new Ball();
            Box n_box = new Box();
            n_box.Drawer_Volume = 5000.0;
            P.pi_Base = 5.0;
            P.pi_Height = 3.0;
            P.Volume = P.Get_P_Volume();
            C.C_Height = 7.0;
            C.C_radius = 2.0;
            C.Volume = C.Get_C_Volume();
            B.B_Radius = 14.0;
            B.Volume = B.Get_B_Volume();
            Console.WriteLine("Adding balls: ");
            n_box.Add(B);
            Console.WriteLine("Adding cylinders: ");
            n_box.Add(C);
            Console.WriteLine("Adding pyramids: ");
            n_box.Add(P);
            Console.ReadKey();
        }
    }
    class Shape
    {
        public double Volume { get; set; }

        public double Get_Volume()
        {
            return Volume;
        }

    }
    class Pyramid : Shape
    {
        public double pi_Base { get; set; }
        public double pi_Height { get; set; }
        public double Get_P_Volume()
        {
            double pi_Volume = (((1/3) * pi_Base * pi_Height))/1000;
            return pi_Volume;
        }

    }
    class Cylinder : Shape
    {
        public double C_radius { get; set; }
        public double C_Height { get; set; }
        public double Get_C_Volume()
    {
        double C_Volume = (Math.PI * C_radius * C_radius * C_Height)/1000;
            return C_Volume;
    }
    }
    class Ball : Shape
    {
        public double B_Radius { get; set; } 
        public double Get_B_Volume()
        {
            double B_Volume = ((4 / 3) * Math.PI * Math.Pow(B_Radius, 3))/1000;
            return B_Volume;
        }
    }
    class Box
    {
        public double Drawer_Volume { get; set; }
        public bool Add(Shape sm_shape)
        {
            double volume = 0;
            bool check;
            if((volume + sm_shape.Volume) < Drawer_Volume)
            {
                check = true;
            }
            else
            {
                check = false;
            }
            int counter = 0;
            while (check)
            {
                volume += sm_shape.Volume;
                counter++;
            }
            Console.WriteLine("This shape can be input {0} times.", counter);
            return check;
        }
    }
}
