using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Direction
    {
        private string direction = "left";

        public void ChangeDirectionLeft()
        {
            this.direction = "left";
        }

        public void ChangeDirectionRight()
        {
            this.direction = "right";
        }

        public void ChangeDirectionTop()
        {
            this.direction = "top";
        }

        public void ChangeDirectionDown()
        {
            this.direction = "down";
        }

        public Position GetNewPosition(Position position)
        {
            if (direction == "left")
            {
                position = new Position(position.Row, position.Col - 1);
            }
            if (direction == "right")
            {
                position = new Position(position.Row, position.Col + 1);
            }
            if (direction == "top")
            {
                position = new Position(position.Row - 1, position.Col);
            }
            if (direction == "down")
            {
                position = new Position(position.Row + 1, position.Col);
            }
            return position;
        }
    }
}
