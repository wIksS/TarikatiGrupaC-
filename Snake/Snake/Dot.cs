using Snake.Common;
using Snake.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    public class Dot : BaseDot
    {
        private readonly IDirection direction;

        public Dot(IPositionalRenderer renderer, IDirection direction, string symbol, Coordinate position)
            : base(renderer, symbol, position)
        {
            this.direction = direction;
        }

        public void ChangeDirection(Directions direction)
        {
            this.direction.ChangeDirection(direction);
        }

        public void Move()
        {
            this.Position = this.direction.GetNewPosition(this.Position);
        }
    }
}
