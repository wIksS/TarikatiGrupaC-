using Abstraction;
using Shapes.Engines;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class Program
    {
        static void Main(string[] args)
        {
            IRenderer renderer = new ConsoleRenderer();
            IReader reader = new ConsoleReader();
            Shape dot = new Dot(renderer);

            IGameEngine engine = new ConsoleEngine(dot, renderer, reader);
            engine.Start();

        }
    }
}
