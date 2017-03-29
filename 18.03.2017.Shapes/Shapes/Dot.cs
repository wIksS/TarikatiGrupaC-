using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abstraction;

namespace Shapes
{
    public class Dot : Shape
    {
        private readonly string dotSymbol = "@";

        public Dot(IRenderer renderer)
            : base(renderer)
        {
            this.Position = new Position(10, 10);
        }

        public override void Draw()
        {
            this.Renderer.WriteAt(dotSymbol, this.Position);
        }

        public override void Move()
        {
            Direction.GetNewPosition(this.Position);
        }
    }
}
