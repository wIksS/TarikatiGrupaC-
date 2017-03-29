using Snake.Common;
using Snake.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Snake
{
    public class SnakeEngine : IGameEngine
    {
        private readonly IPositionalRenderer renderer;
        private readonly IFoodGenerator foodGenerator;
        private readonly IReader reader;
        private Snake snake;
        private Food currentFood;

        public SnakeEngine(IPositionalRenderer renderer, IReader reader, IFoodGenerator foodGenerator)
        {
            this.reader = reader;
            this.renderer = renderer;
            this.foodGenerator = foodGenerator;
            currentFood = foodGenerator.GenerateFood(renderer);

            this.snake = SnakeFactory.CreateSnake(renderer);
            this.snake.Body.Reverse();
        }

        public void Start()
        {
            while (true)
            {
                ChangeDirection();
                CheckIfFoodIsEaten();
                this.snake.Render();
                this.foodGenerator.RenderFood();

                try
                {
                    this.snake.Move();
                }
                catch (ArgumentException)
                {
                    this.Terminate();
                    return;
                }

                Thread.Sleep(100);
                renderer.Clear();
            }
        }

        private void CheckIfFoodIsEaten()
        {
            if (this.currentFood.Position == this.snake.Head.Position)
            {
                this.currentFood = foodGenerator.GenerateFood(renderer);
                this.snake.EatFood(renderer);
            }
        }

        public void Terminate()
        {
            renderer.PrintGameOver();
        }

        private void ChangeDirection()
        {
            string keyPressed = reader.ReadKey();
            if (keyPressed != null)
            {
                switch (keyPressed)
                {
                    case "LeftArrow":
                    snake.Head.ChangeDirection(Directions.Left);
                    break;
                    case "RightArrow":
                    snake.Head.ChangeDirection(Directions.Right);
                    break;
                    case "DownArrow":
                    snake.Head.ChangeDirection(Directions.Down);
                    break;
                    case "UpArrow":
                    snake.Head.ChangeDirection(Directions.Up);
                    break;
                    default:
                    break;
                }
            }
        }
    }
}
