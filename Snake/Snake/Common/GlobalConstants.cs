using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    public static class GlobalConstants
    {
        public static readonly int ConsoleWidth = 70;

        public static readonly int ConsoleHeight = 30;

        public static readonly Coordinate Center = new Coordinate(ConsoleWidth / 2, ConsoleHeight / 2);

        public static readonly string Symbol = "*";

        public static readonly string HeadSymbol = "@";

        public static readonly string FoodSymbol = "#";

        public static readonly int InitialSnakeBodySize = 10;

        public static readonly string GameOverText = "You cant play become better and come back!";
    }
}
