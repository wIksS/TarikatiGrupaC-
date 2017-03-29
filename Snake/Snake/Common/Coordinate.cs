using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Snake.Common;

namespace Snake
{
    public class Coordinate : IEquatable<Coordinate>
    {
        public Coordinate(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        public Coordinate(Coordinate coord)
        {
            this.X = coord.X;
            this.Y = coord.Y;
        }

        public int X
        {
            get;
            set;
        }

        public int Y
        {
            get;
            set;
        }

        public static Coordinate GetRandomPosition(int width, int height)
        {
            Random rand = new Random();

            return new Coordinate(rand.Next(0,width),rand.Next(0,height));
        }

        public bool Equals(Coordinate other)
        {
            if (other.X == this.X && other.Y == this.Y)
            {
                return true;
            }

            return false;
        }

        public static bool operator ==(Coordinate first, Coordinate second)
        {
            if (first.X == second.X && first.Y == second.Y)
            {
                return true;
            }

            return false;
        }

        public static bool operator !=(Coordinate first, Coordinate second)
        {
            if (first.X != second.X || first.Y != second.Y)
            {
                return true;
            }

            return false;
        }
    }
}
