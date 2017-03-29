using Snake.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    public class Snake
    {
        public Dot Head
        {
            get;
            set;
        }

        public List<BaseDot> Body
        {
            get;
            set;
        }

        public void Render()
        {
            Head.Render();

            foreach (var dot in this.Body)
            {
                dot.Render();
            }
        }

        public void Move()
        {
            for (int i = 0; i < Body.Count - 1; i++)
            {
                Body[i].Position = new Coordinate(Body[i + 1].Position);
            }

            Body[Body.Count - 1].Position = new Coordinate(Head.Position);

            Head.Move();

            if (CheckIfDead())
            {
                throw new ArgumentException("We are dead and we cant play!!!");
            }
        }

        public void EatFood(IPositionalRenderer renderer)
        {
            this.Body.Add(new BaseDot(renderer,GlobalConstants.Symbol,new Coordinate(this.Body[this.Body.Count-1].Position)));
        }

        private bool CheckIfDead()
        {
            foreach (var dot in this.Body)
            {
                if (Head.Position == dot.Position)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
