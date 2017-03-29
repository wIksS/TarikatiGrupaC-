using Snake.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    public class ConsoleRenderer : IPositionalRenderer
    {
        public void WriteAtPosition(Coordinate coordinate, object input)
        {
            Console.SetCursorPosition(coordinate.X, coordinate.Y);
            Console.Write(input);
        }


        public void Clear()
        {
            Console.Clear();
        }

        public void PrintGameOver()
        {
            
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.White;
            Console.WriteLine(new string(' ', 100000));
            Console.ForegroundColor = ConsoleColor.Black;
            Console.SetCursorPosition(GlobalConstants.Center.X - GlobalConstants.GameOverText.Length /2, GlobalConstants.Center.Y);
            Console.WriteLine(GlobalConstants.GameOverText);
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine();
            }
        }
    }
}
