using Abstraction;
using Shapes.Engines;

namespace Shapes
{
    class Program
    {
        static public IRenderer renderer = new ConsoleRenderer();

        static void Main(string[] args)
        {
            IReader reader = new ConsoleReader();
            Shape dot = new Dot(renderer);
            IGameEngine engine = new ConsoleEngine(dot, renderer, reader);
            engine.Start();

        }
    }
}
