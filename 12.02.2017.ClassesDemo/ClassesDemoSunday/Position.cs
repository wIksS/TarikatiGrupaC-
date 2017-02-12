using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesDemoSunday
{
    public class Position
    {
        public Position()
        {
            X = 55;
            Y = 60;
            Console.WriteLine("Initializing position!");
        }

        public int X { get; set; }

        public int Y { get; set; }

        public void Print()
        {
            Console.WriteLine("X -> " + this.X + " Y -> " +this.Y);
        }
    }
}
