using Snake.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    public class BaseDot
    {
        public BaseDot(IPositionalRenderer renderer, string symbol, Coordinate position)
        {
            this.Renderer = renderer;
            this.Symbol = symbol;
            this.Position = position;
        }

        protected IPositionalRenderer Renderer
        {
            get;
            private set;
        }

        public Coordinate Position
        {
            get;
            set;
        }

        public string Symbol
        {
            get;
            set;
        }

        public void Render()
        {
            Renderer.WriteAtPosition(this.Position, this.Symbol);
        }
    }
}
