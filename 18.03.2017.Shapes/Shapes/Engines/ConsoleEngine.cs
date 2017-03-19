using Abstraction;
using Shapes.Engines;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Shapes
{
    public class ConsoleEngine : IGameEngine
    {
        private IRenderer renderer;
        private IReader reader;
        private Shape shape;

        public ConsoleEngine(Shape shape, IRenderer renderer, IReader reader)
        {
            this.renderer = renderer;
            this.reader = reader;
            this.shape = shape;
        }

        public void Start()
        {
            while (true)
            {
                if (Console.KeyAvailable)
                {
                    var keyInfo = Console.ReadKey(true);
                    if (keyInfo.Key == ConsoleKey.LeftArrow)
                    {
                        this.shape.Direction.ChangeDirectionLeft();
                    }
                    if (keyInfo.Key == ConsoleKey.RightArrow)
                    {
                        this.shape.Direction.ChangeDirectionRight();
                    }
                    if (keyInfo.Key == ConsoleKey.UpArrow)
                    {
                        this.shape.Direction.ChangeDirectionTop();
                    }
                    if (keyInfo.Key == ConsoleKey.DownArrow)
                    {
                        this.shape.Direction.ChangeDirectionDown();
                    }
                }

                this.shape.Draw();
                this.shape.Move();
                Thread.Sleep(100);
                Console.Clear();
            }
        }

        public void Exit()
        {
            throw new NotImplementedException();
        }
    }
}
