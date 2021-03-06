﻿using System;

namespace L8TaskA2
{
    class Program
    {

        static void Main(string[] args)
        {
            const double pi = 3.14;
            Pyramid P = new Pyramid();
            Cylinder C = new Cylinder();
            Ball B = new Ball();
            Box n_box = new Box();
            n_box.Drawer_Volume = 5000.0;
            P.pi_Base = 5.0;
            P.pi_Height = 8.0;
            P.Volume = P.Get_P_Volume();
            C.C_Height = 2.0;
            C.C_radius = 3.0;
            C.Volume = C.Get_C_Volume(pi);
            B.B_Radius = 4.0;
            B.Volume = B.Get_B_Volume(pi);
            Console.WriteLine("Volumes are: pi {0}  cy {1}  ba {2}", P.Get_Volume(), C.Get_Volume(), B.Get_Volume());
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
            double P_Volume = ((1 * pi_Base * pi_Height)/3);
            return P_Volume;
        }

    }
    class Cylinder : Shape
    {
        public double C_radius { get; set; }
        public double C_Height { get; set; }

        public double Get_C_Volume(double P)
        {
            double C_Volume = (P * C_radius * C_radius * C_Height);

            return C_Volume;
        }
    }
    class Ball : Shape
    {
        public double B_Radius { get; set; }
        public double Get_B_Volume(double P)
        {
            double B_Volume = ((4 / 3) * P * B_Radius * B_Radius * B_Radius);
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
            int counter = 0;
            do
            {
                if ((volume + sm_shape.Volume) <= Drawer_Volume)
                {
                    check = true;
                    volume += sm_shape.Volume;
                    counter++;
                }
                else
                {
                    check = false;
                    Console.WriteLine(Convert.ToString(check));
                    Console.WriteLine("No Space!");
                }
            }
            while (check != false);
            Console.WriteLine("This shape can be input {0} times.", counter);

            return check;

        }
    }
}
