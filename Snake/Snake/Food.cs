using Snake.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    public class Food : BaseDot
    {
        public Food(IPositionalRenderer renderer, string symbol, Coordinate position)
            : base(renderer, symbol, position)
        {
        }
    }
}
