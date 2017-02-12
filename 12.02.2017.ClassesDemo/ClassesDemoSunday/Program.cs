using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesDemoSunday
{
    class Program
    {
        static void Main(string[] args)
        {
            Position center = new Position();
            center.X = 0;
            center.Print();
            //center.X = -5;
            //Console.WriteLine(center.X);
            //center = ChangePosition(center);
            //Console.WriteLine(center.X + " "+center.Y);
        }

        static Position ChangePosition(Position position)
        {
            Position upRightPosition = new Position();
            //upRightPosition.X = position.X + 5;
            upRightPosition.Y = position.Y + 5;

            return upRightPosition;
        }
    }
}
