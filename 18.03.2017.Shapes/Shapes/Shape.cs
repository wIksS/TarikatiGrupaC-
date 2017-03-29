using Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public abstract class Shape
    {
        public Shape(IRenderer renderer)
        {
            this.Renderer = renderer;
            this.Direction = new Direction();
        }

        public IRenderer Renderer { get; set; }

        public Direction Direction { get; set; }

        public Position Position { get; set; }

        public abstract void Draw();

        public abstract void Move();
    }
}
