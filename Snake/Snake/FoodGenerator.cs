using Snake.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    public class FoodGenerator : IFoodGenerator
    {
        private Food food;

        public Food GenerateFood(IPositionalRenderer renderer)
        {
            this.food = new Food(renderer, GlobalConstants.FoodSymbol, Coordinate.GetRandomPosition(GlobalConstants.ConsoleWidth, GlobalConstants.ConsoleHeight));

            this.RenderFood();

            return this.food;
        }

        public void RenderFood()
        {
            this.food.Render();
        }
    }
}
