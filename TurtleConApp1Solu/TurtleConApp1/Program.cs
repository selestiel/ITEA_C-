using Microsoft.SmallBasic.Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurtleConApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console;
            Turtle.Speed = 50;
            Turtle.Show();
            Turtle.Move(150);
            Turtle.TurnLeft();
            Turtle.Move(150);
            Turtle.TurnLeft();
            Turtle.Move(150);
            Turtle.TurnLeft();
            Turtle.Move(150);
            Turtle.Turn(-135);
            Turtle.Move(210);
            //Turtle.MoveTo(150, 150);
            Turtle.Turn(-135);
            Turtle.Move(150);
            Turtle.Turn(-135);
            Turtle.Move(210);
        }   
    }
}
